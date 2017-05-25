﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BranchA_MazalPlus.Teaching_Assistant
{
    public partial class AddLabExercises : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;
        public AddLabExercises()
        {
            InitializeComponent();
        }

        private void Apply_Button_Click(object sender, EventArgs e)
        {
            try
            {
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False; MultipleActiveResultSets=true";
                this.sqlcon = new SqlConnection(connetionString);
                this.sqlcon.Open();
                checkString(CourseIDButton.Text, "Course");
                checkString(StartTimeButton.Text, "Start");
                checkString(DayButton.Text, "Day");
                checkString(SemesterButton.Text, "Semester");
                checkString(ClassButton.Text, "Class");
                checkString(LabExercise.Text, "Lab_Exercise");
                int first, second, third;
                string firstString, secondString, thirdString;
                first = Convert.ToInt32(StartTimeButton.Text);
                second = Convert.ToInt32(StartTimeButton.Text) + 1;
                third = Convert.ToInt32(StartTimeButton.Text) + 2;
                firstString = first.ToString();
                secondString = second.ToString();
                thirdString = third.ToString();
                int end = Convert.ToInt32(StartTimeButton.Text) + 2;
                string endString = end.ToString();
                SqlCommand cmd = new SqlCommand("select * from courses where Course_id = '" + CourseIDButton.Text + "' and Semester = '" + SemesterButton.Text + "'", sqlcon);
                SqlDataReader dre = cmd.ExecuteReader();
                if (dre.Read() == false)
                {
                    throw new ArgumentException("The course and the semester are not good!");
                }

                dre.Close();
                cmd = new SqlCommand("select * from Teaching_Stuff where ID = '" + Forms.UserID.ID + "' and Course_id = '" + CourseIDButton.Text + "'", sqlcon);
                dre = cmd.ExecuteReader();
                if (dre.Read())
                {
                    throw new ArgumentException("You have already a course with this id!");
                }

                dre.Close();
                if (SemesterButton.Text.Equals("a"))
                {
                    if(first == 8)
                    {
                        cmd = new SqlCommand("select * from Classes_SM1 where day = '" + DayButton.Text + "' and Class_Id = '" + ClassButton.Text + "' and [0" + firstString + "-0" + secondString + "]= 1 and [0" + secondString + "-" + thirdString + "]= 1", sqlcon);
                    }
                    else if(first == 9)
                    {
                        cmd = new SqlCommand("select * from Classes_SM1 where day = '" + DayButton.Text + "' and Class_Id = '" + ClassButton.Text + "' and [0" + firstString + "-" + secondString + "]= 1 and [" + secondString + "-" + thirdString + "]= 1", sqlcon);
                    }
                    else
                    {
                        cmd = new SqlCommand("select * from Classes_SM1 where day = '" + DayButton.Text + "' and Class_Id = '" + ClassButton.Text + "' and [" + firstString + "-" + secondString + "]= 1 and [" + secondString + "-" + thirdString + "]= 1", sqlcon);   
                    }
                }
                else if (SemesterButton.Text.Equals("b"))
                {
                    if (first == 8)
                    {
                        cmd = new SqlCommand("select * from Classes_SM2 where day = '" + DayButton.Text + "' and Class_Id = '" + ClassButton.Text + "' and [0" + firstString + "-0" + secondString + "]= 1 and [0" + secondString + "-" + thirdString + "]= 1", sqlcon);
                    }
                    else if (first == 9)
                    {
                        cmd = new SqlCommand("select * from Classes_SM2 where day = '" + DayButton.Text + "' and Class_Id = '" + ClassButton.Text + "' and [0" + firstString + "-" + secondString + "]= 1 and [" + secondString + "-" + thirdString + "]= 1", sqlcon);
                    }
                    else
                    {
                        cmd = new SqlCommand("select * from Classes_SM2 where day = '" + DayButton.Text + "' and Class_Id = '" + ClassButton.Text + "' and [" + firstString + "-" + secondString + "]= 1 and [" + secondString + "-" + thirdString + "]= 1", sqlcon);
                    }
                }

                dre = cmd.ExecuteReader();
                if (dre.Read() == true)
                {
                    throw new ArgumentException("The class you have chosen is already occupied!");
                }
                dre.Close();

                if (LabExercise.Text.Equals("Lab"))
                {
                    cmd = new SqlCommand("select * from Lecture_Course where Course_ID = '" + CourseIDButton.Text + "' and Course_type = 3", sqlcon);
                    dre = cmd.ExecuteReader();
                    if (dre.Read() == true)
                    {
                        throw new ArgumentException("Someone is already teaching this lab!");
                    }
                    else
                    {
                        dre.Close();
                        SqlCommand cmd3 = new SqlCommand("insert into Lecture_Course (Course_ID, Course_Serial, Course_type, Teacher, Date, Start_time, End_time, Class_number, Student_Count) Values('" + CourseIDButton.Text + "', '" + CourseIDButton.Text + "1', 3, '" + Forms.UserID.ID + "', '" + DayButton.Text + "', '" + StartTimeButton.Text + "', '" + endString + "', '" + ClassButton.Text + "', 0) ; ", sqlcon);
                        dre = cmd3.ExecuteReader();
                        dre.Close();
                    }                   
                }

                else if (LabExercise.Text.Equals("Exercise"))
                {

                    cmd = new SqlCommand("select * from Lecture_Course where Course_ID = '" + CourseIDButton.Text + "' and Course_type = 2", sqlcon);
                    dre = cmd.ExecuteReader();
                    if (dre.Read() == true)
                    {
                        throw new ArgumentException("Someone is already teaching this exercise!");
                    }
                    else
                    {
                        dre.Close();
                        SqlCommand cmd4 = new SqlCommand("insert into Lecture_Course (Course_ID, Course_Serial, Course_type, Teacher, Date, Start_time, End_time, Class_number, Student_Count) Values('" + CourseIDButton.Text + "', '" + CourseIDButton.Text + "1', 2, '" + Forms.UserID.ID + "', '" + DayButton.Text + "', '" + StartTimeButton.Text + "', '" + endString + "', '" + ClassButton.Text + "', 0) ; ", sqlcon);
                        dre = cmd4.ExecuteReader();
                        dre.Close();
                    }
                }            
                else
                    throw new ArgumentException("Error choosing option!");

                cmd = new SqlCommand("insert into Teaching_Stuff (ID, Course_id) Values ('" + Forms.UserID.ID + "', '" + CourseIDButton.Text + "' ) ; ", sqlcon);
                dre = cmd.ExecuteReader();
                dre.Close();

                cmd = new SqlCommand("select Date, Start_time, Class_number from Lecture_Course where Teacher = '" + Forms.UserID.ID + "' and Course_ID = '" + CourseIDButton.Text + "'", sqlcon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SqlCommand cmd1, cmd2;
                    if (SemesterButton.Text.Equals("a"))
                    {
                        if (first == 8)
                        {
                            cmd1 = new SqlCommand("update Classes_SM1 set [0" + firstString + "-0" + secondString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM1 set [0" + secondString + "-" + thirdString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                        }
                        else if (first == 9)
                        {
                            cmd1 = new SqlCommand("update Classes_SM1 set [0" + firstString + "-" + secondString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM1 set [" + secondString + "-" + thirdString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                        }
                        else
                        {
                            cmd1 = new SqlCommand("update Classes_SM1 set [" + firstString + "-" + secondString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM1 set [" + secondString + "-" + thirdString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                        }
                        SqlDataAdapter sda1 = new SqlDataAdapter();
                        sda1.SelectCommand = cmd1;
                        SqlDataAdapter sda2 = new SqlDataAdapter();
                        sda2.SelectCommand = cmd2;
                        DataTable dbdataset = new DataTable();
                        sda1.Fill(dbdataset);
                        sda2.Fill(dbdataset);
                        BindingSource bsource = new BindingSource();
                        bsource.DataSource = dbdataset;
                        sda1.Update(dbdataset);
                        sda2.Update(dbdataset);
                    }
                    else if (SemesterButton.Text.Equals("b"))
                    {
                        if (first == 8)
                        {
                            cmd1 = new SqlCommand("update Classes_SM2 set [0" + firstString + "-0" + secondString + "]= 0 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM2 set [0" + secondString + "-" + thirdString + "]= 0 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                        }
                        else if (first == 9)
                        {
                            cmd1 = new SqlCommand("update Classes_SM2 set [0" + firstString + "-" + secondString + "]= 0 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM2 set [" + secondString + "-" + thirdString + "]= 0 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                        }
                        else
                        {
                            cmd1 = new SqlCommand("update Classes_SM2 set [" + firstString + "-" + secondString + "]= 0 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM2 set [" + secondString + "-" + thirdString + "]= 0 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                        }
                        SqlDataAdapter sda1 = new SqlDataAdapter();
                        sda1.SelectCommand = cmd1;
                        SqlDataAdapter sda2 = new SqlDataAdapter();
                        sda2.SelectCommand = cmd2;
                        DataTable dbdataset = new DataTable();
                        sda1.Fill(dbdataset);
                        sda2.Fill(dbdataset);
                        BindingSource bsource = new BindingSource();
                        bsource.DataSource = dbdataset;
                        sda1.Update(dbdataset);
                        sda2.Update(dbdataset);
                    }
                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                AddLabExercises form2 = new AddLabExercises();
                form2.Show();
            }

            this.sqlcon.Close();
            this.Close();       
        }

        private bool checkString(string str, string check)
        {
            if (check == "Day")
            {
                if(!str.Equals("Sunday") && !str.Equals("Monday") && !str.Equals("Tuesday") && !str.Equals("Wednesday") && !str.Equals("Thursday") && !str.Equals("Friday"))
                    throw new ArgumentException("Day should only be the day of the week.");

            }
            if (check == "Semester")
            {
                if (!str.Equals("a") && !str.Equals("b"))
                    throw new ArgumentException("Semester should only be a or b.");
            }
            if (check == "Start_Time")
            {
                bool allDigits = str.All(char.IsDigit);
                int num = Convert.ToInt32(str);
                if (allDigits == false)
                {
                   if(num < 8 || num > 19)
                        throw new ArgumentException("Start Time should be between 8-19 and only digits.");
                }
            }
            if (check == "Course")
            {
                bool allDigits = str.All(char.IsDigit);
                if (str.Length != 3 || allDigits == false)
                {
                    throw new ArgumentException("Course ID should be only digits and with length of 3.");
                }
            }
            if (check == "Class")
            {
                if (str[0] != 'a' && str[0] != 'f' && str[0] != 's')
                {
                    throw new ArgumentException("This is not a correct class.");
                }

                else if (str[1] != '1')
                {
                    throw new ArgumentException("This is not a correct class.");
                }

                else if (str[2] != '0')
                {
                    throw new ArgumentException("This is not a correct class.");
                }

                else if (str[3] < '1' || str[3] > '4')
                {
                    throw new ArgumentException("This is not a correct class.");
                }
            }
   
            if(check == "Lab_Exercise")
            {
                if(!str.Equals("Lab") && !str.Equals("Exercise"))
                {
                    throw new ArgumentException("Not exercise and not a lab have been chosen.");
                }
            }
            return true;
        }
    }
}
