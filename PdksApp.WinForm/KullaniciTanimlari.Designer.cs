namespace PdksApp.WinForm
{
    partial class KullaniciTanimlari
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
            this.userGridControl = new DevExpress.XtraGrid.GridControl();
            this.userGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.userGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).BeginInit();
            this.SuspendLayout();
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
            this.userGridControl.Size = new System.Drawing.Size(1012, 519);
            this.userGridControl.TabIndex = 0;
            this.userGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.userGrid});
            // 
            // userGrid
            // 
            this.userGrid.Appearance.Row.BackColor = System.Drawing.Color.LightCyan;
            this.userGrid.Appearance.Row.BorderColor = System.Drawing.Color.Black;
            this.userGrid.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.userGrid.GridControl = this.userGridControl;
            this.userGrid.GroupPanelText = "Gruplamak İstediğiniz Sütunu Sürükleyin.";
            this.userGrid.GroupRowHeight = 5;
            this.userGrid.Name = "userGrid";
            this.userGrid.OptionsBehavior.Editable = false;
            this.userGrid.OptionsBehavior.ReadOnly = true;
            this.userGrid.OptionsFind.FindDelay = 500;
            this.userGrid.OptionsFind.FindNullPrompt = "Aramak istediğiniz Kelimeyi Girin";
            this.userGrid.OptionsMenu.ShowFooterItem = true;
            this.userGrid.OptionsView.ShowAutoFilterRow = true;
            this.userGrid.OptionsView.ShowFooter = true;
            // 
            // KullaniciTanimlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userGridControl);
            this.Name = "KullaniciTanimlari";
            this.Size = new System.Drawing.Size(1012, 519);
            this.Load += new System.EventHandler(this.KullaniciTanimlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraGrid.Views.Grid.GridView userGrid;
        public DevExpress.XtraGrid.GridControl userGridControl;
    }
}
