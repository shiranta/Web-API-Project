using TaskApi.Services;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class ToDoService :IToDoRepositery
    {


        public List<ToDo> AllThingsToDo()
        {
            var todos = new List<ToDo>();

            var todo1 = new ToDo()
            {
                ID = 1,
                Title = "project start",
                Description = "Collect the existing Doc",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = ToDoStatus.New

            };
            todos.Add(todo1);


            var todo2 = new ToDo()
            {
                ID = 2,
                Title = "project start",
                Description = "Collect the existing Doc",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = ToDoStatus.New

            };
            todos.Add(todo2);

            var todo3 = new ToDo()
            {
                ID = 3,
                Title = "project continue",
                Description = "Design the System",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = ToDoStatus.Completed

            };
            todos.Add(todo3);

            var todo4 = new ToDo()
            {
                ID = 4,
                Title = "project start",
                Description = "Collect the existing Doc",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = ToDoStatus.InPrograse

            };
            todos.Add(todo4);

            return todos;




        }







    }
}
