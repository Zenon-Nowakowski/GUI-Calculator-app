
namespace simple_calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_neg = new System.Windows.Forms.Button();
            this.button_CE = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button_min = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_eq = new System.Windows.Forms.Button();
            this.button_mul = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.equation = new System.Windows.Forms.Label();
            this.resultbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_neg
            // 
            this.button_neg.Location = new System.Drawing.Point(12, 438);
            this.button_neg.Name = "button_neg";
            this.button_neg.Size = new System.Drawing.Size(64, 64);
            this.button_neg.TabIndex = 0;
            this.button_neg.Text = "+/-";
            this.button_neg.UseVisualStyleBackColor = true;
            this.button_neg.Click += new System.EventHandler(this.button_neg_Click);
            // 
            // button_CE
            // 
            this.button_CE.Location = new System.Drawing.Point(12, 158);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(64, 64);
            this.button_CE.TabIndex = 1;
            this.button_CE.Text = "CE";
            this.button_CE.UseVisualStyleBackColor = true;
            this.button_CE.Click += new System.EventHandler(this.button_CE_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(152, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 64);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 64);
            this.button2.TabIndex = 4;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 64);
            this.button1.TabIndex = 5;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(152, 298);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 64);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(82, 298);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 64);
            this.button5.TabIndex = 7;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 64);
            this.button4.TabIndex = 8;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_click);
            // 
            // button_min
            // 
            this.button_min.Location = new System.Drawing.Point(222, 298);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(128, 64);
            this.button_min.TabIndex = 9;
            this.button_min.Text = "-";
            this.button_min.UseVisualStyleBackColor = true;
            this.button_min.Click += new System.EventHandler(this.button_min_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(158, 267);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(0, 0);
            this.button11.TabIndex = 10;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(222, 368);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(128, 64);
            this.button_add.TabIndex = 11;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_eq
            // 
            this.button_eq.Location = new System.Drawing.Point(222, 438);
            this.button_eq.Name = "button_eq";
            this.button_eq.Size = new System.Drawing.Size(128, 64);
            this.button_eq.TabIndex = 12;
            this.button_eq.Text = "=";
            this.button_eq.UseVisualStyleBackColor = true;
            this.button_eq.Click += new System.EventHandler(this.button_eq_Click);
            // 
            // button_mul
            // 
            this.button_mul.Location = new System.Drawing.Point(222, 228);
            this.button_mul.Name = "button_mul";
            this.button_mul.Size = new System.Drawing.Size(128, 64);
            this.button_mul.TabIndex = 13;
            this.button_mul.Text = "*";
            this.button_mul.UseVisualStyleBackColor = true;
            this.button_mul.Click += new System.EventHandler(this.button_mul_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(152, 228);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(64, 64);
            this.button9.TabIndex = 14;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(82, 228);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(64, 64);
            this.button8.TabIndex = 15;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 228);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 64);
            this.button7.TabIndex = 16;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(82, 438);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(64, 64);
            this.button0.TabIndex = 17;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_click);
            // 
            // button_div
            // 
            this.button_div.Location = new System.Drawing.Point(222, 158);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(128, 64);
            this.button_div.TabIndex = 18;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.button_div_Click);
            // 
            // button_C
            // 
            this.button_C.Location = new System.Drawing.Point(83, 158);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(134, 64);
            this.button_C.TabIndex = 19;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button_dot
            // 
            this.button_dot.Location = new System.Drawing.Point(152, 438);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(64, 64);
            this.button_dot.TabIndex = 21;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = true;
            this.button_dot.Click += new System.EventHandler(this.button_click);
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equation.ForeColor = System.Drawing.Color.Gray;
            this.equation.Location = new System.Drawing.Point(15, 15);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(25, 30);
            this.equation.TabIndex = 22;
            this.equation.Text = "0";
            // 
            // resultbox
            // 
            this.resultbox.Font = new System.Drawing.Font("Segoe UI", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultbox.Location = new System.Drawing.Point(12, 12);
            this.resultbox.Name = "resultbox";
            this.resultbox.Size = new System.Drawing.Size(332, 121);
            this.resultbox.TabIndex = 20;
            this.resultbox.Text = "0";
            this.resultbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 506);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button_mul);
            this.Controls.Add(this.button_eq);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button_min);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_CE);
            this.Controls.Add(this.button_neg);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zenon\'s Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_neg;
        private System.Windows.Forms.Button button_CE;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_eq;
        private System.Windows.Forms.Button button_mul;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Label equation;
        private System.Windows.Forms.TextBox resultbox;
    }
}

