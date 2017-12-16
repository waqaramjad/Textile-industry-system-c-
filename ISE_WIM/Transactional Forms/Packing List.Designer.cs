namespace ISE_WIM
{
    partial class Packing_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.managerID = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.totPeiceTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroBtn_View = new MetroFramework.Controls.MetroButton();
            this.metroBtn_Delete = new MetroFramework.Controls.MetroButton();
            this.metroBtn_Update = new MetroFramework.Controls.MetroButton();
            this.metroBtn_Add = new MetroFramework.Controls.MetroButton();
            this.metroDateTime_PL = new MetroFramework.Controls.MetroDateTime();
            this.partyPL = new MetroFramework.Controls.MetroTextBox();
            this.statusTxt = new MetroFramework.Controls.MetroTextBox();
            this.totMtrTxt = new MetroFramework.Controls.MetroTextBox();
            this.qualityPL = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.vehicleNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroTB_PL_ID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid_PLLI = new MetroFramework.Controls.MetroGrid();
            this.itemGrid = new MetroFramework.Controls.MetroGrid();
            this.ItemNameGrid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ItemQtyGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGrid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.contractID = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.AddBtnForGrid = new MetroFramework.Controls.MetroButton();
            this.totQtyforGrid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_PLLI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.managerID);
            this.metroPanel1.Controls.Add(this.metroComboBox1);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 93);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(537, 95);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
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
            this.managerID.Location = new System.Drawing.Point(262, 22);
            this.managerID.MaxLength = 32767;
            this.managerID.Name = "managerID";
            this.managerID.PasswordChar = '\0';
            this.managerID.ReadOnly = true;
            this.managerID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.managerID.SelectedText = "";
            this.managerID.Size = new System.Drawing.Size(161, 23);
            this.managerID.TabIndex = 1;
            this.managerID.UseSelectable = true;
            this.managerID.Click += new System.EventHandler(this.managerID_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(262, 53);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(161, 29);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(51, 57);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Name";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(51, 29);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(21, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "ID";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.totPeiceTxt);
            this.metroPanel2.Controls.Add(this.metroLabel20);
            this.metroPanel2.Controls.Add(this.metroBtn_View);
            this.metroPanel2.Controls.Add(this.metroBtn_Delete);
            this.metroPanel2.Controls.Add(this.metroBtn_Update);
            this.metroPanel2.Controls.Add(this.metroBtn_Add);
            this.metroPanel2.Controls.Add(this.metroDateTime_PL);
            this.metroPanel2.Controls.Add(this.partyPL);
            this.metroPanel2.Controls.Add(this.statusTxt);
            this.metroPanel2.Controls.Add(this.totMtrTxt);
            this.metroPanel2.Controls.Add(this.qualityPL);
            this.metroPanel2.Controls.Add(this.metroLabel21);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.vehicleNo);
            this.metroPanel2.Controls.Add(this.metroLabel11);
            this.metroPanel2.Controls.Add(this.metroTB_PL_ID);
            this.metroPanel2.Controls.Add(this.metroLabel10);
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.Controls.Add(this.metroLabel9);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 192);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(537, 210);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            this.metroPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel2_Paint);
            // 
            // totPeiceTxt
            // 
            this.totPeiceTxt.Lines = new string[0];
            this.totPeiceTxt.Location = new System.Drawing.Point(361, 122);
            this.totPeiceTxt.MaxLength = 32767;
            this.totPeiceTxt.Name = "totPeiceTxt";
            this.totPeiceTxt.PasswordChar = '\0';
            this.totPeiceTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totPeiceTxt.SelectedText = "";
            this.totPeiceTxt.Size = new System.Drawing.Size(161, 23);
            this.totPeiceTxt.TabIndex = 16;
            this.totPeiceTxt.UseSelectable = true;
            this.totPeiceTxt.Click += new System.EventHandler(this.totPeiceTxt_Click);
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(280, 122);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(70, 19);
            this.metroLabel20.TabIndex = 15;
            this.metroLabel20.Text = "Total Peice";
            // 
            // metroBtn_View
            // 
            this.metroBtn_View.Location = new System.Drawing.Point(444, 169);
            this.metroBtn_View.Name = "metroBtn_View";
            this.metroBtn_View.Size = new System.Drawing.Size(75, 23);
            this.metroBtn_View.TabIndex = 14;
            this.metroBtn_View.Text = "View";
            this.metroBtn_View.UseSelectable = true;
            this.metroBtn_View.Click += new System.EventHandler(this.metroBtn_View_Click);
            // 
            // metroBtn_Delete
            // 
            this.metroBtn_Delete.Location = new System.Drawing.Point(363, 169);
            this.metroBtn_Delete.Name = "metroBtn_Delete";
            this.metroBtn_Delete.Size = new System.Drawing.Size(75, 23);
            this.metroBtn_Delete.TabIndex = 13;
            this.metroBtn_Delete.Text = "Delete";
            this.metroBtn_Delete.UseSelectable = true;
            // 
            // metroBtn_Update
            // 
            this.metroBtn_Update.Location = new System.Drawing.Point(281, 169);
            this.metroBtn_Update.Name = "metroBtn_Update";
            this.metroBtn_Update.Size = new System.Drawing.Size(75, 23);
            this.metroBtn_Update.TabIndex = 12;
            this.metroBtn_Update.Text = "Update";
            this.metroBtn_Update.UseSelectable = true;
            // 
            // metroBtn_Add
            // 
            this.metroBtn_Add.Location = new System.Drawing.Point(198, 169);
            this.metroBtn_Add.Name = "metroBtn_Add";
            this.metroBtn_Add.Size = new System.Drawing.Size(75, 23);
            this.metroBtn_Add.TabIndex = 11;
            this.metroBtn_Add.Text = "Add";
            this.metroBtn_Add.UseSelectable = true;
            this.metroBtn_Add.Click += new System.EventHandler(this.metroBtn_Add_Click);
            // 
            // metroDateTime_PL
            // 
            this.metroDateTime_PL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime_PL.Location = new System.Drawing.Point(97, 58);
            this.metroDateTime_PL.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime_PL.Name = "metroDateTime_PL";
            this.metroDateTime_PL.Size = new System.Drawing.Size(161, 29);
            this.metroDateTime_PL.TabIndex = 4;
            this.metroDateTime_PL.ValueChanged += new System.EventHandler(this.metroDateTime_PL_ValueChanged);
            // 
            // partyPL
            // 
            this.partyPL.Lines = new string[0];
            this.partyPL.Location = new System.Drawing.Point(97, 121);
            this.partyPL.MaxLength = 32767;
            this.partyPL.Name = "partyPL";
            this.partyPL.PasswordChar = '\0';
            this.partyPL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.partyPL.SelectedText = "";
            this.partyPL.Size = new System.Drawing.Size(161, 23);
            this.partyPL.TabIndex = 6;
            this.partyPL.UseSelectable = true;
            this.partyPL.Click += new System.EventHandler(this.partyPL_Click);
            // 
            // statusTxt
            // 
            this.statusTxt.Lines = new string[0];
            this.statusTxt.Location = new System.Drawing.Point(361, 60);
            this.statusTxt.MaxLength = 32767;
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.PasswordChar = '\0';
            this.statusTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.statusTxt.SelectedText = "";
            this.statusTxt.Size = new System.Drawing.Size(161, 23);
            this.statusTxt.TabIndex = 9;
            this.statusTxt.UseSelectable = true;
            this.statusTxt.Click += new System.EventHandler(this.statusTxt_Click);
            // 
            // totMtrTxt
            // 
            this.totMtrTxt.Lines = new string[0];
            this.totMtrTxt.Location = new System.Drawing.Point(361, 91);
            this.totMtrTxt.MaxLength = 32767;
            this.totMtrTxt.Name = "totMtrTxt";
            this.totMtrTxt.PasswordChar = '\0';
            this.totMtrTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totMtrTxt.SelectedText = "";
            this.totMtrTxt.Size = new System.Drawing.Size(161, 23);
            this.totMtrTxt.TabIndex = 10;
            this.totMtrTxt.UseSelectable = true;
            this.totMtrTxt.Click += new System.EventHandler(this.totMtrTxt_Click);
            // 
            // qualityPL
            // 
            this.qualityPL.Lines = new string[0];
            this.qualityPL.Location = new System.Drawing.Point(97, 91);
            this.qualityPL.MaxLength = 32767;
            this.qualityPL.Name = "qualityPL";
            this.qualityPL.PasswordChar = '\0';
            this.qualityPL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.qualityPL.SelectedText = "";
            this.qualityPL.Size = new System.Drawing.Size(161, 23);
            this.qualityPL.TabIndex = 5;
            this.qualityPL.UseSelectable = true;
            this.qualityPL.Click += new System.EventHandler(this.qualityPL_Click);
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(16, 121);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(39, 19);
            this.metroLabel21.TabIndex = 3;
            this.metroLabel21.Text = "Party";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Packing List";
            // 
            // vehicleNo
            // 
            this.vehicleNo.Lines = new string[0];
            this.vehicleNo.Location = new System.Drawing.Point(361, 29);
            this.vehicleNo.MaxLength = 32767;
            this.vehicleNo.Name = "vehicleNo";
            this.vehicleNo.PasswordChar = '\0';
            this.vehicleNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.vehicleNo.SelectedText = "";
            this.vehicleNo.Size = new System.Drawing.Size(161, 23);
            this.vehicleNo.TabIndex = 7;
            this.vehicleNo.UseSelectable = true;
            this.vehicleNo.Click += new System.EventHandler(this.vehicleNo_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(280, 91);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(75, 19);
            this.metroLabel11.TabIndex = 4;
            this.metroLabel11.Text = "Total Meter";
            this.metroLabel11.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // metroTB_PL_ID
            // 
            this.metroTB_PL_ID.Lines = new string[0];
            this.metroTB_PL_ID.Location = new System.Drawing.Point(97, 29);
            this.metroTB_PL_ID.MaxLength = 32767;
            this.metroTB_PL_ID.Name = "metroTB_PL_ID";
            this.metroTB_PL_ID.PasswordChar = '\0';
            this.metroTB_PL_ID.ReadOnly = true;
            this.metroTB_PL_ID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTB_PL_ID.SelectedText = "";
            this.metroTB_PL_ID.Size = new System.Drawing.Size(161, 23);
            this.metroTB_PL_ID.TabIndex = 3;
            this.metroTB_PL_ID.UseSelectable = true;
            this.metroTB_PL_ID.Click += new System.EventHandler(this.metroTB_PL_ID_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(280, 64);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(43, 19);
            this.metroLabel10.TabIndex = 3;
            this.metroLabel10.Text = "Status";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(16, 91);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(50, 19);
            this.metroLabel7.TabIndex = 4;
            this.metroLabel7.Text = "Quality";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(280, 33);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(61, 19);
            this.metroLabel9.TabIndex = 4;
            this.metroLabel9.Text = "Vehicle #";
            this.metroLabel9.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(16, 64);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(36, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Date";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(16, 33);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(21, 19);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "ID";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
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
            this.metroGrid_PLLI.Location = new System.Drawing.Point(39, 408);
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
            this.metroGrid_PLLI.Size = new System.Drawing.Size(949, 209);
            this.metroGrid_PLLI.TabIndex = 12;
            this.metroGrid_PLLI.UseCustomBackColor = true;
            this.metroGrid_PLLI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid_PLLI_CellContentClick);
            // 
            // itemGrid
            // 
            this.itemGrid.AllowUserToResizeRows = false;
            this.itemGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.itemGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.itemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNameGrid,
            this.ItemQtyGrid,
            this.descGrid,
            this.statusGrid});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.itemGrid.EnableHeadersVisualStyles = false;
            this.itemGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.itemGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemGrid.Location = new System.Drawing.Point(566, 163);
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.itemGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.itemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemGrid.Size = new System.Drawing.Size(469, 239);
            this.itemGrid.TabIndex = 13;
            this.itemGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // ItemNameGrid
            // 
            this.ItemNameGrid.HeaderText = "ItemName";
            this.ItemNameGrid.Name = "ItemNameGrid";
            // 
            // ItemQtyGrid
            // 
            this.ItemQtyGrid.HeaderText = "Item Qty";
            this.ItemQtyGrid.Name = "ItemQtyGrid";
            // 
            // descGrid
            // 
            this.descGrid.HeaderText = "Description";
            this.descGrid.Name = "descGrid";
            // 
            // statusGrid
            // 
            this.statusGrid.HeaderText = "Status";
            this.statusGrid.Items.AddRange(new object[] {
            "Generated",
            "Send",
            "Unchecked",
            "Received"});
            this.statusGrid.Name = "statusGrid";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(584, 93);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(77, 19);
            this.metroLabel12.TabIndex = 3;
            this.metroLabel12.Text = "Contract_ID";
            this.metroLabel12.Click += new System.EventHandler(this.metroLabel12_Click_1);
            // 
            // contractID
            // 
            this.contractID.FormattingEnabled = true;
            this.contractID.ItemHeight = 23;
            this.contractID.Location = new System.Drawing.Point(755, 87);
            this.contractID.Name = "contractID";
            this.contractID.Size = new System.Drawing.Size(182, 29);
            this.contractID.TabIndex = 2;
            this.contractID.UseSelectable = true;
            this.contractID.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(39, 18);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(99, 25);
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Packing List";
            // 
            // AddBtnForGrid
            // 
            this.AddBtnForGrid.Location = new System.Drawing.Point(960, 134);
            this.AddBtnForGrid.Name = "AddBtnForGrid";
            this.AddBtnForGrid.Size = new System.Drawing.Size(75, 23);
            this.AddBtnForGrid.TabIndex = 16;
            this.AddBtnForGrid.Text = "Add";
            this.AddBtnForGrid.UseSelectable = true;
            this.AddBtnForGrid.Click += new System.EventHandler(this.AddBtnForGrid_Click);
            // 
            // totQtyforGrid
            // 
            this.totQtyforGrid.Lines = new string[0];
            this.totQtyforGrid.Location = new System.Drawing.Point(810, 131);
            this.totQtyforGrid.MaxLength = 32767;
            this.totQtyforGrid.Name = "totQtyforGrid";
            this.totQtyforGrid.PasswordChar = '\0';
            this.totQtyforGrid.ReadOnly = true;
            this.totQtyforGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totQtyforGrid.SelectedText = "";
            this.totQtyforGrid.Size = new System.Drawing.Size(127, 23);
            this.totQtyforGrid.TabIndex = 17;
            this.totQtyforGrid.UseSelectable = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(732, 135);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(61, 19);
            this.metroLabel13.TabIndex = 18;
            this.metroLabel13.Text = "Total Qty";
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::ISE_WIM.Properties.Resources.close_btn;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(983, 1);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(78, 54);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Packing_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1063, 643);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.totQtyforGrid);
            this.Controls.Add(this.AddBtnForGrid);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.itemGrid);
            this.Controls.Add(this.metroGrid_PLLI);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.contractID);
            this.Controls.Add(this.metroLabel12);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Packing_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Packing_List_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_PLLI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox managerID;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTB_PL_ID;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton metroBtn_View;
        private MetroFramework.Controls.MetroButton metroBtn_Delete;
        private MetroFramework.Controls.MetroButton metroBtn_Update;
        private MetroFramework.Controls.MetroButton metroBtn_Add;
        private MetroFramework.Controls.MetroDateTime metroDateTime_PL;
        private MetroFramework.Controls.MetroTextBox statusTxt;
        private MetroFramework.Controls.MetroTextBox totMtrTxt;
        private MetroFramework.Controls.MetroTextBox qualityPL;
        private MetroFramework.Controls.MetroTextBox vehicleNo;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroGrid metroGrid_PLLI;
        private MetroFramework.Controls.MetroTextBox totPeiceTxt;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroTextBox partyPL;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroGrid itemGrid;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroComboBox contractID;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton AddBtnForGrid;
        private MetroFramework.Controls.MetroTextBox totQtyforGrid;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemNameGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQtyGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn descGrid;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusGrid;
    }
}