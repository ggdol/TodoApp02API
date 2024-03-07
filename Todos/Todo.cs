using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace TodoApp02.Todos
{
    public class Todo
    {

        public record TodoPostRequest([MinLength(3)] string Description);
        public int Id { get; private set; }
        [MinLength(3)]
        public string Description { get; private set; }
        public Todo(int id, string description)
        {
            this.Id = id;
            this.Description = description;
        }

       

 
    }
}
