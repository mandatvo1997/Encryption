namespace Symmetric_Encryption
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
            this.txtDecrypt = new System.Windows.Forms.TextBox();
            this.txtEncrypt = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.abtnDecrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.abtnEncrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecrypt.Location = new System.Drawing.Point(159, 239);
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.ReadOnly = true;
            this.txtDecrypt.Size = new System.Drawing.Size(468, 26);
            this.txtDecrypt.TabIndex = 19;
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncrypt.Location = new System.Drawing.Point(159, 164);
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.ReadOnly = true;
            this.txtEncrypt.Size = new System.Drawing.Size(468, 26);
            this.txtEncrypt.TabIndex = 18;
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(159, 89);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(468, 26);
            this.txtKey.TabIndex = 17;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(159, 37);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(468, 26);
            this.txtInput.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Decrypt messange";
            // 
            // abtnDecrypt
            // 
            this.abtnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abtnDecrypt.Location = new System.Drawing.Point(236, 196);
            this.abtnDecrypt.Name = "abtnDecrypt";
            this.abtnDecrypt.Size = new System.Drawing.Size(81, 37);
            this.abtnDecrypt.TabIndex = 14;
            this.abtnDecrypt.Text = "Decrypt";
            this.abtnDecrypt.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Encrypt messange";
            // 
            // abtnEncrypt
            // 
            this.abtnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abtnEncrypt.Location = new System.Drawing.Point(236, 121);
            this.abtnEncrypt.Name = "abtnEncrypt";
            this.abtnEncrypt.Size = new System.Drawing.Size(81, 37);
            this.abtnEncrypt.TabIndex = 12;
            this.abtnEncrypt.Text = "Encrypt";
            this.abtnEncrypt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Input secrect key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Input messanger";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 304);
            this.Controls.Add(this.txtDecrypt);
            this.Controls.Add(this.txtEncrypt);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.abtnDecrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.abtnEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDecrypt;
        private System.Windows.Forms.TextBox txtEncrypt;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button abtnDecrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button abtnEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

