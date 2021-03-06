﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMNNPM
{
    public partial class Quản_lý : Form
    {
        public Quản_lý()
        {
            InitializeComponent();
            setDefault();
            //set data
            setMonthComboBox();
            setYearComboBox();
            setDateComboBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 mForm = new Form1();
            mForm.Show();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            string date = monthCalendar1.SelectionRange.Start.ToString("dd");
            string month = monthCalendar1.SelectionRange.Start.ToString("MM");
            string year = monthCalendar1.SelectionRange.Start.ToString("yyyy");
            cbDate.Text = date;
            cbMonth.Text = month;
            cbYear.Text = year;
        }

        private void cbDate_TextUpdate(object sender, EventArgs e)
        {
            int[] dateOfMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            try
            {
                monthCalendar1.SetDate(new DateTime(int.Parse(cbYear.Text), int.Parse(cbMonth.Text), int.Parse(cbDate.Text)));
            }
            catch
            {
                try
                {
                    if (int.Parse(cbDate.Text) < 1)
                        cbDate.Text = "1";
                    if ((((int.Parse(cbYear.Text) % 4 == 0) &&
                         !(int.Parse(cbYear.Text) % 100 == 0))
                         || (int.Parse(cbYear.Text) % 400 == 0)))
                        if (int.Parse(cbMonth.Text) == 2)
                            cbDate.Text = "29";
                        else
                        {
                            if (int.Parse(cbDate.Text) > dateOfMonth[int.Parse(cbMonth.Text)])
                                cbDate.Text = dateOfMonth[int.Parse(cbMonth.Text)].ToString();
                        }
                }
                catch
                {
                    return;
                }
            }
        }

        private void cbMonth_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                monthCalendar1.SetDate(new DateTime(int.Parse(cbYear.Text), int.Parse(cbMonth.Text), int.Parse(cbDate.Text)));
            }
            catch
            {
                try
                {
                    if (int.Parse(cbMonth.Text) < 1)
                        cbMonth.Text = "1";
                    if (int.Parse(cbMonth.Text) > 12)
                        cbMonth.Text = "12";
                }
                catch
                {
                    return;
                }
                
            }
        }

        private void cbYear_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                monthCalendar1.SetDate(new DateTime(int.Parse(cbYear.Text), int.Parse(cbMonth.Text), int.Parse(cbDate.Text)));
            }
            catch
            {
                try
                {
                    monthCalendar1.SetDate(new DateTime(int.Parse(cbYear.Text), int.Parse(cbMonth.Text), 28));
                }
                catch
                {
                    return;
                }
            }
        }
        //add năm
        private void setDefault()
        {
            string date = monthCalendar1.SelectionRange.Start.ToString("dd");
            string month = monthCalendar1.SelectionRange.Start.ToString("MM");
            string year = monthCalendar1.SelectionRange.Start.ToString("yyyy");
            cbDate.Text = date;
            cbMonth.Text = month;
            cbYear.Text = year;
        }
        //add năm
        private void setYearComboBox()
        {
            string strThisYear = monthCalendar1.SelectionRange.Start.ToString("yyyy");
            int intThisYear = int.Parse(strThisYear);
            int count = -1; ;
            for (int i = 2000; i <= intThisYear; i++)
            {
                cbYear.Items.Add(i);
                count++;
            }
        }
        //add tháng
        private void setMonthComboBox()
        {
            string strThisMonth = monthCalendar1.SelectionRange.Start.ToString("MM");
            int intThisMonth = int.Parse(strThisMonth);
            int monthIndex = intThisMonth - 1;
            for (int i = 1; i <= 12; i++)
            {
                cbMonth.Items.Add(i);
            }
        }
        private void setDateComboBox()
        {
            string strThisYear = monthCalendar1.SelectionRange.Start.ToString("yyyy");
            int intThisYear = int.Parse(strThisYear);
            string strThisMonth = monthCalendar1.SelectionRange.Start.ToString("MM");
            int intThisMonth = int.Parse(strThisMonth);
            string strThisDate = monthCalendar1.SelectionRange.Start.ToString("dd");
            int intThisDate = int.Parse(strThisDate);
            int numDays = 0;
            int dateIndex;
            switch (intThisMonth)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    numDays = 31;
                    break;
                case 2:
                    if (((intThisYear % 4 == 0) &&
                         !(intThisYear % 100 == 0))
                         || (intThisYear % 400 == 0))
                        numDays = 29;
                    else
                        numDays = 28;
                    break;
                default:
                    numDays = 30;
                    break;
            }
            for (int i = 1; i <= numDays; i++)
            {
                cbDate.Items.Add(i);
            }
            dateIndex = intThisDate - 1;
            cbDate.SelectedIndex = dateIndex;
        }

        private void resetDateComboBox()
        {
            string strThisYear = monthCalendar1.SelectionRange.Start.ToString("yyyy");
            int intThisYear = int.Parse(strThisYear);
            string strThisDate = monthCalendar1.SelectionRange.Start.ToString("dd");
            int intThisDate = int.Parse(strThisDate);
            int numDays = 0;
            int dateIndex;
            int selectedYear = int.Parse(cbYear.Text);
            switch (int.Parse(cbMonth.Text))
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    numDays = 31;
                    break;
                case 2:
                    if (((selectedYear % 4 == 0) &&
                         !(selectedYear % 100 == 0))
                         || (selectedYear % 400 == 0))
                        numDays = 29;
                    else
                        numDays = 28;
                    break;
                default:
                    numDays = 30;
                    break;
            }
            for (int i = 1; i <= numDays; i++)
            {
                cbDate.Items.Add(i);
            }
            dateIndex = intThisDate - 1;
            cbDate.SelectedIndex = dateIndex;
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDate.Items.Clear();
            cbDate.ResetText();
            resetDateComboBox();
            monthCalendar1.SetDate(new DateTime(int.Parse(cbYear.Text), int.Parse(cbMonth.Text), int.Parse(cbDate.Text)));
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDate.Items.Clear();
            cbDate.ResetText();
            resetDateComboBox();
            monthCalendar1.SetDate(new DateTime(int.Parse(cbYear.Text), int.Parse(cbMonth.Text), int.Parse(cbDate.Text)));
        }

        private void cbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthCalendar1.SetDate(new DateTime(int.Parse(cbYear.Text),int.Parse(cbMonth.Text),int.Parse(cbDate.Text)));
        }
    }
}
