using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlannerAppOfficial
{
    public partial class frmAddPage : Form
    {
        public frmAddPage()
        {
            InitializeComponent();
        }

        private void BtnUpdatePlanner_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GroupProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            dtpDueDate.Format = DateTimePickerFormat.Short;
            DateTime addedDate = DateTime.Now; 
            
            string sql = "Insert into Calendar (DueDate, Task, AddedDate) values ('" + dtpDueDate.Value.Month + "/" +
                dtpDueDate.Value.Day + "/" + dtpDueDate.Value.Year + "', '" + tbAddItems.Text + "' + CHAR(13), '" + addedDate.Month + "/" + addedDate.Day + "/" + addedDate.Year + "')";

            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

            MessageBox.Show("Your task has been added successfully!");
            tbAddItems.Clear();
        }


    }
}
