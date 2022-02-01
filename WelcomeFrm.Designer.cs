namespace X_GAME_O
{
    partial class WelcomeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeFrm));
            this.labPlay = new System.Windows.Forms.Label();
            this.labWinners = new System.Windows.Forms.Label();
            this.labExit = new System.Windows.Forms.Label();
            this.labBacGrd = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labPlay
            // 
            this.labPlay.BackColor = System.Drawing.Color.Transparent;
            this.labPlay.Location = new System.Drawing.Point(156, 29);
            this.labPlay.Name = "labPlay";
            this.labPlay.Size = new System.Drawing.Size(288, 73);
            this.labPlay.TabIndex = 4;
            this.toolTip1.SetToolTip(this.labPlay, "Play Game \'XGAMEO\'");
            this.labPlay.Click += new System.EventHandler(this.labPlay_Click);
            // 
            // labWinners
            // 
            this.labWinners.BackColor = System.Drawing.Color.Transparent;
            this.labWinners.Location = new System.Drawing.Point(156, 113);
            this.labWinners.Name = "labWinners";
            this.labWinners.Size = new System.Drawing.Size(288, 70);
            this.labWinners.TabIndex = 5;
            this.toolTip1.SetToolTip(this.labWinners, "View A List of All Players Who Have Won");
            this.labWinners.Click += new System.EventHandler(this.labWinners_Click);
            // 
            // labExit
            // 
            this.labExit.BackColor = System.Drawing.Color.Transparent;
            this.labExit.Location = new System.Drawing.Point(156, 197);
            this.labExit.Name = "labExit";
            this.labExit.Size = new System.Drawing.Size(288, 72);
            this.labExit.TabIndex = 6;
            this.toolTip1.SetToolTip(this.labExit, "Exit This Game");
            this.labExit.Click += new System.EventHandler(this.labExit_Click);
            // 
            // labBacGrd
            // 
            this.labBacGrd.BackColor = System.Drawing.Color.Transparent;
            this.labBacGrd.Image = global::X_GAME_O.Properties.Resources.XGAMEO_WelcomeFrm_Frm;
            this.labBacGrd.Location = new System.Drawing.Point(0, -1);
            this.labBacGrd.Name = "labBacGrd";
            this.labBacGrd.Size = new System.Drawing.Size(606, 509);
            this.labBacGrd.TabIndex = 0;
            // 
            // WelcomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 504);
            this.Controls.Add(this.labExit);
            this.Controls.Add(this.labWinners);
            this.Controls.Add(this.labPlay);
            this.Controls.Add(this.labBacGrd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WelcomeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome To XGAMEO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labBacGrd;
        private System.Windows.Forms.Label labPlay;
        private System.Windows.Forms.Label labWinners;
        private System.Windows.Forms.Label labExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}