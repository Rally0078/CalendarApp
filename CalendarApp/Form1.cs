using System;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;

namespace CalendarApp
{
    public partial class Form1 : Form
    {

        private String monthString;
        private int month, year;
        
        public Form1()
        {
            InitializeComponent();
            DisplayDate();
        }

        private void DisplayDateStep()
        {
            DateTime now = DateTime.Now;

            monthString = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + year;
            monthlb.Text = monthString;
            int days = DateTime.DaysInMonth(year, month);
            DateTime startOfMonth = new DateTime(year, month, 1);

            int dayOfWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfWeek; i++)
            {
                UserControlBlank blnk = new UserControlBlank();
                DayContainer.Controls.Add(blnk);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDate ucdays = new UserControlDate();
                ucdays.days(i);
                if (i == now.Day && month == now.Month)
                {
                    ucdays.BackColor = Color.Fuchsia;
                }
                DayContainer.Controls.Add(ucdays);
            }
        }
        private void nextBt_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();

            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
            DisplayDateStep();
        }

        private void prevBt_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }
            DisplayDateStep();
        }

        private void DayContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisplayDate()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            DateTime startOfMonth = new DateTime(year, month, 1);

            monthString = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + year;
            monthlb.Text = monthString;
            int days = DateTime.DaysInMonth(year, month);

            int dayOfWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfWeek; i++)
            {
                UserControlBlank blnk = new UserControlBlank();
                DayContainer.Controls.Add(blnk);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDate ucdays = new UserControlDate();
                ucdays.days(i);
                if (i == now.Day && month == now.Month)
                {
                    ucdays.BackColor = Color.Fuchsia;
                }
                DayContainer.Controls.Add(ucdays);
            }
        }

    }
}
