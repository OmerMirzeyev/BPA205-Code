using OOP_Task.Moduls;

namespace OOP_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Omer","mirzeyev@gmail");
            Console.WriteLine("--------------------------------------------");
            Customer customer = new Customer("Omer","mirzeyevomer1@gmail.com",2000);
            Console.WriteLine($"Customer: {customer.Name}, Balance: {customer.Balance}");
            Console.WriteLine($"Customer: {customer.Name}, Email: {customer.Email}");
            Console.WriteLine("---------------------------------------------");
            Phone phone = new Phone("Samsung S26", 3220, 100, "Android", 300);
            Console.WriteLine($"Product: {phone.Name}, Stock: {phone.Stock}");
            Console.WriteLine("----------------------------------------------");
            Order order = new Order(customer,phone,2);
            Console.WriteLine($"Customer: {order.Customer.Name}");
            Console.WriteLine($"Product: {order.Product.Name}, Quantity: {order.Quantity}");
            Console.WriteLine($"Total Price: {order.TotalPrice}");
            Console.WriteLine($"New Stock: {phone.Stock}");
        }
    }
}
