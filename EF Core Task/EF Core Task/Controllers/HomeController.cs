using EF_Core_Task.DAL;
using EF_Core_Task.Models;
using EF_Core_Task.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EF_Core_Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext dbContext)
        {
            _db = dbContext;
        }
        public IActionResult Index()
        {
            #region
            //    Product product1 = new Product
            //    {
            //        Title = "Chivas Regal 12 illik",
            //        Category = "Viski",
            //        Price = 90,
            //        ImageUrl = "kind-1.jpg"
            //    };
            //    Product product2 = new Product
            //    {
            //        Title = "Nemiroff Original",
            //        Category = "Araq",
            //        Price = 25,
            //        ImageUrl = "kind-2.jpg"
            //    };
            //    Product product3 = new Product
            //    {
            //        Title = "Heineken (0.5L)",
            //        Category = "Pivə",
            //        Price = 4,
            //        ImageUrl = "kind-3.jpg"
            //    };
            //    Product product4 = new Product
            //    {
            //        Title = "Savalan Cabernet Sauvignon",
            //        Category = "Şərab",
            //        Price = 35,
            //        ImageUrl = "kind-4.jpg"
            //    };
            //    Product product5 = new Product
            //    {
            //        Title = "Hennessy V.S.O.P",
            //        Category = "Konyak",
            //        Price = 160,
            //        ImageUrl = "kind-5.jpg"

            //    };

            //    {
            //        Slider slider1 = new Slider
            //        {
            //            Text = "Möhtəşəm xidmət! Şərab çeşidləri çox zəngindir və çatdırılma vaxtında oldu.",
            //            ImageUrl = "person_1.jpg",
            //            Name = "Omer Mirzeyev",
            //            Position = "Daimi Müştəri"
            //        };
            //        Slider slider2 = new Slider
            //        {
            //            Text = "Viski kolleksiyanıza sadəcə bayıldım. Həqiqətən orijinal və premium məhsullardır.",
            //            ImageUrl = "person_2.jpg",
            //            Name = "Kenan Murselizade",
            //            Position = "De Quqsto Jurnalı"
            //        };
            //        Slider slider3 = new Slider
            //        {
            //            Text = "Kolleksiyadakı xarici pivələr əla idi. Həm qiymətlər münasibdir, həm də çeşid çoxdur.",
            //            ImageUrl = "person_3.jpg",
            //            Name = "Emin Qasımov",
            //            Position = "Pivə Həvəskarı"
            //        };
            //        Slider slider4 = new Slider
            //        {
            //            Text = "Saytın şərab menyusu xüsusi zövqlə seçilib. Həm yerli, həm də xarici şərablar yüksək keyfiyyətlidir.",
            //            ImageUrl = "person_1.jpg",
            //            Name = "Leman Bayramova",
            //            Position = "Somelye"
            //        };
            //        Slider slider5 = new Slider

            //        {
            //            Text = "Sifarişim çox tez və təhlükəsiz şəkildə qapıma çatdırıldı. Xidmət səviyyəniz təqdirəlayiqdir.",
            //            ImageUrl = "person_4.jpg",
            //            Name = "Resad Məmmədov",
            //            Position = "Müştəri"
            //        };
            //        Slider slider6 = new Slider
            //        {
            //            Text = "Böyük tədbirlər üçün topdan içki sifarişlərini hər zaman buradan edirəm. Çox güvənilir tərəfdaşdırlar.",
            //            ImageUrl = "person_3.jpg",
            //            Name = "Rovsen Ibrahimov",
            //            Position = "Tədbir Təşkilatçısı"
            //        };
            //_db.Products.AddRange(product1, product2, product3, product4, product5);
            //    _db.Sliders.AddRange(slider1, slider2, slider3, slider4, slider5, slider6);
            //_db.SaveChanges();
#endregion

            List<Product> products = _db.Products.ToList();
            List<Slider> sliders = _db.Sliders.ToList();
            HomeVM homeVM = new HomeVM
            {
                Products = products,
                Sliders = sliders
            };
            return View(homeVM);

            }
        }
    }

