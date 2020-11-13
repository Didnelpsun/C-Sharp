using System;
using System.Collections;
using System.Data.OleDb;
using test.DatabaseController;

namespace test.pages
{
    public partial class index : System.Web.UI.Page
    {
        protected string showTime
        {
            get
            {
                return DateTime.Now.ToString();
            }
            set
            {
                showTime = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string showTime = DateTime.Now.ToString();
            ArrayList dropdownList = new ArrayList();
            //for (char a = 'A'; a < 'F'; a++)
            //{
            //    dropdownList.Add(a);
            //}
            //dropdownList.Sort();
            //dropdown.DataSource = dropdownList;
            //dropdown.DataBind();
            AccessController controller = new AccessController();
            OleDbConnection connection = controller.Connection();
            connection.Open();
            string sql = "SELECT name FROM student;";
            OleDbCommand command = new OleDbCommand(sql, connection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dropdownList.Add(reader["name"].ToString());
            }
            dropdown.DataSource = dropdownList;
            dropdown.DataBind();
            reader.Close();
            connection.Close();
        }

        protected void Click(object sender, EventArgs e)
        {
            button1.Text = showTime;
        }
        protected void TextChange(object sender, EventArgs e)
        {
            Console.WriteLine(sender);
            Console.WriteLine(e);
            label.Text = user.Text;
        }
        protected void SelectedChange(object sender, EventArgs e)
        {
            label2.Text = dropdown.SelectedItem.Text;
        }
        //protected void SelectedChange(object sender, EventArgs e)
        //{
        //    label2.Text = dropdown.SelectedItem.Text;
        //}

    }
}