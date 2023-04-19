namespace TimeTracker1
{
    partial class FormAnalyze
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonCreateReport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMiddlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxDateEnd = new System.Windows.Forms.TextBox();
            this.textBoxDateStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateReport.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateReport.ForeColor = System.Drawing.Color.White;
            this.buttonCreateReport.Location = new System.Drawing.Point(379, 430);
            this.buttonCreateReport.Name = "buttonCreateReport";
            this.buttonCreateReport.Size = new System.Drawing.Size(195, 35);
            this.buttonCreateReport.TabIndex = 7;
            this.buttonCreateReport.Text = "Сформировать отчет";
            this.buttonCreateReport.UseVisualStyleBackColor = true;
            this.buttonCreateReport.Click += new System.EventHandler(this.buttonCreateReport_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnLogin,
            this.ColumnLastname,
            this.ColumnFirstname,
            this.ColumnMiddlename,
            this.ColumnPhone,
            this.ColumnEmail});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(951, 424);
            this.dataGridView1.TabIndex = 26;
            // 
            // ColumnLogin
            // 
            this.ColumnLogin.HeaderText = "Id";
            this.ColumnLogin.MinimumWidth = 6;
            this.ColumnLogin.Name = "ColumnLogin";
            this.ColumnLogin.ReadOnly = true;
            this.ColumnLogin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnLogin.Width = 80;
            // 
            // ColumnLastname
            // 
            this.ColumnLastname.HeaderText = "Фамилия";
            this.ColumnLastname.MinimumWidth = 6;
            this.ColumnLastname.Name = "ColumnLastname";
            this.ColumnLastname.ReadOnly = true;
            this.ColumnLastname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnLastname.Width = 185;
            // 
            // ColumnFirstname
            // 
            this.ColumnFirstname.HeaderText = "Имя";
            this.ColumnFirstname.MinimumWidth = 6;
            this.ColumnFirstname.Name = "ColumnFirstname";
            this.ColumnFirstname.ReadOnly = true;
            this.ColumnFirstname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnFirstname.Width = 170;
            // 
            // ColumnMiddlename
            // 
            this.ColumnMiddlename.HeaderText = "Отчество";
            this.ColumnMiddlename.MinimumWidth = 6;
            this.ColumnMiddlename.Name = "ColumnMiddlename";
            this.ColumnMiddlename.ReadOnly = true;
            this.ColumnMiddlename.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnMiddlename.Width = 175;
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.HeaderText = "Телефон";
            this.ColumnPhone.MinimumWidth = 6;
            this.ColumnPhone.Name = "ColumnPhone";
            this.ColumnPhone.ReadOnly = true;
            this.ColumnPhone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnPhone.Width = 140;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Эл. почта";
            this.ColumnEmail.MinimumWidth = 6;
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            this.ColumnEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnEmail.Width = 200;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.buttonCreateReport);
            this.panel1.Location = new System.Drawing.Point(9, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 468);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.textBoxDateEnd);
            this.panel2.Controls.Add(this.textBoxDateStart);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonClearFilter);
            this.panel2.Location = new System.Drawing.Point(9, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 81);
            this.panel2.TabIndex = 28;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 11F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Вариант отчета:";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.Font = new System.Drawing.Font("Roboto", 11F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Пользователь - Приложение",
            "Пользователь - День"});
            this.comboBox1.Location = new System.Drawing.Point(143, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 30);
            this.comboBox1.TabIndex = 50;
            // 
            // textBoxDateEnd
            // 
            this.textBoxDateEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDateEnd.Font = new System.Drawing.Font("Roboto", 11F);
            this.textBoxDateEnd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDateEnd.Location = new System.Drawing.Point(594, 36);
            this.textBoxDateEnd.Multiline = true;
            this.textBoxDateEnd.Name = "textBoxDateEnd";
            this.textBoxDateEnd.Size = new System.Drawing.Size(98, 28);
            this.textBoxDateEnd.TabIndex = 32;
            // 
            // textBoxDateStart
            // 
            this.textBoxDateStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDateStart.Font = new System.Drawing.Font("Roboto", 11F);
            this.textBoxDateStart.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDateStart.Location = new System.Drawing.Point(432, 36);
            this.textBoxDateStart.Multiline = true;
            this.textBoxDateStart.Name = "textBoxDateStart";
            this.textBoxDateStart.Size = new System.Drawing.Size(98, 28);
            this.textBoxDateStart.TabIndex = 31;
            this.textBoxDateStart.TextChanged += new System.EventHandler(this.textBoxDateStart_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(561, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "ПО:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(411, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "С:";
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFilter.Font = new System.Drawing.Font("Roboto", 11F);
            this.buttonClearFilter.ForeColor = System.Drawing.Color.White;
            this.buttonClearFilter.Location = new System.Drawing.Point(740, 31);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(194, 34);
            this.buttonClearFilter.TabIndex = 27;
            this.buttonClearFilter.Text = "Сбросить фильтры";
            this.buttonClearFilter.UseVisualStyleBackColor = true;
            this.buttonClearFilter.Click += new System.EventHandler(this.buttonClearFilter_Click);
            // 
            // FormAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(972, 572);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAnalyze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аналитика";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAnalyze_FormClosed);
            this.Load += new System.EventHandler(this.FormAnalyze_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateReport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonClearFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDateEnd;
        private System.Windows.Forms.TextBox textBoxDateStart;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMiddlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
    }
}