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
    
    public partial class extract : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        public extract()
        {
            InitializeComponent();
        }

        private void extract_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;" +
                "User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-6FSVS29");
        }

        private void btngetdata_Click(object sender, EventArgs e)
        {
            //with deptno
            con.Open();
            cmd = new SqlCommand("select * from EMPDATA where DEPTNO=@dp",con);
            cmd.Parameters.AddWithValue("@dp", int.Parse(txtdeptno.Text));
            SqlDataReader r=cmd.ExecuteReader();
            DataSet ds = new DataSet();//creating empty temp db
            ds.Tables.Add("deptdata");//adding temporary  table
            ds.Tables["deptdata"].Load(r);//taking data into our temporary table
             dgvdata.DataSource = ds.Tables["deptdata"];//displayng result on grid view

           


            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select * from EMPDATA where HIREDATE between @s and @e", con);
            cmd.Parameters.AddWithValue("@s", DateTime.Parse(dateTimePicker1.Text));
            cmd.Parameters.AddWithValue("@e", DateTime.Parse(dateTimePicker2.Text));
            SqlDataReader r = cmd.ExecuteReader();
            DataSet ds = new DataSet();//creating empty temp db
            ds.Tables.Add("deptdata");//adding temporary  table
            ds.Tables["deptdata"].Load(r);//taking data into our temporary table
            dgvdata.DataSource = ds.Tables["deptdata"];
            con.Close();

        }
    }
}
