using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ForSport.Classes;
using MySql.Data.MySqlClient;


namespace ForSport
{
    public partial class login_menu : Form
    {


        public login_menu()
        {
            InitializeComponent();
            tb_password.PasswordChar = '*';


            
                
         }
            


            /* debug id generatoru
            IdGenerator id = new IdGenerator();
            id.new_id();
            MessageBox.Show(id.id);
            */
        
        

        private void button1_Click(object sender, EventArgs e) // button pre pripojenie
        {
            string username = tb_username.Text; // bere string z textboxu
            string password = tb_password.Text; // bere string z textboxu
            Login login = new Login(username, password);

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                lb_caps.Text = "Máš zapnutý Caps Lock";
            }
            if (tb_username.Text != "" && tb_password.Text != "") // pozrie ci sme zapisali meno aj heslo
            {
                bool valid_login = login.login_verify(); // metoda ktora vrati ci bolo uspesne prihlasenie (heslo sa zhodovalo ku menu)
                if (valid_login == true)
                {
                    MessageBox.Show("Uspesne si sa prihlasil");
                    new app().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Prihlasenie sa nepodarilo alebo nemáš založený účet");
                }
            }
            else
            {
                MessageBox.Show("Musis zadat meno aj heslo!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            register Register = new register(this);
            this.Hide();
            Register.Show();
        }
    }
}
