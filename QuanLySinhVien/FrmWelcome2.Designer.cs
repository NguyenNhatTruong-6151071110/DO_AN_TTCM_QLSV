namespace QuanLySinhVien
{
    partial class FrmWelcome2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWelcome2));
            picWelcome = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picWelcome).BeginInit();
            SuspendLayout();
            // 
            // picWelcome
            // 
            picWelcome.Dock = DockStyle.Fill;
            picWelcome.Image = (Image)resources.GetObject("picWelcome.Image");
            picWelcome.Location = new Point(0, 0);
            picWelcome.Name = "picWelcome";
            picWelcome.Size = new Size(849, 434);
            picWelcome.SizeMode = PictureBoxSizeMode.StretchImage;
            picWelcome.TabIndex = 0;
            picWelcome.TabStop = false;
            // 
            // FrmWelcome2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 434);
            Controls.Add(picWelcome);
            Name = "FrmWelcome2";
            Text = "FrmWelcome2";
            ((System.ComponentModel.ISupportInitialize)picWelcome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picWelcome;
    }
}