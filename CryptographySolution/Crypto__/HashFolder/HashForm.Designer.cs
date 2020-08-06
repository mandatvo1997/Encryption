namespace Crypto__.HashFolder
{
    partial class HashForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.btnHash = new System.Windows.Forms.Button();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "with length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Hash Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Input";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(103, 163);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(488, 20);
            this.txtLength.TabIndex = 22;
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(103, 60);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(158, 37);
            this.btnHash.TabIndex = 21;
            this.btnHash.Text = "Hash";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(101, 116);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(490, 20);
            this.txtHash.TabIndex = 20;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(100, 31);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(491, 20);
            this.txtInput.TabIndex = 19;
            // 
            // HashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 221);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.txtInput);
            this.Name = "HashForm";
            this.Text = "HashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.TextBox txtInput;
    }
}