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
    public partial class Edit : Form
    {
        int Teacher_ID = -1;
        int Teacher_Old = -1;

        int Thing_ID = -1;
        int Thing_Old = -1;

        public Edit()
        {
            InitializeComponent();

            ConnectUp();
        }

        private void edit_teacher_Click(object sender, EventArgs e)
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
                if (temp != 0 && Convert.ToInt32(num_teacher.Text) != Teacher_Old)
                {
                    MessageBox.Show("Номер не должен повторяться!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string connect = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=university_bd.mdb;";
                    OleDbConnection ConnectionDB = new OleDbConnection(connect);
                    DataTable TableCreate = new DataTable();

                    ConnectionDB.Open();
                    OleDbCommand sql = new OleDbCommand("UPDATE teacher SET num_teacher = " + num_teacher.Text + ", surname_teacher = '" + surname_teacher.Text + "', name_teacher = '" + name_teacher.Text + "', middle_teacher = '" + middle_teacher.Text + "', pulpit_teacher = '" + pulpit_teacher.Text + "', special_teacher = '" + special_teacher.Text + "' WHERE id_teacher = " + Teacher_ID + ";", ConnectionDB);
                    sql.ExecuteNonQuery();

                    MessageBox.Show("Запись отредактирована!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ConnectUp();
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void edit_thing_Click(object sender, EventArgs e)
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
                if (temp != 0 && Convert.ToInt32(num_thing.Text) != Thing_Old)
                {
                    MessageBox.Show("Номер не должен повторяться!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string connect = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=university_bd.mdb;";
                    OleDbConnection ConnectionDB = new OleDbConnection(connect);
                    DataTable TableCreate = new DataTable();

                    ConnectionDB.Open();
                    OleDbCommand sql = new OleDbCommand("UPDATE Thing SET num_thing = " + num_thing.Text + ", code_thing = '" + code_thing.Text + "', name_thing = " + name_thing.Text + ", formcontrol_thing = '" + control_thing.Text + "', hour_thing = " + hour_thing.Text + " WHERE id_thing = " + Thing_ID + ";", ConnectionDB);
                    sql.ExecuteNonQuery();

                    MessageBox.Show("Запись отредактирована!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void button_thing_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void del_teacher_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить запись?", "Сообщение пользователю", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Подключение БД

                string connect = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=university_bd.mdb;"; // строка подключения
                OleDbConnection ConnectionDB = new OleDbConnection(connect); // создаем подключение
                DataTable TableCreate = new DataTable(); // создаем таблицу 

                ConnectionDB.Open(); // открываем подключение к базе
                OleDbCommand sql = new OleDbCommand("DELETE FROM Teacher WHERE id_teacher = " + Teacher_ID + ";"); // создаем запрос
                sql.Connection = ConnectionDB; // привязываем запрос к конекту
                sql.ExecuteNonQuery(); //выполнение

                MessageBox.Show("Операция успешно выполнена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ConnectUp();
                Clear();
            }
        }

        private void del_thing_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить запись?", "Сообщение пользователю", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Подключение БД

                string connect = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=university_bd.mdb;"; // строка подключения
                OleDbConnection ConnectionDB = new OleDbConnection(connect); // создаем подключение
                DataTable TableCreate = new DataTable(); // создаем таблицу 

                ConnectionDB.Open(); // открываем подключение к базе
                OleDbCommand sql = new OleDbCommand("DELETE FROM Thing WHERE id_thing = " + Thing_ID + ";"); // создаем запрос
                sql.Connection = ConnectionDB; // привязываем запрос к конекту
                sql.ExecuteNonQuery(); //выполнение

                MessageBox.Show("Операция успешно выполнена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ConnectUp();
                Clear();
            }
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

            del_teacher.Enabled = false;
            del_thing.Enabled = false;
        }

        private void Teacher_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (Convert.ToString(Teacher.SelectedCells[0].Value) != "")
                {
                    Teacher_ID = Convert.ToInt32(Teacher.SelectedCells[0].Value);

                    string connect = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=university_bd.mdb;"; // строка подключения
                    OleDbConnection ConnectionDB = new OleDbConnection(connect); // создаем подключение
                    DataTable TableCreate = new DataTable(); // создаем таблицу

                    ConnectionDB.Open(); // открываем подключение к базе
                    OleDbCommand sql = new OleDbCommand("SELECT * FROM Teacher WHERE id_teacher = " + Teacher_ID + ";"); // создаем запрос
                    OleDbDataAdapter update = new OleDbDataAdapter(sql);
                    sql.Connection = ConnectionDB; // привязываем запрос к конекту
                    sql.ExecuteNonQuery(); //выполнение

                    update.Fill(TableCreate);
                    num_teacher.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(1));
                    surname_teacher.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(2));
                    name_teacher.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(3));
                    middle_teacher.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(4));
                    pulpit_teacher.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(5));
                    special_teacher.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(6));

                    Teacher_Old = Convert.ToInt32(TableCreate.Rows[0].ItemArray.GetValue(1));
                    del_teacher.Enabled = true;
                
                    ConnectionDB.Close();              
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Thing_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (Convert.ToString(Thing.SelectedCells[0].Value) != "")
                {
                    Thing_ID = Convert.ToInt32(Thing.SelectedCells[0].Value);

                    string connect = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=university_bd.mdb;"; // строка подключения
                    OleDbConnection ConnectionDB = new OleDbConnection(connect); // создаем подключение
                    DataTable TableCreate = new DataTable(); // создаем таблицу

                    ConnectionDB.Open(); // открываем подключение к базе
                    OleDbCommand sql = new OleDbCommand("SELECT * FROM Thing WHERE id_thing = " + Thing_ID + ";"); // создаем запрос
                    OleDbDataAdapter update = new OleDbDataAdapter(sql);
                    sql.Connection = ConnectionDB; // привязываем запрос к конекту
                    sql.ExecuteNonQuery(); //выполнение

                    update.Fill(TableCreate);
                    num_thing.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(1));
                    code_thing.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(2));
                    name_thing.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(3));
                    control_thing.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(4));
                    hour_thing.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(5));

                    //На всякий пожарный

                    Thing_Old = Convert.ToInt32(TableCreate.Rows[0].ItemArray.GetValue(1));
                    del_thing.Enabled = true;

                    ConnectionDB.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
