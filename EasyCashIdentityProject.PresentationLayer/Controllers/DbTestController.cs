using EasyCashIdentityProject.DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbTestController : Controller
    {
        private EasyCashIdentityContext _context;

        public DbTestController(EasyCashIdentityContext context)
        {
            _context = context;
        }
        
        // GET: DbTestController
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("DBConnection")]
        public ActionResult CheckDbConnection()
        {
            try
            {
                _context.Database.OpenConnection();
                _context.Database.CloseConnection();
                return Ok("Veritabanı bağlantısı başarılı");
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Veritabanı bağlantısı başarısız hata: {e.Message}");
            }
        }
    }
}
