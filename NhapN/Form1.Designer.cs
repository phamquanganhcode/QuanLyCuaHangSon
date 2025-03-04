namespace NhapN
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
            label1 = new Label();
            tbSoN = new TextBox();
            btHienthi = new Button();
            lbsoCP = new Label();
            lbsoNgto = new Label();
            lbsoHh = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 72);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập số N:";
            // 
            // tbSoN
            // 
            tbSoN.Location = new Point(129, 69);
            tbSoN.Margin = new Padding(4);
            tbSoN.Name = "tbSoN";
            tbSoN.Size = new Size(411, 27);
            tbSoN.TabIndex = 1;
            tbSoN.KeyDown += tbSoN_KeyDown;
            // 
            // btHienthi
            // 
            btHienthi.BackColor = SystemColors.ActiveCaption;
            btHienthi.Location = new Point(640, 72);
            btHienthi.Margin = new Padding(4);
            btHienthi.Name = "btHienthi";
            btHienthi.Size = new Size(117, 36);
            btHienthi.TabIndex = 2;
            btHienthi.Text = "Hiển thị";
            btHienthi.UseVisualStyleBackColor = false;
            btHienthi.Click += btHienthi_Click;
            // 
            // lbsoCP
            // 
            lbsoCP.AutoSize = true;
            lbsoCP.Location = new Point(47, 296);
            lbsoCP.Margin = new Padding(4, 0, 4, 0);
            lbsoCP.Name = "lbsoCP";
            lbsoCP.Size = new Size(227, 20);
            lbsoCP.TabIndex = 3;
            lbsoCP.Text = "Các số chính phương nhỏ hơn N: ";
            // 
            // lbsoNgto
            // 
            lbsoNgto.AutoSize = true;
            lbsoNgto.Location = new Point(47, 229);
            lbsoNgto.Margin = new Padding(4, 0, 4, 0);
            lbsoNgto.Name = "lbsoNgto";
            lbsoNgto.Size = new Size(202, 20);
            lbsoNgto.TabIndex = 4;
            lbsoNgto.Text = "Các số nguyên tố nhỏ hơn N: ";
            // 
            // lbsoHh
            // 
            lbsoHh.AutoSize = true;
            lbsoHh.Location = new Point(47, 370);
            lbsoHh.Margin = new Padding(4, 0, 4, 0);
            lbsoHh.Name = "lbsoHh";
            lbsoHh.Size = new Size(198, 20);
            lbsoHh.TabIndex = 5;
            lbsoHh.Text = "Các số hoàn hảo nhỏ hơn N: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(lbsoHh);
            Controls.Add(lbsoNgto);
            Controls.Add(lbsoCP);
            Controls.Add(btHienthi);
            Controls.Add(tbSoN);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Pham Quang Anh";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbSoN;
        private Button btHienthi;
        private Label lbsoCP;
        private Label lbsoNgto;
        private Label lbsoHh;
    }
}
