using APIFun.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIFun.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MarriottFoodController : ControllerBase
    {
        private IFoodRepository _foodrepository;
        public MarriottFoodController(IFoodRepository temp) {
            _foodrepository = temp;
        }

        public IEnumerable<MarriottFood> Get()
        {
            var foodData = _foodrepository.Foods.ToArray();

            return foodData;
        }
    }
}
