namespace Calculator_Yanjun
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.textBox_Value = new System.Windows.Forms.TextBox();
            this.percent = new System.Windows.Forms.Button();
            this.clearEntry = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.squareRoot = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.quotient = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.deci = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.MC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.operationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Value
            // 
            this.textBox_Value.Location = new System.Drawing.Point(8, 28);
            this.textBox_Value.Name = "textBox_Value";
            this.textBox_Value.Size = new System.Drawing.Size(253, 20);
            this.textBox_Value.TabIndex = 0;
            this.textBox_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // percent
            // 
            this.percent.Location = new System.Drawing.Point(8, 103);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(55, 50);
            this.percent.TabIndex = 1;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.Click += new System.EventHandler(this.operatorSpecial_Click);
            // 
            // clearEntry
            // 
            this.clearEntry.Location = new System.Drawing.Point(74, 103);
            this.clearEntry.Name = "clearEntry";
            this.clearEntry.Size = new System.Drawing.Size(55, 50);
            this.clearEntry.TabIndex = 2;
            this.clearEntry.Text = "CE";
            this.clearEntry.UseVisualStyleBackColor = true;
            this.clearEntry.Click += new System.EventHandler(this.clearEntry_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(140, 103);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(55, 50);
            this.clear.TabIndex = 4;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(206, 103);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(55, 50);
            this.delete.TabIndex = 5;
            this.delete.Text = "del";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(206, 159);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(55, 50);
            this.divide.TabIndex = 9;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.operator_Click);
            // 
            // squareRoot
            // 
            this.squareRoot.Location = new System.Drawing.Point(140, 159);
            this.squareRoot.Name = "squareRoot";
            this.squareRoot.Size = new System.Drawing.Size(55, 50);
            this.squareRoot.TabIndex = 8;
            this.squareRoot.Text = "sqrt";
            this.squareRoot.UseVisualStyleBackColor = true;
            this.squareRoot.Click += new System.EventHandler(this.operatorSpecial_Click);
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(74, 159);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(55, 50);
            this.square.TabIndex = 7;
            this.square.Text = "x^2";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.operatorSpecial_Click);
            // 
            // quotient
            // 
            this.quotient.Location = new System.Drawing.Point(8, 159);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(55, 50);
            this.quotient.TabIndex = 6;
            this.quotient.Text = "1/x";
            this.quotient.UseVisualStyleBackColor = true;
            this.quotient.Click += new System.EventHandler(this.operatorSpecial_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(206, 215);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(55, 50);
            this.multiply.TabIndex = 13;
            this.multiply.Text = "X";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.operator_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(140, 215);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(55, 50);
            this.nine.TabIndex = 12;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.number_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(74, 215);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(55, 50);
            this.eight.TabIndex = 11;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.number_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(8, 215);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(55, 50);
            this.seven.TabIndex = 10;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.number_Click);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(206, 271);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(55, 50);
            this.subtract.TabIndex = 17;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.operator_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(140, 271);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(55, 50);
            this.six.TabIndex = 16;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.number_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(74, 271);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(55, 50);
            this.five.TabIndex = 15;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.number_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(8, 271);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(55, 50);
            this.four.TabIndex = 14;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.number_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(206, 383);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(55, 50);
            this.equals.TabIndex = 25;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // deci
            // 
            this.deci.Location = new System.Drawing.Point(140, 383);
            this.deci.Name = "deci";
            this.deci.Size = new System.Drawing.Size(55, 50);
            this.deci.TabIndex = 24;
            this.deci.Text = ".";
            this.deci.UseVisualStyleBackColor = true;
            this.deci.Click += new System.EventHandler(this.number_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(74, 383);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(55, 50);
            this.zero.TabIndex = 23;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.number_Click);
            // 
            // sign
            // 
            this.sign.Location = new System.Drawing.Point(8, 383);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(55, 50);
            this.sign.TabIndex = 22;
            this.sign.Text = "+/-";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(206, 327);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(55, 50);
            this.add.TabIndex = 21;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.operator_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(140, 327);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(55, 50);
            this.three.TabIndex = 20;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.number_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(74, 327);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(55, 50);
            this.two.TabIndex = 19;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.number_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(8, 327);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(55, 50);
            this.one.TabIndex = 18;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.number_Click);
            // 
            // MC
            // 
            this.MC.AutoSize = true;
            this.MC.Location = new System.Drawing.Point(14, 73);
            this.MC.Name = "MC";
            this.MC.Size = new System.Drawing.Size(23, 13);
            this.MC.TabIndex = 26;
            this.MC.Text = "MC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "MR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "M-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "M+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "MS";
            // 
            // operationLabel
            // 
            this.operationLabel.AutoSize = true;
            this.operationLabel.Location = new System.Drawing.Point(12, 10);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(0, 13);
            this.operationLabel.TabIndex = 32;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 439);
            this.Controls.Add(this.operationLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MC);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.deci);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.add);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.squareRoot);
            this.Controls.Add(this.square);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.clearEntry);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.textBox_Value);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.ShowInTaskbar = false;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Value;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button clearEntry;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button squareRoot;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button quotient;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button deci;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Label MC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label operationLabel;
    }
}

