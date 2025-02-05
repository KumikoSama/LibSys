namespace LibrarySystem
{
    partial class PenaltyFee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PenaltyFee));
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lnklblUploadReceipt = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.btnSubmit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.picBxReceipt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBxReceipt)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(139, 45);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(78, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Penalty Fees";
            // 
            // lnklblUploadReceipt
            // 
            this.lnklblUploadReceipt.Location = new System.Drawing.Point(117, 280);
            this.lnklblUploadReceipt.Name = "lnklblUploadReceipt";
            this.lnklblUploadReceipt.Size = new System.Drawing.Size(123, 20);
            this.lnklblUploadReceipt.TabIndex = 2;
            this.lnklblUploadReceipt.Values.Text = "Upload Receipt Here";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(128, 357);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(101, 25);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Values.Text = "Submit Receipt";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // picBxReceipt
            // 
            this.picBxReceipt.Image = ((System.Drawing.Image)(resources.GetObject("picBxReceipt.Image")));
            this.picBxReceipt.Location = new System.Drawing.Point(90, 113);
            this.picBxReceipt.Name = "picBxReceipt";
            this.picBxReceipt.Size = new System.Drawing.Size(181, 152);
            this.picBxReceipt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxReceipt.TabIndex = 1;
            this.picBxReceipt.TabStop = false;
            // 
            // PenaltyFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(219)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(368, 410);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lnklblUploadReceipt);
            this.Controls.Add(this.picBxReceipt);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "PenaltyFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PenaltyFee";
            ((System.ComponentModel.ISupportInitialize)(this.picBxReceipt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.PictureBox picBxReceipt;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnklblUploadReceipt;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubmit;
    }
}