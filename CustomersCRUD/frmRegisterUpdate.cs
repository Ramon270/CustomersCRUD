using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace CustomersCRUD
{
    public partial class frmRegisterUpdate : Form
    {
        public string id;
        public string vis;
        public frmRegisterUpdate()
        {
            InitializeComponent();
        }

        private void frmRegisterUpdate_Load(object sender, EventArgs e)
        {
            if (vis == "n")
            {
                txtID.Hide();
                lbID.Hide();
                btnLimpiar.Hide();

                Customers cu = new Customers();
                Cliente cliente = cu.ConsultarCustomersByID(id);

                txtID.Text = cliente.CustomerID;
                txtCompanyName.Text = cliente.CompanyName;
                txtContactName.Text = cliente.ContactName;
                txtContactTitle.Text = cliente.ContactTitle;
                txtAddress.Text = cliente.Address;
                txtCity.Text = cliente.City;
                txtRegion.Text = cliente.Region;
                txtPostalCode.Text = cliente.PostalCode;
                txtCountry.Text = cliente.Country;
                txtPhone.Text = cliente.Phone;
                txtFax.Text = cliente.Fax;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            foreach(Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtID.Text == "" || txtCompanyName.Text == "")
            {
                MessageBox.Show("El campo ID y el campo Company Name son obligatorios");
                return;
            }

            if (id == null)
            {
                if (new Customers().Existe(txtID.Text) == true)
                {
                    MessageBox.Show("El ID ya se encuentra registrado");
                    return;
                }

                new Customers().RegistrarCustomers(txtID.Text, txtCompanyName.Text, txtContactName.Text, txtContactTitle.Text,
                    txtAddress.Text, txtCity.Text, txtRegion.Text, txtPostalCode.Text, txtCountry.Text, txtPhone.Text, txtFax.Text);

                MessageBox.Show("El registro se ha realizado");
                ClearForm();
            }

            else
            {
                new Customers().ActualizarCustomers(txtID.Text, txtCompanyName.Text, txtContactName.Text, txtContactTitle.Text,
                    txtAddress.Text, txtCity.Text, txtRegion.Text, txtPostalCode.Text, txtCountry.Text, txtPhone.Text, txtFax.Text);

                MessageBox.Show("Cambios realizados");
                this.Close();
            }
        }
    }
}
