using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers{

    public class HomeController: Controller{

        public IActionResult Index()
        {
            
            // viewbag,viewdata kullanımı 30.video
            int saat = DateTime.Now.Hour;

            //@ViewBag.Selamlama = saat>12 ? "İyi günler":"Günaydın";
            //@ViewBag.UserName= "Yusuf";

            int UserCount = Repository.Users.Where(i=> i.WillAttend == true).Count(); 

            @ViewData["Selamlama"] =saat > 12 ? "İyi günler":"Günaydın";
            //@ViewData["UserName"] = "Yusuf";

            var meetingInfo = new MeetingInfo(){
                Id=1,
                Location="İstanbul, FSM Kongre Merkezi",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople=UserCount
            };
            return View(meetingInfo);
        }
    }
}