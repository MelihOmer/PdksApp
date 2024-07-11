namespace PdksApp.WinForm
{
    partial class DeviceAddOrUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceAddOrUpdate));
            this.txtDeviceId = new DevExpress.XtraEditors.TextEdit();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.btnDeviceSaveCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeviceSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDeviceIpAdress = new DevExpress.XtraEditors.TextEdit();
            this.txtDeviceName = new DevExpress.XtraEditors.TextEdit();
            this.txtPortNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.checkStatus = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeviceId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeviceIpAdress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeviceName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPortNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Enabled = false;
            this.txtDeviceId.Location = new System.Drawing.Point(80, 59);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(31, 20);
            this.txtDeviceId.TabIndex = 28;
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Location = new System.Drawing.Point(80, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 22);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Yeni Okuyucu Ekle";
            // 
            // btnDeviceSaveCancel
            // 
            this.btnDeviceSaveCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeviceSaveCancel.ImageOptions.Image")));
            this.btnDeviceSaveCancel.Location = new System.Drawing.Point(172, 165);
            this.btnDeviceSaveCancel.Name = "btnDeviceSaveCancel";
            this.btnDeviceSaveCancel.Size = new System.Drawing.Size(88, 37);
            this.btnDeviceSaveCancel.TabIndex = 26;
            this.btnDeviceSaveCancel.Text = "Vazgeç";
            this.btnDeviceSaveCancel.Click += new System.EventHandler(this.btnDeviceSaveCancel_Click);
            // 
            // btnDeviceSave
            // 
            this.btnDeviceSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeviceSave.ImageOptions.Image")));
            this.btnDeviceSave.Location = new System.Drawing.Point(80, 165);
            this.btnDeviceSave.Name = "btnDeviceSave";
            this.btnDeviceSave.Size = new System.Drawing.Size(88, 37);
            this.btnDeviceSave.TabIndex = 25;
            this.btnDeviceSave.Text = "Kaydet";
            this.btnDeviceSave.Click += new System.EventHandler(this.btnDeviceSave_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 15);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Ip Adress :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 88);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 15);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "Cihaz Adı :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(22, 64);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 15);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Cihaz Id :";
            // 
            // txtDeviceIpAdress
            // 
            this.txtDeviceIpAdress.Location = new System.Drawing.Point(80, 109);
            this.txtDeviceIpAdress.Name = "txtDeviceIpAdress";
            this.txtDeviceIpAdress.Size = new System.Drawing.Size(182, 20);
            this.txtDeviceIpAdress.TabIndex = 21;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(80, 83);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(182, 20);
            this.txtDeviceName.TabIndex = 20;
            // 
            // txtPortNo
            // 
            this.txtPortNo.Location = new System.Drawing.Point(80, 135);
            this.txtPortNo.Name = "txtPortNo";
            this.txtPortNo.Size = new System.Drawing.Size(182, 20);
            this.txtPortNo.TabIndex = 29;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(43, 137);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 15);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "Port :";
            // 
            // checkStatus
            // 
            this.checkStatus.Location = new System.Drawing.Point(200, 57);
            this.checkStatus.Name = "checkStatus";
            this.checkStatus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkStatus.Properties.Appearance.Options.UseFont = true;
            this.checkStatus.Properties.Caption = "Aktif";
            this.checkStatus.Size = new System.Drawing.Size(60, 20);
            this.checkStatus.TabIndex = 31;
            // 
            // DeviceAddOrUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(329, 240);
            this.Controls.Add(this.checkStatus);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtPortNo);
            this.Controls.Add(this.txtDeviceId);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDeviceSaveCancel);
            this.Controls.Add(this.btnDeviceSave);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtDeviceIpAdress);
            this.Controls.Add(this.txtDeviceName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DeviceAddOrUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okuyucu Ekleme - Güncelleme Paneli";
            this.Load += new System.EventHandler(this.DeviceAddOrUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDeviceId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeviceIpAdress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeviceName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPortNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkStatus.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtDeviceId;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.SimpleButton btnDeviceSaveCancel;
        private DevExpress.XtraEditors.SimpleButton btnDeviceSave;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDeviceIpAdress;
        private DevExpress.XtraEditors.TextEdit txtDeviceName;
        private DevExpress.XtraEditors.TextEdit txtPortNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit checkStatus;
    }
}