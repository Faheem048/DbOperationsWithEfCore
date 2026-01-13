using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbOperationWithEFCoreApp.Controllers
{
    [Route("api/currencies")]
    [ApiController]
    public class CurrencyController : Controller
    {
        public AppDbContext appDbContext { get; set; }

        public CurrencyController(AppDbContext _appDbContext)
        {
            appDbContext = _appDbContext;
        }

        //[HttpGet("Predefine")]
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet("")]
        public async Task<IActionResult> GetAllCurrency()
        {
            // var result = AppDbContext.CurrencyTypes.ToList();
            //var result = (from CurrencyType in AppDbContext.CurrencyTypes
            //             select CurrencyType).ToList();

            var result = await appDbContext.CurrencyTypes.ToArrayAsync();
            //var result = await (from CurrencyType in AppDbContext.CurrencyTypes
            //             select CurrencyType).ToArrayAsync();

            return Ok(result);
        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCurrencyByIdAsync([FromRoute] int id)
        {
            // var result = AppDbContext.CurrencyTypes.ToList();
            //var result = (from CurrencyType in AppDbContext.CurrencyTypes
            //             select CurrencyType).ToList();

            var result = await appDbContext.CurrencyTypes.FindAsync(id);
            //var result = await (from CurrencyType in AppDbContext.CurrencyTypes
            //             select CurrencyType).ToArrayAsync();

            return Ok(result);
        }

        [HttpGet("{name}/{description}")]
        public async Task<IActionResult> GetCurrencyByNameAsync([FromRoute] string name, [FromRoute] string? description)
        {

            // var result = await appDbContext.CurrencyTypes.Where(x => x.Currency == name).FirstOrDefaultAsync();
            var result = await appDbContext.CurrencyTypes.FirstOrDefaultAsync(x => x.Currency == name && string.IsNullOrEmpty(x.Description) || x.Description == description);

            //var result = await (from CurrencyType in AppDbContext.CurrencyTypes
            //             select CurrencyType).ToArrayAsync();

            return Ok(result);
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetCurrencyByNameAsync([FromRoute] string name)
        {

            // var result = await appDbContext.CurrencyTypes.Where(x => x.Currency == name).FirstOrDefaultAsync();
            var result = await appDbContext.CurrencyTypes.Where(x => x.Currency == name).ToListAsync();

            //var result = await (from CurrencyType in AppDbContext.CurrencyTypes
            //             select CurrencyType).ToArrayAsync();

            return Ok(result);
        }

        [HttpPost("all")]
        public async Task<IActionResult> GetCurrencyAllDataAsync([FromBody] List<int> id)
        {

            // var result = await appDbContext.CurrencyTypes.Where(x => x.Currency == name).FirstOrDefaultAsync();
            var result = await appDbContext.CurrencyTypes.Where(x => id.Contains(x.Id))
                .Select(x => new CurrencyType()
                {
                    Id = x.Id,
                    Currency = x.Currency,

                })
             .ToListAsync();

            //var result = await (from CurrencyType in AppDbContext.CurrencyTypes
            //             select CurrencyType).ToArrayAsync();

            return Ok(result);
        }
    }
}
