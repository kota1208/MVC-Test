using System.Data.Entity;

namespace MVC_Test.Models
{
    //Contextくらす、TodoとDBをつなげる役割
    public class TodoesContext:DbContext
    {
        public DbSet<Todo> Todoes { get; set; }
    }
}
