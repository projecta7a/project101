namespace Project_101
{
    partial class menu
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
            this.btnmax = new System.Windows.Forms.Button();
            this.btnmins = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldisplaychk = new System.Windows.Forms.Label();
            this.txtadd1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnmax
            // 
            this.btnmax.Location = new System.Drawing.Point(174, 267);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(24, 23);
            this.btnmax.TabIndex = 0;
            this.btnmax.Text = "+";
            this.btnmax.UseVisualStyleBackColor = true;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // btnmins
            // 
            this.btnmins.Location = new System.Drawing.Point(101, 267);
            this.btnmins.Name = "btnmins";
            this.btnmins.Size = new System.Drawing.Size(26, 23);
            this.btnmins.TabIndex = 1;
            this.btnmins.Text = "-";
            this.btnmins.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "total check";
            // 
            // lbldisplaychk
            // 
            this.lbldisplaychk.AutoSize = true;
            this.lbldisplaychk.Location = new System.Drawing.Point(423, 341);
            this.lbldisplaychk.Name = "lbldisplaychk";
            this.lbldisplaychk.Size = new System.Drawing.Size(56, 13);
            this.lbldisplaychk.TabIndex = 4;
            this.lbldisplaychk.Text = "yourcheck";
            this.lbldisplaychk.Click += new System.EventHandler(this.lbldisplaychk_Click);
            // 
            // txtadd1
            // 
            this.txtadd1.Location = new System.Drawing.Point(145, 269);
            this.txtadd1.Name = "txtadd1";
            this.txtadd1.Size = new System.Drawing.Size(13, 20);
            this.txtadd1.TabIndex = 5;
            this.txtadd1.Text = "0";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 477);
            this.Controls.Add(this.txtadd1);
            this.Controls.Add(this.lbldisplaychk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmins);
            this.Controls.Add(this.btnmax);
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmax;
        private System.Windows.Forms.Button btnmins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldisplaychk;
        private System.Windows.Forms.TextBox txtadd1;
    }
}