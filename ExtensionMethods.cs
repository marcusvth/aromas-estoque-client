using System;
using System.Windows.Forms;
using AromasEstoque.Properties;
using MetroFramework.Controls;

namespace AromasEstoque
{
    public static class ExtensionMethods
    {
        public static void Monify(this MetroTextBox textBox, KeyEventArgs e)
        {
            var isKeyboardTop = e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9;
            var isNumpad = e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9;
            var isDeleting = e.KeyCode is Keys.Delete || e.KeyCode is Keys.Back;

            if (!(isKeyboardTop || isNumpad || isDeleting)) return;

            var unformatedString = textBox.Text.Replace(",", "");

            if (isDeleting)
                unformatedString = unformatedString.Substring(0, unformatedString.Length - 1);
            else if (unformatedString.Length >= 8) return;
            else
                unformatedString += Convert.ToChar(isKeyboardTop ? e.KeyCode : e.KeyCode - 48);
            var decimalValue = decimal.Parse(unformatedString) / 100;
            textBox.Text = decimalValue.ToString("0.00");
        }
    }
}