using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//to connect to database

namespace ADONET
{
    public partial class insert : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;

        public insert()
        {
            InitializeComponent();
        }

        private void insert_Load(object sender, EventArgs e)
        {
            //step 1
            con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ADO_DB;Data Source=DESKTOP-6FSVS29");

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
           


                try
                {
                    //step 2
                    con.Open();
                    //step3
                    cmd = new SqlCommand("insert into emp values(@eno,@en,@g,@d)", con);
                    cmd.Parameters.AddWithValue("@eno", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@en", txtename.Text);
                    cmd.Parameters.AddWithValue("@g", cbbgender.Text);
                    cmd.Parameters.AddWithValue("@d", DateTime.Parse(date.Text));
                    //step 4
                    int r = cmd.ExecuteNonQuery();

                    MessageBox.Show(r + " row inserted");
                    //step5
                }

                catch (SqlException E)
                {
                    if (E.Message.Contains("PK_emp"))
                    {
                        MessageBox.Show("empno cant be null");
                    }
                    if (E.Message.Contains("CK_dob"))
                    {
                        MessageBox.Show("age should be greater than 21 years");
                    }
                    if (E.Message.Contains("CK_gender"))
                    {
                        MessageBox.Show("gender should be 'male' or 'female' ");
                    }

                }
            catch(FormatException EF)
            {
                MessageBox.Show("enter all details");
            }
                finally
                {
                    con.Close();
                }

            }
        }
    }

