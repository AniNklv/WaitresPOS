namespace WaiterPOS
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTables = new System.Windows.Forms.Panel();
            this.pnlFloorPlan = new System.Windows.Forms.Panel();
            this.btnTable6 = new System.Windows.Forms.Button();
            this.btnTable5 = new System.Windows.Forms.Button();
            this.btnTable4 = new System.Windows.Forms.Button();
            this.btnTable3 = new System.Windows.Forms.Button();
            this.btnTable2 = new System.Windows.Forms.Button();
            this.btnTable1 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.pnlOrderList = new System.Windows.Forms.Panel();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.flpItems = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCatPredyastiya = new System.Windows.Forms.Button();
            this.btnCatOsnovni = new System.Windows.Forms.Button();
            this.btnCatNapitki = new System.Windows.Forms.Button();
            this.btnCatDeserti = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnSendToKitchen = new System.Windows.Forms.Button();
            this.btnAddCustomItem = new System.Windows.Forms.Button();
            this.txtCustomItemPrice = new System.Windows.Forms.TextBox();
            this.txtCustomItemName = new System.Windows.Forms.TextBox();
            this.lblCustom = new System.Windows.Forms.Label();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblMod = new System.Windows.Forms.Label();
            this.btnDecreaseQty = new System.Windows.Forms.Button();
            this.btnIncreaseQty = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTableInfo = new System.Windows.Forms.Label();
            this.pnlTables.SuspendLayout();
            this.pnlFloorPlan.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            this.pnlOrderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.flpCategories.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTables
            // 
            this.pnlTables.Controls.Add(this.pnlFloorPlan);
            this.pnlTables.Controls.Add(this.lblTitle);
            this.pnlTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTables.Location = new System.Drawing.Point(0, 0);
            this.pnlTables.Name = "pnlTables";
            this.pnlTables.Size = new System.Drawing.Size(1232, 801);
            this.pnlTables.TabIndex = 0;
            // 
            // pnlFloorPlan
            // 
            this.pnlFloorPlan.AutoScroll = true;
            this.pnlFloorPlan.BackColor = System.Drawing.Color.White;
            this.pnlFloorPlan.Controls.Add(this.btnTable6);
            this.pnlFloorPlan.Controls.Add(this.btnTable5);
            this.pnlFloorPlan.Controls.Add(this.btnTable4);
            this.pnlFloorPlan.Controls.Add(this.btnTable3);
            this.pnlFloorPlan.Controls.Add(this.btnTable2);
            this.pnlFloorPlan.Controls.Add(this.btnTable1);
            this.pnlFloorPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFloorPlan.Location = new System.Drawing.Point(0, 60);
            this.pnlFloorPlan.Name = "pnlFloorPlan";
            this.pnlFloorPlan.Size = new System.Drawing.Size(1232, 741);
            this.pnlFloorPlan.TabIndex = 1;
            // 
            // btnTable6
            // 
            this.btnTable6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnTable6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnTable6.ForeColor = System.Drawing.Color.White;
            this.btnTable6.Location = new System.Drawing.Point(650, 400);
            this.btnTable6.Name = "btnTable6";
            this.btnTable6.Size = new System.Drawing.Size(140, 140);
            this.btnTable6.TabIndex = 5;
            this.btnTable6.Text = "Маса 6";
            this.btnTable6.UseVisualStyleBackColor = false;
            this.btnTable6.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnTable5
            // 
            this.btnTable5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnTable5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnTable5.ForeColor = System.Drawing.Color.White;
            this.btnTable5.Location = new System.Drawing.Point(400, 400);
            this.btnTable5.Name = "btnTable5";
            this.btnTable5.Size = new System.Drawing.Size(140, 140);
            this.btnTable5.TabIndex = 4;
            this.btnTable5.Text = "Маса 5";
            this.btnTable5.UseVisualStyleBackColor = false;
            this.btnTable5.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnTable4
            // 
            this.btnTable4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnTable4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnTable4.ForeColor = System.Drawing.Color.White;
            this.btnTable4.Location = new System.Drawing.Point(150, 400);
            this.btnTable4.Name = "btnTable4";
            this.btnTable4.Size = new System.Drawing.Size(140, 140);
            this.btnTable4.TabIndex = 3;
            this.btnTable4.Text = "Маса 4";
            this.btnTable4.UseVisualStyleBackColor = false;
            this.btnTable4.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnTable3
            // 
            this.btnTable3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnTable3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnTable3.ForeColor = System.Drawing.Color.White;
            this.btnTable3.Location = new System.Drawing.Point(650, 100);
            this.btnTable3.Name = "btnTable3";
            this.btnTable3.Size = new System.Drawing.Size(140, 140);
            this.btnTable3.TabIndex = 2;
            this.btnTable3.Text = "Маса 3";
            this.btnTable3.UseVisualStyleBackColor = false;
            this.btnTable3.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnTable2
            // 
            this.btnTable2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnTable2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnTable2.ForeColor = System.Drawing.Color.White;
            this.btnTable2.Location = new System.Drawing.Point(400, 100);
            this.btnTable2.Name = "btnTable2";
            this.btnTable2.Size = new System.Drawing.Size(140, 140);
            this.btnTable2.TabIndex = 1;
            this.btnTable2.Text = "Маса 2";
            this.btnTable2.UseVisualStyleBackColor = false;
            this.btnTable2.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnTable1
            // 
            this.btnTable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnTable1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnTable1.ForeColor = System.Drawing.Color.White;
            this.btnTable1.Location = new System.Drawing.Point(150, 100);
            this.btnTable1.Name = "btnTable1";
            this.btnTable1.Size = new System.Drawing.Size(140, 140);
            this.btnTable1.TabIndex = 0;
            this.btnTable1.Text = "Маса 1";
            this.btnTable1.UseVisualStyleBackColor = false;
            this.btnTable1.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1232, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Избор на маса";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOrder
            // 
            this.pnlOrder.Controls.Add(this.pnlOrderList);
            this.pnlOrder.Controls.Add(this.pnlMenu);
            this.pnlOrder.Controls.Add(this.pnlControls);
            this.pnlOrder.Controls.Add(this.pnlTopBar);
            this.pnlOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrder.Location = new System.Drawing.Point(0, 0);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(1232, 801);
            this.pnlOrder.TabIndex = 1;
            this.pnlOrder.Visible = false;
            // 
            // pnlOrderList
            // 
            this.pnlOrderList.Controls.Add(this.dgvOrder);
            this.pnlOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderList.Location = new System.Drawing.Point(400, 60);
            this.pnlOrderList.Name = "pnlOrderList";
            this.pnlOrderList.Padding = new System.Windows.Forms.Padding(10);
            this.pnlOrderList.Size = new System.Drawing.Size(482, 741);
            this.pnlOrderList.TabIndex = 3;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colQty,
            this.colNotes});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.EnableHeadersVisualStyles = false;
            this.dgvOrder.Location = new System.Drawing.Point(10, 10);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(462, 721);
            this.dgvOrder.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.HeaderText = "Артикул";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.FillWeight = 50F;
            this.colQty.HeaderText = "Количество";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // colNotes
            // 
            this.colNotes.HeaderText = "Бележки";
            this.colNotes.Name = "colNotes";
            this.colNotes.ReadOnly = true;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.flpItems);
            this.pnlMenu.Controls.Add(this.flpCategories);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 60);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMenu.Size = new System.Drawing.Size(400, 741);
            this.pnlMenu.TabIndex = 2;
            // 
            // flpItems
            // 
            this.flpItems.AutoScroll = true;
            this.flpItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpItems.Location = new System.Drawing.Point(10, 170);
            this.flpItems.Name = "flpItems";
            this.flpItems.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flpItems.Size = new System.Drawing.Size(380, 561);
            this.flpItems.TabIndex = 1;
            // 
            // flpCategories
            // 
            this.flpCategories.AutoScroll = true;
            this.flpCategories.Controls.Add(this.btnCatPredyastiya);
            this.flpCategories.Controls.Add(this.btnCatOsnovni);
            this.flpCategories.Controls.Add(this.btnCatNapitki);
            this.flpCategories.Controls.Add(this.btnCatDeserti);
            this.flpCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCategories.Location = new System.Drawing.Point(10, 10);
            this.flpCategories.Name = "flpCategories";
            this.flpCategories.Size = new System.Drawing.Size(380, 160);
            this.flpCategories.TabIndex = 0;
            // 
            // btnCatPredyastiya
            // 
            this.btnCatPredyastiya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCatPredyastiya.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatPredyastiya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatPredyastiya.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCatPredyastiya.ForeColor = System.Drawing.Color.White;
            this.btnCatPredyastiya.Location = new System.Drawing.Point(5, 5);
            this.btnCatPredyastiya.Margin = new System.Windows.Forms.Padding(5);
            this.btnCatPredyastiya.Name = "btnCatPredyastiya";
            this.btnCatPredyastiya.Size = new System.Drawing.Size(180, 60);
            this.btnCatPredyastiya.TabIndex = 0;
            this.btnCatPredyastiya.Text = "Предястия";
            this.btnCatPredyastiya.UseVisualStyleBackColor = false;
            this.btnCatPredyastiya.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnCatOsnovni
            // 
            this.btnCatOsnovni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCatOsnovni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatOsnovni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatOsnovni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCatOsnovni.ForeColor = System.Drawing.Color.White;
            this.btnCatOsnovni.Location = new System.Drawing.Point(195, 5);
            this.btnCatOsnovni.Margin = new System.Windows.Forms.Padding(5);
            this.btnCatOsnovni.Name = "btnCatOsnovni";
            this.btnCatOsnovni.Size = new System.Drawing.Size(175, 60);
            this.btnCatOsnovni.TabIndex = 1;
            this.btnCatOsnovni.Text = "Основни";
            this.btnCatOsnovni.UseVisualStyleBackColor = false;
            this.btnCatOsnovni.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnCatNapitki
            // 
            this.btnCatNapitki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCatNapitki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatNapitki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatNapitki.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCatNapitki.ForeColor = System.Drawing.Color.White;
            this.btnCatNapitki.Location = new System.Drawing.Point(5, 75);
            this.btnCatNapitki.Margin = new System.Windows.Forms.Padding(5);
            this.btnCatNapitki.Name = "btnCatNapitki";
            this.btnCatNapitki.Size = new System.Drawing.Size(180, 60);
            this.btnCatNapitki.TabIndex = 2;
            this.btnCatNapitki.Text = "Напитки";
            this.btnCatNapitki.UseVisualStyleBackColor = false;
            this.btnCatNapitki.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnCatDeserti
            // 
            this.btnCatDeserti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCatDeserti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatDeserti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatDeserti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCatDeserti.ForeColor = System.Drawing.Color.White;
            this.btnCatDeserti.Location = new System.Drawing.Point(195, 75);
            this.btnCatDeserti.Margin = new System.Windows.Forms.Padding(5);
            this.btnCatDeserti.Name = "btnCatDeserti";
            this.btnCatDeserti.Size = new System.Drawing.Size(175, 60);
            this.btnCatDeserti.TabIndex = 3;
            this.btnCatDeserti.Text = "Десерти";
            this.btnCatDeserti.UseVisualStyleBackColor = false;
            this.btnCatDeserti.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnSendToKitchen);
            this.pnlControls.Controls.Add(this.btnAddCustomItem);
            this.pnlControls.Controls.Add(this.txtCustomItemPrice);
            this.pnlControls.Controls.Add(this.txtCustomItemName);
            this.pnlControls.Controls.Add(this.lblCustom);
            this.pnlControls.Controls.Add(this.btnAddNote);
            this.pnlControls.Controls.Add(this.txtNote);
            this.pnlControls.Controls.Add(this.lblMod);
            this.pnlControls.Controls.Add(this.btnDecreaseQty);
            this.pnlControls.Controls.Add(this.btnIncreaseQty);
            this.pnlControls.Controls.Add(this.lblQty);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControls.Location = new System.Drawing.Point(882, 60);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Padding = new System.Windows.Forms.Padding(10);
            this.pnlControls.Size = new System.Drawing.Size(350, 741);
            this.pnlControls.TabIndex = 1;
            // 
            // btnSendToKitchen
            // 
            this.btnSendToKitchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSendToKitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSendToKitchen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendToKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendToKitchen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSendToKitchen.ForeColor = System.Drawing.Color.White;
            this.btnSendToKitchen.Location = new System.Drawing.Point(10, 641);
            this.btnSendToKitchen.Margin = new System.Windows.Forms.Padding(5);
            this.btnSendToKitchen.Name = "btnSendToKitchen";
            this.btnSendToKitchen.Size = new System.Drawing.Size(310, 80);
            this.btnSendToKitchen.TabIndex = 10;
            this.btnSendToKitchen.Text = "ИЗПРАТИ КЪМ КУХНЯ";
            this.btnSendToKitchen.UseVisualStyleBackColor = false;
            this.btnSendToKitchen.Click += new System.EventHandler(this.BtnSendToKitchen_Click);
            // 
            // btnAddCustomItem
            // 
            this.btnAddCustomItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAddCustomItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCustomItem.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomItem.Location = new System.Drawing.Point(10, 310);
            this.btnAddCustomItem.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddCustomItem.Name = "btnAddCustomItem";
            this.btnAddCustomItem.Size = new System.Drawing.Size(310, 50);
            this.btnAddCustomItem.TabIndex = 9;
            this.btnAddCustomItem.Text = "Добави нестандартен";
            this.btnAddCustomItem.UseVisualStyleBackColor = false;
            this.btnAddCustomItem.Click += new System.EventHandler(this.BtnAddCustomItem_Click);
            // 
            // txtCustomItemPrice
            // 
            this.txtCustomItemPrice.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtCustomItemPrice.Location = new System.Drawing.Point(220, 270);
            this.txtCustomItemPrice.Name = "txtCustomItemPrice";
            this.txtCustomItemPrice.Size = new System.Drawing.Size(90, 32);
            this.txtCustomItemPrice.TabIndex = 8;
            this.txtCustomItemPrice.Text = "Цена";
            this.txtCustomItemPrice.GotFocus += new System.EventHandler(this.TxtCustomItemPrice_GotFocus);
            // 
            // txtCustomItemName
            // 
            this.txtCustomItemName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtCustomItemName.Location = new System.Drawing.Point(10, 270);
            this.txtCustomItemName.Name = "txtCustomItemName";
            this.txtCustomItemName.Size = new System.Drawing.Size(200, 32);
            this.txtCustomItemName.TabIndex = 7;
            this.txtCustomItemName.Text = "Име на артикул";
            this.txtCustomItemName.GotFocus += new System.EventHandler(this.TxtCustomItemName_GotFocus);
            // 
            // lblCustom
            // 
            this.lblCustom.AutoSize = true;
            this.lblCustom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustom.Location = new System.Drawing.Point(10, 240);
            this.lblCustom.Name = "lblCustom";
            this.lblCustom.Size = new System.Drawing.Size(196, 21);
            this.lblCustom.TabIndex = 6;
            this.lblCustom.Text = "Артикул извън менюто:";
            // 
            // btnAddNote
            // 
            this.btnAddNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNote.ForeColor = System.Drawing.Color.White;
            this.btnAddNote.Location = new System.Drawing.Point(10, 180);
            this.btnAddNote.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(310, 50);
            this.btnAddNote.TabIndex = 5;
            this.btnAddNote.Text = "Добави бележка";
            this.btnAddNote.UseVisualStyleBackColor = false;
            this.btnAddNote.Click += new System.EventHandler(this.BtnAddNote_Click);
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNote.Location = new System.Drawing.Point(10, 140);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(310, 32);
            this.txtNote.TabIndex = 4;
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMod.Location = new System.Drawing.Point(10, 110);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(212, 21);
            this.lblMod.TabIndex = 3;
            this.lblMod.Text = "Модификатор / Бележка:";
            // 
            // btnDecreaseQty
            // 
            this.btnDecreaseQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnDecreaseQty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecreaseQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecreaseQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDecreaseQty.ForeColor = System.Drawing.Color.White;
            this.btnDecreaseQty.Location = new System.Drawing.Point(170, 40);
            this.btnDecreaseQty.Margin = new System.Windows.Forms.Padding(5);
            this.btnDecreaseQty.Name = "btnDecreaseQty";
            this.btnDecreaseQty.Size = new System.Drawing.Size(150, 50);
            this.btnDecreaseQty.TabIndex = 2;
            this.btnDecreaseQty.Text = "- 1";
            this.btnDecreaseQty.UseVisualStyleBackColor = false;
            this.btnDecreaseQty.Click += new System.EventHandler(this.BtnDecreaseQty_Click);
            // 
            // btnIncreaseQty
            // 
            this.btnIncreaseQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnIncreaseQty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncreaseQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncreaseQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIncreaseQty.ForeColor = System.Drawing.Color.White;
            this.btnIncreaseQty.Location = new System.Drawing.Point(10, 40);
            this.btnIncreaseQty.Margin = new System.Windows.Forms.Padding(5);
            this.btnIncreaseQty.Name = "btnIncreaseQty";
            this.btnIncreaseQty.Size = new System.Drawing.Size(150, 50);
            this.btnIncreaseQty.TabIndex = 1;
            this.btnIncreaseQty.Text = "+ 1";
            this.btnIncreaseQty.UseVisualStyleBackColor = false;
            this.btnIncreaseQty.Click += new System.EventHandler(this.BtnIncreaseQty_Click);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblQty.Location = new System.Drawing.Point(10, 10);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(229, 21);
            this.lblQty.TabIndex = 0;
            this.lblQty.Text = "Управление на количество:";
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlTopBar.Controls.Add(this.btnBack);
            this.pnlTopBar.Controls.Add(this.lblTableInfo);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1232, 60);
            this.pnlTopBar.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1032, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 60);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Назад към залата";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTableInfo
            // 
            this.lblTableInfo.AutoSize = true;
            this.lblTableInfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTableInfo.ForeColor = System.Drawing.Color.White;
            this.lblTableInfo.Location = new System.Drawing.Point(20, 10);
            this.lblTableInfo.Name = "lblTableInfo";
            this.lblTableInfo.Size = new System.Drawing.Size(98, 32);
            this.lblTableInfo.TabIndex = 0;
            this.lblTableInfo.Text = "Маса X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1232, 801);
            this.Controls.Add(this.pnlOrder);
            this.Controls.Add(this.pnlTables);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Waiter POS";
            this.pnlTables.ResumeLayout(false);
            this.pnlFloorPlan.ResumeLayout(false);
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrderList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.flpCategories.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTables;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFloorPlan;
        private System.Windows.Forms.Button btnTable1;
        private System.Windows.Forms.Button btnTable6;
        private System.Windows.Forms.Button btnTable5;
        private System.Windows.Forms.Button btnTable4;
        private System.Windows.Forms.Button btnTable3;
        private System.Windows.Forms.Button btnTable2;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTableInfo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Button btnDecreaseQty;
        private System.Windows.Forms.Button btnIncreaseQty;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Label lblCustom;
        private System.Windows.Forms.TextBox txtCustomItemName;
        private System.Windows.Forms.TextBox txtCustomItemPrice;
        private System.Windows.Forms.Button btnAddCustomItem;
        private System.Windows.Forms.Button btnSendToKitchen;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.FlowLayoutPanel flpCategories;
        private System.Windows.Forms.Button btnCatPredyastiya;
        private System.Windows.Forms.Button btnCatOsnovni;
        private System.Windows.Forms.Button btnCatNapitki;
        private System.Windows.Forms.Button btnCatDeserti;
        private System.Windows.Forms.FlowLayoutPanel flpItems;
        private System.Windows.Forms.Panel pnlOrderList;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
    }
}
