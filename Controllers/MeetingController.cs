using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers{

    public class MeetingController: Controller{


         [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        // [HttpPost]
        // public IActionResult Apply(string Name,string Phone,string Email,bool WillAttend) //asırı yukleme yaptık iki tane Apply methodu var ancak biri Get biri Post request Post olan parametreli oldugu icin hata vermedi asırı yukleme oldu
        // {
        //     // Console.WriteLine(Name); formdan girdigimiz bilgileri bu sekil konsola yazdırdık calısıyor mu diye kontrol etmek icin
        //     // Console.WriteLine(Email);
        //     // Console.WriteLine(Phone);
        //     // Console.WriteLine(WillAttend);
        //     return View();
        // }

        
        [HttpPost]
        public IActionResult Apply(UserInfo model) // model gonderdik post request 
        {
            if(ModelState.IsValid) // butun data annotationslar dogruysa yani uyulması gereken kontroller saglanmıssa bu bloga gir dedik
            {
                Repository.CreateUser(model);
                ViewBag.UserCount = Repository.Users.Where(i=> i.WillAttend == true).Count(); // toplantıya katılanların sayısını verir
                return View("Thanks",model);
            }
            else{ 
                return View(model); // formda uyulması gereken kontrollerden biri bile hatalıysa formu yeniden gonder dedik orn: Required yazdıgımız alana bir sey girmeyip bos bırakırsak | parantez icine neden model yazdık bidaha cunku hatalı formu giren kullanıcıya en son yazdıklarıyla form donsun istedik inputların value degerleri tekrar doner kullanıcı yazdıgı degerleri de gorur hatalı kısımları gormesini saglar
            }
            
        }

         [HttpGet]
         public IActionResult List()
        {
            return View(Repository.Users);
        }

        // meeting/details/2
        public IActionResult Details(int id){
            return View(Repository.GetById(id));
        }
    }
}