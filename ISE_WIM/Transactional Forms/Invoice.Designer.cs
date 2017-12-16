namespace ISE_WIM
{
    partial class Invoice
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.metroBtn_View = new MetroFramework.Controls.MetroButton();
            this.metroBtn_Delete = new MetroFramework.Controls.MetroButton();
            this.metroBtn_Update = new MetroFramework.Controls.MetroButton();
            this.metroBtn_Add = new MetroFramework.Controls.MetroButton();
            this.dateInvoice = new MetroFramework.Controls.MetroDateTime();
            this.contractInvoice = new MetroFramework.Controls.MetroTextBox();
            this.totAmountInvoice = new MetroFramework.Controls.MetroTextBox();
            this.totMtrInvoice = new MetroFramework.Controls.MetroTextBox();
            this.serialInvoice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.buyerID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid_PLLI = new MetroFramework.Controls.MetroGrid();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.buyerName = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.statusInvoice = new MetroFramework.Controls.MetroTextBox();
            this.descInvoice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.managerID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.contractID = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_PLLI)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroBtn_View
            // 
            this.metroBtn_View.Location = new System.Drawing.Point(497, 179);
            this.metroBtn_View.Name = "metroBtn_View";
            this.metroBtn_View.Size = new System.Drawing.Size(75, 23);
            this.metroBtn_View.TabIndex = 10;
            this.metroBtn_View.Text = "View";
            this.metroBtn_View.UseSelectable = true;
            this.metroBtn_View.Click += new System.EventHandler(this.metroBtn_View_Click);
            // 
            // metroBtn_Delete
            // 
            this.metroBtn_Delete.Location = new System.Drawing.Point(416, 179);
            this.metroBtn_Delete.Name = "metroBtn_Delete";
            this.metroBtn_Delete.Size = new System.Drawing.Size(75, 23);
            this.metroBtn_Delete.TabIndex = 10;
            this.metroBtn_Delete.Text = "Delete";
            this.metroBtn_Delete.UseSelectable = true;
            // 
            // metroBtn_Update
            // 
            this.metroBtn_Update.Location = new System.Drawing.Point(334, 179);
            this.metroBtn_Update.Name = "metroBtn_Update";
            this.metroBtn_Update.Size = new System.Drawing.Size(75, 23);
            this.metroBtn_Update.TabIndex = 10;
            this.metroBtn_Update.Text = "Update";
            this.metroBtn_Update.UseSelectable = true;
            // 
            // metroBtn_Add
            // 
            this.metroBtn_Add.Location = new System.Drawing.Point(251, 179);
            this.metroBtn_Add.Name = "metroBtn_Add";
            this.metroBtn_Add.Size = new System.Drawing.Size(75, 23);
            this.metroBtn_Add.TabIndex = 10;
            this.metroBtn_Add.Text = "Add";
            this.metroBtn_Add.UseSelectable = true;
            this.metroBtn_Add.Click += new System.EventHandler(this.metroBtn_Add_Click);
            // 
            // dateInvoice
            // 
            this.dateInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInvoice.Location = new System.Drawing.Point(109, 58);
            this.dateInvoice.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateInvoice.Name = "dateInvoice";
            this.dateInvoice.Size = new System.Drawing.Size(161, 29);
            this.dateInvoice.TabIndex = 9;
            // 
            // contractInvoice
            // 
            this.contractInvoice.Lines = new string[0];
            this.contractInvoice.Location = new System.Drawing.Point(109, 122);
            this.contractInvoice.MaxLength = 32767;
            this.contractInvoice.Name = "contractInvoice";
            this.contractInvoice.PasswordChar = '\0';
            this.contractInvoice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.contractInvoice.SelectedText = "";
            this.contractInvoice.Size = new System.Drawing.Size(161, 23);
            this.contractInvoice.TabIndex = 8;
            this.contractInvoice.UseSelectable = true;
            this.contractInvoice.Click += new System.EventHandler(this.contractInvoice_Click);
            // 
            // totAmountInvoice
            // 
            this.totAmountInvoice.Lines = new string[0];
            this.totAmountInvoice.Location = new System.Drawing.Point(380, 58);
            this.totAmountInvoice.MaxLength = 32767;
            this.totAmountInvoice.Name = "totAmountInvoice";
            this.totAmountInvoice.PasswordChar = '\0';
            this.totAmountInvoice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totAmountInvoice.SelectedText = "";
            this.totAmountInvoice.Size = new System.Drawing.Size(161, 23);
            this.totAmountInvoice.TabIndex = 8;
            this.totAmountInvoice.UseSelectable = true;
            this.totAmountInvoice.Click += new System.EventHandler(this.totAmountInvoice_Click);
            // 
            // totMtrInvoice
            // 
            this.totMtrInvoice.Lines = new string[0];
            this.totMtrInvoice.Location = new System.Drawing.Point(380, 89);
            this.totMtrInvoice.MaxLength = 32767;
            this.totMtrInvoice.Name = "totMtrInvoice";
            this.totMtrInvoice.PasswordChar = '\0';
            this.totMtrInvoice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totMtrInvoice.SelectedText = "";
            this.totMtrInvoice.Size = new System.Drawing.Size(161, 23);
            this.totMtrInvoice.TabIndex = 6;
            this.totMtrInvoice.UseSelectable = true;
            this.totMtrInvoice.Click += new System.EventHandler(this.totMtrInvoice_Click);
            // 
            // serialInvoice
            // 
            this.serialInvoice.Lines = new string[0];
            this.serialInvoice.Location = new System.Drawing.Point(109, 91);
            this.serialInvoice.MaxLength = 32767;
            this.serialInvoice.Name = "serialInvoice";
            this.serialInvoice.PasswordChar = '\0';
            this.serialInvoice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.serialInvoice.SelectedText = "";
            this.serialInvoice.Size = new System.Drawing.Size(161, 23);
            this.serialInvoice.TabIndex = 6;
            this.serialInvoice.UseSelectable = true;
            this.serialInvoice.Click += new System.EventHandler(this.serialInvoice_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Invoice";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(28, 122);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(71, 19);
            this.metroLabel8.TabIndex = 3;
            this.metroLabel8.Text = "Contract #";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(292, 91);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(75, 19);
            this.metroLabel11.TabIndex = 4;
            this.metroLabel11.Text = "Total Meter";
            // 
            // buyerID
            // 
            this.buyerID.Lines = new string[0];
            this.buyerID.Location = new System.Drawing.Point(109, 29);
            this.buyerID.MaxLength = 32767;
            this.buyerID.Name = "buyerID";
            this.buyerID.PasswordChar = '\0';
            this.buyerID.ReadOnly = true;
            this.buyerID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.buyerID.SelectedText = "";
            this.buyerID.Size = new System.Drawing.Size(161, 23);
            this.buyerID.TabIndex = 6;
            this.buyerID.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(292, 64);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(87, 19);
            this.metroLabel10.TabIndex = 3;
            this.metroLabel10.Text = "Total Amount";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(28, 91);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(53, 19);
            this.metroLabel7.TabIndex = 4;
            this.metroLabel7.Text = "Seriel #";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(292, 33);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(82, 19);
            this.metroLabel9.TabIndex = 4;
            this.metroLabel9.Text = "Buyer Name";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(28, 64);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(36, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Date";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(28, 33);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 19);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "Buyer ID";
            // 
            // metroGrid_PLLI
            // 
            this.metroGrid_PLLI.AllowUserToResizeRows = false;
            this.metroGrid_PLLI.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_PLLI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid_PLLI.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid_PLLI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_PLLI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid_PLLI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid_PLLI.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid_PLLI.EnableHeadersVisualStyles = false;
            this.metroGrid_PLLI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid_PLLI.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_PLLI.Location = new System.Drawing.Point(39, 437);
            this.metroGrid_PLLI.Name = "metroGrid_PLLI";
            this.metroGrid_PLLI.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_PLLI.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid_PLLI.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid_PLLI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid_PLLI.Size = new System.Drawing.Size(728, 175);
            this.metroGrid_PLLI.TabIndex = 16;
            this.metroGrid_PLLI.UseCustomBackColor = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.buyerName);
            this.metroPanel2.Controls.Add(this.metroBtn_View);
            this.metroPanel2.Controls.Add(this.metroBtn_Delete);
            this.metroPanel2.Controls.Add(this.metroBtn_Update);
            this.metroPanel2.Controls.Add(this.metroButton1);
            this.metroPanel2.Controls.Add(this.metroBtn_Add);
            this.metroPanel2.Controls.Add(this.dateInvoice);
            this.metroPanel2.Controls.Add(this.contractInvoice);
            this.metroPanel2.Controls.Add(this.totAmountInvoice);
            this.metroPanel2.Controls.Add(this.statusInvoice);
            this.metroPanel2.Controls.Add(this.descInvoice);
            this.metroPanel2.Controls.Add(this.totMtrInvoice);
            this.metroPanel2.Controls.Add(this.serialInvoice);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel13);
            this.metroPanel2.Controls.Add(this.metroLabel8);
            this.metroPanel2.Controls.Add(this.metroLabel12);
            this.metroPanel2.Controls.Add(this.metroLabel11);
            this.metroPanel2.Controls.Add(this.buyerID);
            this.metroPanel2.Controls.Add(this.metroLabel10);
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.Controls.Add(this.metroLabel9);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(96, 221);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(581, 210);
            this.metroPanel2.TabIndex = 14;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            this.metroPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel2_Paint);
            // 
            // buyerName
            // 
            this.buyerName.FormattingEnabled = true;
            this.buyerName.ItemHeight = 23;
            this.buyerName.Location = new System.Drawing.Point(380, 23);
            this.buyerName.Name = "buyerName";
            this.buyerName.Size = new System.Drawing.Size(161, 29);
            this.buyerName.TabIndex = 18;
            this.buyerName.UseSelectable = true;
            this.buyerName.SelectedIndexChanged += new System.EventHandler(this.buyerName_SelectedIndexChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(121, 179);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(124, 23);
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Text = "Generate Report";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroBtn_Add_Click1);
            // 
            // statusInvoice
            // 
            this.statusInvoice.Lines = new string[0];
            this.statusInvoice.Location = new System.Drawing.Point(109, 150);
            this.statusInvoice.MaxLength = 32767;
            this.statusInvoice.Multiline = true;
            this.statusInvoice.Name = "statusInvoice";
            this.statusInvoice.PasswordChar = '\0';
            this.statusInvoice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.statusInvoice.SelectedText = "";
            this.statusInvoice.Size = new System.Drawing.Size(161, 23);
            this.statusInvoice.TabIndex = 6;
            this.statusInvoice.UseSelectable = true;
            this.statusInvoice.Click += new System.EventHandler(this.statusInvoice_Click);
            // 
            // descInvoice
            // 
            this.descInvoice.Lines = new string[0];
            this.descInvoice.Location = new System.Drawing.Point(380, 120);
            this.descInvoice.MaxLength = 32767;
            this.descInvoice.Multiline = true;
            this.descInvoice.Name = "descInvoice";
            this.descInvoice.PasswordChar = '\0';
            this.descInvoice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descInvoice.SelectedText = "";
            this.descInvoice.Size = new System.Drawing.Size(161, 52);
            this.descInvoice.TabIndex = 6;
            this.descInvoice.UseSelectable = true;
            this.descInvoice.Click += new System.EventHandler(this.descInvoice_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(28, 151);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(43, 19);
            this.metroLabel13.TabIndex = 3;
            this.metroLabel13.Text = "Status";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(292, 126);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(74, 19);
            this.metroLabel12.TabIndex = 4;
            this.metroLabel12.Text = "Description";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Manger";
            // 
            // managerID
            // 
            this.managerID.Lines = new string[0];
            this.managerID.Location = new System.Drawing.Point(266, 20);
            this.managerID.MaxLength = 32767;
            this.managerID.Name = "managerID";
            this.managerID.PasswordChar = '\0';
            this.managerID.ReadOnly = true;
            this.managerID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.managerID.SelectedText = "";
            this.managerID.Size = new System.Drawing.Size(210, 23);
            this.managerID.TabIndex = 6;
            this.managerID.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(121, 48);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Name";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(121, 20);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(21, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "ID";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroComboBox1);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.managerID);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(96, 121);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(581, 95);
            this.metroPanel1.TabIndex = 13;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(266, 49);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(210, 29);
            this.metroComboBox1.TabIndex = 18;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // contractID
            // 
            this.contractID.FormattingEnabled = true;
            this.contractID.ItemHeight = 23;
            this.contractID.Location = new System.Drawing.Point(553, 72);
            this.contractID.Name = "contractID";
            this.contractID.Size = new System.Drawing.Size(182, 29);
            this.contractID.TabIndex = 18;
            this.contractID.UseSelectable = true;
            this.contractID.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(454, 82);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(77, 19);
            this.metroLabel14.TabIndex = 19;
            this.metroLabel14.Text = "Contract_ID";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.Location = new System.Drawing.Point(96, 33);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(65, 25);
            this.metroLabel15.TabIndex = 20;
            this.metroLabel15.Text = "Invoice";
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = global::ISE_WIM.Properties.Resources.close_btn;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton2.Location = new System.Drawing.Point(715, 2);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(78, 54);
            this.metroButton2.TabIndex = 30;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(228, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(326, 34);
            this.label12.TabIndex = 31;
            this.label12.Text = "WIM Textile Industry";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(795, 645);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.contractID);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroGrid_PLLI);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_PLLI)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private MetroFramework.Controls.MetroButton metroBtn_View;
        private MetroFramework.Controls.MetroButton metroBtn_Delete;
        private MetroFramework.Controls.MetroButton metroBtn_Update;
        private MetroFramework.Controls.MetroButton metroBtn_Add;
        private MetroFramework.Controls.MetroDateTime dateInvoice;
        private MetroFramework.Controls.MetroTextBox contractInvoice;
        private MetroFramework.Controls.MetroTextBox totAmountInvoice;
        private MetroFramework.Controls.MetroTextBox totMtrInvoice;
        private MetroFramework.Controls.MetroTextBox serialInvoice;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox buyerID;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroGrid metroGrid_PLLI;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox managerID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox descInvoice;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox statusInvoice;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroComboBox contractID;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroComboBox buyerName;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Label label12;
    }
}