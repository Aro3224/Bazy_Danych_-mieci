using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Ecocoon.Database
{
    public class DBSmieci : DbContext
    {
        public DBSmieci() : base("name=ConnectionSmieci")
        {

        }

        public DbSet<MyEntity> Administrators { get; set; }
    }

    public class MyEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }
}
