using Microsoft.EntityFrameworkCore;
using ProjectX.DataAccess.Core.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectX.DataAccess.Core.Interfaces.DbContext
{
    public interface IProjectConetext : IDisposable,IAsyncDisposable
    {
        DbSet<UserRto> Users { get; set; }
        DbSet<UserRoleRto> UserRoles { get; set; }
        Task<int> SaveChangesAync(CancellationToken cancellationToken = default);
    }
}
