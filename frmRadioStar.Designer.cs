
namespace RadioStarProjectWilliams
{
    partial class frmRadioStar
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnMod = new System.Windows.Forms.RadioButton();
            this.rbtnDivide = new System.Windows.Forms.RadioButton();
            this.rbtnMulti = new System.Windows.Forms.RadioButton();
            this.rbtnSubtract = new System.Windows.Forms.RadioButton();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.chckVer = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(414, 189);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 38);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(301, 189);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 38);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.BackColor = System.Drawing.Color.RosyBrown;
            this.lblLeft.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeft.Location = new System.Drawing.Point(26, 13);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(179, 23);
            this.lblLeft.TabIndex = 2;
            this.lblLeft.Text = "Left Operand:";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.BackColor = System.Drawing.Color.RosyBrown;
            this.lblRight.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRight.Location = new System.Drawing.Point(313, 13);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(192, 23);
            this.lblRight.TabIndex = 3;
            this.lblRight.Text = "Right Operand:";
            // 
            // txtLeft
            // 
            this.txtLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtLeft.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeft.Location = new System.Drawing.Point(17, 47);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(196, 29);
            this.txtLeft.TabIndex = 4;
            // 
            // txtRight
            // 
            this.txtRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtRight.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRight.Location = new System.Drawing.Point(311, 47);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(194, 29);
            this.txtRight.TabIndex = 5;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCalc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(19, 189);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(257, 38);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "C&alculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.BackColor = System.Drawing.Color.Salmon;
            this.lblAnswer.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(15, 267);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(492, 191);
            this.lblAnswer.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Tan;
            this.groupBox1.Controls.Add(this.rbtnMod);
            this.groupBox1.Controls.Add(this.rbtnDivide);
            this.groupBox1.Controls.Add(this.rbtnMulti);
            this.groupBox1.Controls.Add(this.rbtnSubtract);
            this.groupBox1.Controls.Add(this.rbtnAdd);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 97);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Math Operations Available";
            // 
            // rbtnMod
            // 
            this.rbtnMod.AutoSize = true;
            this.rbtnMod.Location = new System.Drawing.Point(329, 25);
            this.rbtnMod.Name = "rbtnMod";
            this.rbtnMod.Size = new System.Drawing.Size(136, 22);
            this.rbtnMod.TabIndex = 13;
            this.rbtnMod.TabStop = true;
            this.rbtnMod.Text = "Modulus (%)";
            this.rbtnMod.UseVisualStyleBackColor = true;
            this.rbtnMod.CheckedChanged += new System.EventHandler(this.rbtnMod_CheckedChanged);
            // 
            // rbtnDivide
            // 
            this.rbtnDivide.AutoSize = true;
            this.rbtnDivide.Location = new System.Drawing.Point(173, 56);
            this.rbtnDivide.Name = "rbtnDivide";
            this.rbtnDivide.Size = new System.Drawing.Size(126, 22);
            this.rbtnDivide.TabIndex = 12;
            this.rbtnDivide.TabStop = true;
            this.rbtnDivide.Text = "Divide (/)";
            this.rbtnDivide.UseVisualStyleBackColor = true;
            // 
            // rbtnMulti
            // 
            this.rbtnMulti.AutoSize = true;
            this.rbtnMulti.Location = new System.Drawing.Point(173, 25);
            this.rbtnMulti.Name = "rbtnMulti";
            this.rbtnMulti.Size = new System.Drawing.Size(146, 22);
            this.rbtnMulti.TabIndex = 11;
            this.rbtnMulti.TabStop = true;
            this.rbtnMulti.Text = "Multiply (x)";
            this.rbtnMulti.UseVisualStyleBackColor = true;
            // 
            // rbtnSubtract
            // 
            this.rbtnSubtract.AutoSize = true;
            this.rbtnSubtract.Location = new System.Drawing.Point(11, 56);
            this.rbtnSubtract.Name = "rbtnSubtract";
            this.rbtnSubtract.Size = new System.Drawing.Size(146, 22);
            this.rbtnSubtract.TabIndex = 10;
            this.rbtnSubtract.TabStop = true;
            this.rbtnSubtract.Text = "Subtract (-)";
            this.rbtnSubtract.UseVisualStyleBackColor = true;
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Location = new System.Drawing.Point(11, 25);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(96, 22);
            this.rbtnAdd.TabIndex = 9;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "Add (+)";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            this.rbtnAdd.CheckedChanged += new System.EventHandler(this.rbtnAdd_CheckedChanged);
            // 
            // chckVer
            // 
            this.chckVer.AutoSize = true;
            this.chckVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chckVer.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckVer.Location = new System.Drawing.Point(19, 233);
            this.chckVer.Name = "chckVer";
            this.chckVer.Size = new System.Drawing.Size(167, 22);
            this.chckVer.TabIndex = 14;
            this.chckVer.Text = "Verbose On/Off";
            this.chckVer.UseVisualStyleBackColor = false;
            this.chckVer.CheckedChanged += new System.EventHandler(this.chckVer_CheckedChanged);
            // 
            // frmRadioStar
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(521, 476);
            this.Controls.Add(this.chckVer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Name = "frmRadioStar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radio Buttons In Action";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnMod;
        private System.Windows.Forms.RadioButton rbtnDivide;
        private System.Windows.Forms.RadioButton rbtnMulti;
        private System.Windows.Forms.RadioButton rbtnSubtract;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.CheckBox chckVer;
    }
}

