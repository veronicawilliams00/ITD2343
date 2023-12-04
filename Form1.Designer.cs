
namespace Exam2WilliamsProject
{
    partial class Form1
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
            this.btnModS = new System.Windows.Forms.Button();
            this.btnFactS = new System.Windows.Forms.Button();
            this.btnFibS = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.btnModD = new System.Windows.Forms.Button();
            this.btnFactD = new System.Windows.Forms.Button();
            this.btnFibD = new System.Windows.Forms.Button();
            this.lblOp1 = new System.Windows.Forms.Label();
            this.lblOp2 = new System.Windows.Forms.Label();
            this.txtOp1 = new System.Windows.Forms.TextBox();
            this.txtOp2 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModS
            // 
            this.btnModS.BackColor = System.Drawing.Color.RosyBrown;
            this.btnModS.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModS.Location = new System.Drawing.Point(89, 104);
            this.btnModS.Name = "btnModS";
            this.btnModS.Size = new System.Drawing.Size(134, 38);
            this.btnModS.TabIndex = 0;
            this.btnModS.Text = "Mod";
            this.btnModS.UseVisualStyleBackColor = false;
            this.btnModS.Click += new System.EventHandler(this.btnModS_Click);
            // 
            // btnFactS
            // 
            this.btnFactS.BackColor = System.Drawing.Color.RosyBrown;
            this.btnFactS.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactS.Location = new System.Drawing.Point(245, 104);
            this.btnFactS.Name = "btnFactS";
            this.btnFactS.Size = new System.Drawing.Size(134, 38);
            this.btnFactS.TabIndex = 1;
            this.btnFactS.Text = "Factorial";
            this.btnFactS.UseVisualStyleBackColor = false;
            this.btnFactS.Click += new System.EventHandler(this.btnFactS_Click);
            // 
            // btnFibS
            // 
            this.btnFibS.BackColor = System.Drawing.Color.RosyBrown;
            this.btnFibS.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFibS.Location = new System.Drawing.Point(403, 104);
            this.btnFibS.Name = "btnFibS";
            this.btnFibS.Size = new System.Drawing.Size(134, 38);
            this.btnFibS.TabIndex = 2;
            this.btnFibS.Text = "Fibonacci";
            this.btnFibS.UseVisualStyleBackColor = false;
            this.btnFibS.Click += new System.EventHandler(this.btnFibS_Click);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow.Location = new System.Drawing.Point(12, 109);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(71, 27);
            this.lblShow.TabIndex = 3;
            this.lblShow.Text = "Show:";
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDo.Location = new System.Drawing.Point(27, 153);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(47, 27);
            this.lblDo.TabIndex = 4;
            this.lblDo.Text = "Do:";
            // 
            // btnModD
            // 
            this.btnModD.BackColor = System.Drawing.Color.RosyBrown;
            this.btnModD.Enabled = false;
            this.btnModD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModD.Location = new System.Drawing.Point(89, 148);
            this.btnModD.Name = "btnModD";
            this.btnModD.Size = new System.Drawing.Size(134, 38);
            this.btnModD.TabIndex = 5;
            this.btnModD.Text = "&Mod";
            this.btnModD.UseVisualStyleBackColor = false;
            this.btnModD.Click += new System.EventHandler(this.btnModD_Click);
            // 
            // btnFactD
            // 
            this.btnFactD.BackColor = System.Drawing.Color.RosyBrown;
            this.btnFactD.Enabled = false;
            this.btnFactD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactD.Location = new System.Drawing.Point(245, 148);
            this.btnFactD.Name = "btnFactD";
            this.btnFactD.Size = new System.Drawing.Size(134, 38);
            this.btnFactD.TabIndex = 6;
            this.btnFactD.Text = "F&actorial";
            this.btnFactD.UseVisualStyleBackColor = false;
            this.btnFactD.Click += new System.EventHandler(this.btnFactD_Click);
            // 
            // btnFibD
            // 
            this.btnFibD.BackColor = System.Drawing.Color.RosyBrown;
            this.btnFibD.Enabled = false;
            this.btnFibD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFibD.Location = new System.Drawing.Point(403, 148);
            this.btnFibD.Name = "btnFibD";
            this.btnFibD.Size = new System.Drawing.Size(134, 38);
            this.btnFibD.TabIndex = 7;
            this.btnFibD.Text = "Fi&bonacci";
            this.btnFibD.UseVisualStyleBackColor = false;
            this.btnFibD.Click += new System.EventHandler(this.btnFibD_Click);
            // 
            // lblOp1
            // 
            this.lblOp1.AutoSize = true;
            this.lblOp1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp1.Location = new System.Drawing.Point(12, 12);
            this.lblOp1.Name = "lblOp1";
            this.lblOp1.Size = new System.Drawing.Size(119, 27);
            this.lblOp1.TabIndex = 8;
            this.lblOp1.Text = "Operand 1:";
            // 
            // lblOp2
            // 
            this.lblOp2.AutoSize = true;
            this.lblOp2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp2.Location = new System.Drawing.Point(12, 63);
            this.lblOp2.Name = "lblOp2";
            this.lblOp2.Size = new System.Drawing.Size(119, 27);
            this.lblOp2.TabIndex = 9;
            this.lblOp2.Text = "Operand 2:";
            // 
            // txtOp1
            // 
            this.txtOp1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOp1.Location = new System.Drawing.Point(137, 12);
            this.txtOp1.Name = "txtOp1";
            this.txtOp1.Size = new System.Drawing.Size(242, 29);
            this.txtOp1.TabIndex = 10;
            // 
            // txtOp2
            // 
            this.txtOp2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOp2.Location = new System.Drawing.Point(137, 59);
            this.txtOp2.Name = "txtOp2";
            this.txtOp2.Size = new System.Drawing.Size(242, 29);
            this.txtOp2.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSalmon;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(403, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 38);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSalmon;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(403, 52);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 38);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(17, 204);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(520, 227);
            this.lblMessage.TabIndex = 14;
            this.lblMessage.Text = "Clear Button Clears Message Only";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtOp2);
            this.Controls.Add(this.txtOp1);
            this.Controls.Add(this.lblOp2);
            this.Controls.Add(this.lblOp1);
            this.Controls.Add(this.btnFibD);
            this.Controls.Add(this.btnFactD);
            this.Controls.Add(this.btnModD);
            this.Controls.Add(this.lblDo);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnFibS);
            this.Controls.Add(this.btnFactS);
            this.Controls.Add(this.btnModS);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operations Veronica Williams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModS;
        private System.Windows.Forms.Button btnFactS;
        private System.Windows.Forms.Button btnFibS;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.Button btnModD;
        private System.Windows.Forms.Button btnFactD;
        private System.Windows.Forms.Button btnFibD;
        private System.Windows.Forms.Label lblOp1;
        private System.Windows.Forms.Label lblOp2;
        private System.Windows.Forms.TextBox txtOp1;
        private System.Windows.Forms.TextBox txtOp2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessage;
    }
}

