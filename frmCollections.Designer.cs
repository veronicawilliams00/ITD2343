
namespace frmCollections
{
    partial class frmCollections
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
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCalc = new System.Windows.Forms.Label();
            this.lblCollect = new System.Windows.Forms.Label();
            this.lblStat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Courier New", 14F);
            this.btnExit.Location = new System.Drawing.Point(461, 458);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 42);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReset.Font = new System.Drawing.Font("Courier New", 14F);
            this.btnReset.Location = new System.Drawing.Point(461, 410);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 42);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "R&eset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNum
            // 
            this.lblNum.BackColor = System.Drawing.Color.Aquamarine;
            this.lblNum.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.ForeColor = System.Drawing.Color.Black;
            this.lblNum.Location = new System.Drawing.Point(65, 12);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(189, 37);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "Number Value:";
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(260, 17);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(151, 29);
            this.txtNum.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Plum;
            this.btnAdd.Font = new System.Drawing.Font("Courier New", 14F);
            this.btnAdd.Location = new System.Drawing.Point(461, 104);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 42);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Plum;
            this.btnView.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(461, 152);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(98, 42);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "&View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.LightPink;
            this.lblResult.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblResult.Location = new System.Drawing.Point(18, 104);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(238, 396);
            this.lblResult.TabIndex = 6;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCalc
            // 
            this.lblCalc.BackColor = System.Drawing.Color.Thistle;
            this.lblCalc.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblCalc.Location = new System.Drawing.Point(271, 104);
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(184, 396);
            this.lblCalc.TabIndex = 7;
            this.lblCalc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCalc.Click += new System.EventHandler(this.lblCalc_Click);
            // 
            // lblCollect
            // 
            this.lblCollect.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblCollect.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollect.ForeColor = System.Drawing.Color.Black;
            this.lblCollect.Location = new System.Drawing.Point(17, 57);
            this.lblCollect.Name = "lblCollect";
            this.lblCollect.Size = new System.Drawing.Size(239, 37);
            this.lblCollect.TabIndex = 8;
            this.lblCollect.Text = "Collection:";
            this.lblCollect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStat
            // 
            this.lblStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblStat.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStat.ForeColor = System.Drawing.Color.Black;
            this.lblStat.Location = new System.Drawing.Point(270, 57);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(185, 37);
            this.lblStat.TabIndex = 9;
            this.lblStat.Text = "Statistics:";
            this.lblStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCollections
            // 
            this.AcceptButton = this.btnReset;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(571, 518);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.lblCollect);
            this.Controls.Add(this.lblCalc);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Name = "frmCollections";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collection Lab";
            this.Load += new System.EventHandler(this.frmCollections_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblCalc;
        private System.Windows.Forms.Label lblCollect;
        private System.Windows.Forms.Label lblStat;
    }
}

