using Microsoft.AspNetCore.Mvc;
using static TodoApp02.Todos.Todo;

namespace TodoApp02.Todos;

[ApiController]
[Route("[controller]")]
public class TodoController
{
    private ITodoRepository repo;
    public TodoController(ITodoRepository repo)
    {
        this.repo = repo;
    }
    
    [HttpGet("{id}", Name = "GetTodo")]
    public ActionResult<Todo> Get(int id)
    {
        var todo = repo.Todos.FirstOrDefault(todo => todo.Id==id);
        if(todo == null) return new NotFoundResult();
        return todo;
    }

    [HttpPost(Name = "PostTodo")]
    public ActionResult<int> Post(TodoPostRequest todoPostRequest)
    {
        var id = repo.Add(todoPostRequest.Description);
        return new CreatedResult($"todo/{id}", id);
    }
}