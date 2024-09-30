using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPlatform
{
    public static class PublicMethod
    {
        #region SQLite

        public static SQLiteConnection ConnectSqlite(string sqliteDb)
        {
            var connSqlDb = new SQLiteConnection("Data Source=" + sqliteDb);
            try
            {
                return connSqlDb;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR詳見：" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return connSqlDb;
            }
        }
        #endregion

    }




}
