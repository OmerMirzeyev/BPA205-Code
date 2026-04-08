using static Inventory_Task.GenericInventoryApp;

namespace Inventory_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory<Product> productInventory = new Inventory<Product>();

            Product p1 = new Product("Noutbuk", 1500m);
            Product p2 = new Product("Smartfon", 800m);
            Product p3 = new Product("Qulaqlıq", 100m);

            productInventory.AddItem(p1);
            productInventory.AddItem(p2);
            productInventory.AddItem(p3);
            Console.WriteLine("\n Butun Mehsullar:");
            productInventory.GetAllItems();
            Console.WriteLine("Silinme prosesi:");
            productInventory.RemoveItem(p2); 
            Console.WriteLine("\nQalan Mehsullar:");
            productInventory.GetAllItems();
            Console.WriteLine("\nIndex 1-deki mehsul:");
            Product foundProduct = productInventory.FindByIndex(1);
            if (foundProduct != null)
            {
                Console.WriteLine(foundProduct.ToString());
            }

            Console.WriteLine("\n-----------------------------------\n");
            Inventory<User> userInventory = new Inventory<User>();

            // 3 user əlavə edilir
            User u1 = new User("Emin", 25);
            User u2 = new User("Omer", 22);
            User u3 = new User("Kenan", 30);

            userInventory.AddItem(u1);
            userInventory.AddItem(u2);
            userInventory.AddItem(u3);

            Console.WriteLine("Bütün İstifadeciler:");
            userInventory.GetAllItems();

            Console.WriteLine("\nIndex 0-dakı istifadeci:");
            User foundUser = userInventory.FindByIndex(0);
            if (foundUser != null)
            {
                Console.WriteLine(foundUser.ToString());
            }
            
            Console.WriteLine("\nSehv usul:");
            User errorUser = userInventory.FindByIndex(5);
        }
    }
}
