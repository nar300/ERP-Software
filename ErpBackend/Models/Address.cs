using System.ComponentModel.DataAnnotations;

namespace ErpBackend.Models
{
    public abstract class Address
    {
        [Display(Name = "Home Address")]
        [Required(ErrorMessage = "Home Address Required")]
        public string HomeAddress { get; set; }
        [Display(Name = "Your City")]
        [Required(ErrorMessage = "City Name Required")]
        public string City { get; set; }
        
        [Required(ErrorMessage = "Post Town Required")]
        public string Town { get; set; }
        [Display(Name = "Postal Code")]
        [Required(ErrorMessage = "Post code or Zip Required")]
        public string PostCode { get; set; }
    }
}