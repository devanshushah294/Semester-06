namespace JWT_Token_WebApi.Models
{
    public class PersonModel
    {
        public int PersonID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
    }
}
