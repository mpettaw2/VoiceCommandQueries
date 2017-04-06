using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRecognition
{
    public class FunctionsEvents
    {
        static string serverName;
        static string dbName;
        public FunctionsEvents(string serv, string db) {
            serverName = serv;
            dbName = db;
        }

        public static string ServerName {
            get { return serverName; }
        }

        public static String DbName {
            get { return dbName; }
        }
        
        public void startConn(string commandItem, DataGridView item) {
            SqlConnection con2 = new SqlConnection("Data Source=" + ServerName + ";Initial Catalog=" + DbName + ";User ID=sa;Password=Aydian21");
            using (var con =con2)
            {
                SqlCommand cmd = new SqlCommand(commandItem, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                item.DataSource = dt;
                con2.Close();
            }
        }
    
        
        public void DisplayAll(DataGridView gridItem) {
            //displays all records in db
            startConn("selectItem", gridItem);
           }

        public void SortAsced(DataGridView gridItem) {
            //sorts current tbl in ascending order
            startConn("ascend", gridItem);

        }
        public void SortDescend(DataGridView gridItem) {
            //sorts tbl in descendig order
            startConn("descend", gridItem);
        }

        public void clear(DataGridView gridItem) {
            //clears the gridview
            gridItem.DataSource = null;
           
            
        }
        public void exitData() {
            Application.Exit();
        }
    }
}
