namespace appRemote
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textExtendedIFMode = new TextBox();
            buttonConnect = new Button();
            buttonEnable = new Button();
            textConnected = new TextBox();
            picPcRemote1 = new PictureBox();
            picPcRemote2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            picCameras = new PictureBox();
            label4 = new Label();
            chkRegion = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)picPcRemote1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPcRemote2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCameras).BeginInit();
            SuspendLayout();
            // 
            // textExtendedIFMode
            // 
            resources.ApplyResources(textExtendedIFMode, "textExtendedIFMode");
            textExtendedIFMode.Name = "textExtendedIFMode";
            textExtendedIFMode.ReadOnly = true;
            textExtendedIFMode.TabStop = false;
            // 
            // buttonConnect
            // 
            resources.ApplyResources(buttonConnect, "buttonConnect");
            buttonConnect.Name = "buttonConnect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // buttonEnable
            // 
            resources.ApplyResources(buttonEnable, "buttonEnable");
            buttonEnable.Name = "buttonEnable";
            buttonEnable.UseVisualStyleBackColor = true;
            buttonEnable.Click += buttonEnable_Click;
            // 
            // textConnected
            // 
            resources.ApplyResources(textConnected, "textConnected");
            textConnected.Name = "textConnected";
            textConnected.ReadOnly = true;
            textConnected.TabStop = false;
            // 
            // picPcRemote1
            // 
            picPcRemote1.Image = EnableUSBC_Remote.Properties.Resources.pcremote_j1;
            resources.ApplyResources(picPcRemote1, "picPcRemote1");
            picPcRemote1.Name = "picPcRemote1";
            picPcRemote1.TabStop = false;
            // 
            // picPcRemote2
            // 
            picPcRemote2.Image = EnableUSBC_Remote.Properties.Resources.pcremote_j2;
            resources.ApplyResources(picPcRemote2, "picPcRemote2");
            picPcRemote2.Name = "picPcRemote2";
            picPcRemote2.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // picCameras
            // 
            picCameras.Image = EnableUSBC_Remote.Properties.Resources.cameras;
            resources.ApplyResources(picCameras, "picCameras");
            picCameras.Name = "picCameras";
            picCameras.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // chkRegion
            // 
            resources.ApplyResources(chkRegion, "chkRegion");
            chkRegion.Checked = true;
            chkRegion.CheckState = CheckState.Checked;
            chkRegion.Name = "chkRegion";
            chkRegion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chkRegion);
            Controls.Add(picCameras);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picPcRemote2);
            Controls.Add(picPcRemote1);
            Controls.Add(textConnected);
            Controls.Add(buttonEnable);
            Controls.Add(buttonConnect);
            Controls.Add(textExtendedIFMode);
            Name = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)picPcRemote1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPcRemote2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCameras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textExtendedIFMode;
        private Button buttonConnect;
        private Button buttonEnable;
        private TextBox textConnected;
        private PictureBox picPcRemote1;
        private PictureBox picPcRemote2;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox picCameras;
        private Label label4;
        private CheckBox chkRegion;
    }
}
