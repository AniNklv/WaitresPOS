using System;
using System.Collections.Generic;

namespace WaiterPOS
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public MenuItem(string name, string category, decimal price)
        {
            Name = name;
            Category = category;
            Price = price;
        }
    }

    public class OrderItem
    {
        public MenuItem Item { get; set; }
        public int Quantity { get; set; }
        public string Notes { get; set; } // modifiers, e.g., "no salt"

        public decimal TotalPrice => Item.Price * Quantity;

        public OrderItem(MenuItem item, int quantity = 1, string notes = "")
        {
            Item = item;
            Quantity = quantity;
            Notes = notes;
        }
    }

    public class Table
    {
        public int Number { get; set; }
        public List<OrderItem> CurrentOrder { get; set; }
        public bool IsOccupied => CurrentOrder.Count > 0;

        public Table(int number)
        {
            Number = number;
            CurrentOrder = new List<OrderItem>();
        }
    }
}
