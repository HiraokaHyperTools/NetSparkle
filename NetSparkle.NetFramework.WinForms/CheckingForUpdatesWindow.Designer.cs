namespace NetSparkle.UI.NetFramework.WinForms
{
    partial class CheckingForUpdatesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckingForUpdatesWindow));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.CheckingForUpdates = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.iconImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconImage)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.MarqueeAnimationSpeed = 5;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // CheckingForUpdates
            // 
            resources.ApplyResources(this.CheckingForUpdates, "CheckingForUpdates");
            this.CheckingForUpdates.Name = "CheckingForUpdates";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // iconImage
            // 
            resources.ApplyResources(this.iconImage, "iconImage");
            this.iconImage.Name = "iconImage";
            this.iconImage.TabStop = false;
            // 
            // CheckingForUpdatesWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconImage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CheckingForUpdates);
            this.Controls.Add(this.progressBar1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckingForUpdatesWindow";
            ((System.ComponentModel.ISupportInitialize)(this.iconImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label CheckingForUpdates;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox iconImage;
    }
}