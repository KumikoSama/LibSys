namespace LibrarySystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnBorrow = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btnReturn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.datagridBooks = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnPendingRequests = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.sidebarMenuPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pctrbxLogo = new System.Windows.Forms.PictureBox();
            this.btnMembers = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnTransactions = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAllBooks = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnBookmarks = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnOverdueBooks = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnLogOut = new System.Windows.Forms.PictureBox();
            this.btnBorrowedBooks = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnManage = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.exitbtnapp = new System.Windows.Forms.PictureBox();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.btnAddBookmark = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnRemoveBookmark = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblFormChange = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblTotal = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.btnConfirmPayment = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancelRequest = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.picBxRefresh = new System.Windows.Forms.PictureBox();
            this.kryptonPalette2 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.grpBxPopularBooks = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblBookThree = new System.Windows.Forms.Label();
            this.lblBookTwo = new System.Windows.Forms.Label();
            this.bookCoverThree = new System.Windows.Forms.PictureBox();
            this.bookCoverTwo = new System.Windows.Forms.PictureBox();
            this.bookCoverOne = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBookOne = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnViewBook = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmbbxGenre = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtbxSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarMenuPanel)).BeginInit();
            this.sidebarMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitbtnapp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpBxPopularBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpBxPopularBooks.Panel)).BeginInit();
            this.grpBxPopularBooks.Panel.SuspendLayout();
            this.grpBxPopularBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookCoverThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCoverTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCoverOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbxGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(154, 460);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Palette = this.kryptonPalette1;
            this.btnBorrow.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnBorrow.Size = new System.Drawing.Size(90, 25);
            this.btnBorrow.TabIndex = 0;
            this.btnBorrow.Values.Text = "Borrow Book";
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonStyles.ButtonCommon.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(94)))), ((int)(((byte)(49)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.OverrideDefault.Border.Rounding = 6;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.OverrideFocus.Border.Rounding = 6;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 6;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StatePressed.Border.Rounding = 6;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateTracking.Border.Rounding = 6;
            this.kryptonPalette1.ButtonStyles.ButtonCommon.StateTracking.Border.Width = 1;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 10;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Border.Rounding = 3;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Rounding = 3;
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette1.GridStyles.GridCommon.StateDisabled.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateDisabled.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateDisabled.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateDisabled.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateDisabled.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateDisabled.DataCell.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.kryptonPalette1.GridStyles.GridCommon.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.kryptonPalette1.InputControlStyles.InputControlCustom1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.kryptonPalette1.InputControlStyles.InputControlCustom1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.InputControlStyles.InputControlCustom1.StateCommon.Border.Rounding = 4;
            this.kryptonPalette1.InputControlStyles.InputControlCustom1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.kryptonPalette1.InputControlStyles.InputControlCustom1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette1.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.kryptonPalette1.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette1.LabelStyles.LabelCustom1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette1.LabelStyles.LabelCustom1.StateCommon.ShortText.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette1.PanelStyles.PanelCommon.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(154, 460);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Palette = this.kryptonPalette1;
            this.btnReturn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnReturn.Size = new System.Drawing.Size(90, 25);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Values.Text = "Return Book";
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // datagridBooks
            // 
            this.datagridBooks.AllowUserToAddRows = false;
            this.datagridBooks.AllowUserToDeleteRows = false;
            this.datagridBooks.AllowUserToResizeColumns = false;
            this.datagridBooks.AllowUserToResizeRows = false;
            this.datagridBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridBooks.Location = new System.Drawing.Point(154, 132);
            this.datagridBooks.MultiSelect = false;
            this.datagridBooks.Name = "datagridBooks";
            this.datagridBooks.Palette = this.kryptonPalette1;
            this.datagridBooks.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.datagridBooks.ReadOnly = true;
            this.datagridBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridBooks.Size = new System.Drawing.Size(752, 322);
            this.datagridBooks.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.datagridBooks.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.datagridBooks.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.datagridBooks.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.datagridBooks.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.datagridBooks.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.datagridBooks.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.datagridBooks.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.datagridBooks.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.datagridBooks.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.datagridBooks.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.datagridBooks.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.datagridBooks.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.datagridBooks.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.datagridBooks.TabIndex = 3;
            this.datagridBooks.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.datagridBooks_BooksCount);
            this.datagridBooks.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.datagridBooks_RowsRemoved);
            // 
            // btnPendingRequests
            // 
            this.btnPendingRequests.Location = new System.Drawing.Point(0, 363);
            this.btnPendingRequests.Name = "btnPendingRequests";
            this.btnPendingRequests.Palette = this.kryptonPalette1;
            this.btnPendingRequests.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnPendingRequests.Size = new System.Drawing.Size(88, 42);
            this.btnPendingRequests.StateCommon.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnPendingRequests.TabIndex = 8;
            this.btnPendingRequests.Values.Text = "Pending\r\nRequests";
            this.btnPendingRequests.Click += new System.EventHandler(this.btnPendingRequests_Click);
            // 
            // sidebarMenuPanel
            // 
            this.sidebarMenuPanel.Controls.Add(this.pctrbxLogo);
            this.sidebarMenuPanel.Controls.Add(this.btnMembers);
            this.sidebarMenuPanel.Controls.Add(this.btnTransactions);
            this.sidebarMenuPanel.Controls.Add(this.btnAllBooks);
            this.sidebarMenuPanel.Controls.Add(this.btnBookmarks);
            this.sidebarMenuPanel.Controls.Add(this.btnOverdueBooks);
            this.sidebarMenuPanel.Controls.Add(this.btnLogOut);
            this.sidebarMenuPanel.Controls.Add(this.btnBorrowedBooks);
            this.sidebarMenuPanel.Controls.Add(this.btnPendingRequests);
            this.sidebarMenuPanel.Controls.Add(this.btnManage);
            this.sidebarMenuPanel.Location = new System.Drawing.Point(0, -1);
            this.sidebarMenuPanel.Name = "sidebarMenuPanel";
            this.sidebarMenuPanel.Palette = this.kryptonPalette1;
            this.sidebarMenuPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.sidebarMenuPanel.Size = new System.Drawing.Size(90, 515);
            this.sidebarMenuPanel.TabIndex = 10;
            // 
            // pctrbxLogo
            // 
            this.pctrbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctrbxLogo.Image = global::libSys.Properties.Resources.photo_2024_11_26_10_04_22_removebg_preview1;
            this.pctrbxLogo.Location = new System.Drawing.Point(-18, 0);
            this.pctrbxLogo.Name = "pctrbxLogo";
            this.pctrbxLogo.Size = new System.Drawing.Size(124, 85);
            this.pctrbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbxLogo.TabIndex = 0;
            this.pctrbxLogo.TabStop = false;
            this.pctrbxLogo.Click += new System.EventHandler(this.pctrbxLogo_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Location = new System.Drawing.Point(0, 411);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Palette = this.kryptonPalette1;
            this.btnMembers.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnMembers.Size = new System.Drawing.Size(88, 42);
            this.btnMembers.StateCommon.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnMembers.TabIndex = 15;
            this.btnMembers.Values.Text = "Members";
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Location = new System.Drawing.Point(0, 219);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Palette = this.kryptonPalette1;
            this.btnTransactions.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnTransactions.Size = new System.Drawing.Size(88, 42);
            this.btnTransactions.StateCommon.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnTransactions.TabIndex = 14;
            this.btnTransactions.Values.Text = "Transactions";
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnAllBooks
            // 
            this.btnAllBooks.Location = new System.Drawing.Point(0, 124);
            this.btnAllBooks.Name = "btnAllBooks";
            this.btnAllBooks.Palette = this.kryptonPalette1;
            this.btnAllBooks.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnAllBooks.Size = new System.Drawing.Size(88, 42);
            this.btnAllBooks.StateCommon.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnAllBooks.TabIndex = 13;
            this.btnAllBooks.Values.Text = "All\r\nBooks";
            this.btnAllBooks.Click += new System.EventHandler(this.btnAllBooks_Click);
            // 
            // btnBookmarks
            // 
            this.btnBookmarks.Location = new System.Drawing.Point(0, 315);
            this.btnBookmarks.Name = "btnBookmarks";
            this.btnBookmarks.Palette = this.kryptonPalette1;
            this.btnBookmarks.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnBookmarks.Size = new System.Drawing.Size(88, 42);
            this.btnBookmarks.StateCommon.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnBookmarks.TabIndex = 12;
            this.btnBookmarks.Values.Text = "Bookmarks";
            this.btnBookmarks.Click += new System.EventHandler(this.btnBookmarks_Click);
            // 
            // btnOverdueBooks
            // 
            this.btnOverdueBooks.Location = new System.Drawing.Point(0, 267);
            this.btnOverdueBooks.Name = "btnOverdueBooks";
            this.btnOverdueBooks.Palette = this.kryptonPalette1;
            this.btnOverdueBooks.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnOverdueBooks.Size = new System.Drawing.Size(88, 42);
            this.btnOverdueBooks.StateCommon.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnOverdueBooks.TabIndex = 11;
            this.btnOverdueBooks.Values.Text = "Overdue\r\nBooks";
            this.btnOverdueBooks.Click += new System.EventHandler(this.btnOverdueBooks_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(34, 476);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(24, 24);
            this.btnLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnBorrowedBooks
            // 
            this.btnBorrowedBooks.Location = new System.Drawing.Point(0, 172);
            this.btnBorrowedBooks.Name = "btnBorrowedBooks";
            this.btnBorrowedBooks.Palette = this.kryptonPalette1;
            this.btnBorrowedBooks.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnBorrowedBooks.Size = new System.Drawing.Size(88, 41);
            this.btnBorrowedBooks.StateCommon.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnBorrowedBooks.TabIndex = 9;
            this.btnBorrowedBooks.Values.Text = "Borrowed\r\nBooks";
            this.btnBorrowedBooks.Click += new System.EventHandler(this.btnBorrowedBooks_Click);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(0, 315);
            this.btnManage.Name = "btnManage";
            this.btnManage.Palette = this.kryptonPalette1;
            this.btnManage.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnManage.Size = new System.Drawing.Size(88, 42);
            this.btnManage.StateCommon.Content.ShortText.MultiLineH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnManage.TabIndex = 6;
            this.btnManage.Values.Text = "Manage\r\nBooks";
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.exitbtnapp);
            this.kryptonPanel2.Controls.Add(this.lblGreeting);
            this.kryptonPanel2.Location = new System.Drawing.Point(-2, -1);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Palette = this.kryptonPalette1;
            this.kryptonPanel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonPanel2.Size = new System.Drawing.Size(983, 49);
            this.kryptonPanel2.TabIndex = 12;
            // 
            // exitbtnapp
            // 
            this.exitbtnapp.BackColor = System.Drawing.Color.Transparent;
            this.exitbtnapp.Image = ((System.Drawing.Image)(resources.GetObject("exitbtnapp.Image")));
            this.exitbtnapp.Location = new System.Drawing.Point(945, 13);
            this.exitbtnapp.Name = "exitbtnapp";
            this.exitbtnapp.Size = new System.Drawing.Size(25, 25);
            this.exitbtnapp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitbtnapp.TabIndex = 12;
            this.exitbtnapp.TabStop = false;
            this.exitbtnapp.Click += new System.EventHandler(this.exitbtnapp_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.BackColor = System.Drawing.Color.Transparent;
            this.lblGreeting.Font = new System.Drawing.Font("Baskerville Old Face", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.lblGreeting.Location = new System.Drawing.Point(2, 0);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(981, 49);
            this.lblGreeting.TabIndex = 13;
            this.lblGreeting.Text = "Welcome to the Bookmark Library!";
            this.lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddBookmark
            // 
            this.btnAddBookmark.Location = new System.Drawing.Point(794, 460);
            this.btnAddBookmark.Name = "btnAddBookmark";
            this.btnAddBookmark.Palette = this.kryptonPalette1;
            this.btnAddBookmark.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnAddBookmark.Size = new System.Drawing.Size(112, 25);
            this.btnAddBookmark.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnAddBookmark.TabIndex = 13;
            this.btnAddBookmark.Values.Text = "Add to Bookmarks";
            this.btnAddBookmark.Click += new System.EventHandler(this.btnAddBookmark_Click);
            // 
            // btnRemoveBookmark
            // 
            this.btnRemoveBookmark.Location = new System.Drawing.Point(794, 460);
            this.btnRemoveBookmark.Name = "btnRemoveBookmark";
            this.btnRemoveBookmark.Palette = this.kryptonPalette1;
            this.btnRemoveBookmark.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnRemoveBookmark.Size = new System.Drawing.Size(112, 25);
            this.btnRemoveBookmark.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnRemoveBookmark.TabIndex = 14;
            this.btnRemoveBookmark.Values.Text = "Remove Bookmark";
            this.btnRemoveBookmark.Visible = false;
            this.btnRemoveBookmark.Click += new System.EventHandler(this.btnRemoveBookmark_Click);
            // 
            // lblFormChange
            // 
            this.lblFormChange.Location = new System.Drawing.Point(154, 69);
            this.lblFormChange.Name = "lblFormChange";
            this.lblFormChange.Palette = this.kryptonPalette1;
            this.lblFormChange.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lblFormChange.Size = new System.Drawing.Size(13, 27);
            this.lblFormChange.StateCommon.ShortText.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormChange.TabIndex = 15;
            this.lblFormChange.Values.Text = " ";
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(839, 106);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Palette = this.kryptonPalette1;
            this.lblTotal.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lblTotal.Size = new System.Drawing.Size(43, 19);
            this.lblTotal.StateCommon.ShortText.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Values.Text = "Total: ";
            // 
            // Worker
            // 
            this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            this.Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Location = new System.Drawing.Point(154, 460);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Palette = this.kryptonPalette1;
            this.btnConfirmPayment.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnConfirmPayment.Size = new System.Drawing.Size(109, 25);
            this.btnConfirmPayment.TabIndex = 17;
            this.btnConfirmPayment.Values.Text = "Confirm Payment";
            this.btnConfirmPayment.Visible = false;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // btnCancelRequest
            // 
            this.btnCancelRequest.Location = new System.Drawing.Point(811, 460);
            this.btnCancelRequest.Name = "btnCancelRequest";
            this.btnCancelRequest.Palette = this.kryptonPalette1;
            this.btnCancelRequest.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnCancelRequest.Size = new System.Drawing.Size(95, 25);
            this.btnCancelRequest.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnCancelRequest.TabIndex = 18;
            this.btnCancelRequest.Values.Text = "Cancel Request";
            this.btnCancelRequest.Visible = false;
            this.btnCancelRequest.Click += new System.EventHandler(this.btnCancelRequest_Click);
            // 
            // picBxRefresh
            // 
            this.picBxRefresh.Image = global::libSys.Properties.Resources.refresh_brown;
            this.picBxRefresh.Location = new System.Drawing.Point(812, 102);
            this.picBxRefresh.Name = "picBxRefresh";
            this.picBxRefresh.Size = new System.Drawing.Size(24, 22);
            this.picBxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxRefresh.TabIndex = 34;
            this.picBxRefresh.TabStop = false;
            this.picBxRefresh.Click += new System.EventHandler(this.picBxRefresh_Click);
            // 
            // kryptonPalette2
            // 
            this.kryptonPalette2.ButtonStyles.ButtonCommon.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(94)))), ((int)(((byte)(49)))));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.OverrideDefault.Border.Rounding = 6;
            this.kryptonPalette2.ButtonStyles.ButtonCommon.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.OverrideFocus.Border.Rounding = 6;
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 6;
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StatePressed.Border.Rounding = 6;
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StateTracking.Border.Rounding = 6;
            this.kryptonPalette2.ButtonStyles.ButtonCommon.StateTracking.Border.Width = 1;
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.Rounding = 10;
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.DataCell.Border.Rounding = 3;
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Rounding = 3;
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette2.GridStyles.GridCommon.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette2.GridStyles.GridCommon.StateDisabled.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.kryptonPalette2.GridStyles.GridCommon.StateDisabled.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.kryptonPalette2.GridStyles.GridCommon.StateDisabled.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.kryptonPalette2.GridStyles.GridCommon.StateDisabled.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.kryptonPalette2.GridStyles.GridCommon.StateDisabled.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.kryptonPalette2.GridStyles.GridCommon.StateDisabled.DataCell.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.kryptonPalette2.GridStyles.GridCommon.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.kryptonPalette2.InputControlStyles.InputControlCustom1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.kryptonPalette2.InputControlStyles.InputControlCustom1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.InputControlStyles.InputControlCustom1.StateCommon.Border.Rounding = 4;
            this.kryptonPalette2.InputControlStyles.InputControlCustom1.StateCommon.Border.Width = 2;
            this.kryptonPalette2.InputControlStyles.InputControlCustom1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.kryptonPalette2.InputControlStyles.InputControlCustom1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette2.InputControlStyles.InputControlRibbon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonPalette2.InputControlStyles.InputControlRibbon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.InputControlStyles.InputControlRibbon.StateCommon.Border.Rounding = 3;
            this.kryptonPalette2.InputControlStyles.InputControlRibbon.StateCommon.Border.Width = 2;
            this.kryptonPalette2.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.kryptonPalette2.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette2.LabelStyles.LabelCustom1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette2.LabelStyles.LabelCustom1.StateCommon.ShortText.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette2.PanelStyles.PanelCommon.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            // 
            // grpBxPopularBooks
            // 
            this.grpBxPopularBooks.CaptionVisible = false;
            this.grpBxPopularBooks.Location = new System.Drawing.Point(106, 56);
            this.grpBxPopularBooks.Name = "grpBxPopularBooks";
            // 
            // grpBxPopularBooks.Panel
            // 
            this.grpBxPopularBooks.Panel.Controls.Add(this.kryptonLabel1);
            this.grpBxPopularBooks.Panel.Controls.Add(this.lblBookThree);
            this.grpBxPopularBooks.Panel.Controls.Add(this.lblBookTwo);
            this.grpBxPopularBooks.Panel.Controls.Add(this.bookCoverThree);
            this.grpBxPopularBooks.Panel.Controls.Add(this.bookCoverTwo);
            this.grpBxPopularBooks.Panel.Controls.Add(this.bookCoverOne);
            this.grpBxPopularBooks.Panel.Controls.Add(this.pictureBox1);
            this.grpBxPopularBooks.Panel.Controls.Add(this.lblBookOne);
            this.grpBxPopularBooks.Panel.Controls.Add(this.pictureBox2);
            this.grpBxPopularBooks.Panel.Controls.Add(this.pictureBox3);
            this.grpBxPopularBooks.Size = new System.Drawing.Size(856, 445);
            this.grpBxPopularBooks.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.grpBxPopularBooks.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.grpBxPopularBooks.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpBxPopularBooks.StateCommon.Border.Rounding = 4;
            this.grpBxPopularBooks.TabIndex = 38;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(318, 22);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Palette = this.kryptonPalette1;
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel1.Size = new System.Drawing.Size(213, 29);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Baskerville Old Face", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 25;
            this.kryptonLabel1.Values.Text = "Most Borrowed Books";
            // 
            // lblBookThree
            // 
            this.lblBookThree.AutoEllipsis = true;
            this.lblBookThree.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookThree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(94)))), ((int)(((byte)(49)))));
            this.lblBookThree.Location = new System.Drawing.Point(541, 352);
            this.lblBookThree.Name = "lblBookThree";
            this.lblBookThree.Size = new System.Drawing.Size(222, 53);
            this.lblBookThree.TabIndex = 22;
            this.lblBookThree.Text = "Title\r\nAuthor\r\nYear Published";
            this.lblBookThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookTwo
            // 
            this.lblBookTwo.AutoEllipsis = true;
            this.lblBookTwo.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(94)))), ((int)(((byte)(49)))));
            this.lblBookTwo.Location = new System.Drawing.Point(315, 352);
            this.lblBookTwo.Name = "lblBookTwo";
            this.lblBookTwo.Size = new System.Drawing.Size(222, 53);
            this.lblBookTwo.TabIndex = 21;
            this.lblBookTwo.Text = "Title\r\nAuthor\r\nYear Published";
            this.lblBookTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookCoverThree
            // 
            this.bookCoverThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bookCoverThree.Location = new System.Drawing.Point(578, 112);
            this.bookCoverThree.Name = "bookCoverThree";
            this.bookCoverThree.Size = new System.Drawing.Size(144, 204);
            this.bookCoverThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookCoverThree.TabIndex = 19;
            this.bookCoverThree.TabStop = false;
            // 
            // bookCoverTwo
            // 
            this.bookCoverTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bookCoverTwo.Location = new System.Drawing.Point(353, 112);
            this.bookCoverTwo.Name = "bookCoverTwo";
            this.bookCoverTwo.Size = new System.Drawing.Size(144, 204);
            this.bookCoverTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookCoverTwo.TabIndex = 18;
            this.bookCoverTwo.TabStop = false;
            // 
            // bookCoverOne
            // 
            this.bookCoverOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bookCoverOne.Location = new System.Drawing.Point(127, 112);
            this.bookCoverOne.Name = "bookCoverOne";
            this.bookCoverOne.Size = new System.Drawing.Size(144, 204);
            this.bookCoverOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookCoverOne.TabIndex = 17;
            this.bookCoverOne.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lblBookOne
            // 
            this.lblBookOne.AutoEllipsis = true;
            this.lblBookOne.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(94)))), ((int)(((byte)(49)))));
            this.lblBookOne.Location = new System.Drawing.Point(89, 352);
            this.lblBookOne.Name = "lblBookOne";
            this.lblBookOne.Size = new System.Drawing.Size(222, 53);
            this.lblBookOne.TabIndex = 20;
            this.lblBookOne.Text = "Title\r\nAuthor\r\nYear Published";
            this.lblBookOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(326, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 279);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(551, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(201, 279);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // btnViewBook
            // 
            this.btnViewBook.Location = new System.Drawing.Point(621, 101);
            this.btnViewBook.Name = "btnViewBook";
            this.btnViewBook.Palette = this.kryptonPalette1;
            this.btnViewBook.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnViewBook.Size = new System.Drawing.Size(72, 25);
            this.btnViewBook.TabIndex = 2;
            this.btnViewBook.Values.Text = "View Book";
            this.btnViewBook.Click += new System.EventHandler(this.btnViewBook_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(553, 101);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Palette = this.kryptonPalette1;
            this.btnSearch.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnSearch.Size = new System.Drawing.Size(62, 25);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Values.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbbxGenre
            // 
            this.cmbbxGenre.DropDownWidth = 183;
            this.cmbbxGenre.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cmbbxGenre.Location = new System.Drawing.Point(699, 102);
            this.cmbbxGenre.Name = "cmbbxGenre";
            this.cmbbxGenre.Palette = this.kryptonPalette2;
            this.cmbbxGenre.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.cmbbxGenre.Size = new System.Drawing.Size(94, 22);
            this.cmbbxGenre.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbbxGenre.StateCommon.ComboBox.Border.Width = 1;
            this.cmbbxGenre.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxGenre.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.cmbbxGenre.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxGenre.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(94)))), ((int)(((byte)(49)))));
            this.cmbbxGenre.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.cmbbxGenre.TabIndex = 37;
            this.cmbbxGenre.TabStop = false;
            this.cmbbxGenre.Text = "Sort by genre";
            this.cmbbxGenre.SelectedIndexChanged += new System.EventHandler(this.cmbbxGenre_SelectedIndexChanged);
            this.cmbbxGenre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbbxGenre_KeyPress);
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtbxSearch.Location = new System.Drawing.Point(154, 102);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Palette = this.kryptonPalette1;
            this.txtbxSearch.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.txtbxSearch.Size = new System.Drawing.Size(393, 24);
            this.txtbxSearch.StateCommon.Content.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSearch.TabIndex = 4;
            this.txtbxSearch.Text = "Search for a book";
            this.txtbxSearch.Enter += new System.EventHandler(this.txtbxSearch_PlaceholderText);
            this.txtbxSearch.Leave += new System.EventHandler(this.txtbxSearch_PlaceholderText);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(980, 511);
            this.Controls.Add(this.grpBxPopularBooks);
            this.Controls.Add(this.cmbbxGenre);
            this.Controls.Add(this.sidebarMenuPanel);
            this.Controls.Add(this.picBxRefresh);
            this.Controls.Add(this.btnCancelRequest);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFormChange);
            this.Controls.Add(this.btnRemoveBookmark);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtbxSearch);
            this.Controls.Add(this.datagridBooks);
            this.Controls.Add(this.btnViewBook);
            this.Controls.Add(this.btnAddBookmark);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnConfirmPayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarMenuPanel)).EndInit();
            this.sidebarMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exitbtnapp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpBxPopularBooks.Panel)).EndInit();
            this.grpBxPopularBooks.Panel.ResumeLayout(false);
            this.grpBxPopularBooks.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpBxPopularBooks)).EndInit();
            this.grpBxPopularBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookCoverThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCoverTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCoverOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbxGenre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBorrow;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnReturn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView datagridBooks;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPendingRequests;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel sidebarMenuPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBorrowedBooks;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.PictureBox pctrbxLogo;
        private System.Windows.Forms.PictureBox btnLogOut;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOverdueBooks;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBookmarks;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnManage;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddBookmark;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAllBooks;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTransactions;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRemoveBookmark;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblFormChange;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTotal;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.PictureBox exitbtnapp;
        private System.ComponentModel.BackgroundWorker Worker;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnConfirmPayment;
        private System.Windows.Forms.Label lblGreeting;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnMembers;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancelRequest;
        private System.Windows.Forms.PictureBox picBxRefresh;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grpBxPopularBooks;
        private System.Windows.Forms.Label lblBookThree;
        private System.Windows.Forms.Label lblBookTwo;
        private System.Windows.Forms.Label lblBookOne;
        private System.Windows.Forms.PictureBox bookCoverThree;
        private System.Windows.Forms.PictureBox bookCoverTwo;
        private System.Windows.Forms.PictureBox bookCoverOne;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnViewBook;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbbxGenre;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbxSearch;
    }
}