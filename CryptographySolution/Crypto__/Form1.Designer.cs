namespace Crypto__
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
            this.btnHash = new System.Windows.Forms.Button();
            this.btnSym = new System.Windows.Forms.Button();
            this.btnAsym = new System.Windows.Forms.Button();
            this.btnDS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(71, 57);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(123, 47);
            this.btnHash.TabIndex = 0;
            this.btnHash.Text = "Hash";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // btnSym
            // 
            this.btnSym.Location = new System.Drawing.Point(216, 57);
            this.btnSym.Name = "btnSym";
            this.btnSym.Size = new System.Drawing.Size(123, 47);
            this.btnSym.TabIndex = 0;
            this.btnSym.Text = "Symmetric";
            this.btnSym.UseVisualStyleBackColor = true;
            this.btnSym.Click += new System.EventHandler(this.btnSym_Click);
            // 
            // btnAsym
            // 
            this.btnAsym.Location = new System.Drawing.Point(71, 128);
            this.btnAsym.Name = "btnAsym";
            this.btnAsym.Size = new System.Drawing.Size(123, 47);
            this.btnAsym.TabIndex = 0;
            this.btnAsym.Text = "Asymmetric";
            this.btnAsym.UseVisualStyleBackColor = true;
            this.btnAsym.Click += new System.EventHandler(this.btnAsym_Click);
            // 
            // btnDS
            // 
            this.btnDS.Location = new System.Drawing.Point(216, 128);
            this.btnDS.Name = "btnDS";
            this.btnDS.Size = new System.Drawing.Size(123, 47);
            this.btnDS.TabIndex = 0;
            this.btnDS.Text = "Digital Signature";
            this.btnDS.UseVisualStyleBackColor = true;
            this.btnDS.Click += new System.EventHandler(this.btnDS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 261);
            this.Controls.Add(this.btnDS);
            this.Controls.Add(this.btnAsym);
            this.Controls.Add(this.btnSym);
            this.Controls.Add(this.btnHash);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Button btnSym;
        private System.Windows.Forms.Button btnAsym;
        private System.Windows.Forms.Button btnDS;
    }
}

