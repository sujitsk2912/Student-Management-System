namespace Attendance_management_system
{
    partial class frmattendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmattendance));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.attendancepanel = new System.Windows.Forms.Panel();
            this.btnsave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtbatch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtfacultyname = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.AttendanceDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.HeaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderPresent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HeaderAbsent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnenter = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.attendancepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.guna2PictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1597, 53);
            this.panel3.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Attendance_management_system.Properties.Resources.google_docs_2991108;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(38, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(40, 28);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 35;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(84, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Attendance";
            // 
            // attendancepanel
            // 
            this.attendancepanel.BackColor = System.Drawing.Color.GhostWhite;
            this.attendancepanel.Controls.Add(this.btnsave);
            this.attendancepanel.Controls.Add(this.guna2Separator1);
            this.attendancepanel.Controls.Add(this.txtbatch);
            this.attendancepanel.Controls.Add(this.txtfacultyname);
            this.attendancepanel.Controls.Add(this.txtdate);
            this.attendancepanel.Controls.Add(this.AttendanceDataGridView);
            this.attendancepanel.Controls.Add(this.label5);
            this.attendancepanel.Controls.Add(this.label3);
            this.attendancepanel.Controls.Add(this.label8);
            this.attendancepanel.Controls.Add(this.btnenter);
            this.attendancepanel.Controls.Add(this.panel3);
            this.attendancepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendancepanel.Location = new System.Drawing.Point(0, 0);
            this.attendancepanel.Name = "attendancepanel";
            this.attendancepanel.Size = new System.Drawing.Size(1597, 905);
            this.attendancepanel.TabIndex = 7;
           
            // btnsave
            // 
            this.btnsave.AllowAnimations = true;
            this.btnsave.AllowMouseEffects = true;
            this.btnsave.AllowToggling = false;
            this.btnsave.AnimationSpeed = 200;
            this.btnsave.AutoGenerateColors = false;
            this.btnsave.AutoRoundBorders = false;
            this.btnsave.AutoSizeLeftIcon = false;
            this.btnsave.AutoSizeRightIcon = true;
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.BackColor1 = System.Drawing.SystemColors.HotTrack;
            this.btnsave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsave.BackgroundImage")));
            this.btnsave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnsave.ButtonText = "Submit";
            this.btnsave.ButtonTextMarginLeft = 0;
            this.btnsave.ColorContrastOnClick = 45;
            this.btnsave.ColorContrastOnHover = 45;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnsave.CustomizableEdges = borderEdges5;
            this.btnsave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnsave.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnsave.DisabledFillColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnsave.DisabledForecolor = System.Drawing.Color.White;
            this.btnsave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnsave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnsave.IconLeftPadding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            this.btnsave.IconMarginLeft = 11;
            this.btnsave.IconPadding = 10;
            this.btnsave.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnsave.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.btnsave.IconSize = 25;
            this.btnsave.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnsave.IdleBorderRadius = 1;
            this.btnsave.IdleBorderThickness = 1;
            this.btnsave.IdleFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnsave.IdleIconLeftImage = null;
            this.btnsave.IdleIconRightImage = null;
            this.btnsave.IndicateFocus = false;
            this.btnsave.Location = new System.Drawing.Point(642, 828);
            this.btnsave.Name = "btnsave";
            this.btnsave.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnsave.OnDisabledState.BorderRadius = 1;
            this.btnsave.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnsave.OnDisabledState.BorderThickness = 1;
            this.btnsave.OnDisabledState.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnsave.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnsave.OnDisabledState.IconLeftImage = null;
            this.btnsave.OnDisabledState.IconRightImage = null;
            this.btnsave.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnsave.onHoverState.BorderRadius = 1;
            this.btnsave.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnsave.onHoverState.BorderThickness = 1;
            this.btnsave.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnsave.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnsave.onHoverState.IconLeftImage = null;
            this.btnsave.onHoverState.IconRightImage = null;
            this.btnsave.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnsave.OnIdleState.BorderRadius = 1;
            this.btnsave.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnsave.OnIdleState.BorderThickness = 1;
            this.btnsave.OnIdleState.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnsave.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnsave.OnIdleState.IconLeftImage = null;
            this.btnsave.OnIdleState.IconRightImage = null;
            this.btnsave.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnsave.OnPressedState.BorderRadius = 1;
            this.btnsave.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnsave.OnPressedState.BorderThickness = 1;
            this.btnsave.OnPressedState.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnsave.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnsave.OnPressedState.IconLeftImage = null;
            this.btnsave.OnPressedState.IconRightImage = null;
            this.btnsave.Size = new System.Drawing.Size(260, 39);
            this.btnsave.TabIndex = 45;
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsave.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsave.TextMarginLeft = 0;
            this.btnsave.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnsave.UseDefaultRadiusAndThickness = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(123, 187);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1350, 10);
            this.guna2Separator1.TabIndex = 41;
           
            // 
            // txtbatch
            // 
            this.txtbatch.BackColor = System.Drawing.Color.Transparent;
            this.txtbatch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtbatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtbatch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbatch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbatch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtbatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtbatch.ItemHeight = 30;
            this.txtbatch.Items.AddRange(new object[] {
            "Java",
            "DotNet"});
            this.txtbatch.Location = new System.Drawing.Point(887, 123);
            this.txtbatch.Name = "txtbatch";
            this.txtbatch.Size = new System.Drawing.Size(275, 36);
            this.txtbatch.StartIndex = 0;
            this.txtbatch.TabIndex = 39;
            this.txtbatch.TextOffset = new System.Drawing.Point(10, 0);
         
            this.txtbatch.SelectedValueChanged += new System.EventHandler(this.txtbatch_SelectedValueChanged);
            // 
            // txtfacultyname
            // 
            this.txtfacultyname.BackColor = System.Drawing.Color.Transparent;
            this.txtfacultyname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtfacultyname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtfacultyname.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfacultyname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfacultyname.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtfacultyname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtfacultyname.ItemHeight = 30;
            this.txtfacultyname.Location = new System.Drawing.Point(506, 123);
            this.txtfacultyname.Name = "txtfacultyname";
            this.txtfacultyname.Size = new System.Drawing.Size(275, 36);
            this.txtfacultyname.TabIndex = 39;
            this.txtfacultyname.TextOffset = new System.Drawing.Point(10, 0);
           
            this.txtfacultyname.SelectedValueChanged += new System.EventHandler(this.txtfacultyname_SelectedValueChanged);
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.Color.Transparent;
            this.txtdate.BorderColor = System.Drawing.Color.Empty;
            this.txtdate.Checked = true;
            this.txtdate.FillColor = System.Drawing.Color.GhostWhite;
            this.txtdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdate.Location = new System.Drawing.Point(248, 123);
            this.txtdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(150, 36);
            this.txtdate.TabIndex = 36;
            this.txtdate.Value = new System.DateTime(2023, 12, 21, 21, 14, 14, 706);
            // 
            // AttendanceDataGridView
            // 
            this.AttendanceDataGridView.AllowUserToAddRows = false;
            this.AttendanceDataGridView.AllowUserToDeleteRows = false;
            this.AttendanceDataGridView.AllowUserToResizeColumns = false;
            this.AttendanceDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            this.AttendanceDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(115)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendanceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.AttendanceDataGridView.ColumnHeadersHeight = 45;
            this.AttendanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HeaderID,
            this.HeaderName,
            this.HeaderBatch,
            this.HeaderPresent,
            this.HeaderAbsent});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(58)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(58)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AttendanceDataGridView.DefaultCellStyle = dataGridViewCellStyle20;
            this.AttendanceDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AttendanceDataGridView.Location = new System.Drawing.Point(123, 220);
            this.AttendanceDataGridView.Name = "AttendanceDataGridView";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendanceDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.AttendanceDataGridView.RowHeadersVisible = false;
            this.AttendanceDataGridView.RowHeadersWidth = 60;
            this.AttendanceDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AttendanceDataGridView.RowTemplate.Height = 45;
            this.AttendanceDataGridView.ShowCellErrors = false;
            this.AttendanceDataGridView.ShowEditingIcon = false;
            this.AttendanceDataGridView.ShowRowErrors = false;
            this.AttendanceDataGridView.Size = new System.Drawing.Size(1353, 575);
            this.AttendanceDataGridView.TabIndex = 35;
            this.AttendanceDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AttendanceDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AttendanceDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AttendanceDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AttendanceDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AttendanceDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AttendanceDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AttendanceDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AttendanceDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AttendanceDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AttendanceDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AttendanceDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.AttendanceDataGridView.ThemeStyle.ReadOnly = false;
            this.AttendanceDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AttendanceDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AttendanceDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AttendanceDataGridView.ThemeStyle.RowsStyle.Height = 45;
            this.AttendanceDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AttendanceDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
           
            // 
            // HeaderID
            // 
            this.HeaderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderID.DataPropertyName = "STUDENT ID";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HeaderID.DefaultCellStyle = dataGridViewCellStyle17;
            this.HeaderID.HeaderText = "STUDENT ID";
            this.HeaderID.MinimumWidth = 6;
            this.HeaderID.Name = "HeaderID";
            this.HeaderID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // HeaderName
            // 
            this.HeaderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderName.DataPropertyName = "FULLNAME";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HeaderName.DefaultCellStyle = dataGridViewCellStyle18;
            this.HeaderName.HeaderText = "NAME";
            this.HeaderName.MinimumWidth = 6;
            this.HeaderName.Name = "HeaderName";
            this.HeaderName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // HeaderBatch
            // 
            this.HeaderBatch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderBatch.DataPropertyName = "COURSE";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HeaderBatch.DefaultCellStyle = dataGridViewCellStyle19;
            this.HeaderBatch.HeaderText = "BATCH";
            this.HeaderBatch.MinimumWidth = 6;
            this.HeaderBatch.Name = "HeaderBatch";
            this.HeaderBatch.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // HeaderPresent
            // 
            this.HeaderPresent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderPresent.DataPropertyName = "PRESENT";
            this.HeaderPresent.FalseValue = "";
            this.HeaderPresent.HeaderText = "PRESENT";
            this.HeaderPresent.IndeterminateValue = "";
            this.HeaderPresent.MinimumWidth = 6;
            this.HeaderPresent.Name = "HeaderPresent";
            this.HeaderPresent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HeaderPresent.TrueValue = "Present";
            // 
            // HeaderAbsent
            // 
            this.HeaderAbsent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderAbsent.DataPropertyName = "ABSENT";
            this.HeaderAbsent.HeaderText = "ABSENT";
            this.HeaderAbsent.MinimumWidth = 6;
            this.HeaderAbsent.Name = "HeaderAbsent";
            this.HeaderAbsent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HeaderAbsent.TrueValue = "Absent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(882, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Batch: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(252, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Date: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(501, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Faculty Name: ";
            // 
            // btnenter
            // 
            this.btnenter.AllowAnimations = true;
            this.btnenter.AllowMouseEffects = true;
            this.btnenter.AllowToggling = false;
            this.btnenter.AnimationSpeed = 200;
            this.btnenter.AutoGenerateColors = false;
            this.btnenter.AutoRoundBorders = false;
            this.btnenter.AutoSizeLeftIcon = true;
            this.btnenter.AutoSizeRightIcon = true;
            this.btnenter.BackColor = System.Drawing.Color.Transparent;
            this.btnenter.BackColor1 = System.Drawing.SystemColors.HotTrack;
            this.btnenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnenter.BackgroundImage")));
            this.btnenter.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnenter.ButtonText = "Enter";
            this.btnenter.ButtonTextMarginLeft = 0;
            this.btnenter.ColorContrastOnClick = 45;
            this.btnenter.ColorContrastOnHover = 45;
            this.btnenter.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnenter.CustomizableEdges = borderEdges6;
            this.btnenter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnenter.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnenter.DisabledFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnenter.DisabledForecolor = System.Drawing.Color.White;
            this.btnenter.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnenter.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenter.ForeColor = System.Drawing.Color.White;
            this.btnenter.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnenter.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnenter.IconLeftPadding = new System.Windows.Forms.Padding(0);
            this.btnenter.IconMarginLeft = 11;
            this.btnenter.IconPadding = 10;
            this.btnenter.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnenter.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnenter.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.btnenter.IconSize = 25;
            this.btnenter.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnenter.IdleBorderRadius = 1;
            this.btnenter.IdleBorderThickness = 1;
            this.btnenter.IdleFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnenter.IdleIconLeftImage = null;
            this.btnenter.IdleIconRightImage = null;
            this.btnenter.IndicateFocus = false;
            this.btnenter.Location = new System.Drawing.Point(1228, 120);
            this.btnenter.Name = "btnenter";
            this.btnenter.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnenter.OnDisabledState.BorderRadius = 1;
            this.btnenter.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnenter.OnDisabledState.BorderThickness = 1;
            this.btnenter.OnDisabledState.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnenter.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnenter.OnDisabledState.IconLeftImage = null;
            this.btnenter.OnDisabledState.IconRightImage = null;
            this.btnenter.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnenter.onHoverState.BorderRadius = 1;
            this.btnenter.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnenter.onHoverState.BorderThickness = 1;
            this.btnenter.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnenter.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnenter.onHoverState.IconLeftImage = null;
            this.btnenter.onHoverState.IconRightImage = null;
            this.btnenter.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnenter.OnIdleState.BorderRadius = 1;
            this.btnenter.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnenter.OnIdleState.BorderThickness = 1;
            this.btnenter.OnIdleState.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnenter.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnenter.OnIdleState.IconLeftImage = null;
            this.btnenter.OnIdleState.IconRightImage = null;
            this.btnenter.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnenter.OnPressedState.BorderRadius = 1;
            this.btnenter.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnenter.OnPressedState.BorderThickness = 1;
            this.btnenter.OnPressedState.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnenter.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnenter.OnPressedState.IconLeftImage = null;
            this.btnenter.OnPressedState.IconRightImage = null;
            this.btnenter.Size = new System.Drawing.Size(120, 39);
            this.btnenter.TabIndex = 6;
            this.btnenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnenter.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnenter.TextMarginLeft = 0;
            this.btnenter.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnenter.UseDefaultRadiusAndThickness = true;
            this.btnenter.Click += new System.EventHandler(this.bunifuButton5_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.AttendanceDataGridView;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.txtdate;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.btnsave;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.btnenter;
            // 
            // frmattendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1597, 905);
            this.Controls.Add(this.attendancepanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmattendance";
            this.Text = "frmattendance";
          
            this.Load += new System.EventHandler(this.frmattendance_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.attendancepanel.ResumeLayout(false);
            this.attendancepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLLNODataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel attendancepanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnenter;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView AttendanceDataGridView;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtdate;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2ComboBox txtbatch;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnsave;
        private Guna.UI2.WinForms.Guna2ComboBox txtfacultyname;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderBatch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HeaderPresent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HeaderAbsent;
    }
}