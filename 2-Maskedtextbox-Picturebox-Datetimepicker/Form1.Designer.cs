namespace Maskedtextbox_Picturebox_Datetimepicker
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
            MskTc = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            MskTel = new MaskedTextBox();
            MskTarih = new MaskedTextBox();
            MskSaat = new MaskedTextBox();
            BtnEkle = new Button();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            dtpTarih = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MskTc
            // 
            MskTc.Location = new Point(171, 94);
            MskTc.Mask = "00000000000";
            MskTc.Name = "MskTc";
            MskTc.Size = new Size(100, 22);
            MskTc.TabIndex = 0;
            MskTc.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 65);
            label1.Name = "label1";
            label1.Size = new Size(60, 19);
            label1.TabIndex = 1;
            label1.Text = "Telefon";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(53, 155);
            label2.Name = "label2";
            label2.Size = new Size(40, 19);
            label2.TabIndex = 2;
            label2.Text = "Saat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(53, 125);
            label3.Name = "label3";
            label3.Size = new Size(44, 19);
            label3.TabIndex = 3;
            label3.Text = "Tarih";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(53, 95);
            label4.Name = "label4";
            label4.Size = new Size(105, 19);
            label4.TabIndex = 4;
            label4.Text = "Tc. Kimlik No:";
            // 
            // MskTel
            // 
            MskTel.Location = new Point(171, 62);
            MskTel.Mask = "(999) 000-0000";
            MskTel.Name = "MskTel";
            MskTel.Size = new Size(100, 22);
            MskTel.TabIndex = 5;
            // 
            // MskTarih
            // 
            MskTarih.Location = new Point(171, 126);
            MskTarih.Mask = "00/00/0000";
            MskTarih.Name = "MskTarih";
            MskTarih.Size = new Size(100, 22);
            MskTarih.TabIndex = 6;
            // 
            // MskSaat
            // 
            MskSaat.Location = new Point(171, 158);
            MskSaat.Mask = "00:00";
            MskSaat.Name = "MskSaat";
            MskSaat.Size = new Size(100, 22);
            MskSaat.TabIndex = 7;
            MskSaat.ValidatingType = typeof(DateTime);
            // 
            // BtnEkle
            // 
            BtnEkle.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEkle.Location = new Point(302, 186);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(75, 38);
            BtnEkle.TabIndex = 8;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = true;
            BtnEkle.Click += BtnEkle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(277, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 14;
            listBox1.Location = new Point(53, 237);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(324, 46);
            listBox1.TabIndex = 10;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(53, 186);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(135, 22);
            dtpTarih.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(413, 300);
            Controls.Add(dtpTarih);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Controls.Add(BtnEkle);
            Controls.Add(MskSaat);
            Controls.Add(MskTarih);
            Controls.Add(MskTel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MskTc);
            Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox MskTc;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox MskTel;
        private MaskedTextBox MskTarih;
        private MaskedTextBox MskSaat;
        private Button BtnEkle;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private DateTimePicker dtpTarih;
    }
}