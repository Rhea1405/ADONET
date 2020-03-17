namespace ADONET
{
    partial class insert
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
            this.txtempno = new System.Windows.Forms.Label();
            this.txtename = new System.Windows.Forms.Label();
            this.rdgender = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.cbbgender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtempno
            // 
            this.txtempno.AutoSize = true;
            this.txtempno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempno.Location = new System.Drawing.Point(138, 49);
            this.txtempno.Name = "txtempno";
            this.txtempno.Size = new System.Drawing.Size(58, 20);
            this.txtempno.TabIndex = 0;
            this.txtempno.Text = "empno";
            // 
            // txtename
            // 
            this.txtename.AutoSize = true;
            this.txtename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtename.Location = new System.Drawing.Point(138, 104);
            this.txtename.Name = "txtename";
            this.txtename.Size = new System.Drawing.Size(58, 20);
            this.txtename.TabIndex = 1;
            this.txtename.Text = "ename";
            // 
            // rdgender
            // 
            this.rdgender.AutoSize = true;
            this.rdgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgender.Location = new System.Drawing.Point(138, 158);
            this.rdgender.Name = "rdgender";
            this.rdgender.Size = new System.Drawing.Size(59, 20);
            this.rdgender.TabIndex = 2;
            this.rdgender.Text = "gender";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(138, 235);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(36, 20);
            this.dob.TabIndex = 3;
            this.dob.Text = "dob";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(403, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(403, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 26);
            this.textBox2.TabIndex = 5;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(403, 228);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(209, 26);
            this.date.TabIndex = 8;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsubmit.Location = new System.Drawing.Point(330, 293);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(130, 48);
            this.btnsubmit.TabIndex = 9;
            this.btnsubmit.Text = "submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // cbbgender
            // 
            this.cbbgender.FormattingEnabled = true;
            this.cbbgender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.cbbgender.Location = new System.Drawing.Point(403, 158);
            this.cbbgender.Name = "cbbgender";
            this.cbbgender.Size = new System.Drawing.Size(185, 21);
            this.cbbgender.TabIndex = 10;
            // 
            // insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbgender);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.date);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.rdgender);
            this.Controls.Add(this.txtename);
            this.Controls.Add(this.txtempno);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "insert";
            this.Text = "insert";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtempno;
        private System.Windows.Forms.Label txtename;
        private System.Windows.Forms.Label rdgender;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.ComboBox cbbgender;
    }
}

