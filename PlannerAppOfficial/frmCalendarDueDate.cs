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
    public partial class frmCalendarDueDate : Form
    {
        frmCalenderView calenderView;
        public frmCalendarDueDate(frmCalenderView calenderView)
        {
            this.calenderView = calenderView;
            //lblDue.Text = calenderView.dueDate;
            InitializeComponent();
            lblDue.Text = "Tasks due on " + calenderView.mcCalenderView.SelectionRange.End.Month + "/" + calenderView.mcCalenderView.SelectionRange.Start.Day + "/" + calenderView.mcCalenderView.SelectionRange.Start.Year;

            string connectionString;
            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;

            string sql, output = "";

            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GroupProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            cnn = new SqlConnection(connectionString);

            cnn.Open();

            sql = "Select Task from Calendar where DueDate = ('" + calenderView.mcCalenderView.SelectionRange.End.Month + "/" + calenderView.mcCalenderView.SelectionRange.End.Day + "/" + calenderView.mcCalenderView.SelectionRange.End.Year +
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

            if (count <= 0)
            {
                tbDue.Text = "NO TASKS DUE";
            }

            else
            {
                tbDue.Text = output;
            }
            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }
    }
}
