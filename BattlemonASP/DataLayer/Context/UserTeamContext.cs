using BattlemonASP.Models.Classes;
using BattlemonASP.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattlemonASP.DataLayer.Interfaces;

namespace BattlemonASP.DataLayer.Context
{
    class UserTeamContext : IUserTeamInterface
    {
        public List<UserTeam> GetUserTeam()
        {
            List<UserTeam> userTeam = new List<UserTeam>();
            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "SELECT * FROM UserTeam";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            userTeam.Add(new UserTeam(Convert.ToInt32(reader["UserId"]), reader["Battlemon1Id"].ToString(), reader["Battlemon2Id"].ToString(), reader["Battlemon3Id"].ToString(), reader["Battlemon4Id"].ToString(), reader["Battlemon5Id"].ToString(), reader["Battlemon6Id"].ToString(), Convert.ToInt32(reader["XP"]), Convert.ToInt32(reader["Level"])));
                        }
                    }
                }
            }
            return userTeam;
        }

        public UserTeam NewUserTeam(UserTeam userTeam)
        {
            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "INSERT INTO UserTeam (UserId) VALUES (@UserId)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userTeam.userID);

                    if (command.ExecuteNonQuery() == 1)
                    {

                    }
                }
            }
            return userTeam;
        }
    }
}
