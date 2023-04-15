namespace TimeTracker1
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMiddlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteBlock = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.buttonDeleteBlock);
            this.panel1.Controls.Add(this.buttonChange);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 574);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnLogin,
            this.ColumnLastname,
            this.ColumnFirstname,
            this.ColumnMiddlename,
            this.ColumnPhone,
            this.ColumnEmail,
            this.Disabled});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(948, 507);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnLogin
            // 
            this.ColumnLogin.HeaderText = "Id";
            this.ColumnLogin.MinimumWidth = 6;
            this.ColumnLogin.Name = "ColumnLogin";
            this.ColumnLogin.ReadOnly = true;
            this.ColumnLogin.Width = 70;
            // 
            // ColumnLastname
            // 
            this.ColumnLastname.HeaderText = "Фамилия";
            this.ColumnLastname.MinimumWidth = 6;
            this.ColumnLastname.Name = "ColumnLastname";
            this.ColumnLastname.ReadOnly = true;
            this.ColumnLastname.Width = 180;
            // 
            // ColumnFirstname
            // 
            this.ColumnFirstname.HeaderText = "Имя";
            this.ColumnFirstname.MinimumWidth = 6;
            this.ColumnFirstname.Name = "ColumnFirstname";
            this.ColumnFirstname.ReadOnly = true;
            this.ColumnFirstname.Width = 145;
            // 
            // ColumnMiddlename
            // 
            this.ColumnMiddlename.HeaderText = "Отчество";
            this.ColumnMiddlename.MinimumWidth = 6;
            this.ColumnMiddlename.Name = "ColumnMiddlename";
            this.ColumnMiddlename.ReadOnly = true;
            this.ColumnMiddlename.Width = 160;
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.HeaderText = "Телефон";
            this.ColumnPhone.MinimumWidth = 6;
            this.ColumnPhone.Name = "ColumnPhone";
            this.ColumnPhone.ReadOnly = true;
            this.ColumnPhone.Width = 135;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Эл. почта";
            this.ColumnEmail.MinimumWidth = 6;
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            this.ColumnEmail.Width = 170;
            // 
            // Disabled
            // 
            this.Disabled.HeaderText = "Активен";
            this.Disabled.MinimumWidth = 6;
            this.Disabled.Name = "Disabled";
            this.Disabled.ReadOnly = true;
            this.Disabled.Width = 90;
            // 
            // buttonDeleteBlock
            // 
            this.buttonDeleteBlock.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteBlock.Enabled = false;
            this.buttonDeleteBlock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteBlock.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteBlock.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteBlock.Location = new System.Drawing.Point(393, 526);
            this.buttonDeleteBlock.Name = "buttonDeleteBlock";
            this.buttonDeleteBlock.Size = new System.Drawing.Size(195, 35);
            this.buttonDeleteBlock.TabIndex = 24;
            this.buttonDeleteBlock.Text = "Заблокировать";
            this.buttonDeleteBlock.UseVisualStyleBackColor = false;
            this.buttonDeleteBlock.Click += new System.EventHandler(this.buttonDeleteBlock_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(82, 110);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 26;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(972, 572);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администрирование";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
            private System.Windows.Forms.Panel panel1;
            private System.Windows.Forms.Button buttonDeleteBlock;
            private System.Windows.Forms.Button buttonChange;
            private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMiddlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disabled;
    }
   
}