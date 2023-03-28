using Microsoft.AspNetCore.Mvc;

namespace Catalogo.Controllers
{
    [ApiController]
    [Route("catalogo")]
   
    public class CatalogoController : ControllerBase
    {
        public IactionResult Get(){
            return ok();
        }
    }
}