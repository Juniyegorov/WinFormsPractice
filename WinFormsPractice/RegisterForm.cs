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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 42);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void topLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void topLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void register_Click(object sender, EventArgs e)
        {
            if(loginField.Text == "" || passField.Text == "")
            {
                MessageBox.Show("Fields are not filled");
                return;
            }
            if (IsUserExists())
            {
                return;
            }

            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`) VALUES (@login, @password)", dataBase.GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passField.Text;

            dataBase.OpenConnection();

            if (command.ExecuteNonQuery() == 1) 
            {
                MessageBox.Show("Account is create");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Account don't create");
            }

            dataBase.CloseConnection();
        }

        public bool IsUserExists()
        {
            DataBase dataBase = new DataBase();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @userLogin", dataBase.GetConnection());
            command.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("This login is busy");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void authorisationLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void passField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                register_Click(sender, e);
            }
        }
    }
}
