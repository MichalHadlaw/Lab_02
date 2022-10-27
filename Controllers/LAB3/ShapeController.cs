using Microsoft.AspNetCore.Mvc;
using WebApplication1.Serwices;
using WebApplication1.Serwices.LAB3;

namespace WebApplication1.Controllers.LAB3
{

        [ApiController]
        [Route("[controller]/[action]")]
        public class ShapeController : ControllerBase
        {
            [HttpGet]
            public int GetArea()
            {
                var rectangle = new rectangle(23, 23);
                return rectangle.GetArea();
            }
        [HttpGet]
        public int GetsumArea()
        {
            var rectangle = new rectangle(23, 23);
            var rectangle2 = new rectangle(4, 4);
            return rectangle + rectangle2;
        }
    }
    
}
