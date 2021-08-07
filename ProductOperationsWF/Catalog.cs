using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductOperationsWF
{
    public partial class CatalogForm : Form
    {
        Form2 productForm = new Form2();
        public CatalogForm()
        {
            InitializeComponent();
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.DisplayMember = "Name";
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
                listBox1.Items.Clear();
            else
                MessageBox.Show("Listbox is empty!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 0)
            {
                while (listBox1.SelectedItems.Count > 0)
                    listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
            else if (listBox1.SelectedItems.Count == 0)
                MessageBox.Show("Listbox is empty!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Please choose at least one product!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            var result = productForm.ShowDialog();
            if (result == DialogResult.OK)
                listBox1.Items.Add(productForm.Product);
            this.Show();

        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 0)
            {
                int index = listBox1.SelectedIndex;
                var product = listBox1.SelectedItem as Product;

                var result = productForm.ShowDialog(product);

                if (result == DialogResult.OK)
                {
                    listBox1.Items.Remove(product);
                    listBox1.Items.Insert(index, productForm.Product);
                }
            }
            else if (listBox1.Items.Count == 0)
                MessageBox.Show("Listbox is empty!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Please choose at least one product!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
