﻿using System;
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
    public partial class ArraySecondProblem : Form
    {
        const int size = 10;
        int[] element = new int[size];
        int userSize = 0;
        int index = 0;

        public ArraySecondProblem()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string message = "";
            for(int i=0; i<userSize; i++)
            {
                message += " " + element[i];
            }
            MessageBox.Show(message);

            message = " ";
            for(int i = userSize - 1; i >= 0; i--)
            {
                message += " " + element[i];
            }
            MessageBox.Show(message);
        }

        private void sizeButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32 (sizeTextBox.Text) <= size)
            {
                userSize = Convert.ToInt32 (sizeTextBox.Text);
            }
            else
            {
                MessageBox.Show("Size Must Be less than " + size);
            }
        }

        private void elementButton_Click(object sender, EventArgs e)
        {
            if (index < userSize)
            {
                element[index] = Convert.ToInt32 (elementTextBox.Text);
                index++;
            }
            else
            {
                MessageBox.Show("Element is full");
            }
        }
    }
}
