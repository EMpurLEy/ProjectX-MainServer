using Microsoft.EntityFrameworkCore;
using ProjectX.DataAccess.Core.Interfaces.DbContext;
using ProjectX.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectX.DataAccess.DbContext
{
    public class ProjectContext : Microsoft.EntityFrameworkCore.DbContext, IProjectConetext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        { }

        public DbSet<UserRto> Users { get;set; }
        public DbSet<UserRoleRto> UserRoles { get ; set; }

        public Task<int> SaveChangesAync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
