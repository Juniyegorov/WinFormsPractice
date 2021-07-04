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
    public partial class LoginForm : Form
    {
        public string _name = string.Empty;
        public LoginForm()
        {
            InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 42);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Gray;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void topLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void topLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void signIN_Click(object sender, EventArgs e)
        {
            string userLogin = loginField.Text;
            string userPass = passField.Text;

            DataBase dataBase = new DataBase();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @userLogin AND `pass` = @userPass", dataBase.GetConnection());
            command.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = userLogin;
            command.Parameters.Add("@userPass", MySqlDbType.VarChar).Value = userPass;

            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if(dataTable.Rows.Count > 0)
            {
                _name = userLogin;
                Name = userLogin;
                this.Hide();
                MainForm mainForm = new MainForm(_name);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Login or password is incorrect!");
            }
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void passField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                signIN_Click(sender, e);
            }
        }
    }
}
