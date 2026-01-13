using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace DbOperationWithEFCoreApp.Controllers
{
    [Route("api/language")]
    [ApiController]
    public class LanguageController : Controller
    {
        public AppDbContext appDbContext { get; set; }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public LanguageController(AppDbContext _appDbContext)
        {
            appDbContext = _appDbContext;

        }


        [HttpGet("")]
        public async Task<IActionResult> GetAllLanauge()
        {
            // var result = appDbContext.languageTable.ToList();

            //var result = (from Language in appDbContext.languageTable
            //              select Language).ToList();

            var result = await appDbContext.languageTable.ToListAsync();

            //var result = await (from Language in appDbContext.languageTable
            //              select Language).ToListAsync();

            return Ok(result);
        }




    }
}
