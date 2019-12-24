namespace CssSprite
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtSass = new System.Windows.Forms.TextBox();
            this.txtCss = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.chkBoxPhone = new System.Windows.Forms.CheckBox();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdOrderByName = new System.Windows.Forms.RadioButton();
            this.rdOrderBySize = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdHorizon = new System.Windows.Forms.RadioButton();
            this.rdVertical = new System.Windows.Forms.RadioButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCanvas = new System.Windows.Forms.TabPage();
            this.panelImages = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtBase64Sass = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtBase64Css = new System.Windows.Forms.TextBox();
            this.cbAlign = new System.Windows.Forms.CheckBox();
            this.tbSrc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panelTool = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.recentList = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxImgType = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.canvasButtons = new System.Windows.Forms.Panel();
            this.tLogs = new System.Windows.Forms.RichTextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabCanvas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panelTool.SuspendLayout();
            this.panel11.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.canvasButtons.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Png文件|*.png|Jpeg文件|*.jpeg|Jpg文件|*.jpg";
            this.openFileDialog.Multiselect = true;
            // 
            // txtSass
            // 
            this.txtSass.BackColor = System.Drawing.Color.White;
            this.txtSass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSass.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtSass.Location = new System.Drawing.Point(3, 3);
            this.txtSass.Multiline = true;
            this.txtSass.Name = "txtSass";
            this.txtSass.ReadOnly = true;
            this.txtSass.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSass.Size = new System.Drawing.Size(507, 344);
            this.txtSass.TabIndex = 11;
            this.txtSass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSass_KeyDown);
            // 
            // txtCss
            // 
            this.txtCss.BackColor = System.Drawing.Color.White;
            this.txtCss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCss.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtCss.Location = new System.Drawing.Point(3, 3);
            this.txtCss.Multiline = true;
            this.txtCss.Name = "txtCss";
            this.txtCss.ReadOnly = true;
            this.txtCss.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCss.Size = new System.Drawing.Size(507, 344);
            this.txtCss.TabIndex = 19;
            this.txtCss.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCss_KeyDown);
            // 
            // chkBoxPhone
            // 
            this.chkBoxPhone.AutoSize = true;
            this.chkBoxPhone.Location = new System.Drawing.Point(9, 5);
            this.chkBoxPhone.Name = "chkBoxPhone";
            this.chkBoxPhone.Size = new System.Drawing.Size(84, 16);
            this.chkBoxPhone.TabIndex = 0;
            this.chkBoxPhone.Text = "用于手机端";
            this.chkBoxPhone.UseVisualStyleBackColor = true;
            this.chkBoxPhone.CheckedChanged += new System.EventHandler(this.chkBoxPhone_CheckedChanged);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.AutoSize = true;
            this.btnRemoveImage.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRemoveImage.FlatAppearance.BorderSize = 0;
            this.btnRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveImage.ForeColor = System.Drawing.Color.White;
            this.btnRemoveImage.Location = new System.Drawing.Point(83, 2);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(69, 24);
            this.btnRemoveImage.TabIndex = 1;
            this.btnRemoveImage.Text = "移除图标";
            this.btnRemoveImage.UseVisualStyleBackColor = false;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(85, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(69, 40);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "打开项目";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnSprite_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.AutoSize = true;
            this.btnAddImage.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddImage.FlatAppearance.BorderSize = 0;
            this.btnAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImage.ForeColor = System.Drawing.Color.White;
            this.btnAddImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddImage.Location = new System.Drawing.Point(4, 2);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(69, 24);
            this.btnAddImage.TabIndex = 0;
            this.btnAddImage.Text = "添加图标";
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(164, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存项目";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.ButtonMakeBigImageCss_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rdOrderByName);
            this.panel3.Controls.Add(this.rdOrderBySize);
            this.panel3.Location = new System.Drawing.Point(113, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(99, 62);
            this.panel3.TabIndex = 25;
            // 
            // rdOrderByName
            // 
            this.rdOrderByName.AutoSize = true;
            this.rdOrderByName.Location = new System.Drawing.Point(18, 8);
            this.rdOrderByName.Name = "rdOrderByName";
            this.rdOrderByName.Size = new System.Drawing.Size(59, 16);
            this.rdOrderByName.TabIndex = 0;
            this.rdOrderByName.Text = "按名称";
            this.rdOrderByName.UseVisualStyleBackColor = true;
            this.rdOrderByName.CheckedChanged += new System.EventHandler(this.ResumeLayout);
            // 
            // rdOrderBySize
            // 
            this.rdOrderBySize.AutoSize = true;
            this.rdOrderBySize.Checked = true;
            this.rdOrderBySize.Location = new System.Drawing.Point(18, 38);
            this.rdOrderBySize.Name = "rdOrderBySize";
            this.rdOrderBySize.Size = new System.Drawing.Size(59, 16);
            this.rdOrderBySize.TabIndex = 1;
            this.rdOrderBySize.TabStop = true;
            this.rdOrderBySize.Text = "按尺寸";
            this.rdOrderBySize.UseVisualStyleBackColor = true;
            this.rdOrderBySize.CheckedChanged += new System.EventHandler(this.ResumeLayout);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rdHorizon);
            this.panel2.Controls.Add(this.rdVertical);
            this.panel2.Location = new System.Drawing.Point(9, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 62);
            this.panel2.TabIndex = 25;
            // 
            // rdHorizon
            // 
            this.rdHorizon.AutoSize = true;
            this.rdHorizon.Location = new System.Drawing.Point(12, 11);
            this.rdHorizon.Name = "rdHorizon";
            this.rdHorizon.Size = new System.Drawing.Size(47, 16);
            this.rdHorizon.TabIndex = 0;
            this.rdHorizon.Text = "横排";
            this.rdHorizon.UseVisualStyleBackColor = true;
            this.rdHorizon.CheckedChanged += new System.EventHandler(this.buttonHRange_Click);
            // 
            // rdVertical
            // 
            this.rdVertical.AutoSize = true;
            this.rdVertical.Checked = true;
            this.rdVertical.Location = new System.Drawing.Point(12, 38);
            this.rdVertical.Name = "rdVertical";
            this.rdVertical.Size = new System.Drawing.Size(47, 16);
            this.rdVertical.TabIndex = 1;
            this.rdVertical.TabStop = true;
            this.rdVertical.Text = "竖排";
            this.rdVertical.UseVisualStyleBackColor = true;
            this.rdVertical.CheckedChanged += new System.EventHandler(this.ButtonVRange_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabCanvas);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.ItemSize = new System.Drawing.Size(48, 28);
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(521, 386);
            this.tabControl.TabIndex = 0;
            // 
            // tabCanvas
            // 
            this.tabCanvas.Controls.Add(this.panelImages);
            this.tabCanvas.Location = new System.Drawing.Point(4, 32);
            this.tabCanvas.Name = "tabCanvas";
            this.tabCanvas.Padding = new System.Windows.Forms.Padding(3);
            this.tabCanvas.Size = new System.Drawing.Size(513, 350);
            this.tabCanvas.TabIndex = 4;
            this.tabCanvas.Text = "画布";
            this.tabCanvas.UseVisualStyleBackColor = true;
            // 
            // panelImages
            // 
            this.panelImages.AutoScroll = true;
            this.panelImages.BackgroundImage = global::CssSprite.Properties.Resources.transparent;
            this.panelImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImages.Location = new System.Drawing.Point(3, 3);
            this.panelImages.Name = "panelImages";
            this.panelImages.Size = new System.Drawing.Size(507, 344);
            this.panelImages.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSass);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(513, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "sass";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCss);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(513, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "css/less";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtBase64Sass);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(513, 350);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "sass Base64";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtBase64Sass
            // 
            this.txtBase64Sass.BackColor = System.Drawing.Color.White;
            this.txtBase64Sass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBase64Sass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBase64Sass.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtBase64Sass.Location = new System.Drawing.Point(3, 3);
            this.txtBase64Sass.Multiline = true;
            this.txtBase64Sass.Name = "txtBase64Sass";
            this.txtBase64Sass.ReadOnly = true;
            this.txtBase64Sass.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBase64Sass.Size = new System.Drawing.Size(507, 344);
            this.txtBase64Sass.TabIndex = 12;
            this.txtBase64Sass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBase64Sass_KeyDown);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtBase64Css);
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(513, 350);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "css Base64";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtBase64Css
            // 
            this.txtBase64Css.BackColor = System.Drawing.Color.White;
            this.txtBase64Css.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBase64Css.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBase64Css.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtBase64Css.Location = new System.Drawing.Point(3, 3);
            this.txtBase64Css.Multiline = true;
            this.txtBase64Css.Name = "txtBase64Css";
            this.txtBase64Css.ReadOnly = true;
            this.txtBase64Css.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBase64Css.Size = new System.Drawing.Size(507, 344);
            this.txtBase64Css.TabIndex = 12;
            this.txtBase64Css.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBase64Css_KeyDown);
            // 
            // cbAlign
            // 
            this.cbAlign.AutoSize = true;
            this.cbAlign.Location = new System.Drawing.Point(9, 6);
            this.cbAlign.Name = "cbAlign";
            this.cbAlign.Size = new System.Drawing.Size(144, 16);
            this.cbAlign.TabIndex = 0;
            this.cbAlign.Text = "对齐相邻的同尺寸图片";
            this.cbAlign.UseVisualStyleBackColor = true;
            this.cbAlign.CheckedChanged += new System.EventHandler(this.ResumeLayout);
            // 
            // tbSrc
            // 
            this.tbSrc.BackColor = System.Drawing.Color.White;
            this.tbSrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSrc.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbSrc.Location = new System.Drawing.Point(87, 4);
            this.tbSrc.Name = "tbSrc";
            this.tbSrc.Size = new System.Drawing.Size(121, 21);
            this.tbSrc.TabIndex = 1;
            this.tbSrc.Text = "src";
            this.tbSrc.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "图片存放目录";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "sprite";
            this.saveFileDialog.Filter = "精灵图文件|*.sprite";
            // 
            // panelTool
            // 
            this.panelTool.Controls.Add(this.panel11);
            this.panelTool.Controls.Add(this.recentList);
            this.panelTool.Controls.Add(this.flowLayoutPanel1);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTool.Location = new System.Drawing.Point(527, 0);
            this.panelTool.Name = "panelTool";
            this.panelTool.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.panelTool.Size = new System.Drawing.Size(257, 566);
            this.panelTool.TabIndex = 25;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.Controls.Add(this.btnNew);
            this.panel11.Controls.Add(this.btnSave);
            this.panel11.Controls.Add(this.btnLoad);
            this.panel11.Location = new System.Drawing.Point(9, 12);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(244, 45);
            this.panel11.TabIndex = 27;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(69, 40);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "新建项目";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // recentList
            // 
            this.recentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recentList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.recentList.Location = new System.Drawing.Point(9, 63);
            this.recentList.Name = "recentList";
            this.recentList.Size = new System.Drawing.Size(244, 203);
            this.recentList.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel9);
            this.flowLayoutPanel1.Controls.Add(this.panel10);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 280);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(244, 282);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tbSrc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 29);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtName);
            this.panel4.Location = new System.Drawing.Point(3, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 27);
            this.panel4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "精灵图文件名";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtName.Location = new System.Drawing.Point(87, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 21);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "sprite-icon";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.tbPrefix);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(3, 71);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(241, 27);
            this.panel5.TabIndex = 2;
            // 
            // tbPrefix
            // 
            this.tbPrefix.BackColor = System.Drawing.Color.White;
            this.tbPrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrefix.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbPrefix.Location = new System.Drawing.Point(87, 4);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.Size = new System.Drawing.Size(121, 21);
            this.tbPrefix.TabIndex = 1;
            this.tbPrefix.Text = "sprite-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "CSS类名前缀";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.comboBoxImgType);
            this.panel6.Location = new System.Drawing.Point(3, 104);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(241, 27);
            this.panel6.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "精灵图类型";
            // 
            // comboBoxImgType
            // 
            this.comboBoxImgType.BackColor = System.Drawing.Color.White;
            this.comboBoxImgType.ForeColor = System.Drawing.Color.RoyalBlue;
            this.comboBoxImgType.Items.AddRange(new object[] {
            "PNG",
            "JPG",
            "JPEG"});
            this.comboBoxImgType.Location = new System.Drawing.Point(87, 4);
            this.comboBoxImgType.Name = "comboBoxImgType";
            this.comboBoxImgType.Size = new System.Drawing.Size(121, 20);
            this.comboBoxImgType.TabIndex = 1;
            this.comboBoxImgType.Text = "PNG";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Location = new System.Drawing.Point(3, 137);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(241, 74);
            this.panel7.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Location = new System.Drawing.Point(3, 170);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(241, 27);
            this.panel8.TabIndex = 11;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.cbAlign);
            this.panel9.Location = new System.Drawing.Point(3, 217);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(241, 27);
            this.panel9.TabIndex = 11;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.Controls.Add(this.chkBoxPhone);
            this.panel10.Location = new System.Drawing.Point(3, 250);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(241, 27);
            this.panel10.TabIndex = 12;
            // 
            // canvasButtons
            // 
            this.canvasButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.canvasButtons.Controls.Add(this.btnAddImage);
            this.canvasButtons.Controls.Add(this.btnRemoveImage);
            this.canvasButtons.Location = new System.Drawing.Point(365, 3);
            this.canvasButtons.Name = "canvasButtons";
            this.canvasButtons.Size = new System.Drawing.Size(156, 29);
            this.canvasButtons.TabIndex = 27;
            // 
            // tLogs
            // 
            this.tLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tLogs.BackColor = System.Drawing.Color.White;
            this.tLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tLogs.Location = new System.Drawing.Point(5, 395);
            this.tLogs.Name = "tLogs";
            this.tLogs.ReadOnly = true;
            this.tLogs.Size = new System.Drawing.Size(518, 165);
            this.tLogs.TabIndex = 1;
            this.tLogs.Text = "";
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Controls.Add(this.canvasButtons);
            this.panel12.Controls.Add(this.tLogs);
            this.panel12.Controls.Add(this.tabControl);
            this.panel12.Location = new System.Drawing.Point(1, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(526, 561);
            this.panel12.TabIndex = 29;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 566);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panelTool);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSS 精灵图生成工具";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabCanvas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panelTool.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.canvasButtons.ResumeLayout(false);
            this.canvasButtons.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelImages;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtSass;
        private System.Windows.Forms.TextBox txtCss;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.CheckBox chkBoxPhone;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtBase64Sass;
        private System.Windows.Forms.TextBox txtBase64Css;
        private System.Windows.Forms.TextBox tbSrc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdOrderByName;
        private System.Windows.Forms.RadioButton rdOrderBySize;
        private System.Windows.Forms.RadioButton rdVertical;
        private System.Windows.Forms.RadioButton rdHorizon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbAlign;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxImgType;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.FlowLayoutPanel recentList;
        private System.Windows.Forms.Panel canvasButtons;
        private System.Windows.Forms.TabPage tabCanvas;
        private System.Windows.Forms.RichTextBox tLogs;
        private System.Windows.Forms.Panel panel12;
    }
}

