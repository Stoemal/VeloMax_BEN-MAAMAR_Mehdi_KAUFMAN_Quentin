using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Program_Velomax
{
    interface IQueries
    {
        void Query(MySqlConnection connection, string query);
    }
}
