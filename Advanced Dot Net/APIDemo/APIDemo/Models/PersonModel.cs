using System.ComponentModel.DataAnnotations;

namespace APIDemo.Models
{
    public class PersonModel
    {
        public int PersonID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword {  get; set; } = string.Empty;
        public string CreditCardNumber { get; set; }
        public decimal Amount { get; set; }
        public bool CheckedTermsConditions { get; set; }
        public int NoOfFriends { get; set; }
    }
}
