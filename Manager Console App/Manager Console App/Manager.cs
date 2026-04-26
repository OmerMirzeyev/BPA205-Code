using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Manager_Console_App
{
    public class Manager<T> where T : BaseEntity
    {
        private List<T> _items;
        public Manager()
        {
            _items = new List<T>();
        }
        public void Add(T entity)
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Id == entity.Id)
                {
                    Console.WriteLine("Bu Id artıq var!");
                    return;
                }
            }

            _items.Add(entity);
            Console.WriteLine("Obyekt elave olundu.");
        }
        public void Remove(int id)
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Id == id)
                {
                    _items.RemoveAt(i);
                    Console.WriteLine("Obyekt silindi");
                    return;
                }
            }

            Console.WriteLine("Bu Id tapilmadi");
        }
        public void Update(T entity)
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Id == entity.Id)
                {
                    _items[i] = entity;
                    Console.WriteLine("Obyekt yenilendi");
                    return;
                }
            }

            Console.WriteLine("Yenilemek ucun obyekt tapılmadı");
        }
        public T GetById(int id)
        {

            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Id == id)
                {
                    return _items[i];
                }
            }

            Console.WriteLine("Obyekt tapilmadi");
            return null;
        }
        public List<T> GetAll() 
        {
            return _items;
        }
    }
}
