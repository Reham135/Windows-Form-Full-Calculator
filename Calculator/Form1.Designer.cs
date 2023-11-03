namespace Calculator
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
            textScreen = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonEqual = new Button();
            buttonPoint = new Button();
            buttonAdd = new Button();
            buttonSub = new Button();
            buttonMulti = new Button();
            buttonDiv = new Button();
            buttonReset = new Button();
            SuspendLayout();
            // 
            // textScreen
            // 
            textScreen.Dock = DockStyle.Top;
            textScreen.Enabled = false;
            textScreen.Location = new Point(0, 0);
            textScreen.Name = "textScreen";
            textScreen.Size = new Size(732, 27);
            textScreen.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(147, 105);
            button1.Name = "button1";
            button1.Size = new Size(94, 50);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnNumbers_Click;
            // 
            // button2
            // 
            button2.Location = new Point(267, 105);
            button2.Name = "button2";
            button2.Size = new Size(94, 50);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnNumbers_Click;
            // 
            // button3
            // 
            button3.Location = new Point(386, 105);
            button3.Name = "button3";
            button3.Size = new Size(94, 50);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnNumbers_Click;
            // 
            // button4
            // 
            button4.Location = new Point(147, 182);
            button4.Name = "button4";
            button4.Size = new Size(94, 50);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnNumbers_Click;
            // 
            // button5
            // 
            button5.Location = new Point(267, 182);
            button5.Name = "button5";
            button5.Size = new Size(94, 50);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnNumbers_Click;
            // 
            // button6
            // 
            button6.Location = new Point(386, 182);
            button6.Name = "button6";
            button6.Size = new Size(94, 50);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnNumbers_Click;
            // 
            // button7
            // 
            button7.Location = new Point(147, 268);
            button7.Name = "button7";
            button7.Size = new Size(94, 50);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnNumbers_Click;
            // 
            // button8
            // 
            button8.Location = new Point(267, 268);
            button8.Name = "button8";
            button8.Size = new Size(94, 50);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btnNumbers_Click;
            // 
            // button9
            // 
            button9.Location = new Point(386, 268);
            button9.Name = "button9";
            button9.Size = new Size(94, 50);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btnNumbers_Click;
            // 
            // button0
            // 
            button0.Location = new Point(267, 353);
            button0.Name = "button0";
            button0.Size = new Size(94, 50);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += btnNumbers_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.Location = new Point(386, 353);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(94, 50);
            buttonEqual.TabIndex = 11;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // buttonPoint
            // 
            buttonPoint.Location = new Point(147, 353);
            buttonPoint.Name = "buttonPoint";
            buttonPoint.Size = new Size(94, 50);
            buttonPoint.TabIndex = 12;
            buttonPoint.Text = ".";
            buttonPoint.UseVisualStyleBackColor = true;
            buttonPoint.Click += buttonPoint_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(507, 105);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 50);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSub
            // 
            buttonSub.Location = new Point(507, 182);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(94, 50);
            buttonSub.TabIndex = 14;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += buttonSub_Click;
            // 
            // buttonMulti
            // 
            buttonMulti.Location = new Point(507, 268);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new Size(94, 50);
            buttonMulti.TabIndex = 15;
            buttonMulti.Text = "*";
            buttonMulti.UseVisualStyleBackColor = true;
            buttonMulti.Click += buttonMulti_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.Location = new Point(507, 353);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(94, 50);
            buttonDiv.TabIndex = 16;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += buttonDiv_Click;
            // 
            // buttonReset
            // 
            buttonReset.ForeColor = Color.Red;
            buttonReset.Location = new Point(626, 105);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 50);
            buttonReset.TabIndex = 17;
            buttonReset.Text = "C";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 450);
            Controls.Add(buttonReset);
            Controls.Add(buttonDiv);
            Controls.Add(buttonMulti);
            Controls.Add(buttonSub);
            Controls.Add(buttonAdd);
            Controls.Add(buttonPoint);
            Controls.Add(buttonEqual);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textScreen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textScreen;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonEqual;
        private Button buttonPoint;
        private Button buttonAdd;
        private Button buttonSub;
        private Button buttonMulti;
        private Button buttonDiv;
        private Button buttonReset;
    }
}