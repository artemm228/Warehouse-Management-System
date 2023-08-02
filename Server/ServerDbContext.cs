using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class ServerDbContext : DbContext
    {
        public ServerDbContext(DbContextOptions<ServerDbContext> options) : base(options)
        {

        }
    }
}
