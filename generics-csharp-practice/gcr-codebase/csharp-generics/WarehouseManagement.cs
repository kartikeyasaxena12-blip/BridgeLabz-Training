using System;
using System.Collections.Generic;

    //Interface
    interface IStorage<T>
    {
        void AddItem(T item);
        void DisplayItems();
    }

    //Encapsulated class
    abstract class WarehouseItem
    {
        private string name;   
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public WarehouseItem(string name)
        {
            this.name = name;
        }

        public abstract void Display();
    }

    //Methods 
    class StorageMethods<T> : IStorage<T> where T : WarehouseItem
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void DisplayItems()
        {
            foreach (T item in items)
            {
                item.Display();
                }
        }
    }

    //Menu class
    class Menu
    {
        public void Show()
        {
            StorageMethods<WarehouseItem> warehouse =
                new StorageMethods<WarehouseItem>();

            warehouse.AddItem(new Electronics("Laptop"));
            warehouse.AddItem(new Groceries("Rice"));
            warehouse.AddItem(new Furniture("Table"));

            Console.WriteLine("Warehouse Items:");
            warehouse.DisplayItems();
        }
    }

    // Main class
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Show();

            Console.ReadLine();
        }
    }

    // Item Types
    class Electronics : WarehouseItem
    {
        public Electronics(string name) : base(name) { }

        public override void Display()
        {
            Console.WriteLine("Electronics: " + Name);
        }
    }

    class Groceries : WarehouseItem
    {
        public Groceries(string name) : base(name) { }

        public override void Display()
        {
            Console.WriteLine("Groceries: " + Name);
        }
    }

    class Furniture : WarehouseItem
    {
        public Furniture(string name) : base(name) { }

        public override void Display()
        {
            Console.WriteLine("Furniture: " + Name);
        }
    }
