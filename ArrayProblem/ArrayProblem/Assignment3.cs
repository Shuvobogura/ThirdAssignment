using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayProblem
{
    public partial class Assignment3 : Form
    {

        int index = 1;
        int unitPrice = 0;

        string[] customerName = new string[100];
        string[] contuctNumber = new string[100];
        string[] address = new string[100];
        string[] order = new string[100];
        string[] quantity = new string[100];
        string[] bill = new string[100];
        int[] quantity1 = new int[100];

        public Assignment3()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            customerName[index] = customerNameTextBox.Text;
            contuctNumber[index] = contuctTextBox.Text;
            address[index] = addressTextBox.Text;
            order[index] = orderComboBox.Text;
            quantity[index] = quantityTextBox.Text;

            if (order[index] == "Black")
            {
                unitPrice = 120;
            }
            else if (order[index] == "Cold")
            {
                unitPrice = 100;
            }
            else if (order[index] == "Hot")
            {
                unitPrice = 90;
            }
            else if (order[index] == "Regular")
            {
                unitPrice = 80;
            }

            bill[index] =(Convert.ToInt32 (quantity[index])*unitPrice).ToString();

            showRichTextBox.AppendText("\n\t Customer No. ["+index+"] Information \n\t_______________________\n\n");
            showRichTextBox.AppendText("Customer Name : "+customerName[index]+"\n");
            showRichTextBox.AppendText("Contuct Nimber : "+contuctNumber[index]+"\n");
            showRichTextBox.AppendText("Address : "+address[index]+"\n");
            showRichTextBox.AppendText("Order : "+order[index]+"\n");
            showRichTextBox.AppendText("Quantity : "+quantity[index]+"\n");
            showRichTextBox.AppendText("Total Bill is : "+bill[index]+".tk \n");

            customerNameTextBox.Clear();
            contuctTextBox.Clear();
            addressTextBox.Clear();
            orderComboBox.Text = " ";
            quantityTextBox.Clear();

        }
    }
}
