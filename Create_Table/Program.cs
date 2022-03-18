using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Create_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Create();
        }

        public void Create()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = MSI;database=ProdiTI;Integrated Security = True");
                con.Open();

                SqlCommand cm = new SqlCommand("Create Table Mahasiswa (NIM Char(12) not null primary key, Nama Varchar(50), Alamat Varchar(50), Alamat Varchar(225), Jenis_Kelamin Varchar(1))", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel Sukses Dibuat!");
                Console.ReadKey();
            } catch (Exception e)
            {
                Console.WriteLine("Oops, sepertinya ada yang salah. " + e);
                Console.ReadKey();
            } finally
            {
                con.Close();
            }
        }
    }
}
