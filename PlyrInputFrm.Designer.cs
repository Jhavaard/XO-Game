namespace X_GAME_O
{
    partial class PlyrInputFrm
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.LabPlyr = new System.Windows.Forms.Label();
            this.btnCon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.MintCream;
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.Color.DimGray;
            this.txtInput.Location = new System.Drawing.Point(12, 47);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(429, 29);
            this.txtInput.TabIndex = 0;
            // 
            // LabPlyr
            // 
            this.LabPlyr.AutoSize = true;
            this.LabPlyr.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPlyr.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabPlyr.Location = new System.Drawing.Point(67, 9);
            this.LabPlyr.Name = "LabPlyr";
            this.LabPlyr.Size = new System.Drawing.Size(319, 28);
            this.LabPlyr.TabIndex = 1;
            this.LabPlyr.Text = "ENTER NAME OF PLAYER X";
            // 
            // btnCon
            // 
            this.btnCon.BackColor = System.Drawing.Color.Teal;
            this.btnCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCon.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCon.Location = new System.Drawing.Point(183, 85);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(88, 30);
            this.btnCon.TabIndex = 2;
            this.btnCon.Text = "CONTINUE";
            this.btnCon.UseVisualStyleBackColor = false;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // PlyrInputFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(453, 123);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.LabPlyr);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "PlyrInputFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Input Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label LabPlyr;
        private System.Windows.Forms.Button btnCon;
    }
}