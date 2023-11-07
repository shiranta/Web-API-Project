using WebAPI.Models;

namespace TaskApi.Services
{
    public interface IToDoRepositery
    {
        public List<ToDo> AllThingsToDo();
    }
}
