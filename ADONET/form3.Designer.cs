namespace ADONET
{
    partial class form3
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
            this.labelempno = new System.Windows.Forms.Label();
            this.labelename = new System.Windows.Forms.Label();
            this.labeljob = new System.Windows.Forms.Label();
            this.labelmgr = new System.Windows.Forms.Label();
            this.labelhiredate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.empnotxt = new System.Windows.Forms.TextBox();
            this.enametxt = new System.Windows.Forms.TextBox();
            this.mgrtxt = new System.Windows.Forms.TextBox();
            this.jobtxt = new System.Windows.Forms.TextBox();
            this.dtphiredate = new System.Windows.Forms.DateTimePicker();
            this.saltxt = new System.Windows.Forms.TextBox();
            this.commtxt = new System.Windows.Forms.TextBox();
            this.cbbdeptno = new System.Windows.Forms.ComboBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelempno
            // 
            this.labelempno.AutoSize = true;
            this.labelempno.Location = new System.Drawing.Point(130, 28);
            this.labelempno.Name = "labelempno";
            this.labelempno.Size = new System.Drawing.Size(39, 13);
            this.labelempno.TabIndex = 0;
            this.labelempno.Text = "empno";
            // 
            // labelename
            // 
            this.labelename.AutoSize = true;
            this.labelename.Location = new System.Drawing.Point(130, 75);
            this.labelename.Name = "labelename";
            this.labelename.Size = new System.Drawing.Size(81, 13);
            this.labelename.TabIndex = 1;
            this.labelename.Text = "employee name";
            // 
            // labeljob
            // 
            this.labeljob.AutoSize = true;
            this.labeljob.Location = new System.Drawing.Point(130, 118);
            this.labeljob.Name = "labeljob";
            this.labeljob.Size = new System.Drawing.Size(21, 13);
            this.labeljob.TabIndex = 2;
            this.labeljob.Text = "job";
            // 
            // labelmgr
            // 
            this.labelmgr.AutoSize = true;
            this.labelmgr.Location = new System.Drawing.Point(130, 170);
            this.labelmgr.Name = "labelmgr";
            this.labelmgr.Size = new System.Drawing.Size(48, 13);
            this.labelmgr.TabIndex = 3;
            this.labelmgr.Text = "manager";
            this.labelmgr.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelhiredate
            // 
            this.labelhiredate.AutoSize = true;
            this.labelhiredate.Location = new System.Drawing.Point(130, 227);
            this.labelhiredate.Name = "labelhiredate";
            this.labelhiredate.Size = new System.Drawing.Size(45, 13);
            this.labelhiredate.TabIndex = 4;
            this.labelhiredate.Text = "hiredate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "commission";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "deptno";
            // 
            // empnotxt
            // 
            this.empnotxt.Location = new System.Drawing.Point(436, 25);
            this.empnotxt.Name = "empnotxt";
            this.empnotxt.Size = new System.Drawing.Size(100, 20);
            this.empnotxt.TabIndex = 8;
            // 
            // enametxt
            // 
            this.enametxt.Location = new System.Drawing.Point(436, 72);
            this.enametxt.Name = "enametxt";
            this.enametxt.Size = new System.Drawing.Size(100, 20);
            this.enametxt.TabIndex = 9;
            this.enametxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // mgrtxt
            // 
            this.mgrtxt.Location = new System.Drawing.Point(436, 170);
            this.mgrtxt.Name = "mgrtxt";
            this.mgrtxt.Size = new System.Drawing.Size(100, 20);
            this.mgrtxt.TabIndex = 10;
            this.mgrtxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // jobtxt
            // 
            this.jobtxt.Location = new System.Drawing.Point(436, 118);
            this.jobtxt.Name = "jobtxt";
            this.jobtxt.Size = new System.Drawing.Size(100, 20);
            this.jobtxt.TabIndex = 11;
            // 
            // dtphiredate
            // 
            this.dtphiredate.Location = new System.Drawing.Point(436, 227);
            this.dtphiredate.Name = "dtphiredate";
            this.dtphiredate.Size = new System.Drawing.Size(200, 20);
            this.dtphiredate.TabIndex = 12;
            // 
            // saltxt
            // 
            this.saltxt.Location = new System.Drawing.Point(436, 271);
            this.saltxt.Name = "saltxt";
            this.saltxt.Size = new System.Drawing.Size(100, 20);
            this.saltxt.TabIndex = 13;
            // 
            // commtxt
            // 
            this.commtxt.Location = new System.Drawing.Point(436, 310);
            this.commtxt.Name = "commtxt";
            this.commtxt.Size = new System.Drawing.Size(100, 20);
            this.commtxt.TabIndex = 14;
            // 
            // cbbdeptno
            // 
            this.cbbdeptno.FormattingEnabled = true;
            this.cbbdeptno.Location = new System.Drawing.Point(436, 360);
            this.cbbdeptno.Name = "cbbdeptno";
            this.cbbdeptno.Size = new System.Drawing.Size(121, 21);
            this.cbbdeptno.TabIndex = 15;
            // 
            // submitbtn
            // 
            this.submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.Location = new System.Drawing.Point(331, 403);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(75, 35);
            this.submitbtn.TabIndex = 16;
            this.submitbtn.Text = "submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.cbbdeptno);
            this.Controls.Add(this.commtxt);
            this.Controls.Add(this.saltxt);
            this.Controls.Add(this.dtphiredate);
            this.Controls.Add(this.jobtxt);
            this.Controls.Add(this.mgrtxt);
            this.Controls.Add(this.enametxt);
            this.Controls.Add(this.empnotxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelhiredate);
            this.Controls.Add(this.labelmgr);
            this.Controls.Add(this.labeljob);
            this.Controls.Add(this.labelename);
            this.Controls.Add(this.labelempno);
            this.Name = "form3";
            this.Text = "form3";
            this.Load += new System.EventHandler(this.form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelempno;
        private System.Windows.Forms.Label labelename;
        private System.Windows.Forms.Label labeljob;
        private System.Windows.Forms.Label labelmgr;
        private System.Windows.Forms.Label labelhiredate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox empnotxt;
        private System.Windows.Forms.TextBox enametxt;
        private System.Windows.Forms.TextBox mgrtxt;
        private System.Windows.Forms.TextBox jobtxt;
        private System.Windows.Forms.DateTimePicker dtphiredate;
        private System.Windows.Forms.TextBox saltxt;
        private System.Windows.Forms.TextBox commtxt;
        private System.Windows.Forms.ComboBox cbbdeptno;
        private System.Windows.Forms.Button submitbtn;
    }
}