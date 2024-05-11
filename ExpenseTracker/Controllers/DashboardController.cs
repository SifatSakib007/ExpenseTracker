using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        { 
            // Last 7 days
            DateTime StartDate = DateTime.Today.AddDays(-6);   
            DateTime EndDate = DateTime.Today;   



            return View();
        }
    }
}
    