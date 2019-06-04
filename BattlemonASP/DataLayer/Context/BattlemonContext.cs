using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BattlemonASP.Models.Classes;
using BattlemonASP.DataLayer;
using System.Data;
using Microsoft.AspNetCore.Authentication;
using BattlemonASP.DataLayer.Interfaces;

namespace BattlemonASP.DataLayer.Context
{
    public class BattlemonContext : BaseMSSQL, IBattlemonInterface
    {
        public BattlemonContext()
        {

        }

        public List<Battlemon> GetAllBattlemon()
        {
            List<Battlemon> mon = new List<Battlemon>();
            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "EXEC GetAllBattlemon";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            mon.Add(new Battlemon(Convert.ToInt32(reader["BattlemonID"]), reader["Name"].ToString(), Convert.ToInt32(reader["Healthpoints"]), Convert.ToInt32(reader["Attack"]), Convert.ToInt32(reader["Defence"]), Convert.ToInt32(reader["Speed"]), reader["Type"].ToString(), reader["Image"].ToString(), reader["Image_back"].ToString()));
                        }
                    }
                }
            }
            return mon;
        }

        public Battlemon GetBattlemonByName(string battlemonName)
        {
            Battlemon mon = new Battlemon();

            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "EXEC GetBattlemonByName @Name = @GivenName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GivenName", battlemonName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();

                        mon = new Battlemon(Convert.ToInt32(reader["BattlemonID"]), reader["Name"].ToString(), Convert.ToInt32(reader["Healthpoints"]), Convert.ToInt32(reader["Attack"]), Convert.ToInt32(reader["Defence"]), Convert.ToInt32(reader["Speed"]), reader["Type"].ToString(), reader["Image"].ToString(), reader["Image_back"].ToString());
                    }
                }
            }
            return mon;
        }

        public Attack GetAttack(int battlemonID)
        {
            Attack attack = new Attack();

            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "EXEC GetAttackByID @battlemonID = @GivenbattlemonID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GivenbattlemonID", battlemonID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();

                        attack = new Attack(reader["Battlemon Name"].ToString(), reader["Attack1"].ToString(), reader["Attack2"].ToString(), reader["Attack3"].ToString(), reader["Attack4"].ToString());
                    }
                }
            }
            return attack;
        }
        public Attack GetAttackPower(string attackName)
        {
            Attack attack = new Attack();

            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "EXEC GetAttackPower @AttackName = @GivenAttackName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GivenAttackName", attackName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();

                        attack = new Attack(Convert.ToInt32(reader["Power"]));
                    }
                }
            }
            return attack;
        }

        public Battlemon GetBattlemonByID(int battlemonID)
        {
            Battlemon mon = new Battlemon();

            using (SqlConnection connection = DatabaseConnection.OpenConnection())
            {
                string query = "EXEC GetBattlemonByID @battlemonID = @GivenbattlemonID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GivenbattlemonID", battlemonID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            mon = new Battlemon(Convert.ToInt32(reader["BattlemonID"]), reader["Name"].ToString(), Convert.ToInt32(reader["Healthpoints"]), Convert.ToInt32(reader["Attack"]), Convert.ToInt32(reader["Defence"]), Convert.ToInt32(reader["Speed"]), reader["Type"].ToString(), reader["Image"].ToString(), reader["Image_back"].ToString());
                        }
                    }
                }
            }
            return mon;
        }

        public void EditBattlemon(Battlemon battlemon)
        {
            string query = "EXEC dbo.EditBattlemon " +
                "@BattlemonID = @GivenBattlemonID" +
                "@Name = @GivenName, " +
                "@Healthpoints = @GivenHealthpoints, " +
                "@Attack = @GivenAttack, " +
                "@Defence = @GivenDefence, " +
                "@Speed = @GivenSpeed, " +
                "@Type = @GivenType"; 

            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("@GivenBattlemonID", battlemon.BattlemonID.ToString()));
            parameters.Add(new KeyValuePair<string, string>("@GivenName", battlemon.Name));
            parameters.Add(new KeyValuePair<string, string>("@GivenHealthpoints", battlemon.HealthPoints.ToString()));  
            parameters.Add(new KeyValuePair<string, string>("@GivenAttack", battlemon.Attack.ToString()));
            parameters.Add(new KeyValuePair<string, string>("@GivenDefence", battlemon.Defence.ToString()));
            parameters.Add(new KeyValuePair<string, string>("@GivenSpeed", battlemon.Speed.ToString()));
            parameters.Add(new KeyValuePair<string, string>("@GivenType", battlemon.Type));

            ExecuteSql(query, parameters);
        }
    }
}
