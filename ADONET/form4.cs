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
    public partial class form4 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public form4()
        {
            InitializeComponent();
        }

        private void form4_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;" +
               "User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-6FSVS29");

            adp = new SqlDataAdapter("select * from deptdata", con);
            DataSet ds = new DataSet();
            adp.Fill(ds, "D");
            cbbdeptno.DataSource = ds.Tables["D"];
            cbbdeptno.ValueMember = "deptno";
            cbbdeptno.DisplayMember = "dname";
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select * from empdata where empno=@eno", con);
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(empnotxt.Text));
            DataSet ds = new DataSet();
            adp.Fill(ds, "e");
            DataRow r = ds.Tables["e"].Rows[0];
            r[2] = jobtxt.Text;
            r[3] = int.Parse(mgrtxt.Text);
            r[5] = int.Parse(saltxt.Text);
            if (commtxt != null)
            {
                r[6] = int.Parse(commtxt.Text);
            }

            r[7] = cbbdeptno.SelectedValue;
            SqlCommandBuilder cmb = new SqlCommandBuilder(adp);
            adp.UpdateCommand = cmb.GetUpdateCommand();
            adp.Update(ds, "e");
            MessageBox.Show("1 row updated");
            clear();
            

        }

        private void empnotxt_Leave(object sender, EventArgs e)
        {
            try
            {
                //when we enter empno and press tab,all other details should be populated for that employee
                adp = new SqlDataAdapter("select * from empdata where empno=@eno", con);
                adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(empnotxt.Text));
                DataSet ds = new DataSet();
                adp.Fill(ds, "e");
                DataRow r = ds.Tables["e"].Rows[0];
                enametxt.Text = r[1].ToString();
                jobtxt.Text = r[2].ToString();
                mgrtxt.Text = r[3].ToString();
                dtphiredate.Text = r[4].ToString();
                saltxt.Text = r[5].ToString();
                commtxt.Text = r[6].ToString();
                cbbdeptno.Text = r[7].ToString();

            }
            catch(IndexOutOfRangeException i)
            {
                MessageBox.Show("no employee exists");
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
