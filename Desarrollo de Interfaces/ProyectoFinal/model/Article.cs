using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Article
    {
        public string id;
        public string description;
        public int quantity;
        public int price;

        public Article(string id, string description, int quantity)
        {
            this.id = id;
            this.description = description;
            this.quantity = quantity;
        }

        public int checkStock(SqlConnection connection)
        {
            int r = 0;
            SqlCommand cmd = new SqlCommand($"SELECT cant_existente2 FROM Existencias WHERE codigo='{this.id}'", connection);

            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                r = rd.GetInt32(0);
            }
            rd.Close();
            return r;
        }

        public void reserveArticle(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand($"UPDATE Existencias SET cant_reservada += 1 WHERE codigo='{this.id}'", connection);
            cmd.ExecuteNonQuery();
        }

        public void orderArticle(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand($"INSERT INTO pedidos_compra (Codigo, Cantidad, Descripcion) VALUES ('{this.id}', '1', '{this.description}')", connection);
            cmd.ExecuteNonQuery();
        }
    }
}
