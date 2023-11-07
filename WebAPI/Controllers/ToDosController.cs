using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskApi.Services;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDosController : ControllerBase
    {

        private IToDoRepositery _ToDoService;
    //public ToDosController()
    //{
    //    _ToDoService = new ToDoService();
    //}

        public ToDosController(IToDoRepositery Repos)
        {
            _ToDoService = Repos;
        }



        [HttpGet("{id?}")]
        public IActionResult AllTodoGet(int? id)
        {
            

            var mytodos = _ToDoService.AllThingsToDo();

            if (id is null) return Ok(mytodos);

            mytodos = mytodos.Where(t => t.ID == id).ToList();

            return Ok(mytodos);

        }

       
    }
}
