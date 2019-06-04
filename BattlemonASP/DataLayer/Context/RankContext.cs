using BattlemonASP.Models.Classes;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BattlemonASP.DataLayer.Context
{
    public class RankContext : IRoleStore<Rank>
    {
        private readonly string _connectionString;
        public RankContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public Task<IdentityResult> CreateAsync(Rank rank, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> DeleteAsync(Rank rank, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {

        }

        public Task<Rank> FindByIdAsync(string RankID, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Rank> FindByNameAsync(string normalizedRoleName, CancellationToken cancellationToken)
        {
            try
            {
                cancellationToken.ThrowIfCancellationRequested();

                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Rank", connection);
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        Rank rank = default(Rank);
                        if (sqlDataReader.Read())
                        {
                            rank = new Rank();
                        }
                        return Task.FromResult<Rank>(rank);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<string> GetNormalizedRoleNameAsync(Rank rank, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetRoleIdAsync(Rank rank, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetRoleNameAsync(Rank rank, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetNormalizedRoleNameAsync(Rank rank, string normalizedName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetRoleNameAsync(Rank rank, string roleName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(Rank rank, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

