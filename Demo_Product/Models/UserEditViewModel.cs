using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Product.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Lütfen isim değeri giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyisim değeri giriniz")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Lütfen Mail  giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen Cinsiyet  giriniz")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre  giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi tekrar  giriniz")]
        [Compare("Password", ErrorMessage = "Lütfen şifrelerin eşleştiğinden emin olunuz")]
        public string ConfirmPassword { get; set; }
    }
}
