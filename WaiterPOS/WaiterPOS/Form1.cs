using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WaiterPOS
{
    public partial class Form1 : Form
    {
        // Data
        private List<Table> tables;
        private List<MenuItem> menuItems;
        private Table currentTable;

        // Colors
        private Color colorPrimary = Color.FromArgb(41, 128, 185);
        private Color colorSuccess = Color.FromArgb(39, 174, 96);
        private Color colorDanger = Color.FromArgb(192, 57, 43);

        public Form1()
        {
            InitializeComponent();
            InitializeData();
            ShowTablesView();
        }

        private void InitializeData()
        {
            tables = new List<Table>();
            for (int i = 1; i <= 6; i++) // 6 Tables
            {
                tables.Add(new Table(i));
            }

            menuItems = new List<MenuItem>
            {
                new MenuItem("Шопска салата", "Предястия", 8.50m),
                new MenuItem("Овчарска салата", "Предястия", 9.50m),
                new MenuItem("Пържени картофи", "Предястия", 5.00m),
                new MenuItem("Пилешка пържола", "Основни", 12.00m),
                new MenuItem("Свински ребра", "Основни", 18.50m),
                new MenuItem("Кюфтета на скара", "Основни", 10.00m),
                new MenuItem("Кока Кола", "Напитки", 3.50m),
                new MenuItem("Минерална вода", "Напитки", 2.00m),
                new MenuItem("Бира Каменица", "Напитки", 4.00m),
                new MenuItem("Палачинка с шоколад", "Десерти", 6.00m),
                new MenuItem("Сладолед", "Десерти", 5.50m)
            };
        }

        private void RefreshTablesUI()
        {
            // Update table buttons based on occupancy
            btnTable1.BackColor = tables[0].IsOccupied ? colorDanger : colorSuccess;
            btnTable2.BackColor = tables[1].IsOccupied ? colorDanger : colorSuccess;
            btnTable3.BackColor = tables[2].IsOccupied ? colorDanger : colorSuccess;
            btnTable4.BackColor = tables[3].IsOccupied ? colorDanger : colorSuccess;
            btnTable5.BackColor = tables[4].IsOccupied ? colorDanger : colorSuccess;
            btnTable6.BackColor = tables[5].IsOccupied ? colorDanger : colorSuccess;
        }

        private void ShowTablesView()
        {
            RefreshTablesUI();
            pnlOrder.Visible = false;
            pnlTables.Visible = true;
            currentTable = null;
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            Button clickedBtn = sender as Button;
            if (clickedBtn != null)
            {
                // Extract table number from button text (e.g., "Маса 1")
                int tableNo = int.Parse(clickedBtn.Text.Replace("Маса ", "").Trim());
                Table table = tables.FirstOrDefault(t => t.Number == tableNo);
                if (table != null)
                {
                    OpenTableOrder(table);
                }
            }
        }

        private void OpenTableOrder(Table table)
        {
            currentTable = table;
            lblTableInfo.Text = $"Маса {table.Number}";
            pnlTables.Visible = false;
            pnlOrder.Visible = true;
            LoadMenuItems("Предястия"); // Load first category by default
            RefreshOrderList();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Button btnCat = sender as Button;
            if (btnCat != null)
            {
                LoadMenuItems(btnCat.Text);
            }
        }

        private void LoadMenuItems(string category)
        {
            flpItems.Controls.Clear();
            var items = menuItems.Where(m => m.Category == category).ToList();
            
            foreach (var item in items)
            {
                Button btnItem = new Button
                {
                    Text = $"{item.Name}\n{item.Price:C}",
                    BackColor = colorPrimary,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Cursor = Cursors.Hand,
                    Width = 180,
                    Height = 80,
                    Margin = new Padding(5)
                };
                
                btnItem.Click += (s, e) => AddItemToOrder(item);
                flpItems.Controls.Add(btnItem);
            }
        }

        private void AddItemToOrder(MenuItem item)
        {
            var existingItem = currentTable.CurrentOrder.FirstOrDefault(o => o.Item.Name == item.Name && string.IsNullOrEmpty(o.Notes));
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                currentTable.CurrentOrder.Add(new OrderItem(item));
            }
            RefreshOrderList();
        }

        private void RefreshOrderList()
        {
            dgvOrder.Rows.Clear();
            foreach (var orderItem in currentTable.CurrentOrder)
            {
                dgvOrder.Rows.Add(orderItem.Item.Name, orderItem.Quantity, orderItem.Notes);
            }
        }

        private OrderItem GetSelectedOrderItem()
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                int index = dgvOrder.SelectedRows[0].Index;
                if (index >= 0 && index < currentTable.CurrentOrder.Count)
                {
                    return currentTable.CurrentOrder[index];
                }
            }
            return null;
        }

        private void BtnIncreaseQty_Click(object sender, EventArgs e)
        {
            var item = GetSelectedOrderItem();
            if (item != null)
            {
                item.Quantity++;
                RefreshOrderList();
            }
        }

        private void BtnDecreaseQty_Click(object sender, EventArgs e)
        {
            var item = GetSelectedOrderItem();
            if (item != null)
            {
                item.Quantity--;
                if (item.Quantity <= 0)
                {
                    currentTable.CurrentOrder.Remove(item);
                }
                RefreshOrderList();
            }
        }

        private void BtnAddNote_Click(object sender, EventArgs e)
        {
            var item = GetSelectedOrderItem();
            if (item != null && !string.IsNullOrWhiteSpace(txtNote.Text))
            {
                if (string.IsNullOrEmpty(item.Notes))
                {
                    item.Notes = txtNote.Text;
                }
                else
                {
                    item.Notes += ", " + txtNote.Text;
                }
                txtNote.Clear();
                RefreshOrderList();
            }
            else if (item == null)
            {
                MessageBox.Show("Моля, изберете артикул от списъка, към който да добавите бележка.", "Информация");
            }
        }

        private void BtnAddCustomItem_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtCustomItemPrice.Text, out decimal price) && !string.IsNullOrWhiteSpace(txtCustomItemName.Text))
            {
                var customItem = new MenuItem(txtCustomItemName.Text, "Извън меню", price);
                currentTable.CurrentOrder.Add(new OrderItem(customItem, 1, ""));
                txtCustomItemName.Text = "Име на артикул";
                txtCustomItemPrice.Text = "Цена";
                RefreshOrderList();
            }
            else
            {
                MessageBox.Show("Невалидна цена или име на артикул.", "Грешка");
            }
        }

        private void BtnSendToKitchen_Click(object sender, EventArgs e)
        {
            if (currentTable == null || currentTable.CurrentOrder.Count == 0)
            {
                MessageBox.Show("Поръчката е празна!", "Грешка");
                return;
            }

            try
            {
                string filename = $"KitchenTicket_Table{currentTable.Number}_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.WriteLine($"--- КУХНЕНСКИ БОН ---");
                    writer.WriteLine($"Маса: {currentTable.Number}");
                    writer.WriteLine($"Час: {DateTime.Now:HH:mm:ss}");
                    writer.WriteLine($"---------------------");
                    
                    foreach (var item in currentTable.CurrentOrder)
                    {
                        string line = $"{item.Quantity}x {item.Item.Name}";
                        if (!string.IsNullOrEmpty(item.Notes))
                        {
                            line += $"  >> {item.Notes} <<";
                        }
                        writer.WriteLine(line);
                    }
                    writer.WriteLine($"---------------------");
                }

                MessageBox.Show($"Успешно изпратено към кухнята!\n(Запазено като {filename})", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentTable.CurrentOrder.Clear();
                ShowTablesView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при създаване на файла: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowTablesView();
        }

        private void TxtCustomItemName_GotFocus(object sender, EventArgs e)
        {
            if (txtCustomItemName.Text == "Име на артикул")
                txtCustomItemName.Text = "";
        }

        private void TxtCustomItemPrice_GotFocus(object sender, EventArgs e)
        {
            if (txtCustomItemPrice.Text == "Цена")
                txtCustomItemPrice.Text = "";
        }
    }
}
