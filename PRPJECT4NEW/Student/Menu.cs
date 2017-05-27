﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRPJECT4NEW.Student
{
    public partial class Menu : Form
    {
        public Menu()
        {

            InitializeComponent();
            Buttons_view.Visible = false;
        
        }

        private void Celender_Click(object sender, EventArgs e)
        {
            Student.Calendar frm = new Student.Calendar();
            frm.TopLevel = false;
            //frm.FormBorderStyle = FormBorderStyle.None;
            //frm.WindowState = FormWindowState.Maximized;
            Buttons_view.Controls.Add(frm);
            Buttons_view.Visible = true;
            frm.Show();

        }


        private void Update_Calendar_Button_Click(object sender, EventArgs e)
        {
            Student.UpdateCalendar frm = new Student.UpdateCalendar();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            Buttons_view.Controls.Add(frm);
            Buttons_view.Visible = true;
            frm.Show();
        }

        private void Messages_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Messages panel");
        }

        private void Exams_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exams calendar");
        }

        private void Holidays_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Holidays calendar");
        }
    
        private void Fees_Button_Click(object sender, EventArgs e)
        {
            TuitionFeesForm frm = new TuitionFeesForm();
            frm.TopLevel = false;
            Buttons_view.Controls.Add(frm);
            Buttons_view.Visible = true;
            frm.Show();
        }

        private void Requests_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Requests panel");
        }

        private void Exam_Res_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exams results");
        }

        private void Alerts_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alerts!");
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

            //Calendar frm = new Calendar();
            //frm.TopLevel = false;
            //frm.FormBorderStyle = FormBorderStyle.None;
            //frm.WindowState = FormWindowState.Maximized;
            //Buttons_view.Controls.Add(frm);
            //frm.Show();

        }


    }
}