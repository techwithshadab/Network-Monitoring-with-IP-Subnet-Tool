using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;

namespace Networks
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : DevComponents.DotNetBar.Office2007Form 
	{
		#region Declarations
		protected IPTool ip = null;
		protected bool fill = false; // lock events wenn updating
		protected bool isIP = false;
		#endregion

        private System.Windows.Forms.TextBox ipAddress;
        private System.Windows.Forms.ComboBox netClassComboBox;
		private System.Windows.Forms.ComboBox prefixComboBox;
		private System.Windows.Forms.ComboBox netMaskComboBox;
		private System.Windows.Forms.CheckBox firstBitCheckBox;
		private System.Windows.Forms.TextBox maxCountHosts;
        private System.Windows.Forms.TextBox calcNetwork;
		private System.Windows.Forms.TextBox calcBroadcast;
		private System.Windows.Forms.TextBox calcIPRange;
		private System.Windows.Forms.TextBox clacMaxNetCount;
        private System.Windows.Forms.TextBox nextNumOfHosts;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private ButtonX BtnCalculate;
        private ButtonX BtnSubnetMask;
        private LabelX labelX3;
        private LabelX noticeLabel;
        private LabelX labelX1;
        private LabelX labelX2;
        private LabelX labelX10;
        private LabelX labelX9;
        private LabelX labelX8;
        private LabelX labelX7;
        private LabelX labelX6;
        private LabelX labelX5;
        private LabelX labelX4;
        private PanelEx PnFirst;
        private ButtonX BtnPnfirstClose;
        private LabelX labelX11;
        private LabelX labelX15;
        private LabelX labelX14;
        private LabelX labelX13;
        private LabelX labelX12;
        private LabelX labelX16;
        private PanelEx panelEx1;
        private LabelX Lbl2;
        private LabelX Lbl1;
        private LabelX Lbl6;
        private LabelX Lbl5;
        private LabelX Lbl4;
        private LabelX Lbl3;
        private PanelEx PnSecond;
        private LabelX Lbls6;
        private LabelX Lbls5;
        private LabelX Lbls4;
        private LabelX Lbls3;
        private LabelX Lbls2;
        private LabelX lbls1;
        private PanelEx panelEx3;
        private LabelX labelX23;
        private LabelX labelX24;
        private LabelX labelX25;
        private LabelX labelX26;
        private LabelX labelX27;
        private LabelX labelX28;
        private LabelX Lbls7;
        private LabelX labelX29;
        private ButtonX BtnPnSecondClose;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.netClassComboBox = new System.Windows.Forms.ComboBox();
            this.ipAddress = new System.Windows.Forms.TextBox();
            this.nextNumOfHosts = new System.Windows.Forms.TextBox();
            this.clacMaxNetCount = new System.Windows.Forms.TextBox();
            this.calcIPRange = new System.Windows.Forms.TextBox();
            this.calcBroadcast = new System.Windows.Forms.TextBox();
            this.calcNetwork = new System.Windows.Forms.TextBox();
            this.maxCountHosts = new System.Windows.Forms.TextBox();
            this.firstBitCheckBox = new System.Windows.Forms.CheckBox();
            this.netMaskComboBox = new System.Windows.Forms.ComboBox();
            this.prefixComboBox = new System.Windows.Forms.ComboBox();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.noticeLabel = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.BtnCalculate = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.PnSecond = new DevComponents.DotNetBar.PanelEx();
            this.BtnPnSecondClose = new DevComponents.DotNetBar.ButtonX();
            this.Lbls7 = new DevComponents.DotNetBar.LabelX();
            this.Lbls6 = new DevComponents.DotNetBar.LabelX();
            this.Lbls5 = new DevComponents.DotNetBar.LabelX();
            this.Lbls4 = new DevComponents.DotNetBar.LabelX();
            this.Lbls3 = new DevComponents.DotNetBar.LabelX();
            this.Lbls2 = new DevComponents.DotNetBar.LabelX();
            this.lbls1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.labelX29 = new DevComponents.DotNetBar.LabelX();
            this.labelX23 = new DevComponents.DotNetBar.LabelX();
            this.labelX24 = new DevComponents.DotNetBar.LabelX();
            this.labelX25 = new DevComponents.DotNetBar.LabelX();
            this.labelX26 = new DevComponents.DotNetBar.LabelX();
            this.labelX27 = new DevComponents.DotNetBar.LabelX();
            this.labelX28 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.BtnSubnetMask = new DevComponents.DotNetBar.ButtonX();
            this.PnFirst = new DevComponents.DotNetBar.PanelEx();
            this.Lbl6 = new DevComponents.DotNetBar.LabelX();
            this.Lbl5 = new DevComponents.DotNetBar.LabelX();
            this.Lbl4 = new DevComponents.DotNetBar.LabelX();
            this.Lbl3 = new DevComponents.DotNetBar.LabelX();
            this.Lbl2 = new DevComponents.DotNetBar.LabelX();
            this.Lbl1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.BtnPnfirstClose = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.PnSecond.SuspendLayout();
            this.PnFirst.SuspendLayout();
            this.SuspendLayout();
            // 
            // netClassComboBox
            // 
            this.netClassComboBox.Items.AddRange(new object[] {
            "Class A: 0.0.0.0-127.255.255.255",
            "Class B: 128.0.0.0-191.255.255.255",
            "Class C: 192.0.0.0-223.255.255.255",
            "Class D: 224.0.0.0-239.255.255.255",
            "Class E: 240.0.0.0-254.255.255.255"});
            this.netClassComboBox.Location = new System.Drawing.Point(224, 58);
            this.netClassComboBox.Name = "netClassComboBox";
            this.netClassComboBox.Size = new System.Drawing.Size(208, 21);
            this.netClassComboBox.TabIndex = 3;
            this.netClassComboBox.Text = "Class A: 0.0.0.0-127.255.255.255";
            this.netClassComboBox.SelectedIndexChanged += new System.EventHandler(this.netClassComboBox_SelectedIndexChanged);
            // 
            // ipAddress
            // 
            this.ipAddress.Location = new System.Drawing.Point(224, 20);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(136, 20);
            this.ipAddress.TabIndex = 2;
            this.ipAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ipAddress_KeyDown);
            this.ipAddress.Leave += new System.EventHandler(this.ipAddress_Leave);
            // 
            // nextNumOfHosts
            // 
            this.nextNumOfHosts.Location = new System.Drawing.Point(224, 246);
            this.nextNumOfHosts.Name = "nextNumOfHosts";
            this.nextNumOfHosts.Size = new System.Drawing.Size(80, 20);
            this.nextNumOfHosts.TabIndex = 17;
            // 
            // clacMaxNetCount
            // 
            this.clacMaxNetCount.Location = new System.Drawing.Point(224, 214);
            this.clacMaxNetCount.Name = "clacMaxNetCount";
            this.clacMaxNetCount.Size = new System.Drawing.Size(320, 20);
            this.clacMaxNetCount.TabIndex = 16;
            // 
            // calcIPRange
            // 
            this.calcIPRange.Location = new System.Drawing.Point(224, 182);
            this.calcIPRange.Name = "calcIPRange";
            this.calcIPRange.Size = new System.Drawing.Size(320, 20);
            this.calcIPRange.TabIndex = 15;
            // 
            // calcBroadcast
            // 
            this.calcBroadcast.Location = new System.Drawing.Point(224, 150);
            this.calcBroadcast.Name = "calcBroadcast";
            this.calcBroadcast.Size = new System.Drawing.Size(320, 20);
            this.calcBroadcast.TabIndex = 14;
            // 
            // calcNetwork
            // 
            this.calcNetwork.Location = new System.Drawing.Point(224, 118);
            this.calcNetwork.Name = "calcNetwork";
            this.calcNetwork.Size = new System.Drawing.Size(320, 20);
            this.calcNetwork.TabIndex = 13;
            // 
            // maxCountHosts
            // 
            this.maxCountHosts.Location = new System.Drawing.Point(224, 86);
            this.maxCountHosts.Name = "maxCountHosts";
            this.maxCountHosts.Size = new System.Drawing.Size(320, 20);
            this.maxCountHosts.TabIndex = 12;
            // 
            // firstBitCheckBox
            // 
            this.firstBitCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.firstBitCheckBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstBitCheckBox.Location = new System.Drawing.Point(396, 47);
            this.firstBitCheckBox.Name = "firstBitCheckBox";
            this.firstBitCheckBox.Size = new System.Drawing.Size(120, 24);
            this.firstBitCheckBox.TabIndex = 5;
            this.firstBitCheckBox.Text = "Allow 1st subnet-BIT";
            this.firstBitCheckBox.CheckedChanged += new System.EventHandler(this.firstBitCheckBox_CheckedChanged);
            // 
            // netMaskComboBox
            // 
            this.netMaskComboBox.Location = new System.Drawing.Point(224, 50);
            this.netMaskComboBox.Name = "netMaskComboBox";
            this.netMaskComboBox.Size = new System.Drawing.Size(121, 21);
            this.netMaskComboBox.TabIndex = 4;
            this.netMaskComboBox.SelectedIndexChanged += new System.EventHandler(this.netMaskComboBox_SelectedIndexChanged);
            // 
            // prefixComboBox
            // 
            this.prefixComboBox.Location = new System.Drawing.Point(224, 15);
            this.prefixComboBox.Name = "prefixComboBox";
            this.prefixComboBox.Size = new System.Drawing.Size(73, 21);
            this.prefixComboBox.TabIndex = 3;
            this.prefixComboBox.SelectedIndexChanged += new System.EventHandler(this.prefixComboBox_SelectedIndexChanged);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.noticeLabel);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.BtnCalculate);
            this.groupPanel1.Controls.Add(this.netClassComboBox);
            this.groupPanel1.Controls.Add(this.ipAddress);
            this.groupPanel1.Location = new System.Drawing.Point(18, 7);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(622, 146);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 7;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(14, 60);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(100, 16);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Network type:";
            // 
            // noticeLabel
            // 
            this.noticeLabel.AutoSize = true;
            this.noticeLabel.BackColor = System.Drawing.Color.Transparent;
            this.noticeLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.noticeLabel.Location = new System.Drawing.Point(14, 90);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(71, 16);
            this.noticeLabel.TabIndex = 6;
            this.noticeLabel.Text = "Info stuff";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(14, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(130, 16);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Internet Protocal";
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnCalculate.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.BtnCalculate.Location = new System.Drawing.Point(271, 112);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 5;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.PnSecond);
            this.groupPanel2.Controls.Add(this.labelX10);
            this.groupPanel2.Controls.Add(this.labelX9);
            this.groupPanel2.Controls.Add(this.labelX8);
            this.groupPanel2.Controls.Add(this.labelX7);
            this.groupPanel2.Controls.Add(this.labelX6);
            this.groupPanel2.Controls.Add(this.labelX5);
            this.groupPanel2.Controls.Add(this.labelX4);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.BtnSubnetMask);
            this.groupPanel2.Controls.Add(this.nextNumOfHosts);
            this.groupPanel2.Controls.Add(this.clacMaxNetCount);
            this.groupPanel2.Controls.Add(this.calcIPRange);
            this.groupPanel2.Controls.Add(this.netMaskComboBox);
            this.groupPanel2.Controls.Add(this.calcBroadcast);
            this.groupPanel2.Controls.Add(this.prefixComboBox);
            this.groupPanel2.Controls.Add(this.firstBitCheckBox);
            this.groupPanel2.Controls.Add(this.calcNetwork);
            this.groupPanel2.Controls.Add(this.maxCountHosts);
            this.groupPanel2.Location = new System.Drawing.Point(18, 156);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(622, 312);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 18;
            this.groupPanel2.Text = "Results / Option ";
            // 
            // PnSecond
            // 
            this.PnSecond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnSecond.CanvasColor = System.Drawing.SystemColors.Control;
            this.PnSecond.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.PnSecond.Controls.Add(this.BtnPnSecondClose);
            this.PnSecond.Controls.Add(this.Lbls7);
            this.PnSecond.Controls.Add(this.Lbls6);
            this.PnSecond.Controls.Add(this.Lbls5);
            this.PnSecond.Controls.Add(this.Lbls4);
            this.PnSecond.Controls.Add(this.Lbls3);
            this.PnSecond.Controls.Add(this.Lbls2);
            this.PnSecond.Controls.Add(this.lbls1);
            this.PnSecond.Controls.Add(this.panelEx3);
            this.PnSecond.Controls.Add(this.labelX29);
            this.PnSecond.Controls.Add(this.labelX23);
            this.PnSecond.Controls.Add(this.labelX24);
            this.PnSecond.Controls.Add(this.labelX25);
            this.PnSecond.Controls.Add(this.labelX26);
            this.PnSecond.Controls.Add(this.labelX27);
            this.PnSecond.Controls.Add(this.labelX28);
            this.PnSecond.Location = new System.Drawing.Point(162, 71);
            this.PnSecond.Name = "PnSecond";
            this.PnSecond.Size = new System.Drawing.Size(334, 207);
            this.PnSecond.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PnSecond.Style.BackColor1.Color = System.Drawing.Color.Silver;
            this.PnSecond.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PnSecond.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PnSecond.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBorder;
            this.PnSecond.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.PnSecond.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PnSecond.Style.GradientAngle = 90;
            this.PnSecond.TabIndex = 7;
            this.PnSecond.Visible = false;
            // 
            // BtnPnSecondClose
            // 
            this.BtnPnSecondClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnPnSecondClose.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.BtnPnSecondClose.Location = new System.Drawing.Point(129, 177);
            this.BtnPnSecondClose.Name = "BtnPnSecondClose";
            this.BtnPnSecondClose.Size = new System.Drawing.Size(75, 23);
            this.BtnPnSecondClose.TabIndex = 5;
            this.BtnPnSecondClose.Text = "Close";
            this.BtnPnSecondClose.Click += new System.EventHandler(this.BtnPnSecondClose_Click);
            // 
            // Lbls7
            // 
            this.Lbls7.AutoSize = true;
            this.Lbls7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbls7.Location = new System.Drawing.Point(155, 156);
            this.Lbls7.Name = "Lbls7";
            this.Lbls7.Size = new System.Drawing.Size(26, 15);
            this.Lbls7.TabIndex = 4;
            this.Lbls7.Text = "label";
            // 
            // Lbls6
            // 
            this.Lbls6.AutoSize = true;
            this.Lbls6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbls6.Location = new System.Drawing.Point(155, 135);
            this.Lbls6.Name = "Lbls6";
            this.Lbls6.Size = new System.Drawing.Size(26, 15);
            this.Lbls6.TabIndex = 4;
            this.Lbls6.Text = "label";
            // 
            // Lbls5
            // 
            this.Lbls5.AutoSize = true;
            this.Lbls5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbls5.Location = new System.Drawing.Point(155, 112);
            this.Lbls5.Name = "Lbls5";
            this.Lbls5.Size = new System.Drawing.Size(26, 15);
            this.Lbls5.TabIndex = 4;
            this.Lbls5.Text = "label";
            // 
            // Lbls4
            // 
            this.Lbls4.AutoSize = true;
            this.Lbls4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbls4.Location = new System.Drawing.Point(155, 89);
            this.Lbls4.Name = "Lbls4";
            this.Lbls4.Size = new System.Drawing.Size(26, 15);
            this.Lbls4.TabIndex = 4;
            this.Lbls4.Text = "label";
            // 
            // Lbls3
            // 
            this.Lbls3.AutoSize = true;
            this.Lbls3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbls3.Location = new System.Drawing.Point(155, 66);
            this.Lbls3.Name = "Lbls3";
            this.Lbls3.Size = new System.Drawing.Size(26, 15);
            this.Lbls3.TabIndex = 4;
            this.Lbls3.Text = "label";
            // 
            // Lbls2
            // 
            this.Lbls2.AutoSize = true;
            this.Lbls2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbls2.Location = new System.Drawing.Point(155, 43);
            this.Lbls2.Name = "Lbls2";
            this.Lbls2.Size = new System.Drawing.Size(26, 15);
            this.Lbls2.TabIndex = 4;
            this.Lbls2.Text = "label";
            // 
            // lbls1
            // 
            this.lbls1.AutoSize = true;
            this.lbls1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbls1.Location = new System.Drawing.Point(155, 20);
            this.lbls1.Name = "lbls1";
            this.lbls1.Size = new System.Drawing.Size(26, 15);
            this.lbls1.TabIndex = 4;
            this.lbls1.Text = "label";
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.Location = new System.Drawing.Point(-9, 1);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(353, 13);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.Color = System.Drawing.Color.Gray;
            this.panelEx3.Style.BackColor2.Color = System.Drawing.Color.Black;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 3;
            // 
            // labelX29
            // 
            this.labelX29.AutoSize = true;
            this.labelX29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelX29.Location = new System.Drawing.Point(7, 156);
            this.labelX29.Name = "labelX29";
            this.labelX29.Size = new System.Drawing.Size(145, 15);
            this.labelX29.TabIndex = 2;
            this.labelX29.Text = "Maximum Number Of Host ->";
            // 
            // labelX23
            // 
            this.labelX23.AutoSize = true;
            this.labelX23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelX23.Location = new System.Drawing.Point(7, 135);
            this.labelX23.Name = "labelX23";
            this.labelX23.Size = new System.Drawing.Size(139, 15);
            this.labelX23.TabIndex = 2;
            this.labelX23.Text = "Maximum Network Count ->";
            // 
            // labelX24
            // 
            this.labelX24.AutoSize = true;
            this.labelX24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelX24.Location = new System.Drawing.Point(7, 112);
            this.labelX24.Name = "labelX24";
            this.labelX24.Size = new System.Drawing.Size(142, 15);
            this.labelX24.TabIndex = 1;
            this.labelX24.Text = "Maximum IP-Range --------->";
            // 
            // labelX25
            // 
            this.labelX25.AutoSize = true;
            this.labelX25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelX25.Location = new System.Drawing.Point(7, 89);
            this.labelX25.Name = "labelX25";
            this.labelX25.Size = new System.Drawing.Size(142, 15);
            this.labelX25.TabIndex = 1;
            this.labelX25.Text = "Broadcast ---------------------->";
            // 
            // labelX26
            // 
            this.labelX26.AutoSize = true;
            this.labelX26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelX26.Location = new System.Drawing.Point(7, 66);
            this.labelX26.Name = "labelX26";
            this.labelX26.Size = new System.Drawing.Size(144, 15);
            this.labelX26.TabIndex = 1;
            this.labelX26.Text = "Network ------------------------->";
            this.labelX26.WordWrap = true;
            // 
            // labelX27
            // 
            this.labelX27.AutoSize = true;
            this.labelX27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelX27.Location = new System.Drawing.Point(7, 43);
            this.labelX27.Name = "labelX27";
            this.labelX27.Size = new System.Drawing.Size(144, 15);
            this.labelX27.TabIndex = 1;
            this.labelX27.Text = "Sub-Net Mask ----------------->";
            // 
            // labelX28
            // 
            this.labelX28.AutoSize = true;
            this.labelX28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelX28.Location = new System.Drawing.Point(7, 20);
            this.labelX28.Name = "labelX28";
            this.labelX28.Size = new System.Drawing.Size(142, 15);
            this.labelX28.TabIndex = 1;
            this.labelX28.Text = "Number Of Host -------------->";
            // 
            // labelX10
            // 
            this.labelX10.AutoSize = true;
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            this.labelX10.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F);
            this.labelX10.Location = new System.Drawing.Point(14, 248);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(175, 16);
            this.labelX10.TabIndex = 19;
            this.labelX10.Text = "Wanted number of hosts:";
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            this.labelX9.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F);
            this.labelX9.Location = new System.Drawing.Point(14, 216);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(196, 16);
            this.labelX9.TabIndex = 19;
            this.labelX9.Text = "Maximum number of subnets:";
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            this.labelX8.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F);
            this.labelX8.Location = new System.Drawing.Point(14, 184);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(70, 16);
            this.labelX8.TabIndex = 19;
            this.labelX8.Text = "IP - range:";
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F);
            this.labelX7.Location = new System.Drawing.Point(14, 152);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(80, 16);
            this.labelX7.TabIndex = 19;
            this.labelX7.Text = "Broadcast:";
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F);
            this.labelX6.Location = new System.Drawing.Point(14, 120);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(68, 16);
            this.labelX6.TabIndex = 19;
            this.labelX6.Text = "Network:";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F);
            this.labelX5.Location = new System.Drawing.Point(14, 88);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(182, 16);
            this.labelX5.TabIndex = 19;
            this.labelX5.Text = "Maximum number of Hosts:";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F);
            this.labelX4.Location = new System.Drawing.Point(14, 52);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(69, 16);
            this.labelX4.TabIndex = 19;
            this.labelX4.Text = "Net-Mask:";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F);
            this.labelX2.Location = new System.Drawing.Point(14, 17);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(50, 16);
            this.labelX2.TabIndex = 19;
            this.labelX2.Text = "Prefix:";
            // 
            // BtnSubnetMask
            // 
            this.BtnSubnetMask.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSubnetMask.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.BtnSubnetMask.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F);
            this.BtnSubnetMask.Location = new System.Drawing.Point(352, 240);
            this.BtnSubnetMask.Name = "BtnSubnetMask";
            this.BtnSubnetMask.Size = new System.Drawing.Size(176, 41);
            this.BtnSubnetMask.TabIndex = 18;
            this.BtnSubnetMask.Text = "Show next subnet with this number of hosts";
            this.BtnSubnetMask.Click += new System.EventHandler(this.BtnSubnetMask_Click);
            // 
            // PnFirst
            // 
            this.PnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnFirst.CanvasColor = System.Drawing.SystemColors.Control;
            this.PnFirst.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.PnFirst.Controls.Add(this.Lbl6);
            this.PnFirst.Controls.Add(this.Lbl5);
            this.PnFirst.Controls.Add(this.Lbl4);
            this.PnFirst.Controls.Add(this.Lbl3);
            this.PnFirst.Controls.Add(this.Lbl2);
            this.PnFirst.Controls.Add(this.Lbl1);
            this.PnFirst.Controls.Add(this.panelEx1);
            this.PnFirst.Controls.Add(this.labelX16);
            this.PnFirst.Controls.Add(this.labelX15);
            this.PnFirst.Controls.Add(this.labelX14);
            this.PnFirst.Controls.Add(this.labelX13);
            this.PnFirst.Controls.Add(this.labelX12);
            this.PnFirst.Controls.Add(this.labelX11);
            this.PnFirst.Controls.Add(this.BtnPnfirstClose);
            this.PnFirst.Location = new System.Drawing.Point(183, 33);
            this.PnFirst.Name = "PnFirst";
            this.PnFirst.Size = new System.Drawing.Size(334, 186);
            this.PnFirst.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PnFirst.Style.BackColor1.Color = System.Drawing.Color.Silver;
            this.PnFirst.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PnFirst.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PnFirst.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBorder;
            this.PnFirst.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.PnFirst.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PnFirst.Style.GradientAngle = 90;
            this.PnFirst.TabIndex = 7;
            this.PnFirst.Visible = false;
            // 
            // Lbl6
            // 
            this.Lbl6.AutoSize = true;
            this.Lbl6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl6.Location = new System.Drawing.Point(155, 135);
            this.Lbl6.Name = "Lbl6";
            this.Lbl6.Size = new System.Drawing.Size(26, 15);
            this.Lbl6.TabIndex = 4;
            this.Lbl6.Text = "label";
            // 
            // Lbl5
            // 
            this.Lbl5.AutoSize = true;
            this.Lbl5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl5.Location = new System.Drawing.Point(155, 112);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(26, 15);
            this.Lbl5.TabIndex = 4;
            this.Lbl5.Text = "label";
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Lbl4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl4.Location = new System.Drawing.Point(155, 89);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(26, 15);
            this.Lbl4.TabIndex = 4;
            this.Lbl4.Text = "label";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl3.Location = new System.Drawing.Point(155, 66);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(26, 15);
            this.Lbl3.TabIndex = 4;
            this.Lbl3.Text = "label";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl2.Location = new System.Drawing.Point(155, 43);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(26, 15);
            this.Lbl2.TabIndex = 4;
            this.Lbl2.Text = "label";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Lbl1.Location = new System.Drawing.Point(155, 20);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(26, 15);
            this.Lbl1.TabIndex = 4;
            this.Lbl1.Text = "label";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Location = new System.Drawing.Point(-9, 1);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(353, 13);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.Gray;
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.Black;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 3;
            // 
            // labelX16
            // 
            this.labelX16.AutoSize = true;
            this.labelX16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelX16.Location = new System.Drawing.Point(7, 135);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(142, 15);
            this.labelX16.TabIndex = 2;
            this.labelX16.Text = "Maximum IP-Range --------->";
            // 
            // labelX15
            // 
            this.labelX15.AutoSize = true;
            this.labelX15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelX15.Location = new System.Drawing.Point(7, 112);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(142, 15);
            this.labelX15.TabIndex = 1;
            this.labelX15.Text = "Broadcast ---------------------->";
            // 
            // labelX14
            // 
            this.labelX14.AutoSize = true;
            this.labelX14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelX14.Location = new System.Drawing.Point(7, 89);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(144, 15);
            this.labelX14.TabIndex = 1;
            this.labelX14.Text = "Network ------------------------->";
            // 
            // labelX13
            // 
            this.labelX13.AutoSize = true;
            this.labelX13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelX13.Location = new System.Drawing.Point(7, 66);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(143, 15);
            this.labelX13.TabIndex = 1;
            this.labelX13.Text = "Max No Of HostYou Can --->";
            this.labelX13.WordWrap = true;
            // 
            // labelX12
            // 
            this.labelX12.AutoSize = true;
            this.labelX12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelX12.Location = new System.Drawing.Point(7, 43);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(144, 15);
            this.labelX12.TabIndex = 1;
            this.labelX12.Text = "Sub-Net Mask ----------------->";
            // 
            // labelX11
            // 
            this.labelX11.AutoSize = true;
            this.labelX11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelX11.Location = new System.Drawing.Point(7, 20);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(142, 15);
            this.labelX11.TabIndex = 1;
            this.labelX11.Text = "Network Type Is -------------->";
            // 
            // BtnPnfirstClose
            // 
            this.BtnPnfirstClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnPnfirstClose.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.BtnPnfirstClose.Location = new System.Drawing.Point(129, 157);
            this.BtnPnfirstClose.Name = "BtnPnfirstClose";
            this.BtnPnfirstClose.Size = new System.Drawing.Size(76, 23);
            this.BtnPnfirstClose.TabIndex = 0;
            this.BtnPnfirstClose.Text = "Close";
            this.BtnPnfirstClose.Click += new System.EventHandler(this.BtnPnfirstClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(659, 474);
            this.Controls.Add(this.PnFirst);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  IP Sub Net Calculator     ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.PnSecond.ResumeLayout(false);
            this.PnSecond.PerformLayout();
            this.PnFirst.ResumeLayout(false);
            this.PnFirst.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
        //[STAThread]
        //static void Main() 
        //{
        //    Application.EnableVisualStyles() ;
        //    Application.DoEvents();
        //    Application.Run(new MainForm());
        //}

		#region Events
		private void ipAddress_Leave(object sender, System.EventArgs e)
		{
			newIP();
		}

		private void ipAddress_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if ( e.KeyCode == Keys.Enter )
			{
				newIP();			
			}
		}

		private void prefixComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (ip == null || ip.getIp() == null || fill) return;
			if (ip.getNetworkClassPrefix() == -1) return;
				
			int prefix = Int32.Parse((string)prefixComboBox.SelectedItem);
			ip.setNetworkPrefix(prefix);

			fillIPCalc();
		}

		private void netMaskComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (ip == null || ip.getIp() == null || fill) return;
			if (ip.getNetworkClassPrefix() == -1) return;
				
			int select = netMaskComboBox.SelectedIndex;
			int prefix = select + ip.getNetworkClassPrefix();
			if (select != 0 && !ip.isFirstSubNetBit()) prefix++; 
			//int prefix = Integer.parseInt((String)main.getJcb_Calc_NetworkMask().getSelectedItem());
			ip.setNetworkPrefix(prefix);

			fillIPCalc();
		}

		private void netClassComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (fill) return;
			switch (netClassComboBox.SelectedIndex)
			{
				case 0: ipAddress.Text = "1.0.0.1";
					break;				
				case 1: ipAddress.Text = "128.0.0.1";
					break;
				case 2: ipAddress.Text = "192.0.0.1";
					break;
				case 3: ipAddress.Text = "224.0.0.1";
					break;
				case 4: ipAddress.Text = "240.0.0.1";
					break;
			}
				
			newIP ();
		}

		private void firstBitCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if (ip == null || ip.getIp() == null || fill) return;
				
			ip.setFirstSubNetBit(firstBitCheckBox.Checked);
			fillIPCalc();
		}

	

		
		#endregion

		#region Methods Used
		protected void newIP()
		{
			try 
			{
				ip = new IPTool (ipAddress.Text);
				ipAddress.BackColor = Color.White;
				fillIPCalc();
			}
			catch(Exception e)
			{
				//MessageBox.Show(e.StackTrace);
			}
			//catch (UnknownHostException e) 
			//{
			//	main.getJp_Calc().getJtf_IP_Calc().setBackground(java.awt.Color.red);
			//}
		}

		protected void fillIPCalc()
		{
			if (ip == null || ip.getIp() == null) return;
			this.fill = true;
		
			this.fillComboBox_Prefix();
			this.fillComboBox_NetworkMask();
		
			// Prefix
			int prefix = ip.getNetworkPrefix();
			if (prefix >= 8 && prefix <= 30) 
			{
				if (prefix != ip.getNetworkClassPrefix() && !ip.isFirstSubNetBit()) prefix--;
				prefix = prefix - ip.getNetworkClassPrefix(); 
			} 
			else prefix = -1;
			prefixComboBox.SelectedIndex = prefix;
			// NetMask
			netMaskComboBox.SelectedIndex = prefix;
		
			// folgendes nur wenn Netzwerkmaske vorhanden
			// nicht der Fall bei Class-D oder E
			if (prefix != -1)
			{
				// max Net Hosts
				maxCountHosts.Text = ip.getMaxNetworkHosts()+"";
				// Net Class    
				calcNetwork.Text = ip.getNetworkClassName();
				// Broadcast
				calcBroadcast.Text = ip.getBroadCast();
				//	Network
				calcNetwork.Text = ip.getNetwork();
				//	Net-Class
				netClassComboBox.SelectedIndex = ip.getNetworkClass();
				// IP-Range
				string [] ipRange = ip.getNetworkIPRange();
				calcIPRange.Text = ipRange[0]+" - "+ipRange[1];
				// max Sub-Nets
				clacMaxNetCount.Text = ip.getMaxSubNets()+"";
			}
			else // Anzeige löschen
			{
				// max Net Hosts
				maxCountHosts.Text = "";
				// Net Class    
				calcNetwork.Text = "";
				// Broadcast
				calcBroadcast.Text = "";
				//	Network
				calcNetwork.Text = "";
				// IP-Range
				calcIPRange.Text = "";
				// max Sub-Nets
				clacMaxNetCount.Text = "";
			}
			// Description
			string desc = "";  
			if (ip.get1Byte() >= (byte)64 && ip.getNetworkClass() == (byte)0)	// 64. 
				desc = "reserved for future use";
			if (ip.get1Byte() == (byte)127)	// localhost 
				desc = "localhost and loopback-Device - your one computer";
			if (ip.get1Byte() == (byte)10) 	// private 10.0.0.0
				desc = "private net - for internal use only, would not be routed in internet";
			if (ip.get1Byte() == (byte)192 && ip.get2Byte() == (byte)168)  // private 192. - 168. 
				desc = "private net - for internal use only, would not be routed in internet";
			if (ip.get1Byte() == (byte)172 && (ip.get2Byte() >= (byte)16 && ip.get2Byte() <= (byte)31))		//private 172.16 - 172.31 
				desc = "private net - for internal use only, would not be routed in internet";
			if ((ip.get1Byte() == (byte)169) && (ip.get2Byte() == (byte)254))		// 169.254. 
				desc = "APIPA Automatic Private IP Addressing";
			if (ip.get1Byte() == (byte)0) 	// 0.
				desc = "0.0.0.0 = default route";
			if (ip.getNetworkClass() == (byte)4) // Class-E 
				desc = "reserved for future use";
			if (ip.getNetworkClass() == (byte)3) // Class-D 
				desc = "used for multicast";

			noticeLabel.Text = "Info stuff: "+desc;
			this.fill = false;
		}

		protected void fillComboBox_Prefix ()
		{
			if (ip == null || ip.getIp() == null) return;
		
			prefixComboBox.Items.Clear();
		
			if (ip.getNetworkClassPrefix() == -1) 
			{
				prefixComboBox.Items.Add("");
				return;
			} 

			int startPrefix = ip.getNetworkClassPrefix();
			// first is Networkclass
			prefixComboBox.Items.Add(startPrefix+"");
			startPrefix++;
			if (!ip.isFirstSubNetBit()) startPrefix++;
		
			for (int i=startPrefix; i<=30; i++) 
				prefixComboBox.Items.Add(i+"");
		}
		protected void fillComboBox_NetworkMask ()
		{
			if (ip == null || ip.getIp() == null) return;
		
			netMaskComboBox.Items.Clear();
		
			if (ip.getNetworkClassPrefix() == -1) 
			{
				netMaskComboBox.Items.Add("");
				return;
			} 
		 
			int startPrefix = ip.getNetworkClassPrefix();
			// first is Networkclass
			netMaskComboBox.Items.Add(ip.getNetworkMaskByPrefix(startPrefix));
			startPrefix++;
			if (!ip.isFirstSubNetBit()) startPrefix++;
		
			for (int i=startPrefix; i<=30; i++) 
				netMaskComboBox.Items.Add(ip.getNetworkMaskByPrefix(i));
		}
		#endregion

		

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black;

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            newIP();
            PnFirst.Visible = true;
            string strnet = "Network Type Is -> " + netClassComboBox.Text;
            //MessageBox.Show(strnet);
            Lbl1.Text = netClassComboBox.Text;
            string strsubnet = "Sub-Net Mask -> " + netMaskComboBox.Text;
            //MessageBox.Show(strsubnet);
            Lbl2.Text = netMaskComboBox.Text;
            string strhost = "Maximum Number Of Host You Can Connect in this Network is " + maxCountHosts.Text;
           //MessageBox.Show(strhost);
            Lbl3.Text = maxCountHosts.Text;
            string strnetq = "Network -> " + calcNetwork.Text;
            //MessageBox.Show(strnetq);
            Lbl4.Text = calcNetwork.Text;
            string strbroad = "Broadcast -> " + calcBroadcast.Text;
           // MessageBox.Show(strbroad);
            Lbl5.Text = calcBroadcast.Text;
            string strip = "Maximum IP-Range You Can Have in this Network -->> " + calcIPRange.Text;
           // MessageBox.Show(strip);
            Lbl6.Text = calcIPRange.Text;
        }

        private void BtnSubnetMask_Click(object sender, EventArgs e)
        {
            if (ip == null || ip.getIp() == null || fill) return;
            nextNumOfHosts.BackColor = Color.White;

            try
            {
                int hosts = Int32.Parse(nextNumOfHosts.Text);

                IPTool newIp = ip.getNextSubNet(hosts);
                if (newIp == null)
                {
                    //ToManyHosts
                    MessageBox.Show("Info stuff: Number of hosts in this network-class not possible!");
                    noticeLabel.Text = "Info stuff: Number of hosts in this network-class not possible!";
                    return;
                }
                ip = newIp;
                ipAddress.Text = ip.getIp();

            }
            catch (System.FormatException)
            {
                nextNumOfHosts.BackColor = Color.Red;
                return;
            }
            catch (Exception e1)
            {
                //MessageBox.Show(e1.StackTrace);
                return;
            }
            PnSecond.Visible = true;
            fillIPCalc();
            //MessageBox.Show("Wanted Number Of Host is ->" + nextNumOfHosts.Text);
            lbls1.Text=nextNumOfHosts.Text;
            string strsubnet = "Sub-Net Mask is" + netMaskComboBox.Text;
           // MessageBox.Show(strsubnet);
            Lbls2.Text = netMaskComboBox.Text;
            string strnetq = "Network ->> " + calcNetwork.Text;
            //MessageBox.Show(strnetq);
            Lbls3.Text = calcNetwork.Text;
            string strbroad = "Broadcast -->>" + calcBroadcast.Text;
            //MessageBox.Show(strbroad);
            Lbls4.Text = calcBroadcast.Text;
            string strip = "Maximum IP-Range You Can Have in this Network -->>" + calcIPRange.Text;
           // MessageBox.Show(strip);
            Lbls5.Text = calcIPRange.Text;
            string strmaxcount = "Maximum Network Count You can Have In this Network is " + clacMaxNetCount.Text;
          //  MessageBox.Show(strmaxcount);
            Lbls6.Text = clacMaxNetCount.Text;
            string strhost = "Maximum Number Of Host You Can Connect in this Network is " + maxCountHosts.Text;
            //MessageBox.Show(strhost);
            Lbls7.Text = maxCountHosts.Text;
        }

        private void BtnPnfirstClose_Click(object sender, EventArgs e)
        {
            PnFirst.Visible = false;
        }

        private void BtnPnSecondClose_Click(object sender, EventArgs e)
        {
            PnSecond.Visible = false;
        }
     }
}
