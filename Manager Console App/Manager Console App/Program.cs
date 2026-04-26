namespace Manager_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager<Product> manager = new Manager<Product>();

            manager.Add(new Product { Id = 1, Name = "Telefon", Price = 800 });
            manager.Add(new Product { Id = 2, Name = "Laptop", Price = 2000 });
            manager.Add(new Product { Id = 1, Name = "Xaladenik", Price = 7000 });
            manager.Add(new Product { Id = 3, Name = "Adapter", Price = 7 });
            manager.Add(new Product { Id = 4, Name = "Nausniq", Price = 80 });
            Console.WriteLine("--------------------------------------------------------------------");
            Product p = manager.GetById(1);
            if (p != null)
            {
                Console.WriteLine("Tapildi: " + p.Name + " " + p.Price);
            }
            Product p1 = manager.GetById(2);
            if (p1 != null)
            {
                Console.WriteLine("Tapildi: " + p1.Name + " " + p1.Price);
            }
            Product p2 = manager.GetById(3);
            if (p2 != null)
            {
                Console.WriteLine("Tapildi: " + p2.Name + " " + p2.Price);
            }
            Product p3 = manager.GetById(4);
            if (p3 != null)
            {
                Console.WriteLine("Tapildi: " + p3.Name + " " + p3.Price);
            }
            Product p4 = manager.GetById(5);
            if (p4 != null)
            {
                Console.WriteLine("Tapildi: " + p4.Name + " " + p4.Price);
            }
            Console.WriteLine("--------------------------------------------------------------------");
            manager.Update(new Product { Id = 1, Name = "iPhone", Price = 2500 });
            manager.Update(new Product { Id = 3, Name = "Kondisoner", Price = 500 });

            manager.Remove(2);

            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("\nButun mehsullar:");
            List<Product> products = manager.GetAll();

            foreach (Product item in products)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Price);
            }

        }
    }
}
