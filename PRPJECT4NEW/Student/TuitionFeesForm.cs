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
    public partial class TuitionFeesForm : Form
    {
        float approximatedFee = 0;

        public TuitionFeesForm()
        {
            InitializeComponent();
            createGridView();
            getData();
        }

        private void createGridView()
        {
            //Create columns
            tuitionGridView.Columns.Add("courseID", "Course ID");
            tuitionGridView.Columns.Add("courseName", "Course Name");
            tuitionGridView.Columns.Add("nakaz", "Nakaz");
            tuitionGridView.Columns.Add("price", "Price");

            //Paint headers
            tuitionGridView.Columns[0].DefaultCellStyle.BackColor = Utility.HeaderBackColor;
            tuitionGridView.Columns[0].DefaultCellStyle.ForeColor = Color.White;
            tuitionGridView.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            tuitionGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            tuitionGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tuitionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void getData()
        {
            using (Entities context = new Entities())
            {
                //Select cources of a student without final grade 
                var selected =
                    from c in context.Student_Courses
                    where c.stud_Id == Utility.User.ID.ToString() && c.final_grade == null
                    from i in context.courses
                    where i.Course_id == c.course_id
                    select i;

                foreach (var s in selected)
                {
                    float coursePrice = (float)s.Nakaz * Utility.feePerNakaz;
                    tuitionGridView.Rows.Add(s.Course_id, s.Course_name, s.Nakaz, coursePrice);
                    approximatedFee += coursePrice; //Calculate aproximated Tuition Fee
                }
            }

            totalFeeLabel.Text = "Approximate total tuition Fee for this semester: " + approximatedFee + " NIS";
        }

        private void totalFeeLabel_Click(object sender, EventArgs e)
        {

        }

        private void tuitionGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}