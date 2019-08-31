namespace BankaOtomasyon.UI.WinForm
{
    partial class FrmHesapIslemleri
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_hesapdetay = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_hesapcvv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_hesapsifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_hesapbakiye = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_hesapskt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_hesapiban = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hesapsahibi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_hesapno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_hesapid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grd_hesaplar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_hesaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(332, 435);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 25;
            this.simpleButton4.Text = "Temizle";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(241, 435);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 24;
            this.simpleButton3.Text = "Güncelle";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(144, 435);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 23;
            this.simpleButton2.Text = "Sil";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(49, 435);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 22;
            this.simpleButton1.Text = "Ekle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txt_hesapdetay
            // 
            this.txt_hesapdetay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_hesapdetay.Location = new System.Drawing.Point(181, 321);
            this.txt_hesapdetay.Name = "txt_hesapdetay";
            this.txt_hesapdetay.Size = new System.Drawing.Size(201, 27);
            this.txt_hesapdetay.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(64, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "HesapDetay";
            // 
            // txt_hesapcvv
            // 
            this.txt_hesapcvv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_hesapcvv.Location = new System.Drawing.Point(181, 288);
            this.txt_hesapcvv.Name = "txt_hesapcvv";
            this.txt_hesapcvv.Size = new System.Drawing.Size(201, 27);
            this.txt_hesapcvv.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(74, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "HesapCVV";
            // 
            // txt_hesapsifre
            // 
            this.txt_hesapsifre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_hesapsifre.Location = new System.Drawing.Point(181, 255);
            this.txt_hesapsifre.Name = "txt_hesapsifre";
            this.txt_hesapsifre.Size = new System.Drawing.Size(201, 27);
            this.txt_hesapsifre.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(72, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "HesapSifre";
            // 
            // txt_hesapbakiye
            // 
            this.txt_hesapbakiye.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_hesapbakiye.Location = new System.Drawing.Point(181, 222);
            this.txt_hesapbakiye.Name = "txt_hesapbakiye";
            this.txt_hesapbakiye.Size = new System.Drawing.Size(201, 27);
            this.txt_hesapbakiye.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(59, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "HesapBakiye";
            // 
            // txt_hesapskt
            // 
            this.txt_hesapskt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_hesapskt.Location = new System.Drawing.Point(181, 189);
            this.txt_hesapskt.Name = "txt_hesapskt";
            this.txt_hesapskt.Size = new System.Drawing.Size(201, 27);
            this.txt_hesapskt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(76, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "HesapSKT";
            // 
            // txt_hesapiban
            // 
            this.txt_hesapiban.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_hesapiban.Location = new System.Drawing.Point(181, 156);
            this.txt_hesapiban.Name = "txt_hesapiban";
            this.txt_hesapiban.Size = new System.Drawing.Size(201, 27);
            this.txt_hesapiban.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(67, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "HesapIBAN";
            // 
            // txt_hesapsahibi
            // 
            this.txt_hesapsahibi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_hesapsahibi.Location = new System.Drawing.Point(181, 123);
            this.txt_hesapsahibi.Name = "txt_hesapsahibi";
            this.txt_hesapsahibi.Size = new System.Drawing.Size(201, 27);
            this.txt_hesapsahibi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(61, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "HesapSahibi";
            // 
            // txt_hesapno
            // 
            this.txt_hesapno.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_hesapno.Location = new System.Drawing.Point(181, 90);
            this.txt_hesapno.Name = "txt_hesapno";
            this.txt_hesapno.Size = new System.Drawing.Size(201, 27);
            this.txt_hesapno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(84, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "HesapNo";
            // 
            // txt_hesapid
            // 
            this.txt_hesapid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_hesapid.Location = new System.Drawing.Point(181, 57);
            this.txt_hesapid.Name = "txt_hesapid";
            this.txt_hesapid.Size = new System.Drawing.Size(201, 27);
            this.txt_hesapid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(87, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "HesapID";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton4);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.txt_hesapdetay);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.txt_hesapcvv);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.txt_hesapsifre);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txt_hesapbakiye);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txt_hesapskt);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txt_hesapiban);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txt_hesapsahibi);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txt_hesapno);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txt_hesapid);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(875, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(493, 559);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "groupControl1";
            // 
            // grd_hesaplar
            // 
            gridLevelNode1.RelationName = "Level1";
            this.grd_hesaplar.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grd_hesaplar.Location = new System.Drawing.Point(3, 1);
            this.grd_hesaplar.MainView = this.gridView1;
            this.grd_hesaplar.Name = "grd_hesaplar";
            this.grd_hesaplar.Size = new System.Drawing.Size(866, 559);
            this.grd_hesaplar.TabIndex = 2;
            this.grd_hesaplar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grd_hesaplar;
            this.gridView1.Name = "gridView1";
            // 
            // FrmHesapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 561);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grd_hesaplar);
            this.Name = "FrmHesapIslemleri";
            this.Text = "FrmHesapIslemleri";
            this.Load += new System.EventHandler(this.FrmHesapIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_hesaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txt_hesapdetay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_hesapcvv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_hesapsifre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_hesapbakiye;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_hesapskt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_hesapiban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hesapsahibi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_hesapno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_hesapid;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grd_hesaplar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}