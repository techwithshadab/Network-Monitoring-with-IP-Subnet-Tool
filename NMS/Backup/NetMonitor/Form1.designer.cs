namespace Networks
{
    partial class Form1
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
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            catch { }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MnuRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RightExportToFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.Right_ClearLogHistry = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripSeparator();
            this.RightCurrentUser = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabFolderWatcher = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lstCreate = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lstDelete = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lstRenamed = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.lstChanged = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabFileAccessed = new System.Windows.Forms.TabPage();
            this.lview = new System.Windows.Forms.ListView();
            this.tabSession = new System.Windows.Forms.TabPage();
            this.lviewSession = new System.Windows.Forms.ListView();
            this.tabShared = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cb = new System.Windows.Forms.CheckBox();
            this.tbarRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Connect = new System.Windows.Forms.ToolStripLabel();
            this.ip = new System.Windows.Forms.ToolStripTextBox();
            this.username = new System.Windows.Forms.ToolStripLabel();
            this.uname = new System.Windows.Forms.ToolStripTextBox();
            this.Password = new System.Windows.Forms.ToolStripLabel();
            this.pass = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnStartMonitor = new DevComponents.DotNetBar.ButtonX();
            this.BtnStopMonitor = new DevComponents.DotNetBar.ButtonX();
            this.ContextMenu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabFolderWatcher.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabFileAccessed.SuspendLayout();
            this.tabSession.SuspendLayout();
            this.tabShared.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NotifyIcon.BalloonTipText = "Your Network Spy";
            this.NotifyIcon.BalloonTipTitle = "Spy Net";
            this.NotifyIcon.ContextMenuStrip = this.ContextMenu;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "SpyNet";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuRestore,
            this.MnuClose});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(114, 48);
            this.ContextMenu.Text = "Restore";
            // 
            // MnuRestore
            // 
            this.MnuRestore.Image = ((System.Drawing.Image)(resources.GetObject("MnuRestore.Image")));
            this.MnuRestore.Name = "MnuRestore";
            this.MnuRestore.Size = new System.Drawing.Size(113, 22);
            this.MnuRestore.Text = "Restore";
            this.MnuRestore.ToolTipText = "Restore The Application";
            this.MnuRestore.Click += new System.EventHandler(this.MnuRestore_Click);
            // 
            // MnuClose
            // 
            this.MnuClose.Image = ((System.Drawing.Image)(resources.GetObject("MnuClose.Image")));
            this.MnuClose.Name = "MnuClose";
            this.MnuClose.Size = new System.Drawing.Size(113, 22);
            this.MnuClose.Text = "Close";
            this.MnuClose.ToolTipText = "Close Application";
            this.MnuClose.Click += new System.EventHandler(this.MnuClose_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RightExportToFile,
            this.toolStripMenuItem3,
            this.Right_ClearLogHistry,
            this.toolStripMenuItem14,
            this.RightCurrentUser});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 82);
            // 
            // RightExportToFile
            // 
            this.RightExportToFile.Image = ((System.Drawing.Image)(resources.GetObject("RightExportToFile.Image")));
            this.RightExportToFile.Name = "RightExportToFile";
            this.RightExportToFile.Size = new System.Drawing.Size(170, 22);
            this.RightExportToFile.Text = "&Export To Text File";
            this.RightExportToFile.Click += new System.EventHandler(this.RightExportToFile_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(167, 6);
            // 
            // Right_ClearLogHistry
            // 
            this.Right_ClearLogHistry.Image = ((System.Drawing.Image)(resources.GetObject("Right_ClearLogHistry.Image")));
            this.Right_ClearLogHistry.Name = "Right_ClearLogHistry";
            this.Right_ClearLogHistry.Size = new System.Drawing.Size(170, 22);
            this.Right_ClearLogHistry.Text = "&Clear Log History";
            this.Right_ClearLogHistry.Click += new System.EventHandler(this.Right_ClearLogHistry_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(167, 6);
            // 
            // RightCurrentUser
            // 
            this.RightCurrentUser.Image = ((System.Drawing.Image)(resources.GetObject("RightCurrentUser.Image")));
            this.RightCurrentUser.Name = "RightCurrentUser";
            this.RightCurrentUser.Size = new System.Drawing.Size(170, 22);
            this.RightCurrentUser.Text = "&Active Users IP";
            this.RightCurrentUser.Click += new System.EventHandler(this.RightCurrentUser_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "folder-black-favourite.ico");
            this.imageList2.Images.SetKeyName(1, "Symbols-Delete.ico");
            this.imageList2.Images.SetKeyName(2, "Admin-tools.ico");
            this.imageList2.Images.SetKeyName(3, "Binary data SH.ico");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
            this.imageList1.Images.SetKeyName(22, "");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 488);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(765, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel2.Text = "Monitroing your PC";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripMenuItem.Image")));
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.tbarRefresh_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1,
            this.toolStripMenuItem4,
            this.refreshTimeToolStripMenuItem,
            this.clearLogHistoryToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Checked = true;
            this.settingsToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.settingsToolStripMenuItem1.Text = "Enabled PopUp";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click_1);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(162, 6);
            // 
            // refreshTimeToolStripMenuItem
            // 
            this.refreshTimeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem5,
            this.toolStripMenuItem7,
            this.toolStripMenuItem11,
            this.toolStripMenuItem8,
            this.toolStripMenuItem12,
            this.toolStripMenuItem9,
            this.toolStripMenuItem13,
            this.toolStripMenuItem10});
            this.refreshTimeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshTimeToolStripMenuItem.Image")));
            this.refreshTimeToolStripMenuItem.Name = "refreshTimeToolStripMenuItem";
            this.refreshTimeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.refreshTimeToolStripMenuItem.Text = "Refresh Time";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Checked = true;
            this.toolStripMenuItem6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem6.Text = "1";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(77, 6);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem7.Text = "2";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(77, 6);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem8.Text = "3";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(77, 6);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.ShowShortcutKeys = false;
            this.toolStripMenuItem9.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem9.Text = "4";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(77, 6);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem10.Text = "5";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // clearLogHistoryToolStripMenuItem
            // 
            this.clearLogHistoryToolStripMenuItem.Name = "clearLogHistoryToolStripMenuItem";
            this.clearLogHistoryToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.clearLogHistoryToolStripMenuItem.Text = "Clear Log History";
            this.clearLogHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearLogHistoryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.toolStripMenuItem2});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem1.Image")));
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem1.Text = "&Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(96, 6);
            // 
            // tabFolderWatcher
            // 
            this.tabFolderWatcher.Controls.Add(this.tabControl2);
            this.tabFolderWatcher.Controls.Add(this.panel1);
            this.tabFolderWatcher.ImageIndex = 20;
            this.tabFolderWatcher.Location = new System.Drawing.Point(4, 23);
            this.tabFolderWatcher.Name = "tabFolderWatcher";
            this.tabFolderWatcher.Size = new System.Drawing.Size(757, 434);
            this.tabFolderWatcher.TabIndex = 3;
            this.tabFolderWatcher.Text = "Folder Watcher";
            this.tabFolderWatcher.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.ImageList = this.imageList2;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(757, 434);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.lstCreate);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(749, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Created";
            this.tabPage1.ToolTipText = "Created Files/Folders";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 398);
            this.dataGridView1.TabIndex = 5;
            // 
            // lstCreate
            // 
            this.lstCreate.ContextMenuStrip = this.contextMenuStrip1;
            this.lstCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCreate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstCreate.FullRowSelect = true;
            this.lstCreate.GridLines = true;
            this.lstCreate.Location = new System.Drawing.Point(3, 3);
            this.lstCreate.Name = "lstCreate";
            this.lstCreate.Size = new System.Drawing.Size(743, 398);
            this.lstCreate.TabIndex = 0;
            this.lstCreate.UseCompatibleStateImageBehavior = false;
            this.lstCreate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstCreate_MouseDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.lstDelete);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(749, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Deleted";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(743, 398);
            this.dataGridView2.TabIndex = 1;
            // 
            // lstDelete
            // 
            this.lstDelete.ContextMenuStrip = this.contextMenuStrip1;
            this.lstDelete.ForeColor = System.Drawing.Color.IndianRed;
            this.lstDelete.FullRowSelect = true;
            this.lstDelete.GridLines = true;
            this.lstDelete.Location = new System.Drawing.Point(0, 0);
            this.lstDelete.Name = "lstDelete";
            this.lstDelete.Size = new System.Drawing.Size(566, 245);
            this.lstDelete.TabIndex = 0;
            this.lstDelete.UseCompatibleStateImageBehavior = false;
            this.lstDelete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstDelete_MouseDown);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.lstRenamed);
            this.tabPage3.ImageIndex = 3;
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(749, 404);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Renamed";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(749, 404);
            this.dataGridView3.TabIndex = 9;
            // 
            // lstRenamed
            // 
            this.lstRenamed.ContextMenuStrip = this.contextMenuStrip1;
            this.lstRenamed.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lstRenamed.FullRowSelect = true;
            this.lstRenamed.GridLines = true;
            this.lstRenamed.Location = new System.Drawing.Point(-8, 0);
            this.lstRenamed.Name = "lstRenamed";
            this.lstRenamed.Size = new System.Drawing.Size(581, 244);
            this.lstRenamed.TabIndex = 0;
            this.lstRenamed.UseCompatibleStateImageBehavior = false;
            this.lstRenamed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstRenamed_MouseDown);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Controls.Add(this.lstChanged);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(749, 404);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(576, 243);
            this.dataGridView4.TabIndex = 1;
            // 
            // lstChanged
            // 
            this.lstChanged.ContextMenuStrip = this.contextMenuStrip1;
            this.lstChanged.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lstChanged.FullRowSelect = true;
            this.lstChanged.GridLines = true;
            this.lstChanged.Location = new System.Drawing.Point(0, 0);
            this.lstChanged.Name = "lstChanged";
            this.lstChanged.Size = new System.Drawing.Size(573, 252);
            this.lstChanged.TabIndex = 0;
            this.lstChanged.UseCompatibleStateImageBehavior = false;
            this.lstChanged.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstChanged_MouseDown);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 434);
            this.panel1.TabIndex = 0;
            // 
            // tabFileAccessed
            // 
            this.tabFileAccessed.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabFileAccessed.Controls.Add(this.lview);
            this.tabFileAccessed.ImageIndex = 15;
            this.tabFileAccessed.Location = new System.Drawing.Point(4, 23);
            this.tabFileAccessed.Name = "tabFileAccessed";
            this.tabFileAccessed.Size = new System.Drawing.Size(757, 434);
            this.tabFileAccessed.TabIndex = 2;
            this.tabFileAccessed.Text = "Accessed Folder";
            this.tabFileAccessed.UseVisualStyleBackColor = true;
            // 
            // lview
            // 
            this.lview.BackColor = System.Drawing.SystemColors.Info;
            this.lview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lview.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lview.GridLines = true;
            this.lview.Location = new System.Drawing.Point(0, 0);
            this.lview.Name = "lview";
            this.lview.Size = new System.Drawing.Size(757, 434);
            this.lview.TabIndex = 0;
            this.lview.UseCompatibleStateImageBehavior = false;
            // 
            // tabSession
            // 
            this.tabSession.Controls.Add(this.lviewSession);
            this.tabSession.ImageIndex = 13;
            this.tabSession.Location = new System.Drawing.Point(4, 23);
            this.tabSession.Name = "tabSession";
            this.tabSession.Size = new System.Drawing.Size(757, 434);
            this.tabSession.TabIndex = 1;
            this.tabSession.Text = "Current Session";
            this.tabSession.UseVisualStyleBackColor = true;
            // 
            // lviewSession
            // 
            this.lviewSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lviewSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lviewSession.ForeColor = System.Drawing.Color.Navy;
            this.lviewSession.FullRowSelect = true;
            this.lviewSession.GridLines = true;
            this.lviewSession.Location = new System.Drawing.Point(0, 0);
            this.lviewSession.Name = "lviewSession";
            this.lviewSession.Size = new System.Drawing.Size(757, 434);
            this.lviewSession.TabIndex = 0;
            this.lviewSession.UseCompatibleStateImageBehavior = false;
            this.lviewSession.SelectedIndexChanged += new System.EventHandler(this.lviewSession_SelectedIndexChanged);
            // 
            // tabShared
            // 
            this.tabShared.Controls.Add(this.listView1);
            this.tabShared.ImageIndex = 1;
            this.tabShared.Location = new System.Drawing.Point(4, 23);
            this.tabShared.Name = "tabShared";
            this.tabShared.Size = new System.Drawing.Size(757, 434);
            this.tabShared.TabIndex = 0;
            this.tabShared.Text = "Shared Folder";
            this.tabShared.UseVisualStyleBackColor = true;
            this.tabShared.Click += new System.EventHandler(this.tabShared_Click);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Navy;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(757, 434);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabShared);
            this.tabControl1.Controls.Add(this.tabSession);
            this.tabControl1.Controls.Add(this.tabFileAccessed);
            this.tabControl1.Controls.Add(this.tabFolderWatcher);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(765, 461);
            this.tabControl1.TabIndex = 1;
            // 
            // cb
            // 
            this.cb.AutoSize = true;
            this.cb.Checked = true;
            this.cb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb.Location = new System.Drawing.Point(483, 27);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(66, 17);
            this.cb.TabIndex = 5;
            this.cb.Text = "Connect";
            this.cb.UseVisualStyleBackColor = true;
            this.cb.Visible = false;
            // 
            // tbarRefresh
            // 
            this.tbarRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbarRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tbarRefresh.Image")));
            this.tbarRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbarRefresh.Name = "tbarRefresh";
            this.tbarRefresh.Size = new System.Drawing.Size(23, 22);
            this.tbarRefresh.ToolTipText = "Refresh Session";
            this.tbarRefresh.Click += new System.EventHandler(this.tbarRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Connect
            // 
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(17, 22);
            this.Connect.Text = "IP";
            // 
            // ip
            // 
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(100, 25);
            // 
            // username
            // 
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(65, 22);
            this.username.Text = "User Name";
            // 
            // uname
            // 
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(75, 25);
            // 
            // Password
            // 
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(57, 22);
            this.Password.Text = "Password";
            // 
            // pass
            // 
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(75, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbarRefresh,
            this.toolStripSeparator1,
            this.Connect,
            this.ip,
            this.username,
            this.uname,
            this.Password,
            this.pass});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(765, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnStartMonitor
            // 
            this.BtnStartMonitor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnStartMonitor.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.BtnStartMonitor.Location = new System.Drawing.Point(527, 27);
            this.BtnStartMonitor.Name = "BtnStartMonitor";
            this.BtnStartMonitor.Size = new System.Drawing.Size(75, 23);
            this.BtnStartMonitor.TabIndex = 7;
            this.BtnStartMonitor.Text = "Start Monitor";
            this.BtnStartMonitor.Click += new System.EventHandler(this.BtnStartMonitor_Click);
            // 
            // BtnStopMonitor
            // 
            this.BtnStopMonitor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnStopMonitor.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.BtnStopMonitor.Location = new System.Drawing.Point(637, 27);
            this.BtnStopMonitor.Name = "BtnStopMonitor";
            this.BtnStopMonitor.Size = new System.Drawing.Size(75, 23);
            this.BtnStopMonitor.TabIndex = 8;
            this.BtnStopMonitor.Text = "Stop Monitor";
            this.BtnStopMonitor.Click += new System.EventHandler(this.BtnStopMonitor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(765, 510);
            this.Controls.Add(this.BtnStartMonitor);
            this.Controls.Add(this.BtnStopMonitor);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Monitroing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ContextMenu.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabFolderWatcher.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabFileAccessed.ResumeLayout(false);
            this.tabSession.ResumeLayout(false);
            this.tabShared.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem MnuRestore;
        private System.Windows.Forms.ToolStripMenuItem MnuClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RightExportToFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem Right_ClearLogHistry;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabShared;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabSession;
        private System.Windows.Forms.ListView lviewSession;
        private System.Windows.Forms.TabPage tabFileAccessed;
        private System.Windows.Forms.ListView lview;
        private System.Windows.Forms.TabPage tabFolderWatcher;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lstCreate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lstDelete;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lstRenamed;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView lstChanged;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem refreshTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem12;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem13;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem RightCurrentUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.ToolStripMenuItem clearLogHistoryToolStripMenuItem;
        private System.Windows.Forms.CheckBox cb;
        private System.Windows.Forms.ToolStripButton tbarRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel Connect;
        private System.Windows.Forms.ToolStripTextBox ip;
        private System.Windows.Forms.ToolStripLabel username;
        private System.Windows.Forms.ToolStripTextBox uname;
        private System.Windows.Forms.ToolStripLabel Password;
        private System.Windows.Forms.ToolStripTextBox pass;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevComponents.DotNetBar.ButtonX BtnStartMonitor;
        private DevComponents.DotNetBar.ButtonX BtnStopMonitor;
    }
}

