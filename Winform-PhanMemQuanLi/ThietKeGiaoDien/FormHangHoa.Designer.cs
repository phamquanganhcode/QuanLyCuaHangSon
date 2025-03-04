namespace ThietKeGiaoDien
{
    partial class FormHangHoa
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cl_tenMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_phanLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_maMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_donVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_Gia = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(790, 19);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 35);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tìm kiếm:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cl_tenMatHang,
            this.Cl_hang,
            this.Cl_phanLoai,
            this.Cl_maMau,
            this.Cl_donVi,
            this.Cl_soLuong,
            this.Cl_Gia});
            this.dataGridView1.Location = new System.Drawing.Point(27, 134);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 699);
            this.dataGridView1.TabIndex = 12;
            // 
            // Cl_tenMatHang
            // 
            this.Cl_tenMatHang.HeaderText = "Tên mặt hàng";
            this.Cl_tenMatHang.MinimumWidth = 6;
            this.Cl_tenMatHang.Name = "Cl_tenMatHang";
            // 
            // Cl_hang
            // 
            this.Cl_hang.HeaderText = "Hãng";
            this.Cl_hang.MinimumWidth = 6;
            this.Cl_hang.Name = "Cl_hang";
            // 
            // Cl_phanLoai
            // 
            this.Cl_phanLoai.HeaderText = "Phân loại";
            this.Cl_phanLoai.MinimumWidth = 6;
            this.Cl_phanLoai.Name = "Cl_phanLoai";
            // 
            // Cl_maMau
            // 
            this.Cl_maMau.HeaderText = "Mã màu";
            this.Cl_maMau.MinimumWidth = 6;
            this.Cl_maMau.Name = "Cl_maMau";
            // 
            // Cl_donVi
            // 
            this.Cl_donVi.HeaderText = "Đơn vị";
            this.Cl_donVi.MinimumWidth = 6;
            this.Cl_donVi.Name = "Cl_donVi";
            // 
            // Cl_soLuong
            // 
            this.Cl_soLuong.HeaderText = "Số lượng";
            this.Cl_soLuong.MinimumWidth = 6;
            this.Cl_soLuong.Name = "Cl_soLuong";
            // 
            // Cl_Gia
            // 
            this.Cl_Gia.HeaderText = "Giá bán";
            this.Cl_Gia.MinimumWidth = 6;
            this.Cl_Gia.Name = "Cl_Gia";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(27, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(548, 57);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(277, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Nhập kho";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Xuất kho";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.Location = new System.Drawing.Point(432, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(477, 50);
            this.button3.TabIndex = 14;
            this.button3.Text = "Thêm hàng hóa";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 853);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.button3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FormHangHoa";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "FormHangHoa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_tenMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_hang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_phanLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_maMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_donVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_soLuong;
        private System.Windows.Forms.DataGridViewButtonColumn Cl_Gia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}