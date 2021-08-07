using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductOperationsWF
{
    static class TextBoxExtension
    {
        static string oldText = string.Empty;

        public static string OnlyDecimalNumberTextBox(this TextBox textBox)
        {
            if (textBox.Text.All(chr => chr.IsComma() || char.IsDigit(chr)))
            {
                oldText = textBox.Text;
                textBox.Text = oldText;
            }
            else
            {
                textBox.Text = oldText;
            }
            textBox.SelectionStart = textBox.Text.Length;
            return textBox.Text;
        }

        public static string OnlyLetterTextBox(this TextBox textBox)
        {
            if (textBox.Text.All(chr => char.IsLetter(chr) || char.IsWhiteSpace(chr)))
            {
                oldText = textBox.Text;
                textBox.Text = oldText;
            }
            else
            {
                textBox.Text = oldText;
            }
            textBox.SelectionStart = textBox.Text.Length;
            return textBox.Text;
        }
    }
}
