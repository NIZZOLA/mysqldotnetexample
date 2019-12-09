using DotCoreNetMySql.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotCoreNetMySql
{
    public class MysqlContext : DbContext
    {
        public MysqlContext( DbContextOptions<MysqlContext> options ): base(options)
        {

        }

        public DbSet<BookModel> Books { get; set; }
    }
}
