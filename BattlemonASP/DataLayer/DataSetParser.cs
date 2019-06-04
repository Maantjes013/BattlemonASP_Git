using BattlemonASP.Models.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BattlemonASP.DataLayer
{
    public class DataSetParser
    {
        public static Battlemon DataSetToBattlemon(DataSet set, int rowIndex)
        {
            return new Battlemon()
            {
                BattlemonID = (int)set.Tables[0].Rows[rowIndex][0],
                Name = (string)set.Tables[0].Rows[rowIndex][1],
                HealthPoints = (int)set.Tables[0].Rows[rowIndex][2],
                Attack = (int)set.Tables[0].Rows[rowIndex][3],
                Defence = (int)set.Tables[0].Rows[rowIndex][4],
                Speed = (int)set.Tables[0].Rows[rowIndex][5],
                Type = (string)set.Tables[0].Rows[rowIndex][6],
                Image = (string)set.Tables[0].Rows[rowIndex][7]
            };
        }
    }
}
