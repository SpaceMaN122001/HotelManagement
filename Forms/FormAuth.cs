using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Forms
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        private void ButtonAuth_Click(object sender, EventArgs e)
        {
            string login = TextBoxLogin.Text;
            string password = TextBoxPassword.Text;

            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполненные не все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (login == "admin" && password == "admin")
            {
                MessageBox.Show("Вход выполнен", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.Show();
                Hide();
            }

            else if (login == "manager" && password == "manager")
            {
                MessageBox.Show("Вход выполнен", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormManager formManager = new FormManager();
                formManager.Show();
                Hide();
            }

            else
                MessageBox.Show("Неправильный логин или пароль", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
