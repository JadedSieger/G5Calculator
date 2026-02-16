namespace WinFormsApp1
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
            txtDisplay = new RichTextBox();
            clearBtn = new Button();
            polarBtn = new Button();
            prcBtn = new Button();
            divBtn = new Button();
            multBtn = new Button();
            subBtn = new Button();
            plusBtn = new Button();
            eqBtn = new Button();
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            BtnZero = new Button();
            decBtn = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 20F);
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(431, 101);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "";
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(12, 119);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(103, 53);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "AC";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += btnAC_Click;
            // 
            // polarBtn
            // 
            polarBtn.Location = new Point(132, 119);
            polarBtn.Name = "polarBtn";
            polarBtn.Size = new Size(99, 53);
            polarBtn.TabIndex = 2;
            polarBtn.Text = "+/-";
            polarBtn.UseVisualStyleBackColor = true;
            polarBtn.Click += btnPlusMinus_Click;
            // 
            // prcBtn
            // 
            prcBtn.Location = new Point(248, 119);
            prcBtn.Name = "prcBtn";
            prcBtn.Size = new Size(94, 53);
            prcBtn.TabIndex = 3;
            prcBtn.Text = "%";
            prcBtn.UseVisualStyleBackColor = true;
            prcBtn.Click += btnPercent_Click;
            // 
            // divBtn
            // 
            divBtn.Location = new Point(359, 119);
            divBtn.Name = "divBtn";
            divBtn.Size = new Size(84, 66);
            divBtn.TabIndex = 5;
            divBtn.Text = "/";
            divBtn.UseVisualStyleBackColor = true;
            divBtn.Click += Operator_Click;
            // 
            // multBtn
            // 
            multBtn.Location = new Point(359, 191);
            multBtn.Name = "multBtn";
            multBtn.Size = new Size(84, 66);
            multBtn.TabIndex = 6;
            multBtn.Text = "x";
            multBtn.UseVisualStyleBackColor = true;
            multBtn.Click += Operator_Click;
            // 
            // subBtn
            // 
            subBtn.Location = new Point(359, 263);
            subBtn.Name = "subBtn";
            subBtn.Size = new Size(84, 66);
            subBtn.TabIndex = 7;
            subBtn.Text = "-";
            subBtn.UseVisualStyleBackColor = true;
            subBtn.Click += Operator_Click;
            // 
            // plusBtn
            // 
            plusBtn.Location = new Point(359, 335);
            plusBtn.Name = "plusBtn";
            plusBtn.Size = new Size(84, 66);
            plusBtn.TabIndex = 8;
            plusBtn.Text = "+";
            plusBtn.UseVisualStyleBackColor = true;
            plusBtn.Click += Operator_Click;
            // 
            // eqBtn
            // 
            eqBtn.Location = new Point(359, 407);
            eqBtn.Name = "eqBtn";
            eqBtn.Size = new Size(84, 66);
            eqBtn.TabIndex = 9;
            eqBtn.Text = "=";
            eqBtn.UseVisualStyleBackColor = true;
            eqBtn.Click += btnEquals_Click;
            // 
            // btnSeven
            // 
            btnSeven.Location = new Point(12, 191);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(103, 66);
            btnSeven.TabIndex = 10;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += Number_Click;
            // 
            // btnEight
            // 
            btnEight.Location = new Point(132, 191);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(99, 66);
            btnEight.TabIndex = 11;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += Number_Click;
            // 
            // btnNine
            // 
            btnNine.Location = new Point(248, 191);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(94, 66);
            btnNine.TabIndex = 12;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += Number_Click;
            // 
            // btnFour
            // 
            btnFour.Location = new Point(12, 263);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(103, 66);
            btnFour.TabIndex = 13;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += Number_Click;
            // 
            // btnFive
            // 
            btnFive.Location = new Point(132, 263);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(99, 66);
            btnFive.TabIndex = 14;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += Number_Click;
            // 
            // btnSix
            // 
            btnSix.Location = new Point(248, 263);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(94, 66);
            btnSix.TabIndex = 15;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += Number_Click;
            // 
            // btnOne
            // 
            btnOne.Location = new Point(12, 335);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(103, 66);
            btnOne.TabIndex = 16;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += Number_Click;
            // 
            // btnTwo
            // 
            btnTwo.Location = new Point(132, 335);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(99, 66);
            btnTwo.TabIndex = 17;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += Number_Click;
            // 
            // btnThree
            // 
            btnThree.Location = new Point(248, 335);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(94, 66);
            btnThree.TabIndex = 18;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += Number_Click;
            // 
            // BtnZero
            // 
            BtnZero.Location = new Point(12, 407);
            BtnZero.Name = "BtnZero";
            BtnZero.Size = new Size(219, 66);
            BtnZero.TabIndex = 19;
            BtnZero.Text = "0";
            BtnZero.UseVisualStyleBackColor = true;
            // 
            // decBtn
            // 
            decBtn.Location = new Point(248, 407);
            decBtn.Name = "decBtn";
            decBtn.Size = new Size(94, 66);
            decBtn.TabIndex = 20;
            decBtn.Text = ".";
            decBtn.UseVisualStyleBackColor = true;
            decBtn.Click += btnDot_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 491);
            Controls.Add(decBtn);
            Controls.Add(BtnZero);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(eqBtn);
            Controls.Add(plusBtn);
            Controls.Add(subBtn);
            Controls.Add(multBtn);
            Controls.Add(divBtn);
            Controls.Add(prcBtn);
            Controls.Add(polarBtn);
            Controls.Add(clearBtn);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtDisplay;
        private Button clearBtn;
        private Button polarBtn;
        private Button prcBtn;
        private Button divBtn;
        private Button multBtn;
        private Button subBtn;
        private Button plusBtn;
        private Button eqBtn;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button BtnZero;
        private Button decBtn;
    }
}
