using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PARCIAL2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }


        private void frmMenu_Load(object sender, EventArgs e)
        {
            FillControl();
        }

        private void FillControl()
        {
            cmbUser.DataSource = null;
            cmbUser.ValueMember = "password";
            cmbUser.DisplayMember = "userName";
            cmbUser.DataSource = appUserDAO.getLista();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtPassword.Text == cmbUser.SelectedValue.ToString()))
            {
                appUser au = (appUser) cmbUser.SelectedItem;
                                                       
                MessageBox.Show("Bienvenido!", "HUGO DELIVERY" , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                                                       
                frmPrincipal window = new frmPrincipal(au);
                                                                       
                window.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error!, Contraseña incorrecta", "HUGO DELIVERY", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }


       


        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword unaVentana = new frmChangePassword();
            unaVentana.ShowDialog();
            FillControl();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogin_Click(sender, e);
        }
        
        

     
    }
}