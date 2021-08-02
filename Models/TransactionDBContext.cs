using Microsoft.EntityFrameworkCore;

namespace JqueryAjax.Models
{
    public class TransactionDBContext:DbContext
    {
        
        public TransactionDBContext(DbContextOptions<TransactionDBContext> options):base(options)
        {

        }
        public DbSet<TransactionModel> transaction {get;set;}
    }
}