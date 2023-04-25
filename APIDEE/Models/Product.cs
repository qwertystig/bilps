namespace APIDEE.Models
{
    public class Product
    {
        public int code { get; set; }
        public string name { get; set; }

        public Product(int code, string name)
        {
            this.code = code;
            this.name = name;   
        }
    }
}
