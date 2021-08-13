
namespace WordPad
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Font = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_FontSize = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_FontStyle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_Alignment = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_Color = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbx_FontSize = new System.Windows.Forms.ComboBox();
            this.cbx_Fonts = new System.Windows.Forms.ComboBox();
            this.bunifuColorTransition1 = new Bunifu.UI.WinForms.BunifuColorTransition(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btn_BackColor = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_ForeColor = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_R = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_C = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_L = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.icbx_Italic = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.icbx_Underline = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.icbx_Bold = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.tsm_New = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыСтраницыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправитьПоЭлектроннойПочтеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Menu,
            this.главнаяToolStripMenuItem,
            this.видToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsm_Menu
            // 
            this.tsm_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_New,
            this.tsm_Open,
            this.tsm_Save,
            this.tsm_SaveAs,
            this.tsm_Print,
            this.параметрыСтраницыToolStripMenuItem,
            this.отправитьПоЭлектроннойПочтеToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.tsm_Exit});
            this.tsm_Menu.Name = "tsm_Menu";
            this.tsm_Menu.Size = new System.Drawing.Size(48, 20);
            this.tsm_Menu.Text = "Файл";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.главнаяToolStripMenuItem.Text = "Главная";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // lbl_Font
            // 
            this.lbl_Font.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Font.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Font.Location = new System.Drawing.Point(106, 27);
            this.lbl_Font.Name = "lbl_Font";
            this.lbl_Font.Size = new System.Drawing.Size(38, 21);
            this.lbl_Font.TabIndex = 2;
            this.lbl_Font.Text = "Font";
            // 
            // lbl_FontSize
            // 
            this.lbl_FontSize.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FontSize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_FontSize.Location = new System.Drawing.Point(229, 27);
            this.lbl_FontSize.Name = "lbl_FontSize";
            this.lbl_FontSize.Size = new System.Drawing.Size(36, 21);
            this.lbl_FontSize.TabIndex = 3;
            this.lbl_FontSize.Text = "Size";
            // 
            // lbl_FontStyle
            // 
            this.lbl_FontStyle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FontStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_FontStyle.Location = new System.Drawing.Point(330, 27);
            this.lbl_FontStyle.Name = "lbl_FontStyle";
            this.lbl_FontStyle.Size = new System.Drawing.Size(76, 21);
            this.lbl_FontStyle.TabIndex = 4;
            this.lbl_FontStyle.Text = "FontStyle";
            // 
            // lbl_Alignment
            // 
            this.lbl_Alignment.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Alignment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Alignment.Location = new System.Drawing.Point(486, 27);
            this.lbl_Alignment.Name = "lbl_Alignment";
            this.lbl_Alignment.Size = new System.Drawing.Size(80, 21);
            this.lbl_Alignment.TabIndex = 5;
            this.lbl_Alignment.Text = "Alignment";
            // 
            // lbl_Color
            // 
            this.lbl_Color.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Color.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Color.Location = new System.Drawing.Point(638, 31);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(45, 21);
            this.lbl_Color.TabIndex = 6;
            this.lbl_Color.Text = "Color";
            // 
            // cbx_FontSize
            // 
            this.cbx_FontSize.FormattingEnabled = true;
            this.cbx_FontSize.Location = new System.Drawing.Point(220, 52);
            this.cbx_FontSize.Name = "cbx_FontSize";
            this.cbx_FontSize.Size = new System.Drawing.Size(54, 21);
            this.cbx_FontSize.TabIndex = 10;
            this.cbx_FontSize.SelectedIndexChanged += new System.EventHandler(this.FontAndFontSize);
            // 
            // cbx_Fonts
            // 
            this.cbx_Fonts.FormattingEnabled = true;
            this.cbx_Fonts.Location = new System.Drawing.Point(43, 52);
            this.cbx_Fonts.Name = "cbx_Fonts";
            this.cbx_Fonts.Size = new System.Drawing.Size(171, 21);
            this.cbx_Fonts.TabIndex = 11;
            this.cbx_Fonts.SelectedIndexChanged += new System.EventHandler(this.FontAndFontSize);
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.AutoTransition = false;
            this.bunifuColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Purple,
        System.Drawing.Color.LightBlue,
        System.Drawing.Color.Orange};
            this.bunifuColorTransition1.EndColor = System.Drawing.Color.White;
            this.bunifuColorTransition1.Interval = 10;
            this.bunifuColorTransition1.ProgessValue = 0;
            this.bunifuColorTransition1.StartColor = System.Drawing.Color.White;
            this.bunifuColorTransition1.TransitionControl = null;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(43, 88);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(996, 561);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = "";
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = false;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.bunifuPictureBox1.Image = global::WordPad.Properties.Resources._2;
            this.bunifuPictureBox1.IsCircle = false;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(699, 29);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(190, 53);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 31;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // btn_BackColor
            // 
            this.btn_BackColor.ActiveImage = null;
            this.btn_BackColor.AllowAnimations = true;
            this.btn_BackColor.AllowBuffering = false;
            this.btn_BackColor.AllowToggling = false;
            this.btn_BackColor.AllowZooming = false;
            this.btn_BackColor.AllowZoomingOnFocus = false;
            this.btn_BackColor.BackColor = System.Drawing.Color.Transparent;
            this.btn_BackColor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_BackColor.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_BackColor.ErrorImage")));
            this.btn_BackColor.FadeWhenInactive = false;
            this.btn_BackColor.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_BackColor.Image = global::WordPad.Properties.Resources.BackColor;
            this.btn_BackColor.ImageActive = null;
            this.btn_BackColor.ImageLocation = null;
            this.btn_BackColor.ImageMargin = 0;
            this.btn_BackColor.ImageSize = new System.Drawing.Size(30, 21);
            this.btn_BackColor.ImageZoomSize = new System.Drawing.Size(30, 21);
            this.btn_BackColor.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_BackColor.InitialImage")));
            this.btn_BackColor.Location = new System.Drawing.Point(665, 55);
            this.btn_BackColor.Name = "btn_BackColor";
            this.btn_BackColor.Rotation = 0;
            this.btn_BackColor.ShowActiveImage = true;
            this.btn_BackColor.ShowCursorChanges = true;
            this.btn_BackColor.ShowImageBorders = false;
            this.btn_BackColor.ShowSizeMarkers = false;
            this.btn_BackColor.Size = new System.Drawing.Size(30, 21);
            this.btn_BackColor.TabIndex = 30;
            this.btn_BackColor.ToolTipText = "BackColor";
            this.btn_BackColor.WaitOnLoad = false;
            this.btn_BackColor.Zoom = 0;
            this.btn_BackColor.ZoomSpeed = 10;
            this.btn_BackColor.Click += new System.EventHandler(this.ColorSelect);
            // 
            // btn_ForeColor
            // 
            this.btn_ForeColor.ActiveImage = null;
            this.btn_ForeColor.AllowAnimations = true;
            this.btn_ForeColor.AllowBuffering = false;
            this.btn_ForeColor.AllowToggling = false;
            this.btn_ForeColor.AllowZooming = false;
            this.btn_ForeColor.AllowZoomingOnFocus = false;
            this.btn_ForeColor.BackColor = System.Drawing.Color.Transparent;
            this.btn_ForeColor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ForeColor.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_ForeColor.ErrorImage")));
            this.btn_ForeColor.FadeWhenInactive = false;
            this.btn_ForeColor.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_ForeColor.Image = global::WordPad.Properties.Resources.ForeColor;
            this.btn_ForeColor.ImageActive = null;
            this.btn_ForeColor.ImageLocation = null;
            this.btn_ForeColor.ImageMargin = 0;
            this.btn_ForeColor.ImageSize = new System.Drawing.Size(30, 21);
            this.btn_ForeColor.ImageZoomSize = new System.Drawing.Size(30, 21);
            this.btn_ForeColor.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_ForeColor.InitialImage")));
            this.btn_ForeColor.Location = new System.Drawing.Point(629, 55);
            this.btn_ForeColor.Name = "btn_ForeColor";
            this.btn_ForeColor.Rotation = 0;
            this.btn_ForeColor.ShowActiveImage = true;
            this.btn_ForeColor.ShowCursorChanges = true;
            this.btn_ForeColor.ShowImageBorders = false;
            this.btn_ForeColor.ShowSizeMarkers = false;
            this.btn_ForeColor.Size = new System.Drawing.Size(30, 21);
            this.btn_ForeColor.TabIndex = 29;
            this.btn_ForeColor.ToolTipText = "ForeColor";
            this.btn_ForeColor.WaitOnLoad = false;
            this.btn_ForeColor.Zoom = 0;
            this.btn_ForeColor.ZoomSpeed = 10;
            this.btn_ForeColor.Click += new System.EventHandler(this.ColorSelect);
            // 
            // btn_R
            // 
            this.btn_R.AllowAnimations = true;
            this.btn_R.AllowMouseEffects = true;
            this.btn_R.AllowToggling = true;
            this.btn_R.AnimationSpeed = 200;
            this.btn_R.AutoGenerateColors = false;
            this.btn_R.AutoRoundBorders = false;
            this.btn_R.AutoSizeLeftIcon = true;
            this.btn_R.AutoSizeRightIcon = true;
            this.btn_R.BackColor = System.Drawing.Color.Transparent;
            this.btn_R.BackColor1 = System.Drawing.Color.Silver;
            this.btn_R.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_R.BackgroundImage")));
            this.btn_R.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_R.ButtonText = "R";
            this.btn_R.ButtonTextMarginLeft = 0;
            this.btn_R.ColorContrastOnClick = 45;
            this.btn_R.ColorContrastOnHover = 45;
            this.btn_R.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btn_R.CustomizableEdges = borderEdges7;
            this.btn_R.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_R.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_R.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_R.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_R.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_R.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_R.ForeColor = System.Drawing.Color.Black;
            this.btn_R.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_R.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_R.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_R.IconMarginLeft = 11;
            this.btn_R.IconPadding = 10;
            this.btn_R.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_R.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_R.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_R.IconSize = 25;
            this.btn_R.IdleBorderColor = System.Drawing.Color.Silver;
            this.btn_R.IdleBorderRadius = 1;
            this.btn_R.IdleBorderThickness = 1;
            this.btn_R.IdleFillColor = System.Drawing.Color.Silver;
            this.btn_R.IdleIconLeftImage = null;
            this.btn_R.IdleIconRightImage = null;
            this.btn_R.IndicateFocus = true;
            this.btn_R.Location = new System.Drawing.Point(543, 49);
            this.btn_R.Name = "btn_R";
            this.btn_R.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_R.OnDisabledState.BorderRadius = 1;
            this.btn_R.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_R.OnDisabledState.BorderThickness = 1;
            this.btn_R.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_R.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_R.OnDisabledState.IconLeftImage = null;
            this.btn_R.OnDisabledState.IconRightImage = null;
            this.btn_R.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_R.onHoverState.BorderRadius = 1;
            this.btn_R.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_R.onHoverState.BorderThickness = 1;
            this.btn_R.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_R.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_R.onHoverState.IconLeftImage = null;
            this.btn_R.onHoverState.IconRightImage = null;
            this.btn_R.OnIdleState.BorderColor = System.Drawing.Color.Silver;
            this.btn_R.OnIdleState.BorderRadius = 1;
            this.btn_R.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_R.OnIdleState.BorderThickness = 1;
            this.btn_R.OnIdleState.FillColor = System.Drawing.Color.Silver;
            this.btn_R.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn_R.OnIdleState.IconLeftImage = null;
            this.btn_R.OnIdleState.IconRightImage = null;
            this.btn_R.OnPressedState.BorderColor = System.Drawing.Color.DimGray;
            this.btn_R.OnPressedState.BorderRadius = 1;
            this.btn_R.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_R.OnPressedState.BorderThickness = 1;
            this.btn_R.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.btn_R.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_R.OnPressedState.IconLeftImage = null;
            this.btn_R.OnPressedState.IconRightImage = null;
            this.btn_R.Size = new System.Drawing.Size(25, 26);
            this.btn_R.TabIndex = 25;
            this.btn_R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_R.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_R.TextMarginLeft = 0;
            this.btn_R.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_R.UseDefaultRadiusAndThickness = true;
            this.btn_R.Click += new System.EventHandler(this.MoveText);
            // 
            // btn_C
            // 
            this.btn_C.AllowAnimations = true;
            this.btn_C.AllowMouseEffects = true;
            this.btn_C.AllowToggling = true;
            this.btn_C.AnimationSpeed = 200;
            this.btn_C.AutoGenerateColors = false;
            this.btn_C.AutoRoundBorders = false;
            this.btn_C.AutoSizeLeftIcon = true;
            this.btn_C.AutoSizeRightIcon = true;
            this.btn_C.BackColor = System.Drawing.Color.Transparent;
            this.btn_C.BackColor1 = System.Drawing.Color.Silver;
            this.btn_C.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_C.BackgroundImage")));
            this.btn_C.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_C.ButtonText = "C";
            this.btn_C.ButtonTextMarginLeft = 0;
            this.btn_C.ColorContrastOnClick = 45;
            this.btn_C.ColorContrastOnHover = 45;
            this.btn_C.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.btn_C.CustomizableEdges = borderEdges8;
            this.btn_C.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_C.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_C.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_C.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_C.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_C.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_C.ForeColor = System.Drawing.Color.Black;
            this.btn_C.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_C.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_C.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_C.IconMarginLeft = 11;
            this.btn_C.IconPadding = 10;
            this.btn_C.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_C.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_C.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_C.IconSize = 25;
            this.btn_C.IdleBorderColor = System.Drawing.Color.Silver;
            this.btn_C.IdleBorderRadius = 1;
            this.btn_C.IdleBorderThickness = 1;
            this.btn_C.IdleFillColor = System.Drawing.Color.Silver;
            this.btn_C.IdleIconLeftImage = null;
            this.btn_C.IdleIconRightImage = null;
            this.btn_C.IndicateFocus = true;
            this.btn_C.Location = new System.Drawing.Point(512, 49);
            this.btn_C.Name = "btn_C";
            this.btn_C.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_C.OnDisabledState.BorderRadius = 1;
            this.btn_C.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_C.OnDisabledState.BorderThickness = 1;
            this.btn_C.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_C.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_C.OnDisabledState.IconLeftImage = null;
            this.btn_C.OnDisabledState.IconRightImage = null;
            this.btn_C.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_C.onHoverState.BorderRadius = 1;
            this.btn_C.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_C.onHoverState.BorderThickness = 1;
            this.btn_C.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_C.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_C.onHoverState.IconLeftImage = null;
            this.btn_C.onHoverState.IconRightImage = null;
            this.btn_C.OnIdleState.BorderColor = System.Drawing.Color.Silver;
            this.btn_C.OnIdleState.BorderRadius = 1;
            this.btn_C.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_C.OnIdleState.BorderThickness = 1;
            this.btn_C.OnIdleState.FillColor = System.Drawing.Color.Silver;
            this.btn_C.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn_C.OnIdleState.IconLeftImage = null;
            this.btn_C.OnIdleState.IconRightImage = null;
            this.btn_C.OnPressedState.BorderColor = System.Drawing.Color.DimGray;
            this.btn_C.OnPressedState.BorderRadius = 1;
            this.btn_C.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_C.OnPressedState.BorderThickness = 1;
            this.btn_C.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.btn_C.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_C.OnPressedState.IconLeftImage = null;
            this.btn_C.OnPressedState.IconRightImage = null;
            this.btn_C.Size = new System.Drawing.Size(25, 26);
            this.btn_C.TabIndex = 24;
            this.btn_C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_C.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_C.TextMarginLeft = 0;
            this.btn_C.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_C.UseDefaultRadiusAndThickness = true;
            this.btn_C.Click += new System.EventHandler(this.MoveText);
            // 
            // btn_L
            // 
            this.btn_L.AllowAnimations = true;
            this.btn_L.AllowMouseEffects = true;
            this.btn_L.AllowToggling = true;
            this.btn_L.AnimationSpeed = 200;
            this.btn_L.AutoGenerateColors = false;
            this.btn_L.AutoRoundBorders = false;
            this.btn_L.AutoSizeLeftIcon = true;
            this.btn_L.AutoSizeRightIcon = true;
            this.btn_L.BackColor = System.Drawing.Color.Transparent;
            this.btn_L.BackColor1 = System.Drawing.Color.Silver;
            this.btn_L.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_L.BackgroundImage")));
            this.btn_L.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_L.ButtonText = "L";
            this.btn_L.ButtonTextMarginLeft = 0;
            this.btn_L.ColorContrastOnClick = 45;
            this.btn_L.ColorContrastOnHover = 45;
            this.btn_L.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.btn_L.CustomizableEdges = borderEdges9;
            this.btn_L.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_L.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_L.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_L.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_L.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_L.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_L.ForeColor = System.Drawing.Color.Black;
            this.btn_L.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_L.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_L.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_L.IconMarginLeft = 11;
            this.btn_L.IconPadding = 10;
            this.btn_L.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_L.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_L.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_L.IconSize = 25;
            this.btn_L.IdleBorderColor = System.Drawing.Color.Silver;
            this.btn_L.IdleBorderRadius = 1;
            this.btn_L.IdleBorderThickness = 1;
            this.btn_L.IdleFillColor = System.Drawing.Color.Silver;
            this.btn_L.IdleIconLeftImage = null;
            this.btn_L.IdleIconRightImage = null;
            this.btn_L.IndicateFocus = true;
            this.btn_L.Location = new System.Drawing.Point(481, 49);
            this.btn_L.Name = "btn_L";
            this.btn_L.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_L.OnDisabledState.BorderRadius = 1;
            this.btn_L.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_L.OnDisabledState.BorderThickness = 1;
            this.btn_L.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_L.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_L.OnDisabledState.IconLeftImage = null;
            this.btn_L.OnDisabledState.IconRightImage = null;
            this.btn_L.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_L.onHoverState.BorderRadius = 1;
            this.btn_L.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_L.onHoverState.BorderThickness = 1;
            this.btn_L.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_L.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_L.onHoverState.IconLeftImage = null;
            this.btn_L.onHoverState.IconRightImage = null;
            this.btn_L.OnIdleState.BorderColor = System.Drawing.Color.Silver;
            this.btn_L.OnIdleState.BorderRadius = 1;
            this.btn_L.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_L.OnIdleState.BorderThickness = 1;
            this.btn_L.OnIdleState.FillColor = System.Drawing.Color.Silver;
            this.btn_L.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn_L.OnIdleState.IconLeftImage = null;
            this.btn_L.OnIdleState.IconRightImage = null;
            this.btn_L.OnPressedState.BorderColor = System.Drawing.Color.DimGray;
            this.btn_L.OnPressedState.BorderRadius = 1;
            this.btn_L.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_L.OnPressedState.BorderThickness = 1;
            this.btn_L.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.btn_L.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_L.OnPressedState.IconLeftImage = null;
            this.btn_L.OnPressedState.IconRightImage = null;
            this.btn_L.Size = new System.Drawing.Size(25, 26);
            this.btn_L.TabIndex = 23;
            this.btn_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_L.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_L.TextMarginLeft = 0;
            this.btn_L.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_L.UseDefaultRadiusAndThickness = true;
            this.btn_L.Click += new System.EventHandler(this.MoveText);
            // 
            // icbx_Italic
            // 
            this.icbx_Italic.BackColor = System.Drawing.Color.Silver;
            this.icbx_Italic.CheckedState.Image = global::WordPad.Properties.Resources.White_Italic;
            this.icbx_Italic.CheckedState.ImageSize = new System.Drawing.Size(15, 15);
            this.icbx_Italic.CheckedState.Parent = this.icbx_Italic;
            this.icbx_Italic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icbx_Italic.HoverState.Parent = this.icbx_Italic;
            this.icbx_Italic.Image = global::WordPad.Properties.Resources.Black_Italic;
            this.icbx_Italic.ImageOffset = new System.Drawing.Point(0, 0);
            this.icbx_Italic.ImageRotate = 0F;
            this.icbx_Italic.ImageSize = new System.Drawing.Size(15, 15);
            this.icbx_Italic.IndicateFocus = true;
            this.icbx_Italic.Location = new System.Drawing.Point(386, 49);
            this.icbx_Italic.Name = "icbx_Italic";
            this.icbx_Italic.PressedState.Parent = this.icbx_Italic;
            this.icbx_Italic.ShadowDecoration.Parent = this.icbx_Italic;
            this.icbx_Italic.Size = new System.Drawing.Size(25, 26);
            this.icbx_Italic.TabIndex = 22;
            this.icbx_Italic.Click += new System.EventHandler(this.FontStyle);
            // 
            // icbx_Underline
            // 
            this.icbx_Underline.BackColor = System.Drawing.Color.Silver;
            this.icbx_Underline.CheckedState.Image = global::WordPad.Properties.Resources.White_Undirline;
            this.icbx_Underline.CheckedState.ImageSize = new System.Drawing.Size(15, 15);
            this.icbx_Underline.CheckedState.Parent = this.icbx_Underline;
            this.icbx_Underline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icbx_Underline.HoverState.Parent = this.icbx_Underline;
            this.icbx_Underline.Image = global::WordPad.Properties.Resources.Black_Undirline;
            this.icbx_Underline.ImageOffset = new System.Drawing.Point(0, 0);
            this.icbx_Underline.ImageRotate = 0F;
            this.icbx_Underline.ImageSize = new System.Drawing.Size(15, 15);
            this.icbx_Underline.IndicateFocus = true;
            this.icbx_Underline.Location = new System.Drawing.Point(356, 49);
            this.icbx_Underline.Name = "icbx_Underline";
            this.icbx_Underline.PressedState.Parent = this.icbx_Underline;
            this.icbx_Underline.ShadowDecoration.Parent = this.icbx_Underline;
            this.icbx_Underline.Size = new System.Drawing.Size(25, 26);
            this.icbx_Underline.TabIndex = 21;
            this.icbx_Underline.Click += new System.EventHandler(this.FontStyle);
            // 
            // icbx_Bold
            // 
            this.icbx_Bold.BackColor = System.Drawing.Color.Silver;
            this.icbx_Bold.CheckedState.Image = global::WordPad.Properties.Resources.White_Bold;
            this.icbx_Bold.CheckedState.ImageSize = new System.Drawing.Size(15, 15);
            this.icbx_Bold.CheckedState.Parent = this.icbx_Bold;
            this.icbx_Bold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icbx_Bold.HoverState.Parent = this.icbx_Bold;
            this.icbx_Bold.Image = global::WordPad.Properties.Resources.Black_Bold;
            this.icbx_Bold.ImageOffset = new System.Drawing.Point(0, 0);
            this.icbx_Bold.ImageRotate = 0F;
            this.icbx_Bold.ImageSize = new System.Drawing.Size(15, 15);
            this.icbx_Bold.IndicateFocus = true;
            this.icbx_Bold.Location = new System.Drawing.Point(325, 49);
            this.icbx_Bold.Name = "icbx_Bold";
            this.icbx_Bold.PressedState.Parent = this.icbx_Bold;
            this.icbx_Bold.ShadowDecoration.Parent = this.icbx_Bold;
            this.icbx_Bold.Size = new System.Drawing.Size(25, 26);
            this.icbx_Bold.TabIndex = 20;
            this.icbx_Bold.Click += new System.EventHandler(this.FontStyle);
            // 
            // tsm_New
            // 
            this.tsm_New.Image = global::WordPad.Properties.Resources.icons8_document_48;
            this.tsm_New.Name = "tsm_New";
            this.tsm_New.Size = new System.Drawing.Size(180, 22);
            this.tsm_New.Text = "New";
            this.tsm_New.Click += new System.EventHandler(this.tsm_New_Click);
            // 
            // tsm_Open
            // 
            this.tsm_Open.Image = global::WordPad.Properties.Resources.icons8_folder_48;
            this.tsm_Open.Name = "tsm_Open";
            this.tsm_Open.Size = new System.Drawing.Size(180, 22);
            this.tsm_Open.Text = "Open";
            this.tsm_Open.Click += new System.EventHandler(this.tsm_Open_Click);
            // 
            // tsm_Save
            // 
            this.tsm_Save.Image = global::WordPad.Properties.Resources.icons8_save_48;
            this.tsm_Save.Name = "tsm_Save";
            this.tsm_Save.Size = new System.Drawing.Size(180, 22);
            this.tsm_Save.Text = "Save";
            this.tsm_Save.Click += new System.EventHandler(this.tsm_Save_Click);
            // 
            // tsm_SaveAs
            // 
            this.tsm_SaveAs.Image = global::WordPad.Properties.Resources.icons8_save_as_48;
            this.tsm_SaveAs.Name = "tsm_SaveAs";
            this.tsm_SaveAs.Size = new System.Drawing.Size(180, 22);
            this.tsm_SaveAs.Text = "Save as";
            this.tsm_SaveAs.Click += new System.EventHandler(this.tsm_SaveAs_Click);
            // 
            // tsm_Print
            // 
            this.tsm_Print.Image = global::WordPad.Properties.Resources.icons8_print_48;
            this.tsm_Print.Name = "tsm_Print";
            this.tsm_Print.Size = new System.Drawing.Size(180, 22);
            this.tsm_Print.Text = "Print";
            this.tsm_Print.Click += new System.EventHandler(this.tsm_Print_Click);
            // 
            // параметрыСтраницыToolStripMenuItem
            // 
            this.параметрыСтраницыToolStripMenuItem.Image = global::WordPad.Properties.Resources.icons8_gear_48;
            this.параметрыСтраницыToolStripMenuItem.Name = "параметрыСтраницыToolStripMenuItem";
            this.параметрыСтраницыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.параметрыСтраницыToolStripMenuItem.Text = "Page settings";
            // 
            // отправитьПоЭлектроннойПочтеToolStripMenuItem
            // 
            this.отправитьПоЭлектроннойПочтеToolStripMenuItem.Image = global::WordPad.Properties.Resources.icons8_email_open_40;
            this.отправитьПоЭлектроннойПочтеToolStripMenuItem.Name = "отправитьПоЭлектроннойПочтеToolStripMenuItem";
            this.отправитьПоЭлектроннойПочтеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отправитьПоЭлектроннойПочтеToolStripMenuItem.Text = "Send to Email";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::WordPad.Properties.Resources.icons8_info_48;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "About the program";
            // 
            // tsm_Exit
            // 
            this.tsm_Exit.Image = global::WordPad.Properties.Resources.icons8_exit_48;
            this.tsm_Exit.Name = "tsm_Exit";
            this.tsm_Exit.Size = new System.Drawing.Size(180, 22);
            this.tsm_Exit.Text = "Exit";
            this.tsm_Exit.Click += new System.EventHandler(this.tsm_Exit_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 816);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.btn_BackColor);
            this.Controls.Add(this.btn_ForeColor);
            this.Controls.Add(this.btn_R);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_L);
            this.Controls.Add(this.icbx_Italic);
            this.Controls.Add(this.icbx_Underline);
            this.Controls.Add(this.icbx_Bold);
            this.Controls.Add(this.cbx_Fonts);
            this.Controls.Add(this.cbx_FontSize);
            this.Controls.Add(this.lbl_Color);
            this.Controls.Add(this.lbl_Alignment);
            this.Controls.Add(this.lbl_FontStyle);
            this.Controls.Add(this.lbl_FontSize);
            this.Controls.Add(this.lbl_Font);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1100, 855);
            this.MinimumSize = new System.Drawing.Size(1100, 855);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_Menu;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_New;
        private System.Windows.Forms.ToolStripMenuItem tsm_Open;
        private System.Windows.Forms.ToolStripMenuItem tsm_Save;
        private System.Windows.Forms.ToolStripMenuItem tsm_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsm_Print;
        private System.Windows.Forms.ToolStripMenuItem параметрыСтраницыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отправитьПоЭлектроннойПочтеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_Exit;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Font;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_FontSize;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_FontStyle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Alignment;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Color;
        private System.Windows.Forms.ComboBox cbx_FontSize;
        private System.Windows.Forms.ComboBox cbx_Fonts;
        private Guna.UI2.WinForms.Guna2ImageCheckBox icbx_Bold;
        private Guna.UI2.WinForms.Guna2ImageCheckBox icbx_Underline;
        private Guna.UI2.WinForms.Guna2ImageCheckBox icbx_Italic;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_L;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_C;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_R;
        private Bunifu.UI.WinForms.BunifuColorTransition bunifuColorTransition1;
        private Bunifu.UI.WinForms.BunifuImageButton btn_ForeColor;
        private Bunifu.UI.WinForms.BunifuImageButton btn_BackColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

