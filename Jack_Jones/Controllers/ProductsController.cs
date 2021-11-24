using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Jack_Jones.Controllers
{
    //public class Rootobject
    //{
    //    public Product[] products { get; set; }
    //}
    //public class Product
    //{
    //    public int id { get; set; }
    //    public string brand { get; set; }
    //    public float price { get; set; }
    //    public int stock { get; set; }
    //    public string color { get; set; }
    //    public string[] size { get; set; }
    //    public Name name { get; set; }
    //    public string[] images { get; set; }
    //    public string[] categories { get; set; }
    //}
    //public class Name
    //{
    //    public string dk { get; set; }
    //    public string en { get; set; }
    //}
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Name
    {
        public string? dk { get; set; }
        public string? en { get; set; }
    }

    public class Variant
    {
        public object? stock { get; set; }
        public string? color { get; set; }
        public List<string>? size { get; set; }
        public List<string>? images { get; set; }
    }

    public class Product
    {
        public int id { get; set; }
        public string? brand { get; set; }
        public double price { get; set; }
        public object? stock { get; set; }
        public string? color { get; set; }
        public List<object>? size { get; set; }
        public Name? name { get; set; }
        public List<string>? images { get; set; }
        public List<string>? categories { get; set; }
        public List<Variant>? variant { get; set; }
    }

    public class Category
    {
        public string? id { get; set; }
        public string? parent_category_id { get; set; }
        public int level { get; set; }
        public Name? name { get; set; }
        public List<Category>? categories { get; set; }
    }

    public class Root
    {
        public List<Product>? products { get; set; }
        public Category? categories { get; set; }
    }


    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]

        public List<Product> GetInfo()
        {
                 
                    //StreamReader r = new("..\\Mock_Shop\\Pages\\JSONfile\\test-technical-prep.json");
                    StreamReader r = new StreamReader("..\\test-technical-prep.json");
                    Root root = new();
                    root = JsonConvert.DeserializeObject<Root>(r.ReadToEnd());
                    return root.products;

        
         }
    }
}
