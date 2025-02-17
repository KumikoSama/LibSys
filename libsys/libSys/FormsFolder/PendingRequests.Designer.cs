namespace LibrarySystem
{
    partial class PendingRequests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PendingRequests));
            this.lblPendingRequests = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPalette2 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btnDeclinedRequests = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.txtbxCopies = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtBxBorrowDuration = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblBorrowDuration = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtBxBookName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblBookName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblMemberName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtBxMemberName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblEstimatedDueDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblDateRequested = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dueDateEstimation = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dateRequested = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btnDecline = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnApprove = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAllPendingRequests = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnGoBack = new System.Windows.Forms.PictureBox();
            this.dataGridPendingRequests = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.lblRequestNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPendingRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPendingRequests
            // 
            this.lblPendingRequests.Location = new System.Drawing.Point(347, 34);
            this.lblPendingRequests.Name = "lblPendingRequests";
            this.lblPendingRequests.Palette = this.kryptonPalette2;
            this.lblPendingRequests.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lblPendingRequests.Size = new System.Drawing.Size(128, 23);
            this.lblPendingRequests.StateCommon.ShortText.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingRequests.TabIndex = 22;
            this.lblPendingRequests.Values.Text = "Pending Requests";
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
            // btnDeclinedRequests
            // 
            this.btnDeclinedRequests.Location = new System.Drawing.Point(12, 467);
            this.btnDeclinedRequests.Name = "btnDeclinedRequests";
            this.btnDeclinedRequests.Palette = this.kryptonPalette2;
            this.btnDeclinedRequests.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnDeclinedRequests.Size = new System.Drawing.Size(121, 27);
            this.btnDeclinedRequests.TabIndex = 30;
            this.btnDeclinedRequests.Values.Text = "Decline Requests";
            this.btnDeclinedRequests.Click += new System.EventHandler(this.btnDeclinedRequests_Click);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(482, 34);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            this.kryptonGroupBox1.Palette = this.kryptonPalette2;
            this.kryptonGroupBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.AutoScroll = true;
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblRequestNum);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtbxCopies);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtBxBorrowDuration);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblBorrowDuration);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtBxBookName);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblBookName);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblMemberName);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtBxMemberName);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblEstimatedDueDate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblDateRequested);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dueDateEstimation);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dateRequested);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnDecline);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnApprove);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(486, 425);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.TabIndex = 33;
            // 
            // txtbxCopies
            // 
            this.txtbxCopies.Enabled = false;
            this.txtbxCopies.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtbxCopies.Location = new System.Drawing.Point(195, 159);
            this.txtbxCopies.Name = "txtbxCopies";
            this.txtbxCopies.Palette = this.kryptonPalette2;
            this.txtbxCopies.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.txtbxCopies.Size = new System.Drawing.Size(216, 24);
            this.txtbxCopies.TabIndex = 55;
            this.txtbxCopies.TabStop = false;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(71, 159);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Palette = this.kryptonPalette2;
            this.kryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel2.Size = new System.Drawing.Size(106, 19);
            this.kryptonLabel2.TabIndex = 54;
            this.kryptonLabel2.Values.Text = "Copies to borrow:";
            // 
            // txtBxBorrowDuration
            // 
            this.txtBxBorrowDuration.Enabled = false;
            this.txtBxBorrowDuration.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtBxBorrowDuration.Location = new System.Drawing.Point(195, 203);
            this.txtBxBorrowDuration.Name = "txtBxBorrowDuration";
            this.txtBxBorrowDuration.Palette = this.kryptonPalette2;
            this.txtBxBorrowDuration.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.txtBxBorrowDuration.Size = new System.Drawing.Size(216, 24);
            this.txtBxBorrowDuration.TabIndex = 52;
            this.txtBxBorrowDuration.TabStop = false;
            this.txtBxBorrowDuration.TextChanged += new System.EventHandler(this.txtBxBorrowDuration_TextChanged);
            // 
            // lblBorrowDuration
            // 
            this.lblBorrowDuration.Location = new System.Drawing.Point(71, 206);
            this.lblBorrowDuration.Name = "lblBorrowDuration";
            this.lblBorrowDuration.Palette = this.kryptonPalette2;
            this.lblBorrowDuration.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lblBorrowDuration.Size = new System.Drawing.Size(103, 19);
            this.lblBorrowDuration.TabIndex = 51;
            this.lblBorrowDuration.Values.Text = "Borrow duration:";
            // 
            // txtBxBookName
            // 
            this.txtBxBookName.Enabled = false;
            this.txtBxBookName.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtBxBookName.Location = new System.Drawing.Point(195, 115);
            this.txtBxBookName.Name = "txtBxBookName";
            this.txtBxBookName.Palette = this.kryptonPalette2;
            this.txtBxBookName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.txtBxBookName.Size = new System.Drawing.Size(216, 24);
            this.txtBxBookName.TabIndex = 50;
            this.txtBxBookName.TabStop = false;
            // 
            // lblBookName
            // 
            this.lblBookName.Location = new System.Drawing.Point(71, 115);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Palette = this.kryptonPalette2;
            this.lblBookName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lblBookName.Size = new System.Drawing.Size(76, 19);
            this.lblBookName.TabIndex = 49;
            this.lblBookName.Values.Text = "Book name:";
            // 
            // lblMemberName
            // 
            this.lblMemberName.Location = new System.Drawing.Point(71, 69);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Palette = this.kryptonPalette2;
            this.lblMemberName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lblMemberName.Size = new System.Drawing.Size(93, 19);
            this.lblMemberName.TabIndex = 48;
            this.lblMemberName.Values.Text = "Member name:";
            // 
            // txtBxMemberName
            // 
            this.txtBxMemberName.Enabled = false;
            this.txtBxMemberName.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtBxMemberName.Location = new System.Drawing.Point(195, 69);
            this.txtBxMemberName.Name = "txtBxMemberName";
            this.txtBxMemberName.Palette = this.kryptonPalette2;
            this.txtBxMemberName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.txtBxMemberName.Size = new System.Drawing.Size(216, 24);
            this.txtBxMemberName.TabIndex = 47;
            this.txtBxMemberName.TabStop = false;
            // 
            // lblEstimatedDueDate
            // 
            this.lblEstimatedDueDate.Location = new System.Drawing.Point(71, 290);
            this.lblEstimatedDueDate.Name = "lblEstimatedDueDate";
            this.lblEstimatedDueDate.Palette = this.kryptonPalette2;
            this.lblEstimatedDueDate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lblEstimatedDueDate.Size = new System.Drawing.Size(116, 19);
            this.lblEstimatedDueDate.TabIndex = 46;
            this.lblEstimatedDueDate.Values.Text = "Estimated due date:";
            // 
            // lblDateRequested
            // 
            this.lblDateRequested.Location = new System.Drawing.Point(71, 248);
            this.lblDateRequested.Name = "lblDateRequested";
            this.lblDateRequested.Palette = this.kryptonPalette2;
            this.lblDateRequested.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lblDateRequested.Size = new System.Drawing.Size(95, 19);
            this.lblDateRequested.TabIndex = 45;
            this.lblDateRequested.Values.Text = "Date requested:";
            // 
            // dueDateEstimation
            // 
            this.dueDateEstimation.Enabled = false;
            this.dueDateEstimation.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.dueDateEstimation.Location = new System.Drawing.Point(195, 289);
            this.dueDateEstimation.Name = "dueDateEstimation";
            this.dueDateEstimation.Palette = this.kryptonPalette2;
            this.dueDateEstimation.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.dueDateEstimation.Size = new System.Drawing.Size(216, 22);
            this.dueDateEstimation.TabIndex = 44;
            this.dueDateEstimation.TabStop = false;
            // 
            // dateRequested
            // 
            this.dateRequested.Enabled = false;
            this.dateRequested.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.dateRequested.Location = new System.Drawing.Point(195, 247);
            this.dateRequested.Name = "dateRequested";
            this.dateRequested.Palette = this.kryptonPalette2;
            this.dateRequested.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.dateRequested.Size = new System.Drawing.Size(216, 22);
            this.dateRequested.TabIndex = 43;
            this.dateRequested.TabStop = false;
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(244, 337);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Palette = this.kryptonPalette2;
            this.btnDecline.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnDecline.Size = new System.Drawing.Size(64, 39);
            this.btnDecline.TabIndex = 42;
            this.btnDecline.Values.Text = "Decline";
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(174, 337);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Palette = this.kryptonPalette2;
            this.btnApprove.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnApprove.Size = new System.Drawing.Size(64, 39);
            this.btnApprove.TabIndex = 41;
            this.btnApprove.Values.Text = "Approve";
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnAllPendingRequests
            // 
            this.btnAllPendingRequests.Location = new System.Drawing.Point(12, 467);
            this.btnAllPendingRequests.Name = "btnAllPendingRequests";
            this.btnAllPendingRequests.Palette = this.kryptonPalette2;
            this.btnAllPendingRequests.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnAllPendingRequests.Size = new System.Drawing.Size(121, 27);
            this.btnAllPendingRequests.TabIndex = 34;
            this.btnAllPendingRequests.Values.Text = "Pending Requests";
            this.btnAllPendingRequests.Visible = false;
            this.btnAllPendingRequests.Click += new System.EventHandler(this.btnAllPendingRequests_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btnGoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoBack.BackgroundImage")));
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGoBack.Image = ((System.Drawing.Image)(resources.GetObject("btnGoBack.Image")));
            this.btnGoBack.Location = new System.Drawing.Point(12, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(25, 25);
            this.btnGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGoBack.TabIndex = 21;
            this.btnGoBack.TabStop = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // dataGridPendingRequests
            // 
            this.dataGridPendingRequests.AllowUserToAddRows = false;
            this.dataGridPendingRequests.AllowUserToDeleteRows = false;
            this.dataGridPendingRequests.AllowUserToResizeColumns = false;
            this.dataGridPendingRequests.AllowUserToResizeRows = false;
            this.dataGridPendingRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPendingRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPendingRequests.Location = new System.Drawing.Point(12, 63);
            this.dataGridPendingRequests.MultiSelect = false;
            this.dataGridPendingRequests.Name = "dataGridPendingRequests";
            this.dataGridPendingRequests.Palette = this.kryptonPalette2;
            this.dataGridPendingRequests.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.dataGridPendingRequests.ReadOnly = true;
            this.dataGridPendingRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPendingRequests.Size = new System.Drawing.Size(452, 398);
            this.dataGridPendingRequests.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridPendingRequests.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.dataGridPendingRequests.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.dataGridPendingRequests.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.dataGridPendingRequests.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.dataGridPendingRequests.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dataGridPendingRequests.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.dataGridPendingRequests.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.dataGridPendingRequests.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.dataGridPendingRequests.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.dataGridPendingRequests.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.dataGridPendingRequests.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.dataGridPendingRequests.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dataGridPendingRequests.StateDisabled.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.dataGridPendingRequests.StateDisabled.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.dataGridPendingRequests.StateDisabled.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.dataGridPendingRequests.StateDisabled.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.dataGridPendingRequests.StateDisabled.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.dataGridPendingRequests.StateDisabled.DataCell.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(192)))), ((int)(((byte)(176)))));
            this.dataGridPendingRequests.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.dataGridPendingRequests.TabIndex = 35;
            this.dataGridPendingRequests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPendingRequests_CellClick);
            // 
            // lblRequestNum
            // 
            this.lblRequestNum.AutoEllipsis = true;
            this.lblRequestNum.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.lblRequestNum.Location = new System.Drawing.Point(3, 25);
            this.lblRequestNum.Name = "lblRequestNum";
            this.lblRequestNum.Size = new System.Drawing.Size(476, 29);
            this.lblRequestNum.TabIndex = 56;
            this.lblRequestNum.Text = "Request #";
            this.lblRequestNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PendingRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(980, 511);
            this.Controls.Add(this.dataGridPendingRequests);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.lblPendingRequests);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnDeclinedRequests);
            this.Controls.Add(this.btnAllPendingRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PendingRequests";
            this.Palette = this.kryptonPalette2;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MembersInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MembersInfo_FormClosed);
            this.Load += new System.EventHandler(this.PendingRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPendingRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox btnGoBack;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPendingRequests;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeclinedRequests;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbxCopies;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBxBorrowDuration;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBorrowDuration;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBxBookName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBookName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblMemberName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBxMemberName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblEstimatedDueDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDateRequested;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dueDateEstimation;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dateRequested;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDecline;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnApprove;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAllPendingRequests;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataGridPendingRequests;
        private System.Windows.Forms.Label lblRequestNum;
    }
}