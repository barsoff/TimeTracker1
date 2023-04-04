namespace TimeTracker1
{
    partial class FormTimeTracker
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGoToFormAnalyze = new System.Windows.Forms.Button();
            this.buttonGoToAdminForm = new System.Windows.Forms.Button();
            this.buttonAutoHideMod = new System.Windows.Forms.Button();
            this.buttonAutoMod = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTime = new System.Windows.Forms.Label();
            this.textBoxNameForTimeline = new System.Windows.Forms.TextBox();
            this.buttonStartStopTimer = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonGoToFormAnalyze);
            this.panel2.Controls.Add(this.buttonGoToAdminForm);
            this.panel2.Controls.Add(this.buttonAutoHideMod);
            this.panel2.Controls.Add(this.buttonAutoMod);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 548);
            this.panel2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(6, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 53);
            this.button1.TabIndex = 12;
            this.button1.Text = "Автоматический режим\r\nСтоп";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGoToFormAnalyze
            // 
            this.buttonGoToFormAnalyze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoToFormAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoToFormAnalyze.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonGoToFormAnalyze.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGoToFormAnalyze.Location = new System.Drawing.Point(6, 210);
            this.buttonGoToFormAnalyze.Name = "buttonGoToFormAnalyze";
            this.buttonGoToFormAnalyze.Size = new System.Drawing.Size(171, 54);
            this.buttonGoToFormAnalyze.TabIndex = 10;
            this.buttonGoToFormAnalyze.Text = "Аналитика";
            this.buttonGoToFormAnalyze.UseVisualStyleBackColor = true;
            this.buttonGoToFormAnalyze.Click += new System.EventHandler(this.buttonGoToFormAnalyze_Click);
            // 
            // buttonGoToAdminForm
            // 
            this.buttonGoToAdminForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoToAdminForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoToAdminForm.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonGoToAdminForm.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGoToAdminForm.Location = new System.Drawing.Point(6, 279);
            this.buttonGoToAdminForm.Name = "buttonGoToAdminForm";
            this.buttonGoToAdminForm.Size = new System.Drawing.Size(171, 54);
            this.buttonGoToAdminForm.TabIndex = 9;
            this.buttonGoToAdminForm.Text = "Открыть окно администратора";
            this.buttonGoToAdminForm.UseVisualStyleBackColor = true;
            this.buttonGoToAdminForm.Click += new System.EventHandler(this.buttonGoToAdminForm_Click);
            // 
            // buttonAutoHideMod
            // 
            this.buttonAutoHideMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAutoHideMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAutoHideMod.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonAutoHideMod.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAutoHideMod.Location = new System.Drawing.Point(6, 140);
            this.buttonAutoHideMod.Name = "buttonAutoHideMod";
            this.buttonAutoHideMod.Size = new System.Drawing.Size(171, 54);
            this.buttonAutoHideMod.TabIndex = 8;
            this.buttonAutoHideMod.Text = "Автоматический режим (скрытный) \r\nСтарт";
            this.buttonAutoHideMod.UseVisualStyleBackColor = true;
            this.buttonAutoHideMod.Click += new System.EventHandler(this.buttonAutoHideMod_Click);
            // 
            // buttonAutoMod
            // 
            this.buttonAutoMod.BackColor = System.Drawing.Color.Transparent;
            this.buttonAutoMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAutoMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAutoMod.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonAutoMod.ForeColor = System.Drawing.Color.White;
            this.buttonAutoMod.Location = new System.Drawing.Point(6, 12);
            this.buttonAutoMod.Name = "buttonAutoMod";
            this.buttonAutoMod.Size = new System.Drawing.Size(171, 53);
            this.buttonAutoMod.TabIndex = 7;
            this.buttonAutoMod.Text = "Автоматический режим\r\nСтарт";
            this.buttonAutoMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAutoMod.UseVisualStyleBackColor = false;
            this.buttonAutoMod.Click += new System.EventHandler(this.buttonAutoMod_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.textBoxNameForTimeline);
            this.panel1.Controls.Add(this.buttonStartStopTimer);
            this.panel1.Location = new System.Drawing.Point(201, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 548);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dataGridView1.BackgroundImage = global::TimeTracker1.Properties.Resources.gr72_509_500__2_;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDate,
            this.ColumnName,
            this.ColumnStartTime,
            this.ColumnEndTime,
            this.ColumnDur});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(749, 490);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Дата";
            this.ColumnDate.MinimumWidth = 6;
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            this.ColumnDate.Width = 125;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Наименование";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 220;
            // 
            // ColumnStartTime
            // 
            this.ColumnStartTime.HeaderText = "Начало";
            this.ColumnStartTime.MinimumWidth = 6;
            this.ColumnStartTime.Name = "ColumnStartTime";
            this.ColumnStartTime.ReadOnly = true;
            this.ColumnStartTime.Width = 125;
            // 
            // ColumnEndTime
            // 
            this.ColumnEndTime.HeaderText = "Конец";
            this.ColumnEndTime.MinimumWidth = 6;
            this.ColumnEndTime.Name = "ColumnEndTime";
            this.ColumnEndTime.ReadOnly = true;
            this.ColumnEndTime.Width = 125;
            // 
            // ColumnDur
            // 
            this.ColumnDur.HeaderText = "Продолжительность";
            this.ColumnDur.MinimumWidth = 6;
            this.ColumnDur.Name = "ColumnDur";
            this.ColumnDur.ReadOnly = true;
            this.ColumnDur.Width = 170;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.labelTime.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTime.Location = new System.Drawing.Point(20, 16);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(119, 33);
            this.labelTime.TabIndex = 21;
            this.labelTime.Text = "00:00:00";
            // 
            // textBoxNameForTimeline
            // 
            this.textBoxNameForTimeline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNameForTimeline.Font = new System.Drawing.Font("Roboto", 10F);
            this.textBoxNameForTimeline.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxNameForTimeline.Location = new System.Drawing.Point(145, 12);
            this.textBoxNameForTimeline.Multiline = true;
            this.textBoxNameForTimeline.Name = "textBoxNameForTimeline";
            this.textBoxNameForTimeline.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNameForTimeline.Size = new System.Drawing.Size(532, 34);
            this.textBoxNameForTimeline.TabIndex = 20;
            // 
            // buttonStartStopTimer
            // 
            this.buttonStartStopTimer.BackColor = System.Drawing.Color.LightGreen;
            this.buttonStartStopTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartStopTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartStopTimer.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonStartStopTimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStartStopTimer.Location = new System.Drawing.Point(683, 12);
            this.buttonStartStopTimer.Name = "buttonStartStopTimer";
            this.buttonStartStopTimer.Size = new System.Drawing.Size(66, 34);
            this.buttonStartStopTimer.TabIndex = 10;
            this.buttonStartStopTimer.Text = "Старт";
            this.buttonStartStopTimer.UseVisualStyleBackColor = false;
            this.buttonStartStopTimer.Click += new System.EventHandler(this.buttonStartStopTimer_Click);
            // 
            // FormTimeTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(972, 572);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormTimeTracker";
            this.Text = "Учет времени";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTimeTracker_FormClosed);
            this.Load += new System.EventHandler(this.FormTimeTracker_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAutoHideMod;
        private System.Windows.Forms.Button buttonAutoMod;
        private System.Windows.Forms.Button buttonGoToAdminForm;
        private System.Windows.Forms.Button buttonStartStopTimer;
        private System.Windows.Forms.TextBox textBoxNameForTimeline;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonGoToFormAnalyze;
    }
}
