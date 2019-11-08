namespace NetSparkle.UI.NetFramework.WinForms
{
    partial class MessageNotificationWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageNotificationWindow));
            this.iconImage = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconImage)).BeginInit();
            this.SuspendLayout();
            // 
            // iconImage
            // 
            resources.ApplyResources(this.iconImage, "iconImage");
            this.iconImage.Name = "iconImage";
            this.iconImage.TabStop = false;
            // 
            // lblMessage
            // 
            resources.ApplyResources(this.lblMessage, "lblMessage");
            this.lblMessage.Name = "lblMessage";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OK_Click);
            // 
            // MessageNotificationWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iconImage);
            this.Controls.Add(this.lblMessage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageNotificationWindow";
            ((System.ComponentModel.ISupportInitialize)(this.iconImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox iconImage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button button1;
    }
}