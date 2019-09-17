namespace ArrayProblem
{
    partial class ArraySecondProblem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sizeButton = new System.Windows.Forms.Button();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.elementButton = new System.Windows.Forms.Button();
            this.elementTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sizeButton
            // 
            this.sizeButton.Location = new System.Drawing.Point(272, 46);
            this.sizeButton.Name = "sizeButton";
            this.sizeButton.Size = new System.Drawing.Size(75, 23);
            this.sizeButton.TabIndex = 0;
            this.sizeButton.Text = "Size";
            this.sizeButton.UseVisualStyleBackColor = true;
            this.sizeButton.Click += new System.EventHandler(this.sizeButton_Click);
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(129, 49);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(126, 20);
            this.sizeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size";
            // 
            // elementButton
            // 
            this.elementButton.Location = new System.Drawing.Point(272, 81);
            this.elementButton.Name = "elementButton";
            this.elementButton.Size = new System.Drawing.Size(75, 23);
            this.elementButton.TabIndex = 0;
            this.elementButton.Text = "Element";
            this.elementButton.UseVisualStyleBackColor = true;
            this.elementButton.Click += new System.EventHandler(this.elementButton_Click);
            // 
            // elementTextBox
            // 
            this.elementTextBox.Location = new System.Drawing.Point(129, 84);
            this.elementTextBox.Name = "elementTextBox";
            this.elementTextBox.Size = new System.Drawing.Size(126, 20);
            this.elementTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Element";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(272, 120);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // ArraySecondProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 183);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elementTextBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.elementButton);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.sizeButton);
            this.Name = "ArraySecondProblem";
            this.Text = "ArraySecondProblem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sizeButton;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button elementButton;
        private System.Windows.Forms.TextBox elementTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showButton;
    }
}