using System.ComponentModel;

namespace PARCIAL2
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabWelcome = new System.Windows.Forms.TabPage();
            this.lblText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabCreate = new System.Windows.Forms.TabPage();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabEliminate = new System.Windows.Forms.TabPage();
            this.btnEliminate = new System.Windows.Forms.Button();
            this.cmbUserEliminate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabView = new System.Windows.Forms.TabPage();
            this.btnRefreshdgv = new System.Windows.Forms.Button();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabChange = new System.Windows.Forms.TabPage();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtActualPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbChangePassword = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabBusiness = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabAddBusiness = new System.Windows.Forms.TabPage();
            this.btnAddBusiness = new System.Windows.Forms.Button();
            this.txtDescriptionBusiness = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddBusiness = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tabEliminateBusiness = new System.Windows.Forms.TabPage();
            this.btnDeleteBusiness = new System.Windows.Forms.Button();
            this.txtDeleteBusiness = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.tabSee = new System.Windows.Forms.TabPage();
            this.btnRefreshBusiness = new System.Windows.Forms.Button();
            this.dgvBusiness = new System.Windows.Forms.DataGridView();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabAddProduct = new System.Windows.Forms.TabPage();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cmbBusinessName = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.tabDeleteProduct = new System.Windows.Forms.TabPage();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.tabSeeProduct = new System.Windows.Forms.TabPage();
            this.btrnRefreshDgvProducts = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.tabProductsBusiness = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvRestauranteProduct = new System.Windows.Forms.DataGridView();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnDeleteAddress = new System.Windows.Forms.Button();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.nudDirection = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAddNewDirection = new System.Windows.Forms.Button();
            this.txtNewDirection = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnRefreshDirection = new System.Windows.Forms.Button();
            this.dgvDirection = new System.Windows.Forms.DataGridView();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl6 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.nudAddress = new System.Windows.Forms.NumericUpDown();
            this.nudProduct = new System.Windows.Forms.NumericUpDown();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dtmProduct = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.nudEliminate = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvOrderUser = new System.Windows.Forms.DataGridView();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.tabUser.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            this.tabEliminate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            this.tabView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).BeginInit();
            this.tabChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).BeginInit();
            this.tabBusiness.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabAddBusiness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox6)).BeginInit();
            this.tabEliminateBusiness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox7)).BeginInit();
            this.tabSee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvBusiness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox8)).BeginInit();
            this.tabProduct.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox9)).BeginInit();
            this.tabDeleteProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox10)).BeginInit();
            this.tabSeeProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox11)).BeginInit();
            this.tabProductsBusiness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvRestauranteProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox12)).BeginInit();
            this.tabOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox13)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox14)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox15)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox16)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox17)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.nudProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox18)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudEliminate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox19)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrderUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabWelcome);
            this.tabControl1.Controls.Add(this.tabUser);
            this.tabControl1.Controls.Add(this.tabBusiness);
            this.tabControl1.Controls.Add(this.tabProduct);
            this.tabControl1.Controls.Add(this.tabOrder);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(661, 409);
            this.tabControl1.TabIndex = 0;
            // 
            // tabWelcome
            // 
            this.tabWelcome.BackColor = System.Drawing.Color.MidnightBlue;
            this.tabWelcome.Controls.Add(this.lblText);
            this.tabWelcome.Controls.Add(this.pictureBox1);
            this.tabWelcome.Location = new System.Drawing.Point(4, 25);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tabWelcome.Size = new System.Drawing.Size(653, 380);
            this.tabWelcome.TabIndex = 0;
            this.tabWelcome.Text = "WELCOME";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblText.Location = new System.Drawing.Point(207, 330);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 25);
            this.lblText.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 307);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabUser
            // 
            this.tabUser.BackColor = System.Drawing.Color.Silver;
            this.tabUser.Controls.Add(this.tabControl2);
            this.tabUser.Location = new System.Drawing.Point(4, 25);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(653, 380);
            this.tabUser.TabIndex = 1;
            this.tabUser.Text = "USUARIOS";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabCreate);
            this.tabControl2.Controls.Add(this.tabEliminate);
            this.tabControl2.Controls.Add(this.tabView);
            this.tabControl2.Controls.Add(this.tabChange);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(647, 374);
            this.tabControl2.TabIndex = 0;
            // 
            // tabCreate
            // 
            this.tabCreate.BackColor = System.Drawing.Color.MediumPurple;
            this.tabCreate.Controls.Add(this.btnCreate);
            this.tabCreate.Controls.Add(this.txtUserName);
            this.tabCreate.Controls.Add(this.txtName);
            this.tabCreate.Controls.Add(this.label2);
            this.tabCreate.Controls.Add(this.label1);
            this.tabCreate.Controls.Add(this.pictureBox2);
            this.tabCreate.Location = new System.Drawing.Point(4, 27);
            this.tabCreate.Name = "tabCreate";
            this.tabCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreate.Size = new System.Drawing.Size(639, 343);
            this.tabCreate.TabIndex = 0;
            this.tabCreate.Text = "CREAR";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Black;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreate.Location = new System.Drawing.Point(334, 160);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(208, 57);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "CREAR USUARIO";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtUserName.Location = new System.Drawing.Point(435, 103);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(184, 27);
            this.txtUserName.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtName.Location = new System.Drawing.Point(435, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 27);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(250, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE USUARIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(334, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOMBRE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 310);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabEliminate
            // 
            this.tabEliminate.BackColor = System.Drawing.Color.MediumPurple;
            this.tabEliminate.Controls.Add(this.btnEliminate);
            this.tabEliminate.Controls.Add(this.cmbUserEliminate);
            this.tabEliminate.Controls.Add(this.label3);
            this.tabEliminate.Controls.Add(this.pictureBox3);
            this.tabEliminate.Location = new System.Drawing.Point(4, 27);
            this.tabEliminate.Name = "tabEliminate";
            this.tabEliminate.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminate.Size = new System.Drawing.Size(639, 343);
            this.tabEliminate.TabIndex = 1;
            this.tabEliminate.Text = "ELIMINAR";
            // 
            // btnEliminate
            // 
            this.btnEliminate.BackColor = System.Drawing.Color.Black;
            this.btnEliminate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminate.Location = new System.Drawing.Point(303, 159);
            this.btnEliminate.Name = "btnEliminate";
            this.btnEliminate.Size = new System.Drawing.Size(208, 57);
            this.btnEliminate.TabIndex = 8;
            this.btnEliminate.Text = "ELIMINAR USUARIO";
            this.btnEliminate.UseVisualStyleBackColor = false;
            this.btnEliminate.Click += new System.EventHandler(this.btnEliminate_Click);
            // 
            // cmbUserEliminate
            // 
            this.cmbUserEliminate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbUserEliminate.FormattingEnabled = true;
            this.cmbUserEliminate.Location = new System.Drawing.Point(285, 86);
            this.cmbUserEliminate.Name = "cmbUserEliminate";
            this.cmbUserEliminate.Size = new System.Drawing.Size(240, 31);
            this.cmbUserEliminate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(296, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOMBRE USUARIO";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(20, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(188, 210);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // tabView
            // 
            this.tabView.BackColor = System.Drawing.Color.MediumPurple;
            this.tabView.Controls.Add(this.btnRefreshdgv);
            this.tabView.Controls.Add(this.dgvView);
            this.tabView.Controls.Add(this.pictureBox4);
            this.tabView.Location = new System.Drawing.Point(4, 27);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3);
            this.tabView.Size = new System.Drawing.Size(639, 343);
            this.tabView.TabIndex = 2;
            this.tabView.Text = "VER USUARIOS";
            // 
            // btnRefreshdgv
            // 
            this.btnRefreshdgv.BackColor = System.Drawing.Color.Black;
            this.btnRefreshdgv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshdgv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRefreshdgv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshdgv.Location = new System.Drawing.Point(497, 53);
            this.btnRefreshdgv.Name = "btnRefreshdgv";
            this.btnRefreshdgv.Size = new System.Drawing.Size(120, 57);
            this.btnRefreshdgv.TabIndex = 9;
            this.btnRefreshdgv.Text = "ACTUALIZAR";
            this.btnRefreshdgv.UseVisualStyleBackColor = false;
            this.btnRefreshdgv.Click += new System.EventHandler(this.btnRefreshdgv_Click);
            // 
            // dgvView
            // 
            this.dgvView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvView.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(0, 164);
            this.dgvView.Name = "dgvView";
            this.dgvView.Size = new System.Drawing.Size(640, 179);
            this.dgvView.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(450, 152);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // tabChange
            // 
            this.tabChange.BackColor = System.Drawing.Color.MediumPurple;
            this.tabChange.Controls.Add(this.btnApply);
            this.tabChange.Controls.Add(this.txtNewPassword);
            this.tabChange.Controls.Add(this.txtConfirm);
            this.tabChange.Controls.Add(this.label7);
            this.tabChange.Controls.Add(this.label6);
            this.tabChange.Controls.Add(this.txtActualPassword);
            this.tabChange.Controls.Add(this.label5);
            this.tabChange.Controls.Add(this.cmbChangePassword);
            this.tabChange.Controls.Add(this.label4);
            this.tabChange.Controls.Add(this.pictureBox5);
            this.tabChange.Location = new System.Drawing.Point(4, 27);
            this.tabChange.Name = "tabChange";
            this.tabChange.Padding = new System.Windows.Forms.Padding(3);
            this.tabChange.Size = new System.Drawing.Size(639, 343);
            this.tabChange.TabIndex = 3;
            this.tabChange.Text = "Cambiar Contraseña";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.Black;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnApply.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnApply.Location = new System.Drawing.Point(425, 78);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(208, 57);
            this.btnApply.TabIndex = 12;
            this.btnApply.Text = "APLICAR CAMBIOS";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtNewPassword.Location = new System.Drawing.Point(498, 223);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(116, 27);
            this.txtNewPassword.TabIndex = 11;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtConfirm.Location = new System.Drawing.Point(498, 270);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(116, 27);
            this.txtConfirm.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(393, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "CONFIRMAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(322, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "NUEVA CONTRASEÑA";
            // 
            // txtActualPassword
            // 
            this.txtActualPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtActualPassword.Location = new System.Drawing.Point(191, 276);
            this.txtActualPassword.Name = "txtActualPassword";
            this.txtActualPassword.PasswordChar = '*';
            this.txtActualPassword.Size = new System.Drawing.Size(116, 27);
            this.txtActualPassword.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "CONTRASEÑA ACTUAL";
            // 
            // cmbChangePassword
            // 
            this.cmbChangePassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbChangePassword.FormattingEnabled = true;
            this.cmbChangePassword.Location = new System.Drawing.Point(190, 223);
            this.cmbChangePassword.Name = "cmbChangePassword";
            this.cmbChangePassword.Size = new System.Drawing.Size(116, 27);
            this.cmbChangePassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(26, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "NOMBRE USUARIO";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(38, 23);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(367, 166);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // tabBusiness
            // 
            this.tabBusiness.BackColor = System.Drawing.Color.Silver;
            this.tabBusiness.Controls.Add(this.tabControl3);
            this.tabBusiness.Location = new System.Drawing.Point(4, 25);
            this.tabBusiness.Name = "tabBusiness";
            this.tabBusiness.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusiness.Size = new System.Drawing.Size(653, 380);
            this.tabBusiness.TabIndex = 2;
            this.tabBusiness.Text = "NEGOCIOS";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabAddBusiness);
            this.tabControl3.Controls.Add(this.tabEliminateBusiness);
            this.tabControl3.Controls.Add(this.tabSee);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(3, 3);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(647, 374);
            this.tabControl3.TabIndex = 0;
            // 
            // tabAddBusiness
            // 
            this.tabAddBusiness.BackColor = System.Drawing.Color.MediumOrchid;
            this.tabAddBusiness.Controls.Add(this.btnAddBusiness);
            this.tabAddBusiness.Controls.Add(this.txtDescriptionBusiness);
            this.tabAddBusiness.Controls.Add(this.label9);
            this.tabAddBusiness.Controls.Add(this.txtAddBusiness);
            this.tabAddBusiness.Controls.Add(this.label8);
            this.tabAddBusiness.Controls.Add(this.pictureBox6);
            this.tabAddBusiness.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabAddBusiness.Location = new System.Drawing.Point(4, 25);
            this.tabAddBusiness.Name = "tabAddBusiness";
            this.tabAddBusiness.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddBusiness.Size = new System.Drawing.Size(639, 345);
            this.tabAddBusiness.TabIndex = 0;
            this.tabAddBusiness.Text = "AGREGAR";
            // 
            // btnAddBusiness
            // 
            this.btnAddBusiness.BackColor = System.Drawing.Color.Black;
            this.btnAddBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBusiness.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddBusiness.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddBusiness.Location = new System.Drawing.Point(335, 243);
            this.btnAddBusiness.Name = "btnAddBusiness";
            this.btnAddBusiness.Size = new System.Drawing.Size(219, 57);
            this.btnAddBusiness.TabIndex = 8;
            this.btnAddBusiness.Text = "AGREGAR NEGOCIO";
            this.btnAddBusiness.UseVisualStyleBackColor = false;
            this.btnAddBusiness.Click += new System.EventHandler(this.btnAddBusiness_Click);
            // 
            // txtDescriptionBusiness
            // 
            this.txtDescriptionBusiness.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtDescriptionBusiness.Location = new System.Drawing.Point(348, 183);
            this.txtDescriptionBusiness.Name = "txtDescriptionBusiness";
            this.txtDescriptionBusiness.Size = new System.Drawing.Size(184, 27);
            this.txtDescriptionBusiness.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(312, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "DESCRIPCION DEL NEGOCIO";
            // 
            // txtAddBusiness
            // 
            this.txtAddBusiness.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtAddBusiness.Location = new System.Drawing.Point(348, 76);
            this.txtAddBusiness.Name = "txtAddBusiness";
            this.txtAddBusiness.Size = new System.Drawing.Size(184, 27);
            this.txtAddBusiness.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(332, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "NOMBRE DEL NEGOCIO";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(22, 34);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(222, 250);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // tabEliminateBusiness
            // 
            this.tabEliminateBusiness.BackColor = System.Drawing.Color.MediumOrchid;
            this.tabEliminateBusiness.Controls.Add(this.btnDeleteBusiness);
            this.tabEliminateBusiness.Controls.Add(this.txtDeleteBusiness);
            this.tabEliminateBusiness.Controls.Add(this.label10);
            this.tabEliminateBusiness.Controls.Add(this.pictureBox7);
            this.tabEliminateBusiness.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabEliminateBusiness.Location = new System.Drawing.Point(4, 25);
            this.tabEliminateBusiness.Name = "tabEliminateBusiness";
            this.tabEliminateBusiness.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminateBusiness.Size = new System.Drawing.Size(639, 345);
            this.tabEliminateBusiness.TabIndex = 1;
            this.tabEliminateBusiness.Text = "ELIMINAR";
            // 
            // btnDeleteBusiness
            // 
            this.btnDeleteBusiness.BackColor = System.Drawing.Color.Black;
            this.btnDeleteBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBusiness.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDeleteBusiness.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteBusiness.Location = new System.Drawing.Point(379, 184);
            this.btnDeleteBusiness.Name = "btnDeleteBusiness";
            this.btnDeleteBusiness.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteBusiness.Size = new System.Drawing.Size(219, 57);
            this.btnDeleteBusiness.TabIndex = 9;
            this.btnDeleteBusiness.Text = "ELIMINAR NEGOCIO";
            this.btnDeleteBusiness.UseVisualStyleBackColor = false;
            this.btnDeleteBusiness.Click += new System.EventHandler(this.btnDeleteBusiness_Click);
            // 
            // txtDeleteBusiness
            // 
            this.txtDeleteBusiness.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtDeleteBusiness.Location = new System.Drawing.Point(395, 109);
            this.txtDeleteBusiness.Name = "txtDeleteBusiness";
            this.txtDeleteBusiness.Size = new System.Drawing.Size(184, 27);
            this.txtDeleteBusiness.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(379, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "NOMBRE DEL NEGOCIO";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(27, 32);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(284, 276);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            // 
            // tabSee
            // 
            this.tabSee.BackColor = System.Drawing.Color.MediumOrchid;
            this.tabSee.Controls.Add(this.btnRefreshBusiness);
            this.tabSee.Controls.Add(this.dgvBusiness);
            this.tabSee.Controls.Add(this.pictureBox8);
            this.tabSee.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabSee.Location = new System.Drawing.Point(4, 25);
            this.tabSee.Name = "tabSee";
            this.tabSee.Padding = new System.Windows.Forms.Padding(3);
            this.tabSee.Size = new System.Drawing.Size(639, 345);
            this.tabSee.TabIndex = 2;
            this.tabSee.Text = "VER NEGOCIO";
            // 
            // btnRefreshBusiness
            // 
            this.btnRefreshBusiness.BackColor = System.Drawing.Color.Black;
            this.btnRefreshBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshBusiness.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRefreshBusiness.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshBusiness.Location = new System.Drawing.Point(496, 51);
            this.btnRefreshBusiness.Name = "btnRefreshBusiness";
            this.btnRefreshBusiness.Size = new System.Drawing.Size(120, 57);
            this.btnRefreshBusiness.TabIndex = 12;
            this.btnRefreshBusiness.Text = "ACTUALIZAR";
            this.btnRefreshBusiness.UseVisualStyleBackColor = false;
            this.btnRefreshBusiness.Click += new System.EventHandler(this.btnRefreshBusiness_Click);
            // 
            // dgvBusiness
            // 
            this.dgvBusiness.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBusiness.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBusiness.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dgvBusiness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusiness.Location = new System.Drawing.Point(-1, 162);
            this.dgvBusiness.Name = "dgvBusiness";
            this.dgvBusiness.Size = new System.Drawing.Size(640, 179);
            this.dgvBusiness.TabIndex = 11;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(5, 4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(450, 152);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 10;
            this.pictureBox8.TabStop = false;
            // 
            // tabProduct
            // 
            this.tabProduct.BackColor = System.Drawing.Color.Silver;
            this.tabProduct.Controls.Add(this.tabControl4);
            this.tabProduct.Location = new System.Drawing.Point(4, 25);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(653, 380);
            this.tabProduct.TabIndex = 3;
            this.tabProduct.Text = "PRODUCTOS";
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabAddProduct);
            this.tabControl4.Controls.Add(this.tabDeleteProduct);
            this.tabControl4.Controls.Add(this.tabSeeProduct);
            this.tabControl4.Controls.Add(this.tabProductsBusiness);
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabControl4.Location = new System.Drawing.Point(3, 3);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(647, 374);
            this.tabControl4.TabIndex = 0;
            // 
            // tabAddProduct
            // 
            this.tabAddProduct.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabAddProduct.Controls.Add(this.btnAddProduct);
            this.tabAddProduct.Controls.Add(this.cmbBusinessName);
            this.tabAddProduct.Controls.Add(this.label12);
            this.tabAddProduct.Controls.Add(this.txtProductName);
            this.tabAddProduct.Controls.Add(this.label11);
            this.tabAddProduct.Controls.Add(this.pictureBox9);
            this.tabAddProduct.Location = new System.Drawing.Point(4, 25);
            this.tabAddProduct.Name = "tabAddProduct";
            this.tabAddProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddProduct.Size = new System.Drawing.Size(639, 345);
            this.tabAddProduct.TabIndex = 0;
            this.tabAddProduct.Text = "AÑADIR PRODUCTO";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Black;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProduct.Location = new System.Drawing.Point(352, 222);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(208, 57);
            this.btnAddProduct.TabIndex = 9;
            this.btnAddProduct.Text = "AGREGAR PRODUCTO";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cmbBusinessName
            // 
            this.cmbBusinessName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbBusinessName.FormattingEnabled = true;
            this.cmbBusinessName.Location = new System.Drawing.Point(324, 162);
            this.cmbBusinessName.Name = "cmbBusinessName";
            this.cmbBusinessName.Size = new System.Drawing.Size(240, 31);
            this.cmbBusinessName.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(324, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(236, 25);
            this.label12.TabIndex = 7;
            this.label12.Text = "NOMBRE DEL NEGOCIO";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtProductName.Location = new System.Drawing.Point(355, 70);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(184, 27);
            this.txtProductName.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(324, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(253, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "NOMBRE DEL PRODUCTO";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(27, 37);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(231, 255);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            // 
            // tabDeleteProduct
            // 
            this.tabDeleteProduct.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabDeleteProduct.Controls.Add(this.btnDeleteProduct);
            this.tabDeleteProduct.Controls.Add(this.cmbProductName);
            this.tabDeleteProduct.Controls.Add(this.label13);
            this.tabDeleteProduct.Controls.Add(this.pictureBox10);
            this.tabDeleteProduct.Location = new System.Drawing.Point(4, 25);
            this.tabDeleteProduct.Name = "tabDeleteProduct";
            this.tabDeleteProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeleteProduct.Size = new System.Drawing.Size(639, 345);
            this.tabDeleteProduct.TabIndex = 1;
            this.tabDeleteProduct.Text = "ELIMINAR PRODUCTO";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Black;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteProduct.Location = new System.Drawing.Point(358, 167);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(208, 57);
            this.btnDeleteProduct.TabIndex = 10;
            this.btnDeleteProduct.Text = "ELIMINAR PRODUCTO";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // cmbProductName
            // 
            this.cmbProductName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(339, 103);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(240, 31);
            this.cmbProductName.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(326, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(253, 25);
            this.label13.TabIndex = 5;
            this.label13.Text = "NOMBRE DEL PRODUCTO";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(22, 40);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(261, 240);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 2;
            this.pictureBox10.TabStop = false;
            // 
            // tabSeeProduct
            // 
            this.tabSeeProduct.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabSeeProduct.Controls.Add(this.btrnRefreshDgvProducts);
            this.tabSeeProduct.Controls.Add(this.dgvProducts);
            this.tabSeeProduct.Controls.Add(this.pictureBox11);
            this.tabSeeProduct.Location = new System.Drawing.Point(4, 25);
            this.tabSeeProduct.Name = "tabSeeProduct";
            this.tabSeeProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeeProduct.Size = new System.Drawing.Size(639, 345);
            this.tabSeeProduct.TabIndex = 2;
            this.tabSeeProduct.Text = "VER PRODUCTOS";
            // 
            // btrnRefreshDgvProducts
            // 
            this.btrnRefreshDgvProducts.BackColor = System.Drawing.Color.Black;
            this.btrnRefreshDgvProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btrnRefreshDgvProducts.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btrnRefreshDgvProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btrnRefreshDgvProducts.Location = new System.Drawing.Point(496, 51);
            this.btrnRefreshDgvProducts.Name = "btrnRefreshDgvProducts";
            this.btrnRefreshDgvProducts.Size = new System.Drawing.Size(120, 57);
            this.btrnRefreshDgvProducts.TabIndex = 15;
            this.btrnRefreshDgvProducts.Text = "ACTUALIZAR";
            this.btrnRefreshDgvProducts.UseVisualStyleBackColor = false;
            this.btrnRefreshDgvProducts.Click += new System.EventHandler(this.btrnRefreshDgvProducts_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(-1, 162);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(640, 179);
            this.dgvProducts.TabIndex = 14;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(5, 4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(450, 152);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 13;
            this.pictureBox11.TabStop = false;
            // 
            // tabProductsBusiness
            // 
            this.tabProductsBusiness.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabProductsBusiness.Controls.Add(this.numericUpDown1);
            this.tabProductsBusiness.Controls.Add(this.label14);
            this.tabProductsBusiness.Controls.Add(this.button1);
            this.tabProductsBusiness.Controls.Add(this.dgvRestauranteProduct);
            this.tabProductsBusiness.Controls.Add(this.pictureBox12);
            this.tabProductsBusiness.Location = new System.Drawing.Point(4, 25);
            this.tabProductsBusiness.Name = "tabProductsBusiness";
            this.tabProductsBusiness.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductsBusiness.Size = new System.Drawing.Size(639, 345);
            this.tabProductsBusiness.TabIndex = 3;
            this.tabProductsBusiness.Text = "VER PRODUCTOS RESTAURANTE";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(519, 55);
            this.numericUpDown1.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 23);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(494, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 23);
            this.label14.TabIndex = 20;
            this.label14.Text = "ID NEGOCIO";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(491, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 57);
            this.button1.TabIndex = 18;
            this.button1.Text = "ACTUALIZAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvRestauranteProduct
            // 
            this.dgvRestauranteProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRestauranteProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRestauranteProduct.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dgvRestauranteProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestauranteProduct.Location = new System.Drawing.Point(-1, 162);
            this.dgvRestauranteProduct.Name = "dgvRestauranteProduct";
            this.dgvRestauranteProduct.Size = new System.Drawing.Size(640, 179);
            this.dgvRestauranteProduct.TabIndex = 17;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(5, 4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(450, 152);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 16;
            this.pictureBox12.TabStop = false;
            // 
            // tabOrder
            // 
            this.tabOrder.BackColor = System.Drawing.Color.SkyBlue;
            this.tabOrder.Controls.Add(this.dgvOrders);
            this.tabOrder.Controls.Add(this.pictureBox13);
            this.tabOrder.Location = new System.Drawing.Point(4, 25);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrder.Size = new System.Drawing.Size(653, 380);
            this.tabOrder.TabIndex = 4;
            this.tabOrder.Text = "ORDENES";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(0, 174);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(653, 206);
            this.dgvOrders.TabIndex = 18;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(95, 16);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(450, 152);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 17;
            this.pictureBox13.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage1.Controls.Add(this.tabControl5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(653, 380);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "DIRECCIÓN";
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage3);
            this.tabControl5.Controls.Add(this.tabPage4);
            this.tabControl5.Controls.Add(this.tabPage5);
            this.tabControl5.Controls.Add(this.tabPage6);
            this.tabControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl5.Location = new System.Drawing.Point(3, 3);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(647, 374);
            this.tabControl5.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Plum;
            this.tabPage3.Controls.Add(this.btnAddAddress);
            this.tabPage3.Controls.Add(this.txtAddress);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.pictureBox14);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(639, 345);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "AGREGAR ";
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.BackColor = System.Drawing.Color.Black;
            this.btnAddAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddAddress.ForeColor = System.Drawing.Color.Snow;
            this.btnAddAddress.Location = new System.Drawing.Point(329, 176);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(213, 49);
            this.btnAddAddress.TabIndex = 6;
            this.btnAddAddress.Text = "AGREGAR DIRECCIÓN";
            this.btnAddAddress.UseVisualStyleBackColor = false;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtAddress.Location = new System.Drawing.Point(340, 98);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(184, 27);
            this.txtAddress.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(365, 54);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(122, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "DIRECCIÓN";
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(30, 19);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(214, 310);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 1;
            this.pictureBox14.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Plum;
            this.tabPage4.Controls.Add(this.btnDeleteAddress);
            this.tabPage4.Controls.Add(this.nudID);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.pictureBox15);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(639, 345);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "ELIMINAR";
            // 
            // btnDeleteAddress
            // 
            this.btnDeleteAddress.BackColor = System.Drawing.Color.Black;
            this.btnDeleteAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDeleteAddress.ForeColor = System.Drawing.Color.Snow;
            this.btnDeleteAddress.Location = new System.Drawing.Point(362, 181);
            this.btnDeleteAddress.Name = "btnDeleteAddress";
            this.btnDeleteAddress.Size = new System.Drawing.Size(213, 49);
            this.btnDeleteAddress.TabIndex = 7;
            this.btnDeleteAddress.Text = "ELIMINAR DIRECCIÓN";
            this.btnDeleteAddress.UseVisualStyleBackColor = false;
            this.btnDeleteAddress.Click += new System.EventHandler(this.btnDeleteAddress_Click);
            // 
            // nudID
            // 
            this.nudID.Location = new System.Drawing.Point(393, 120);
            this.nudID.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(160, 23);
            this.nudID.TabIndex = 4;
            this.nudID.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(393, 79);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label16.Size = new System.Drawing.Size(151, 25);
            this.label16.TabIndex = 3;
            this.label16.Text = "ID DIRECCIÓN";
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(28, 20);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(284, 276);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 2;
            this.pictureBox15.TabStop = false;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Plum;
            this.tabPage5.Controls.Add(this.nudDirection);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.btnAddNewDirection);
            this.tabPage5.Controls.Add(this.txtNewDirection);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.pictureBox16);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(639, 345);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "MODIFICAR";
            // 
            // nudDirection
            // 
            this.nudDirection.Location = new System.Drawing.Point(355, 89);
            this.nudDirection.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudDirection.Name = "nudDirection";
            this.nudDirection.Size = new System.Drawing.Size(160, 23);
            this.nudDirection.TabIndex = 10;
            this.nudDirection.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(364, 42);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label17.Size = new System.Drawing.Size(151, 25);
            this.label17.TabIndex = 9;
            this.label17.Text = "ID DIRECCIÓN";
            // 
            // btnAddNewDirection
            // 
            this.btnAddNewDirection.BackColor = System.Drawing.Color.Black;
            this.btnAddNewDirection.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddNewDirection.ForeColor = System.Drawing.Color.Snow;
            this.btnAddNewDirection.Location = new System.Drawing.Point(326, 254);
            this.btnAddNewDirection.Name = "btnAddNewDirection";
            this.btnAddNewDirection.Size = new System.Drawing.Size(239, 49);
            this.btnAddNewDirection.TabIndex = 8;
            this.btnAddNewDirection.Text = "AGREGAR DIRECCIÓN";
            this.btnAddNewDirection.UseVisualStyleBackColor = false;
            this.btnAddNewDirection.Click += new System.EventHandler(this.btnAddNewDirection_Click);
            // 
            // txtNewDirection
            // 
            this.txtNewDirection.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtNewDirection.Location = new System.Drawing.Point(350, 188);
            this.txtNewDirection.Name = "txtNewDirection";
            this.txtNewDirection.Size = new System.Drawing.Size(184, 27);
            this.txtNewDirection.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(339, 137);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label18.Size = new System.Drawing.Size(195, 25);
            this.label18.TabIndex = 6;
            this.label18.Text = "NUEVA DIRECCIÓN";
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(33, 68);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(221, 211);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 3;
            this.pictureBox16.TabStop = false;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Plum;
            this.tabPage6.Controls.Add(this.btnRefreshDirection);
            this.tabPage6.Controls.Add(this.dgvDirection);
            this.tabPage6.Controls.Add(this.pictureBox17);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(639, 345);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "VER";
            // 
            // btnRefreshDirection
            // 
            this.btnRefreshDirection.BackColor = System.Drawing.Color.Black;
            this.btnRefreshDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDirection.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRefreshDirection.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshDirection.Location = new System.Drawing.Point(494, 17);
            this.btnRefreshDirection.Name = "btnRefreshDirection";
            this.btnRefreshDirection.Size = new System.Drawing.Size(120, 57);
            this.btnRefreshDirection.TabIndex = 18;
            this.btnRefreshDirection.Text = "ACTUALIZAR";
            this.btnRefreshDirection.UseVisualStyleBackColor = false;
            this.btnRefreshDirection.Click += new System.EventHandler(this.btnRefreshDirection_Click);
            // 
            // dgvDirection
            // 
            this.dgvDirection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDirection.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDirection.BackgroundColor = System.Drawing.Color.Plum;
            this.dgvDirection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirection.Location = new System.Drawing.Point(-1, 162);
            this.dgvDirection.Name = "dgvDirection";
            this.dgvDirection.Size = new System.Drawing.Size(640, 179);
            this.dgvDirection.TabIndex = 17;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(5, 4);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(450, 152);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 16;
            this.pictureBox17.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage2.Controls.Add(this.tabControl6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(653, 380);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "ORDENES";
            // 
            // tabControl6
            // 
            this.tabControl6.Controls.Add(this.tabPage7);
            this.tabControl6.Controls.Add(this.tabPage8);
            this.tabControl6.Controls.Add(this.tabPage9);
            this.tabControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabControl6.Location = new System.Drawing.Point(3, 3);
            this.tabControl6.Name = "tabControl6";
            this.tabControl6.SelectedIndex = 0;
            this.tabControl6.Size = new System.Drawing.Size(647, 374);
            this.tabControl6.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.Indigo;
            this.tabPage7.Controls.Add(this.nudAddress);
            this.tabPage7.Controls.Add(this.nudProduct);
            this.tabPage7.Controls.Add(this.btnAddOrder);
            this.tabPage7.Controls.Add(this.label21);
            this.tabPage7.Controls.Add(this.label20);
            this.tabPage7.Controls.Add(this.dtmProduct);
            this.tabPage7.Controls.Add(this.label19);
            this.tabPage7.Controls.Add(this.pictureBox18);
            this.tabPage7.Location = new System.Drawing.Point(4, 27);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(639, 343);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "CREAR ORDEN";
            // 
            // nudAddress
            // 
            this.nudAddress.Location = new System.Drawing.Point(377, 181);
            this.nudAddress.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudAddress.Name = "nudAddress";
            this.nudAddress.Size = new System.Drawing.Size(160, 26);
            this.nudAddress.TabIndex = 11;
            this.nudAddress.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // nudProduct
            // 
            this.nudProduct.Location = new System.Drawing.Point(377, 111);
            this.nudProduct.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudProduct.Name = "nudProduct";
            this.nudProduct.Size = new System.Drawing.Size(160, 26);
            this.nudProduct.TabIndex = 10;
            this.nudProduct.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.Black;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddOrder.Location = new System.Drawing.Point(276, 234);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(208, 57);
            this.btnAddOrder.TabIndex = 9;
            this.btnAddOrder.Text = "AGREGAR ORDEN";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(213, 182);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label21.Size = new System.Drawing.Size(122, 25);
            this.label21.TabIndex = 7;
            this.label21.Text = "DIRECCIÓN";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(213, 112);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(120, 25);
            this.label20.TabIndex = 5;
            this.label20.Text = "PRODUCTO";
            // 
            // dtmProduct
            // 
            this.dtmProduct.CustomFormat = "2020/05/28";
            this.dtmProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtmProduct.Location = new System.Drawing.Point(321, 35);
            this.dtmProduct.MinDate = new System.DateTime(2020, 5, 28, 0, 0, 0, 0);
            this.dtmProduct.Name = "dtmProduct";
            this.dtmProduct.Size = new System.Drawing.Size(276, 26);
            this.dtmProduct.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(229, 35);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label19.Size = new System.Drawing.Size(75, 25);
            this.label19.TabIndex = 3;
            this.label19.Text = "FECHA";
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(19, 18);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(175, 214);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 2;
            this.pictureBox18.TabStop = false;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.Indigo;
            this.tabPage8.Controls.Add(this.button2);
            this.tabPage8.Controls.Add(this.nudEliminate);
            this.tabPage8.Controls.Add(this.label22);
            this.tabPage8.Controls.Add(this.pictureBox19);
            this.tabPage8.Location = new System.Drawing.Point(4, 27);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(639, 343);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "ELIMINAR ORDEN";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(305, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 57);
            this.button2.TabIndex = 12;
            this.button2.Text = "ELIMINAR ORDEN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nudEliminate
            // 
            this.nudEliminate.Location = new System.Drawing.Point(332, 145);
            this.nudEliminate.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudEliminate.Name = "nudEliminate";
            this.nudEliminate.Size = new System.Drawing.Size(160, 26);
            this.nudEliminate.TabIndex = 11;
            this.nudEliminate.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Location = new System.Drawing.Point(349, 86);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label22.Size = new System.Drawing.Size(109, 25);
            this.label22.TabIndex = 6;
            this.label22.Text = "ID ORDEN";
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(53, 56);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(175, 214);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 3;
            this.pictureBox19.TabStop = false;
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.Indigo;
            this.tabPage9.Controls.Add(this.button3);
            this.tabPage9.Controls.Add(this.dgvOrderUser);
            this.tabPage9.Location = new System.Drawing.Point(4, 27);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(639, 343);
            this.tabPage9.TabIndex = 2;
            this.tabPage9.Text = "VER ORDEN";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(217, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 57);
            this.button3.TabIndex = 20;
            this.button3.Text = "ACTUALIZAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvOrderUser
            // 
            this.dgvOrderUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrderUser.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvOrderUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderUser.Location = new System.Drawing.Point(-3, 127);
            this.dgvOrderUser.Name = "dgvOrderUser";
            this.dgvOrderUser.Size = new System.Drawing.Size(642, 223);
            this.dgvOrderUser.TabIndex = 19;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblWelcome.Location = new System.Drawing.Point(256, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 23);
            this.lblWelcome.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(663, 453);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BIENVENIDO!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabWelcome.ResumeLayout(false);
            this.tabWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.tabUser.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabCreate.ResumeLayout(false);
            this.tabCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.tabEliminate.ResumeLayout(false);
            this.tabEliminate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            this.tabView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvView)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).EndInit();
            this.tabChange.ResumeLayout(false);
            this.tabChange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).EndInit();
            this.tabBusiness.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabAddBusiness.ResumeLayout(false);
            this.tabAddBusiness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox6)).EndInit();
            this.tabEliminateBusiness.ResumeLayout(false);
            this.tabEliminateBusiness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox7)).EndInit();
            this.tabSee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvBusiness)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox8)).EndInit();
            this.tabProduct.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabAddProduct.ResumeLayout(false);
            this.tabAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox9)).EndInit();
            this.tabDeleteProduct.ResumeLayout(false);
            this.tabDeleteProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox10)).EndInit();
            this.tabSeeProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox11)).EndInit();
            this.tabProductsBusiness.ResumeLayout(false);
            this.tabProductsBusiness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvRestauranteProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox12)).EndInit();
            this.tabOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox13)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabControl5.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox14)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudID)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox15)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox16)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox17)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControl6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.nudProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox18)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudEliminate)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox19)).EndInit();
            this.tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrderUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Button btnAddBusiness;
        private System.Windows.Forms.Button btnAddNewDirection;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDeleteAddress;
        private System.Windows.Forms.Button btnDeleteBusiness;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEliminate;
        private System.Windows.Forms.Button btnRefreshBusiness;
        private System.Windows.Forms.Button btnRefreshdgv;
        private System.Windows.Forms.Button btnRefreshDirection;
        private System.Windows.Forms.Button btrnRefreshDgvProducts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbBusinessName;
        private System.Windows.Forms.ComboBox cmbChangePassword;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.ComboBox cmbUserEliminate;
        private System.Windows.Forms.DataGridView dgvBusiness;
        private System.Windows.Forms.DataGridView dgvDirection;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dgvOrderUser;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvRestauranteProduct;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.DateTimePicker dtmProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.NumericUpDown nudAddress;
        private System.Windows.Forms.NumericUpDown nudDirection;
        private System.Windows.Forms.NumericUpDown nudEliminate;
        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.NumericUpDown nudProduct;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TabPage tabAddBusiness;
        private System.Windows.Forms.TabPage tabAddProduct;
        private System.Windows.Forms.TabPage tabBusiness;
        private System.Windows.Forms.TabPage tabChange;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabControl tabControl5;
        private System.Windows.Forms.TabControl tabControl6;
        private System.Windows.Forms.TabPage tabCreate;
        private System.Windows.Forms.TabPage tabDeleteProduct;
        private System.Windows.Forms.TabPage tabEliminate;
        private System.Windows.Forms.TabPage tabEliminateBusiness;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.TabPage tabProductsBusiness;
        private System.Windows.Forms.TabPage tabSee;
        private System.Windows.Forms.TabPage tabSeeProduct;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.TabPage tabWelcome;
        private System.Windows.Forms.TextBox txtActualPassword;
        private System.Windows.Forms.TextBox txtAddBusiness;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.TextBox txtDeleteBusiness;
        private System.Windows.Forms.TextBox txtDescriptionBusiness;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNewDirection;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtUserName;

        #endregion
    }
}