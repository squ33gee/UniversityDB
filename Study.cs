using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace University
{
    public partial class Study : Form
    {
        public Study()
        {
            InitializeComponent();

            try
            {
                string con = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=university_bd.mdb;";
                OleDbConnection oleDbConn = new OleDbConnection(con);

                oleDbConn.Open();

                //================================
                DataTable dt = new DataTable();
                OleDbCommand sql = new OleDbCommand("SELECT num_teacher AS [num], surname_teacher & ' ' & name_teacher & ' ' & middle_teacher AS [fio] FROM teacher;");
                sql.Connection = oleDbConn;
                sql.ExecuteNonQuery();

                OleDbDataReader reader = sql.ExecuteReader();

                while (reader.Read())
                {
                    teacher_combo.Items.Add(reader["num"] + " " + reader["fio"].ToString());
                }

                teacher_combo.Text = "";

                //================================

                DataTable dt2 = new DataTable();
                OleDbCommand sql2 = new OleDbCommand("SELECT num_thing AS [num], name_thing AS [name]  FROM thing;");
                sql2.Connection = oleDbConn;
                sql2.ExecuteNonQuery();

                OleDbDataReader reader2 = sql2.ExecuteReader();

                while (reader2.Read())
                {
                    thing_combo.Items.Add(reader2["num"] + " " + reader2["name"].ToString());
                }

                thing_combo.Text = "";

                oleDbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void save_study_Click(object sender, EventArgs e)
        {
            string[] timing = new string[2];
            timing = maskedTextBox1.Text.Split(':');

            if (timing[0].Trim() == "" || timing[1].Trim() == "" || (Convert.ToInt32(timing[0]) > 23 || Convert.ToInt32(timing[0]) < 0) || (Convert.ToInt32(timing[1]) > 59 || Convert.ToInt32(timing[1]) < 0))
            {
                MessageBox.Show("Введите время корректно!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (teacher_combo.Text != "" && thing_combo.Text != "" && num_audition.Text != "" && num_group.Text != "")
                {
                    int id_teacher = 0, id_thing = 0;

                    string str = "";
                    string[] num_teacher = new string[4]; // препод
                    string[] num_thing = new string[3]; // предмет

                    str = teacher_combo.Text;
                    num_teacher = str.Split(' ');

                    str = thing_combo.Text;
                    num_thing = str.Split(' ');

                    string con = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=university_bd.mdb;";
                    OleDbConnection oleDbConn = new OleDbConnection(con);

                    oleDbConn.Open();
                    OleDbCommand sql1 = new OleDbCommand("SELECT id_teacher AS [ID1] FROM teacher WHERE num_teacher = " + num_teacher[0] + ";");
                    sql1.Connection = oleDbConn;

                    OleDbDataReader reader1 = sql1.ExecuteReader();

                    while (reader1.Read())
                    {
                        id_teacher = Convert.ToInt32(reader1["ID1"]);
                    }

                    OleDbCommand sql2 = new OleDbCommand("SELECT id_thing AS [ID2] FROM thing WHERE num_thing = " + num_thing[0] + ";");
                    sql2.Connection = oleDbConn;

                    OleDbDataReader reader2 = sql2.ExecuteReader();

                    while (reader2.Read())
                    {
                        id_thing = Convert.ToInt32(reader2["ID2"]);
                    }

                    DateTime dt = dateTimePicker1.Value;

                    string str0 = Convert.ToString(dt);

                    string str1 = str0.Substring(0, 2); // day
                    string str2 = str0.Substring(3, 2); // mouth
                    string str3 = str0.Substring(6, 4); // year

                    OleDbCommand sql3 = new OleDbCommand("INSERT INTO couple (id_teachers, id_things, day_couple, mouth_couple, year_couple, hour_couple, minute_couple, auditory_couple, group_couple) VALUES (" + id_teacher + "," + id_thing + ", '" + str1 + "', '" + str2 + "', '" + str3 + "', '" + timing[0] + "', '" + timing[1] + "', '" + num_audition.Text + "', '" + num_group.Text + "');");
                    sql3.Connection = oleDbConn;

                    sql3.ExecuteNonQuery();

                    oleDbConn.Close();

                    MessageBox.Show("Запись добавлена!", "Сообщение", MessageBoxButtons.OK);

                    teacher_combo.SelectedIndex = -1;
                    thing_combo.SelectedIndex = -1;

                    num_audition.Text = "";
                    num_group.Text = "";
                    maskedTextBox1.Text = "";

                    dateTimePicker1.Value = DateTime.Today;
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены!");
                }
            }
        }

        private void back_study_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
