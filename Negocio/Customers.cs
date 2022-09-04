using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Data;

namespace Negocio
{
	public class Customers
	{
		private Connection con = new Connection();
		private SqlCommand comando = new SqlCommand();

		public List<Cliente> ConsultarCustomers()
        {
			List<Cliente> cliente = new List<Cliente>();

			comando.Connection = con.OpenCon();
			SqlDataReader r;

			comando.CommandText = "select * from Customers";
			r = comando.ExecuteReader();

            while (r.Read())
            {
				Cliente cli = new Cliente();

				cli.CustomerID = r.GetString(0);
				cli.CompanyName = r.GetString(1);
				cli.ContactName = Convert.ToString(r.GetValue(2));
				cli.ContactTitle = Convert.ToString(r.GetValue(3));
				cli.Address = Convert.ToString(r.GetValue(4));
				cli.City = Convert.ToString(r.GetValue(5));
				cli.Region = Convert.ToString(r.GetValue(6));
				cli.PostalCode = Convert.ToString(r.GetValue(7));
				cli.Country = Convert.ToString(r.GetValue(8));
				cli.Phone = Convert.ToString(r.GetValue(9));
				cli.Fax = Convert.ToString(r.GetValue(10));

				cliente.Add(cli);
            }
			r.Close();
			con.CloseCon();

			return cliente;
        }

		public void RegistrarCustomers(string iD, string companyName, string contactName, string contactTitle,
			string address, string city, string region, string postalCode, string country, string phone, string fax)
        {
			comando.Connection = con.OpenCon();
			comando.CommandText = "insert into Customers values (@iD, @companyName, @contactName, @contactTitle" +
				", @address, @city, @region, @postalCode, @country, @phone, @fax)";

			comando.Parameters.AddWithValue("@iD", iD);
			comando.Parameters.AddWithValue("@companyName", companyName);
			comando.Parameters.AddWithValue("@contactName", contactName);
			comando.Parameters.AddWithValue("@contactTitle", contactTitle);
			comando.Parameters.AddWithValue("@address", address);
			comando.Parameters.AddWithValue("@city", city);
			comando.Parameters.AddWithValue("@region", region);
			comando.Parameters.AddWithValue("@postalCode", postalCode);
			comando.Parameters.AddWithValue("@country", country);
			comando.Parameters.AddWithValue("@phone", phone);
			comando.Parameters.AddWithValue("@fax", fax);

			comando.ExecuteNonQuery();
			con.CloseCon();

		}

		public void ActualizarCustomers(string iD, string companyName, string contactName, string contactTitle,
			string address, string city, string region, string postalCode, string country, string phone, string fax)
        {
			comando.Connection = con.OpenCon();
			comando.CommandText = "update Customers set CompanyName = @companyName, ContactName = @contactName" +
				", ContactTitle = @contactTitle, Address = @address, City = @city, Region = @region" +
				", PostalCode = @postalCode, Country = @country, Phone = @phone, Fax = @fax where CustomerID = @iD";

			comando.Parameters.AddWithValue("@iD", iD);
			comando.Parameters.AddWithValue("@companyName", companyName);
			comando.Parameters.AddWithValue("@contactName", contactName);
			comando.Parameters.AddWithValue("@contactTitle", contactTitle);
			comando.Parameters.AddWithValue("@address", address);
			comando.Parameters.AddWithValue("@city", city);
			comando.Parameters.AddWithValue("@region", region);
			comando.Parameters.AddWithValue("@postalCode", postalCode);
			comando.Parameters.AddWithValue("@country", country);
			comando.Parameters.AddWithValue("@phone", phone);
			comando.Parameters.AddWithValue("@fax", fax);

			comando.ExecuteNonQuery();
			con.CloseCon();
		}

		public bool Existe(string iD)
        {
			bool existe;

			comando.Connection = con.OpenCon();
			comando.CommandText = "select count(*) from Customers where CustomerID ='" + iD + "'";

			int count = Convert.ToInt32(comando.ExecuteScalar());

			if (count == 0)
			{
				existe = false;
			}
			else existe = true;

			con.CloseCon();

			return existe;
        }

		public Cliente ConsultarCustomersByID(string iD)
		{
			comando.Connection = con.OpenCon();
			SqlDataReader r;

			comando.CommandText = "select * from Customers where CustomerID = @iD";
			comando.Parameters.AddWithValue("@iD", iD);
			r = comando.ExecuteReader();

			r.Read();
			
			Cliente cli = new Cliente();

			cli.CustomerID = r.GetString(0);
			cli.CompanyName = r.GetString(1);
			cli.ContactName = Convert.ToString(r.GetValue(2));
			cli.ContactTitle = Convert.ToString(r.GetValue(3));
			cli.Address = Convert.ToString(r.GetValue(4));
			cli.City = Convert.ToString(r.GetValue(5));
			cli.Region = Convert.ToString(r.GetValue(6));
			cli.PostalCode = Convert.ToString(r.GetValue(7));
			cli.Country = Convert.ToString(r.GetValue(8));
			cli.Phone = Convert.ToString(r.GetValue(9));
			cli.Fax = Convert.ToString(r.GetValue(10));

			r.Close();
			con.CloseCon();

			return cli;
		}

		public void EliminarCustomer(string id)
        {
			comando.Connection = con.OpenCon();
			comando.CommandText = "delete from Customers where CustomerID = @id";
			comando.Parameters.AddWithValue("@id", id);
			comando.ExecuteNonQuery();
			con.CloseCon();
		}
	}

	public class Cliente
    {
		public string CustomerID { get; set; }
		public string CompanyName { get; set; }
		public string ContactName { get; set; }
		public string ContactTitle { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string Region { get; set; }
		public string PostalCode { get; set; }
		public string Country { get; set; }
		public string Phone { get; set; }
		public string Fax { get; set; }
	}
}
