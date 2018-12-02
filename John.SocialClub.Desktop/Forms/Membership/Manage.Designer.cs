namespace John.SocialClub.Desktop.Forms.Membership
{
    partial class Manage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabRegistration = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblHealthStatusRequired = new System.Windows.Forms.Label();
            this.lblMaritalStatusRequired = new System.Windows.Forms.Label();
            this.lblOccupationRequired = new System.Windows.Forms.Label();
            this.lblDOBRequired = new System.Windows.Forms.Label();
            this.lblNameRequired = new System.Windows.Forms.Label();
            this.lblNoOfChildren = new System.Windows.Forms.Label();
            this.txtNoOfChildren = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.cmbHealthStatus = new System.Windows.Forms.ComboBox();
            this.lblHealthStatus = new System.Windows.Forms.Label();
            this.dtDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cmbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.cmbOccupation = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tabSearchManage = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl2NoOfChildren = new System.Windows.Forms.Label();
            this.txt2NoOfChildren = new System.Windows.Forms.TextBox();
            this.cmb2HealthStatus = new System.Windows.Forms.ComboBox();
            this.lbl2HealthStatus = new System.Windows.Forms.Label();
            this.cmb2MaritalStatus = new System.Windows.Forms.ComboBox();
            this.lbl2MaritalStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl2Salary = new System.Windows.Forms.Label();
            this.txt2Salary = new System.Windows.Forms.TextBox();
            this.dt2DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lbl2Occupation = new System.Windows.Forms.Label();
            this.cmb2Occupation = new System.Windows.Forms.ComboBox();
            this.txt2FirstName = new System.Windows.Forms.TextBox();
            this.lbl2DateOfBirth = new System.Windows.Forms.Label();
            this.lbl2Name = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbOperand = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearchMaritalStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSearchOccupation = new System.Windows.Forms.ComboBox();
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            this.Header = new System.Windows.Forms.TextBox();
            this.PrintReport = new System.Drawing.Printing.PrintDocument();
            this.txt2MiddleName = new System.Windows.Forms.TextBox();
            this.txt2LastName = new System.Windows.Forms.TextBox();
            this.tab.SuspendLayout();
            this.tabRegistration.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.tabSearchManage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabRegistration);
            this.tab.Controls.Add(this.tabSearchManage);
            this.tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.Location = new System.Drawing.Point(12, 67);
            this.tab.Margin = new System.Windows.Forms.Padding(6);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(2070, 950);
            this.tab.TabIndex = 0;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.Tab_SelectedIndexChanged);
            // 
            // tabRegistration
            // 
            this.tabRegistration.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabRegistration.Controls.Add(this.tabControl2);
            this.tabRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRegistration.Location = new System.Drawing.Point(8, 43);
            this.tabRegistration.Margin = new System.Windows.Forms.Padding(6);
            this.tabRegistration.Name = "tabRegistration";
            this.tabRegistration.Padding = new System.Windows.Forms.Padding(6);
            this.tabRegistration.Size = new System.Drawing.Size(2054, 899);
            this.tabRegistration.TabIndex = 0;
            this.tabRegistration.Text = "New Registration";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabRegister);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(16, 12);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1342, 410);
            this.tabControl2.TabIndex = 5;
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.txtLastName);
            this.tabRegister.Controls.Add(this.txtMiddleName);
            this.tabRegister.Controls.Add(this.lblHealthStatusRequired);
            this.tabRegister.Controls.Add(this.lblMaritalStatusRequired);
            this.tabRegister.Controls.Add(this.lblOccupationRequired);
            this.tabRegister.Controls.Add(this.lblDOBRequired);
            this.tabRegister.Controls.Add(this.lblNameRequired);
            this.tabRegister.Controls.Add(this.lblNoOfChildren);
            this.tabRegister.Controls.Add(this.txtNoOfChildren);
            this.tabRegister.Controls.Add(this.lblSalary);
            this.tabRegister.Controls.Add(this.txtSalary);
            this.tabRegister.Controls.Add(this.cmbHealthStatus);
            this.tabRegister.Controls.Add(this.lblHealthStatus);
            this.tabRegister.Controls.Add(this.dtDateOfBirth);
            this.tabRegister.Controls.Add(this.btnRegister);
            this.tabRegister.Controls.Add(this.cmbMaritalStatus);
            this.tabRegister.Controls.Add(this.lblMaritalStatus);
            this.tabRegister.Controls.Add(this.lblOccupation);
            this.tabRegister.Controls.Add(this.cmbOccupation);
            this.tabRegister.Controls.Add(this.txtFirstName);
            this.tabRegister.Controls.Add(this.lblDateOfBirth);
            this.tabRegister.Controls.Add(this.lblName);
            this.tabRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRegister.Location = new System.Drawing.Point(8, 45);
            this.tabRegister.Margin = new System.Windows.Forms.Padding(6);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(6);
            this.tabRegister.Size = new System.Drawing.Size(1326, 357);
            this.tabRegister.TabIndex = 0;
            this.tabRegister.Text = "Member";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Location = new System.Drawing.Point(499, 25);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(187, 35);
            this.txtLastName.TabIndex = 24;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMiddleName.Location = new System.Drawing.Point(426, 25);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(6);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(61, 35);
            this.txtMiddleName.TabIndex = 23;
            // 
            // lblHealthStatusRequired
            // 
            this.lblHealthStatusRequired.AutoSize = true;
            this.lblHealthStatusRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealthStatusRequired.ForeColor = System.Drawing.Color.Red;
            this.lblHealthStatusRequired.Location = new System.Drawing.Point(905, 112);
            this.lblHealthStatusRequired.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHealthStatusRequired.Name = "lblHealthStatusRequired";
            this.lblHealthStatusRequired.Size = new System.Drawing.Size(36, 46);
            this.lblHealthStatusRequired.TabIndex = 22;
            this.lblHealthStatusRequired.Text = "*";
            // 
            // lblMaritalStatusRequired
            // 
            this.lblMaritalStatusRequired.AutoSize = true;
            this.lblMaritalStatusRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaritalStatusRequired.ForeColor = System.Drawing.Color.Red;
            this.lblMaritalStatusRequired.Location = new System.Drawing.Point(909, 35);
            this.lblMaritalStatusRequired.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMaritalStatusRequired.Name = "lblMaritalStatusRequired";
            this.lblMaritalStatusRequired.Size = new System.Drawing.Size(36, 46);
            this.lblMaritalStatusRequired.TabIndex = 21;
            this.lblMaritalStatusRequired.Text = "*";
            // 
            // lblOccupationRequired
            // 
            this.lblOccupationRequired.AutoSize = true;
            this.lblOccupationRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupationRequired.ForeColor = System.Drawing.Color.Red;
            this.lblOccupationRequired.Location = new System.Drawing.Point(168, 167);
            this.lblOccupationRequired.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOccupationRequired.Name = "lblOccupationRequired";
            this.lblOccupationRequired.Size = new System.Drawing.Size(36, 46);
            this.lblOccupationRequired.TabIndex = 20;
            this.lblOccupationRequired.Text = "*";
            // 
            // lblDOBRequired
            // 
            this.lblDOBRequired.AutoSize = true;
            this.lblDOBRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOBRequired.ForeColor = System.Drawing.Color.Red;
            this.lblDOBRequired.Location = new System.Drawing.Point(178, 100);
            this.lblDOBRequired.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDOBRequired.Name = "lblDOBRequired";
            this.lblDOBRequired.Size = new System.Drawing.Size(36, 46);
            this.lblDOBRequired.TabIndex = 19;
            this.lblDOBRequired.Text = "*";
            // 
            // lblNameRequired
            // 
            this.lblNameRequired.AutoSize = true;
            this.lblNameRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameRequired.ForeColor = System.Drawing.Color.Red;
            this.lblNameRequired.Location = new System.Drawing.Point(106, 33);
            this.lblNameRequired.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNameRequired.Name = "lblNameRequired";
            this.lblNameRequired.Size = new System.Drawing.Size(36, 46);
            this.lblNameRequired.TabIndex = 18;
            this.lblNameRequired.Text = "*";
            // 
            // lblNoOfChildren
            // 
            this.lblNoOfChildren.AutoSize = true;
            this.lblNoOfChildren.Location = new System.Drawing.Point(751, 185);
            this.lblNoOfChildren.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNoOfChildren.Name = "lblNoOfChildren";
            this.lblNoOfChildren.Size = new System.Drawing.Size(169, 29);
            this.lblNoOfChildren.TabIndex = 17;
            this.lblNoOfChildren.Text = "No. of children";
            // 
            // txtNoOfChildren
            // 
            this.txtNoOfChildren.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoOfChildren.Location = new System.Drawing.Point(949, 179);
            this.txtNoOfChildren.Margin = new System.Windows.Forms.Padding(6);
            this.txtNoOfChildren.MaxLength = 2;
            this.txtNoOfChildren.Name = "txtNoOfChildren";
            this.txtNoOfChildren.Size = new System.Drawing.Size(104, 35);
            this.txtNoOfChildren.TabIndex = 8;
            this.txtNoOfChildren.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Children_KeyPress);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(34, 242);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(80, 29);
            this.lblSalary.TabIndex = 15;
            this.lblSalary.Text = "Salary";
            // 
            // txtSalary
            // 
            this.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalary.Location = new System.Drawing.Point(222, 235);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(6);
            this.txtSalary.MaxLength = 12;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(464, 35);
            this.txtSalary.TabIndex = 5;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Salary_KeyPress);
            // 
            // cmbHealthStatus
            // 
            this.cmbHealthStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHealthStatus.FormattingEnabled = true;
            this.cmbHealthStatus.Location = new System.Drawing.Point(949, 110);
            this.cmbHealthStatus.Margin = new System.Windows.Forms.Padding(6);
            this.cmbHealthStatus.Name = "cmbHealthStatus";
            this.cmbHealthStatus.Size = new System.Drawing.Size(300, 37);
            this.cmbHealthStatus.TabIndex = 7;
            // 
            // lblHealthStatus
            // 
            this.lblHealthStatus.AutoSize = true;
            this.lblHealthStatus.Location = new System.Drawing.Point(749, 110);
            this.lblHealthStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHealthStatus.Name = "lblHealthStatus";
            this.lblHealthStatus.Size = new System.Drawing.Size(150, 29);
            this.lblHealthStatus.TabIndex = 12;
            this.lblHealthStatus.Text = "Health status";
            // 
            // dtDateOfBirth
            // 
            this.dtDateOfBirth.AllowDrop = true;
            this.dtDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateOfBirth.Location = new System.Drawing.Point(222, 88);
            this.dtDateOfBirth.Margin = new System.Windows.Forms.Padding(6);
            this.dtDateOfBirth.MaxDate = new System.DateTime(2012, 12, 25, 0, 0, 0, 0);
            this.dtDateOfBirth.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtDateOfBirth.Name = "dtDateOfBirth";
            this.dtDateOfBirth.Size = new System.Drawing.Size(464, 35);
            this.dtDateOfBirth.TabIndex = 3;
            this.dtDateOfBirth.Value = new System.DateTime(2012, 12, 25, 0, 0, 0, 0);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(953, 269);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(6);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(230, 54);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.Register_Click);
            // 
            // cmbMaritalStatus
            // 
            this.cmbMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaritalStatus.FormattingEnabled = true;
            this.cmbMaritalStatus.Location = new System.Drawing.Point(953, 33);
            this.cmbMaritalStatus.Margin = new System.Windows.Forms.Padding(6);
            this.cmbMaritalStatus.Name = "cmbMaritalStatus";
            this.cmbMaritalStatus.Size = new System.Drawing.Size(300, 37);
            this.cmbMaritalStatus.TabIndex = 6;
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Location = new System.Drawing.Point(749, 33);
            this.lblMaritalStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(153, 29);
            this.lblMaritalStatus.TabIndex = 6;
            this.lblMaritalStatus.Text = "Marital status";
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(32, 165);
            this.lblOccupation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(135, 29);
            this.lblOccupation.TabIndex = 5;
            this.lblOccupation.Text = "Occupation";
            // 
            // cmbOccupation
            // 
            this.cmbOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOccupation.FormattingEnabled = true;
            this.cmbOccupation.Location = new System.Drawing.Point(222, 156);
            this.cmbOccupation.Margin = new System.Windows.Forms.Padding(6);
            this.cmbOccupation.Name = "cmbOccupation";
            this.cmbOccupation.Size = new System.Drawing.Size(464, 37);
            this.cmbOccupation.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Location = new System.Drawing.Point(222, 25);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(192, 35);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(32, 98);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(144, 29);
            this.lblDateOfBirth.TabIndex = 1;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 29);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // tabSearchManage
            // 
            this.tabSearchManage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabSearchManage.Controls.Add(this.txt2LastName);
            this.tabSearchManage.Controls.Add(this.txt2MiddleName);
            this.tabSearchManage.Controls.Add(this.label10);
            this.tabSearchManage.Controls.Add(this.label11);
            this.tabSearchManage.Controls.Add(this.lbl2NoOfChildren);
            this.tabSearchManage.Controls.Add(this.txt2NoOfChildren);
            this.tabSearchManage.Controls.Add(this.cmb2HealthStatus);
            this.tabSearchManage.Controls.Add(this.lbl2HealthStatus);
            this.tabSearchManage.Controls.Add(this.cmb2MaritalStatus);
            this.tabSearchManage.Controls.Add(this.lbl2MaritalStatus);
            this.tabSearchManage.Controls.Add(this.label1);
            this.tabSearchManage.Controls.Add(this.label2);
            this.tabSearchManage.Controls.Add(this.label5);
            this.tabSearchManage.Controls.Add(this.lbl2Salary);
            this.tabSearchManage.Controls.Add(this.txt2Salary);
            this.tabSearchManage.Controls.Add(this.dt2DateOfBirth);
            this.tabSearchManage.Controls.Add(this.lbl2Occupation);
            this.tabSearchManage.Controls.Add(this.cmb2Occupation);
            this.tabSearchManage.Controls.Add(this.txt2FirstName);
            this.tabSearchManage.Controls.Add(this.lbl2DateOfBirth);
            this.tabSearchManage.Controls.Add(this.lbl2Name);
            this.tabSearchManage.Controls.Add(this.btnUpdate);
            this.tabSearchManage.Controls.Add(this.btnDelete);
            this.tabSearchManage.Controls.Add(this.btnPrintPreview);
            this.tabSearchManage.Controls.Add(this.btnExport);
            this.tabSearchManage.Controls.Add(this.btnPrint);
            this.tabSearchManage.Controls.Add(this.tabControl1);
            this.tabSearchManage.Controls.Add(this.dataGridViewMembers);
            this.tabSearchManage.Location = new System.Drawing.Point(8, 43);
            this.tabSearchManage.Margin = new System.Windows.Forms.Padding(6);
            this.tabSearchManage.Name = "tabSearchManage";
            this.tabSearchManage.Padding = new System.Windows.Forms.Padding(6);
            this.tabSearchManage.Size = new System.Drawing.Size(2054, 899);
            this.tabSearchManage.TabIndex = 1;
            this.tabSearchManage.Text = "Search / Manage Members";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(1389, 681);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 46);
            this.label10.TabIndex = 39;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(1393, 604);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 46);
            this.label11.TabIndex = 38;
            this.label11.Text = "*";
            // 
            // lbl2NoOfChildren
            // 
            this.lbl2NoOfChildren.AutoSize = true;
            this.lbl2NoOfChildren.Location = new System.Drawing.Point(1235, 756);
            this.lbl2NoOfChildren.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl2NoOfChildren.Name = "lbl2NoOfChildren";
            this.lbl2NoOfChildren.Size = new System.Drawing.Size(169, 29);
            this.lbl2NoOfChildren.TabIndex = 37;
            this.lbl2NoOfChildren.Text = "No. of children";
            // 
            // txt2NoOfChildren
            // 
            this.txt2NoOfChildren.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2NoOfChildren.Location = new System.Drawing.Point(1485, 744);
            this.txt2NoOfChildren.Margin = new System.Windows.Forms.Padding(6);
            this.txt2NoOfChildren.MaxLength = 2;
            this.txt2NoOfChildren.Name = "txt2NoOfChildren";
            this.txt2NoOfChildren.Size = new System.Drawing.Size(104, 35);
            this.txt2NoOfChildren.TabIndex = 35;
            // 
            // cmb2HealthStatus
            // 
            this.cmb2HealthStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2HealthStatus.FormattingEnabled = true;
            this.cmb2HealthStatus.Location = new System.Drawing.Point(1475, 673);
            this.cmb2HealthStatus.Margin = new System.Windows.Forms.Padding(6);
            this.cmb2HealthStatus.Name = "cmb2HealthStatus";
            this.cmb2HealthStatus.Size = new System.Drawing.Size(300, 37);
            this.cmb2HealthStatus.TabIndex = 34;
            // 
            // lbl2HealthStatus
            // 
            this.lbl2HealthStatus.AutoSize = true;
            this.lbl2HealthStatus.Location = new System.Drawing.Point(1233, 679);
            this.lbl2HealthStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl2HealthStatus.Name = "lbl2HealthStatus";
            this.lbl2HealthStatus.Size = new System.Drawing.Size(150, 29);
            this.lbl2HealthStatus.TabIndex = 36;
            this.lbl2HealthStatus.Text = "Health status";
            // 
            // cmb2MaritalStatus
            // 
            this.cmb2MaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2MaritalStatus.FormattingEnabled = true;
            this.cmb2MaritalStatus.Location = new System.Drawing.Point(1473, 596);
            this.cmb2MaritalStatus.Margin = new System.Windows.Forms.Padding(6);
            this.cmb2MaritalStatus.Name = "cmb2MaritalStatus";
            this.cmb2MaritalStatus.Size = new System.Drawing.Size(300, 37);
            this.cmb2MaritalStatus.TabIndex = 32;
            // 
            // lbl2MaritalStatus
            // 
            this.lbl2MaritalStatus.AutoSize = true;
            this.lbl2MaritalStatus.Location = new System.Drawing.Point(1233, 602);
            this.lbl2MaritalStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl2MaritalStatus.Name = "lbl2MaritalStatus";
            this.lbl2MaritalStatus.Size = new System.Drawing.Size(153, 29);
            this.lbl2MaritalStatus.TabIndex = 33;
            this.lbl2MaritalStatus.Text = "Marital status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1371, 471);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 46);
            this.label1.TabIndex = 31;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1381, 408);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 46);
            this.label2.TabIndex = 30;
            this.label2.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1309, 346);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 46);
            this.label5.TabIndex = 29;
            this.label5.Text = "*";
            // 
            // lbl2Salary
            // 
            this.lbl2Salary.AutoSize = true;
            this.lbl2Salary.Location = new System.Drawing.Point(1237, 536);
            this.lbl2Salary.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl2Salary.Name = "lbl2Salary";
            this.lbl2Salary.Size = new System.Drawing.Size(80, 29);
            this.lbl2Salary.TabIndex = 28;
            this.lbl2Salary.Text = "Salary";
            // 
            // txt2Salary
            // 
            this.txt2Salary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2Salary.Location = new System.Drawing.Point(1469, 531);
            this.txt2Salary.Margin = new System.Windows.Forms.Padding(6);
            this.txt2Salary.MaxLength = 12;
            this.txt2Salary.Name = "txt2Salary";
            this.txt2Salary.Size = new System.Drawing.Size(226, 35);
            this.txt2Salary.TabIndex = 26;
            // 
            // dt2DateOfBirth
            // 
            this.dt2DateOfBirth.AllowDrop = true;
            this.dt2DateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dt2DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt2DateOfBirth.Location = new System.Drawing.Point(1469, 396);
            this.dt2DateOfBirth.Margin = new System.Windows.Forms.Padding(6);
            this.dt2DateOfBirth.MaxDate = new System.DateTime(2012, 12, 25, 0, 0, 0, 0);
            this.dt2DateOfBirth.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dt2DateOfBirth.Name = "dt2DateOfBirth";
            this.dt2DateOfBirth.Size = new System.Drawing.Size(224, 35);
            this.dt2DateOfBirth.TabIndex = 24;
            this.dt2DateOfBirth.Value = new System.DateTime(2012, 12, 25, 0, 0, 0, 0);
            // 
            // lbl2Occupation
            // 
            this.lbl2Occupation.AutoSize = true;
            this.lbl2Occupation.Location = new System.Drawing.Point(1235, 469);
            this.lbl2Occupation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl2Occupation.Name = "lbl2Occupation";
            this.lbl2Occupation.Size = new System.Drawing.Size(135, 29);
            this.lbl2Occupation.TabIndex = 27;
            this.lbl2Occupation.Text = "Occupation";
            // 
            // cmb2Occupation
            // 
            this.cmb2Occupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2Occupation.FormattingEnabled = true;
            this.cmb2Occupation.Location = new System.Drawing.Point(1469, 459);
            this.cmb2Occupation.Margin = new System.Windows.Forms.Padding(6);
            this.cmb2Occupation.Name = "cmb2Occupation";
            this.cmb2Occupation.Size = new System.Drawing.Size(300, 37);
            this.cmb2Occupation.TabIndex = 25;
            // 
            // txt2FirstName
            // 
            this.txt2FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2FirstName.Location = new System.Drawing.Point(1469, 338);
            this.txt2FirstName.Margin = new System.Windows.Forms.Padding(6);
            this.txt2FirstName.Name = "txt2FirstName";
            this.txt2FirstName.Size = new System.Drawing.Size(168, 35);
            this.txt2FirstName.TabIndex = 23;
            // 
            // lbl2DateOfBirth
            // 
            this.lbl2DateOfBirth.AutoSize = true;
            this.lbl2DateOfBirth.Location = new System.Drawing.Point(1235, 406);
            this.lbl2DateOfBirth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl2DateOfBirth.Name = "lbl2DateOfBirth";
            this.lbl2DateOfBirth.Size = new System.Drawing.Size(144, 29);
            this.lbl2DateOfBirth.TabIndex = 22;
            this.lbl2DateOfBirth.Text = "Date of Birth";
            // 
            // lbl2Name
            // 
            this.lbl2Name.AutoSize = true;
            this.lbl2Name.Location = new System.Drawing.Point(1229, 342);
            this.lbl2Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl2Name.Name = "lbl2Name";
            this.lbl2Name.Size = new System.Drawing.Size(78, 29);
            this.lbl2Name.TabIndex = 21;
            this.lbl2Name.Text = "Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1473, 821);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(168, 52);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1653, 821);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 52);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Location = new System.Drawing.Point(780, 242);
            this.btnPrintPreview.Margin = new System.Windows.Forms.Padding(6);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(200, 54);
            this.btnPrintPreview.TabIndex = 8;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.UseVisualStyleBackColor = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.PrintPreview_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1204, 242);
            this.btnExport.Margin = new System.Windows.Forms.Padding(6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(200, 54);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.Export_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(992, 242);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(200, 54);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.Print_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(14, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2028, 202);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cmbOperand);
            this.tabPage3.Controls.Add(this.btnRefresh);
            this.tabPage3.Controls.Add(this.btnSearch);
            this.tabPage3.Controls.Add(this.cmbSearchMaritalStatus);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.cmbSearchOccupation);
            this.tabPage3.Location = new System.Drawing.Point(8, 43);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage3.Size = new System.Drawing.Size(2012, 151);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Search";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmbOperand
            // 
            this.cmbOperand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperand.FormattingEnabled = true;
            this.cmbOperand.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cmbOperand.Location = new System.Drawing.Point(312, 63);
            this.cmbOperand.Margin = new System.Windows.Forms.Padding(6);
            this.cmbOperand.Name = "cmbOperand";
            this.cmbOperand.Size = new System.Drawing.Size(126, 37);
            this.cmbOperand.TabIndex = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(958, 63);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(200, 54);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(728, 63);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 54);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search_Click);
            // 
            // cmbSearchMaritalStatus
            // 
            this.cmbSearchMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchMaritalStatus.FormattingEnabled = true;
            this.cmbSearchMaritalStatus.Location = new System.Drawing.Point(454, 63);
            this.cmbSearchMaritalStatus.Margin = new System.Windows.Forms.Padding(6);
            this.cmbSearchMaritalStatus.Name = "cmbSearchMaritalStatus";
            this.cmbSearchMaritalStatus.Size = new System.Drawing.Size(238, 37);
            this.cmbSearchMaritalStatus.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Marital status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Occupation";
            // 
            // cmbSearchOccupation
            // 
            this.cmbSearchOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchOccupation.FormattingEnabled = true;
            this.cmbSearchOccupation.Location = new System.Drawing.Point(58, 63);
            this.cmbSearchOccupation.Margin = new System.Windows.Forms.Padding(6);
            this.cmbSearchOccupation.Name = "cmbSearchOccupation";
            this.cmbSearchOccupation.Size = new System.Drawing.Size(238, 37);
            this.cmbSearchOccupation.TabIndex = 4;
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.AllowUserToAddRows = false;
            this.dataGridViewMembers.AllowUserToOrderColumns = true;
            this.dataGridViewMembers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.Location = new System.Drawing.Point(6, 319);
            this.dataGridViewMembers.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.ReadOnly = true;
            this.dataGridViewMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMembers.Size = new System.Drawing.Size(1138, 571);
            this.dataGridViewMembers.TabIndex = 3;
            this.dataGridViewMembers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView_CellFormatting);
            this.dataGridViewMembers.SelectionChanged += new System.EventHandler(this.dataGridViewMembers_SelectionChanged);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.Control;
            this.Header.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header.Enabled = false;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.DimGray;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(6);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(2100, 61);
            this.Header.TabIndex = 0;
            this.Header.Text = "Social club";
            this.Header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PrintReport
            // 
            this.PrintReport.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // txt2MiddleName
            // 
            this.txt2MiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2MiddleName.Location = new System.Drawing.Point(1649, 336);
            this.txt2MiddleName.Margin = new System.Windows.Forms.Padding(6);
            this.txt2MiddleName.Name = "txt2MiddleName";
            this.txt2MiddleName.Size = new System.Drawing.Size(79, 35);
            this.txt2MiddleName.TabIndex = 40;
            // 
            // txt2LastName
            // 
            this.txt2LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2LastName.Location = new System.Drawing.Point(1740, 336);
            this.txt2LastName.Margin = new System.Windows.Forms.Padding(6);
            this.txt2LastName.Name = "txt2LastName";
            this.txt2LastName.Size = new System.Drawing.Size(246, 35);
            this.txt2LastName.TabIndex = 41;
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(2100, 1033);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.tab);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Social Club - Membership Manager";
            this.tab.ResumeLayout(false);
            this.tabRegistration.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            this.tabSearchManage.ResumeLayout(false);
            this.tabSearchManage.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabRegistration;
        private System.Windows.Forms.TabPage tabSearchManage;
        private System.Windows.Forms.DataGridView dataGridViewMembers;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSearchMaritalStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSearchOccupation;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cmbMaritalStatus;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.ComboBox cmbOccupation;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtDateOfBirth;
        private System.Windows.Forms.Label lblNoOfChildren;
        private System.Windows.Forms.TextBox txtNoOfChildren;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.ComboBox cmbHealthStatus;
        private System.Windows.Forms.Label lblHealthStatus;
        private System.Windows.Forms.Label lblHealthStatusRequired;
        private System.Windows.Forms.Label lblMaritalStatusRequired;
        private System.Windows.Forms.Label lblOccupationRequired;
        private System.Windows.Forms.Label lblDOBRequired;
        private System.Windows.Forms.Label lblNameRequired;
        private System.Windows.Forms.TextBox Header;
        private System.Windows.Forms.ComboBox cmbOperand;
        private System.Drawing.Printing.PrintDocument PrintReport;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl2Salary;
        private System.Windows.Forms.TextBox txt2Salary;
        private System.Windows.Forms.DateTimePicker dt2DateOfBirth;
        private System.Windows.Forms.Label lbl2Occupation;
        private System.Windows.Forms.ComboBox cmb2Occupation;
        private System.Windows.Forms.TextBox txt2FirstName;
        private System.Windows.Forms.Label lbl2DateOfBirth;
        private System.Windows.Forms.Label lbl2Name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl2NoOfChildren;
        private System.Windows.Forms.TextBox txt2NoOfChildren;
        private System.Windows.Forms.ComboBox cmb2HealthStatus;
        private System.Windows.Forms.Label lbl2HealthStatus;
        private System.Windows.Forms.ComboBox cmb2MaritalStatus;
        private System.Windows.Forms.Label lbl2MaritalStatus;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txt2LastName;
        private System.Windows.Forms.TextBox txt2MiddleName;
    }
}