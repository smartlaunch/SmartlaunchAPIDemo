namespace Demo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.txtIPAddress = new IPAddressControlLib.IPAddressControl();
            this.txtPort = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ButtonUserGroup = new System.Windows.Forms.Button();
            this.ButtonUserGroupAll = new System.Windows.Forms.Button();
            this.ButtonUserAddOffers = new System.Windows.Forms.Button();
            this.ButtonUserAddOffer = new System.Windows.Forms.Button();
            this.ButtonUserAddProducts = new System.Windows.Forms.Button();
            this.ButtonUserAddProduct = new System.Windows.Forms.Button();
            this.ButtonUserAddMoney = new System.Windows.Forms.Button();
            this.ButtonUserAddTime = new System.Windows.Forms.Button();
            this.ButtonUserGetBill = new System.Windows.Forms.Button();
            this.ButtonUserLock = new System.Windows.Forms.Button();
            this.ButtonUserOpen = new System.Windows.Forms.Button();
            this.ButtonUserLogout = new System.Windows.Forms.Button();
            this.ButtonUserLogin2 = new System.Windows.Forms.Button();
            this.ButtonUserLoginToConsole = new System.Windows.Forms.Button();
            this.ButtonUserLogin = new System.Windows.Forms.Button();
            this.ButtonUserMoveUserGroup = new System.Windows.Forms.Button();
            this.ButtonUserUpdate = new System.Windows.Forms.Button();
            this.ButtonUserCreate = new System.Windows.Forms.Button();
            this.ButtonUserAllByStatus = new System.Windows.Forms.Button();
            this.ButtonUserAllByNumberOfUsers = new System.Windows.Forms.Button();
            this.ButtonUserAll = new System.Windows.Forms.Button();
            this.ButtonUser = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ButtonComputerAll = new System.Windows.Forms.Button();
            this.ButtonComputer = new System.Windows.Forms.Button();
            this.ButtonComputerTurnOn = new System.Windows.Forms.Button();
            this.ButtonComputerTurnOff = new System.Windows.Forms.Button();
            this.ButtonComputerGroupAll = new System.Windows.Forms.Button();
            this.ButtonComputerGroup = new System.Windows.Forms.Button();
            this.ButtonComputerGroupByComputerName = new System.Windows.Forms.Button();
            this.ButtonLayoutGroupAll = new System.Windows.Forms.Button();
            this.ButtonLayoutGroup = new System.Windows.Forms.Button();
            this.ButtonLayoutGroupByComputerGroupName = new System.Windows.Forms.Button();
            this.ButtonLayoutGroupByComputerName = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ButtonProductGroupAll = new System.Windows.Forms.Button();
            this.ButtonProductGroup = new System.Windows.Forms.Button();
            this.ButtonProductAll = new System.Windows.Forms.Button();
            this.ButtonProduct = new System.Windows.Forms.Button();
            this.ButtonOfferAll = new System.Windows.Forms.Button();
            this.ButtonOffer = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ButtonEmployeeAll = new System.Windows.Forms.Button();
            this.ButtonEmployee = new System.Windows.Forms.Button();
            this.ButtonEmployeeLogin = new System.Windows.Forms.Button();
            this.ButtonFinancialReport = new System.Windows.Forms.Button();
            this.ButtonRESTAPIVersion = new System.Windows.Forms.Button();
            this.ButtonSmartlaunchVersion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(6, 19);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(457, 508);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOutput_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtOutput);
            this.groupBox2.Location = new System.Drawing.Point(506, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 527);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnTestConnection);
            this.groupBox3.Controls.Add(this.txtIPAddress);
            this.groupBox3.Controls.Add(this.txtPort);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(66, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(909, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(189, 32);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(75, 46);
            this.btnTestConnection.TabIndex = 5;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.AllowInternalTab = false;
            this.txtIPAddress.AutoHeight = true;
            this.txtIPAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtIPAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtIPAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIPAddress.Location = new System.Drawing.Point(87, 32);
            this.txtIPAddress.MinimumSize = new System.Drawing.Size(87, 20);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.ReadOnly = false;
            this.txtIPAddress.Size = new System.Drawing.Size(87, 20);
            this.txtIPAddress.TabIndex = 4;
            this.txtIPAddress.Text = "...";
            // 
            // txtPort
            // 
            this.txtPort.HidePromptOnLeave = true;
            this.txtPort.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.txtPort.Location = new System.Drawing.Point(87, 58);
            this.txtPort.Mask = "00000";
            this.txtPort.Name = "txtPort";
            this.txtPort.PromptChar = ' ';
            this.txtPort.Size = new System.Drawing.Size(47, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "7833";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPort.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Address";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 118);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(488, 527);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ButtonUserGroup);
            this.tabPage1.Controls.Add(this.ButtonUserGroupAll);
            this.tabPage1.Controls.Add(this.ButtonUserAddOffers);
            this.tabPage1.Controls.Add(this.ButtonUserAddOffer);
            this.tabPage1.Controls.Add(this.ButtonUserAddProducts);
            this.tabPage1.Controls.Add(this.ButtonUserAddProduct);
            this.tabPage1.Controls.Add(this.ButtonUserAddMoney);
            this.tabPage1.Controls.Add(this.ButtonUserAddTime);
            this.tabPage1.Controls.Add(this.ButtonUserGetBill);
            this.tabPage1.Controls.Add(this.ButtonUserLock);
            this.tabPage1.Controls.Add(this.ButtonUserOpen);
            this.tabPage1.Controls.Add(this.ButtonUserLogout);
            this.tabPage1.Controls.Add(this.ButtonUserLogin2);
            this.tabPage1.Controls.Add(this.ButtonUserLoginToConsole);
            this.tabPage1.Controls.Add(this.ButtonUserLogin);
            this.tabPage1.Controls.Add(this.ButtonUserMoveUserGroup);
            this.tabPage1.Controls.Add(this.ButtonUserUpdate);
            this.tabPage1.Controls.Add(this.ButtonUserCreate);
            this.tabPage1.Controls.Add(this.ButtonUserAllByStatus);
            this.tabPage1.Controls.Add(this.ButtonUserAllByNumberOfUsers);
            this.tabPage1.Controls.Add(this.ButtonUserAll);
            this.tabPage1.Controls.Add(this.ButtonUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(480, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "USER AND USERGROUP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ButtonUserGroup
            // 
            this.ButtonUserGroup.Location = new System.Drawing.Point(6, 438);
            this.ButtonUserGroup.Name = "ButtonUserGroup";
            this.ButtonUserGroup.Size = new System.Drawing.Size(150, 30);
            this.ButtonUserGroup.TabIndex = 44;
            this.ButtonUserGroup.Text = "UserGroup";
            this.ButtonUserGroup.UseVisualStyleBackColor = true;
            this.ButtonUserGroup.Click += new System.EventHandler(this.UserGroup_Click);
            // 
            // ButtonUserGroupAll
            // 
            this.ButtonUserGroupAll.Location = new System.Drawing.Point(6, 402);
            this.ButtonUserGroupAll.Name = "ButtonUserGroupAll";
            this.ButtonUserGroupAll.Size = new System.Drawing.Size(150, 30);
            this.ButtonUserGroupAll.TabIndex = 43;
            this.ButtonUserGroupAll.Text = "UserGroupAll";
            this.ButtonUserGroupAll.UseVisualStyleBackColor = true;
            this.ButtonUserGroupAll.Click += new System.EventHandler(this.UserGroupAll_Click);
            // 
            // ButtonUserAddOffers
            // 
            this.ButtonUserAddOffers.Location = new System.Drawing.Point(162, 330);
            this.ButtonUserAddOffers.Name = "ButtonUserAddOffers";
            this.ButtonUserAddOffers.Size = new System.Drawing.Size(150, 30);
            this.ButtonUserAddOffers.TabIndex = 42;
            this.ButtonUserAddOffers.Text = "UserAddOffers";
            this.ButtonUserAddOffers.UseVisualStyleBackColor = true;
            // 
            // ButtonUserAddOffer
            // 
            this.ButtonUserAddOffer.Location = new System.Drawing.Point(6, 330);
            this.ButtonUserAddOffer.Name = "ButtonUserAddOffer";
            this.ButtonUserAddOffer.Size = new System.Drawing.Size(150, 30);
            this.ButtonUserAddOffer.TabIndex = 41;
            this.ButtonUserAddOffer.Text = "UserAddOffer";
            this.ButtonUserAddOffer.UseVisualStyleBackColor = true;
            // 
            // ButtonUserAddProducts
            // 
            this.ButtonUserAddProducts.Location = new System.Drawing.Point(162, 294);
            this.ButtonUserAddProducts.Name = "ButtonUserAddProducts";
            this.ButtonUserAddProducts.Size = new System.Drawing.Size(150, 30);
            this.ButtonUserAddProducts.TabIndex = 40;
            this.ButtonUserAddProducts.Text = "UserAddProducts";
            this.ButtonUserAddProducts.UseVisualStyleBackColor = true;
            // 
            // ButtonUserAddProduct
            // 
            this.ButtonUserAddProduct.Location = new System.Drawing.Point(6, 294);
            this.ButtonUserAddProduct.Name = "ButtonUserAddProduct";
            this.ButtonUserAddProduct.Size = new System.Drawing.Size(150, 30);
            this.ButtonUserAddProduct.TabIndex = 39;
            this.ButtonUserAddProduct.Text = "UserAddProduct";
            this.ButtonUserAddProduct.UseVisualStyleBackColor = true;
            // 
            // ButtonUserAddMoney
            // 
            this.ButtonUserAddMoney.Location = new System.Drawing.Point(164, 258);
            this.ButtonUserAddMoney.Name = "ButtonUserAddMoney";
            this.ButtonUserAddMoney.Size = new System.Drawing.Size(150, 30);
            this.ButtonUserAddMoney.TabIndex = 38;
            this.ButtonUserAddMoney.Text = "UserAddMoney";
            this.ButtonUserAddMoney.UseVisualStyleBackColor = true;
            // 
            // ButtonUserAddTime
            // 
            this.ButtonUserAddTime.Location = new System.Drawing.Point(6, 258);
            this.ButtonUserAddTime.Name = "ButtonUserAddTime";
            this.ButtonUserAddTime.Size = new System.Drawing.Size(150, 30);
            this.ButtonUserAddTime.TabIndex = 37;
            this.ButtonUserAddTime.Text = "UserAddTime";
            this.ButtonUserAddTime.UseVisualStyleBackColor = true;
            // 
            // ButtonUserGetBill
            // 
            this.ButtonUserGetBill.Location = new System.Drawing.Point(6, 222);
            this.ButtonUserGetBill.Name = "ButtonUserGetBill";
            this.ButtonUserGetBill.Size = new System.Drawing.Size(150, 30);
            this.ButtonUserGetBill.TabIndex = 36;
            this.ButtonUserGetBill.Text = "UserGetBill";
            this.ButtonUserGetBill.UseVisualStyleBackColor = true;
            this.ButtonUserGetBill.Click += new System.EventHandler(this.UserGetBill_Click);
            // 
            // ButtonUserLock
            // 
            this.ButtonUserLock.Location = new System.Drawing.Point(162, 186);
            this.ButtonUserLock.Name = "ButtonUserLock";
            this.ButtonUserLock.Size = new System.Drawing.Size(150, 30);
            this.ButtonUserLock.TabIndex = 35;
            this.ButtonUserLock.Text = "UserLock";
            this.ButtonUserLock.UseVisualStyleBackColor = true;
            this.ButtonUserLock.Click += new System.EventHandler(this.UserLock_Click);
            // 
            // ButtonUserOpen
            // 
            this.ButtonUserOpen.Location = new System.Drawing.Point(6, 186);
            this.ButtonUserOpen.Name = "ButtonUserOpen";
            this.ButtonUserOpen.Size = new System.Drawing.Size(150, 30);
            this.ButtonUserOpen.TabIndex = 34;
            this.ButtonUserOpen.Text = "UserOpen";
            this.ButtonUserOpen.UseVisualStyleBackColor = true;
            this.ButtonUserOpen.Click += new System.EventHandler(this.UserOpen_Click);
            // 
            // ButtonUserLogout
            // 
            this.ButtonUserLogout.Location = new System.Drawing.Point(6, 150);
            this.ButtonUserLogout.Name = "ButtonUserLogout";
            this.ButtonUserLogout.Size = new System.Drawing.Size(150, 30);
            this.ButtonUserLogout.TabIndex = 33;
            this.ButtonUserLogout.Text = "UserLogout";
            this.ButtonUserLogout.UseVisualStyleBackColor = true;
            this.ButtonUserLogout.Click += new System.EventHandler(this.UserLogout_Click);
            // 
            // ButtonUserLogin2
            // 
            this.ButtonUserLogin2.Location = new System.Drawing.Point(318, 114);
            this.ButtonUserLogin2.Name = "ButtonUserLogin2";
            this.ButtonUserLogin2.Size = new System.Drawing.Size(150, 30);
            this.ButtonUserLogin2.TabIndex = 32;
            this.ButtonUserLogin2.Text = "UserLogin2";
            this.ButtonUserLogin2.UseVisualStyleBackColor = true;
            this.ButtonUserLogin2.Click += new System.EventHandler(this.UserLogin2_Click);
            // 
            // ButtonUserLoginToConsole
            // 
            this.ButtonUserLoginToConsole.Location = new System.Drawing.Point(162, 114);
            this.ButtonUserLoginToConsole.Name = "ButtonUserLoginToConsole";
            this.ButtonUserLoginToConsole.Size = new System.Drawing.Size(150, 30);
            this.ButtonUserLoginToConsole.TabIndex = 31;
            this.ButtonUserLoginToConsole.Text = "UserLoginToConsole";
            this.ButtonUserLoginToConsole.UseVisualStyleBackColor = true;
            this.ButtonUserLoginToConsole.Click += new System.EventHandler(this.UserLoginToConsole_Click);
            // 
            // ButtonUserLogin
            // 
            this.ButtonUserLogin.Location = new System.Drawing.Point(6, 114);
            this.ButtonUserLogin.Name = "ButtonUserLogin";
            this.ButtonUserLogin.Size = new System.Drawing.Size(150, 30);
            this.ButtonUserLogin.TabIndex = 30;
            this.ButtonUserLogin.Text = "UserLogin";
            this.ButtonUserLogin.UseVisualStyleBackColor = true;
            this.ButtonUserLogin.Click += new System.EventHandler(this.UserLogin_Click);
            // 
            // ButtonUserMoveUserGroup
            // 
            this.ButtonUserMoveUserGroup.Location = new System.Drawing.Point(318, 78);
            this.ButtonUserMoveUserGroup.Name = "ButtonUserMoveUserGroup";
            this.ButtonUserMoveUserGroup.Size = new System.Drawing.Size(150, 30);
            this.ButtonUserMoveUserGroup.TabIndex = 29;
            this.ButtonUserMoveUserGroup.Text = "UserMoveUserGroup";
            this.ButtonUserMoveUserGroup.UseVisualStyleBackColor = true;
            this.ButtonUserMoveUserGroup.Click += new System.EventHandler(this.UserMoveUserGroup_Click);
            // 
            // ButtonUserUpdate
            // 
            this.ButtonUserUpdate.Location = new System.Drawing.Point(162, 78);
            this.ButtonUserUpdate.Name = "ButtonUserUpdate";
            this.ButtonUserUpdate.Size = new System.Drawing.Size(150, 30);
            this.ButtonUserUpdate.TabIndex = 28;
            this.ButtonUserUpdate.Text = "UserUpdate";
            this.ButtonUserUpdate.UseVisualStyleBackColor = true;
            this.ButtonUserUpdate.Click += new System.EventHandler(this.UserUpdate_Click);
            // 
            // ButtonUserCreate
            // 
            this.ButtonUserCreate.Location = new System.Drawing.Point(6, 78);
            this.ButtonUserCreate.Name = "ButtonUserCreate";
            this.ButtonUserCreate.Size = new System.Drawing.Size(150, 30);
            this.ButtonUserCreate.TabIndex = 27;
            this.ButtonUserCreate.Text = "UserCreate";
            this.ButtonUserCreate.UseVisualStyleBackColor = true;
            this.ButtonUserCreate.Click += new System.EventHandler(this.UserCreate_Click);
            // 
            // ButtonUserAllByStatus
            // 
            this.ButtonUserAllByStatus.Location = new System.Drawing.Point(318, 6);
            this.ButtonUserAllByStatus.Name = "ButtonUserAllByStatus";
            this.ButtonUserAllByStatus.Size = new System.Drawing.Size(150, 30);
            this.ButtonUserAllByStatus.TabIndex = 26;
            this.ButtonUserAllByStatus.Text = "UserAllByStatus";
            this.ButtonUserAllByStatus.UseVisualStyleBackColor = true;
            this.ButtonUserAllByStatus.Click += new System.EventHandler(this.UserAllByStatus_Click);
            // 
            // ButtonUserAllByNumberOfUsers
            // 
            this.ButtonUserAllByNumberOfUsers.Location = new System.Drawing.Point(162, 6);
            this.ButtonUserAllByNumberOfUsers.Name = "ButtonUserAllByNumberOfUsers";
            this.ButtonUserAllByNumberOfUsers.Size = new System.Drawing.Size(150, 30);
            this.ButtonUserAllByNumberOfUsers.TabIndex = 25;
            this.ButtonUserAllByNumberOfUsers.Text = "UserAllByNumberOfUsers";
            this.ButtonUserAllByNumberOfUsers.UseVisualStyleBackColor = true;
            this.ButtonUserAllByNumberOfUsers.Click += new System.EventHandler(this.UserAllByNumberOfUsers_Click);
            // 
            // ButtonUserAll
            // 
            this.ButtonUserAll.Location = new System.Drawing.Point(6, 6);
            this.ButtonUserAll.Name = "ButtonUserAll";
            this.ButtonUserAll.Size = new System.Drawing.Size(150, 30);
            this.ButtonUserAll.TabIndex = 24;
            this.ButtonUserAll.Text = "UserAll";
            this.ButtonUserAll.UseVisualStyleBackColor = true;
            this.ButtonUserAll.Click += new System.EventHandler(this.UserAll_Click);
            // 
            // ButtonUser
            // 
            this.ButtonUser.Location = new System.Drawing.Point(6, 42);
            this.ButtonUser.Name = "ButtonUser";
            this.ButtonUser.Size = new System.Drawing.Size(150, 30);
            this.ButtonUser.TabIndex = 23;
            this.ButtonUser.Text = "User";
            this.ButtonUser.UseVisualStyleBackColor = true;
            this.ButtonUser.Click += new System.EventHandler(this.User_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ButtonLayoutGroupByComputerName);
            this.tabPage2.Controls.Add(this.ButtonLayoutGroupByComputerGroupName);
            this.tabPage2.Controls.Add(this.ButtonLayoutGroup);
            this.tabPage2.Controls.Add(this.ButtonLayoutGroupAll);
            this.tabPage2.Controls.Add(this.ButtonComputerGroupByComputerName);
            this.tabPage2.Controls.Add(this.ButtonComputerGroup);
            this.tabPage2.Controls.Add(this.ButtonComputerGroupAll);
            this.tabPage2.Controls.Add(this.ButtonComputerTurnOff);
            this.tabPage2.Controls.Add(this.ButtonComputerTurnOn);
            this.tabPage2.Controls.Add(this.ButtonComputer);
            this.tabPage2.Controls.Add(this.ButtonComputerAll);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(480, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "COMPUTERS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ButtonComputerAll
            // 
            this.ButtonComputerAll.Location = new System.Drawing.Point(6, 6);
            this.ButtonComputerAll.Name = "ButtonComputerAll";
            this.ButtonComputerAll.Size = new System.Drawing.Size(150, 30);
            this.ButtonComputerAll.TabIndex = 44;
            this.ButtonComputerAll.Text = "ComputerAll";
            this.ButtonComputerAll.UseVisualStyleBackColor = true;
            this.ButtonComputerAll.Click += new System.EventHandler(this.ButtonComputerAll_Click);
            // 
            // ButtonComputer
            // 
            this.ButtonComputer.Location = new System.Drawing.Point(6, 42);
            this.ButtonComputer.Name = "ButtonComputer";
            this.ButtonComputer.Size = new System.Drawing.Size(150, 30);
            this.ButtonComputer.TabIndex = 45;
            this.ButtonComputer.Text = "Computer";
            this.ButtonComputer.UseVisualStyleBackColor = true;
            this.ButtonComputer.Click += new System.EventHandler(this.ButtonComputer_Click);
            // 
            // ButtonComputerTurnOn
            // 
            this.ButtonComputerTurnOn.Location = new System.Drawing.Point(6, 78);
            this.ButtonComputerTurnOn.Name = "ButtonComputerTurnOn";
            this.ButtonComputerTurnOn.Size = new System.Drawing.Size(150, 30);
            this.ButtonComputerTurnOn.TabIndex = 46;
            this.ButtonComputerTurnOn.Text = "ComputerTurnOn";
            this.ButtonComputerTurnOn.UseVisualStyleBackColor = true;
            this.ButtonComputerTurnOn.Click += new System.EventHandler(this.ButtonComputerTurnOn_Click);
            // 
            // ButtonComputerTurnOff
            // 
            this.ButtonComputerTurnOff.Location = new System.Drawing.Point(164, 78);
            this.ButtonComputerTurnOff.Name = "ButtonComputerTurnOff";
            this.ButtonComputerTurnOff.Size = new System.Drawing.Size(150, 30);
            this.ButtonComputerTurnOff.TabIndex = 47;
            this.ButtonComputerTurnOff.Text = "ComputerTurnOff";
            this.ButtonComputerTurnOff.UseVisualStyleBackColor = true;
            this.ButtonComputerTurnOff.Click += new System.EventHandler(this.ButtonComputerTurnOff_Click);
            // 
            // ButtonComputerGroupAll
            // 
            this.ButtonComputerGroupAll.Location = new System.Drawing.Point(6, 150);
            this.ButtonComputerGroupAll.Name = "ButtonComputerGroupAll";
            this.ButtonComputerGroupAll.Size = new System.Drawing.Size(150, 30);
            this.ButtonComputerGroupAll.TabIndex = 48;
            this.ButtonComputerGroupAll.Text = "ComputerGroupAll";
            this.ButtonComputerGroupAll.UseVisualStyleBackColor = true;
            this.ButtonComputerGroupAll.Click += new System.EventHandler(this.ButtonComputerGroupAll_Click);
            // 
            // ButtonComputerGroup
            // 
            this.ButtonComputerGroup.Location = new System.Drawing.Point(6, 186);
            this.ButtonComputerGroup.Name = "ButtonComputerGroup";
            this.ButtonComputerGroup.Size = new System.Drawing.Size(150, 30);
            this.ButtonComputerGroup.TabIndex = 49;
            this.ButtonComputerGroup.Text = "ComputerGroup";
            this.ButtonComputerGroup.UseVisualStyleBackColor = true;
            this.ButtonComputerGroup.Click += new System.EventHandler(this.ButtonComputerGroup_Click);
            // 
            // ButtonComputerGroupByComputerName
            // 
            this.ButtonComputerGroupByComputerName.Location = new System.Drawing.Point(162, 186);
            this.ButtonComputerGroupByComputerName.Name = "ButtonComputerGroupByComputerName";
            this.ButtonComputerGroupByComputerName.Size = new System.Drawing.Size(200, 30);
            this.ButtonComputerGroupByComputerName.TabIndex = 50;
            this.ButtonComputerGroupByComputerName.Text = "ComputerGroupByComputerName";
            this.ButtonComputerGroupByComputerName.UseVisualStyleBackColor = true;
            this.ButtonComputerGroupByComputerName.Click += new System.EventHandler(this.ButtonComputerGroupByComputerName_Click);
            // 
            // ButtonLayoutGroupAll
            // 
            this.ButtonLayoutGroupAll.Location = new System.Drawing.Point(6, 258);
            this.ButtonLayoutGroupAll.Name = "ButtonLayoutGroupAll";
            this.ButtonLayoutGroupAll.Size = new System.Drawing.Size(150, 30);
            this.ButtonLayoutGroupAll.TabIndex = 51;
            this.ButtonLayoutGroupAll.Text = "LayoutGroupAll";
            this.ButtonLayoutGroupAll.UseVisualStyleBackColor = true;
            this.ButtonLayoutGroupAll.Click += new System.EventHandler(this.ButtonLayoutGroupAll_Click);
            // 
            // ButtonLayoutGroup
            // 
            this.ButtonLayoutGroup.Location = new System.Drawing.Point(6, 294);
            this.ButtonLayoutGroup.Name = "ButtonLayoutGroup";
            this.ButtonLayoutGroup.Size = new System.Drawing.Size(150, 30);
            this.ButtonLayoutGroup.TabIndex = 52;
            this.ButtonLayoutGroup.Text = "LayoutGroup";
            this.ButtonLayoutGroup.UseVisualStyleBackColor = true;
            this.ButtonLayoutGroup.Click += new System.EventHandler(this.ButtonLayoutGroup_Click);
            // 
            // ButtonLayoutGroupByComputerGroupName
            // 
            this.ButtonLayoutGroupByComputerGroupName.Location = new System.Drawing.Point(6, 330);
            this.ButtonLayoutGroupByComputerGroupName.Name = "ButtonLayoutGroupByComputerGroupName";
            this.ButtonLayoutGroupByComputerGroupName.Size = new System.Drawing.Size(200, 30);
            this.ButtonLayoutGroupByComputerGroupName.TabIndex = 53;
            this.ButtonLayoutGroupByComputerGroupName.Text = "LayoutGroupByComputerGroupName";
            this.ButtonLayoutGroupByComputerGroupName.UseVisualStyleBackColor = true;
            this.ButtonLayoutGroupByComputerGroupName.Click += new System.EventHandler(this.ButtonLayoutGroupByComputerGroupName_Click);
            // 
            // ButtonLayoutGroupByComputerName
            // 
            this.ButtonLayoutGroupByComputerName.Location = new System.Drawing.Point(212, 330);
            this.ButtonLayoutGroupByComputerName.Name = "ButtonLayoutGroupByComputerName";
            this.ButtonLayoutGroupByComputerName.Size = new System.Drawing.Size(200, 30);
            this.ButtonLayoutGroupByComputerName.TabIndex = 54;
            this.ButtonLayoutGroupByComputerName.Text = "LayoutGroupByComputerName";
            this.ButtonLayoutGroupByComputerName.UseVisualStyleBackColor = true;
            this.ButtonLayoutGroupByComputerName.Click += new System.EventHandler(this.ButtonLayoutGroupByComputerName_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ButtonOffer);
            this.tabPage3.Controls.Add(this.ButtonOfferAll);
            this.tabPage3.Controls.Add(this.ButtonProduct);
            this.tabPage3.Controls.Add(this.ButtonProductAll);
            this.tabPage3.Controls.Add(this.ButtonProductGroup);
            this.tabPage3.Controls.Add(this.ButtonProductGroupAll);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(480, 501);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PRODUCTS AND OFFERS";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ButtonProductGroupAll
            // 
            this.ButtonProductGroupAll.Location = new System.Drawing.Point(6, 6);
            this.ButtonProductGroupAll.Name = "ButtonProductGroupAll";
            this.ButtonProductGroupAll.Size = new System.Drawing.Size(150, 30);
            this.ButtonProductGroupAll.TabIndex = 45;
            this.ButtonProductGroupAll.Text = "ProductGroupAll";
            this.ButtonProductGroupAll.UseVisualStyleBackColor = true;
            this.ButtonProductGroupAll.Click += new System.EventHandler(this.ButtonProductGroupAll_Click);
            // 
            // ButtonProductGroup
            // 
            this.ButtonProductGroup.Location = new System.Drawing.Point(6, 42);
            this.ButtonProductGroup.Name = "ButtonProductGroup";
            this.ButtonProductGroup.Size = new System.Drawing.Size(150, 30);
            this.ButtonProductGroup.TabIndex = 46;
            this.ButtonProductGroup.Text = "ProductGroup";
            this.ButtonProductGroup.UseVisualStyleBackColor = true;
            this.ButtonProductGroup.Click += new System.EventHandler(this.ButtonProductGroup_Click);
            // 
            // ButtonProductAll
            // 
            this.ButtonProductAll.Location = new System.Drawing.Point(6, 114);
            this.ButtonProductAll.Name = "ButtonProductAll";
            this.ButtonProductAll.Size = new System.Drawing.Size(150, 30);
            this.ButtonProductAll.TabIndex = 47;
            this.ButtonProductAll.Text = "ProductAll";
            this.ButtonProductAll.UseVisualStyleBackColor = true;
            this.ButtonProductAll.Click += new System.EventHandler(this.ButtonProductAll_Click);
            // 
            // ButtonProduct
            // 
            this.ButtonProduct.Location = new System.Drawing.Point(6, 150);
            this.ButtonProduct.Name = "ButtonProduct";
            this.ButtonProduct.Size = new System.Drawing.Size(150, 30);
            this.ButtonProduct.TabIndex = 48;
            this.ButtonProduct.Text = "Product";
            this.ButtonProduct.UseVisualStyleBackColor = true;
            this.ButtonProduct.Click += new System.EventHandler(this.ButtonProduct_Click);
            // 
            // ButtonOfferAll
            // 
            this.ButtonOfferAll.Location = new System.Drawing.Point(6, 222);
            this.ButtonOfferAll.Name = "ButtonOfferAll";
            this.ButtonOfferAll.Size = new System.Drawing.Size(150, 30);
            this.ButtonOfferAll.TabIndex = 49;
            this.ButtonOfferAll.Text = "OfferAll";
            this.ButtonOfferAll.UseVisualStyleBackColor = true;
            this.ButtonOfferAll.Click += new System.EventHandler(this.ButtonOfferAll_Click);
            // 
            // ButtonOffer
            // 
            this.ButtonOffer.Location = new System.Drawing.Point(6, 258);
            this.ButtonOffer.Name = "ButtonOffer";
            this.ButtonOffer.Size = new System.Drawing.Size(150, 30);
            this.ButtonOffer.TabIndex = 50;
            this.ButtonOffer.Text = "Offer";
            this.ButtonOffer.UseVisualStyleBackColor = true;
            this.ButtonOffer.Click += new System.EventHandler(this.ButtonOffer_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ButtonSmartlaunchVersion);
            this.tabPage4.Controls.Add(this.ButtonRESTAPIVersion);
            this.tabPage4.Controls.Add(this.ButtonFinancialReport);
            this.tabPage4.Controls.Add(this.ButtonEmployeeLogin);
            this.tabPage4.Controls.Add(this.ButtonEmployee);
            this.tabPage4.Controls.Add(this.ButtonEmployeeAll);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(480, 501);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "MISC";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ButtonEmployeeAll
            // 
            this.ButtonEmployeeAll.Location = new System.Drawing.Point(6, 6);
            this.ButtonEmployeeAll.Name = "ButtonEmployeeAll";
            this.ButtonEmployeeAll.Size = new System.Drawing.Size(150, 30);
            this.ButtonEmployeeAll.TabIndex = 46;
            this.ButtonEmployeeAll.Text = "EmployeeAll";
            this.ButtonEmployeeAll.UseVisualStyleBackColor = true;
            this.ButtonEmployeeAll.Click += new System.EventHandler(this.ButtonEmployeeAll_Click);
            // 
            // ButtonEmployee
            // 
            this.ButtonEmployee.Location = new System.Drawing.Point(6, 42);
            this.ButtonEmployee.Name = "ButtonEmployee";
            this.ButtonEmployee.Size = new System.Drawing.Size(150, 30);
            this.ButtonEmployee.TabIndex = 47;
            this.ButtonEmployee.Text = "Employee";
            this.ButtonEmployee.UseVisualStyleBackColor = true;
            this.ButtonEmployee.Click += new System.EventHandler(this.ButtonEmployee_Click);
            // 
            // ButtonEmployeeLogin
            // 
            this.ButtonEmployeeLogin.Location = new System.Drawing.Point(6, 78);
            this.ButtonEmployeeLogin.Name = "ButtonEmployeeLogin";
            this.ButtonEmployeeLogin.Size = new System.Drawing.Size(150, 30);
            this.ButtonEmployeeLogin.TabIndex = 48;
            this.ButtonEmployeeLogin.Text = "EmployeeLogin";
            this.ButtonEmployeeLogin.UseVisualStyleBackColor = true;
            this.ButtonEmployeeLogin.Click += new System.EventHandler(this.ButtonEmployeeLogin_Click);
            // 
            // ButtonFinancialReport
            // 
            this.ButtonFinancialReport.Location = new System.Drawing.Point(6, 150);
            this.ButtonFinancialReport.Name = "ButtonFinancialReport";
            this.ButtonFinancialReport.Size = new System.Drawing.Size(150, 30);
            this.ButtonFinancialReport.TabIndex = 49;
            this.ButtonFinancialReport.Text = "FinancialReport";
            this.ButtonFinancialReport.UseVisualStyleBackColor = true;
            this.ButtonFinancialReport.Click += new System.EventHandler(this.ButtonFinancialReport_Click);
            // 
            // ButtonRESTAPIVersion
            // 
            this.ButtonRESTAPIVersion.Location = new System.Drawing.Point(324, 6);
            this.ButtonRESTAPIVersion.Name = "ButtonRESTAPIVersion";
            this.ButtonRESTAPIVersion.Size = new System.Drawing.Size(150, 30);
            this.ButtonRESTAPIVersion.TabIndex = 50;
            this.ButtonRESTAPIVersion.Text = "RESTAPIVersion";
            this.ButtonRESTAPIVersion.UseVisualStyleBackColor = true;
            this.ButtonRESTAPIVersion.Click += new System.EventHandler(this.ButtonRESTAPIVersion_Click);
            // 
            // ButtonSmartlaunchVersion
            // 
            this.ButtonSmartlaunchVersion.Location = new System.Drawing.Point(324, 42);
            this.ButtonSmartlaunchVersion.Name = "ButtonSmartlaunchVersion";
            this.ButtonSmartlaunchVersion.Size = new System.Drawing.Size(150, 30);
            this.ButtonSmartlaunchVersion.TabIndex = 51;
            this.ButtonSmartlaunchVersion.Text = "SmartlaunchVersion";
            this.ButtonSmartlaunchVersion.UseVisualStyleBackColor = true;
            this.ButtonSmartlaunchVersion.Click += new System.EventHandler(this.ButtonSmartlaunchVersion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 657);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Smartlaunch REST API Demo (REST API version 1.0.8)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtPort;
        private IPAddressControlLib.IPAddressControl txtIPAddress;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button ButtonUserGroup;
        private System.Windows.Forms.Button ButtonUserGroupAll;
        private System.Windows.Forms.Button ButtonUserAddOffers;
        private System.Windows.Forms.Button ButtonUserAddOffer;
        private System.Windows.Forms.Button ButtonUserAddProducts;
        private System.Windows.Forms.Button ButtonUserAddProduct;
        private System.Windows.Forms.Button ButtonUserAddMoney;
        private System.Windows.Forms.Button ButtonUserAddTime;
        private System.Windows.Forms.Button ButtonUserGetBill;
        private System.Windows.Forms.Button ButtonUserLock;
        private System.Windows.Forms.Button ButtonUserOpen;
        private System.Windows.Forms.Button ButtonUserLogout;
        private System.Windows.Forms.Button ButtonUserLogin2;
        private System.Windows.Forms.Button ButtonUserLoginToConsole;
        private System.Windows.Forms.Button ButtonUserLogin;
        private System.Windows.Forms.Button ButtonUserMoveUserGroup;
        private System.Windows.Forms.Button ButtonUserUpdate;
        private System.Windows.Forms.Button ButtonUserCreate;
        private System.Windows.Forms.Button ButtonUserAllByStatus;
        private System.Windows.Forms.Button ButtonUserAllByNumberOfUsers;
        private System.Windows.Forms.Button ButtonUserAll;
        private System.Windows.Forms.Button ButtonUser;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ButtonComputerAll;
        private System.Windows.Forms.Button ButtonLayoutGroupByComputerName;
        private System.Windows.Forms.Button ButtonLayoutGroupByComputerGroupName;
        private System.Windows.Forms.Button ButtonLayoutGroup;
        private System.Windows.Forms.Button ButtonLayoutGroupAll;
        private System.Windows.Forms.Button ButtonComputerGroupByComputerName;
        private System.Windows.Forms.Button ButtonComputerGroup;
        private System.Windows.Forms.Button ButtonComputerGroupAll;
        private System.Windows.Forms.Button ButtonComputerTurnOff;
        private System.Windows.Forms.Button ButtonComputerTurnOn;
        private System.Windows.Forms.Button ButtonComputer;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button ButtonOffer;
        private System.Windows.Forms.Button ButtonOfferAll;
        private System.Windows.Forms.Button ButtonProduct;
        private System.Windows.Forms.Button ButtonProductAll;
        private System.Windows.Forms.Button ButtonProductGroup;
        private System.Windows.Forms.Button ButtonProductGroupAll;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button ButtonFinancialReport;
        private System.Windows.Forms.Button ButtonEmployeeLogin;
        private System.Windows.Forms.Button ButtonEmployee;
        private System.Windows.Forms.Button ButtonEmployeeAll;
        private System.Windows.Forms.Button ButtonSmartlaunchVersion;
        private System.Windows.Forms.Button ButtonRESTAPIVersion;
    }
}

