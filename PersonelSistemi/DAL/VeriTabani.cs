using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSistemi.DAL
{
   public class VeriTabani
    {
        private string baglanti = "Server=172.21.54.253; Database=26_132430041; Uid=26_132430041; Pwd=İnif123.;";
        public DataTable VeriGetir(string sql, MySqlParameter[] parametreler = null)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(baglanti))
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                if (parametreler != null) da.SelectCommand.Parameters.AddRange(parametreler);
                da.Fill(dt);
            }
            return dt;
        }
        public void SorguCalistir(string sql, MySqlParameter[] parametreler = null)
        {
            using (MySqlConnection conn = new MySqlConnection(baglanti))
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if (parametreler != null)
                {
                    cmd.Parameters.AddRange(parametreler);
                }
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
