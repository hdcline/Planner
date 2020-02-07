using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlannerAppOfficial
{
    public partial class frmCalenderView : Form
    {
        public string dueDate;
        //public MonthCalendar mcCalendarView;
        public frmCalenderView()
        {
            InitializeComponent();
        }

        public MonthCalendar GetMc()
        {
            return mcCalenderView;
        }

        private void McCalenderView_DateSelected(object sender, DateRangeEventArgs e)
        {
            frmCalendarDueDate Due = new frmCalendarDueDate(this);
            dueDate = mcCalenderView.SelectionRange.End.Month + "/" + mcCalenderView.SelectionRange.Start.Day + "/" + mcCalenderView.SelectionRange.Start.Year;
            Due.Text = dueDate;
            Due.Show();
            //string dueDate = mcCalenderView.SelectionRange.Start.Month + "\\" + mcCalenderView.SelectionRange.Start.Day + "\\" + mcCalenderView.SelectionRange.Start.Year;
            //Due.Text = dueDate;
            
        }
    }
}
