namespace Networks
{
    partial class Main
    {
      
        private System.ComponentModel.IContainer components = null;

        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bubbleBar1 = new DevComponents.DotNetBar.BubbleBar();
            this.bubbleBarTab1 = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.BtnIPCalc = new DevComponents.DotNetBar.BubbleButton();
            this.BtnRemoteDesktop = new DevComponents.DotNetBar.BubbleButton();
            this.BtnEmailClient = new DevComponents.DotNetBar.BubbleButton();
            this.BtnSystemRes = new DevComponents.DotNetBar.BubbleButton();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.office2007StartButton1 = new DevComponents.DotNetBar.Office2007StartButton();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.BtnExit = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar1)).BeginInit();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bubbleBar1
            // 
            this.bubbleBar1.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.bubbleBar1.AntiAlias = true;
            this.bubbleBar1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.bubbleBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            // 
            // 
            // 
            this.bubbleBar1.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent;
            this.bubbleBar1.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar1.ButtonBackAreaStyle.BorderBottomWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.bubbleBar1.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar1.ButtonBackAreaStyle.BorderLeftWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar1.ButtonBackAreaStyle.BorderRightWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar1.ButtonBackAreaStyle.BorderTopWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingBottom = 3;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingLeft = 3;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingRight = 3;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingTop = 3;
            this.bubbleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bubbleBar1.ImageSizeNormal = new System.Drawing.Size(24, 24);
            this.bubbleBar1.Location = new System.Drawing.Point(3, 0);
            this.bubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bubbleBar1.Name = "bubbleBar1";
            this.bubbleBar1.SelectedTab = this.bubbleBarTab1;
            this.bubbleBar1.SelectedTabColors.BackColor = System.Drawing.Color.Transparent;
            this.bubbleBar1.SelectedTabColors.BackColor2 = System.Drawing.Color.Transparent;
            this.bubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Transparent;
            this.bubbleBar1.SelectedTabColors.DarkBorderColor = System.Drawing.Color.Transparent;
            this.bubbleBar1.Size = new System.Drawing.Size(880, 61);
            this.bubbleBar1.TabIndex = 0;
            this.bubbleBar1.Tabs.Add(this.bubbleBarTab1);
            // 
            // bubbleBarTab1
            // 
            this.bubbleBarTab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.bubbleBarTab1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(170)))));
            this.bubbleBarTab1.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.BtnIPCalc,
            this.BtnRemoteDesktop,
            this.BtnEmailClient,
            this.BtnSystemRes});
            this.bubbleBarTab1.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bubbleBarTab1.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bubbleBarTab1.Name = "bubbleBarTab1";
            this.bubbleBarTab1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Silver;
            this.bubbleBarTab1.Text = "";
            this.bubbleBarTab1.TextColor = System.Drawing.Color.Black;
            // 
            // BtnIPCalc
            // 
            this.BtnIPCalc.Image = global::Networks.Properties.Resources.IPCalc;
            this.BtnIPCalc.ImageLarge = global::Networks.Properties.Resources.IPCalc;
            this.BtnIPCalc.Name = "BtnIPCalc";
            this.BtnIPCalc.TooltipText = "IP Calculator";
            this.BtnIPCalc.Click += new DevComponents.DotNetBar.ClickEventHandler(this.BtnIPCalc_Click);
            // 
            // BtnRemoteDesktop
            // 
            this.BtnRemoteDesktop.Image = global::Networks.Properties.Resources.remotedesktop;
            this.BtnRemoteDesktop.ImageLarge = global::Networks.Properties.Resources.remotedesktop;
            this.BtnRemoteDesktop.Name = "BtnRemoteDesktop";
            this.BtnRemoteDesktop.TooltipText = "Remote Desktop";
            this.BtnRemoteDesktop.Click += new DevComponents.DotNetBar.ClickEventHandler(this.BtnRemoteDesktop_Click);
            // 
            // BtnEmailClient
            // 
            this.BtnEmailClient.Image = global::Networks.Properties.Resources.email64;
            this.BtnEmailClient.ImageLarge = global::Networks.Properties.Resources.email64;
            this.BtnEmailClient.Name = "BtnEmailClient";
            this.BtnEmailClient.TooltipText = "Email Client";
            this.BtnEmailClient.Click += new DevComponents.DotNetBar.ClickEventHandler(this.BtnEmailClient_Click);
            // 
            // BtnSystemRes
            // 
            this.BtnSystemRes.Image = global::Networks.Properties.Resources.SysMonitor;
            this.BtnSystemRes.ImageLarge = global::Networks.Properties.Resources.SysMonitor;
            this.BtnSystemRes.Name = "BtnSystemRes";
            this.BtnSystemRes.TooltipText = "Monitor System Resource";
            this.BtnSystemRes.Click += new DevComponents.DotNetBar.ClickEventHandler(this.BtnSystemRes_Click);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(4, 1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.VistaGlass;
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.office2007StartButton1,
            this.qatCustomizeItem1});
            this.ribbonControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ribbonControl1.Size = new System.Drawing.Size(886, 121);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 3;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel1.Controls.Add(this.bubbleBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(886, 64);
            this.ribbonPanel1.TabIndex = 1;
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "N";
            // 
            // office2007StartButton1
            // 
            this.office2007StartButton1.AutoExpandOnClick = true;
            this.office2007StartButton1.CanCustomize = false;
            this.office2007StartButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartButton1.Image = ((System.Drawing.Image)(resources.GetObject("office2007StartButton1.Image")));
            this.office2007StartButton1.ImagePaddingHorizontal = 2;
            this.office2007StartButton1.ImagePaddingVertical = 2;
            this.office2007StartButton1.Name = "office2007StartButton1";
            this.office2007StartButton1.ShowSubItems = false;
            this.office2007StartButton1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.office2007StartButton1.Text = "&File";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer4});
            // 
            // itemContainer4
            // 
            // 
            // 
            // 
            this.itemContainer4.BackgroundStyle.Class = "RibbonFileMenuBottomContainer";
            this.itemContainer4.Name = "itemContainer4";
            this.itemContainer4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BtnExit});
            // 
            // BtnExit
            // 
            this.BtnExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BtnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.SubItemsExpandWidth = 24;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 672);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar1)).EndInit();
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.BubbleBar bubbleBar1;
        private DevComponents.DotNetBar.BubbleBarTab bubbleBarTab1;
        private DevComponents.DotNetBar.BubbleButton BtnIPCalc;
        private DevComponents.DotNetBar.BubbleButton BtnRemoteDesktop;
        private DevComponents.DotNetBar.BubbleButton BtnEmailClient;
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.ButtonItem BtnExit;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.BubbleButton BtnSystemRes;

    }
}

