namespace Attendance_management_system
{
    partial class frmAttendanceRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttendanceRecord));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.attendancepanel = new System.Windows.Forms.Panel();
            this.btnrefresh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnprint = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbatch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsearchrecord = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AttendanceRecordDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.HeaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderPresent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderAbsent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderAction = new System.Windows.Forms.DataGridViewImageColumn();
            this.attendancepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnrefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceRecordDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // attendancepanel
            // 
            this.attendancepanel.BackColor = System.Drawing.Color.GhostWhite;
            this.attendancepanel.Controls.Add(this.btnrefresh);
            this.attendancepanel.Controls.Add(this.btnprint);
            this.attendancepanel.Controls.Add(this.guna2Separator1);
            this.attendancepanel.Controls.Add(this.txtdate);
            this.attendancepanel.Controls.Add(this.label4);
            this.attendancepanel.Controls.Add(this.txtbatch);
            this.attendancepanel.Controls.Add(this.label1);
            this.attendancepanel.Controls.Add(this.btnsearchrecord);
            this.attendancepanel.Controls.Add(this.AttendanceRecordDataGridView);
            this.attendancepanel.Controls.Add(this.panel3);
            this.attendancepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendancepanel.Location = new System.Drawing.Point(0, 0);
            this.attendancepanel.Name = "attendancepanel";
            this.attendancepanel.Size = new System.Drawing.Size(1597, 905);
            this.attendancepanel.TabIndex = 8;
        
            // 
            // btnrefresh
            // 
            this.btnrefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrefresh.Image = global::Attendance_management_system.Properties.Resources.loading_arrow;
            this.btnrefresh.ImageRotate = 0F;
            this.btnrefresh.Location = new System.Drawing.Point(1219, 92);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(38, 45);
            this.btnrefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnrefresh.TabIndex = 50;
            this.btnrefresh.TabStop = false;
            this.toolTip1.SetToolTip(this.btnrefresh, "Refresh Button");
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnprint
            // 
            this.btnprint.AllowAnimations = true;
            this.btnprint.AllowMouseEffects = true;
            this.btnprint.AllowToggling = false;
            this.btnprint.AnimationSpeed = 200;
            this.btnprint.AutoGenerateColors = false;
            this.btnprint.AutoRoundBorders = false;
            this.btnprint.AutoSizeLeftIcon = false;
            this.btnprint.AutoSizeRightIcon = true;
            this.btnprint.BackColor = System.Drawing.Color.Transparent;
            this.btnprint.BackColor1 = System.Drawing.SystemColors.HotTrack;
            this.btnprint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnprint.BackgroundImage")));
            this.btnprint.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnprint.ButtonText = "Print Records";
            this.btnprint.ButtonTextMarginLeft = 0;
            this.btnprint.ColorContrastOnClick = 45;
            this.btnprint.ColorContrastOnHover = 45;
            this.btnprint.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnprint.CustomizableEdges = borderEdges1;
            this.btnprint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnprint.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnprint.DisabledFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnprint.DisabledForecolor = System.Drawing.Color.White;
            this.btnprint.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnprint.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprint.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnprint.IconLeftPadding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnprint.IconMarginLeft = 11;
            this.btnprint.IconPadding = 10;
            this.btnprint.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnprint.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnprint.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.btnprint.IconSize = 25;
            this.btnprint.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnprint.IdleBorderRadius = 1;
            this.btnprint.IdleBorderThickness = 1;
            this.btnprint.IdleFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnprint.IdleIconLeftImage = null;
            this.btnprint.IdleIconRightImage = null;
            this.btnprint.IndicateFocus = false;
            this.btnprint.Location = new System.Drawing.Point(706, 830);
            this.btnprint.Name = "btnprint";
            this.btnprint.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnprint.OnDisabledState.BorderRadius = 1;
            this.btnprint.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnprint.OnDisabledState.BorderThickness = 1;
            this.btnprint.OnDisabledState.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnprint.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnprint.OnDisabledState.IconLeftImage = null;
            this.btnprint.OnDisabledState.IconRightImage = null;
            this.btnprint.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnprint.onHoverState.BorderRadius = 1;
            this.btnprint.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnprint.onHoverState.BorderThickness = 1;
            this.btnprint.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnprint.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnprint.onHoverState.IconLeftImage = null;
            this.btnprint.onHoverState.IconRightImage = null;
            this.btnprint.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnprint.OnIdleState.BorderRadius = 1;
            this.btnprint.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnprint.OnIdleState.BorderThickness = 1;
            this.btnprint.OnIdleState.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnprint.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnprint.OnIdleState.IconLeftImage = null;
            this.btnprint.OnIdleState.IconRightImage = null;
            this.btnprint.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnprint.OnPressedState.BorderRadius = 1;
            this.btnprint.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnprint.OnPressedState.BorderThickness = 1;
            this.btnprint.OnPressedState.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnprint.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnprint.OnPressedState.IconLeftImage = null;
            this.btnprint.OnPressedState.IconRightImage = null;
            this.btnprint.Size = new System.Drawing.Size(203, 39);
            this.btnprint.TabIndex = 48;
            this.btnprint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnprint.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnprint.TextMarginLeft = 0;
            this.btnprint.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnprint.UseDefaultRadiusAndThickness = true;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(123, 159);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1350, 10);
            this.guna2Separator1.TabIndex = 45;
            // 
            // txtdate
            // 
            this.txtdate.BorderColor = System.Drawing.Color.Empty;
            this.txtdate.Checked = true;
            this.txtdate.FillColor = System.Drawing.Color.GhostWhite;
            this.txtdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdate.Location = new System.Drawing.Point(440, 99);
            this.txtdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(164, 36);
            this.txtdate.TabIndex = 43;
            this.txtdate.Value = new System.DateTime(2023, 12, 21, 21, 14, 14, 706);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(365, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Date: ";
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
            this.txtbatch.Location = new System.Drawing.Point(773, 99);
            this.txtbatch.Name = "txtbatch";
            this.txtbatch.Size = new System.Drawing.Size(178, 36);
            this.txtbatch.StartIndex = 0;
            this.txtbatch.TabIndex = 41;
            this.txtbatch.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(701, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Batch: ";
            // 
            // btnsearchrecord
            // 
            this.btnsearchrecord.AllowAnimations = true;
            this.btnsearchrecord.AllowMouseEffects = true;
            this.btnsearchrecord.AllowToggling = false;
            this.btnsearchrecord.AnimationSpeed = 200;
            this.btnsearchrecord.AutoGenerateColors = false;
            this.btnsearchrecord.AutoRoundBorders = false;
            this.btnsearchrecord.AutoSizeLeftIcon = false;
            this.btnsearchrecord.AutoSizeRightIcon = false;
            this.btnsearchrecord.BackColor = System.Drawing.Color.Transparent;
            this.btnsearchrecord.BackColor1 = System.Drawing.SystemColors.HotTrack;
            this.btnsearchrecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsearchrecord.BackgroundImage")));
            this.btnsearchrecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsearchrecord.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnsearchrecord.ButtonText = "Search";
            this.btnsearchrecord.ButtonTextMarginLeft = 0;
            this.btnsearchrecord.ColorContrastOnClick = 45;
            this.btnsearchrecord.ColorContrastOnHover = 45;
            this.btnsearchrecord.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnsearchrecord.CustomizableEdges = borderEdges2;
            this.btnsearchrecord.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnsearchrecord.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnsearchrecord.DisabledFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnsearchrecord.DisabledForecolor = System.Drawing.Color.White;
            this.btnsearchrecord.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnsearchrecord.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchrecord.ForeColor = System.Drawing.Color.White;
            this.btnsearchrecord.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsearchrecord.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnsearchrecord.IconLeftPadding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnsearchrecord.IconMarginLeft = 11;
            this.btnsearchrecord.IconPadding = 10;
            this.btnsearchrecord.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsearchrecord.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnsearchrecord.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.btnsearchrecord.IconSize = 25;
            this.btnsearchrecord.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnsearchrecord.IdleBorderRadius = 1;
            this.btnsearchrecord.IdleBorderThickness = 1;
            this.btnsearchrecord.IdleFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnsearchrecord.IdleIconLeftImage = global::Attendance_management_system.Properties.Resources.search_7079548;
            this.btnsearchrecord.IdleIconRightImage = null;
            this.btnsearchrecord.IndicateFocus = false;
            this.btnsearchrecord.Location = new System.Drawing.Point(1017, 96);
            this.btnsearchrecord.Name = "btnsearchrecord";
            this.btnsearchrecord.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnsearchrecord.OnDisabledState.BorderRadius = 1;
            this.btnsearchrecord.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnsearchrecord.OnDisabledState.BorderThickness = 1;
            this.btnsearchrecord.OnDisabledState.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnsearchrecord.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnsearchrecord.OnDisabledState.IconLeftImage = null;
            this.btnsearchrecord.OnDisabledState.IconRightImage = null;
            this.btnsearchrecord.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnsearchrecord.onHoverState.BorderRadius = 1;
            this.btnsearchrecord.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnsearchrecord.onHoverState.BorderThickness = 1;
            this.btnsearchrecord.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnsearchrecord.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnsearchrecord.onHoverState.IconLeftImage = null;
            this.btnsearchrecord.onHoverState.IconRightImage = null;
            this.btnsearchrecord.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnsearchrecord.OnIdleState.BorderRadius = 1;
            this.btnsearchrecord.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnsearchrecord.OnIdleState.BorderThickness = 1;
            this.btnsearchrecord.OnIdleState.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnsearchrecord.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnsearchrecord.OnIdleState.IconLeftImage = global::Attendance_management_system.Properties.Resources.search_7079548;
            this.btnsearchrecord.OnIdleState.IconRightImage = null;
            this.btnsearchrecord.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnsearchrecord.OnPressedState.BorderRadius = 1;
            this.btnsearchrecord.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnsearchrecord.OnPressedState.BorderThickness = 1;
            this.btnsearchrecord.OnPressedState.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnsearchrecord.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnsearchrecord.OnPressedState.IconLeftImage = null;
            this.btnsearchrecord.OnPressedState.IconRightImage = null;
            this.btnsearchrecord.Size = new System.Drawing.Size(181, 39);
            this.btnsearchrecord.TabIndex = 38;
            this.btnsearchrecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsearchrecord.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsearchrecord.TextMarginLeft = 0;
            this.btnsearchrecord.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnsearchrecord.UseDefaultRadiusAndThickness = true;
            this.btnsearchrecord.Click += new System.EventHandler(this.btnsearchrecord_Click);
            // 
            // AttendanceRecordDataGridView
            // 
            this.AttendanceRecordDataGridView.AllowUserToAddRows = false;
            this.AttendanceRecordDataGridView.AllowUserToDeleteRows = false;
            this.AttendanceRecordDataGridView.AllowUserToResizeColumns = false;
            this.AttendanceRecordDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AttendanceRecordDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(115)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendanceRecordDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AttendanceRecordDataGridView.ColumnHeadersHeight = 45;
            this.AttendanceRecordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HeaderID,
            this.HeaderName,
            this.HeaderBatch,
            this.HeaderFaculty,
            this.HeaderPresent,
            this.HeaderAbsent,
            this.HeaderDate,
            this.HeaderAction});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(58)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(58)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AttendanceRecordDataGridView.DefaultCellStyle = dataGridViewCellStyle10;
            this.AttendanceRecordDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AttendanceRecordDataGridView.Location = new System.Drawing.Point(118, 198);
            this.AttendanceRecordDataGridView.Name = "AttendanceRecordDataGridView";
            this.AttendanceRecordDataGridView.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendanceRecordDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.AttendanceRecordDataGridView.RowHeadersVisible = false;
            this.AttendanceRecordDataGridView.RowHeadersWidth = 60;
            this.AttendanceRecordDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AttendanceRecordDataGridView.RowTemplate.Height = 45;
            this.AttendanceRecordDataGridView.ShowCellErrors = false;
            this.AttendanceRecordDataGridView.ShowEditingIcon = false;
            this.AttendanceRecordDataGridView.ShowRowErrors = false;
            this.AttendanceRecordDataGridView.Size = new System.Drawing.Size(1355, 600);
            this.AttendanceRecordDataGridView.TabIndex = 37;
            this.AttendanceRecordDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AttendanceRecordDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AttendanceRecordDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AttendanceRecordDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AttendanceRecordDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AttendanceRecordDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AttendanceRecordDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AttendanceRecordDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AttendanceRecordDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AttendanceRecordDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceRecordDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AttendanceRecordDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AttendanceRecordDataGridView.ThemeStyle.HeaderStyle.Height = 45;
            this.AttendanceRecordDataGridView.ThemeStyle.ReadOnly = true;
            this.AttendanceRecordDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AttendanceRecordDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AttendanceRecordDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceRecordDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AttendanceRecordDataGridView.ThemeStyle.RowsStyle.Height = 45;
            this.AttendanceRecordDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AttendanceRecordDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AttendanceRecordDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttendanceRecordDataGridView_CellContentClick);
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
            this.guna2PictureBox1.Image = global::Attendance_management_system.Properties.Resources.rec_10260887;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(39, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(38, 45);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 44;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(84, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Attendance Record";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.AttendanceRecordDataGridView;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.btnsearchrecord;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.btnprint;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.txtdate;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle12.NullValue")));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewImageColumn1.HeaderText = "ACTION";
            this.dataGridViewImageColumn1.Image = global::Attendance_management_system.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 146;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.GhostWhite;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // HeaderID
            // 
            this.HeaderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderID.DataPropertyName = "STUDENT ID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HeaderID.DefaultCellStyle = dataGridViewCellStyle3;
            this.HeaderID.HeaderText = "STUDENT ID";
            this.HeaderID.MinimumWidth = 6;
            this.HeaderID.Name = "HeaderID";
            this.HeaderID.ReadOnly = true;
            this.HeaderID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HeaderID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // HeaderName
            // 
            this.HeaderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderName.DataPropertyName = "NAME";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HeaderName.DefaultCellStyle = dataGridViewCellStyle4;
            this.HeaderName.HeaderText = "NAME";
            this.HeaderName.MinimumWidth = 6;
            this.HeaderName.Name = "HeaderName";
            this.HeaderName.ReadOnly = true;
            this.HeaderName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // HeaderBatch
            // 
            this.HeaderBatch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderBatch.DataPropertyName = "BATCH";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HeaderBatch.DefaultCellStyle = dataGridViewCellStyle5;
            this.HeaderBatch.HeaderText = "BATCH";
            this.HeaderBatch.MinimumWidth = 6;
            this.HeaderBatch.Name = "HeaderBatch";
            this.HeaderBatch.ReadOnly = true;
            this.HeaderBatch.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // HeaderFaculty
            // 
            this.HeaderFaculty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderFaculty.DataPropertyName = "FACULTY";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HeaderFaculty.DefaultCellStyle = dataGridViewCellStyle6;
            this.HeaderFaculty.HeaderText = "FACULTY";
            this.HeaderFaculty.MinimumWidth = 6;
            this.HeaderFaculty.Name = "HeaderFaculty";
            this.HeaderFaculty.ReadOnly = true;
            this.HeaderFaculty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // HeaderPresent
            // 
            this.HeaderPresent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderPresent.DataPropertyName = "PRESENT";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.ForestGreen;
            this.HeaderPresent.DefaultCellStyle = dataGridViewCellStyle7;
            this.HeaderPresent.HeaderText = "PRESENT";
            this.HeaderPresent.MinimumWidth = 6;
            this.HeaderPresent.Name = "HeaderPresent";
            this.HeaderPresent.ReadOnly = true;
            this.HeaderPresent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HeaderPresent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HeaderAbsent
            // 
            this.HeaderAbsent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderAbsent.DataPropertyName = "ABSENT";
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Red;
            this.HeaderAbsent.DefaultCellStyle = dataGridViewCellStyle8;
            this.HeaderAbsent.HeaderText = "ABSENT";
            this.HeaderAbsent.MinimumWidth = 6;
            this.HeaderAbsent.Name = "HeaderAbsent";
            this.HeaderAbsent.ReadOnly = true;
            this.HeaderAbsent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HeaderAbsent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HeaderDate
            // 
            this.HeaderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderDate.DataPropertyName = "DATE";
            this.HeaderDate.HeaderText = "DATE";
            this.HeaderDate.MinimumWidth = 6;
            this.HeaderDate.Name = "HeaderDate";
            this.HeaderDate.ReadOnly = true;
            // 
            // HeaderAction
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle9.NullValue")));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(10);
            this.HeaderAction.DefaultCellStyle = dataGridViewCellStyle9;
            this.HeaderAction.HeaderText = "ACTION";
            this.HeaderAction.Image = global::Attendance_management_system.Properties.Resources.edit__4_;
            this.HeaderAction.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.HeaderAction.MinimumWidth = 6;
            this.HeaderAction.Name = "HeaderAction";
            this.HeaderAction.ReadOnly = true;
            this.HeaderAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmAttendanceRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1597, 905);
            this.Controls.Add(this.attendancepanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAttendanceRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Record";
            this.Activated += new System.EventHandler(this.frmAttendanceRecord_Activated);
            this.Load += new System.EventHandler(this.frmAttendanceRecord_Load);
            this.attendancepanel.ResumeLayout(false);
            this.attendancepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnrefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceRecordDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel attendancepanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI2.WinForms.Guna2DataGridView AttendanceRecordDataGridView;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2ComboBox txtbatch;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtdate;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnprint;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnsearchrecord;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2PictureBox btnrefresh;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderPresent;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderAbsent;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderDate;
        private System.Windows.Forms.DataGridViewImageColumn HeaderAction;
    }
}