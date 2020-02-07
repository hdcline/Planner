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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            //tbAdded.Enabled = false;
            string connectionString;
            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;

            DateTime addedDate = DateTime.Now;

            string sql, output = "";

            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GroupProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            cnn = new SqlConnection(connectionString);

            cnn.Open();

            sql = "Select Task from Calendar where AddedDate = ('" + addedDate.Month + "/" + addedDate.Day + "/" + addedDate.Year +
                "')";
            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            int count = 0;
            while (dataReader.Read())
            {
                if (count == 0)
                {
                    output = output + dataReader.GetValue(0) + Environment.NewLine;
                    //tbAdded.Text = Convert.ToString(dataReader.GetValue(0));
                    //tbAdded.AppendText(Environment.NewLine);
                    count++;
                }

                else if (count >= 1)
                {
                    output = output + Environment.NewLine + dataReader.GetValue(0) + Environment.NewLine;
                    //tbAdded.AppendText(Environment.NewLine);
                    //tbAdded.AppendText(Convert.ToString(dataReader.GetValue(0)));
                    //tbAdded.AppendText(Environment.NewLine);
                    count++;
                }
            }
            tbAdded.Text = output;

            dataReader.Close();
            command.Dispose();
            cnn.Close();

            string sql1, output1 = "";
            cnn.Open();

            sql1 = "Select Task from Calendar where DueDate = ('" + addedDate.Month + "/" + addedDate.Day + "/" + addedDate.Year +
                "')";
            command = new SqlCommand(sql1, cnn);

            dataReader = command.ExecuteReader();

            int count1 = 0;
            while (dataReader.Read())
            {
                if (count1 == 0)
                {
                    output1 = output1 + dataReader.GetValue(0) + Environment.NewLine;
                    //tbAdded.Text = Convert.ToString(dataReader.GetValue(0));
                    //tbAdded.AppendText(Environment.NewLine);
                    count1++;
                }

                else if (count1 >= 1)
                {
                    output1 = output1 + Environment.NewLine + dataReader.GetValue(0) + Environment.NewLine;
                    //tbAdded.AppendText(Environment.NewLine);
                    //tbAdded.AppendText(Convert.ToString(dataReader.GetValue(0)));
                    //tbAdded.AppendText(Environment.NewLine);
                    count1++;
                }
            }
            tbDue.Text = output1;

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void MiAdd_Click(object sender, EventArgs e)
        {
            frmAddPage Add = new frmAddPage();
            Add.Show();
        }

        private void MiCalenderView_Click(object sender, EventArgs e)
        {
            frmCalenderView Picker = new frmCalenderView();
            Picker.Show();
        }

        private void MiRefresh_Click(object sender, EventArgs e)
        {
            tbAdded.Clear();
            string connectionString;
            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;

            DateTime addedDate = DateTime.Now;

            string sql, output = "";

            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GroupProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            cnn = new SqlConnection(connectionString);

            cnn.Open();

            sql = "Select Task from Calendar where AddedDate = ('" + addedDate.Month + "/" + addedDate.Day + "/" + addedDate.Year +
                "')";
            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();
            int count = 0;
            //tbAdded.
            while (dataReader.Read())
            {
                if (count == 0)
                {
                    output = output + dataReader.GetValue(0) + Environment.NewLine;
                    //tbAdded.Text = Convert.ToString(dataReader.GetValue(0));
                    //tbAdded.AppendText(Environment.NewLine);
                    count++;
                }

                else if (count >= 1)
                {
                    output = output + Environment.NewLine + dataReader.GetValue(0) + Environment.NewLine;
                    //tbAdded.AppendText(Environment.NewLine);
                    //tbAdded.AppendText(Convert.ToString(dataReader.GetValue(0)));
                    //tbAdded.AppendText(Environment.NewLine);
                    count++;
                }
            }
            tbAdded.Text = output;

            dataReader.Close();
            command.Dispose();
            cnn.Close();

            string sql1, output1 = "";
            sql1 = "Select Task from Calendar where DueDate = ('" + addedDate.Month + "/" + addedDate.Day + "/" + addedDate.Year +
                "')";
            cnn.Open();
            command = new SqlCommand(sql1, cnn);

            dataReader = command.ExecuteReader();

            int count1 = 0;
            while (dataReader.Read())
            {
                if (count1 == 0)
                {
                    output1 = output1 + dataReader.GetValue(0) + Environment.NewLine;
                    //tbAdded.Text = Convert.ToString(dataReader.GetValue(0));
                    //tbAdded.AppendText(Environment.NewLine);
                    count1++;
                }

                else if (count1 >= 1)
                {
                    output1 = output1 + Environment.NewLine + dataReader.GetValue(0) + Environment.NewLine;
                    //tbAdded.AppendText(Environment.NewLine);
                    //tbAdded.AppendText(Convert.ToString(dataReader.GetValue(0)));
                    //tbAdded.AppendText(Environment.NewLine);
                    count1++;
                }
            }
            tbDue.Text = output1;

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }
    }
}
