namespace PdksApp.WinForm
{
    partial class OkuyucuTanimlari
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
            this.deviceGridControl = new DevExpress.XtraGrid.GridControl();
            this.deviceGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.deviceGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceGridControl
            // 
            this.deviceGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceGridControl.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.deviceGridControl.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deviceGridControl.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.deviceGridControl.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.deviceGridControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deviceGridControl.Location = new System.Drawing.Point(0, 0);
            this.deviceGridControl.MainView = this.deviceGrid;
            this.deviceGridControl.Name = "deviceGridControl";
            this.deviceGridControl.Size = new System.Drawing.Size(1012, 519);
            this.deviceGridControl.TabIndex = 1;
            this.deviceGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.deviceGrid});
            // 
            // deviceGrid
            // 
            this.deviceGrid.Appearance.Row.BackColor = System.Drawing.Color.LightCyan;
            this.deviceGrid.Appearance.Row.BorderColor = System.Drawing.Color.Black;
            this.deviceGrid.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deviceGrid.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.deviceGrid.Appearance.Row.Options.UseBackColor = true;
            this.deviceGrid.Appearance.Row.Options.UseBorderColor = true;
            this.deviceGrid.Appearance.Row.Options.UseFont = true;
            this.deviceGrid.Appearance.Row.Options.UseForeColor = true;
            this.deviceGrid.Appearance.SelectedRow.BackColor = System.Drawing.Color.DarkCyan;
            this.deviceGrid.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Black;
            this.deviceGrid.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.deviceGrid.Appearance.SelectedRow.Options.UseBackColor = true;
            this.deviceGrid.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.deviceGrid.Appearance.SelectedRow.Options.UseForeColor = true;
            this.deviceGrid.GridControl = this.deviceGridControl;
            this.deviceGrid.GroupPanelText = "Gruplamak İstediğiniz Sütunu Sürükleyin.";
            this.deviceGrid.GroupRowHeight = 5;
            this.deviceGrid.Name = "deviceGrid";
            this.deviceGrid.OptionsBehavior.Editable = false;
            this.deviceGrid.OptionsBehavior.ReadOnly = true;
            this.deviceGrid.OptionsFind.FindDelay = 500;
            this.deviceGrid.OptionsFind.FindNullPrompt = "Aramak istediğiniz Kelimeyi Girin";
            this.deviceGrid.OptionsMenu.ShowFooterItem = true;
            this.deviceGrid.OptionsView.ShowAutoFilterRow = true;
            this.deviceGrid.OptionsView.ShowFooter = true;
            // 
            // OkuyucuTanimlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deviceGridControl);
            this.Name = "OkuyucuTanimlari";
            this.Size = new System.Drawing.Size(1012, 519);
            this.Load += new System.EventHandler(this.OkuyucuTanimlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deviceGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl deviceGridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView deviceGrid;
    }
}
