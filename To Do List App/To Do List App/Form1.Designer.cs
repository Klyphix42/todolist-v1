namespace To_Do_List_App
{
    partial class ToDoList
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
            this.label1 = new System.Windows.Forms.Label();
            this.BaşlıkKutusu = new System.Windows.Forms.TextBox();
            this.AçıklamaKutusu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.YeniButon = new System.Windows.Forms.Button();
            this.İsEditing = new System.Windows.Forms.Button();
            this.SilmeButonu = new System.Windows.Forms.Button();
            this.KaydetmeButonu = new System.Windows.Forms.Button();
            this.ToDoListWiew = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ToDoListWiew)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1021, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yapılacaklar Listesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BaşlıkKutusu
            // 
            this.BaşlıkKutusu.Location = new System.Drawing.Point(12, 115);
            this.BaşlıkKutusu.Name = "BaşlıkKutusu";
            this.BaşlıkKutusu.Size = new System.Drawing.Size(1021, 22);
            this.BaşlıkKutusu.TabIndex = 1;
            // 
            // AçıklamaKutusu
            // 
            this.AçıklamaKutusu.Location = new System.Drawing.Point(12, 166);
            this.AçıklamaKutusu.Name = "AçıklamaKutusu";
            this.AçıklamaKutusu.Size = new System.Drawing.Size(1021, 22);
            this.AçıklamaKutusu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1021, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklama:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1021, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Başlık:";
            // 
            // YeniButon
            // 
            this.YeniButon.Location = new System.Drawing.Point(12, 203);
            this.YeniButon.Name = "YeniButon";
            this.YeniButon.Size = new System.Drawing.Size(236, 50);
            this.YeniButon.TabIndex = 5;
            this.YeniButon.Text = "Yeni";
            this.YeniButon.UseVisualStyleBackColor = true;
            this.YeniButon.Click += new System.EventHandler(this.YeniButon_Click);
            // 
            // İsEditing
            // 
            this.İsEditing.Location = new System.Drawing.Point(275, 203);
            this.İsEditing.Name = "İsEditing";
            this.İsEditing.Size = new System.Drawing.Size(238, 50);
            this.İsEditing.TabIndex = 6;
            this.İsEditing.Text = "Düzenle";
            this.İsEditing.UseVisualStyleBackColor = true;
            this.İsEditing.Click += new System.EventHandler(this.button1_Click);
            // 
            // SilmeButonu
            // 
            this.SilmeButonu.Location = new System.Drawing.Point(538, 203);
            this.SilmeButonu.Name = "SilmeButonu";
            this.SilmeButonu.Size = new System.Drawing.Size(233, 50);
            this.SilmeButonu.TabIndex = 7;
            this.SilmeButonu.Text = "Kaldır";
            this.SilmeButonu.UseVisualStyleBackColor = true;
            this.SilmeButonu.Click += new System.EventHandler(this.button2_Click);
            // 
            // KaydetmeButonu
            // 
            this.KaydetmeButonu.Location = new System.Drawing.Point(796, 203);
            this.KaydetmeButonu.Name = "KaydetmeButonu";
            this.KaydetmeButonu.Size = new System.Drawing.Size(237, 50);
            this.KaydetmeButonu.TabIndex = 8;
            this.KaydetmeButonu.Text = "Kaydet";
            this.KaydetmeButonu.UseVisualStyleBackColor = true;
            this.KaydetmeButonu.Click += new System.EventHandler(this.KaydetmeButonu_Click);
            // 
            // ToDoListWiew
            // 
            this.ToDoListWiew.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ToDoListWiew.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ToDoListWiew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToDoListWiew.Location = new System.Drawing.Point(12, 269);
            this.ToDoListWiew.Name = "ToDoListWiew";
            this.ToDoListWiew.RowTemplate.Height = 24;
            this.ToDoListWiew.Size = new System.Drawing.Size(1021, 390);
            this.ToDoListWiew.TabIndex = 9;
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1045, 671);
            this.Controls.Add(this.ToDoListWiew);
            this.Controls.Add(this.KaydetmeButonu);
            this.Controls.Add(this.SilmeButonu);
            this.Controls.Add(this.İsEditing);
            this.Controls.Add(this.YeniButon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AçıklamaKutusu);
            this.Controls.Add(this.BaşlıkKutusu);
            this.Controls.Add(this.label1);
            this.Name = "ToDoList";
            this.Text = "To Do List ";
            this.Load += new System.EventHandler(this.ToDoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToDoListWiew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BaşlıkKutusu;
        private System.Windows.Forms.TextBox AçıklamaKutusu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button YeniButon;
        private System.Windows.Forms.Button İsEditing;
        private System.Windows.Forms.Button SilmeButonu;
        private System.Windows.Forms.Button KaydetmeButonu;
        private System.Windows.Forms.DataGridView ToDoListWiew;
    }
}

