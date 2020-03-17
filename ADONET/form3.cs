using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADONET
{
    public partial class form3 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;

        public form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void form3_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;" +
                "User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-6FSVS29");

            adp = new SqlDataAdapter("select * from deptdata",con);
            DataSet ds = new DataSet();
            adp.Fill(ds, "D");
            cbbdeptno.DataSource = ds.Tables["D"];
            cbbdeptno.ValueMember = "deptno";
            cbbdeptno.DisplayMember = "dname";


        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                adp = new SqlDataAdapter("select * from empdata", con);
                DataSet ds = new DataSet();
                adp.Fill(ds, "E");
                DataRow dr = ds.Tables["E"].NewRow();//adding new row to our empty database ds
                dr[0] = int.Parse(empnotxt.Text);
                dr[1] = enametxt.Text;
                dr[2] = jobtxt.Text;
                dr[3] = int.Parse(mgrtxt.Text);
                dr[4] = DateTime.Parse(dtphiredate.Text);
                dr[5] = int.Parse(saltxt.Text);
                dr[6] = int.Parse(commtxt.Text);
                dr[7] = cbbdeptno.SelectedValue;

                ds.Tables["E"].Rows.Add(dr);

                //now we wil send data from the ds to database
                SqlCommandBuilder cmb = new SqlCommandBuilder(adp);
                adp.InsertCommand = cmb.GetInsertCommand();
                adp.Update(ds, "E");

                MessageBox.Show( "1 row inserted");
                clear();


            }
          
            catch(SqlException s)
            {
                MessageBox.Show(s.Message);
            }






        }
        private void clear()
        {
            empnotxt.Text = "";
            enametxt.Text = "";
            saltxt.Text = "";
            jobtxt.Text = "";
            commtxt.Text = "";
            mgrtxt.Text = "";
            cbbdeptno.Text = "";
            


        }
    }
}
