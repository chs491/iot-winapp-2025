using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Dapper;

namespace toyproject05._07
{
    using System.Collections.Generic;
    using System.Data;
    using MySql.Data.MySqlClient;
    using Dapper;

    namespace PlayerApp.Data
    {
        public static class Database
        {
            private const string ConnectionString = "Server=localhost;Database=playerdb;Uid=root;Pwd=your_password;";

            public static IEnumerable<Player> GetAllPlayers()
            {
                using (IDbConnection db = new MySqlConnection(ConnectionString))
                {
                    return db.Query<Player>("SELECT * FROM Players");
                }
            }

            public static void AddPlayer(Player player)
            {
                using (IDbConnection db = new MySqlConnection(ConnectionString))
                {
                    db.Execute("INSERT INTO Players (Name, Position, Age) VALUES (@Name, @Position, @Age)", player);
                }
            }

            public static void DeletePlayer(int id)
            {
                using (IDbConnection db = new MySqlConnection(ConnectionString))
                {
                    db.Execute("DELETE FROM Players WHERE Id = @Id", new { Id = id });
                }
            }
        }
    }

}
