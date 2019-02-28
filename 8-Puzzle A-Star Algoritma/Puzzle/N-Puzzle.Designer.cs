namespace _8_Puzzle_A_Star_Algoritma
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.square1 = new _8_Puzzle_A_Star_Algoritma.Square();
            this.square2 = new _8_Puzzle_A_Star_Algoritma.Square();
            this.square3 = new _8_Puzzle_A_Star_Algoritma.Square();
            this.square4 = new _8_Puzzle_A_Star_Algoritma.Square();
            this.square6 = new _8_Puzzle_A_Star_Algoritma.Square();
            this.square7 = new _8_Puzzle_A_Star_Algoritma.Square();
            this.square8 = new _8_Puzzle_A_Star_Algoritma.Square();
            this.square5 = new _8_Puzzle_A_Star_Algoritma.Square();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(313, 337);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = global::_8_Puzzle_A_Star_Algoritma.Properties.Resources.a;
            this.pictureBox5.Location = new System.Drawing.Point(0, 302);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(313, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.948453F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.80412F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.453609F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(313, 269);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::_8_Puzzle_A_Star_Algoritma.Properties.Resources.so;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 269);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::_8_Puzzle_A_Star_Algoritma.Properties.Resources.sol;
            this.pictureBox3.Location = new System.Drawing.Point(286, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 269);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(15, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 269);
            this.panel1.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Wheat;
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(271, 269);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // square1
            // 
            this.square1.BorderColor = System.Drawing.Color.Gray;
            this.square1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square1.Location = new System.Drawing.Point(5, 5);
            this.square1.Margin = new System.Windows.Forms.Padding(5);
            this.square1.Name = "square1";
            this.square1.Number = 1;
            this.square1.Size = new System.Drawing.Size(80, 79);
            this.square1.TabIndex = 0;
            this.square1.Click += new System.EventHandler(this.BoxClick_Event);
            // 
            // square2
            // 
            this.square2.BorderColor = System.Drawing.Color.Gray;
            this.square2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square2.Location = new System.Drawing.Point(95, 5);
            this.square2.Margin = new System.Windows.Forms.Padding(5);
            this.square2.Name = "square2";
            this.square2.Number = 2;
            this.square2.Size = new System.Drawing.Size(80, 79);
            this.square2.TabIndex = 0;
            this.square2.Click += new System.EventHandler(this.BoxClick_Event);
            // 
            // square3
            // 
            this.square3.BorderColor = System.Drawing.Color.Gray;
            this.square3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square3.Location = new System.Drawing.Point(185, 5);
            this.square3.Margin = new System.Windows.Forms.Padding(5);
            this.square3.Name = "square3";
            this.square3.Number = 3;
            this.square3.Size = new System.Drawing.Size(81, 79);
            this.square3.TabIndex = 0;
            this.square3.Click += new System.EventHandler(this.BoxClick_Event);
            // 
            // square4
            // 
            this.square4.BorderColor = System.Drawing.Color.Gray;
            this.square4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square4.Location = new System.Drawing.Point(5, 94);
            this.square4.Margin = new System.Windows.Forms.Padding(5);
            this.square4.Name = "square4";
            this.square4.Number = 4;
            this.square4.Size = new System.Drawing.Size(80, 79);
            this.square4.TabIndex = 0;
            this.square4.Click += new System.EventHandler(this.BoxClick_Event);
            // 
            // square6
            // 
            this.square6.BorderColor = System.Drawing.Color.Gray;
            this.square6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square6.Location = new System.Drawing.Point(185, 94);
            this.square6.Margin = new System.Windows.Forms.Padding(5);
            this.square6.Name = "square6";
            this.square6.Number = 6;
            this.square6.Size = new System.Drawing.Size(81, 79);
            this.square6.TabIndex = 0;
            this.square6.Click += new System.EventHandler(this.BoxClick_Event);
            // 
            // square7
            // 
            this.square7.BorderColor = System.Drawing.Color.Gray;
            this.square7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square7.Location = new System.Drawing.Point(5, 183);
            this.square7.Margin = new System.Windows.Forms.Padding(5);
            this.square7.Name = "square7";
            this.square7.Number = 7;
            this.square7.Size = new System.Drawing.Size(80, 81);
            this.square7.TabIndex = 0;
            this.square7.Click += new System.EventHandler(this.BoxClick_Event);
            // 
            // square8
            // 
            this.square8.BorderColor = System.Drawing.Color.Gray;
            this.square8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square8.Location = new System.Drawing.Point(95, 183);
            this.square8.Margin = new System.Windows.Forms.Padding(5);
            this.square8.Name = "square8";
            this.square8.Number = 8;
            this.square8.Size = new System.Drawing.Size(80, 81);
            this.square8.TabIndex = 0;
            this.square8.Click += new System.EventHandler(this.BoxClick_Event);
            // 
            // square5
            // 
            this.square5.BorderColor = System.Drawing.Color.Gray;
            this.square5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.square5.Location = new System.Drawing.Point(95, 94);
            this.square5.Margin = new System.Windows.Forms.Padding(5);
            this.square5.Name = "square5";
            this.square5.Number = 5;
            this.square5.Size = new System.Drawing.Size(80, 79);
            this.square5.TabIndex = 0;
            this.square5.Click += new System.EventHandler(this.BoxClick_Event);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::_8_Puzzle_A_Star_Algoritma.Properties.Resources.u;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(313, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // N_Puzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "N_Puzzle";
            this.Size = new System.Drawing.Size(313, 337);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Square square1;
        private Square square2;
        private Square square3;
        private Square square4;
        private Square square6;
        private Square square7;
        private Square square8;
        private Square square5;
    }
}
