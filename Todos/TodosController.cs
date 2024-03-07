using Microsoft.AspNetCore.Mvc;

namespace TodoApp02.Todos
{
    [ApiController]
    [Route("todos")]
    public class TodosController
    {
        private ITodoRepository repo;

        public TodosController(ITodoRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet(Name = "GetTodos")]
        public IEnumerable<Todo> Get()
        {
           return this.repo.Todos;
        }
    }
}
