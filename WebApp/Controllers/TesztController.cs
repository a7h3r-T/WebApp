using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class TesztController : ControllerBase
    {
        [HttpGet]
        [Route("corvinus/szerverido")]
        public IActionResult M1()
        {
            string pontosIdő = DateTime.Now.ToString();

            return new ContentResult
            {
                ContentType = System.Net.Mime.MediaTypeNames.Text.Plain,
                Content = pontosIdő
            };

            //return Ok(pontosIdő);
        }

        [HttpGet]
        [Route("corvinus/nagybetus/{szoveg}")]
        public IActionResult M2(string szoveg)
        {
            try
            {
                return new ContentResult
                {
                    ContentType = System.Net.Mime.MediaTypeNames.Text.Plain,
                    Content = szoveg.ToUpper()

                    //return Ok(szoveg.ToUpper());
                };
            }
            catch (Exception)
            {
                return BadRequest("Nem jó a bemenő adat");
            }
             
        }
    }
}
