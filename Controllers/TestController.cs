using Microsoft.AspNetCore.Mvc;

namespace Muresan_Razvan_Lab1.Controllers
{
    public class TestController : Controller
    {
        public String Index()
        {
            return "Hello from test controller!";
        }

        public String Salut()
        {
            return "Salutare!";
        }

        public String SalutParametrizat(String nume, int numar)
        {
            return $"Salutare, {nume}! Ai ales numarul: {numar}";
        }
    }
}
