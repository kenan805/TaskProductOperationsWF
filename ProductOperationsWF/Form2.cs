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
    public partial class Form2 : Form
    {
        public Product Product { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(Product product)
        {
            textBox1.Text = product.Name;
            textBox2.Text = product.Country;
            textBox3.Text = product.Cost.ToString();
            return ShowDialog();
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            Product = new Product();
            Product.Name = textBox1.Text;
            Product.Country = textBox2.Text;
            Product.Cost = double.Parse(textBox3.Text);
            DialogResult = DialogResult.OK;
        }

        private void TextBoxOnlyLetter_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox tb)
            {
                tb.Text = tb.OnlyLetterTextBox();
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.OnlyDecimalNumberTextBox();
        }
    }
}
