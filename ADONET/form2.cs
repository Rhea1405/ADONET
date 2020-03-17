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
    //command builder
    public partial class form2 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public form2()
        {
            InitializeComponent();
        }

        private void form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;" +
                "User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-6FSVS29");
            adp = new SqlDataAdapter("select * from empdata", con);
            DataSet ds = new DataSet();

            SqlCommandBuilder cmb = new SqlCommandBuilder(adp);//will generate the insert,delete,update for the table mentioned in query since datadaptor can take only select
            SqlCommand cmd = cmb.GetInsertCommand();//or getdeletecommand or getupdatecommand
            MessageBox.Show(cmd.CommandText);

        }
    }
}
