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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxImgType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCss = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.chkBoxPhone = new System.Windows.Forms.CheckBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSprite = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonVRange = new System.Windows.Forms.Button();
            this.buttonHRange = new System.Windows.Forms.Button();
            this.buttonMakeBigImageCss = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelPhone = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabelLess = new System.Windows.Forms.LinkLabel();
            this.linkLabelSass = new System.Windows.Forms.LinkLabel();
            this.linkLabelHelp = new System.Windows.Forms.LinkLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtBase64Sass = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtBase64Css = new System.Windows.Forms.TextBox();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelImages = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSrc = new System.Windows.Forms.TextBox();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelPhone.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Png文件|*.png|Jpeg文件|*.jpeg|Jpg文件|*.jpg";
            this.openFileDialog.Multiselect = true;
            // 
            // comboBoxImgType
            // 
            this.comboBoxImgType.BackColor = System.Drawing.Color.White;
            this.comboBoxImgType.ForeColor = System.Drawing.Color.RoyalBlue;
            this.comboBoxImgType.Items.AddRange(new object[] {
            "PNG",
            "JPG",
            "JPEG"});
            this.comboBoxImgType.Location = new System.Drawing.Point(130, 99);
            this.comboBoxImgType.Name = "comboBoxImgType";
            this.comboBoxImgType.Size = new System.Drawing.Size(121, 20);
            this.comboBoxImgType.TabIndex = 7;
            this.comboBoxImgType.Text = "PNG";
            this.comboBoxImgType.SelectedIndexChanged += new System.EventHandler(this.comboBoxImgType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "雪碧图文件类型：";
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
            this.txtSass.Size = new System.Drawing.Size(790, 186);
            this.txtSass.TabIndex = 11;
            this.txtSass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSass_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "生成文件名：";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtName.Location = new System.Drawing.Point(130, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(680, 21);
            this.txtName.TabIndex = 16;
            this.txtName.Text = "sprite-icon";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
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
            this.txtCss.Size = new System.Drawing.Size(790, 101);
            this.txtCss.TabIndex = 19;
            this.txtCss.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCss_KeyDown);
            // 
            // chkBoxPhone
            // 
            this.chkBoxPhone.AutoSize = true;
            this.chkBoxPhone.Location = new System.Drawing.Point(283, 101);
            this.chkBoxPhone.Name = "chkBoxPhone";
            this.chkBoxPhone.Size = new System.Drawing.Size(96, 16);
            this.chkBoxPhone.TabIndex = 20;
            this.chkBoxPhone.Text = "是否是手机端";
            this.chkBoxPhone.UseVisualStyleBackColor = true;
            this.chkBoxPhone.CheckedChanged += new System.EventHandler(this.chkBoxPhone_CheckedChanged);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnDelete);
            this.panelTop.Controls.Add(this.btnAdd);
            this.panelTop.Controls.Add(this.btnSprite);
            this.panelTop.Controls.Add(this.buttonBrowse);
            this.panelTop.Controls.Add(this.buttonVRange);
            this.panelTop.Controls.Add(this.buttonHRange);
            this.panelTop.Controls.Add(this.buttonMakeBigImageCss);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.panelTop.Size = new System.Drawing.Size(817, 54);
            this.panelTop.TabIndex = 21;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::CssSprite.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(329, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::CssSprite.Properties.Resources.add2;
            this.btnAdd.Location = new System.Drawing.Point(283, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSprite
            // 
            this.btnSprite.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSprite.FlatAppearance.BorderSize = 0;
            this.btnSprite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSprite.ForeColor = System.Drawing.Color.White;
            this.btnSprite.Image = global::CssSprite.Properties.Resources.open;
            this.btnSprite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSprite.Location = new System.Drawing.Point(142, 9);
            this.btnSprite.Name = "btnSprite";
            this.btnSprite.Size = new System.Drawing.Size(135, 40);
            this.btnSprite.TabIndex = 22;
            this.btnSprite.Text = "打开.sprite";
            this.btnSprite.UseVisualStyleBackColor = false;
            this.btnSprite.Click += new System.EventHandler(this.btnSprite_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonBrowse.FlatAppearance.BorderSize = 0;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.ForeColor = System.Drawing.Color.White;
            this.buttonBrowse.Image = global::CssSprite.Properties.Resources.open;
            this.buttonBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBrowse.Location = new System.Drawing.Point(0, 9);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(135, 40);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "选择多幅图片";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonVRange
            // 
            this.buttonVRange.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonVRange.FlatAppearance.BorderSize = 0;
            this.buttonVRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVRange.ForeColor = System.Drawing.Color.White;
            this.buttonVRange.Image = global::CssSprite.Properties.Resources.vertical;
            this.buttonVRange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVRange.Location = new System.Drawing.Point(406, 9);
            this.buttonVRange.Name = "buttonVRange";
            this.buttonVRange.Size = new System.Drawing.Size(134, 40);
            this.buttonVRange.TabIndex = 4;
            this.buttonVRange.Text = "小图竖排";
            this.buttonVRange.UseVisualStyleBackColor = false;
            this.buttonVRange.Click += new System.EventHandler(this.ButtonVRange_Click);
            // 
            // buttonHRange
            // 
            this.buttonHRange.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHRange.FlatAppearance.BorderSize = 0;
            this.buttonHRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHRange.ForeColor = System.Drawing.Color.White;
            this.buttonHRange.Image = global::CssSprite.Properties.Resources.horizontal;
            this.buttonHRange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHRange.Location = new System.Drawing.Point(546, 9);
            this.buttonHRange.Name = "buttonHRange";
            this.buttonHRange.Size = new System.Drawing.Size(115, 40);
            this.buttonHRange.TabIndex = 5;
            this.buttonHRange.Text = "小图横排";
            this.buttonHRange.UseVisualStyleBackColor = false;
            this.buttonHRange.Click += new System.EventHandler(this.buttonHRange_Click);
            // 
            // buttonMakeBigImageCss
            // 
            this.buttonMakeBigImageCss.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonMakeBigImageCss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMakeBigImageCss.ForeColor = System.Drawing.Color.White;
            this.buttonMakeBigImageCss.Image = global::CssSprite.Properties.Resources.download;
            this.buttonMakeBigImageCss.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMakeBigImageCss.Location = new System.Drawing.Point(667, 9);
            this.buttonMakeBigImageCss.Name = "buttonMakeBigImageCss";
            this.buttonMakeBigImageCss.Size = new System.Drawing.Size(145, 40);
            this.buttonMakeBigImageCss.TabIndex = 9;
            this.buttonMakeBigImageCss.Text = "生成雪碧图";
            this.buttonMakeBigImageCss.UseVisualStyleBackColor = false;
            this.buttonMakeBigImageCss.Click += new System.EventHandler(this.ButtonMakeBigImageCss_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panelPhone);
            this.panelBottom.Controls.Add(this.tabControl);
            this.panelBottom.Controls.Add(this.chkBoxPhone);
            this.panelBottom.Controls.Add(this.label1);
            this.panelBottom.Controls.Add(this.comboBoxImgType);
            this.panelBottom.Controls.Add(this.tbPrefix);
            this.panelBottom.Controls.Add(this.label4);
            this.panelBottom.Controls.Add(this.tbSrc);
            this.panelBottom.Controls.Add(this.txtName);
            this.panelBottom.Controls.Add(this.label2);
            this.panelBottom.Controls.Add(this.label5);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(3, 243);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(817, 346);
            this.panelBottom.TabIndex = 0;
            // 
            // panelPhone
            // 
            this.panelPhone.Controls.Add(this.label3);
            this.panelPhone.Controls.Add(this.linkLabelLess);
            this.panelPhone.Controls.Add(this.linkLabelSass);
            this.panelPhone.Controls.Add(this.linkLabelHelp);
            this.panelPhone.Location = new System.Drawing.Point(403, 97);
            this.panelPhone.Name = "panelPhone";
            this.panelPhone.Size = new System.Drawing.Size(407, 28);
            this.panelPhone.TabIndex = 22;
            this.panelPhone.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "帮助：";
            // 
            // linkLabelLess
            // 
            this.linkLabelLess.AutoSize = true;
            this.linkLabelLess.Location = new System.Drawing.Point(303, 9);
            this.linkLabelLess.Name = "linkLabelLess";
            this.linkLabelLess.Size = new System.Drawing.Size(77, 12);
            this.linkLabelLess.TabIndex = 0;
            this.linkLabelLess.TabStop = true;
            this.linkLabelLess.Text = "Less变量合集";
            this.linkLabelLess.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLess_LinkClicked);
            // 
            // linkLabelSass
            // 
            this.linkLabelSass.AutoSize = true;
            this.linkLabelSass.Location = new System.Drawing.Point(208, 9);
            this.linkLabelSass.Name = "linkLabelSass";
            this.linkLabelSass.Size = new System.Drawing.Size(77, 12);
            this.linkLabelSass.TabIndex = 0;
            this.linkLabelSass.TabStop = true;
            this.linkLabelSass.Text = "Sass变量合集";
            this.linkLabelSass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSass_LinkClicked);
            // 
            // linkLabelHelp
            // 
            this.linkLabelHelp.AutoSize = true;
            this.linkLabelHelp.Location = new System.Drawing.Point(50, 9);
            this.linkLabelHelp.Name = "linkLabelHelp";
            this.linkLabelHelp.Size = new System.Drawing.Size(143, 12);
            this.linkLabelHelp.TabIndex = 0;
            this.linkLabelHelp.TabStop = true;
            this.linkLabelHelp.Text = "手机端页面rem自适应脚本";
            this.linkLabelHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHelp_LinkClicked);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(6, 128);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(804, 218);
            this.tabControl.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSass);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 192);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "sass代码";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCss);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 107);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "css/less代码";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtBase64Sass);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(796, 107);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "sass Base64代码";
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
            this.txtBase64Sass.Size = new System.Drawing.Size(790, 101);
            this.txtBase64Sass.TabIndex = 12;
            this.txtBase64Sass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBase64Sass_KeyDown);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtBase64Css);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(796, 107);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "css Base64代码";
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
            this.txtBase64Css.Size = new System.Drawing.Size(790, 101);
            this.txtBase64Css.TabIndex = 12;
            this.txtBase64Css.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBase64Css_KeyDown);
            // 
            // tbPrefix
            // 
            this.tbPrefix.BackColor = System.Drawing.Color.White;
            this.tbPrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrefix.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbPrefix.Location = new System.Drawing.Point(130, 70);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.Size = new System.Drawing.Size(680, 21);
            this.tbPrefix.TabIndex = 16;
            this.tbPrefix.Text = "sprite-";
            this.tbPrefix.TextChanged += new System.EventHandler(this.TbPrefix_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "类名前缀：";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelBottom, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 352F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(823, 592);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CssSprite.Properties.Resources.QQ截图201504271504082;
            this.panel1.Controls.Add(this.panelImages);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 174);
            this.panel1.TabIndex = 0;
            // 
            // panelImages
            // 
            this.panelImages.AutoScroll = true;
            this.panelImages.BackColor = System.Drawing.Color.Transparent;
            this.panelImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImages.Location = new System.Drawing.Point(0, 0);
            this.panelImages.Name = "panelImages";
            this.panelImages.Size = new System.Drawing.Size(817, 174);
            this.panelImages.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "图片存放目录：";
            // 
            // tbSrc
            // 
            this.tbSrc.BackColor = System.Drawing.Color.White;
            this.tbSrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSrc.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbSrc.Location = new System.Drawing.Point(130, 12);
            this.tbSrc.Name = "tbSrc";
            this.tbSrc.Size = new System.Drawing.Size(680, 21);
            this.tbSrc.TabIndex = 16;
            this.tbSrc.Text = "src";
            this.tbSrc.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 592);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Css背景图合并工具";
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelPhone.ResumeLayout(false);
            this.panelPhone.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelImages;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonMakeBigImageCss;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonHRange;
        private System.Windows.Forms.Button buttonVRange;
        private System.Windows.Forms.ComboBox comboBoxImgType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCss;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.CheckBox chkBoxPhone;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSprite;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtBase64Sass;
        private System.Windows.Forms.TextBox txtBase64Css;
        private System.Windows.Forms.Panel panelPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabelHelp;
        private System.Windows.Forms.LinkLabel linkLabelLess;
        private System.Windows.Forms.LinkLabel linkLabelSass;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSrc;
        private System.Windows.Forms.Label label2;
    }
}

