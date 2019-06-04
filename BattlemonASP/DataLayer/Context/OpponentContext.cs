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
    public class OpponentContext : IOpponentInterface
    {
        public OpponentContext()
        {

        }

        public Opponent GetOpponentByID(int opponentID)
        {
            Opponent opponent = new Opponent();

            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "EXEC GetOpponentByID @OpponentID = @GivenOpponentID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GivenOpponentID", opponentID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();

                        opponent = new Opponent(reader["Name"].ToString(), reader["TrainerClass"].ToString());
                    }
                }
            }
            return opponent;
        }
    }
}
