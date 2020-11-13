using System.Data.OleDb;
using System.Web;

namespace test.DatabaseController
{
    public class DatabaseController
    {
        public string ConnectionString;
        public DatabaseController()
        {
            this.ConnectionString = "Provider=Microsoft.Ace.OleDb.12.0;";
        }
        public DatabaseController(string String)
        {
            this.ConnectionString = String;
        }
    }
    public class AccessController : DatabaseController
    {
        public OleDbConnection connection;
        public AccessController()
        {
            //this.ConnectionString += @"Data Source=" + System.Web.HttpContext.Current.Server.MapPath("/_AppData/Database.accdb");
            this.ConnectionString += @"Data Source=" + HttpContext.Current.Server.MapPath("/_AppData/Database.accdb");
        }
        public AccessController(string String) : base(String)
        {
            this.ConnectionString += String;
        }
        public OleDbConnection Connection()
        {
            this.connection = new OleDbConnection(this.ConnectionString);
            return this.connection;
        }
        public void Open()
        {
            this.connection.Open();
        }
        public void Close()
        {
            this.connection.Close();
        }
    }
}