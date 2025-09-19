using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public List<Car> Cars { get; set; }

        public void OnGet()
        {
            SqlConnection db = new SqlConnection("Data Source=localhost;Initial Catalog=Cars;User ID=sa;Password=@12tf56so;Trust Server Certificate=True");
            db.Open();
            Cars=db.Query<Car>("SELECT * FROM Cars").ToList();
        }

        public void OnPost()
        {

        }
    }
}
