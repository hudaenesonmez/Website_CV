using System.ComponentModel.DataAnnotations;

namespace YucedagUdemy.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soydınızı Giriniz.")]
        public string Surname { get; set; }
        [Required(ErrorMessage ="Lütfen Kullanıcı Adınızı Giriniz.")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Lütfen Şifrenizi Giriniz.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Şifreyi Yeniden Giriniz.")]
        [Compare("Password",ErrorMessage ="Şifreyi Onaylamak İçin Doğru Girdiğinizden Emin Olun.")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage ="Mail Bilgilerinizi Giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen Resim yolunuzu Giriniz.")]
        public string ImageUrl { get; set; }


    }
}
