namespace Attendance_management_system
{
    partial class frmStudentAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.AttendanceRecordDataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.HeaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderPresent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderAbsent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.AttPercent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.StudentPanel = new System.Windows.Forms.Panel();
            this.StudentName = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AttendancePercentBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceRecordDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.StudentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.AttendanceRecordDataGridView1;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
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
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(58)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(58)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AttendanceRecordDataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            this.AttendanceRecordDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AttendanceRecordDataGridView1.Location = new System.Drawing.Point(151, 246);
            this.AttendanceRecordDataGridView1.Name = "AttendanceRecordDataGridView1";
            this.AttendanceRecordDataGridView1.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
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
            this.AttendanceRecordDataGridView1.Size = new System.Drawing.Size(1319, 620);
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
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(135, 217);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1335, 26);
            this.guna2Separator1.TabIndex = 68;
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
            // 
            // AttPercent
            // 
            this.AttPercent.AutoSize = true;
            this.AttPercent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.AttPercent.Location = new System.Drawing.Point(1293, 174);
            this.AttPercent.Name = "AttPercent";
            this.AttPercent.Size = new System.Drawing.Size(40, 28);
            this.AttPercent.TabIndex = 75;
            this.AttPercent.Text = "0%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 71;
            this.label1.Text = "Attendance : ";
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
            // 
            // StudentPanel
            // 
            this.StudentPanel.Controls.Add(this.StudentName);
            this.StudentPanel.Controls.Add(this.StudentID);
            this.StudentPanel.Controls.Add(this.label4);
            this.StudentPanel.Controls.Add(this.label3);
            this.StudentPanel.Controls.Add(this.AttPercent);
            this.StudentPanel.Controls.Add(this.AttendancePercentBar);
            this.StudentPanel.Controls.Add(this.label1);
            this.StudentPanel.Controls.Add(this.panel3);
            this.StudentPanel.Controls.Add(this.guna2Separator1);
            this.StudentPanel.Controls.Add(this.AttendanceRecordDataGridView1);
            this.StudentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentPanel.Location = new System.Drawing.Point(0, 0);
            this.StudentPanel.Name = "StudentPanel";
            this.StudentPanel.Size = new System.Drawing.Size(1597, 972);
            this.StudentPanel.TabIndex = 4;
            this.StudentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.StudentPanel_Paint);
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.StudentName.Location = new System.Drawing.Point(388, 128);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(20, 25);
            this.StudentName.TabIndex = 77;
            this.StudentName.Text = "?";
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.StudentID.Location = new System.Drawing.Point(388, 77);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(20, 25);
            this.StudentID.TabIndex = 77;
            this.StudentID.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 28);
            this.label4.TabIndex = 76;
            this.label4.Text = "Student Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 28);
            this.label3.TabIndex = 76;
            this.label3.Text = "Student ID: ";
            // 
            // AttendancePercentBar
            // 
            this.AttendancePercentBar.Location = new System.Drawing.Point(392, 180);
            this.AttendancePercentBar.Name = "AttendancePercentBar";
            this.AttendancePercentBar.Size = new System.Drawing.Size(881, 20);
            this.AttendancePercentBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.AttendancePercentBar.TabIndex = 74;
            // 
            // frmStudentAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 972);
            this.Controls.Add(this.StudentPanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStudentAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStudentAttendance";
            this.Load += new System.EventHandler(this.frmStudentAttendance_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceRecordDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.StudentPanel.ResumeLayout(false);
            this.StudentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2DataGridView AttendanceRecordDataGridView1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label AttPercent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private System.Windows.Forms.Panel StudentPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderPresent;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderAbsent;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderDate;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.Label StudentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar AttendancePercentBar;
    }
}