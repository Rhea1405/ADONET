using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADONET
{
    class ADO
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        int product_id;
        public ADO(int product_id)
        {
            this.product_id = product_id;
        }
        public int Product_id { get => product_id; }
        public void TEST()
        {
            try
            {
                con = new SqlConnection("Password=Admin@123;Persist Security Info=True;" +
                    "User ID=sa;Initial Catalog=TEST1;Data Source=DESKTOP-6FSVS29");
                con.Open();
                cmd = new SqlCommand("select product_id,product_name,description,standard_cost,list_price from productinfo where product_id=@Pid", con);
                cmd.Parameters.AddWithValue("@Pid", Product_id);
                SqlDataReader R = cmd.ExecuteReader();
                R.Read();
                Console.WriteLine("PRODUCT_ID : " + R[0]);
                Console.WriteLine("PRODUCT_NAME : " + R[1]);
                Console.WriteLine("DESCRIPTION : " + R[2]);
                Console.WriteLine("STANDARD_COST : " + R[3]);
                Console.WriteLine("LIST_PRICE : " + R[4]);
            }
            catch (InvalidOperationException E)
            {
                Console.WriteLine("Enter Valid Product_id");
            }
            finally
            {
                con.Close();
            }
        }
    }
    class ado
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Product ID : ");
            int pid = int.Parse(Console.ReadLine());
            ADO A = new ADO(pid);
            A.TEST();
            Console.Read();
        }
    }
}


