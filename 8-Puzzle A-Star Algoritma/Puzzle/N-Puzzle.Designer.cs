﻿namespace _8_Puzzle_A_Star_Algoritma
{
    partial class N_Puzzle
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.square1 = new _8_Puzzle_A_Star_Algoritma.Square();
            this.square2 = new _8_Puzzle_A_Star_Algoritma.Square();
            this.square3 = new _8_Puzzle_A_Star_Algoritma.Square();
            this.square4 = new _8_Puzzle_A_Star_Algoritma.Square();
            this.square6 = new _8_Puzzle_A_Star_Algoritma.Square();
            this.square7 = new _8_Puzzle_A_Star_Algoritma.Square();
            this.square8 = new _8_Puzzle_A_Star_Algoritma.Square();
            this.square5 = new _8_Puzzle_A_Star_Algoritma.Square();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.square1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.square2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.square3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.square4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.square6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.square7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.square8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.square5, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(291, 272);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // square1
            // 
            this.square1.Color = System.Drawing.Color.Empty;
            this.square1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square1.Location = new System.Drawing.Point(5, 5);
            this.square1.Margin = new System.Windows.Forms.Padding(5);
            this.square1.Name = "square1";
            this.square1.Number = 1;
            this.square1.Size = new System.Drawing.Size(87, 80);
            this.square1.TabIndex = 0;
            this.square1.Click += new System.EventHandler(this.BoxClick_Event);
            // 
            // square2
            // 
            this.square2.Color = System.Drawing.Color.Empty;
            this.square2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square2.Location = new System.Drawing.Point(102, 5);
            this.square2.Margin = new System.Windows.Forms.Padding(5);
            this.square2.Name = "square2";
            this.square2.Number = 2;
            this.square2.Size = new System.Drawing.Size(87, 80);
            this.square2.TabIndex = 0;
            this.square2.Click += new System.EventHandler(this.BoxClick_Event);
            // 
            // square3
            // 
            this.square3.Color = System.Drawing.Color.Empty;
            this.square3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square3.Location = new System.Drawing.Point(199, 5);
            this.square3.Margin = new System.Windows.Forms.Padding(5);
            this.square3.Name = "square3";
            this.square3.Number = 3;
            this.square3.Size = new System.Drawing.Size(87, 80);
            this.square3.TabIndex = 0;
            this.square3.Click += new System.EventHandler(this.BoxClick_Event);
            // 
            // square4
            // 
            this.square4.Color = System.Drawing.Color.Empty;
            this.square4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square4.Location = new System.Drawing.Point(5, 95);
            this.square4.Margin = new System.Windows.Forms.Padding(5);
            this.square4.Name = "square4";
            this.square4.Number = 4;
            this.square4.Size = new System.Drawing.Size(87, 80);
            this.square4.TabIndex = 0;
            this.square4.Click += new System.EventHandler(this.BoxClick_Event);
            // 
            // square6
            // 
            this.square6.Color = System.Drawing.Color.Empty;
            this.square6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square6.Location = new System.Drawing.Point(199, 95);
            this.square6.Margin = new System.Windows.Forms.Padding(5);
            this.square6.Name = "square6";
            this.square6.Number = 6;
            this.square6.Size = new System.Drawing.Size(87, 80);
            this.square6.TabIndex = 0;
            this.square6.Click += new System.EventHandler(this.BoxClick_Event);
            // 
            // square7
            // 
            this.square7.Color = System.Drawing.Color.Empty;
            this.square7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square7.Location = new System.Drawing.Point(5, 185);
            this.square7.Margin = new System.Windows.Forms.Padding(5);
            this.square7.Name = "square7";
            this.square7.Number = 7;
            this.square7.Size = new System.Drawing.Size(87, 82);
            this.square7.TabIndex = 0;
            this.square7.Click += new System.EventHandler(this.BoxClick_Event);
            // 
            // square8
            // 
            this.square8.Color = System.Drawing.Color.Empty;
            this.square8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square8.Location = new System.Drawing.Point(102, 185);
            this.square8.Margin = new System.Windows.Forms.Padding(5);
            this.square8.Name = "square8";
            this.square8.Number = 8;
            this.square8.Size = new System.Drawing.Size(87, 82);
            this.square8.TabIndex = 0;
            this.square8.Load += new System.EventHandler(this.square8_Load);
            this.square8.Click += new System.EventHandler(this.BoxClick_Event);
            // 
            // square5
            // 
            this.square5.Color = System.Drawing.Color.Empty;
            this.square5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square5.Location = new System.Drawing.Point(102, 95);
            this.square5.Margin = new System.Windows.Forms.Padding(5);
            this.square5.Name = "square5";
            this.square5.Number = 5;
            this.square5.Size = new System.Drawing.Size(87, 80);
            this.square5.TabIndex = 0;
            this.square5.Load += new System.EventHandler(this.square5_Load);
            this.square5.Click += new System.EventHandler(this.BoxClick_Event);
            // 
            // N_Puzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "N_Puzzle";
            this.Size = new System.Drawing.Size(291, 272);
            this.Load += new System.EventHandler(this.N_Puzzle_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Square square1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Square square2;
        private Square square3;
        private Square square4;
        private Square square5;
        private Square square6;
        private Square square7;
        private Square square8;
    }
}
