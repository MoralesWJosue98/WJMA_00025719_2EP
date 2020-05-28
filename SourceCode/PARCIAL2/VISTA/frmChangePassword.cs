using System;
using System.Windows.Forms;


namespace PARCIAL2
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            cmbUser.DataSource = null;
            cmbUser.ValueMember = "password";
            cmbUser.DisplayMember = "userName";
            cmbUser.DataSource = appUserDAO.getLista();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            bool actualIgual = (txtPassword.Text == cmbUser.SelectedValue.ToString());
            bool nuevaIgual = txtNewPassword.Text.Equals(txtConfirmPassword.Text);
            bool nuevaValida = txtNewPassword.Text.Length > 0;

            if (actualIgual && nuevaIgual && nuevaValida)
            {
                try
                {
                    appUserDAO.NewPassword(cmbUser.Text, (txtNewPassword.Text));
                    
                    MessageBox.Show("¡Contraseña actualizada exitosamente!", 
                        "HUGO DELIVERY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("¡Contraseña no actualizada! Favor intente mas tarde.", 
                        "HUGO DELIVERY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("¡¡Favor verifique que los datos sean correctos!", 
                    "HUGO DELIVERY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}