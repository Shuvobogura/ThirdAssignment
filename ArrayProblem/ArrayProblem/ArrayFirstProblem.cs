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
    public partial class ArrayFirstProblem : Form
    {
        public ArrayFirstProblem()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            const int size = 10;
            int[] index = new int[size];
            index[0] = 1;
            index[1] = 1;
            index[2] = 2;
            index[3] = 3;
            index[4] = 4;
            index[5] = 5;
            index[6] = 6;
            index[7] = 7;
            index[8] = 8;
            index[9] = 9;

            string message = "";
            for(int i=0; i<size; i++)
            {
                message += (" "+index[i]);
            }
            MessageBox.Show("Elements in array are : " + message);
        }
    }
}
