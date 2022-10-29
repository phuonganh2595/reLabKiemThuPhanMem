namespace Calculator
{
    partial class FCalculator
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
            this.lbA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lbB = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.lbKQ = new System.Windows.Forms.Label();
            this.btCong = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(36, 48);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(33, 13);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "Số A:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(92, 41);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(156, 20);
            this.txtA.TabIndex = 1;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(92, 90);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(156, 20);
            this.txtB.TabIndex = 3;
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(36, 97);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(33, 13);
            this.lbB.TabIndex = 2;
            this.lbB.Text = "Số B:";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(92, 141);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(156, 20);
            this.txtKQ.TabIndex = 5;
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Location = new System.Drawing.Point(36, 148);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(47, 13);
            this.lbKQ.TabIndex = 4;
            this.lbKQ.Text = "Kết quả:";
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(25, 197);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(75, 23);
            this.btCong.TabIndex = 6;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            // 
            // btTru
            // 
            this.btTru.Location = new System.Drawing.Point(148, 197);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(75, 23);
            this.btTru.TabIndex = 7;
            this.btTru.Text = "Trừ";
            this.btTru.UseVisualStyleBackColor = true;
            // 
            // FCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbA);
            this.Name = "FCalculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btTru;
    }
}

