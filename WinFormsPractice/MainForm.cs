using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPractice
{
    public partial class MainForm : Form
    {
        public string _name = string.Empty;
        public MainForm(string name)
        {
            _name = name;
            InitializeComponent();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void treyButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void sendLabel_Click(object sender, EventArgs e)
        {
            if (messageBox.Text.Length > 250)
            {
                MessageBox.Show($"Max text 250 symbols. Yours: {messageBox.Text.Length}");
                return;
            }
            if (messageBox.Text == String.Empty)
            {
                return;
            }

            DataBase dataBase = new DataBase();
            
            MySqlCommand command = new MySqlCommand("INSERT INTO `message` (`text`, `name`) VALUES (@text, @name)", dataBase.GetConnection());
           
            command.Parameters.Add("@text", MySqlDbType.VarChar).Value = messageBox.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = _name;


            dataBase.OpenConnection();

            command.ExecuteNonQuery();

            dataBase.CloseConnection();
            messageBox.Text = String.Empty;
        }
        private void sendLabel_MouseEnter(object sender, EventArgs e)
        {
            sendLabel.ForeColor = Color.Gray;
        }

        private void sendLabel_MouseLeave(object sender, EventArgs e)
        {
            sendLabel.ForeColor = Color.Black;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            outMessageBox.Clear();
            DataBase dataBase = new DataBase();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `message`", dataBase.GetConnection());

            dataBase.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            foreach (DataRow dt in dataTable.Rows)
            {
                var cells = dt.ItemArray;
               
                for (int i = 0; i < cells.Length; i++)
                {
                    outMessageBox.Text += cells[i];
                    ++i;
                    outMessageBox.Text +=  ": " + cells[i] + Environment.NewLine;
                }
                
            }
            
            dataBase.CloseConnection();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("DELETE FROM `message`", dataBase.GetConnection());

            dataBase.OpenConnection();

            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            dataBase.CloseConnection();
        }

        Point lastPoint;
        private void mainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void messageBox_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                
                sendLabel_Click(sender, e);
            }
                
        }
    }
}
