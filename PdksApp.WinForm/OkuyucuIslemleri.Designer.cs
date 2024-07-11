namespace PdksApp.WinForm
{
    partial class OkuyucuIslemleri
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControlDevice = new DevExpress.XtraGrid.GridControl();
            this.gridViewDevice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabPersonList = new DevExpress.XtraTab.XtraTabPage();
            this.userGridControl = new DevExpress.XtraGrid.GridControl();
            this.userGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabEvents = new DevExpress.XtraTab.XtraTabPage();
            this.txtEventLog = new System.Windows.Forms.RichTextBox();
            this.tabReaderEvents = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlDevicePerson = new DevExpress.XtraGrid.GridControl();
            this.gridDevicePerson = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPersonList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).BeginInit();
            this.tabEvents.SuspendLayout();
            this.tabReaderEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDevicePerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDevicePerson)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlDevice
            // 
            this.gridControlDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlDevice.Location = new System.Drawing.Point(0, 0);
            this.gridControlDevice.MainView = this.gridViewDevice;
            this.gridControlDevice.MinimumSize = new System.Drawing.Size(0, 219);
            this.gridControlDevice.Name = "gridControlDevice";
            this.gridControlDevice.Size = new System.Drawing.Size(1012, 219);
            this.gridControlDevice.TabIndex = 2;
            this.gridControlDevice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDevice});
            // 
            // gridViewDevice
            // 
            this.gridViewDevice.Appearance.Empty.BackColor = System.Drawing.Color.SkyBlue;
            this.gridViewDevice.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewDevice.Appearance.FocusedCell.BackColor = System.Drawing.Color.SteelBlue;
            this.gridViewDevice.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewDevice.Appearance.FocusedRow.BackColor = System.Drawing.Color.SteelBlue;
            this.gridViewDevice.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewDevice.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridViewDevice.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewDevice.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewDevice.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewDevice.Appearance.Row.BackColor = System.Drawing.Color.SkyBlue;
            this.gridViewDevice.Appearance.Row.BorderColor = System.Drawing.Color.Black;
            this.gridViewDevice.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridViewDevice.Appearance.Row.Options.UseBackColor = true;
            this.gridViewDevice.Appearance.Row.Options.UseBorderColor = true;
            this.gridViewDevice.Appearance.Row.Options.UseFont = true;
            this.gridViewDevice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridViewDevice.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewDevice.GridControl = this.gridControlDevice;
            this.gridViewDevice.GroupPanelText = "Gruplamak İstediğiniz Sütunu Sürükleyin.";
            this.gridViewDevice.Name = "gridViewDevice";
            this.gridViewDevice.OptionsFind.AllowFindPanel = false;
            this.gridViewDevice.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewDevice.OptionsView.ShowGroupPanel = false;
            // 
            // tabControl
            // 
            this.tabControl.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.tabControl.Appearance.Options.UseBackColor = true;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.tabControl.Location = new System.Drawing.Point(0, 219);
            this.tabControl.MaximumSize = new System.Drawing.Size(0, 650);
            this.tabControl.MinimumSize = new System.Drawing.Size(0, 483);
            this.tabControl.MultiLine = DevExpress.Utils.DefaultBoolean.False;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabPage = this.tabPersonList;
            this.tabControl.Size = new System.Drawing.Size(1012, 489);
            this.tabControl.TabIndex = 3;
            this.tabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPersonList,
            this.tabEvents,
            this.tabReaderEvents});
            // 
            // tabPersonList
            // 
            this.tabPersonList.Appearance.PageClient.BackColor = System.Drawing.Color.LightGray;
            this.tabPersonList.Appearance.PageClient.Options.UseBackColor = true;
            this.tabPersonList.Controls.Add(this.userGridControl);
            this.tabPersonList.Name = "tabPersonList";
            this.tabPersonList.Size = new System.Drawing.Size(1010, 464);
            this.tabPersonList.Text = "Personel Kayıtları";
            // 
            // userGridControl
            // 
            this.userGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userGridControl.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.userGridControl.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userGridControl.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.userGridControl.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.userGridControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userGridControl.Location = new System.Drawing.Point(0, 0);
            this.userGridControl.MainView = this.userGrid;
            this.userGridControl.Name = "userGridControl";
            this.userGridControl.Size = new System.Drawing.Size(1010, 464);
            this.userGridControl.TabIndex = 1;
            this.userGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.userGrid});
            // 
            // userGrid
            // 
            this.userGrid.Appearance.Empty.BackColor = System.Drawing.Color.LightCyan;
            this.userGrid.Appearance.Empty.Options.UseBackColor = true;
            this.userGrid.Appearance.FocusedCell.BackColor = System.Drawing.Color.Teal;
            this.userGrid.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Black;
            this.userGrid.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userGrid.Appearance.FocusedCell.Options.UseBackColor = true;
            this.userGrid.Appearance.FocusedCell.Options.UseBorderColor = true;
            this.userGrid.Appearance.FocusedCell.Options.UseFont = true;
            this.userGrid.Appearance.FocusedRow.BackColor = System.Drawing.Color.Teal;
            this.userGrid.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Black;
            this.userGrid.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userGrid.Appearance.FocusedRow.Options.UseBackColor = true;
            this.userGrid.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.userGrid.Appearance.FocusedRow.Options.UseFont = true;
            this.userGrid.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userGrid.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.userGrid.Appearance.HeaderPanel.Options.UseFont = true;
            this.userGrid.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.userGrid.Appearance.Row.BackColor = System.Drawing.Color.LightCyan;
            this.userGrid.Appearance.Row.BorderColor = System.Drawing.Color.Black;
            this.userGrid.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userGrid.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.userGrid.Appearance.Row.Options.UseBackColor = true;
            this.userGrid.Appearance.Row.Options.UseBorderColor = true;
            this.userGrid.Appearance.Row.Options.UseFont = true;
            this.userGrid.Appearance.Row.Options.UseForeColor = true;
            this.userGrid.Appearance.SelectedRow.BackColor = System.Drawing.Color.DarkCyan;
            this.userGrid.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Black;
            this.userGrid.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.userGrid.Appearance.SelectedRow.Options.UseBackColor = true;
            this.userGrid.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.userGrid.Appearance.SelectedRow.Options.UseForeColor = true;
            this.userGrid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.userGrid.GridControl = this.userGridControl;
            this.userGrid.GroupPanelText = "Gruplamak İstediğiniz Sütunu Sürükleyin.";
            this.userGrid.GroupRowHeight = 5;
            this.userGrid.Name = "userGrid";
            this.userGrid.OptionsCustomization.AllowRowSizing = true;
            this.userGrid.OptionsFind.AlwaysVisible = true;
            this.userGrid.OptionsFind.FindDelay = 250;
            this.userGrid.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.userGrid.OptionsFind.FindNullPrompt = "Aramak istediğiniz Kelimeyi Girin";
            this.userGrid.OptionsFind.ShowFindButton = false;
            this.userGrid.OptionsMenu.ShowAutoFilterRowItem = false;
            this.userGrid.OptionsMenu.ShowFooterItem = true;
            this.userGrid.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office2003;
            this.userGrid.OptionsView.ShowFooter = true;
            this.userGrid.OptionsView.ShowGroupPanel = false;
            // 
            // tabEvents
            // 
            this.tabEvents.Controls.Add(this.txtEventLog);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Size = new System.Drawing.Size(1010, 464);
            this.tabEvents.Text = "Olaylar";
            // 
            // txtEventLog
            // 
            this.txtEventLog.BackColor = System.Drawing.Color.RosyBrown;
            this.txtEventLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEventLog.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEventLog.Location = new System.Drawing.Point(0, 0);
            this.txtEventLog.Name = "txtEventLog";
            this.txtEventLog.Size = new System.Drawing.Size(1010, 464);
            this.txtEventLog.TabIndex = 0;
            this.txtEventLog.Text = "";
            // 
            // tabReaderEvents
            // 
            this.tabReaderEvents.Controls.Add(this.gridControlDevicePerson);
            this.tabReaderEvents.Name = "tabReaderEvents";
            this.tabReaderEvents.Size = new System.Drawing.Size(1010, 464);
            this.tabReaderEvents.Text = "Okuyucu Kayıtları";
            // 
            // gridControlDevicePerson
            // 
            this.gridControlDevicePerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDevicePerson.Location = new System.Drawing.Point(0, 0);
            this.gridControlDevicePerson.MainView = this.gridDevicePerson;
            this.gridControlDevicePerson.Name = "gridControlDevicePerson";
            this.gridControlDevicePerson.Size = new System.Drawing.Size(1010, 464);
            this.gridControlDevicePerson.TabIndex = 0;
            this.gridControlDevicePerson.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDevicePerson});
            // 
            // gridDevicePerson
            // 
            this.gridDevicePerson.GridControl = this.gridControlDevicePerson;
            this.gridDevicePerson.Name = "gridDevicePerson";
            this.gridDevicePerson.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridDevicePerson.OptionsView.ShowAutoFilterRow = true;
            this.gridDevicePerson.OptionsView.ShowGroupPanel = false;
            // 
            // OkuyucuIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.gridControlDevice);
            this.Name = "OkuyucuIslemleri";
            this.Size = new System.Drawing.Size(1012, 708);
            this.Load += new System.EventHandler(this.OkuyucuIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPersonList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).EndInit();
            this.tabEvents.ResumeLayout(false);
            this.tabReaderEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDevicePerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDevicePerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlDevice;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDevice;
        private DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraTab.XtraTabPage tabPersonList;
        public DevExpress.XtraGrid.GridControl userGridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView userGrid;
        private DevExpress.XtraTab.XtraTabPage tabEvents;
        private DevExpress.XtraTab.XtraTabPage tabReaderEvents;
        private System.Windows.Forms.RichTextBox txtEventLog;
        private DevExpress.XtraGrid.GridControl gridControlDevicePerson;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDevicePerson;
    }
}
