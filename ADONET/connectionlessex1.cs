using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADONET
{
    public partial class connectionlessex1 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public connectionlessex1()
        {
            InitializeComponent();
        }

        

        private void connectionlessex1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;" +
                "User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-6FSVS29");

            adp = new SqlDataAdapter("select * from deptdata", con);
            DataSet ds = new DataSet();
            cbbdeptno.DataSource = ds;
            adp.Fill(ds,"emp1");

            cbbdeptno.DataSource = ds.Tables["emp1"];
            cbbdeptno.ValueMember = "deptno";
           cbbdeptno.DisplayMember="dname";









        }
        private void txtdeptno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnextract_Click(object sender, EventArgs e)
        {
          adp = new SqlDataAdapter("select * from EMPDATA where deptno=@dp", con);
          adp.SelectCommand.Parameters.AddWithValue("@dp",(cbbdeptno.SelectedValue));

            DataSet ds = new DataSet();
            adp.Fill(ds, "emp");
            dgv1.DataSource = ds.Tables["emp"];

            


            
        }

        private void cbbdeptno_SelectedIndexChanged(object sender, EventArgs e)
        {
           



        }
    }
}
