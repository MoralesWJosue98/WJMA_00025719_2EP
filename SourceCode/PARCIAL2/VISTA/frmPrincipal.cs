using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace PARCIAL2
{
    public partial class frmPrincipal : Form
    {
        private appUser user;
        public frmPrincipal(appUser pUser)
        {
            InitializeComponent();
            user = pUser;
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Bienvenido " + user.userName + "  ID: " + user.idUser + "  [" + (user.userType ? "Administrador" : "Usuario") +
                              "]";

            lblText.Text = "Usuario Conectado: " + user.fullName;

            if (user.userType)
            {
                RefreshControl();    
                RefreshControl2();
                RefreshControl3();
                //RefreshControl4();
                tabControl1.TabPages[5].Parent = null;
                tabControl1.TabPages[5].Parent = null;
                
            }
            else
            {
                tabControl1.TabPages[1].Parent = null;
                tabControl1.TabPages[1].Parent = null;
                tabControl1.TabPages[1].Parent = null;
                tabControl1.TabPages[1].Parent = null;
                
       
                

            }
            
            
            
            
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que deseas salir, " + user.userName + "?", "HUGO DELIVERY",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    e.Cancel = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha sucedido un error, intente dentro de un minuto!", "HUGO DELIVERY",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }  
        }
        
        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text.Length >= 5)
                {
                    appUserDAO.CreateUser(txtName.Text, txtUserName.Text);

                    MessageBox.Show("USUARIO CREADO EXITOSAMENTE!" +
                                    "Values: Password igual nombre, no admin", "HUGO DELIVERY",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtName.Clear();
                    txtUserName.Clear();
                }
                else
                    MessageBox.Show("ERROR!, ingrese un usuario con más de cinco caracteres." ,
                        "HUGO DELIVERY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch(Exception)
            {
                MessageBox.Show("ERROR!, user name registrado, intente con otro!", "HUGO DELIVERY",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        

        private void RefreshControl()
        {
            List<appUser> list = appUserDAO.getLista();

            cmbUserEliminate.DataSource = null;
            cmbUserEliminate.ValueMember = "password";
            cmbUserEliminate.DisplayMember = "userName";
            cmbUserEliminate.DataSource = list;

            dgvView.DataSource = null;
            dgvView.DataSource = list;

            cmbChangePassword.DataSource = null;
            cmbChangePassword.ValueMember = "password";
            cmbChangePassword.DisplayMember = "userName";
            cmbChangePassword.DataSource = list;
            
            
        }


        private void btnEliminate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de querer eliminar el usuario " +  cmbUserEliminate.DisplayMember + " ?",
                "HUGO DELIVERY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                appUserDAO.Delete(cmbUserEliminate.Text);
                                
                MessageBox.Show("Usuario eliminado correctamente!","HUGO DELIVERY",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    
                RefreshControl();    
                             
            }
        }


        private void btnRefreshdgv_Click(object sender, EventArgs e)
        {
            RefreshControl();
        }


        private void btnApply_Click(object sender, EventArgs e)
        {
            bool actualIgual = (txtActualPassword.Text == cmbChangePassword.SelectedValue.ToString());
            bool nuevaIgual = txtNewPassword.Text.Equals(txtConfirm.Text);
            bool nuevaValida = txtNewPassword.Text.Length > 0;

            if (actualIgual && nuevaIgual && nuevaValida)
            {
                try
                {
                    appUserDAO.NewPassword(cmbChangePassword.Text, (txtNewPassword.Text));
                    
                    MessageBox.Show("¡Contraseña actualizada exitosamente!", 
                        "HUGO DELIVERY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
            
                   
                    txtActualPassword.Clear();
                    txtNewPassword.Clear();
                    txtConfirm.Clear();
                    RefreshControl();

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


        private void btnAddBusiness_Click(object sender, EventArgs e)
        {
            if (txtAddBusiness.Text.Length >= 5)
            {
                BusinessDAO.AddBusiness(txtAddBusiness.Text, txtDescriptionBusiness.Text);
                
                MessageBox.Show("Negocio agregado exitosamente!", "HUGO DELIVERY", MessageBoxButtons.OK, MessageBoxIcon.Information );

                txtAddBusiness.Clear();
                txtDescriptionBusiness.Clear();
                RefreshControl2();
                
                

            }
            else
            {
                MessageBox.Show("Error al agregar el negocio!, intentelo más tarde", "HUGO DELIVERY",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnDeleteBusiness_Click(object sender, EventArgs e)
        {
            if (txtDeleteBusiness.Text.Length >= 5)
            {
                BusinessDAO.DeleteBusiness(txtDeleteBusiness.Text);
                
                MessageBox.Show("Negocio eliminado exitosamente!", "HUGO DELIVERY", MessageBoxButtons.OK, MessageBoxIcon.Information );

                txtDeleteBusiness.Clear();
                

            }
            else
            {
                MessageBox.Show("Error al eliminar el negocio!, intentelo más tarde", "HUGO DELIVERY",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void btnRefreshBusiness_Click(object sender, EventArgs e)
        {
            RefreshControl2();
        }
        
         private void RefreshControl2()
               {
                    List<Business> list = BusinessDAO.getLista();
                    
                    dgvBusiness.DataSource = null;
                    dgvBusiness.DataSource = list;

                    cmbBusinessName.DataSource = null;
                    cmbBusinessName.ValueMember = "idbusiness";
                    cmbBusinessName.DisplayMember = "name";
                    cmbBusinessName.DataSource = list;
                    
                     
                    
                    
                    
                   


               }


         private void btnAddProduct_Click(object sender, EventArgs e)
         {
             try{

                 if (txtProductName.Text.Length > 3)
                 {
                     ProductDAO.AddProduct(Convert.ToInt32(cmbBusinessName.SelectedValue), txtProductName.Text);
                     
                     MessageBox.Show("Se agrego el producto correctamente!", "HUGO DELIVERY",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);

                     txtProductName.Clear();
                     RefreshControl2();

                 }
                 else
                        MessageBox.Show("No se pudo ingresar el producto!, intentelo más tarde", "HUGO DELIVERY",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);  
                            
             }
             catch(Exception)
             {
                    MessageBox.Show("Error al ingresar el producto!, intentelo después", "HUGO DELIVERY",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
             }            
         }

         private void RefreshControl3()
         {
             List<Product> list = ProductDAO.getLista();

             cmbProductName.DataSource = null;
             cmbProductName.ValueMember = "idProduct";
             cmbProductName.DisplayMember = "name";
             cmbProductName.DataSource = list;

             dgvProducts.DataSource = null;
             dgvProducts.DataSource = list;
             
           
            

             
             
             
             
         }


         private void btnDeleteProduct_Click(object sender, EventArgs e)
         {
             try{
                 
                    ProductDAO.DeleteProduct(Convert.ToInt32(cmbProductName.SelectedValue));
                     
                     MessageBox.Show("Se elimino el producto correctamente!", "HUGO DELIVERY",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                     RefreshControl3();

                            
             }
             catch(Exception)
             {
                 MessageBox.Show("Error al eliminar el producto!, intentelo después", "HUGO DELIVERY",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
             }               
         }


         private void btrnRefreshDgvProducts_Click(object sender, EventArgs e)
         {
             RefreshControl3();
             
         }
         
        
         
       


         private void btnAddAddress_Click(object sender, EventArgs e)
         {
             if (txtAddress.Text.Length >= 10)
             {
                 AddressDAO.Address(user.idUser, txtAddress.Text);

                 MessageBox.Show("Se ingreso la dirección corecctamente!", "HUGO DELIVERY", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);

                 txtAddress.Clear();

             }
             else
                 MessageBox.Show("Error!, no se pueden ingresar direcciones tan cortas!", "HUGO DELIVERY",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
         }

         private void btnDeleteAddress_Click(object sender, EventArgs e)
         {
             try
             {
                 AddressDAO.DeleteAddress(Convert.ToInt32(nudID.Value));
                 MessageBox.Show("Se elimino la dirección correctamente!", "HUGO DELIVERY",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                     
             }
             catch(Exception){
                 MessageBox.Show("Error!, no se elimino la dirección, intente más tarde", "HUGO DELIVERY",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                     
             }

         }
         
         


         private void btnAddNewDirection_Click(object sender, EventArgs e)
         {
           try
             {
              AddressDAO.NewAddress(txtNewDirection.Text, Convert.ToInt32(nudDirection.Value));
                             
               MessageBox.Show("Se modifico la dirección!", "HUGO DELIVERY", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                             
                txtNewDirection.Clear();
                 
                                                 
                             
              }
           catch (Exception)
            {
             MessageBox.Show("Error!, no se pudo modificar la dirección, intentelo más tarde!", "HUGO DELIVERY",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }
         
         
         
            
    private void btnRefreshDirection_Click(object sender, EventArgs e)
    {
        
        var aux = Convert.ToInt32(user.idUser);
        string query = String.Format(
            "SELECT idAddress, Address FROM ADDRESS WHERE idUser = '{0}';", aux);
          
          var view = ConectionDB.ExecuteQuery(query);
          
          dgvDirection.DataSource = view;
    }


    private void btnAddOrder_Click(object sender, EventArgs e)
    {
       try{
        
        var aux = Convert.ToInt32(nudProduct.Value);
        var aux2 = Convert.ToInt32(nudAddress.Value);
        DateTime time = DateTime.Now;
     
        
        appOrderDAO.AddOrder(time, aux, aux2);
        
        MessageBox.Show("Se agrego la orden!", "HUGO DELIVERY", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
       
        }
       catch(Exception){
        MessageBox.Show("Error!, no se pudo realizar la orden, intente más tarde", "HUGO DELIVERY", MessageBoxButtons.OK, MessageBoxIcon.Error);
       }
        
    }


    private void button2_Click(object sender, EventArgs e)
    {
        try{
        
            var aux = Convert.ToInt32(nudEliminate.Value);
            appOrderDAO.EliminateOrder(aux);
            
            MessageBox.Show("Eliminado con exito!","HUGO DELIVERY", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        
        
        }
        catch(Exception){
            MessageBox.Show("Error!, no se pudo eliminar la orden, intente más tarde", "HUGO DELIVERY",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    private void button3_Click(object sender, EventArgs e)
    {
         var aux = Convert.ToInt32(user.idUser);
                 
                 string query = String.Format(
                 "SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address" + 
                 "FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au" + 
                 "WHERE ao.idProduct = pr.idProduct" + 
                 "AND ao.idAddress = ad.idAddress" + 
                 "AND ad.'{0}' = au.'{0}';",aux);
        
                  var view = ConectionDB.ExecuteQuery(query);
                  dgvOrderUser.DataSource = view;
    }
    
    
    
    
    
    
    }
    
}