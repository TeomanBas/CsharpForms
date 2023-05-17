namespace _4_AracUygulamasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            BtnDegistir = new Button();
            CboxNereye = new ComboBox();
            CboxNereden = new ComboBox();
            MtboxSaat = new MaskedTextBox();
            MtboxTarih = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            MtboxTel = new MaskedTextBox();
            MtboxTc = new MaskedTextBox();
            TboxAdSoyad = new TextBox();
            BtnKaydet = new Button();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            LboxGoster = new ListBox();
            LblDegistir = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(662, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Script", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 23);
            label1.Name = "label1";
            label1.Size = new Size(581, 53);
            label1.TabIndex = 0;
            label1.Text = "Online Otobüs Bilet Satış Paneli";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(LblDegistir);
            groupBox1.Controls.Add(BtnDegistir);
            groupBox1.Controls.Add(CboxNereye);
            groupBox1.Controls.Add(CboxNereden);
            groupBox1.Controls.Add(MtboxSaat);
            groupBox1.Controls.Add(MtboxTarih);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 191);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kalkış Bilgileri";
            // 
            // BtnDegistir
            // 
            BtnDegistir.Location = new Point(292, 44);
            BtnDegistir.Name = "BtnDegistir";
            BtnDegistir.Size = new Size(75, 26);
            BtnDegistir.TabIndex = 4;
            BtnDegistir.Text = "<>";
            BtnDegistir.UseVisualStyleBackColor = true;
            BtnDegistir.Click += BtnDegistir_Click;
            // 
            // CboxNereye
            // 
            CboxNereye.FormattingEnabled = true;
            CboxNereye.Items.AddRange(new object[] { "İstanbul", "Ankara", "Bursa", "İzmir" });
            CboxNereye.Location = new Point(151, 70);
            CboxNereye.Name = "CboxNereye";
            CboxNereye.Size = new Size(121, 26);
            CboxNereye.TabIndex = 1;
            // 
            // CboxNereden
            // 
            CboxNereden.FormattingEnabled = true;
            CboxNereden.Items.AddRange(new object[] { "İstanbul", "Ankara", "Bursa", "İzmir" });
            CboxNereden.Location = new Point(151, 36);
            CboxNereden.Name = "CboxNereden";
            CboxNereden.Size = new Size(121, 26);
            CboxNereden.TabIndex = 0;
            CboxNereden.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // MtboxSaat
            // 
            MtboxSaat.Location = new Point(151, 134);
            MtboxSaat.Mask = "90:00";
            MtboxSaat.Name = "MtboxSaat";
            MtboxSaat.Size = new Size(121, 26);
            MtboxSaat.TabIndex = 3;
            MtboxSaat.ValidatingType = typeof(DateTime);
            // 
            // MtboxTarih
            // 
            MtboxTarih.Location = new Point(151, 102);
            MtboxTarih.Mask = "00/00/0000";
            MtboxTarih.Name = "MtboxTarih";
            MtboxTarih.Size = new Size(121, 26);
            MtboxTarih.TabIndex = 2;
            MtboxTarih.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 143);
            label5.Name = "label5";
            label5.Size = new Size(55, 18);
            label5.TabIndex = 3;
            label5.Text = "Saat :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 110);
            label4.Name = "label4";
            label4.Size = new Size(65, 18);
            label4.TabIndex = 2;
            label4.Text = "Tarih :";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 77);
            label3.Name = "label3";
            label3.Size = new Size(75, 18);
            label3.TabIndex = 1;
            label3.Text = "Nereye :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 44);
            label2.Name = "label2";
            label2.Size = new Size(88, 18);
            label2.TabIndex = 0;
            label2.Text = "Nereden :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(MtboxTel);
            groupBox2.Controls.Add(MtboxTc);
            groupBox2.Controls.Add(TboxAdSoyad);
            groupBox2.Controls.Add(BtnKaydet);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(391, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(397, 191);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Bilgileri";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // MtboxTel
            // 
            MtboxTel.Location = new Point(167, 100);
            MtboxTel.Mask = "(999) 000-0000";
            MtboxTel.Name = "MtboxTel";
            MtboxTel.Size = new Size(213, 26);
            MtboxTel.TabIndex = 6;
            // 
            // MtboxTc
            // 
            MtboxTc.Location = new Point(167, 68);
            MtboxTc.Mask = "00000000000";
            MtboxTc.Name = "MtboxTc";
            MtboxTc.Size = new Size(213, 26);
            MtboxTc.TabIndex = 5;
            MtboxTc.MaskInputRejected += maskedTextBox3_MaskInputRejected;
            // 
            // TboxAdSoyad
            // 
            TboxAdSoyad.Location = new Point(167, 36);
            TboxAdSoyad.Name = "TboxAdSoyad";
            TboxAdSoyad.Size = new Size(213, 26);
            TboxAdSoyad.TabIndex = 4;
            // 
            // BtnKaydet
            // 
            BtnKaydet.Location = new Point(266, 143);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(125, 42);
            BtnKaydet.TabIndex = 6;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 77);
            label7.Name = "label7";
            label7.Size = new Size(133, 18);
            label7.TabIndex = 5;
            label7.Text = "T.C Kimlik No :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 110);
            label8.Name = "label8";
            label8.Size = new Size(81, 18);
            label8.TabIndex = 6;
            label8.Text = "Telefon :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 44);
            label6.Name = "label6";
            label6.Size = new Size(95, 18);
            label6.TabIndex = 4;
            label6.Text = "Ad Soyad :";
            label6.Click += label6_Click;
            // 
            // LboxGoster
            // 
            LboxGoster.FormattingEnabled = true;
            LboxGoster.ItemHeight = 15;
            LboxGoster.Location = new Point(12, 346);
            LboxGoster.Name = "LboxGoster";
            LboxGoster.Size = new Size(776, 94);
            LboxGoster.TabIndex = 3;
            // 
            // LblDegistir
            // 
            LblDegistir.AutoSize = true;
            LblDegistir.Location = new Point(294, 167);
            LblDegistir.Name = "LblDegistir";
            LblDegistir.RightToLeft = RightToLeft.Yes;
            LblDegistir.Size = new Size(73, 18);
            LblDegistir.TabIndex = 5;
            LblDegistir.Text = "Degistir";
            LblDegistir.Visible = false;
            LblDegistir.Click += LblDegistir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(LboxGoster);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private MaskedTextBox MtboxSaat;
        private MaskedTextBox MtboxTarih;
        private MaskedTextBox MtboxTc;
        private TextBox TboxAdSoyad;
        private Button BtnKaydet;
        private ListBox LboxGoster;
        private ComboBox CboxNereden;
        private MaskedTextBox MtboxTel;
        private ComboBox CboxNereye;
        private Button BtnDegistir;
        private Label LblDegistir;
    }
}