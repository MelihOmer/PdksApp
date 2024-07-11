namespace PdksApp.WinForm
{
    partial class CardOperations
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardOperations));
            this.PageReader = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnGetDevice = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnConnectedDevice = new DevExpress.XtraBars.BarButtonItem();
            this.btnDisconnectedDevice = new DevExpress.XtraBars.BarButtonItem();
            this.btnCardWorkStart = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeviceWorkStop = new DevExpress.XtraBars.BarButtonItem();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barLinkContainerItem1 = new DevExpress.XtraBars.BarLinkContainerItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.barListItem2 = new DevExpress.XtraBars.BarListItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barBtnDeviceList = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDeviceAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDeviceDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnPersonList = new DevExpress.XtraBars.BarButtonItem();
            this.btnPersonAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDeviceEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.btnPersonEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnPersonDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barToggleSwitchItem2 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barEditItem4 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.PageReaderManager = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageUserManager = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.checkPassword = new DevExpress.XtraBars.BarCheckItem();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PageReader
            // 
            this.PageReader.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
            this.PageReader.Name = "PageReader";
            this.PageReader.Text = "Okuyucu İşlemleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageGroup1.ImageOptions.SvgImage")));
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGetDevice);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnConnectedDevice, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDisconnectedDevice);
            this.ribbonPageGroup1.KeyTip = "CİHAZLARI LİSTELER";
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Okuyucu İşlemleri";
            // 
            // btnGetDevice
            // 
            this.btnGetDevice.Caption = "Okuyucuları Getir";
            this.btnGetDevice.Id = 4;
            this.btnGetDevice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGetDevice.ImageOptions.SvgImage")));
            this.btnGetDevice.Name = "btnGetDevice";
            this.btnGetDevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGetDevice_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.ActAsDropDown = true;
            this.barButtonItem4.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem4.Caption = "Okuyucu Seçim";
            this.barButtonItem4.DropDownControl = this.popupMenu1;
            this.barButtonItem4.Id = 7;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // popupMenu1
            // 
            this.popupMenu1.ItemLinks.Add(this.barButtonItem1);
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbonControl1;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "selectAllDevice";
            this.barButtonItem1.Id = 36;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.White;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.VisibleInSearchMenu = false;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.skinPaletteDropDownButtonItem1,
            this.skinDropDownButtonItem1,
            this.barSubItem1,
            this.btnGetDevice,
            this.btnConnectedDevice,
            this.btnDisconnectedDevice,
            this.barButtonItem4,
            this.btnCardWorkStart,
            this.btnDeviceWorkStop,
            this.barListItem1,
            this.barToggleSwitchItem1,
            this.barLinkContainerItem1,
            this.barSubItem2,
            this.ribbonGalleryBarItem1,
            this.barEditItem1,
            this.barEditItem2,
            this.barListItem2,
            this.barStaticItem1,
            this.barMdiChildrenListItem1,
            this.barEditItem3,
            this.barBtnDeviceList,
            this.barBtnDeviceAdd,
            this.barBtnDeviceDelete,
            this.btnPersonList,
            this.btnPersonAdd,
            this.barBtnDeviceEdit,
            this.barButtonGroup1,
            this.btnPersonEdit,
            this.btnPersonDelete,
            this.barToggleSwitchItem2,
            this.barEditItem4,
            this.barButtonItem1,
            this.checkPassword});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 43;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.PageReader,
            this.PageReaderManager,
            this.PageUserManager});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemCheckedComboBoxEdit1,
            this.repositoryItemComboBox2,
            this.repositoryItemLookUpEdit1});
            this.ribbonControl1.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Center;
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(1012, 141);
            this.ribbonControl1.SelectedPageChanged += new System.EventHandler(this.ribbonControl1_SelectedPageChanged);
            // 
            // skinPaletteDropDownButtonItem1
            // 
            this.skinPaletteDropDownButtonItem1.Id = 1;
            this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 2;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 3;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnConnectedDevice
            // 
            this.btnConnectedDevice.Caption = "Bağlantı Kur";
            this.btnConnectedDevice.Id = 5;
            this.btnConnectedDevice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnConnectedDevice.ImageOptions.SvgImage")));
            this.btnConnectedDevice.Name = "btnConnectedDevice";
            this.btnConnectedDevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnConnectedDevice_ItemClick);
            // 
            // btnDisconnectedDevice
            // 
            this.btnDisconnectedDevice.Caption = "Bağlantı Kes";
            this.btnDisconnectedDevice.Id = 6;
            this.btnDisconnectedDevice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDisconnectedDevice.ImageOptions.SvgImage")));
            this.btnDisconnectedDevice.Name = "btnDisconnectedDevice";
            this.btnDisconnectedDevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDisconnectedDevice_ItemClick);
            // 
            // btnCardWorkStart
            // 
            this.btnCardWorkStart.Caption = "Çalışmayı Başlat";
            this.btnCardWorkStart.Id = 8;
            this.btnCardWorkStart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCardWorkStart.ImageOptions.Image")));
            this.btnCardWorkStart.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCardWorkStart.ImageOptions.LargeImage")));
            this.btnCardWorkStart.Name = "btnCardWorkStart";
            this.btnCardWorkStart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCardWorkStart_ItemClick);
            // 
            // btnDeviceWorkStop
            // 
            this.btnDeviceWorkStop.Caption = "Çalışmayı Durdur";
            this.btnDeviceWorkStop.Id = 9;
            this.btnDeviceWorkStop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeviceWorkStop.ImageOptions.Image")));
            this.btnDeviceWorkStop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDeviceWorkStop.ImageOptions.LargeImage")));
            this.btnDeviceWorkStop.Name = "btnDeviceWorkStop";
            this.btnDeviceWorkStop.VisibleInSearchMenu = false;
            this.btnDeviceWorkStop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeviceWorkStop_ItemClick);
            // 
            // barListItem1
            // 
            this.barListItem1.Caption = "barListItem1";
            this.barListItem1.Id = 10;
            this.barListItem1.Name = "barListItem1";
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Caption = "barToggleSwitchItem1";
            this.barToggleSwitchItem1.Id = 11;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // barLinkContainerItem1
            // 
            this.barLinkContainerItem1.Caption = "barLinkContainerItem1";
            this.barLinkContainerItem1.Id = 12;
            this.barLinkContainerItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2)});
            this.barLinkContainerItem1.Name = "barLinkContainerItem1";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "barSubItem2";
            this.barSubItem2.Id = 13;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            this.ribbonGalleryBarItem1.Id = 14;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.AccessibleRole = System.Windows.Forms.AccessibleRole.ListItem;
            this.barEditItem1.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.True;
            this.barEditItem1.Caption = "Çalışma Şekli";
            this.barEditItem1.Edit = this.repositoryItemComboBox1;
            this.barEditItem1.EditWidth = 100;
            this.barEditItem1.Id = 15;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemComboBox1.DropDownRows = 4;
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.EditValueChanged += new System.EventHandler(this.repositoryItemComboBox1_EditValueChanged);
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "barEditItem2";
            this.barEditItem2.Edit = this.repositoryItemCheckedComboBoxEdit1;
            this.barEditItem2.Id = 18;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            // 
            // barListItem2
            // 
            this.barListItem2.Caption = "barListItem2";
            this.barListItem2.Id = 19;
            this.barListItem2.Name = "barListItem2";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 20;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1";
            this.barMdiChildrenListItem1.Id = 21;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // barEditItem3
            // 
            this.barEditItem3.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.True;
            this.barEditItem3.Caption = "barEditItem3";
            this.barEditItem3.Edit = this.repositoryItemComboBox2;
            this.barEditItem3.Id = 22;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // barBtnDeviceList
            // 
            this.barBtnDeviceList.Caption = "Okuyucuları Listele";
            this.barBtnDeviceList.Id = 24;
            this.barBtnDeviceList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnDeviceList.ImageOptions.SvgImage")));
            this.barBtnDeviceList.Name = "barBtnDeviceList";
            this.barBtnDeviceList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDeviceList_ItemClick);
            // 
            // barBtnDeviceAdd
            // 
            this.barBtnDeviceAdd.Caption = "Okuyucu Ekle";
            this.barBtnDeviceAdd.Id = 25;
            this.barBtnDeviceAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnDeviceAdd.ImageOptions.SvgImage")));
            this.barBtnDeviceAdd.Name = "barBtnDeviceAdd";
            this.barBtnDeviceAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDeviceAdd_ItemClick);
            // 
            // barBtnDeviceDelete
            // 
            this.barBtnDeviceDelete.Caption = "Okuyucu Sil";
            this.barBtnDeviceDelete.Id = 26;
            this.barBtnDeviceDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnDeviceDelete.ImageOptions.SvgImage")));
            this.barBtnDeviceDelete.Name = "barBtnDeviceDelete";
            this.barBtnDeviceDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDeviceDelete_ItemClick);
            // 
            // btnPersonList
            // 
            this.btnPersonList.Caption = "Personelleri Listele";
            this.btnPersonList.Id = 27;
            this.btnPersonList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonList.ImageOptions.Image")));
            this.btnPersonList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPersonList.ImageOptions.LargeImage")));
            this.btnPersonList.Name = "btnPersonList";
            this.btnPersonList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPersonList_ItemClick);
            // 
            // btnPersonAdd
            // 
            this.btnPersonAdd.Caption = "Personel Ekle";
            this.btnPersonAdd.Id = 28;
            this.btnPersonAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonAdd.ImageOptions.Image")));
            this.btnPersonAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPersonAdd.ImageOptions.LargeImage")));
            this.btnPersonAdd.Name = "btnPersonAdd";
            this.btnPersonAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPersonAdd_ItemClick);
            // 
            // barBtnDeviceEdit
            // 
            this.barBtnDeviceEdit.Caption = "Okuyucu Düzenle";
            this.barBtnDeviceEdit.Id = 29;
            this.barBtnDeviceEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnDeviceEdit.ImageOptions.SvgImage")));
            this.barBtnDeviceEdit.Name = "barBtnDeviceEdit";
            this.barBtnDeviceEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDeviceEdit_ItemClick);
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 30;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // btnPersonEdit
            // 
            this.btnPersonEdit.Caption = "Personel Düzenle";
            this.btnPersonEdit.Id = 31;
            this.btnPersonEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonEdit.ImageOptions.Image")));
            this.btnPersonEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPersonEdit.ImageOptions.LargeImage")));
            this.btnPersonEdit.Name = "btnPersonEdit";
            this.btnPersonEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPersonEdit_ItemClick);
            // 
            // btnPersonDelete
            // 
            this.btnPersonDelete.Caption = "Personel Sil";
            this.btnPersonDelete.Id = 32;
            this.btnPersonDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonDelete.ImageOptions.Image")));
            this.btnPersonDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPersonDelete.ImageOptions.LargeImage")));
            this.btnPersonDelete.Name = "btnPersonDelete";
            this.btnPersonDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPersonDelete_ItemClick);
            // 
            // barToggleSwitchItem2
            // 
            this.barToggleSwitchItem2.Caption = "barToggleSwitchItem2";
            this.barToggleSwitchItem2.Id = 33;
            this.barToggleSwitchItem2.Name = "barToggleSwitchItem2";
            // 
            // barEditItem4
            // 
            this.barEditItem4.Caption = "Çalışma Şekli";
            this.barEditItem4.Edit = this.repositoryItemLookUpEdit1;
            this.barEditItem4.Id = 34;
            this.barEditItem4.Name = "barEditItem4";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // PageReaderManager
            // 
            this.PageReaderManager.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.PageReaderManager.Name = "PageReaderManager";
            this.PageReaderManager.Text = "Okuyucu Tanımlamaları";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnDeviceList);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnDeviceAdd);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnDeviceEdit);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnDeviceDelete);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Okuyucu İşlemleri";
            // 
            // PageUserManager
            // 
            this.PageUserManager.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.PageUserManager.Name = "PageUserManager";
            this.PageUserManager.Text = "Kullanıcı Tanımlamaları";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPersonList);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPersonAdd);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPersonEdit);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPersonDelete);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Personel Tanımlamaları";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barEditItem1);
            this.ribbonPageGroup4.ItemLinks.Add(this.checkPassword);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnCardWorkStart);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDeviceWorkStop);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            this.ribbonPageGroup4.Text = "Çalışma İşlemleri";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.Black;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.Appearance.Options.UseForeColor = true;
            this.panelControl1.Controls.Add(this.windowsUIButtonPanel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 141);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1012, 708);
            this.panelControl1.TabIndex = 1;
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(0, 0);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(0, 0);
            this.windowsUIButtonPanel1.TabIndex = 0;
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "ribbonPage5";
            // 
            // checkPassword
            // 
            this.checkPassword.Caption = "TckNo 5 Hane Devrede";
            this.checkPassword.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.AfterText;
            this.checkPassword.Id = 42;
            this.checkPassword.Name = "checkPassword";
            // 
            // CardOperations
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 849);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "CardOperations";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Kart Okuyucu İşlemleri";
            this.Load += new System.EventHandler(this.CardOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage PageReader;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageReaderManager;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageUserManager;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnGetDevice;
        private DevExpress.XtraBars.BarButtonItem btnConnectedDevice;
        private DevExpress.XtraBars.BarButtonItem btnDisconnectedDevice;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnCardWorkStart;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnDeviceWorkStop;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.BarLinkContainerItem barLinkContainerItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraBars.BarListItem barListItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraBars.BarButtonItem barBtnDeviceList;
        private DevExpress.XtraBars.BarButtonItem barBtnDeviceAdd;
        private DevExpress.XtraBars.BarButtonItem barBtnDeviceDelete;
        private DevExpress.XtraBars.BarButtonItem btnPersonList;
        private DevExpress.XtraBars.BarButtonItem btnPersonAdd;
        private DevExpress.XtraBars.BarButtonItem barBtnDeviceEdit;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem btnPersonEdit;
        private DevExpress.XtraBars.BarButtonItem btnPersonDelete;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.BarEditItem barEditItem4;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarCheckItem checkPassword;
    }
}