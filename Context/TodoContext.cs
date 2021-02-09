using Microsoft.EntityFrameworkCore;


namespace Projeto.Context{
    public class TodoContext:DbContext{
        public TodoContext(DbContextOptions<TodoContext> option):base(option){
        
        }

        public DbSet<Forecast> Forecasts{get; set;} = default!;

    }

}