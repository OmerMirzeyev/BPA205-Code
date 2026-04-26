using Front_to_Back_Intro_Task.Models;
using Front_to_Back_Intro_Task.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Front_to_Back_Intro_Task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>()
{
    new Product
    {
        Id = 1,
        Title = "Chivas Regal 12 illik",
        Category = "Viski",
        Price = 90,
        ImageUrl = "kind-1.jpg"
    },
    new Product
    {
        Id = 2,
        Title = "Nemiroff Original",
        Category = "Araq",
        Price = 25,
        ImageUrl = "kind-2.jpg"
    },
    new Product
    {
        Id = 3,
        Title = "Heineken (0.5L)",
        Category = "Pivə",
        Price = 4,
        ImageUrl = "kind-3.jpg"
    },
    new Product
    {
        Id = 4,
        Title = "Savalan Cabernet Sauvignon",
        Category = "Şərab",
        Price = 35,
        ImageUrl = "kind-4.jpg"
    },
    new Product
    {
        Id = 5,
        Title = "Hennessy V.S.O.P",
        Category = "Konyak",
        Price = 160,
        ImageUrl = "kind-5.jpg"
    }
};
            List<Slider> sliders = new List<Slider>()
{
    new Slider
    {
        Id = 1,
        Text = "Möhtəşəm xidmət! Şərab çeşidləri çox zəngindir və çatdırılma vaxtında oldu.",
        ImageUrl = "person_1.jpg",
        Name = "Omer Mirzeyev",
        Position = "Daimi Müştəri"
    },
    new Slider
    {
        Id = 2,
        Text = "Viski kolleksiyanıza sadəcə bayıldım. Həqiqətən orijinal və premium məhsullardır.",
        ImageUrl = "person_2.jpg",
        Name = "Kenan Murselizade",
        Position = "De Quqsto Jurnalı"
    },
    new Slider
    {
        Id = 3,
        Text = "Kolleksiyadakı xarici pivələr əla idi. Həm qiymətlər münasibdir, həm də çeşid çoxdur.",
        ImageUrl = "person_3.jpg",
        Name = "Emin Qasımov",
        Position = "Pivə Həvəskarı"
    },
    new Slider
    {
        Id = 4,
        Text = "Saytın şərab menyusu xüsusi zövqlə seçilib. Həm yerli, həm də xarici şərablar yüksək keyfiyyətlidir.",
        ImageUrl = "person_1.jpg",
        Name = "Leman Bayramova",
        Position = "Somelye"
    },
    new Slider
    {
        Id = 5,
        Text = "Sifarişim çox tez və təhlükəsiz şəkildə qapıma çatdırıldı. Xidmət səviyyəniz təqdirəlayiqdir.",
        ImageUrl = "person_4.jpg", 
        Name = "Resad Məmmədov",
        Position = "Müştəri"
    },
    new Slider
    {
        Id = 6,
        Text = "Böyük tədbirlər üçün topdan içki sifarişlərini hər zaman buradan edirəm. Çox güvənilir tərəfdaşdırlar.",
        ImageUrl = "person_3.jpg",
        Name = "Rovsen Ibrahimov",
        Position = "Tədbir Təşkilatçısı"
    }
};
            HomeVM homeVM = new HomeVM()
            {
                Products = products,
                Sliders = sliders
            };
            return View(homeVM);
        }
    }
}
