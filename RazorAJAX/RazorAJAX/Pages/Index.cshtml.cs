using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorAJAX.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public string secondaryName { get; set; }

        public void OnGet()
        {
            secondaryName = "A small sample";
        }
        public int counter { get; set; }

        public IActionResult OnPostMyAjaxHandler1(string data)
        {
            int myResult = int.Parse(data) + 1;
            return new JsonResult(new { result = myResult.ToString() });
        }

        /*
         * return current time
         */
        public IActionResult OnPostMyAjaxHandler2(string data)
        {
            return new JsonResult(new { result = DateTime.Now.ToString("G") });
        }
    }
}
