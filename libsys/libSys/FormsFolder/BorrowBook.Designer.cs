namespace LibrarySystem
{
    partial class BorrowBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowBook));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.txtbxBookTitle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmbbxBorrowDuration = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnBorrow = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblHeader = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblBorrowDuration = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblCopies = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblBookTitle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.cmbbxCopies = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.datagridBooks = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbxBorrowDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbxCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBooks)).BeginInit();
            this.SuspendLayout();
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
            // txtbxBookTitle
            // 
            this.txtbxBookTitle.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtbxBookTitle.Location = new System.Drawing.Point(401, 74);
            this.txtbxBookTitle.Name = "txtbxBookTitle";
            this.txtbxBookTitle.Palette = this.kryptonPalette1;
            this.txtbxBookTitle.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.txtbxBookTitle.ReadOnly = true;
            this.txtbxBookTitle.Size = new System.Drawing.Size(178, 24);
            this.txtbxBookTitle.TabIndex = 11;
            this.txtbxBookTitle.Text = "Book Title";
            // 
            // cmbbxBorrowDuration
            // 
            this.cmbbxBorrowDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxBorrowDuration.DropDownWidth = 169;
            this.cmbbxBorrowDuration.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cmbbxBorrowDuration.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbbxBorrowDuration.Location = new System.Drawing.Point(401, 190);
            this.cmbbxBorrowDuration.Name = "cmbbxBorrowDuration";
            this.cmbbxBorrowDuration.Palette = this.kryptonPalette1;
            this.cmbbxBorrowDuration.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.cmbbxBorrowDuration.Size = new System.Drawing.Size(178, 22);
            this.cmbbxBorrowDuration.TabIndex = 15;
            this.cmbbxBorrowDuration.Text = "1";
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(445, 230);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnBorrow.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnBorrow.Palette = this.kryptonPalette1;
            this.btnBorrow.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnBorrow.Size = new System.Drawing.Size(90, 25);
            this.btnBorrow.TabIndex = 16;
            this.btnBorrow.Values.Text = "Borrow";
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Location = new System.Drawing.Point(433, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Palette = this.kryptonPalette1;
            this.lblHeader.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lblHeader.Size = new System.Drawing.Size(96, 21);
            this.lblHeader.StateCommon.ShortText.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.TabIndex = 17;
            this.lblHeader.Values.Text = "Borrow Book";
            // 
            // lblBorrowDuration
            // 
            this.lblBorrowDuration.Location = new System.Drawing.Point(401, 164);
            this.lblBorrowDuration.Name = "lblBorrowDuration";
            this.lblBorrowDuration.Palette = this.kryptonPalette1;
            this.lblBorrowDuration.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lblBorrowDuration.Size = new System.Drawing.Size(154, 19);
            this.lblBorrowDuration.TabIndex = 20;
            this.lblBorrowDuration.Values.Text = "Borrow Duration (in days):";
            // 
            // lblCopies
            // 
            this.lblCopies.Location = new System.Drawing.Point(401, 109);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Palette = this.kryptonPalette1;
            this.lblCopies.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lblCopies.Size = new System.Drawing.Size(106, 19);
            this.lblCopies.TabIndex = 22;
            this.lblCopies.Values.Text = "Copies to borrow:";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.Location = new System.Drawing.Point(402, 51);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Palette = this.kryptonPalette1;
            this.lblBookTitle.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lblBookTitle.Size = new System.Drawing.Size(72, 19);
            this.lblBookTitle.TabIndex = 23;
            this.lblBookTitle.Values.Text = "Book Title:";
            // 
            // Worker
            // 
            this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            this.Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btnGoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoBack.BackgroundImage")));
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Location = new System.Drawing.Point(12, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(25, 25);
            this.btnGoBack.TabIndex = 28;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // cmbbxCopies
            // 
            this.cmbbxCopies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxCopies.DropDownWidth = 169;
            this.cmbbxCopies.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.cmbbxCopies.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbbxCopies.Location = new System.Drawing.Point(402, 134);
            this.cmbbxCopies.Name = "cmbbxCopies";
            this.cmbbxCopies.Palette = this.kryptonPalette1;
            this.cmbbxCopies.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.cmbbxCopies.Size = new System.Drawing.Size(177, 22);
            this.cmbbxCopies.TabIndex = 29;
            this.cmbbxCopies.Text = "1";
            // 
            // datagridBooks
            // 
            this.datagridBooks.AllowUserToAddRows = false;
            this.datagridBooks.AllowUserToDeleteRows = false;
            this.datagridBooks.AllowUserToResizeColumns = false;
            this.datagridBooks.AllowUserToResizeRows = false;
            this.datagridBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridBooks.Location = new System.Drawing.Point(152, 276);
            this.datagridBooks.MultiSelect = false;
            this.datagridBooks.Name = "datagridBooks";
            this.datagridBooks.Palette = this.kryptonPalette1;
            this.datagridBooks.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.datagridBooks.ReadOnly = true;
            this.datagridBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridBooks.Size = new System.Drawing.Size(677, 223);
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
            this.datagridBooks.TabIndex = 30;
            this.datagridBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridBooks_CellClick);
            // 
            // BorrowBook
            // 
            this.AcceptButton = this.btnBorrow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.CancelButton = this.btnGoBack;
            this.ClientSize = new System.Drawing.Size(980, 511);
            this.Controls.Add(this.datagridBooks);
            this.Controls.Add(this.cmbbxCopies);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.lblCopies);
            this.Controls.Add(this.lblBorrowDuration);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.cmbbxBorrowDuration);
            this.Controls.Add(this.txtbxBookTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowBook";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow Book";
            ((System.ComponentModel.ISupportInitialize)(this.cmbbxBorrowDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbxCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbxBookTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbbxBorrowDuration;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBorrow;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblHeader;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBorrowDuration;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblCopies;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBookTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.ComponentModel.BackgroundWorker Worker;
        private System.Windows.Forms.Button btnGoBack;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbbxCopies;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView datagridBooks;
    }
}