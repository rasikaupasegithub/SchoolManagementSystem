
namespace SchoolManagementSystem
{
    partial class AddTTeachersForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.teacher_status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.teacher_deleteBtn = new System.Windows.Forms.Button();
            this.teacher_clearBtn = new System.Windows.Forms.Button();
            this.teacher_updateBtn = new System.Windows.Forms.Button();
            this.teacher_addBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.teacher_Image = new System.Windows.Forms.PictureBox();
            this.teacher_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teacher_gender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teacher_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teacher_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teacher_gridData = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_Image)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.teacher_status);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.teacher_deleteBtn);
            this.panel2.Controls.Add(this.teacher_clearBtn);
            this.panel2.Controls.Add(this.teacher_updateBtn);
            this.panel2.Controls.Add(this.teacher_addBtn);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.teacher_address);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.teacher_gender);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.teacher_name);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.teacher_id);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(30, 443);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1359, 285);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // teacher_status
            // 
            this.teacher_status.FormattingEnabled = true;
            this.teacher_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.teacher_status.Location = new System.Drawing.Point(812, 42);
            this.teacher_status.Name = "teacher_status";
            this.teacher_status.Size = new System.Drawing.Size(177, 24);
            this.teacher_status.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(738, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Status :";
            // 
            // teacher_deleteBtn
            // 
            this.teacher_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teacher_deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_deleteBtn.Location = new System.Drawing.Point(840, 227);
            this.teacher_deleteBtn.Name = "teacher_deleteBtn";
            this.teacher_deleteBtn.Size = new System.Drawing.Size(144, 44);
            this.teacher_deleteBtn.TabIndex = 17;
            this.teacher_deleteBtn.Text = "DELETE";
            this.teacher_deleteBtn.UseVisualStyleBackColor = true;
            this.teacher_deleteBtn.Click += new System.EventHandler(this.teacher_deleteBtn_Click);
            // 
            // teacher_clearBtn
            // 
            this.teacher_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teacher_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_clearBtn.Location = new System.Drawing.Point(650, 227);
            this.teacher_clearBtn.Name = "teacher_clearBtn";
            this.teacher_clearBtn.Size = new System.Drawing.Size(144, 44);
            this.teacher_clearBtn.TabIndex = 16;
            this.teacher_clearBtn.Text = "CLEAR";
            this.teacher_clearBtn.UseVisualStyleBackColor = true;
            this.teacher_clearBtn.Click += new System.EventHandler(this.teacher_clearBtn_Click);
            // 
            // teacher_updateBtn
            // 
            this.teacher_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teacher_updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_updateBtn.Location = new System.Drawing.Point(438, 227);
            this.teacher_updateBtn.Name = "teacher_updateBtn";
            this.teacher_updateBtn.Size = new System.Drawing.Size(144, 44);
            this.teacher_updateBtn.TabIndex = 15;
            this.teacher_updateBtn.Text = "UPDATE";
            this.teacher_updateBtn.UseVisualStyleBackColor = true;
            this.teacher_updateBtn.Click += new System.EventHandler(this.teacher_updateBtn_Click);
            // 
            // teacher_addBtn
            // 
            this.teacher_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teacher_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_addBtn.Location = new System.Drawing.Point(209, 227);
            this.teacher_addBtn.Name = "teacher_addBtn";
            this.teacher_addBtn.Size = new System.Drawing.Size(144, 44);
            this.teacher_addBtn.TabIndex = 14;
            this.teacher_addBtn.Text = "ADD";
            this.teacher_addBtn.UseVisualStyleBackColor = true;
            this.teacher_addBtn.Click += new System.EventHandler(this.teacher_addBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1015, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.teacher_Image);
            this.panel3.Location = new System.Drawing.Point(1015, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 157);
            this.panel3.TabIndex = 12;
            // 
            // teacher_Image
            // 
            this.teacher_Image.Location = new System.Drawing.Point(3, 0);
            this.teacher_Image.Name = "teacher_Image";
            this.teacher_Image.Size = new System.Drawing.Size(155, 154);
            this.teacher_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teacher_Image.TabIndex = 20;
            this.teacher_Image.TabStop = false;
            this.teacher_Image.Click += new System.EventHandler(this.teacher_Image_Click);
            // 
            // teacher_address
            // 
            this.teacher_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_address.Location = new System.Drawing.Point(453, 41);
            this.teacher_address.Multiline = true;
            this.teacher_address.Name = "teacher_address";
            this.teacher_address.Size = new System.Drawing.Size(256, 110);
            this.teacher_address.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address :";
            // 
            // teacher_gender
            // 
            this.teacher_gender.FormattingEnabled = true;
            this.teacher_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.teacher_gender.Location = new System.Drawing.Point(133, 166);
            this.teacher_gender.Name = "teacher_gender";
            this.teacher_gender.Size = new System.Drawing.Size(195, 24);
            this.teacher_gender.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender :";
            // 
            // teacher_name
            // 
            this.teacher_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_name.Location = new System.Drawing.Point(133, 101);
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.Size = new System.Drawing.Size(195, 27);
            this.teacher_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name :";
            // 
            // teacher_id
            // 
            this.teacher_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_id.Location = new System.Drawing.Point(133, 39);
            this.teacher_id.Name = "teacher_id";
            this.teacher_id.Size = new System.Drawing.Size(195, 27);
            this.teacher_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher ID :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.teacher_gridData);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(30, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1359, 400);
            this.panel1.TabIndex = 2;
            // 
            // teacher_gridData
            // 
            this.teacher_gridData.AllowUserToAddRows = false;
            this.teacher_gridData.AllowUserToDeleteRows = false;
            this.teacher_gridData.AllowUserToResizeRows = false;
            this.teacher_gridData.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teacher_gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.teacher_gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacher_gridData.EnableHeadersVisualStyles = false;
            this.teacher_gridData.Location = new System.Drawing.Point(20, 71);
            this.teacher_gridData.Name = "teacher_gridData";
            this.teacher_gridData.ReadOnly = true;
            this.teacher_gridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.teacher_gridData.RowHeadersVisible = false;
            this.teacher_gridData.RowHeadersWidth = 51;
            this.teacher_gridData.RowTemplate.Height = 24;
            this.teacher_gridData.Size = new System.Drawing.Size(1224, 310);
            this.teacher_gridData.TabIndex = 5;
            this.teacher_gridData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacher_gridData_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Teachers Data";
            // 
            // AddTTeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddTTeachersForm";
            this.Size = new System.Drawing.Size(1842, 745);
            this.Load += new System.EventHandler(this.AddTTeachersForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teacher_Image)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_gridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button teacher_deleteBtn;
        private System.Windows.Forms.Button teacher_clearBtn;
        private System.Windows.Forms.Button teacher_updateBtn;
        private System.Windows.Forms.Button teacher_addBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox teacher_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox teacher_gender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teacher_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teacher_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView teacher_gridData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox teacher_status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox teacher_Image;
    }
}
