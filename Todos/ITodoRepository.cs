using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp02.Todos
{
    public interface ITodoRepository
    {
        IEnumerable<Todo> Todos { get; }
        int Add(string description);
    }
}
