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
    public partial class ArrayPractice : Form
    {
        public ArrayPractice()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            const int size = 3;
            string[] name =new string [size];
            name[0] = "Shuvo";
            name[1] = "Shupto";
            name[2] = "Dipto";

            int[] age =new int[size];
            age[0] = 25;
            age[1] = 20;
            age[2] = 15;

            string message = "";
            for(int index=0; index<size; index++)
            {
                message+=("Name is : "+ name[index] + "\t"+"age is : " + age[index]+"\n");
            }
            MessageBox.Show(message);
        }
    }
}
