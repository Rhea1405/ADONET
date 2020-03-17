namespace ADONET
{
    partial class updatebtn
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
            this.cbbgender = new System.Windows.Forms.ComboBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.Label();
            this.rdgender = new System.Windows.Forms.Label();
            this.txtename = new System.Windows.Forms.Label();
            this.txtempno = new System.Windows.Forms.Label();
            this.extractbtn = new System.Windows.Forms.Button();
            this.txtdeptno = new System.Windows.Forms.Label();
            this.textdeptnum = new System.Windows.Forms.TextBox();
            this.btndel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbgender
            // 
            this.cbbgender.Enabled = false;
            this.cbbgender.FormattingEnabled = true;
            this.cbbgender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.cbbgender.Location = new System.Drawing.Point(428, 192);
            this.cbbgender.Name = "cbbgender";
            this.cbbgender.Size = new System.Drawing.Size(185, 21);
            this.cbbgender.TabIndex = 19;
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnupdate.Location = new System.Drawing.Point(157, 373);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(130, 48);
            this.btnupdate.TabIndex = 18;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(428, 262);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(209, 26);
            this.date.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(428, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 26);
            this.textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(428, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 26);
            this.textBox1.TabIndex = 15;
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(163, 269);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(36, 20);
            this.dob.TabIndex = 14;
            this.dob.Text = "dob";
            // 
            // rdgender
            // 
            this.rdgender.AutoSize = true;
            this.rdgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgender.Location = new System.Drawing.Point(163, 192);
            this.rdgender.Name = "rdgender";
            this.rdgender.Size = new System.Drawing.Size(59, 20);
            this.rdgender.TabIndex = 13;
            this.rdgender.Text = "gender";
            // 
            // txtename
            // 
            this.txtename.AutoSize = true;
            this.txtename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtename.Location = new System.Drawing.Point(163, 138);
            this.txtename.Name = "txtename";
            this.txtename.Size = new System.Drawing.Size(58, 20);
            this.txtename.TabIndex = 12;
            this.txtename.Text = "ename";
            // 
            // txtempno
            // 
            this.txtempno.AutoSize = true;
            this.txtempno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempno.Location = new System.Drawing.Point(163, 81);
            this.txtempno.Name = "txtempno";
            this.txtempno.Size = new System.Drawing.Size(58, 20);
            this.txtempno.TabIndex = 11;
            this.txtempno.Text = "empno";
            // 
            // extractbtn
            // 
            this.extractbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extractbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.extractbtn.Location = new System.Drawing.Point(326, 373);
            this.extractbtn.Name = "extractbtn";
            this.extractbtn.Size = new System.Drawing.Size(130, 48);
            this.extractbtn.TabIndex = 20;
            this.extractbtn.Text = "extract";
            this.extractbtn.UseVisualStyleBackColor = true;
            this.extractbtn.Click += new System.EventHandler(this.extractbtn_Click);
            // 
            // txtdeptno
            // 
            this.txtdeptno.AutoSize = true;
            this.txtdeptno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeptno.Location = new System.Drawing.Point(164, 322);
            this.txtdeptno.Name = "txtdeptno";
            this.txtdeptno.Size = new System.Drawing.Size(59, 20);
            this.txtdeptno.TabIndex = 21;
            this.txtdeptno.Text = "deptno";
            // 
            // textdeptnum
            // 
            this.textdeptnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textdeptnum.Location = new System.Drawing.Point(428, 322);
            this.textdeptnum.Name = "textdeptnum";
            this.textdeptnum.Size = new System.Drawing.Size(209, 26);
            this.textdeptnum.TabIndex = 22;
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndel.Location = new System.Drawing.Point(507, 373);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(130, 48);
            this.btndel.TabIndex = 23;
            this.btndel.Text = "delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // updatebtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 471);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.textdeptnum);
            this.Controls.Add(this.txtdeptno);
            this.Controls.Add(this.extractbtn);
            this.Controls.Add(this.cbbgender);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.date);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.rdgender);
            this.Controls.Add(this.txtename);
            this.Controls.Add(this.txtempno);
            this.Name = "updatebtn";
            this.Text = "update";
            this.Load += new System.EventHandler(this.updatebtn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbgender;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label rdgender;
        private System.Windows.Forms.Label txtename;
        private System.Windows.Forms.Label txtempno;
        private System.Windows.Forms.Button extractbtn;
        private System.Windows.Forms.Label txtdeptno;
        private System.Windows.Forms.TextBox textdeptnum;
        private System.Windows.Forms.Button btndel;
    }
}