using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private double result = 0;
        private string operation = "";
        private bool isOperationPerformed = false;
        private string currentTheme = "Light";

        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((resultLabel.Text == "0") || (isOperationPerformed))
            {
                resultLabel.Text = button.Text;
            }
            else
            {
                resultLabel.Text = resultLabel.Text + button.Text;
            }
            isOperationPerformed = false;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            if (operation != "")
            {
                return;
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = Double.Parse(resultLabel.Text);
            resultLabel.Text = result + operation;
            isOperationPerformed = true;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        { 
            if (resultLabel.Text == result + operation)
            {
                resultLabel.Text = "0";
            }
            switch (operation)
            {
                case "+":
                    resultLabel.Text = (result + Double.Parse(resultLabel.Text)).ToString();
                    break;
                case "-":
                    resultLabel.Text = (result - Double.Parse(resultLabel.Text)).ToString();
                    break;
                case "*":
                    resultLabel.Text = (result * Double.Parse(resultLabel.Text)).ToString();
                    break;
                case "/":
                    if (resultLabel.Text == "0")
                        MessageBox.Show("Деление на ноль невозможно!");
                    else
                        resultLabel.Text = (result / Double.Parse(resultLabel.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(resultLabel.Text);
            operation = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "0";
            result = 0;
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, resultLabel.Text);
            }
        }

        private void buttLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                resultLabel.Text = System.IO.File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void buttToggleTheme_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (currentTheme)
            {
                case "Light":
                    button.BackColor = Color.White;
                    this.BackColor = Color.Black; 
                    resultLabel.ForeColor = Color.White;
                    bttSave.FlatAppearance.BorderColor = Color.White;
                    bttSave.ForeColor = Color.White;
                    buttLoad.FlatAppearance.BorderColor = Color.White;
                    buttLoad.ForeColor = Color.White;
                    currentTheme = "Dark";
                    break;
                case "Dark":
                    button.BackColor = Color.Black;
                    this.BackColor = Color.White;
                    resultLabel.ForeColor = Color.Black;
                    bttSave.FlatAppearance.BorderColor = Color.Black;
                    bttSave.ForeColor = Color.Black;
                    buttLoad.FlatAppearance.BorderColor = Color.Black;
                    buttLoad.ForeColor = Color.Black;
                    currentTheme = "Light";
                    break;
                default:
                    break;
            }
        }
    }
}