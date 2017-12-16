namespace ISE_WIM.Transactional_Forms
{
    partial class Contract
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.startDate = new MetroFramework.Controls.MetroDateTime();
            this.cPaymenttermtxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cDescrtxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cDeliverytermtxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.contractID = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.endDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.TotalCosttxt = new MetroFramework.Controls.MetroTextBox();
            this.LoomSize = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.ratemtrtxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.NoOfLommstxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.ItmDSCP = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.ItemNametxt = new MetroFramework.Controls.MetroTextBox();
            this.contractGridView = new MetroFramework.Controls.MetroGrid();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.viewBtn = new MetroFramework.Controls.MetroButton();
            this.deleteBtn = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractGridView)).BeginInit();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(46, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ContractID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(46, 70);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "StartDate";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(148, 70);
            this.startDate.MinDate = new System.DateTime(2015, 12, 22, 0, 0, 0, 0);
            this.startDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(82, 29);
            this.startDate.TabIndex = 4;
            this.startDate.Value = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // cPaymenttermtxt
            // 
            this.cPaymenttermtxt.Lines = new string[0];
            this.cPaymenttermtxt.Location = new System.Drawing.Point(148, 105);
            this.cPaymenttermtxt.MaxLength = 32767;
            this.cPaymenttermtxt.Name = "cPaymenttermtxt";
            this.cPaymenttermtxt.PasswordChar = '\0';
            this.cPaymenttermtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cPaymenttermtxt.SelectedText = "";
            this.cPaymenttermtxt.Size = new System.Drawing.Size(261, 23);
            this.cPaymenttermtxt.TabIndex = 6;
            this.cPaymenttermtxt.UseSelectable = true;
            this.cPaymenttermtxt.Click += new System.EventHandler(this.cPaymenttermtxt_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(46, 105);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(92, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Payment Term";
            // 
            // cDescrtxt
            // 
            this.cDescrtxt.Lines = new string[0];
            this.cDescrtxt.Location = new System.Drawing.Point(148, 134);
            this.cDescrtxt.MaxLength = 32767;
            this.cDescrtxt.Multiline = true;
            this.cDescrtxt.Name = "cDescrtxt";
            this.cDescrtxt.PasswordChar = '\0';
            this.cDescrtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cDescrtxt.SelectedText = "";
            this.cDescrtxt.Size = new System.Drawing.Size(261, 52);
            this.cDescrtxt.TabIndex = 8;
            this.cDescrtxt.UseSelectable = true;
            this.cDescrtxt.Click += new System.EventHandler(this.cDescrtxt_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(46, 134);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Description";
            // 
            // cDeliverytermtxt
            // 
            this.cDeliverytermtxt.Lines = new string[0];
            this.cDeliverytermtxt.Location = new System.Drawing.Point(148, 192);
            this.cDeliverytermtxt.MaxLength = 32767;
            this.cDeliverytermtxt.Name = "cDeliverytermtxt";
            this.cDeliverytermtxt.PasswordChar = '\0';
            this.cDeliverytermtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cDeliverytermtxt.SelectedText = "";
            this.cDeliverytermtxt.Size = new System.Drawing.Size(261, 23);
            this.cDeliverytermtxt.TabIndex = 12;
            this.cDeliverytermtxt.UseSelectable = true;
            this.cDeliverytermtxt.Click += new System.EventHandler(this.cDeliverytermtxt_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(46, 192);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(88, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Delivery term";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.contractID);
            this.metroPanel1.Controls.Add(this.metroLabel15);
            this.metroPanel1.Controls.Add(this.endDate);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.cDeliverytermtxt);
            this.metroPanel1.Controls.Add(this.metroTextBox1);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.cDescrtxt);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.startDate);
            this.metroPanel1.Controls.Add(this.cPaymenttermtxt);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(418, 69);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(440, 231);
            this.metroPanel1.TabIndex = 13;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // contractID
            // 
            this.contractID.FormattingEnabled = true;
            this.contractID.ItemHeight = 23;
            this.contractID.Location = new System.Drawing.Point(148, 5);
            this.contractID.Name = "contractID";
            this.contractID.Size = new System.Drawing.Size(261, 29);
            this.contractID.TabIndex = 36;
            this.contractID.UseSelectable = true;
            this.contractID.SelectedIndexChanged += new System.EventHandler(this.contractID_SelectedIndexChanged);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(246, 73);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(58, 19);
            this.metroLabel15.TabIndex = 34;
            this.metroLabel15.Text = "EndDate";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(327, 70);
            this.endDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(82, 29);
            this.endDate.TabIndex = 35;
            this.endDate.ValueChanged += new System.EventHandler(this.endDate_ValueChanged);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(46, 40);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(36, 19);
            this.metroLabel12.TabIndex = 33;
            this.metroLabel12.Text = "PO#";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(148, 40);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(261, 23);
            this.metroTextBox1.TabIndex = 32;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            this.metroTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.TotalCosttxt);
            this.metroPanel2.Controls.Add(this.LoomSize);
            this.metroPanel2.Controls.Add(this.metroLabel13);
            this.metroPanel2.Controls.Add(this.ratemtrtxt);
            this.metroPanel2.Controls.Add(this.metroLabel8);
            this.metroPanel2.Controls.Add(this.metroLabel14);
            this.metroPanel2.Controls.Add(this.NoOfLommstxt);
            this.metroPanel2.Controls.Add(this.metroLabel9);
            this.metroPanel2.Controls.Add(this.metroLabel10);
            this.metroPanel2.Controls.Add(this.ItmDSCP);
            this.metroPanel2.Controls.Add(this.metroLabel11);
            this.metroPanel2.Controls.Add(this.ItemNametxt);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(864, 70);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(386, 230);
            this.metroPanel2.TabIndex = 14;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            this.metroPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel2_Paint);
            // 
            // TotalCosttxt
            // 
            this.TotalCosttxt.Lines = new string[0];
            this.TotalCosttxt.Location = new System.Drawing.Point(146, 165);
            this.TotalCosttxt.MaxLength = 32767;
            this.TotalCosttxt.Name = "TotalCosttxt";
            this.TotalCosttxt.PasswordChar = '\0';
            this.TotalCosttxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TotalCosttxt.SelectedText = "";
            this.TotalCosttxt.Size = new System.Drawing.Size(230, 23);
            this.TotalCosttxt.TabIndex = 29;
            this.TotalCosttxt.UseSelectable = true;
            this.TotalCosttxt.Click += new System.EventHandler(this.TotalCosttxt_Click);
            // 
            // LoomSize
            // 
            this.LoomSize.Lines = new string[0];
            this.LoomSize.Location = new System.Drawing.Point(146, 43);
            this.LoomSize.MaxLength = 32767;
            this.LoomSize.Name = "LoomSize";
            this.LoomSize.PasswordChar = '\0';
            this.LoomSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LoomSize.SelectedText = "";
            this.LoomSize.Size = new System.Drawing.Size(230, 23);
            this.LoomSize.TabIndex = 25;
            this.LoomSize.UseSelectable = true;
            this.LoomSize.Click += new System.EventHandler(this.LoomSize_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(13, 136);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(84, 19);
            this.metroLabel13.TabIndex = 26;
            this.metroLabel13.Text = "Rate per mtr";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ratemtrtxt
            // 
            this.ratemtrtxt.Lines = new string[0];
            this.ratemtrtxt.Location = new System.Drawing.Point(146, 136);
            this.ratemtrtxt.MaxLength = 32767;
            this.ratemtrtxt.Name = "ratemtrtxt";
            this.ratemtrtxt.PasswordChar = '\0';
            this.ratemtrtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ratemtrtxt.SelectedText = "";
            this.ratemtrtxt.Size = new System.Drawing.Size(230, 23);
            this.ratemtrtxt.TabIndex = 27;
            this.ratemtrtxt.UseSelectable = true;
            this.ratemtrtxt.Click += new System.EventHandler(this.ratemtrtxt_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(13, 76);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(75, 19);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Item Name";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(13, 165);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(66, 19);
            this.metroLabel14.TabIndex = 28;
            this.metroLabel14.Text = "Total Cost";
            // 
            // NoOfLommstxt
            // 
            this.NoOfLommstxt.Lines = new string[0];
            this.NoOfLommstxt.Location = new System.Drawing.Point(146, 107);
            this.NoOfLommstxt.MaxLength = 32767;
            this.NoOfLommstxt.Name = "NoOfLommstxt";
            this.NoOfLommstxt.PasswordChar = '\0';
            this.NoOfLommstxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NoOfLommstxt.SelectedText = "";
            this.NoOfLommstxt.Size = new System.Drawing.Size(230, 23);
            this.NoOfLommstxt.TabIndex = 22;
            this.NoOfLommstxt.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(13, 14);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(113, 19);
            this.metroLabel9.TabIndex = 13;
            this.metroLabel9.Text = "Contract Remarks";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(13, 107);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(86, 19);
            this.metroLabel10.TabIndex = 21;
            this.metroLabel10.Text = "No of Looms";
            // 
            // ItmDSCP
            // 
            this.ItmDSCP.Lines = new string[0];
            this.ItmDSCP.Location = new System.Drawing.Point(146, 14);
            this.ItmDSCP.MaxLength = 32767;
            this.ItmDSCP.Name = "ItmDSCP";
            this.ItmDSCP.PasswordChar = '\0';
            this.ItmDSCP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ItmDSCP.SelectedText = "";
            this.ItmDSCP.Size = new System.Drawing.Size(230, 23);
            this.ItmDSCP.TabIndex = 14;
            this.ItmDSCP.UseSelectable = true;
            this.ItmDSCP.Click += new System.EventHandler(this.ItmDSCP_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(13, 43);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(70, 19);
            this.metroLabel11.TabIndex = 15;
            this.metroLabel11.Text = "Loom Size";
            // 
            // ItemNametxt
            // 
            this.ItemNametxt.Lines = new string[0];
            this.ItemNametxt.Location = new System.Drawing.Point(146, 76);
            this.ItemNametxt.MaxLength = 32767;
            this.ItemNametxt.Name = "ItemNametxt";
            this.ItemNametxt.PasswordChar = '\0';
            this.ItemNametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ItemNametxt.SelectedText = "";
            this.ItemNametxt.Size = new System.Drawing.Size(230, 23);
            this.ItemNametxt.TabIndex = 18;
            this.ItemNametxt.UseSelectable = true;
            this.ItemNametxt.Click += new System.EventHandler(this.ItemNametxt_Click);
            // 
            // contractGridView
            // 
            this.contractGridView.AllowUserToResizeRows = false;
            this.contractGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.contractGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contractGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.contractGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contractGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.contractGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.contractGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.contractGridView.EnableHeadersVisualStyles = false;
            this.contractGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.contractGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.contractGridView.Location = new System.Drawing.Point(33, 306);
            this.contractGridView.Name = "contractGridView";
            this.contractGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contractGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.contractGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.contractGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contractGridView.Size = new System.Drawing.Size(1108, 223);
            this.contractGridView.TabIndex = 30;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1156, 306);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(94, 29);
            this.metroButton1.TabIndex = 31;
            this.metroButton1.Text = "SAVE";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroComboBox1);
            this.metroPanel3.Controls.Add(this.metroLabel16);
            this.metroPanel3.Controls.Add(this.metroTextBox3);
            this.metroPanel3.Controls.Add(this.metroLabel17);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(33, 69);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(379, 230);
            this.metroPanel3.TabIndex = 32;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            this.metroPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel3_Paint);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(57, 152);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(261, 29);
            this.metroComboBox1.TabIndex = 37;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged_1);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(6, 47);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(78, 19);
            this.metroLabel16.TabIndex = 34;
            this.metroLabel16.Text = "Manager ID";
            this.metroLabel16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(57, 76);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ReadOnly = true;
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.Size = new System.Drawing.Size(261, 23);
            this.metroTextBox3.TabIndex = 35;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.Click += new System.EventHandler(this.metroTextBox3_Click);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(6, 118);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(102, 19);
            this.metroLabel17.TabIndex = 36;
            this.metroLabel17.Text = "Manager Name";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel18.Location = new System.Drawing.Point(12, 13);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(80, 25);
            this.metroLabel18.TabIndex = 33;
            this.metroLabel18.Text = "Contract:";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel19.Location = new System.Drawing.Point(346, 13);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(163, 25);
            this.metroLabel19.TabIndex = 34;
            this.metroLabel19.Text = "WIM Textile Industry";
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(1156, 341);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(94, 29);
            this.viewBtn.TabIndex = 37;
            this.viewBtn.Text = "View";
            this.viewBtn.UseSelectable = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(1156, 376);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(94, 29);
            this.deleteBtn.TabIndex = 38;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseSelectable = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.BackgroundImage = global::ISE_WIM.Properties.Resources.close_btn;
            this.metroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton3.Location = new System.Drawing.Point(1196, 0);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 52);
            this.metroButton3.TabIndex = 36;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1273, 548);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.contractGridView);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Contract_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractGridView)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime startDate;
        private MetroFramework.Controls.MetroTextBox cPaymenttermtxt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox cDescrtxt;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox cDeliverytermtxt;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox NoOfLommstxt;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox ItmDSCP;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox ItemNametxt;
        private MetroFramework.Controls.MetroTextBox LoomSize;
        private MetroFramework.Controls.MetroTextBox TotalCosttxt;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox ratemtrtxt;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroGrid contractGridView;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroDateTime endDate;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton viewBtn;
        private MetroFramework.Controls.MetroButton deleteBtn;
        private MetroFramework.Controls.MetroComboBox contractID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}