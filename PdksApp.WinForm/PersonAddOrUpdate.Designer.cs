namespace PdksApp.WinForm
{
    partial class PersonAddOrUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonAddOrUpdate));
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.btnPersonSaveCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCardNo = new DevExpress.XtraEditors.TextEdit();
            this.txtNameSurname = new DevExpress.XtraEditors.TextEdit();
            this.txtPersonId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTckNo = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTckNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Location = new System.Drawing.Point(88, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(156, 22);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Yeni Personel Ekle";
            // 
            // btnPersonSaveCancel
            // 
            this.btnPersonSaveCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonSaveCancel.ImageOptions.Image")));
            this.btnPersonSaveCancel.Location = new System.Drawing.Point(197, 174);
            this.btnPersonSaveCancel.Name = "btnPersonSaveCancel";
            this.btnPersonSaveCancel.Size = new System.Drawing.Size(88, 37);
            this.btnPersonSaveCancel.TabIndex = 17;
            this.btnPersonSaveCancel.Text = "Vazgeç";
            this.btnPersonSaveCancel.Click += new System.EventHandler(this.btnPersonSaveCancel_Click);
            // 
            // btnPersonSave
            // 
            this.btnPersonSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonSave.ImageOptions.Image")));
            this.btnPersonSave.Location = new System.Drawing.Point(105, 174);
            this.btnPersonSave.Name = "btnPersonSave";
            this.btnPersonSave.Size = new System.Drawing.Size(88, 37);
            this.btnPersonSave.TabIndex = 16;
            this.btnPersonSave.Text = "Kaydet";
            this.btnPersonSave.Click += new System.EventHandler(this.btnPersonSave_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(9, 123);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(89, 15);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Kart Numarası :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(41, 100);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 15);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Ad Soyad :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(11, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 15);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Personel Kodu :";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(105, 121);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(182, 20);
            this.txtCardNo.TabIndex = 11;
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Location = new System.Drawing.Point(105, 95);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(182, 20);
            this.txtNameSurname.TabIndex = 10;
            // 
            // txtPersonId
            // 
            this.txtPersonId.Enabled = false;
            this.txtPersonId.Location = new System.Drawing.Point(105, 71);
            this.txtPersonId.Name = "txtPersonId";
            this.txtPersonId.Size = new System.Drawing.Size(43, 20);
            this.txtPersonId.TabIndex = 19;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(17, 149);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 15);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Tc Kimlik No :";
            // 
            // txtTckNo
            // 
            this.txtTckNo.Location = new System.Drawing.Point(105, 147);
            this.txtTckNo.Name = "txtTckNo";
            this.txtTckNo.Size = new System.Drawing.Size(182, 20);
            this.txtTckNo.TabIndex = 21;
            // 
            // PersonAddOrUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(329, 240);
            this.Controls.Add(this.txtTckNo);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtPersonId);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPersonSaveCancel);
            this.Controls.Add(this.btnPersonSave);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.txtNameSurname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(345, 279);
            this.MinimumSize = new System.Drawing.Size(345, 279);
            this.Name = "PersonAddOrUpdate";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Ekleme - Güncelleme Paneli";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PersonAddOrUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCardNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTckNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.SimpleButton btnPersonSaveCancel;
        private DevExpress.XtraEditors.SimpleButton btnPersonSave;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCardNo;
        private DevExpress.XtraEditors.TextEdit txtNameSurname;
        private DevExpress.XtraEditors.TextEdit txtPersonId;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTckNo;
    }
}