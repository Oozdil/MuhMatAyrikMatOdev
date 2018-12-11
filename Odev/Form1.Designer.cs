namespace Odev
{
    partial class OdevForm
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
            this.btnTabloHesapla = new System.Windows.Forms.Button();
            this.txBxMod = new System.Windows.Forms.TextBox();
            this.dGvResult = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOdev1 = new System.Windows.Forms.Panel();
            this.txBxOdev1Info = new System.Windows.Forms.TextBox();
            this.richTxBxOdev1Sonuc = new System.Windows.Forms.RichTextBox();
            this.lblForOdev1 = new System.Windows.Forms.Label();
            this.pnlOdev2 = new System.Windows.Forms.Panel();
            this.txBxOdev2Info = new System.Windows.Forms.TextBox();
            this.lblForOdev2 = new System.Windows.Forms.Label();
            this.pnlOdev3 = new System.Windows.Forms.Panel();
            this.pnlSureHesabi = new System.Windows.Forms.Panel();
            this.lblYuzde = new System.Windows.Forms.Label();
            this.lblSureHesSonuc = new System.Windows.Forms.Label();
            this.rdBtnSure2 = new System.Windows.Forms.RadioButton();
            this.rdBtnSure1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txBxSureHesKutleYuzdesi = new System.Windows.Forms.TextBox();
            this.comBxSureHesKutle = new System.Windows.Forms.ComboBox();
            this.txBxSureHesKutle = new System.Windows.Forms.TextBox();
            this.lblSoru = new System.Windows.Forms.Label();
            this.pnlKutleHesabi = new System.Windows.Forms.Panel();
            this.lblKutleHesSonuc = new System.Windows.Forms.Label();
            this.lblKutleHesSure = new System.Windows.Forms.Label();
            this.comBxKutleHesSure = new System.Windows.Forms.ComboBox();
            this.txBxKutleHesSure = new System.Windows.Forms.TextBox();
            this.btnYarilanmaOmruHesapla = new System.Windows.Forms.Button();
            this.rdBtnSureBul = new System.Windows.Forms.RadioButton();
            this.rdBtnKalanKutleBul = new System.Windows.Forms.RadioButton();
            this.txBxOdev3Info = new System.Windows.Forms.TextBox();
            this.lblForKutle = new System.Windows.Forms.Label();
            this.lblForYarilanmaOmru = new System.Windows.Forms.Label();
            this.comBxKutle = new System.Windows.Forms.ComboBox();
            this.comBxYO = new System.Windows.Forms.ComboBox();
            this.txBxKutle = new System.Windows.Forms.TextBox();
            this.txBxYarilanmaOmru = new System.Windows.Forms.TextBox();
            this.lblForOdev3 = new System.Windows.Forms.Label();
            this.lblOdevInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGvResult)).BeginInit();
            this.pnlOdev1.SuspendLayout();
            this.pnlOdev2.SuspendLayout();
            this.pnlOdev3.SuspendLayout();
            this.pnlSureHesabi.SuspendLayout();
            this.pnlKutleHesabi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTabloHesapla
            // 
            this.btnTabloHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTabloHesapla.Location = new System.Drawing.Point(105, 88);
            this.btnTabloHesapla.Name = "btnTabloHesapla";
            this.btnTabloHesapla.Size = new System.Drawing.Size(138, 34);
            this.btnTabloHesapla.TabIndex = 0;
            this.btnTabloHesapla.Text = "Tabloyu Hesapla";
            this.btnTabloHesapla.UseVisualStyleBackColor = true;
            this.btnTabloHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txBxMod
            // 
            this.txBxMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxMod.Location = new System.Drawing.Point(15, 96);
            this.txBxMod.Name = "txBxMod";
            this.txBxMod.Size = new System.Drawing.Size(74, 23);
            this.txBxMod.TabIndex = 1;
            // 
            // dGvResult
            // 
            this.dGvResult.AllowUserToAddRows = false;
            this.dGvResult.AllowUserToDeleteRows = false;
            this.dGvResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dGvResult.Location = new System.Drawing.Point(14, 137);
            this.dGvResult.Name = "dGvResult";
            this.dGvResult.ReadOnly = true;
            this.dGvResult.RowHeadersVisible = false;
            this.dGvResult.Size = new System.Drawing.Size(229, 298);
            this.dGvResult.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "w";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "-w";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 75;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "w^-1";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 75;
            // 
            // pnlOdev1
            // 
            this.pnlOdev1.BackColor = System.Drawing.SystemColors.Control;
            this.pnlOdev1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOdev1.Controls.Add(this.txBxOdev1Info);
            this.pnlOdev1.Controls.Add(this.richTxBxOdev1Sonuc);
            this.pnlOdev1.Controls.Add(this.lblForOdev1);
            this.pnlOdev1.Location = new System.Drawing.Point(26, 12);
            this.pnlOdev1.Name = "pnlOdev1";
            this.pnlOdev1.Size = new System.Drawing.Size(253, 442);
            this.pnlOdev1.TabIndex = 5;
            // 
            // txBxOdev1Info
            // 
            this.txBxOdev1Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxOdev1Info.Location = new System.Drawing.Point(16, 58);
            this.txBxOdev1Info.Multiline = true;
            this.txBxOdev1Info.Name = "txBxOdev1Info";
            this.txBxOdev1Info.ReadOnly = true;
            this.txBxOdev1Info.Size = new System.Drawing.Size(217, 47);
            this.txBxOdev1Info.TabIndex = 2;
            this.txBxOdev1Info.Text = "Literatürde bilien en büyük asal sayı nedir ?";
            this.txBxOdev1Info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTxBxOdev1Sonuc
            // 
            this.richTxBxOdev1Sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTxBxOdev1Sonuc.Location = new System.Drawing.Point(16, 122);
            this.richTxBxOdev1Sonuc.Name = "richTxBxOdev1Sonuc";
            this.richTxBxOdev1Sonuc.Size = new System.Drawing.Size(217, 313);
            this.richTxBxOdev1Sonuc.TabIndex = 1;
            this.richTxBxOdev1Sonuc.Text = "";
            // 
            // lblForOdev1
            // 
            this.lblForOdev1.AutoSize = true;
            this.lblForOdev1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForOdev1.Location = new System.Drawing.Point(85, 10);
            this.lblForOdev1.Name = "lblForOdev1";
            this.lblForOdev1.Size = new System.Drawing.Size(74, 20);
            this.lblForOdev1.TabIndex = 0;
            this.lblForOdev1.Text = "ÖDEV 1";
            // 
            // pnlOdev2
            // 
            this.pnlOdev2.BackColor = System.Drawing.SystemColors.Control;
            this.pnlOdev2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOdev2.Controls.Add(this.txBxOdev2Info);
            this.pnlOdev2.Controls.Add(this.lblForOdev2);
            this.pnlOdev2.Controls.Add(this.txBxMod);
            this.pnlOdev2.Controls.Add(this.btnTabloHesapla);
            this.pnlOdev2.Controls.Add(this.dGvResult);
            this.pnlOdev2.Location = new System.Drawing.Point(302, 12);
            this.pnlOdev2.Name = "pnlOdev2";
            this.pnlOdev2.Size = new System.Drawing.Size(253, 442);
            this.pnlOdev2.TabIndex = 6;
            // 
            // txBxOdev2Info
            // 
            this.txBxOdev2Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxOdev2Info.Location = new System.Drawing.Point(15, 37);
            this.txBxOdev2Info.Multiline = true;
            this.txBxOdev2Info.Name = "txBxOdev2Info";
            this.txBxOdev2Info.ReadOnly = true;
            this.txBxOdev2Info.Size = new System.Drawing.Size(229, 47);
            this.txBxOdev2Info.TabIndex = 3;
            this.txBxOdev2Info.Text = "Toplamsal ve çarpımsal hesaplama için bir \'n\' değeri giriniz";
            this.txBxOdev2Info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblForOdev2
            // 
            this.lblForOdev2.AutoSize = true;
            this.lblForOdev2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForOdev2.Location = new System.Drawing.Point(85, 10);
            this.lblForOdev2.Name = "lblForOdev2";
            this.lblForOdev2.Size = new System.Drawing.Size(74, 20);
            this.lblForOdev2.TabIndex = 0;
            this.lblForOdev2.Text = "ÖDEV 2";
            // 
            // pnlOdev3
            // 
            this.pnlOdev3.BackColor = System.Drawing.SystemColors.Control;
            this.pnlOdev3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOdev3.Controls.Add(this.pnlSureHesabi);
            this.pnlOdev3.Controls.Add(this.pnlKutleHesabi);
            this.pnlOdev3.Controls.Add(this.btnYarilanmaOmruHesapla);
            this.pnlOdev3.Controls.Add(this.rdBtnSureBul);
            this.pnlOdev3.Controls.Add(this.rdBtnKalanKutleBul);
            this.pnlOdev3.Controls.Add(this.txBxOdev3Info);
            this.pnlOdev3.Controls.Add(this.lblForKutle);
            this.pnlOdev3.Controls.Add(this.lblForYarilanmaOmru);
            this.pnlOdev3.Controls.Add(this.comBxKutle);
            this.pnlOdev3.Controls.Add(this.comBxYO);
            this.pnlOdev3.Controls.Add(this.txBxKutle);
            this.pnlOdev3.Controls.Add(this.txBxYarilanmaOmru);
            this.pnlOdev3.Controls.Add(this.lblForOdev3);
            this.pnlOdev3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlOdev3.Location = new System.Drawing.Point(583, 12);
            this.pnlOdev3.Name = "pnlOdev3";
            this.pnlOdev3.Size = new System.Drawing.Size(456, 442);
            this.pnlOdev3.TabIndex = 7;
            // 
            // pnlSureHesabi
            // 
            this.pnlSureHesabi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSureHesabi.Controls.Add(this.lblYuzde);
            this.pnlSureHesabi.Controls.Add(this.lblSureHesSonuc);
            this.pnlSureHesabi.Controls.Add(this.rdBtnSure2);
            this.pnlSureHesabi.Controls.Add(this.rdBtnSure1);
            this.pnlSureHesabi.Controls.Add(this.label4);
            this.pnlSureHesabi.Controls.Add(this.txBxSureHesKutleYuzdesi);
            this.pnlSureHesabi.Controls.Add(this.comBxSureHesKutle);
            this.pnlSureHesabi.Controls.Add(this.txBxSureHesKutle);
            this.pnlSureHesabi.Controls.Add(this.lblSoru);
            this.pnlSureHesabi.Location = new System.Drawing.Point(22, 287);
            this.pnlSureHesabi.Name = "pnlSureHesabi";
            this.pnlSureHesabi.Size = new System.Drawing.Size(411, 106);
            this.pnlSureHesabi.TabIndex = 14;
            this.pnlSureHesabi.Visible = false;
            // 
            // lblYuzde
            // 
            this.lblYuzde.AutoSize = true;
            this.lblYuzde.Location = new System.Drawing.Point(35, 57);
            this.lblYuzde.Name = "lblYuzde";
            this.lblYuzde.Size = new System.Drawing.Size(20, 17);
            this.lblYuzde.TabIndex = 19;
            this.lblYuzde.Text = "%";
            this.lblYuzde.Visible = false;
            // 
            // lblSureHesSonuc
            // 
            this.lblSureHesSonuc.AutoSize = true;
            this.lblSureHesSonuc.Location = new System.Drawing.Point(7, 80);
            this.lblSureHesSonuc.Name = "lblSureHesSonuc";
            this.lblSureHesSonuc.Size = new System.Drawing.Size(60, 17);
            this.lblSureHesSonuc.TabIndex = 18;
            this.lblSureHesSonuc.Text = "Sonuç : ";
            // 
            // rdBtnSure2
            // 
            this.rdBtnSure2.AutoSize = true;
            this.rdBtnSure2.Location = new System.Drawing.Point(9, 58);
            this.rdBtnSure2.Name = "rdBtnSure2";
            this.rdBtnSure2.Size = new System.Drawing.Size(14, 13);
            this.rdBtnSure2.TabIndex = 16;
            this.rdBtnSure2.UseVisualStyleBackColor = true;
            this.rdBtnSure2.CheckedChanged += new System.EventHandler(this.rdBtnSure2_CheckedChanged);
            // 
            // rdBtnSure1
            // 
            this.rdBtnSure1.AutoSize = true;
            this.rdBtnSure1.Checked = true;
            this.rdBtnSure1.Location = new System.Drawing.Point(9, 31);
            this.rdBtnSure1.Name = "rdBtnSure1";
            this.rdBtnSure1.Size = new System.Drawing.Size(14, 13);
            this.rdBtnSure1.TabIndex = 15;
            this.rdBtnSure1.TabStop = true;
            this.rdBtnSure1.UseVisualStyleBackColor = true;
            this.rdBtnSure1.CheckedChanged += new System.EventHandler(this.rdBtnSure2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "kalır";
            // 
            // txBxSureHesKutleYuzdesi
            // 
            this.txBxSureHesKutleYuzdesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxSureHesKutleYuzdesi.Location = new System.Drawing.Point(33, 53);
            this.txBxSureHesKutleYuzdesi.Name = "txBxSureHesKutleYuzdesi";
            this.txBxSureHesKutleYuzdesi.Size = new System.Drawing.Size(119, 23);
            this.txBxSureHesKutleYuzdesi.TabIndex = 11;
            this.txBxSureHesKutleYuzdesi.Text = "0";
            this.txBxSureHesKutleYuzdesi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txBxSureHesKutleYuzdesi.Visible = false;
            // 
            // comBxSureHesKutle
            // 
            this.comBxSureHesKutle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comBxSureHesKutle.FormattingEnabled = true;
            this.comBxSureHesKutle.Items.AddRange(new object[] {
            "Kilogram (kg)",
            "Gram (g)"});
            this.comBxSureHesKutle.Location = new System.Drawing.Point(95, 25);
            this.comBxSureHesKutle.Name = "comBxSureHesKutle";
            this.comBxSureHesKutle.Size = new System.Drawing.Size(105, 24);
            this.comBxSureHesKutle.TabIndex = 10;
            // 
            // txBxSureHesKutle
            // 
            this.txBxSureHesKutle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxSureHesKutle.Location = new System.Drawing.Point(33, 26);
            this.txBxSureHesKutle.Name = "txBxSureHesKutle";
            this.txBxSureHesKutle.Size = new System.Drawing.Size(56, 23);
            this.txBxSureHesKutle.TabIndex = 9;
            this.txBxSureHesKutle.Text = "100";
            this.txBxSureHesKutle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Location = new System.Drawing.Point(3, 3);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(138, 17);
            this.lblSoru.TabIndex = 8;
            this.lblSoru.Text = "Ne kadar süre sonra";
            // 
            // pnlKutleHesabi
            // 
            this.pnlKutleHesabi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlKutleHesabi.Controls.Add(this.lblKutleHesSonuc);
            this.pnlKutleHesabi.Controls.Add(this.lblKutleHesSure);
            this.pnlKutleHesabi.Controls.Add(this.comBxKutleHesSure);
            this.pnlKutleHesabi.Controls.Add(this.txBxKutleHesSure);
            this.pnlKutleHesabi.Location = new System.Drawing.Point(22, 180);
            this.pnlKutleHesabi.Name = "pnlKutleHesabi";
            this.pnlKutleHesabi.Size = new System.Drawing.Size(411, 86);
            this.pnlKutleHesabi.TabIndex = 13;
            // 
            // lblKutleHesSonuc
            // 
            this.lblKutleHesSonuc.AutoSize = true;
            this.lblKutleHesSonuc.Location = new System.Drawing.Point(9, 42);
            this.lblKutleHesSonuc.Name = "lblKutleHesSonuc";
            this.lblKutleHesSonuc.Size = new System.Drawing.Size(60, 17);
            this.lblKutleHesSonuc.TabIndex = 9;
            this.lblKutleHesSonuc.Text = "Sonuç : ";
            // 
            // lblKutleHesSure
            // 
            this.lblKutleHesSure.AutoSize = true;
            this.lblKutleHesSure.Location = new System.Drawing.Point(181, 7);
            this.lblKutleHesSure.Name = "lblKutleHesSure";
            this.lblKutleHesSure.Size = new System.Drawing.Size(223, 17);
            this.lblKutleHesSure.TabIndex = 7;
            this.lblKutleHesSure.Text = "süre sonra kalan kütle/yüzdeyi bul";
            // 
            // comBxKutleHesSure
            // 
            this.comBxKutleHesSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comBxKutleHesSure.FormattingEnabled = true;
            this.comBxKutleHesSure.Items.AddRange(new object[] {
            "Yıl",
            "Gün"});
            this.comBxKutleHesSure.Location = new System.Drawing.Point(65, 3);
            this.comBxKutleHesSure.Name = "comBxKutleHesSure";
            this.comBxKutleHesSure.Size = new System.Drawing.Size(105, 24);
            this.comBxKutleHesSure.TabIndex = 6;
            // 
            // txBxKutleHesSure
            // 
            this.txBxKutleHesSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxKutleHesSure.Location = new System.Drawing.Point(6, 4);
            this.txBxKutleHesSure.Name = "txBxKutleHesSure";
            this.txBxKutleHesSure.Size = new System.Drawing.Size(56, 23);
            this.txBxKutleHesSure.TabIndex = 4;
            this.txBxKutleHesSure.Text = "0";
            this.txBxKutleHesSure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnYarilanmaOmruHesapla
            // 
            this.btnYarilanmaOmruHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYarilanmaOmruHesapla.Location = new System.Drawing.Point(22, 400);
            this.btnYarilanmaOmruHesapla.Name = "btnYarilanmaOmruHesapla";
            this.btnYarilanmaOmruHesapla.Size = new System.Drawing.Size(411, 35);
            this.btnYarilanmaOmruHesapla.TabIndex = 12;
            this.btnYarilanmaOmruHesapla.Text = "Sonucu Hesapla";
            this.btnYarilanmaOmruHesapla.UseVisualStyleBackColor = true;
            this.btnYarilanmaOmruHesapla.Click += new System.EventHandler(this.btnYarilanmaOmruHesapla_Click);
            // 
            // rdBtnSureBul
            // 
            this.rdBtnSureBul.AutoSize = true;
            this.rdBtnSureBul.Location = new System.Drawing.Point(22, 267);
            this.rdBtnSureBul.Name = "rdBtnSureBul";
            this.rdBtnSureBul.Size = new System.Drawing.Size(116, 21);
            this.rdBtnSureBul.TabIndex = 11;
            this.rdBtnSureBul.Text = "Süre Hesabı...";
            this.rdBtnSureBul.UseVisualStyleBackColor = true;
            this.rdBtnSureBul.CheckedChanged += new System.EventHandler(this.rdBtnSureBul_CheckedChanged);
            // 
            // rdBtnKalanKutleBul
            // 
            this.rdBtnKalanKutleBul.AutoSize = true;
            this.rdBtnKalanKutleBul.Checked = true;
            this.rdBtnKalanKutleBul.Location = new System.Drawing.Point(22, 160);
            this.rdBtnKalanKutleBul.Name = "rdBtnKalanKutleBul";
            this.rdBtnKalanKutleBul.Size = new System.Drawing.Size(185, 21);
            this.rdBtnKalanKutleBul.TabIndex = 9;
            this.rdBtnKalanKutleBul.TabStop = true;
            this.rdBtnKalanKutleBul.Text = "Kalan kütle-yüzde hesabı";
            this.rdBtnKalanKutleBul.UseVisualStyleBackColor = true;
            this.rdBtnKalanKutleBul.CheckedChanged += new System.EventHandler(this.rdBtnSureBul_CheckedChanged);
            // 
            // txBxOdev3Info
            // 
            this.txBxOdev3Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxOdev3Info.Location = new System.Drawing.Point(89, 52);
            this.txBxOdev3Info.Multiline = true;
            this.txBxOdev3Info.Name = "txBxOdev3Info";
            this.txBxOdev3Info.ReadOnly = true;
            this.txBxOdev3Info.Size = new System.Drawing.Size(279, 32);
            this.txBxOdev3Info.TabIndex = 4;
            this.txBxOdev3Info.Text = "Yarılanma Ömrü Hesaplaması";
            this.txBxOdev3Info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblForKutle
            // 
            this.lblForKutle.AutoSize = true;
            this.lblForKutle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForKutle.Location = new System.Drawing.Point(128, 133);
            this.lblForKutle.Name = "lblForKutle";
            this.lblForKutle.Size = new System.Drawing.Size(73, 17);
            this.lblForKutle.TabIndex = 8;
            this.lblForKutle.Text = "Kütle (m) :";
            // 
            // lblForYarilanmaOmru
            // 
            this.lblForYarilanmaOmru.AutoSize = true;
            this.lblForYarilanmaOmru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForYarilanmaOmru.Location = new System.Drawing.Point(83, 97);
            this.lblForYarilanmaOmru.Name = "lblForYarilanmaOmru";
            this.lblForYarilanmaOmru.Size = new System.Drawing.Size(118, 17);
            this.lblForYarilanmaOmru.TabIndex = 7;
            this.lblForYarilanmaOmru.Text = "Yarılanma Ömrü :";
            // 
            // comBxKutle
            // 
            this.comBxKutle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comBxKutle.FormattingEnabled = true;
            this.comBxKutle.Items.AddRange(new object[] {
            "Kilogram (kg)",
            "Gram (g)"});
            this.comBxKutle.Location = new System.Drawing.Point(263, 128);
            this.comBxKutle.Name = "comBxKutle";
            this.comBxKutle.Size = new System.Drawing.Size(105, 24);
            this.comBxKutle.TabIndex = 6;
            // 
            // comBxYO
            // 
            this.comBxYO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comBxYO.FormattingEnabled = true;
            this.comBxYO.Items.AddRange(new object[] {
            "Yıl",
            "Gün"});
            this.comBxYO.Location = new System.Drawing.Point(263, 93);
            this.comBxYO.Name = "comBxYO";
            this.comBxYO.Size = new System.Drawing.Size(105, 24);
            this.comBxYO.TabIndex = 5;
            // 
            // txBxKutle
            // 
            this.txBxKutle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxKutle.Location = new System.Drawing.Point(201, 129);
            this.txBxKutle.Name = "txBxKutle";
            this.txBxKutle.Size = new System.Drawing.Size(56, 23);
            this.txBxKutle.TabIndex = 4;
            this.txBxKutle.Text = "100";
            this.txBxKutle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txBxYarilanmaOmru
            // 
            this.txBxYarilanmaOmru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBxYarilanmaOmru.Location = new System.Drawing.Point(201, 93);
            this.txBxYarilanmaOmru.Name = "txBxYarilanmaOmru";
            this.txBxYarilanmaOmru.Size = new System.Drawing.Size(56, 23);
            this.txBxYarilanmaOmru.TabIndex = 3;
            this.txBxYarilanmaOmru.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblForOdev3
            // 
            this.lblForOdev3.AutoSize = true;
            this.lblForOdev3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForOdev3.Location = new System.Drawing.Point(183, 10);
            this.lblForOdev3.Name = "lblForOdev3";
            this.lblForOdev3.Size = new System.Drawing.Size(74, 20);
            this.lblForOdev3.TabIndex = 0;
            this.lblForOdev3.Text = "ÖDEV 3";
            // 
            // lblOdevInfo
            // 
            this.lblOdevInfo.AutoSize = true;
            this.lblOdevInfo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOdevInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdevInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOdevInfo.Location = new System.Drawing.Point(374, 460);
            this.lblOdevInfo.Name = "lblOdevInfo";
            this.lblOdevInfo.Size = new System.Drawing.Size(349, 20);
            this.lblOdevInfo.TabIndex = 8;
            this.lblOdevInfo.Text = "Hazırlayan : Orçun Özdil, Ergen Altiparmak";
            // 
            // OdevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1108, 489);
            this.Controls.Add(this.lblOdevInfo);
            this.Controls.Add(this.pnlOdev3);
            this.Controls.Add(this.pnlOdev2);
            this.Controls.Add(this.pnlOdev1);
            this.Name = "OdevForm";
            this.Text = "Ayrık Matematik ve Mühendisli Matematiği Ödevleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGvResult)).EndInit();
            this.pnlOdev1.ResumeLayout(false);
            this.pnlOdev1.PerformLayout();
            this.pnlOdev2.ResumeLayout(false);
            this.pnlOdev2.PerformLayout();
            this.pnlOdev3.ResumeLayout(false);
            this.pnlOdev3.PerformLayout();
            this.pnlSureHesabi.ResumeLayout(false);
            this.pnlSureHesabi.PerformLayout();
            this.pnlKutleHesabi.ResumeLayout(false);
            this.pnlKutleHesabi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTabloHesapla;
        private System.Windows.Forms.TextBox txBxMod;
        private System.Windows.Forms.DataGridView dGvResult;
        private System.Windows.Forms.Panel pnlOdev1;
        private System.Windows.Forms.RichTextBox richTxBxOdev1Sonuc;
        private System.Windows.Forms.Label lblForOdev1;
        private System.Windows.Forms.Panel pnlOdev2;
        private System.Windows.Forms.Label lblForOdev2;
        private System.Windows.Forms.Panel pnlOdev3;
        private System.Windows.Forms.Label lblForKutle;
        private System.Windows.Forms.Label lblForYarilanmaOmru;
        private System.Windows.Forms.ComboBox comBxKutle;
        private System.Windows.Forms.ComboBox comBxYO;
        private System.Windows.Forms.TextBox txBxKutle;
        private System.Windows.Forms.TextBox txBxYarilanmaOmru;
        private System.Windows.Forms.Label lblForOdev3;
        private System.Windows.Forms.TextBox txBxOdev1Info;
        private System.Windows.Forms.Label lblOdevInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txBxOdev2Info;
        private System.Windows.Forms.TextBox txBxOdev3Info;
        private System.Windows.Forms.RadioButton rdBtnSureBul;
        private System.Windows.Forms.RadioButton rdBtnKalanKutleBul;
        private System.Windows.Forms.Panel pnlSureHesabi;
        private System.Windows.Forms.Panel pnlKutleHesabi;
        private System.Windows.Forms.Button btnYarilanmaOmruHesapla;
        private System.Windows.Forms.Label lblKutleHesSure;
        private System.Windows.Forms.ComboBox comBxKutleHesSure;
        private System.Windows.Forms.TextBox txBxKutleHesSure;
        private System.Windows.Forms.RadioButton rdBtnSure2;
        private System.Windows.Forms.RadioButton rdBtnSure1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txBxSureHesKutleYuzdesi;
        private System.Windows.Forms.ComboBox comBxSureHesKutle;
        private System.Windows.Forms.TextBox txBxSureHesKutle;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.Label lblSureHesSonuc;
        private System.Windows.Forms.Label lblKutleHesSonuc;
        private System.Windows.Forms.Label lblYuzde;
    }
}

