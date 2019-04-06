using System.Data.Entity;

namespace API5.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<API5.Models.Product> Products { get; set; }
    }
}