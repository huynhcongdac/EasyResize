namespace EasyWatermark
{
    partial class MainForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnBrowseOutputFolder = new DevExpress.XtraEditors.SimpleButton();
            this.txtOutputFolder = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.lblStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.lblVisitFacebook = new System.Windows.Forms.LinkLabel();
            this.lblVisitWeb = new System.Windows.Forms.LinkLabel();
            this.btnStartStop = new DevExpress.XtraEditors.SimpleButton();
            this.btnBrowseImageFolder = new DevExpress.XtraEditors.SimpleButton();
            this.txtImageFolder = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nmrNewWidth = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.nmrNewHeight = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutputFolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageFolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNewWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNewHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.linkLabel1);
            this.layoutControl1.Controls.Add(this.nmrNewHeight);
            this.layoutControl1.Controls.Add(this.nmrNewWidth);
            this.layoutControl1.Controls.Add(this.btnBrowseOutputFolder);
            this.layoutControl1.Controls.Add(this.txtOutputFolder);
            this.layoutControl1.Controls.Add(this.lblVisitFacebook);
            this.layoutControl1.Controls.Add(this.lblVisitWeb);
            this.layoutControl1.Controls.Add(this.btnStartStop);
            this.layoutControl1.Controls.Add(this.btnBrowseImageFolder);
            this.layoutControl1.Controls.Add(this.txtImageFolder);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(657, 215);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnBrowseOutputFolder
            // 
            this.btnBrowseOutputFolder.AllowFocus = false;
            this.btnBrowseOutputFolder.Location = new System.Drawing.Point(507, 50);
            this.btnBrowseOutputFolder.Name = "btnBrowseOutputFolder";
            this.btnBrowseOutputFolder.Size = new System.Drawing.Size(134, 28);
            this.btnBrowseOutputFolder.StyleController = this.layoutControl1;
            this.btnBrowseOutputFolder.TabIndex = 13;
            this.btnBrowseOutputFolder.Text = "Browse...";
            this.btnBrowseOutputFolder.Click += new System.EventHandler(this.btnBrowseOutputFolder_Click);
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(127, 52);
            this.txtOutputFolder.MenuManager = this.barManager1;
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(374, 30);
            this.txtOutputFolder.StyleController = this.layoutControl1;
            this.txtOutputFolder.TabIndex = 12;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblStatus});
            this.barManager1.MaxItemId = 3;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.lblStatus)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // lblStatus
            // 
            this.lblStatus.Caption = "Ready";
            this.lblStatus.Id = 2;
            this.lblStatus.Name = "lblStatus";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(657, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 558);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(657, 38);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 558);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(657, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 558);
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // lblVisitFacebook
            // 
            this.lblVisitFacebook.Location = new System.Drawing.Point(16, 150);
            this.lblVisitFacebook.Name = "lblVisitFacebook";
            this.lblVisitFacebook.Size = new System.Drawing.Size(304, 20);
            this.lblVisitFacebook.TabIndex = 9;
            this.lblVisitFacebook.TabStop = true;
            this.lblVisitFacebook.Text = "Visit out FB page";
            this.lblVisitFacebook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblVisitFacebook_LinkClicked);
            // 
            // lblVisitWeb
            // 
            this.lblVisitWeb.Location = new System.Drawing.Point(16, 124);
            this.lblVisitWeb.Name = "lblVisitWeb";
            this.lblVisitWeb.Size = new System.Drawing.Size(304, 20);
            this.lblVisitWeb.TabIndex = 8;
            this.lblVisitWeb.TabStop = true;
            this.lblVisitWeb.Text = "Visit our website";
            this.lblVisitWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblVisitWeb_LinkClicked);
            // 
            // btnStartStop
            // 
            this.btnStartStop.AllowFocus = false;
            this.btnStartStop.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnStartStop.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.Appearance.Options.UseBackColor = true;
            this.btnStartStop.Appearance.Options.UseFont = true;
            this.btnStartStop.Location = new System.Drawing.Point(326, 124);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(315, 30);
            this.btnStartStop.StyleController = this.layoutControl1;
            this.btnStartStop.TabIndex = 7;
            this.btnStartStop.Text = "START";
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnBrowseImageFolder
            // 
            this.btnBrowseImageFolder.AllowFocus = false;
            this.btnBrowseImageFolder.Location = new System.Drawing.Point(507, 16);
            this.btnBrowseImageFolder.Name = "btnBrowseImageFolder";
            this.btnBrowseImageFolder.Size = new System.Drawing.Size(134, 28);
            this.btnBrowseImageFolder.StyleController = this.layoutControl1;
            this.btnBrowseImageFolder.TabIndex = 5;
            this.btnBrowseImageFolder.Text = "Browse...";
            this.btnBrowseImageFolder.Click += new System.EventHandler(this.btnBrowseImageFolder_Click);
            // 
            // txtImageFolder
            // 
            this.txtImageFolder.AllowDrop = true;
            this.txtImageFolder.Location = new System.Drawing.Point(127, 16);
            this.txtImageFolder.Name = "txtImageFolder";
            this.txtImageFolder.Properties.NullText = "Browse folder or drag folder here...";
            this.txtImageFolder.Properties.NullValuePrompt = "Browse folder or drag folder here...";
            this.txtImageFolder.Size = new System.Drawing.Size(374, 30);
            this.txtImageFolder.StyleController = this.layoutControl1;
            this.txtImageFolder.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem3,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(657, 215);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtImageFolder;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(491, 36);
            this.layoutControlItem1.Text = "Image Folder:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(95, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnBrowseImageFolder;
            this.layoutControlItem2.Location = new System.Drawing.Point(491, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(140, 34);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnStartStop;
            this.layoutControlItem4.Location = new System.Drawing.Point(310, 108);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(321, 52);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lblVisitWeb;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 108);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(310, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lblVisitFacebook;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 134);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(310, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtOutputFolder;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(491, 36);
            this.layoutControlItem9.Text = "Output Folder:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(95, 16);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnBrowseOutputFolder;
            this.layoutControlItem10.Location = new System.Drawing.Point(491, 34);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(140, 38);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 215);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(657, 343);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // nmrNewWidth
            // 
            this.nmrNewWidth.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmrNewWidth.Location = new System.Drawing.Point(127, 88);
            this.nmrNewWidth.MenuManager = this.barManager1;
            this.nmrNewWidth.Name = "nmrNewWidth";
            this.nmrNewWidth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nmrNewWidth.Properties.MaskSettings.Set("mask", "n0");
            this.nmrNewWidth.Size = new System.Drawing.Size(193, 30);
            this.nmrNewWidth.StyleController = this.layoutControl1;
            this.nmrNewWidth.TabIndex = 14;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.nmrNewWidth;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(310, 36);
            this.layoutControlItem3.Text = "New size width:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(95, 16);
            // 
            // nmrNewHeight
            // 
            this.nmrNewHeight.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmrNewHeight.Location = new System.Drawing.Point(437, 88);
            this.nmrNewHeight.MenuManager = this.barManager1;
            this.nmrNewHeight.Name = "nmrNewHeight";
            this.nmrNewHeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nmrNewHeight.Properties.MaskSettings.Set("mask", "n0");
            this.nmrNewHeight.Size = new System.Drawing.Size(204, 30);
            this.nmrNewHeight.StyleController = this.layoutControl1;
            this.nmrNewHeight.TabIndex = 15;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.nmrNewHeight;
            this.layoutControlItem7.Location = new System.Drawing.Point(310, 72);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(321, 36);
            this.layoutControlItem7.Text = "New size height:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(95, 16);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(16, 176);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(625, 20);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Get design Merch, Redbubble, Customily automatically. Try it for FREE now!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.linkLabel1;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 160);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(631, 29);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 596);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Resize - Free | fb.com/cong.dac.dev";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtOutputFolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageFolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNewWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNewHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnBrowseImageFolder;
        private DevExpress.XtraEditors.TextEdit txtImageFolder;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnStartStop;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.LinkLabel lblVisitWeb;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.LinkLabel lblVisitFacebook;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraBars.BarStaticItem lblStatus;
        private DevExpress.XtraEditors.TextEdit txtOutputFolder;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.SimpleButton btnBrowseOutputFolder;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.SpinEdit nmrNewHeight;
        private DevExpress.XtraEditors.SpinEdit nmrNewWidth;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}

