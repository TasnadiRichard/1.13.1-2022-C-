namespace Formsfeladat1
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
            this.Bt_BF = new System.Windows.Forms.Button();
            this.Bt_JF = new System.Windows.Forms.Button();
            this.Bt_BL = new System.Windows.Forms.Button();
            this.Bt_JL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bt_BF
            // 
            this.Bt_BF.Location = new System.Drawing.Point(161, 137);
            this.Bt_BF.Name = "Bt_BF";
            this.Bt_BF.Size = new System.Drawing.Size(75, 23);
            this.Bt_BF.TabIndex = 0;
            this.Bt_BF.Text = "Balra, fel";
            this.Bt_BF.UseVisualStyleBackColor = true;
            this.Bt_BF.Click += new System.EventHandler(this.Bt_BF_Click);
            // 
            // Bt_JF
            // 
            this.Bt_JF.Location = new System.Drawing.Point(555, 137);
            this.Bt_JF.Name = "Bt_JF";
            this.Bt_JF.Size = new System.Drawing.Size(75, 23);
            this.Bt_JF.TabIndex = 1;
            this.Bt_JF.Text = "Jobbra, fel";
            this.Bt_JF.UseVisualStyleBackColor = true;
            this.Bt_JF.Click += new System.EventHandler(this.Bt_JF_Click);
            // 
            // Bt_BL
            // 
            this.Bt_BL.Location = new System.Drawing.Point(161, 278);
            this.Bt_BL.Name = "Bt_BL";
            this.Bt_BL.Size = new System.Drawing.Size(75, 23);
            this.Bt_BL.TabIndex = 2;
            this.Bt_BL.Text = "Balra, le";
            this.Bt_BL.UseVisualStyleBackColor = true;
            this.Bt_BL.Click += new System.EventHandler(this.Bt_BL_Click);
            // 
            // Bt_JL
            // 
            this.Bt_JL.Location = new System.Drawing.Point(545, 278);
            this.Bt_JL.Name = "Bt_JL";
            this.Bt_JL.Size = new System.Drawing.Size(75, 23);
            this.Bt_JL.TabIndex = 3;
            this.Bt_JL.Text = "Jobbra, le";
            this.Bt_JL.UseVisualStyleBackColor = true;
            this.Bt_JL.Click += new System.EventHandler(this.Bt_JL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bt_JL);
            this.Controls.Add(this.Bt_BL);
            this.Controls.Add(this.Bt_JF);
            this.Controls.Add(this.Bt_BF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Bt_BF;
        private Button Bt_JF;
        private Button Bt_BL;
        private Button Bt_JL;
    }
}