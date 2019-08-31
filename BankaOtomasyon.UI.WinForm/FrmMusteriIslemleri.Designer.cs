namespace BankaOtomasyon.UI.WinForm
{
    partial class FrmMusteriIslemleri
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.grd_musteriler = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_musteriadres = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_musteriilce = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_musteriil = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_musteritelefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_musterihesapno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_musteritip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_musteridogumtarihi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_musterisoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_musteriad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_musteritc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_musteriid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_musteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd_musteriler
            // 
            gridLevelNode2.RelationName = "Level1";
            this.grd_musteriler.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.grd_musteriler.Location = new System.Drawing.Point(1, 0);
            this.grd_musteriler.MainView = this.gridView1;
            this.grd_musteriler.Name = "grd_musteriler";
            this.grd_musteriler.Size = new System.Drawing.Size(866, 559);
            this.grd_musteriler.TabIndex = 0;
            this.grd_musteriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grd_musteriler;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton4);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.txt_musteriadres);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.txt_musteriilce);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.txt_musteriil);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.txt_musteritelefon);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.txt_musterihesapno);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txt_musteritip);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txt_musteridogumtarihi);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txt_musterisoyad);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txt_musteriad);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txt_musteritc);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txt_musteriid);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(873, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(493, 559);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
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
            // txt_musteriadres
            // 
            this.txt_musteriadres.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_musteriadres.Location = new System.Drawing.Point(181, 387);
            this.txt_musteriadres.Name = "txt_musteriadres";
            this.txt_musteriadres.Size = new System.Drawing.Size(201, 27);
            this.txt_musteriadres.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(58, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "MusteriAdres";
            // 
            // txt_musteriilce
            // 
            this.txt_musteriilce.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_musteriilce.Location = new System.Drawing.Point(181, 354);
            this.txt_musteriilce.Name = "txt_musteriilce";
            this.txt_musteriilce.Size = new System.Drawing.Size(201, 27);
            this.txt_musteriilce.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(74, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "MusteriIlce";
            // 
            // txt_musteriil
            // 
            this.txt_musteriil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_musteriil.Location = new System.Drawing.Point(181, 321);
            this.txt_musteriil.Name = "txt_musteriil";
            this.txt_musteriil.Size = new System.Drawing.Size(201, 27);
            this.txt_musteriil.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(89, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "MusteriIl";
            // 
            // txt_musteritelefon
            // 
            this.txt_musteritelefon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_musteritelefon.Location = new System.Drawing.Point(181, 288);
            this.txt_musteritelefon.Name = "txt_musteritelefon";
            this.txt_musteritelefon.Size = new System.Drawing.Size(201, 27);
            this.txt_musteritelefon.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(46, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "MusteriTelefon";
            // 
            // txt_musterihesapno
            // 
            this.txt_musterihesapno.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_musterihesapno.Location = new System.Drawing.Point(181, 255);
            this.txt_musterihesapno.Name = "txt_musterihesapno";
            this.txt_musterihesapno.Size = new System.Drawing.Size(201, 27);
            this.txt_musterihesapno.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(36, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "MusteriHesapNo";
            // 
            // txt_musteritip
            // 
            this.txt_musteritip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_musteritip.Location = new System.Drawing.Point(181, 222);
            this.txt_musteritip.Name = "txt_musteritip";
            this.txt_musteritip.Size = new System.Drawing.Size(201, 27);
            this.txt_musteritip.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(76, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "MusteriTip";
            // 
            // txt_musteridogumtarihi
            // 
            this.txt_musteridogumtarihi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_musteridogumtarihi.Location = new System.Drawing.Point(181, 189);
            this.txt_musteridogumtarihi.Name = "txt_musteridogumtarihi";
            this.txt_musteridogumtarihi.Size = new System.Drawing.Size(201, 27);
            this.txt_musteridogumtarihi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "MusteriDogumTarihi";
            // 
            // txt_musterisoyad
            // 
            this.txt_musterisoyad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_musterisoyad.Location = new System.Drawing.Point(181, 156);
            this.txt_musterisoyad.Name = "txt_musterisoyad";
            this.txt_musterisoyad.Size = new System.Drawing.Size(201, 27);
            this.txt_musterisoyad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(56, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "MusteriSoyad";
            // 
            // txt_musteriad
            // 
            this.txt_musteriad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_musteriad.Location = new System.Drawing.Point(181, 123);
            this.txt_musteriad.Name = "txt_musteriad";
            this.txt_musteriad.Size = new System.Drawing.Size(201, 27);
            this.txt_musteriad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(79, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "MusteriAd";
            // 
            // txt_musteritc
            // 
            this.txt_musteritc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_musteritc.Location = new System.Drawing.Point(181, 90);
            this.txt_musteritc.Name = "txt_musteritc";
            this.txt_musteritc.Size = new System.Drawing.Size(201, 27);
            this.txt_musteritc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(79, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "MusteriTC";
            // 
            // txt_musteriid
            // 
            this.txt_musteriid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_musteriid.Location = new System.Drawing.Point(181, 57);
            this.txt_musteriid.Name = "txt_musteriid";
            this.txt_musteriid.Size = new System.Drawing.Size(201, 27);
            this.txt_musteriid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(82, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "MusteriID";
            // 
            // FrmMusteriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 561);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grd_musteriler);
            this.Name = "FrmMusteriIslemleri";
            this.Text = "FrmMusteriIslemleri";
            this.Load += new System.EventHandler(this.FrmMusteriIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_musteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_musteriler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txt_musteriid;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txt_musteriadres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_musteriilce;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_musteriil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_musteritelefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_musterihesapno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_musteritip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_musteridogumtarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_musterisoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_musteriad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_musteritc;
        private System.Windows.Forms.Label label2;
    }
}