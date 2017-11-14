﻿using Identity.Dapper.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Dapper.Repositories.Contracts
{
    public interface IRoleRepository<TRole, TKey, TUserRole, TRoleClaim>
        where TRole : DapperIdentityRole<TKey, TUserRole, TRoleClaim>
        where TKey : IEquatable<TKey>
        where TUserRole : DapperIdentityUserRole<TKey>
        where TRoleClaim : DapperIdentityRoleClaim<TKey>
    {
        Task<bool> InsertAsync(TRole role, CancellationToken cancellationToken);
        Task<bool> RemoveAsync(TKey id, CancellationToken cancellationToken);
        Task<bool> UpdateAsync(TRole role, CancellationToken cancellationToken);
        Task<TRole> GetByIdAsync(TKey id);
        Task<TRole> GetByNameAsync(string roleName);
    }
}
