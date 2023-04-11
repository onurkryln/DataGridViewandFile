namespace Ödev
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
            this.okubtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ekle = new System.Windows.Forms.Button();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.lengttxt = new System.Windows.Forms.TextBox();
            this.nufusttxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.seçilisatırsil = new System.Windows.Forms.Button();
            this.güncellebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // okubtn
            // 
            this.okubtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.okubtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.okubtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.okubtn.Location = new System.Drawing.Point(758, 251);
            this.okubtn.Name = "okubtn";
            this.okubtn.Size = new System.Drawing.Size(143, 69);
            this.okubtn.TabIndex = 1;
            this.okubtn.Text = "Dosya Oku";
            this.okubtn.UseVisualStyleBackColor = false;
            this.okubtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(422, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(530, 242);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ekle.Location = new System.Drawing.Point(309, 171);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(107, 74);
            this.ekle.TabIndex = 8;
            this.ekle.Text = "ekle";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.button7_Click);
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(316, 23);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 22);
            this.nametxt.TabIndex = 9;
            // 
            // lengttxt
            // 
            this.lengttxt.Location = new System.Drawing.Point(316, 141);
            this.lengttxt.Name = "lengttxt";
            this.lengttxt.Size = new System.Drawing.Size(100, 22);
            this.lengttxt.TabIndex = 10;
            // 
            // nufusttxt
            // 
            this.nufusttxt.Location = new System.Drawing.Point(316, 77);
            this.nufusttxt.Name = "nufusttxt";
            this.nufusttxt.Size = new System.Drawing.Size(100, 22);
            this.nufusttxt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(238, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "adı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(225, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "nüfus:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(206, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "uzunluk:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // seçilisatırsil
            // 
            this.seçilisatırsil.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.seçilisatırsil.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seçilisatırsil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seçilisatırsil.Location = new System.Drawing.Point(603, 251);
            this.seçilisatırsil.Name = "seçilisatırsil";
            this.seçilisatırsil.Size = new System.Drawing.Size(115, 69);
            this.seçilisatırsil.TabIndex = 15;
            this.seçilisatırsil.Text = "SeçSil";
            this.seçilisatırsil.UseVisualStyleBackColor = false;
            this.seçilisatırsil.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // güncellebtn
            // 
            this.güncellebtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.güncellebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.güncellebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.güncellebtn.Location = new System.Drawing.Point(447, 250);
            this.güncellebtn.Name = "güncellebtn";
            this.güncellebtn.Size = new System.Drawing.Size(131, 70);
            this.güncellebtn.TabIndex = 16;
            this.güncellebtn.Text = "Güncelle";
            this.güncellebtn.UseVisualStyleBackColor = false;
            this.güncellebtn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(953, 501);
            this.Controls.Add(this.güncellebtn);
            this.Controls.Add(this.seçilisatırsil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nufusttxt);
            this.Controls.Add(this.lengttxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.okubtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button okubtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox lengttxt;
        private System.Windows.Forms.TextBox nufusttxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button seçilisatırsil;
        private System.Windows.Forms.Button güncellebtn;
    }
}

