using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_Task
{
    public class GenericInventoryApp
    {
        public class Inventory<T>
        {
            private List<T> items;

            public Inventory()
            {
                items = new List<T>();
            }

            public void AddItem(T item)
            {
                items.Add(item);
            }

            public void RemoveItem(T item)
            {
                if (items.Contains(item))
                {
                    items.Remove(item);
                    Console.WriteLine($"{item},Item uğurla silindi.");
                }
                else
                {
                    Console.WriteLine("Item tapılmadı");
                }
            }
            public void GetAllItems()
            {
                foreach (var item in items)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            public T FindByIndex(int index)
            {
                if (index < 0 || index >= items.Count)
                {
                    Console.WriteLine("Index out of range");
                    return default(T);
                }

                return items[index];
            }
        }
    }
}
