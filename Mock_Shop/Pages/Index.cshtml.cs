using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Net;



namespace Mock_Shop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }



        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Name
        {
            public string dk { get; set; }
            public string en { get; set; }
        }

        public class Variant
        {
            public object stock { get; set; }
            public string color { get; set; }
            public List<string> size { get; set; }
            public List<string> images { get; set; }
        }

        public class Product
        {
            public int id { get; set; }
            public string brand { get; set; }
            public double price { get; set; }
            public object stock { get; set; }
            public string color { get; set; }
            public List<object> size { get; set; }
            public Name name { get; set; }
            public List<string> images { get; set; }
            public List<string> categories { get; set; }
            public List<Variant> variant { get; set; }
        }

        public class Category
        {
            public string id { get; set; }
            public string parent_category_id { get; set; }
            public int level { get; set; }
            public Name name { get; set; }
            public List<Category> categories { get; set; }
        }

        public class Root
        {
            public List<Product> products { get; set; }
            public Category categories { get; set; }
        }



        public void OnGet()

        {

            // StreamReader r = new StreamReader("..\\Mock_Shop\\Pages\\JSONfile\\test-technical-prep.json");
            StreamReader r = new StreamReader("..\\test-technical-prep.json");
            string jsonString = r.ReadToEnd();
            Root root= new();  
            root = JsonConvert.DeserializeObject<Root>(jsonString);
            foreach (var v in root.products)
            {
                ViewData["id"] = v.id;
                ViewData["product"] = v.name.dk;
            }
            ;

        }
    }
}