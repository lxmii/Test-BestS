using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace Mock_Shop.Pages
{
    public class TestModel : PageModel
    {
        private readonly ILogger<TestModel> _logger;

        public TestModel(ILogger<TestModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string datetime = DateTime.Now.ToString("d", new CultureInfo("da-DK"));
            ViewData["TimeStamp"] = datetime;
        }
    }
}