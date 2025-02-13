namespace LibrarySystem
{
    partial class ManageBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBooks));
            this.kryptonPalette2 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btnAddNewBook = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtbxSearchBar = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEditBook = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDeleteBook = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.datagridBooks = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.genreListBox = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.lnklblRemoveImage = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lblGenres = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lnklblUploadImage = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.txtbxCopies = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.bookCoverImage = new System.Windows.Forms.PictureBox();
            this.txtbxYear = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtbxAuthor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtbxDescription = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.txtbxTitle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSaveNewBook = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSaveChanges = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.picBxRefresh = new System.Windows.Forms.PictureBox();
            this.btnGoBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookCoverImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBack)).BeginInit();
            this.SuspendLayout();
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
            this.kryptonPalette2.InputControlStyles.InputControlCustom1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.kryptonPalette2.InputControlStyles.InputControlCustom1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette2.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.kryptonPalette2.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette2.LabelStyles.LabelCustom1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonPalette2.LabelStyles.LabelCustom1.StateCommon.ShortText.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPalette2.PanelStyles.PanelCommon.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Location = new System.Drawing.Point(48, 474);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Palette = this.kryptonPalette2;
            this.btnAddNewBook.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnAddNewBook.Size = new System.Drawing.Size(88, 25);
            this.btnAddNewBook.TabIndex = 18;
            this.btnAddNewBook.Values.Text = "Add new book";
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // txtbxSearchBar
            // 
            this.txtbxSearchBar.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtbxSearchBar.Location = new System.Drawing.Point(48, 22);
            this.txtbxSearchBar.Name = "txtbxSearchBar";
            this.txtbxSearchBar.Palette = this.kryptonPalette2;
            this.txtbxSearchBar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.txtbxSearchBar.Size = new System.Drawing.Size(221, 24);
            this.txtbxSearchBar.StateCommon.Content.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSearchBar.TabIndex = 5;
            this.txtbxSearchBar.Text = "Search for a book";
            this.txtbxSearchBar.TextChanged += new System.EventHandler(this.txtbxSearchBar_TextChanged);
            this.txtbxSearchBar.Enter += new System.EventHandler(this.txtbxSearchBar_PlaceholderText);
            this.txtbxSearchBar.Leave += new System.EventHandler(this.txtbxSearchBar_PlaceholderText);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(275, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Palette = this.kryptonPalette2;
            this.btnSearch.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnSearch.Size = new System.Drawing.Size(64, 25);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Values.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(48, 474);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Palette = this.kryptonPalette2;
            this.btnEditBook.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnEditBook.Size = new System.Drawing.Size(88, 25);
            this.btnEditBook.TabIndex = 22;
            this.btnEditBook.Values.Text = "Edit book";
            this.btnEditBook.Visible = false;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(142, 473);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Palette = this.kryptonPalette2;
            this.btnDeleteBook.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnDeleteBook.Size = new System.Drawing.Size(79, 25);
            this.btnDeleteBook.TabIndex = 27;
            this.btnDeleteBook.Values.Text = "Delete book";
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // datagridBooks
            // 
            this.datagridBooks.AllowUserToAddRows = false;
            this.datagridBooks.AllowUserToDeleteRows = false;
            this.datagridBooks.AllowUserToResizeColumns = false;
            this.datagridBooks.AllowUserToResizeRows = false;
            this.datagridBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridBooks.Location = new System.Drawing.Point(48, 53);
            this.datagridBooks.MultiSelect = false;
            this.datagridBooks.Name = "datagridBooks";
            this.datagridBooks.Palette = this.kryptonPalette2;
            this.datagridBooks.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.datagridBooks.ReadOnly = true;
            this.datagridBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridBooks.Size = new System.Drawing.Size(377, 414);
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
            this.datagridBooks.StateDisabled.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.datagridBooks.StateDisabled.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.datagridBooks.StateDisabled.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.datagridBooks.StateDisabled.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.datagridBooks.StateDisabled.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.datagridBooks.StateDisabled.DataCell.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.datagridBooks.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.datagridBooks.TabIndex = 31;
            this.datagridBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridBooks_CellClick);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionVisible = false;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(442, 12);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            this.kryptonGroupBox1.Palette = this.kryptonPalette2;
            this.kryptonGroupBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.AutoScroll = true;
            this.kryptonGroupBox1.Panel.AutoScrollMinSize = new System.Drawing.Size(0, 600);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.genreListBox);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lnklblRemoveImage);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblGenres);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lnklblUploadImage);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtbxCopies);
            this.kryptonGroupBox1.Panel.Controls.Add(this.bookCoverImage);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtbxYear);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtbxAuthor);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtbxDescription);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtbxTitle);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnSaveNewBook);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnSaveChanges);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(538, 487);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.TabIndex = 32;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(20, 191);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Palette = this.kryptonPalette2;
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel1.Size = new System.Drawing.Size(76, 19);
            this.kryptonLabel1.TabIndex = 50;
            this.kryptonLabel1.Values.Text = "Description:";
            // 
            // genreListBox
            // 
            this.genreListBox.Enabled = false;
            this.genreListBox.Location = new System.Drawing.Point(20, 408);
            this.genreListBox.Name = "genreListBox";
            this.genreListBox.Palette = this.kryptonPalette2;
            this.genreListBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.genreListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.genreListBox.Size = new System.Drawing.Size(276, 180);
            this.genreListBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.genreListBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.genreListBox.StateCommon.Border.Rounding = 4;
            this.genreListBox.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.genreListBox.TabIndex = 48;
            this.genreListBox.SelectedIndexChanged += new System.EventHandler(this.genreListBox_SelectedIndexChanged);
            // 
            // lnklblRemoveImage
            // 
            this.lnklblRemoveImage.Location = new System.Drawing.Point(383, 296);
            this.lnklblRemoveImage.Name = "lnklblRemoveImage";
            this.lnklblRemoveImage.Palette = this.kryptonPalette2;
            this.lnklblRemoveImage.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lnklblRemoveImage.Size = new System.Drawing.Size(89, 19);
            this.lnklblRemoveImage.TabIndex = 44;
            this.lnklblRemoveImage.Values.Text = "Remove image";
            this.lnklblRemoveImage.Visible = false;
            this.lnklblRemoveImage.LinkClicked += new System.EventHandler(this.lnklblRemoveImage_LinkClicked);
            // 
            // lblGenres
            // 
            this.lblGenres.Location = new System.Drawing.Point(20, 386);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Palette = this.kryptonPalette2;
            this.lblGenres.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lblGenres.Size = new System.Drawing.Size(53, 19);
            this.lblGenres.TabIndex = 39;
            this.lblGenres.Values.Text = "Genres:";
            // 
            // lnklblUploadImage
            // 
            this.lnklblUploadImage.Enabled = false;
            this.lnklblUploadImage.Location = new System.Drawing.Point(384, 271);
            this.lnklblUploadImage.Name = "lnklblUploadImage";
            this.lnklblUploadImage.Palette = this.kryptonPalette2;
            this.lnklblUploadImage.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lnklblUploadImage.Size = new System.Drawing.Size(85, 19);
            this.lnklblUploadImage.TabIndex = 38;
            this.lnklblUploadImage.Values.Text = "Upload image";
            this.lnklblUploadImage.LinkClicked += new System.EventHandler(this.btnUploadImage_LinkClicked);
            // 
            // txtbxCopies
            // 
            this.txtbxCopies.Enabled = false;
            this.txtbxCopies.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtbxCopies.Location = new System.Drawing.Point(20, 152);
            this.txtbxCopies.Name = "txtbxCopies";
            this.txtbxCopies.Palette = this.kryptonPalette2;
            this.txtbxCopies.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.txtbxCopies.Size = new System.Drawing.Size(276, 24);
            this.txtbxCopies.StateCommon.Content.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCopies.TabIndex = 37;
            this.txtbxCopies.Text = "Copies";
            this.txtbxCopies.Enter += new System.EventHandler(this.txtbxCopies_PlaceholderText);
            this.txtbxCopies.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxNumberOnly_KeyPress);
            this.txtbxCopies.Leave += new System.EventHandler(this.txtbxCopies_PlaceholderText);
            // 
            // bookCoverImage
            // 
            this.bookCoverImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bookCoverImage.Location = new System.Drawing.Point(347, 22);
            this.bookCoverImage.Name = "bookCoverImage";
            this.bookCoverImage.Size = new System.Drawing.Size(156, 234);
            this.bookCoverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookCoverImage.TabIndex = 36;
            this.bookCoverImage.TabStop = false;
            // 
            // txtbxYear
            // 
            this.txtbxYear.Enabled = false;
            this.txtbxYear.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtbxYear.Location = new System.Drawing.Point(20, 109);
            this.txtbxYear.Name = "txtbxYear";
            this.txtbxYear.Palette = this.kryptonPalette2;
            this.txtbxYear.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.txtbxYear.Size = new System.Drawing.Size(276, 24);
            this.txtbxYear.StateCommon.Content.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxYear.TabIndex = 35;
            this.txtbxYear.Text = "Year of Publication";
            this.txtbxYear.Enter += new System.EventHandler(this.txtbxYear_PlaceholderText);
            this.txtbxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxNumberOnly_KeyPress);
            this.txtbxYear.Leave += new System.EventHandler(this.txtbxYear_PlaceholderText);
            // 
            // txtbxAuthor
            // 
            this.txtbxAuthor.Enabled = false;
            this.txtbxAuthor.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtbxAuthor.Location = new System.Drawing.Point(20, 65);
            this.txtbxAuthor.Name = "txtbxAuthor";
            this.txtbxAuthor.Palette = this.kryptonPalette2;
            this.txtbxAuthor.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.txtbxAuthor.Size = new System.Drawing.Size(276, 24);
            this.txtbxAuthor.StateCommon.Content.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAuthor.TabIndex = 34;
            this.txtbxAuthor.Text = "Author";
            this.txtbxAuthor.Enter += new System.EventHandler(this.txtbxAuthor_PlaceholderText);
            this.txtbxAuthor.Leave += new System.EventHandler(this.txtbxAuthor_PlaceholderText);
            // 
            // txtbxDescription
            // 
            this.txtbxDescription.Enabled = false;
            this.txtbxDescription.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtbxDescription.Location = new System.Drawing.Point(20, 213);
            this.txtbxDescription.Name = "txtbxDescription";
            this.txtbxDescription.Palette = this.kryptonPalette2;
            this.txtbxDescription.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.txtbxDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtbxDescription.Size = new System.Drawing.Size(276, 166);
            this.txtbxDescription.TabIndex = 32;
            this.txtbxDescription.Text = "";
            // 
            // txtbxTitle
            // 
            this.txtbxTitle.Enabled = false;
            this.txtbxTitle.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtbxTitle.Location = new System.Drawing.Point(20, 22);
            this.txtbxTitle.Name = "txtbxTitle";
            this.txtbxTitle.Palette = this.kryptonPalette2;
            this.txtbxTitle.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.txtbxTitle.Size = new System.Drawing.Size(276, 24);
            this.txtbxTitle.StateCommon.Content.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTitle.TabIndex = 31;
            this.txtbxTitle.Text = "Title";
            this.txtbxTitle.Enter += new System.EventHandler(this.txtbxTitle_PlaceholderText);
            this.txtbxTitle.Leave += new System.EventHandler(this.txtbxTitle_PlaceholderText);
            // 
            // btnSaveNewBook
            // 
            this.btnSaveNewBook.Location = new System.Drawing.Point(383, 441);
            this.btnSaveNewBook.Name = "btnSaveNewBook";
            this.btnSaveNewBook.Palette = this.kryptonPalette2;
            this.btnSaveNewBook.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnSaveNewBook.Size = new System.Drawing.Size(95, 25);
            this.btnSaveNewBook.TabIndex = 49;
            this.btnSaveNewBook.Values.Text = "Save New Book";
            this.btnSaveNewBook.Visible = false;
            this.btnSaveNewBook.Click += new System.EventHandler(this.btnSaveNewBook_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Location = new System.Drawing.Point(383, 558);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Palette = this.kryptonPalette2;
            this.btnSaveChanges.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnSaveChanges.Size = new System.Drawing.Size(95, 25);
            this.btnSaveChanges.TabIndex = 33;
            this.btnSaveChanges.Values.Text = "Save changes";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // Worker
            // 
            this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            this.Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
            // 
            // picBxRefresh
            // 
            this.picBxRefresh.Image = global::libSys.Properties.Resources.refresh_brown;
            this.picBxRefresh.Location = new System.Drawing.Point(345, 22);
            this.picBxRefresh.Name = "picBxRefresh";
            this.picBxRefresh.Size = new System.Drawing.Size(24, 24);
            this.picBxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxRefresh.TabIndex = 33;
            this.picBxRefresh.TabStop = false;
            this.picBxRefresh.Click += new System.EventHandler(this.picBxRefresh_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btnGoBack.Image = ((System.Drawing.Image)(resources.GetObject("btnGoBack.Image")));
            this.btnGoBack.Location = new System.Drawing.Point(12, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(25, 25);
            this.btnGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGoBack.TabIndex = 20;
            this.btnGoBack.TabStop = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // ManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(980, 511);
            this.Controls.Add(this.picBxRefresh);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.datagridBooks);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnEditBook);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtbxSearchBar);
            this.Controls.Add(this.btnAddNewBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageBooks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageBooks_FormClosed);
            this.Load += new System.EventHandler(this.ManageBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookCoverImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddNewBook;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbxSearchBar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private System.Windows.Forms.PictureBox btnGoBack;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEditBook;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeleteBook;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView datagridBooks;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox genreListBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnklblRemoveImage;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblGenres;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnklblUploadImage;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbxCopies;
        private System.Windows.Forms.PictureBox bookCoverImage;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbxYear;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbxAuthor;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSaveChanges;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtbxDescription;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbxTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSaveNewBook;
        private System.ComponentModel.BackgroundWorker Worker;
        private System.Windows.Forms.PictureBox picBxRefresh;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}