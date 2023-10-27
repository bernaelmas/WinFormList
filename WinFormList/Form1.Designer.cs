namespace WinFormList
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
            groupBox2 = new GroupBox();
            toplamButton = new Button();
            toplamBox = new TextBox();
            temizleButton = new Button();
            alisverisListesi = new ListBox();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            fiyat = new Label();
            ekleButton = new Button();
            kilo = new Label();
            meyveSebze = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 81);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.PowderBlue;
            groupBox2.Controls.Add(toplamButton);
            groupBox2.Controls.Add(toplamBox);
            groupBox2.Controls.Add(temizleButton);
            groupBox2.Controls.Add(alisverisListesi);
            groupBox2.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(452, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(295, 374);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "ALIŞVERİŞ LİSTESİ";
            // 
            // toplamButton
            // 
            toplamButton.Location = new Point(96, 241);
            toplamButton.Name = "toplamButton";
            toplamButton.Size = new Size(94, 29);
            toplamButton.TabIndex = 3;
            toplamButton.Text = "Toplam Tutar";
            toplamButton.UseVisualStyleBackColor = true;
            toplamButton.Click += toplamButton_Click;
            // 
            // toplamBox
            // 
            toplamBox.Location = new Point(30, 287);
            toplamBox.Multiline = true;
            toplamBox.Name = "toplamBox";
            toplamBox.Size = new Size(217, 68);
            toplamBox.TabIndex = 2;
            // 
            // temizleButton
            // 
            temizleButton.Location = new Point(96, 189);
            temizleButton.Name = "temizleButton";
            temizleButton.Size = new Size(94, 29);
            temizleButton.TabIndex = 1;
            temizleButton.Text = "Temizle";
            temizleButton.UseVisualStyleBackColor = true;
            temizleButton.Click += temizleButton_Click;
            // 
            // alisverisListesi
            // 
            alisverisListesi.FormattingEnabled = true;
            alisverisListesi.ItemHeight = 21;
            alisverisListesi.Location = new Point(20, 40);
            alisverisListesi.Name = "alisverisListesi";
            alisverisListesi.Size = new Size(250, 130);
            alisverisListesi.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PowderBlue;
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(fiyat);
            groupBox1.Controls.Add(ekleButton);
            groupBox1.Controls.Add(kilo);
            groupBox1.Controls.Add(meyveSebze);
            groupBox1.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(57, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 374);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "ALINACAKLAR";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 204);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 28);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 28);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 28);
            textBox1.TabIndex = 6;
            // 
            // fiyat
            // 
            fiyat.AutoSize = true;
            fiyat.Location = new Point(22, 211);
            fiyat.Name = "fiyat";
            fiyat.Size = new Size(47, 21);
            fiyat.TabIndex = 5;
            fiyat.Text = "Fiyat";
            // 
            // ekleButton
            // 
            ekleButton.Location = new Point(159, 286);
            ekleButton.Name = "ekleButton";
            ekleButton.Size = new Size(118, 29);
            ekleButton.TabIndex = 4;
            ekleButton.Text = "Ekle";
            ekleButton.UseVisualStyleBackColor = true;
            ekleButton.Click += ekleButton_Click;
            // 
            // kilo
            // 
            kilo.AutoSize = true;
            kilo.Location = new Point(22, 142);
            kilo.Name = "kilo";
            kilo.Size = new Size(39, 21);
            kilo.TabIndex = 3;
            kilo.Text = "Kilo";
            // 
            // meyveSebze
            // 
            meyveSebze.AutoSize = true;
            meyveSebze.Location = new Point(22, 73);
            meyveSebze.Name = "meyveSebze";
            meyveSebze.Size = new Size(111, 21);
            meyveSebze.TabIndex = 2;
            meyveSebze.Text = "Meyve-Sebze";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Alışveriş Sipariş Sistemi";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label meyveSebze;
        private Label kilo;
        private Button ekleButton;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label fiyat;
        private ListBox alisverisListesi;
        private Button temizleButton;
        private Button toplamButton;
        private TextBox toplamBox;
    }
}