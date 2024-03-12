namespace Attendance_management_system
{
    partial class frmstudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmstudent));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.StudentPanel = new System.Windows.Forms.Panel();
            this.btnprint = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.AttendanceRecordDataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.HeaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderPresent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderAbsent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtstudentid = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnenter = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.AttPercent = new System.Windows.Forms.Label();
            this.AttendancePercentBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceRecordDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentPanel
            // 
            this.StudentPanel.Controls.Add(this.AttPercent);
            this.StudentPanel.Controls.Add(this.AttendancePercentBar);
            this.StudentPanel.Controls.Add(this.label4);
            this.StudentPanel.Controls.Add(this.btnprint);
            this.StudentPanel.Controls.Add(this.panel3);
            this.StudentPanel.Controls.Add(this.guna2Separator1);
            this.StudentPanel.Controls.Add(this.AttendanceRecordDataGridView1);
            this.StudentPanel.Controls.Add(this.label7);
            this.StudentPanel.Controls.Add(this.txtstudentid);
            this.StudentPanel.Controls.Add(this.btnenter);
            this.StudentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentPanel.Location = new System.Drawing.Point(0, 0);
            this.StudentPanel.Name = "StudentPanel";
            this.StudentPanel.Size = new System.Drawing.Size(1597, 972);
            this.StudentPanel.TabIndex = 3;
            this.StudentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.StudentPanel_Paint);
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
            this.btnprint.Location = new System.Drawing.Point(703, 848);
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
            this.btnprint.TabIndex = 70;
            this.btnprint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnprint.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnprint.TextMarginLeft = 0;
            this.btnprint.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnprint.UseDefaultRadiusAndThickness = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.guna2PictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1597, 53);
            this.panel3.TabIndex = 69;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(89, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Students Data";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Attendance_management_system.Properties.Resources.student__1_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(36, 5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(56, 41);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 36;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(135, 209);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1335, 10);
            this.guna2Separator1.TabIndex = 68;
            this.guna2Separator1.Click += new System.EventHandler(this.guna2Separator1_Click);
            // 
            // AttendanceRecordDataGridView1
            // 
            this.AttendanceRecordDataGridView1.AllowUserToAddRows = false;
            this.AttendanceRecordDataGridView1.AllowUserToDeleteRows = false;
            this.AttendanceRecordDataGridView1.AllowUserToResizeColumns = false;
            this.AttendanceRecordDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AttendanceRecordDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(115)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendanceRecordDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AttendanceRecordDataGridView1.ColumnHeadersHeight = 45;
            this.AttendanceRecordDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HeaderID,
            this.HeaderName,
            this.HeaderFaculty,
            this.HeaderBatch,
            this.HeaderPresent,
            this.HeaderAbsent,
            this.HeaderDate});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(58)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(58)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AttendanceRecordDataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            this.AttendanceRecordDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AttendanceRecordDataGridView1.Location = new System.Drawing.Point(147, 229);
            this.AttendanceRecordDataGridView1.Name = "AttendanceRecordDataGridView1";
            this.AttendanceRecordDataGridView1.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendanceRecordDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.AttendanceRecordDataGridView1.RowHeadersVisible = false;
            this.AttendanceRecordDataGridView1.RowHeadersWidth = 60;
            this.AttendanceRecordDataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AttendanceRecordDataGridView1.RowTemplate.Height = 45;
            this.AttendanceRecordDataGridView1.ShowCellErrors = false;
            this.AttendanceRecordDataGridView1.ShowEditingIcon = false;
            this.AttendanceRecordDataGridView1.ShowRowErrors = false;
            this.AttendanceRecordDataGridView1.Size = new System.Drawing.Size(1319, 598);
            this.AttendanceRecordDataGridView1.TabIndex = 67;
            this.AttendanceRecordDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AttendanceRecordDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AttendanceRecordDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AttendanceRecordDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AttendanceRecordDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AttendanceRecordDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AttendanceRecordDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AttendanceRecordDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AttendanceRecordDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AttendanceRecordDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceRecordDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AttendanceRecordDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AttendanceRecordDataGridView1.ThemeStyle.HeaderStyle.Height = 45;
            this.AttendanceRecordDataGridView1.ThemeStyle.ReadOnly = true;
            this.AttendanceRecordDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AttendanceRecordDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AttendanceRecordDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceRecordDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AttendanceRecordDataGridView1.ThemeStyle.RowsStyle.Height = 45;
            this.AttendanceRecordDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AttendanceRecordDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AttendanceRecordDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttendanceRecordDataGridView1_CellContentClick);
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
            // HeaderFaculty
            // 
            this.HeaderFaculty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderFaculty.DataPropertyName = "FACULTY";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HeaderFaculty.DefaultCellStyle = dataGridViewCellStyle5;
            this.HeaderFaculty.HeaderText = "FACULTY";
            this.HeaderFaculty.MinimumWidth = 6;
            this.HeaderFaculty.Name = "HeaderFaculty";
            this.HeaderFaculty.ReadOnly = true;
            this.HeaderFaculty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // HeaderBatch
            // 
            this.HeaderBatch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderBatch.DataPropertyName = "BATCH";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HeaderBatch.DefaultCellStyle = dataGridViewCellStyle6;
            this.HeaderBatch.HeaderText = "BATCH";
            this.HeaderBatch.MinimumWidth = 6;
            this.HeaderBatch.Name = "HeaderBatch";
            this.HeaderBatch.ReadOnly = true;
            this.HeaderBatch.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // HeaderPresent
            // 
            this.HeaderPresent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderPresent.DataPropertyName = "PRESENT";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.ForestGreen;
            this.HeaderPresent.DefaultCellStyle = dataGridViewCellStyle7;
            this.HeaderPresent.HeaderText = "PRESENT";
            this.HeaderPresent.MinimumWidth = 6;
            this.HeaderPresent.Name = "HeaderPresent";
            this.HeaderPresent.ReadOnly = true;
            this.HeaderPresent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // HeaderAbsent
            // 
            this.HeaderAbsent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeaderAbsent.DataPropertyName = "ABSENT";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HeaderDate.DefaultCellStyle = dataGridViewCellStyle9;
            this.HeaderDate.HeaderText = "DATE";
            this.HeaderDate.MinimumWidth = 6;
            this.HeaderDate.Name = "HeaderDate";
            this.HeaderDate.ReadOnly = true;
            this.HeaderDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(528, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 66;
            this.label7.Text = "Student ID: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtstudentid
            // 
            this.txtstudentid.AcceptsReturn = false;
            this.txtstudentid.AcceptsTab = false;
            this.txtstudentid.AnimationSpeed = 200;
            this.txtstudentid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtstudentid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtstudentid.BackColor = System.Drawing.Color.Transparent;
            this.txtstudentid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtstudentid.BackgroundImage")));
            this.txtstudentid.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtstudentid.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtstudentid.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtstudentid.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtstudentid.BorderRadius = 1;
            this.txtstudentid.BorderThickness = 1;
            this.txtstudentid.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtstudentid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstudentid.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentid.DefaultText = "";
            this.txtstudentid.FillColor = System.Drawing.Color.GhostWhite;
            this.txtstudentid.HideSelection = true;
            this.txtstudentid.IconLeft = null;
            this.txtstudentid.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstudentid.IconPadding = 10;
            this.txtstudentid.IconRight = null;
            this.txtstudentid.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstudentid.Lines = new string[0];
            this.txtstudentid.Location = new System.Drawing.Point(644, 83);
            this.txtstudentid.MaxLength = 32767;
            this.txtstudentid.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtstudentid.Modified = false;
            this.txtstudentid.Multiline = false;
            this.txtstudentid.Name = "txtstudentid";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtstudentid.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtstudentid.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtstudentid.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.GhostWhite;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtstudentid.OnIdleState = stateProperties4;
            this.txtstudentid.Padding = new System.Windows.Forms.Padding(3);
            this.txtstudentid.PasswordChar = '\0';
            this.txtstudentid.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtstudentid.PlaceholderText = "";
            this.txtstudentid.ReadOnly = false;
            this.txtstudentid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtstudentid.SelectedText = "";
            this.txtstudentid.SelectionLength = 0;
            this.txtstudentid.SelectionStart = 0;
            this.txtstudentid.ShortcutsEnabled = true;
            this.txtstudentid.Size = new System.Drawing.Size(262, 43);
            this.txtstudentid.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtstudentid.TabIndex = 65;
            this.txtstudentid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtstudentid.TextMarginBottom = 0;
            this.txtstudentid.TextMarginLeft = 3;
            this.txtstudentid.TextMarginTop = 0;
            this.txtstudentid.TextPlaceholder = "";
            this.txtstudentid.UseSystemPasswordChar = false;
            this.txtstudentid.WordWrap = true;
            this.txtstudentid.TextChanged += new System.EventHandler(this.txtstudentid_TextChanged);
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
            this.btnenter.ButtonText = "Find Record";
            this.btnenter.ButtonTextMarginLeft = 0;
            this.btnenter.ColorContrastOnClick = 45;
            this.btnenter.ColorContrastOnHover = 45;
            this.btnenter.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnenter.CustomizableEdges = borderEdges2;
            this.btnenter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnenter.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnenter.DisabledFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnenter.DisabledForecolor = System.Drawing.Color.White;
            this.btnenter.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnenter.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenter.ForeColor = System.Drawing.Color.White;
            this.btnenter.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnenter.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnenter.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnenter.IconMarginLeft = 11;
            this.btnenter.IconPadding = 10;
            this.btnenter.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnenter.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnenter.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnenter.IconSize = 25;
            this.btnenter.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnenter.IdleBorderRadius = 1;
            this.btnenter.IdleBorderThickness = 1;
            this.btnenter.IdleFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnenter.IdleIconLeftImage = null;
            this.btnenter.IdleIconRightImage = null;
            this.btnenter.IndicateFocus = false;
            this.btnenter.Location = new System.Drawing.Point(940, 83);
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
            this.btnenter.Size = new System.Drawing.Size(142, 43);
            this.btnenter.TabIndex = 62;
            this.btnenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnenter.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnenter.TextMarginLeft = 0;
            this.btnenter.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnenter.UseDefaultRadiusAndThickness = true;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click_4);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.btnenter;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.AttendanceRecordDataGridView1;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.btnprint;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            // 
            // AttPercent
            // 
            this.AttPercent.AutoSize = true;
            this.AttPercent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.AttPercent.Location = new System.Drawing.Point(1316, 159);
            this.AttPercent.Name = "AttPercent";
            this.AttPercent.Size = new System.Drawing.Size(40, 28);
            this.AttPercent.TabIndex = 78;
            this.AttPercent.Text = "0%";
            // 
            // AttendancePercentBar
            // 
            this.AttendancePercentBar.Location = new System.Drawing.Point(415, 165);
            this.AttendancePercentBar.Name = "AttendancePercentBar";
            this.AttendancePercentBar.Size = new System.Drawing.Size(881, 20);
            this.AttendancePercentBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.AttendancePercentBar.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 28);
            this.label4.TabIndex = 76;
            this.label4.Text = "Attendance : ";
            // 
            // frmstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1597, 972);
            this.Controls.Add(this.StudentPanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmstudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmstudent";
            this.StudentPanel.ResumeLayout(false);
            this.StudentPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceRecordDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel StudentPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2DataGridView AttendanceRecordDataGridView1;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuTextBox txtstudentid;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnenter;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnprint;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderPresent;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderAbsent;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderDate;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label AttPercent;
        private System.Windows.Forms.ProgressBar AttendancePercentBar;
        private System.Windows.Forms.Label label4;
    }
}