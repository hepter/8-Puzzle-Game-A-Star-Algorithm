namespace _8_Puzzle_A_Star_Algoritma
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.n_Puzzle1 = new _8_Puzzle_A_Star_Algoritma.N_Puzzle();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "Karıştır";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // n_Puzzle1
            // 
            this.n_Puzzle1.IsBusy = false;
            this.n_Puzzle1.Location = new System.Drawing.Point(2, 9);
            this.n_Puzzle1.Name = "n_Puzzle1";
            this.n_Puzzle1.Size = new System.Drawing.Size(320, 320);
            this.n_Puzzle1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "A-Star";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.n_Puzzle1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private N_Puzzle n_Puzzle1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

