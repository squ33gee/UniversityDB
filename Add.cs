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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();

            ConnectUp();
        }

        private void add_teacher_Click(object sender, EventArgs e)
        {
            if (num_teacher.Text != "" || surname_teacher.Text != "" || name_teacher.Text != "" || middle_teacher.Text != "" || pulpit_teacher.Text != "" || special_teacher.Text != "")
            {
                //Временная переменная
                int temp = 0;

                for (int i = 0; i <= Teacher.RowCount - 1; i++)
                {
                    if (Convert.ToString(Teacher.Rows[i].Cells[1].Value) == Convert.ToString(num_teacher.Text))
                    {
                        temp++;
                    }
                }

                //Проверка на "повторку"
                if (temp != 0)
                {
                    MessageBox.Show("Номер не должен повторяться!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string connect = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=university_bd.mdb;";
                    OleDbConnection ConnectionDB = new OleDbConnection(connect);
                    DataTable TableCreate = new DataTable();

                    ConnectionDB.Open();
                    OleDbCommand sql = new OleDbCommand("INSERT INTO Teacher (num_teacher, surname_teacher, name_teacher, middle_teacher, pulpit_teacher, special_teacher) VALUES (" + num_teacher.Text + ", '" + surname_teacher.Text + "', '" + name_teacher.Text + "', '" + middle_teacher.Text + "', '" + pulpit_teacher.Text + "', '" + special_teacher.Text + "');", ConnectionDB);
                    sql.ExecuteNonQuery();

                    MessageBox.Show("Запись добавлена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ConnectUp();
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void add_thing_Click(object sender, EventArgs e)
        {
            if (num_thing.Text != "" || code_thing.Text != "" || name_thing.Text != "" || control_thing.Text != "" || hour_thing.Text != "")
            {
                //Временная переменная
                int temp = 0;

                for (int i = 0; i <= Thing.RowCount - 1; i++)
                {
                    if (Convert.ToString(Thing.Rows[i].Cells[1].Value) == Convert.ToString(num_thing.Text))
                    {
                        temp++;
                    }
                }

                //Проверка на "повторку"
                if (temp != 0)
                {
                    MessageBox.Show("Номер не должен повторяться!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string connect = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=university_bd.mdb;";
                    OleDbConnection ConnectionDB = new OleDbConnection(connect);
                    DataTable TableCreate = new DataTable();

                    ConnectionDB.Open();
                    OleDbCommand sql = new OleDbCommand("INSERT INTO Thing (num_thing, code_thing, name_thing, formcontrol_thing, hour_thing) VALUES (" + num_thing.Text + ", '" + code_thing.Text + "', '" + name_thing.Text + "', '" + control_thing.Text + "', " + hour_thing.Text + ");", ConnectionDB);
                    sql.ExecuteNonQuery();

                    MessageBox.Show("Запись добавлена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ConnectUp();
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void back_teacher_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void back_thing_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void ConnectUp()
        {
            try
            {
                string con = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=university_bd.mdb;";
                OleDbConnection oleDbConn = new OleDbConnection(con);

                oleDbConn.Open();

                //================================
                DataTable dt = new DataTable();
                OleDbCommand sql = new OleDbCommand("SELECT id_teacher AS [ID], num_teacher AS [Номер], surname_teacher & ' ' & name_teacher & ' ' & middle_teacher AS [ФИО], pulpit_teacher AS [Кафедра], special_teacher AS [Должность] FROM teacher;");
                sql.Connection = oleDbConn;
                sql.ExecuteNonQuery();

                OleDbDataAdapter update = new OleDbDataAdapter(sql);
                update.Fill(dt);
                Teacher.DataSource = dt;

                Teacher.Columns[0].Visible = false;

                //=================================
                DataTable dt2 = new DataTable();
                OleDbCommand sql2 = new OleDbCommand("SELECT id_thing AS [ID], num_thing AS [Номер], code_thing AS [Код], name_thing AS [Название], formcontrol_thing AS [Форма контроля], hour_thing AS [Часы] FROM thing;");
                sql2.Connection = oleDbConn;
                sql2.ExecuteNonQuery();

                OleDbDataAdapter update2 = new OleDbDataAdapter(sql2);
                update2.Fill(dt2);
                Thing.DataSource = dt2;

                Thing.Columns[0].Visible = false;

                //=================================

                oleDbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Clear()
        {
            num_teacher.Text = "";
            surname_teacher.Text = "";
            name_teacher.Text = "";
            middle_teacher.Text = "";
            pulpit_teacher.Text = "";
            special_teacher.Text = "";

            num_thing.Text = "";
            code_thing.Text = "";
            name_thing.Text = "";
            control_thing.Text = "";
            hour_thing.Text = "";
        }

        private void num_teacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void num_thing_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void hour_thing_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
