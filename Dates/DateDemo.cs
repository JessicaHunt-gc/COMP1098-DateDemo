using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dates
{
    public partial class DateDemo : Form
    {
        public DateDemo()
        {
            InitializeComponent();
        }

        private DateTime? ParseDate1()
        {
            DateTime dt;
            if (!DateTime.TryParse(txtDate1.Text, out dt))
            {
                MessageBox.Show("Invalid date string");
                return null;
            }
            return dt;
        }
        private void btnParse_Click(object sender, EventArgs e)
        {
            DateTime? dt = ParseDate1();
            if (dt == null)
                return;
            //lblParsedDate.Text = "Parsed Value: " + String.Format("{0:F}", dt);
            lblParsedDate.Text = $"Parsed Value: {dt:F}";
        }

        private void btnDifference_Click(object sender, EventArgs e)
        {
            DateTime? dt = ParseDate1(); //Nullable<DateTime> dt
            if (dt == null)
                return;
            
            DateTime secondDate = dtpSecondDate.Value;

            TimeSpan ts = secondDate - dt.Value;

            lblTimespan.Text = "Total Minutes: "+ts.TotalMinutes +"; Minutes: "+ ts.Minutes+" Total Days: "+ ts.TotalDays+ "; Days: "+ts.Days;

        }
    }
}
