using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Negocio;

namespace CustomersCRUD
{
    public partial class frmRead : Form
    {
        public frmRead()
        {
            InitializeComponent();
        }

        private void frmRead_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            var list = new Customers().ConsultarCustomers();
            dtgRead.DataSource = list;
            dtgRead.Columns[0].HeaderText = "Customer ID";
            dtgRead.Columns[1].HeaderText = "Company Name";
            dtgRead.Columns[2].HeaderText = "Contact Name";
            dtgRead.Columns[3].HeaderText = "Contact Title";
            dtgRead.Columns[7].HeaderText = "Postal Code";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = dtgRead.Rows[dtgRead.CurrentRow.Index].Cells[0].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                new Customers().EliminarCustomer(id);
                
                MessageBox.Show("Registro eliminado");
                LoadGrid();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegisterUpdate fr = new frmRegisterUpdate();
            fr.ShowDialog();
            LoadGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmRegisterUpdate fr = new frmRegisterUpdate();
            fr.vis = "n";
            fr.id = dtgRead.Rows[dtgRead.CurrentRow.Index].Cells[0].Value.ToString();
            fr.ShowDialog();
            fr.vis = null;
            fr.id = null;
            LoadGrid();
        }
    }
}
