using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NonameThing_1
{
    public partial class SetDate : Form
    {
        internal bool isOK = false;
        internal DateTime bdate;
        private readonly List<DayOfWeek> dow = new List<DayOfWeek>() { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday };
        private readonly List<int> hours = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
        private readonly List<int> minutes = new List<int>() { 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55 };
        readonly CultureInfo culture = new CultureInfo("ru-RU");
        List<string> dowr = new List<string>();

        public SetDate()
        {
            InitializeComponent();
            dowr.Clear();
            foreach(DayOfWeek d in dow)
                dowr.Add(culture.DateTimeFormat.GetDayName(d));
            DoWBox.DataSource = dowr;
            HBox.DataSource = hours;
            MBox.DataSource = minutes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day = DoWBox.SelectedIndex + 1;
            int min = MBox.SelectedIndex * 5;
            int hour = HBox.SelectedIndex;

            bdate = new DateTime(0001, 1, day, hour, min, 0);
            isOK = true;
            Close();
        }
    }
}
