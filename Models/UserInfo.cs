using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models{

    public class UserInfo{
        public int Id { get; set; }

        [Required] // eger null deger donerse uyarı verir null olamaz diye. data annotations
        public string? Name { get; set; } // null 

        [Required(ErrorMessage ="Telefon numarası zorunlu")] // hata mesajlarını kendimiz yazdık
        public string? Phone { get; set; }

        [Required] // default hata mesajı
        [EmailAddress(ErrorMessage ="Hatalı email")]//bizim yazdıgımız hata mesajı
        public string? Email { get; set; }

        [Required(ErrorMessage ="Katılım durumunuzu belirtiniz.")]
        public bool? WillAttend { get; set; } // true,false,null
    }

}