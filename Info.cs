using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class Info : Form
    {
        int InfoTable_ID = -1;

        public Info()
        {
            InitializeComponent();

            ConnectUp();
        }

        private void InfoTable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (Convert.ToString(InfoTable.SelectedCells[0].Value) != "")
                {
                    InfoTable_ID = Convert.ToInt32(InfoTable.SelectedCells[0].Value);

                    if (MessageBox.Show("Вы точно хотите удалить запись?", "Сообщение пользователю", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //Подключение БД

                        string connect = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=university_bd.mdb;"; // строка подключения
                        OleDbConnection ConnectionDB = new OleDbConnection(connect); // создаем подключение
                        DataTable TableCreate = new DataTable(); // создаем таблицу 

                        ConnectionDB.Open(); // открываем подключение к базе
                        OleDbCommand sql = new OleDbCommand("DELETE FROM couple WHERE id_couple = " + InfoTable_ID + ";"); // создаем запрос
                        sql.Connection = ConnectionDB; // привязываем запрос к конекту
                        sql.ExecuteNonQuery(); //выполнение

                        MessageBox.Show("Операция успешно выполнена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ConnectUp();

                        InfoTable_ID = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    
        private void button1_Click(object sender, EventArgs e)
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
                OleDbCommand sql = new OleDbCommand("SELECT id_couple AS [ID], (SELECT surname_teacher & ' ' & name_teacher & ' ' & middle_teacher FROM teacher WHERE id_teachers = id_teacher) AS [Преподаватель], (SELECT name_thing FROM thing WHERE id_things = id_thing) AS [Предмет], day_couple & '/' & mouth_couple & '/' & year_couple AS [Дата], hour_couple & ':' & minute_couple AS [Время], auditory_couple AS [Аудитория], group_couple AS [Группа] FROM couple;");
                sql.Connection = oleDbConn;
                sql.ExecuteNonQuery();

                OleDbDataAdapter update = new OleDbDataAdapter(sql);
                update.Fill(dt);
                InfoTable.DataSource = dt;

                InfoTable.Columns[0].Visible = false;

                oleDbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
