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
    public partial class updatebtn : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        public updatebtn()
        {
            InitializeComponent();
        }

        private void updatebtn_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;" +
                "Persist Security Info=True;User ID=sa;Initial Catalog=ADO_DB;" +
                "Data Source=DESKTOP-6FSVS29");

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update emp set ename=@en,deptno=@dn where empno=@eno ", con);
                cmd.Parameters.AddWithValue("@en", textBox2.Text);
                cmd.Parameters.AddWithValue("@dn", int.Parse(textdeptnum.Text));
                cmd.Parameters.AddWithValue("@eno", int.Parse(textBox1.Text));
                int r = cmd.ExecuteNonQuery();
                MessageBox.Show(r + "row(s) updated");
                //con.Close();
            }
            catch (SqlException s)
            {
                MessageBox.Show("name can be only 15 characters");
            }
            finally
            {
                con.Close();
            }
        }

        private void extractbtn_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                cmd = new SqlCommand("select * from emp where empno=@eno", con);
                cmd.Parameters.AddWithValue("@eno", int.Parse(textBox1.Text));//empno
                SqlDataReader r = cmd.ExecuteReader();//since we r using select,we use executereader
                r.Read();//using read cmd only once because empno is primary key, if there was any other feildd that might have duplicate values,we should use read multiple times

                textBox2.Text = r[1].ToString();//ename

                cbbgender.Text = r[2].ToString();//gender
                date.Text = r[3].ToString();//dob
                textdeptnum.Text = r[4].ToString();//deptno
                //con.Close();

            }
            catch (InvalidOperationException E)
            {
                MessageBox.Show("no employyee exists with this number");
                textBox1.Text = "";
                textBox2.Text = "";
                cbbgender.Text = "";
                date.Text = "";
                textdeptnum.Text = "";
            }
            catch (FormatException E)
            {
                MessageBox.Show("enter only numbers in empno");
            }
            finally
            {
                con.Close();
            }




        }

        private void btndel_Click(object sender, EventArgs e)
        {
            
                con.Open();
                cmd = new SqlCommand("delete from emp where empno=@eno", con);
                cmd.Parameters.AddWithValue("@eno", int.Parse(textBox1.Text));
                int r = cmd.ExecuteNonQuery();
            if (r != 0)
            {
                MessageBox.Show(r + "row(s) deleted");
            }
            if(r==0)
            {
                MessageBox.Show("does not exist,can't be deleted");
            }
                con.Close();
            
           
           
           
                
            
        }
    }
}
