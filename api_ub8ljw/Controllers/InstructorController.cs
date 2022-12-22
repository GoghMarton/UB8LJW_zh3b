using api_ub8ljw.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_ub8ljw.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        [HttpGet]
        [Route("instructor/all")]
        public IActionResult M1()
        {
            InstructorContext context = new InstructorContext();

            var tanárok = from x in context.Instructor
                          select x;

            return Ok(tanárok);
        }

        [HttpPost]
        [Route("instructor/new")]
        public void POST([FromBody] Instructor ujTanar)
        {
            InstructorContext context = new InstructorContext();
            context.Instructor.Add(ujTanar);
            context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void DELETE(int id)
        {
            InstructorContext context = new InstructorContext();
            var törlendőTanár = (from x in context.Instructor
                                 where x.InstructorSk == id
                                 select x).FirstOrDefault();

            context.Instructor.Remove(törlendőTanár);
            context.SaveChanges();
        }

        [HttpGet]
        [Route("instructor/{id}")]
        public IActionResult InstructorID(int id)
        {
            InstructorContext context = new InstructorContext();
            var tanár = (from x in context.Instructor
                         where x.InstructorSk == id
                         select x).FirstOrDefault();

            return Ok(tanár);
        }

        [HttpGet]
        [Route("day/{id}")]
        public IActionResult DayID(int id)
        {
            InstructorContext context = new InstructorContext();
            var nap = (from x in context.Day
                       where x.DayId == id
                       select x).FirstOrDefault();

            return Ok(nap);
        }
    }
}
