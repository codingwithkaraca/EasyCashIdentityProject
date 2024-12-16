using EasyCashIdentityProject.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    public class TestController : Controller
    {
        // GET: TestController
        public ActionResult Index()
        {
            try
            {
                EasyCashIdentityContext _context = new EasyCashIdentityContext();
                var first = _context.CustomerAccounts.FirstOrDefault();
                Console.WriteLine(first.BankBranch);
                // dün 00.00 da db bağlantısı ile veri aldım başarılı oldu

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            
            
            return View();
        }

    }
}
