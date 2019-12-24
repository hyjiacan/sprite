using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Linq;

namespace CssSprite
{
    public partial class FormMain : Form
    {
        private List<ImageInfo> ImgList;
        private string basePath;
        private Option option;
        private Logger logger;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panelImages.MouseWheel += panelImages_MouseWheel;
            panelImages.MouseHover += panelImages_MouseHover;
            panelImages.MouseDown += panelImages_MouseDown;
            panelImages.MouseMove += panelImages_MouseMove;
            panelImages.MouseUp += panelImages_MouseUp;

            panelImages.KeyDown += panelImages_KeyDown;
            panelImages.LostFocus += panelImages_LostFocus;
            comboBoxImgType.DropDownStyle = ComboBoxStyle.DropDownList;

            option = Option.Load();
            logger = new Logger(tLogs);

            option.RecentProjects.ForEach(project =>
            {
                var link = new LinkLabel
                {
                    Text = project,
                    AutoEllipsis = true,
                    AutoSize = false,
                    Width = recentList.Width
                };
                link.LinkClicked += LkRecent_LinkClicked;
                toolTip.SetToolTip(link, project);
                recentList.Controls.Add(link);
            });
        }

        #region 鼠标和键盘支持
        void panelImages_LostFocus(object sender, EventArgs e)
        {
            list = null;
        }

        void panelImages_KeyDown(object sender, KeyEventArgs e)
        {
            if (SelectedPicture != null && (list == null || list.Count == 0))
            {
                Util.MakePictureOffset(SelectedPicture, e.KeyCode);
                SetCssText();
            }

            if (list == null)
            {
                return;
            }
            foreach (PictureBox pb in list)
            {
                Util.MakePictureOffset(pb, e.KeyCode);
            }
            DrawRectangle(list);
        }

        private delegate void EnableButtonCallBack();

        /// <summary>
        /// 鼠标的初始位置
        /// </summary>
        Point MouseDownPosition;
        /// <summary>
        /// 是否在拖动
        /// </summary>
        bool IsDragging = false;
        /// <summary>
        /// 画笔
        /// </summary>
        Graphics graphics;
        /// <summary>
        /// 颜色笔
        /// </summary>
        Pen pen;
        /// <summary>
        /// 区域
        /// </summary>
        Area area;
        /// <summary>
        /// 零时装载选中图片列表
        /// </summary>
        List<PictureBox> list;
        void panelImages_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                IsDragging = false;
                return;
            }
            list = null;
            pen = new Pen(Color.Blue);
            graphics = panelImages.CreateGraphics();
            MouseDownPosition = new Point(e.X, e.Y);
            area = new Area();
            IsDragging = true;
        }

        void panelImages_MouseMove(object sender, MouseEventArgs e)
        {
            if (!IsDragging || list != null)
            {
                return;
            }
            panelImages.Refresh();
            if (e.X > MouseDownPosition.X && e.Y > MouseDownPosition.Y)
            {
                area.ZeroPoint = new Point(MouseDownPosition.X, MouseDownPosition.Y);
                area.Height = e.Y - MouseDownPosition.Y;
                area.Width = e.X - MouseDownPosition.X;
            }
            else if (e.X < MouseDownPosition.X && e.Y < MouseDownPosition.Y)
            {
                area.ZeroPoint = new Point(e.X, e.Y);
                area.Height = MouseDownPosition.Y - e.Y;
                area.Width = MouseDownPosition.X - e.X;
            }
            else if (e.X < MouseDownPosition.X && e.Y > MouseDownPosition.Y)
            {
                area.ZeroPoint = new Point(e.X, MouseDownPosition.Y);
                area.Width = MouseDownPosition.X - e.X;
                area.Height = e.Y - MouseDownPosition.Y;
            }
            else
            {
                area.ZeroPoint = new Point(MouseDownPosition.X, e.Y);
                area.Width = e.X - MouseDownPosition.X;
                area.Height = MouseDownPosition.Y - e.Y;
            }
            graphics.DrawRectangle(pen, area.ZeroPoint.X, area.ZeroPoint.Y, area.Width, area.Height);
        }

        void panelImages_MouseUp(object sender, MouseEventArgs e)
        {
            if (!IsDragging)
            {
                return;
            }
            IsDragging = false;
            list = panelImages.Controls.Cast<PictureBox>().Where(pb =>
                    pb.Location.X > area.ZeroPoint.X && pb.Location.Y > area.ZeroPoint.Y &&
                    pb.Location.X + pb.Width < area.ZeroPoint.X + area.Width &&
                    pb.Location.Y + pb.Height < area.ZeroPoint.Y + area.Height)
                .Select(pb => pb).ToList();
            DrawRectangle(list);
        }

        void panelImages_MouseHover(object sender, EventArgs e)
        {
            panelImages.Focus();
        }

        void panelImages_MouseWheel(object sender, MouseEventArgs e)
        {
            panelImages.ResumeLayout(false);
            panelImages.Refresh();
        }


        #endregion
        /// <summary>
        /// 重绘矩形边框
        /// </summary>
        /// <param name="lists"></param>
        void DrawRectangle(List<PictureBox> list)
        {
            var size = GetEdgeSize(list);
            panelImages.Refresh();
            graphics.DrawRectangle(pen, size.MinWidth, size.MinHeight, size.MaxWidth - size.MinWidth, size.MaxHeight - size.MinHeight);
        }

        /// <summary>
        ///获取最大最小尺寸
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private EdgeSize GetEdgeSize(List<PictureBox> list)
        {
            var size = new EdgeSize();
            foreach (PictureBox pb in list)
            {
                if (list.IndexOf(pb) == 0)
                {
                    size.MinWidth = pb.Location.X;
                    size.MinHeight = pb.Location.Y;
                }
                size.MinWidth = Math.Min(size.MinWidth, pb.Location.X);
                size.MinHeight = Math.Min(size.MinHeight, pb.Location.Y);
                size.MaxWidth = Math.Max(size.MaxWidth, pb.Location.X + pb.Image.Width);
                size.MaxHeight = Math.Max(size.MaxHeight, pb.Location.Y + pb.Image.Height);
            }
            return size;
        }
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (!OpenFile(false))
            {
                return;
            }
            DialogResult dr = openFileDialog.ShowDialog();
            if (DialogResult.OK == dr && openFileDialog.FileNames.Length > 0)
            {
                if (string.IsNullOrEmpty(basePath))
                {
                    basePath = Path.GetDirectoryName(openFileDialog.FileName);
                }
                LoadImages(openFileDialog.FileNames);
                ButtonVRange_Click(null, EventArgs.Empty);
                SetBase64();
            }
        }

        private void btnSprite_Click(object sender, EventArgs e)
        {
            if (!OpenFile(true))
            {
                return;
            }
            DialogResult dr = openFileDialog.ShowDialog();
            if (DialogResult.OK == dr && openFileDialog.FileNames.Length > 0)
            {
                LoadSprite(openFileDialog.FileName);
            }
        }

        private void LoadSprite(string filename)
        {
            Text = $"项目文件: {filename}";
            basePath = Path.GetDirectoryName(filename);
            saveFileDialog.FileName = filename;
            try
            {
                var spriteFile = SpriteFile.Load(filename);
                if (ImgList == null)
                {
                    ImgList = new List<ImageInfo>();
                }
                else
                {
                    ImgList.Clear();
                }
                var noFile = "这些文件不存在：" + Environment.NewLine;
                var hasFile = false;
                foreach (SpriteImage s in spriteFile.Images)
                {
                    var path = Path.Combine(basePath, spriteFile.SrcPath, s.File);
                    if (File.Exists(path))
                    {
                        Image img = Image.FromStream(new MemoryStream(File.ReadAllBytes(path)));
                        string imgName = Path.GetFileNameWithoutExtension(s.File);
                        ImageInfo imgInfo = new ImageInfo(img, imgName, path);
                        img.Tag = imgInfo;
                        ImgList.Add(imgInfo);
                        AddPictureBox(img, s.X, s.Y, imgInfo.Name);
                    }
                    else
                    {
                        hasFile = true;
                        noFile += path + Environment.NewLine;
                    }
                }
                if (hasFile)
                {
                    logger.Warn(noFile);
                }
                tbPrefix.Text = spriteFile.ClassPrefix;
                txtName.Text = spriteFile.ImageName;
                chkBoxPhone.Checked = spriteFile.IsPhone;
                cbAlign.Checked = spriteFile.AutoAlign;
                rdHorizon.Checked = spriteFile.Align == "horizon";
                rdOrderByName.Checked = spriteFile.OrderBy == "name";
                comboBoxImgType.Text = spriteFile.FileType == null ? "png" : spriteFile.FileType;
                panelImages.ResumeLayout(false);
                SetCssText();
                SetBase64();
                option.AppendProject(filename).Save();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message + Environment.NewLine + "项目文件被损坏，无法打开！");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Png文件|*.png|Jpeg文件|*.jpeg|Jpg文件|*.jpg";
            openFileDialog.Multiselect = false;
            DialogResult dr = openFileDialog.ShowDialog();
            if (DialogResult.OK != dr || openFileDialog.FileNames.Length == 0)
            {
                return;
            }
            if (ImgList == null)
            {
                ImgList = new List<ImageInfo>();
            }
            var fileName = openFileDialog.FileName;

            if (!IsImgExists(fileName))
            {
                Image img = Image.FromStream(new MemoryStream(File.ReadAllBytes(fileName)));
                string imgName = Path.GetFileNameWithoutExtension(fileName);
                ImageInfo imgInfo = new ImageInfo(img, imgName, fileName);
                img.Tag = imgInfo;
                ImgList.Add(imgInfo);
                AddPictureBox(img, 0, 0, imgInfo.Name);
                SetBase64();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedPicture == null)
            {
                logger.Warn("请选中你需要移除的图片！");
                return;
            }
            var dr = MessageBox.Show("确定删除图片：" + ((ImageInfo)SelectedPicture.Image.Tag).Name + " ？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                foreach (ImageInfo info in ImgList)
                {
                    if (info.Image == SelectedPicture.Image)
                    {
                        ImgList.Remove(info);
                        break;
                    }
                }
                panelImages.Controls.Remove(SelectedPicture);
                SelectedPicture = null;
                SetCssText();
                SetBase64();
            }
        }

        /// <summary>
        /// 画布以及对话框初始化
        /// </summary>
        /// <param name="spriteFile"></param>
        private bool OpenFile(bool spriteFile)
        {
            if (spriteFile)
            {
                openFileDialog.Filter = "精灵图文件|*.sprite";
                openFileDialog.Multiselect = false;
            }
            else
            {
                openFileDialog.Filter = "Png文件|*.png|Jpeg文件|*.jpeg|Jpg文件|*.jpg";
                openFileDialog.Multiselect = true;
            }
            return true;
        }

        /// <summary>
        /// 加载图片进画布
        /// </summary>
        /// <param name="imageFileNames"></param>
        private void LoadImages(string[] imageFileNames)
        {
            if (ImgList == null)
            {
                ImgList = new List<ImageInfo>();
            }
            foreach (string fileName in imageFileNames)
            {
                if (IsImgExists(fileName))
                {
                    continue;
                }
                Image img = Image.FromStream(new MemoryStream(File.ReadAllBytes(fileName)));
                string imgName = Path.GetFileNameWithoutExtension(fileName);
                ImageInfo imgInfo = new ImageInfo(img, imgName, fileName);
                img.Tag = imgInfo;
                ImgList.Add(imgInfo);
            }
        }

        /// <summary>
        /// 选中的单张图片
        /// </summary>
        private PictureBox SelectedPicture = null;

        string GetImgExt()
        {
            string ext = comboBoxImgType.Text.ToLower();
            return ext == "png" || ext == "gif" || ext == "jpg" || ext == "jpeg" ? ext : "png";
        }

        /// <summary>
        /// 设置css的文本
        /// </summary>
        public void SetCssText()
        {
            var list = new List<PictureBox>();
            foreach (PictureBox pb in panelImages.Controls)
            {
                list.Add(pb);
            }
            var edgeSize = GetEdgeSize(list);
            var tmpStr = "{0}" + txtName.Text + "[background:url(" + txtName.Text + "." + GetImgExt() + ") no-repeat {1};]" + Environment.NewLine;
            string sassStr;
            string cssStr;
            if (chkBoxPhone.Checked)
            {
                chkBoxPhone_CheckedChanged(null, EventArgs.Empty);
                sassStr = string.Format(tmpStr, "@mixin ", ";background-size:$_" + (edgeSize.MaxWidth - edgeSize.MinWidth) + " $_" + (edgeSize.MaxHeight - edgeSize.MinHeight)).Replace("[", "{").Replace("]", "}");
                cssStr = string.Format(tmpStr, ".", ";background-size:@_" + (edgeSize.MaxWidth - edgeSize.MinWidth) + " $_" + (edgeSize.MaxHeight - edgeSize.MinHeight)).Replace("[", "{").Replace("]", "}");
            }
            else
            {
                sassStr = string.Format(tmpStr, "@mixin ", "").Replace("[", "{").Replace("]", "}");
                cssStr = string.Format(tmpStr, ".", "").Replace("[", "{").Replace("]", "}");
            }

            foreach (PictureBox pb in panelImages.Controls)
            {
                sassStr += Util.GetSassCss(pb.Image, pb.Left - edgeSize.MinWidth, pb.Top - edgeSize.MinHeight, true, chkBoxPhone.Checked, tbPrefix.Text);
                cssStr += Util.GetSassCss(pb.Image, pb.Left - edgeSize.MinWidth, pb.Top - edgeSize.MinHeight, false, chkBoxPhone.Checked, tbPrefix.Text);
            }
            txtSass.Text = sassStr;
            txtCss.Text = cssStr;
        }

        void SetBase64()
        {
            string base64Sass = string.Empty;
            string base64Css = string.Empty;
            ImageInfo imageInfo;
            int height, width;
            var isPhone = chkBoxPhone.Checked;
            var unit = "px";
            var sassPrefix = string.Empty;
            var lessPrefix = string.Empty;
            if (isPhone)
            {
                unit = "rem";
                lessPrefix = "@_";
                sassPrefix = "$_";
            }

            foreach (PictureBox pb in panelImages.Controls)
            {
                Bitmap bmp = new Bitmap(pb.Image, pb.Image.Width, pb.Image.Height);
                imageInfo = (ImageInfo)pb.Image.Tag;
                MemoryStream memStream = new MemoryStream();
                ImageFormat format = ImageFormat.Png;
                switch (Path.GetExtension(imageInfo.FileName))
                {
                    case "jpeg":
                        format = ImageFormat.Jpeg;
                        break;
                    case "jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case "png":
                        format = ImageFormat.Png;
                        break;
                    case "gif":
                        format = ImageFormat.Gif;
                        break;
                    default:
                        break;
                }
                bmp.Save(memStream, format);
                byte[] arr = new byte[memStream.Length];
                memStream.Position = 0;
                memStream.Read(arr, 0, (int)memStream.Length);
                memStream.Close();
                height = pb.Image.Height;
                //height = isPhone ? height / 2 : height;
                width = pb.Image.Width;
                //width = isPhone ? width / 2 : width;
                string _height = height == 0 ? "0" : "{0}" + height.ToString() + unit;
                string _width = width == 0 ? "0" : "{0}" + width.ToString() + unit;
                base64Sass += "@mixin ";
                base64Css += ".";
                var code = Util.GetCssName(imageInfo.Name) + "[height:" + _height + ";width:" + _width + ";background:url(data:image/png;base64," + Convert.ToBase64String(arr) + ") no-repeat]" + Environment.NewLine;
                base64Sass += string.Format(code, sassPrefix).Replace("[", "{").Replace("]", "}");
                base64Css += string.Format(code, lessPrefix).Replace("[", "{").Replace("]", "}");
            }

            txtBase64Sass.Text = base64Sass;
            txtBase64Css.Text = base64Css;
        }

        /// <summary>
        /// 画出图片
        /// </summary>
        /// <param name="img">图片</param>
        /// <param name="left">左边</param>
        /// <param name="top">上边</param>
        private void AddPictureBox(Image img, int left, int top, string name)
        {
            PictureBox pb = new PictureBox();
            pb.Image = img;
            pb.Location = new System.Drawing.Point(left, top);
            pb.Cursor = Cursors.SizeAll;
            pb.BorderStyle = BorderStyle.FixedSingle;
            pb.Name = "pb_" + left + "_" + top;
            pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pb.Click += pb_Click;
            pb.MouseDown += pb_MouseDown;
            pb.MouseMove += pb_MouseMove;
            pb.MouseUp += pb_MouseUp;
            toolTip.SetToolTip(pb, name);
            //pb.Paint += pb_Paint;
            panelImages.Controls.Add(pb);
            pb.Show();
        }

        void pb_Click(object sender, EventArgs e)
        {
            var p = (PictureBox)sender;
            p.Tag = "1";
            p.Refresh();
            panelImages.Focus();
            SelectedPicture = p;
        }

        void pb_Paint(object sender, PaintEventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            if (p.Tag == null || p.Tag.ToString() != "1")
            {
                return;
            }
            Pen pp = new Pen(Color.Blue);
            e.Graphics.DrawRectangle(pp, e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.X + e.ClipRectangle.Width - 1, e.ClipRectangle.Y + e.ClipRectangle.Height - 1);
            foreach (PictureBox pb in panelImages.Controls)
            {
                if (pb != p)
                {
                    pb.Tag = null;
                    pb.Refresh();
                }
            }
        }

        #region 拖动
        bool _isDragged = false;
        Point _dragStartLocation;
        void pb_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragged = false;
        }

        void pb_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragged)
            {
                PictureBox pb = sender as PictureBox;
                Point p = e.Location;
                int x = Math.Max(0, pb.Location.X + p.X - _dragStartLocation.X);
                int y = Math.Max(0, pb.Location.Y + p.Y - _dragStartLocation.Y);
                pb.Location = new Point(x, y);
                SetCssText();
                panelImages.ResumeLayout(false);
                panelImages.Refresh();
            }
        }

        void pb_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                _isDragged = false;
                return;
            }
            _isDragged = true;
            _dragStartLocation = new Point(e.X, e.Y);
        }


        #endregion

        private void ButtonMakeBigImageCss_Click(object sender, EventArgs e)
        {
            panelImages.VerticalScroll.Value = 0;
            panelImages.HorizontalScroll.Value = 0;
            if (ImgList == null || ImgList.Count < 2)
            {
                logger.Warn("请选择多个背景图片。");
                return;
            }

            DialogResult dr = saveFileDialog.ShowDialog();
            if (dr != DialogResult.OK)
            {
                return;
            }
            string imgDir = Path.GetDirectoryName(saveFileDialog.FileName);
            string imgPath = Path.Combine(imgDir, txtName.Text + "." + GetImgExt());
            if (File.Exists(imgPath))
            {
                if (DialogResult.Yes !=
                    MessageBox.Show("选定文件夹中已存在" + txtName.Text + "." + GetImgExt() + "，继续执行将覆盖已存在文件，是否继续？", "询问"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    return;
                }
            }

            int maxWidth, maxHeight, minWidth, minHeight;
            maxWidth = maxHeight = minWidth = minHeight = 0;
            //循环获取距离左边和上边最小距离
            //把所有元素按照0，0点为标准，通过最小向上距离和向左距离平移，获取最大距离
            foreach (PictureBox pb in panelImages.Controls)
            {
                if (panelImages.Controls.GetChildIndex(pb) == 0)
                {
                    minWidth = pb.Location.X;
                    minHeight = pb.Location.Y;
                }
                minWidth = Math.Min(minWidth, pb.Location.X);
                minHeight = Math.Min(minHeight, pb.Location.Y);
                maxWidth = Math.Max(maxWidth, pb.Location.X + pb.Image.Width);
                maxHeight = Math.Max(maxHeight, pb.Location.Y + pb.Image.Height);
            }
            Size imgSize = new Size(maxWidth, maxHeight);
            //var codeMime = string.Empty;
            using (Bitmap bigImg = new Bitmap(imgSize.Width - minWidth, imgSize.Height - minHeight, PixelFormat.Format32bppArgb))
            {
                string imgType = GetImgExt();
                ImageFormat format = ImageFormat.Png;
                switch (imgType)
                {
                    case "jpeg":
                        format = ImageFormat.Jpeg;
                        break;
                    case "jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case "png":
                        format = ImageFormat.Png;
                        break;
                    default:
                        break;
                }
                using (Graphics g = Graphics.FromImage(bigImg))
                {
                    //设置高质量插值法 
                    g.InterpolationMode = InterpolationMode.High;
                    //设置高质量,低速度呈现平滑度 
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    //清空画布并以透明背景色填充 
                    g.CompositingQuality = CompositingQuality.HighQuality;
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                    if ((format == ImageFormat.Jpeg)) g.Clear(Color.White);
                    else g.Clear(Color.Transparent);

                    SetCssText();
                    SetBase64();
                    var sprite = new SpriteFile()
                    {
                        SrcPath = tbSrc.Text,
                        ImageName = txtName.Text,
                        Images = new List<SpriteImage>(),
                        IsPhone = chkBoxPhone.Checked,
                        FileType = comboBoxImgType.Text,
                        ClassPrefix = tbPrefix.Text,
                        AutoAlign = cbAlign.Checked,
                        Align = rdHorizon.Checked ? "horizon" : "vertical",
                        OrderBy = rdOrderByName.Checked ? "name" : "size"
                    };
                    try
                    {
                        var outputPath = Path.Combine(imgDir, tbSrc.Text);
                        if (!Directory.Exists(outputPath))
                        {
                            Directory.CreateDirectory(outputPath);
                        }
                        foreach (PictureBox pb in panelImages.Controls)
                        {
                            var img = (ImageInfo)pb.Image.Tag;
                            var path = img.FileName;
                            SpriteImage s = new SpriteImage()
                            {
                                Y = pb.Location.Y,
                                X = pb.Location.X,
                                File = Path.GetFileName(path)
                            };
                            sprite.Images.Add(s);
                            g.DrawImage(pb.Image, pb.Location.X - minWidth, pb.Location.Y - minHeight, pb.Image.Width, pb.Image.Height);

                            var destFile = Path.Combine(outputPath, Path.GetFileName(path));
                            if (Path.GetDirectoryName(path) != outputPath && path != destFile)
                            {
                                File.Copy(path, destFile, true);
                            }
                        }
                        var file = saveFileDialog.FileName;
                        var content = Json.Encode(sprite);
                        File.WriteAllText(file, content);

                        option.AppendProject(file).Save();
                    }
                    catch (Exception ex)
                    {
                        logger.Error(ex.Message);
                        return;
                    }
                }
                try
                {
                    //保存图片
                    bigImg.Save(imgPath, format);
                    logger.Success("图片生成成功！");
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message + "图片生成失败，被覆盖文件可能被其他程序占用，请换个文件名！");
                }
            }
        }


        public bool IsImgExists(string fileName)
        {
            return ImgList.Any(ii => string.Compare(ii.FileName, fileName, true) == 0);
        }

        private void txtSass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control) { txtSass.SelectAll(); }
        }


        private void txtDir_TextChanged(object sender, EventArgs e)
        {
            SetCssText();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            SetCssText();
        }

        private void TbPrefix_TextChanged(object sender, EventArgs e)
        {
            SetCssText();
        }

        private List<ImageInfo> GetOrderedImageList()
        {
            if (rdOrderByName.Checked)
            {
                return ImgList.OrderBy(img => img.FileName).ToList();
            }

            return ImgList.OrderBy(img => img.Image.Width).ToList();
        }

        private void ResumeLayout(object sender, EventArgs e)
        {
            if (rdHorizon.Checked)
            {
                buttonHRange_Click(null, null);
            }
            else
            {
                ButtonVRange_Click(null, null);
            }
        }

        const int OFFSET = 5;

        //小图横排点击
        private void buttonHRange_Click(object sender, EventArgs e)
        {
            panelImages.Controls.Clear();
            int left = 0;
            int top = 0;
            int prevWidth = 0;
            int prevHeight = 0;
            List<ImageInfo> list = GetOrderedImageList();
            for (int i = 0; i < list.Count; i++)
            {
                ImageInfo ii = list[i];
                Image img = ii.Image;
                if (cbAlign.Checked)
                {
                    if (img.Width != prevWidth)
                    {
                        top = 0;
                    }
                    else
                    {
                        top += prevHeight + OFFSET;
                    }
                }
                AddPictureBox(img, left, top, ii.Name);
                if (!cbAlign.Checked)
                {
                    left += img.Width + OFFSET;
                }
                else if (i < list.Count - 1)
                {
                    prevWidth = img.Width;
                    prevHeight = img.Height;
                    var next = list[i + 1];
                    if (next.Image.Width != prevWidth)
                    {
                        left += img.Width + OFFSET;
                    }
                }
            }

            panelImages.ResumeLayout(false);
            SetCssText();
        }


        //小图竖排点击
        private void ButtonVRange_Click(object sender, EventArgs e)
        {
            panelImages.Controls.Clear();
            int left = 0;
            int top = 0;
            int prevWidth = 0;
            int prevHeight = 0;
            List<ImageInfo> list = GetOrderedImageList();
            for (int i = 0; i < list.Count; i++)
            {
                ImageInfo ii = list[i];
                Image img = ii.Image;
                if (cbAlign.Checked)
                {
                    if (img.Height != prevHeight)
                    {
                        left = 0;
                    }
                    else
                    {
                        left += prevWidth + OFFSET;
                    }
                }
                AddPictureBox(img, left, top, ii.Name);
                if (cbAlign.Checked)
                {
                    if (i < list.Count - 1)
                    {
                        prevWidth = img.Width;
                        prevHeight = img.Height;
                        var next = list[i + 1];
                        if (next.Image.Height != prevHeight)
                        {
                            top += img.Height + OFFSET;
                        }
                    }
                }
                else
                {
                    top += img.Height + OFFSET;
                }
            }
            panelImages.ResumeLayout(false);
            SetCssText();
        }

        List<PictureBox> _list;
        private void chkBoxPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxPhone.Checked)
            {
                _list = new List<PictureBox>();
                foreach (PictureBox pb in panelImages.Controls)
                {
                    _list.Add(pb);
                }
                //按照Y轴排序
                for (int i = 0; i < _list.Count; i++)
                {
                    for (int j = 0; j < _list.Count; j++)
                    {
                        if (_list[i].Location.Y < _list[j].Location.Y)
                        {
                            var temp = _list[i];
                            _list[i] = _list[j];
                            _list[j] = temp;
                        }
                    }
                }
                var left = 0;
                var preY = 0;
                var edgeSize = GetEdgeSize(_list);
                for (var i = 0; i < _list.Count; i++)
                {
                    var item = _list[i];
                    var preItem = i > 0 ? _list[i - 1] : null;
                    if (edgeSize.MinHeight != item.Location.Y)
                    {
                        if (preY == 0)
                        {
                            preY = preItem.Location.Y;
                        }
                        if (preY + preItem.Height - item.Location.Y == 2)
                        {
                            preY = item.Location.Y;
                            var _left = item.Location.Y + left;
                            item.Location = new Point(item.Location.X, _left);
                        }
                    }
                    left++;
                }
                //按照X排序
                for (int i = 0; i < _list.Count; i++)
                {
                    for (int j = 0; j < _list.Count; j++)
                    {
                        if (_list[i].Location.X < _list[j].Location.X)
                        {
                            var temp = _list[i];
                            _list[i] = _list[j];
                            _list[j] = temp;
                        }
                    }
                }
                var top = 0;
                var preX = 0;
                for (var i = 0; i < _list.Count; i++)
                {
                    var item = _list[i];
                    var preItem = i > 0 ? _list[i - 1] : null;
                    if (edgeSize.MinWidth != item.Location.X)
                    {
                        if (preX == 0)
                        {
                            preX = preItem.Location.X;
                        }
                        if (preX + preItem.Width - item.Location.X == 2)
                        {
                            preX = item.Location.X;
                            var _top = item.Location.X + top;
                            item.Location = new Point(_top, item.Location.Y);
                        }
                    }
                    top++;
                }
            }
            if (sender != null)
            {
                SetCssText();
                SetBase64();
            }
        }

        private void SetMargin(PictureBox pictureBox)
        {
            var locationPiont = new Point(pictureBox.Location.X, pictureBox.Location.Y);
            foreach (PictureBox pb in _list)
            {
                if (pictureBox.Location.X - (pb.Location.X + pb.Width) == -2 && pictureBox.Location.Y == pb.Location.Y)
                {

                    if (locationPiont.X > 0)
                    {
                        locationPiont.X++;
                    }
                }
                if (pictureBox.Location.Y - (pb.Location.Y + pb.Height) == -2 && pictureBox.Location.X == pb.Location.X)
                {
                    if (locationPiont.Y > 0)
                    {
                        locationPiont.Y++;
                    }
                }
            }
            pictureBox.Location = locationPiont;
        }

        private void txtCss_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control) { txtCss.SelectAll(); }
        }

        private void txtBase64Sass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control) { txtBase64Sass.SelectAll(); }
        }

        private void txtBase64Css_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control) { txtBase64Css.SelectAll(); }
        }

        private void comboBoxImgType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCssText();
        }

        private void LkRecent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            var filename = ((LinkLabel)sender).Text;
            if (string.IsNullOrWhiteSpace((filename)))
            {
                return;
            }
            LoadSprite(filename);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Text = "新建项目";
            ImgList?.Clear();
            panelImages.Controls.Clear();
        }
    }
}