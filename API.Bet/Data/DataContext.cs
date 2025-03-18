using API.Bet.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace API.Bet.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public  DbSet<VMPlayer> C_Player { get; set; }
    }
    
}
