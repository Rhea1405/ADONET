using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ADONET
{
    class ADONET

    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        int product_id;
        public ADONET(int product_id)
        {
            this.product_id = product_id;
        }
        public int Product_id { get => product_id; }
        public void test()
        {
            try
            {
                con = new SqlConnection("Password=Admin@123;Persist Security Info=True;" +
                    "User ID=sa;Initial Catalog=TEST1;Data Source=DESKTOP-6FSVS29");
                con.Open();
                cmd = new SqlCommand("select product_id,product_name,description,standard_cost,list_price from productinfo where product_id=@P", con);
                cmd.Parameters.AddWithValue("@P",Product_id);
                SqlDataReader sr = cmd.ExecuteReader();
                sr.Read();
                Console.WriteLine("product_id" + sr[0]);
                Console.WriteLine("product_name" + sr[1]);
                Console.WriteLine("description" + sr[2]);
                Console.WriteLine("standard cost" + sr[3]);
                Console.WriteLine("list price" + sr[4]);


            }
            catch (InvalidOperationException s)
            {
                Console.WriteLine("invalid product id");
            }
            finally
            {
                con.Close();
            }
        }


        class ADONETEXAM
        {
            static void Main(string[] args)
            {
                Console.Write("Enter a Product ID : ");
                int P = int.Parse(Console.ReadLine());
                ADONET A = new ADONET(P);
                A.test();
                Console.Read();
            }
        }
    }
}
