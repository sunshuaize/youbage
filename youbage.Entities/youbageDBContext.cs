using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using youbage.Entities.Entities;

namespace youbage.Entities
{
    public class youbageDBContext :DbContext
    {

        public youbageDBContext(DbContextOptions<youbageDBContext> options):base(options)
        {


        }


        public DbSet<user> User { get; set; }
    }
}
