namespace Crypto__.DigitalSignatureFolder
{
    partial class DSForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKey = new System.Windows.Forms.Button();
            this.txtprivate = new System.Windows.Forms.TextBox();
            this.txtpublic = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.txtSign = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Input File";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(126, 178);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(394, 20);
            this.txtInput.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Private key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Public key";
            // 
            // btnKey
            // 
            this.btnKey.Location = new System.Drawing.Point(126, 13);
            this.btnKey.Name = "btnKey";
            this.btnKey.Size = new System.Drawing.Size(134, 23);
            this.btnKey.TabIndex = 32;
            this.btnKey.Text = "Generate key pair";
            this.btnKey.UseVisualStyleBackColor = true;
            this.btnKey.Click += new System.EventHandler(this.btnKey_Click);
            // 
            // txtprivate
            // 
            this.txtprivate.Location = new System.Drawing.Point(126, 111);
            this.txtprivate.Name = "txtprivate";
            this.txtprivate.Size = new System.Drawing.Size(288, 20);
            this.txtprivate.TabIndex = 31;
            // 
            // txtpublic
            // 
            this.txtpublic.Location = new System.Drawing.Point(126, 56);
            this.txtpublic.Name = "txtpublic";
            this.txtpublic.Size = new System.Drawing.Size(288, 20);
            this.txtpublic.TabIndex = 30;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(527, 170);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 37;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(126, 227);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(75, 23);
            this.btnSign.TabIndex = 38;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(228, 227);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 39;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // txtSign
            // 
            this.txtSign.Location = new System.Drawing.Point(126, 281);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(394, 20);
            this.txtSign.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Signed File";
            // 
            // DSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 365);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSign);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKey);
            this.Controls.Add(this.txtprivate);
            this.Controls.Add(this.txtpublic);
            this.Name = "DSForm";
            this.Text = "DSForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKey;
        private System.Windows.Forms.TextBox txtprivate;
        private System.Windows.Forms.TextBox txtpublic;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox txtSign;
        private System.Windows.Forms.Label label3;
    }
}