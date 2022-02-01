namespace X_GAME_O
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.TabsFrm = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DisPlyrO = new System.Windows.Forms.Label();
            this.DisPlyrX = new System.Windows.Forms.Label();
            this.LabPlyrO = new System.Windows.Forms.Label();
            this.LabPlyrX = new System.Windows.Forms.Label();
            this.labForward = new System.Windows.Forms.Label();
            this.labBack = new System.Windows.Forms.Label();
            this.labBacGrd1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LabUndo = new System.Windows.Forms.Label();
            this.LabSecWon = new System.Windows.Forms.Label();
            this.LabFstWon = new System.Windows.Forms.Label();
            this.LabSecPlyrNam = new System.Windows.Forms.Label();
            this.LabFstPlyrNam = new System.Windows.Forms.Label();
            this.LabPlyrTrn = new System.Windows.Forms.Label();
            this.LabCnl = new System.Windows.Forms.Label();
            this.LabBlock9 = new System.Windows.Forms.Label();
            this.LabBlock6 = new System.Windows.Forms.Label();
            this.LabBlock3 = new System.Windows.Forms.Label();
            this.LabBlock8 = new System.Windows.Forms.Label();
            this.LabBlock7 = new System.Windows.Forms.Label();
            this.LabBlock5 = new System.Windows.Forms.Label();
            this.LabBlock4 = new System.Windows.Forms.Label();
            this.LabBlock2 = new System.Windows.Forms.Label();
            this.LabBlock1 = new System.Windows.Forms.Label();
            this.HistoryItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labBacGrd2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.LabWinBck = new System.Windows.Forms.Label();
            this.ListTime = new System.Windows.Forms.ListView();
            this.ListDate = new System.Windows.Forms.ListView();
            this.ListName = new System.Windows.Forms.ListView();
            this.LabBacGrd3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TabsFrm.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabsFrm
            // 
            this.TabsFrm.Controls.Add(this.tabPage1);
            this.TabsFrm.Controls.Add(this.tabPage2);
            this.TabsFrm.Controls.Add(this.tabPage3);
            this.TabsFrm.Location = new System.Drawing.Point(-4, -22);
            this.TabsFrm.Name = "TabsFrm";
            this.TabsFrm.SelectedIndex = 0;
            this.TabsFrm.Size = new System.Drawing.Size(683, 591);
            this.TabsFrm.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DisPlyrO);
            this.tabPage1.Controls.Add(this.DisPlyrX);
            this.tabPage1.Controls.Add(this.LabPlyrO);
            this.tabPage1.Controls.Add(this.LabPlyrX);
            this.tabPage1.Controls.Add(this.labForward);
            this.tabPage1.Controls.Add(this.labBack);
            this.tabPage1.Controls.Add(this.labBacGrd1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(675, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DisPlyrO
            // 
            this.DisPlyrO.Font = new System.Drawing.Font("Kristen ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisPlyrO.ForeColor = System.Drawing.Color.White;
            this.DisPlyrO.Location = new System.Drawing.Point(133, 396);
            this.DisPlyrO.Name = "DisPlyrO";
            this.DisPlyrO.Size = new System.Drawing.Size(426, 57);
            this.DisPlyrO.TabIndex = 6;
            this.DisPlyrO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisPlyrX
            // 
            this.DisPlyrX.Font = new System.Drawing.Font("Kristen ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisPlyrX.ForeColor = System.Drawing.Color.White;
            this.DisPlyrX.Location = new System.Drawing.Point(133, 186);
            this.DisPlyrX.Name = "DisPlyrX";
            this.DisPlyrX.Size = new System.Drawing.Size(426, 57);
            this.DisPlyrX.TabIndex = 6;
            this.DisPlyrX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabPlyrO
            // 
            this.LabPlyrO.Location = new System.Drawing.Point(146, 311);
            this.LabPlyrO.Name = "LabPlyrO";
            this.LabPlyrO.Size = new System.Drawing.Size(402, 75);
            this.LabPlyrO.TabIndex = 5;
            this.toolTip1.SetToolTip(this.LabPlyrO, "The Name of Player Who Is Going To Be \'O\'");
            this.LabPlyrO.Click += new System.EventHandler(this.LabPlyrO_Click);
            // 
            // LabPlyrX
            // 
            this.LabPlyrX.Location = new System.Drawing.Point(146, 101);
            this.LabPlyrX.Name = "LabPlyrX";
            this.LabPlyrX.Size = new System.Drawing.Size(402, 75);
            this.LabPlyrX.TabIndex = 5;
            this.toolTip1.SetToolTip(this.LabPlyrX, "The Name of Player Who Is Going To Be \'X\'");
            this.LabPlyrX.Click += new System.EventHandler(this.LabPlyrX_Click);
            // 
            // labForward
            // 
            this.labForward.Location = new System.Drawing.Point(593, 528);
            this.labForward.Name = "labForward";
            this.labForward.Size = new System.Drawing.Size(80, 33);
            this.labForward.TabIndex = 4;
            this.toolTip1.SetToolTip(this.labForward, "Start Game");
            this.labForward.Click += new System.EventHandler(this.labForward_Click);
            // 
            // labBack
            // 
            this.labBack.Location = new System.Drawing.Point(0, 528);
            this.labBack.Name = "labBack";
            this.labBack.Size = new System.Drawing.Size(80, 34);
            this.labBack.TabIndex = 3;
            this.toolTip1.SetToolTip(this.labBack, "Go Back");
            this.labBack.Click += new System.EventHandler(this.labBack_Click);
            // 
            // labBacGrd1
            // 
            this.labBacGrd1.Image = global::X_GAME_O.Properties.Resources.XGAMEO_NameFrm;
            this.labBacGrd1.Location = new System.Drawing.Point(0, 0);
            this.labBacGrd1.Name = "labBacGrd1";
            this.labBacGrd1.Size = new System.Drawing.Size(673, 561);
            this.labBacGrd1.TabIndex = 2;
            this.labBacGrd1.Click += new System.EventHandler(this.labBacGrd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LabUndo);
            this.tabPage2.Controls.Add(this.LabSecWon);
            this.tabPage2.Controls.Add(this.LabFstWon);
            this.tabPage2.Controls.Add(this.LabSecPlyrNam);
            this.tabPage2.Controls.Add(this.LabFstPlyrNam);
            this.tabPage2.Controls.Add(this.LabPlyrTrn);
            this.tabPage2.Controls.Add(this.LabCnl);
            this.tabPage2.Controls.Add(this.LabBlock9);
            this.tabPage2.Controls.Add(this.LabBlock6);
            this.tabPage2.Controls.Add(this.LabBlock3);
            this.tabPage2.Controls.Add(this.LabBlock8);
            this.tabPage2.Controls.Add(this.LabBlock7);
            this.tabPage2.Controls.Add(this.LabBlock5);
            this.tabPage2.Controls.Add(this.LabBlock4);
            this.tabPage2.Controls.Add(this.LabBlock2);
            this.tabPage2.Controls.Add(this.LabBlock1);
            this.tabPage2.Controls.Add(this.HistoryItems);
            this.tabPage2.Controls.Add(this.labBacGrd2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(675, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LabUndo
            // 
            this.LabUndo.Location = new System.Drawing.Point(441, 13);
            this.LabUndo.Name = "LabUndo";
            this.LabUndo.Size = new System.Drawing.Size(36, 37);
            this.LabUndo.TabIndex = 7;
            this.toolTip1.SetToolTip(this.LabUndo, "Undo Your Move");
            this.LabUndo.Click += new System.EventHandler(this.LabUndo_Click);
            // 
            // LabSecWon
            // 
            this.LabSecWon.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSecWon.ForeColor = System.Drawing.Color.White;
            this.LabSecWon.Location = new System.Drawing.Point(325, 98);
            this.LabSecWon.Name = "LabSecWon";
            this.LabSecWon.Size = new System.Drawing.Size(71, 23);
            this.LabSecWon.TabIndex = 6;
            this.LabSecWon.Text = "Won: 5";
            this.LabSecWon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabFstWon
            // 
            this.LabFstWon.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabFstWon.ForeColor = System.Drawing.Color.White;
            this.LabFstWon.Location = new System.Drawing.Point(325, 75);
            this.LabFstWon.Name = "LabFstWon";
            this.LabFstWon.Size = new System.Drawing.Size(71, 23);
            this.LabFstWon.TabIndex = 6;
            this.LabFstWon.Text = "Won: 1";
            this.LabFstWon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabSecPlyrNam
            // 
            this.LabSecPlyrNam.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSecPlyrNam.ForeColor = System.Drawing.Color.White;
            this.LabSecPlyrNam.Location = new System.Drawing.Point(99, 99);
            this.LabSecPlyrNam.Name = "LabSecPlyrNam";
            this.LabSecPlyrNam.Size = new System.Drawing.Size(213, 23);
            this.LabSecPlyrNam.TabIndex = 6;
            this.LabSecPlyrNam.Text = "Luke De Charmoy";
            this.LabSecPlyrNam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabFstPlyrNam
            // 
            this.LabFstPlyrNam.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabFstPlyrNam.ForeColor = System.Drawing.Color.White;
            this.LabFstPlyrNam.Location = new System.Drawing.Point(99, 76);
            this.LabFstPlyrNam.Name = "LabFstPlyrNam";
            this.LabFstPlyrNam.Size = new System.Drawing.Size(213, 23);
            this.LabFstPlyrNam.TabIndex = 6;
            this.LabFstPlyrNam.Text = "Srivas";
            this.LabFstPlyrNam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabPlyrTrn
            // 
            this.LabPlyrTrn.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPlyrTrn.ForeColor = System.Drawing.Color.White;
            this.LabPlyrTrn.Location = new System.Drawing.Point(99, 44);
            this.LabPlyrTrn.Name = "LabPlyrTrn";
            this.LabPlyrTrn.Size = new System.Drawing.Size(297, 32);
            this.LabPlyrTrn.TabIndex = 6;
            this.LabPlyrTrn.Text = "Srivas >>";
            this.LabPlyrTrn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabCnl
            // 
            this.LabCnl.Location = new System.Drawing.Point(12, 13);
            this.LabCnl.Name = "LabCnl";
            this.LabCnl.Size = new System.Drawing.Size(39, 37);
            this.LabCnl.TabIndex = 5;
            this.toolTip1.SetToolTip(this.LabCnl, "Exit Game");
            this.LabCnl.Click += new System.EventHandler(this.LabCnl_Click);
            // 
            // LabBlock9
            // 
            this.LabBlock9.Font = new System.Drawing.Font("Arial", 84.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBlock9.ForeColor = System.Drawing.Color.White;
            this.LabBlock9.Location = new System.Drawing.Point(321, 428);
            this.LabBlock9.Name = "LabBlock9";
            this.LabBlock9.Size = new System.Drawing.Size(137, 122);
            this.LabBlock9.TabIndex = 3;
            this.LabBlock9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBlock6
            // 
            this.LabBlock6.Font = new System.Drawing.Font("Arial", 84.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBlock6.ForeColor = System.Drawing.Color.White;
            this.LabBlock6.Location = new System.Drawing.Point(321, 300);
            this.LabBlock6.Name = "LabBlock6";
            this.LabBlock6.Size = new System.Drawing.Size(137, 122);
            this.LabBlock6.TabIndex = 3;
            this.LabBlock6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBlock3
            // 
            this.LabBlock3.Font = new System.Drawing.Font("Arial", 84.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBlock3.ForeColor = System.Drawing.Color.White;
            this.LabBlock3.Location = new System.Drawing.Point(321, 173);
            this.LabBlock3.Name = "LabBlock3";
            this.LabBlock3.Size = new System.Drawing.Size(137, 122);
            this.LabBlock3.TabIndex = 3;
            this.LabBlock3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBlock8
            // 
            this.LabBlock8.Font = new System.Drawing.Font("Arial", 84.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBlock8.ForeColor = System.Drawing.Color.White;
            this.LabBlock8.Location = new System.Drawing.Point(175, 428);
            this.LabBlock8.Name = "LabBlock8";
            this.LabBlock8.Size = new System.Drawing.Size(137, 122);
            this.LabBlock8.TabIndex = 3;
            this.LabBlock8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBlock7
            // 
            this.LabBlock7.Font = new System.Drawing.Font("Arial", 84.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBlock7.ForeColor = System.Drawing.Color.White;
            this.LabBlock7.Location = new System.Drawing.Point(29, 428);
            this.LabBlock7.Name = "LabBlock7";
            this.LabBlock7.Size = new System.Drawing.Size(137, 122);
            this.LabBlock7.TabIndex = 3;
            this.LabBlock7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBlock5
            // 
            this.LabBlock5.Font = new System.Drawing.Font("Arial", 84.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBlock5.ForeColor = System.Drawing.Color.White;
            this.LabBlock5.Location = new System.Drawing.Point(175, 300);
            this.LabBlock5.Name = "LabBlock5";
            this.LabBlock5.Size = new System.Drawing.Size(137, 122);
            this.LabBlock5.TabIndex = 3;
            this.LabBlock5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBlock4
            // 
            this.LabBlock4.Font = new System.Drawing.Font("Arial", 84.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBlock4.ForeColor = System.Drawing.Color.White;
            this.LabBlock4.Location = new System.Drawing.Point(29, 300);
            this.LabBlock4.Name = "LabBlock4";
            this.LabBlock4.Size = new System.Drawing.Size(137, 122);
            this.LabBlock4.TabIndex = 3;
            this.LabBlock4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBlock2
            // 
            this.LabBlock2.Font = new System.Drawing.Font("Arial", 84.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBlock2.ForeColor = System.Drawing.Color.White;
            this.LabBlock2.Location = new System.Drawing.Point(175, 173);
            this.LabBlock2.Name = "LabBlock2";
            this.LabBlock2.Size = new System.Drawing.Size(137, 122);
            this.LabBlock2.TabIndex = 3;
            this.LabBlock2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabBlock1
            // 
            this.LabBlock1.Font = new System.Drawing.Font("Arial", 84.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBlock1.ForeColor = System.Drawing.Color.White;
            this.LabBlock1.Location = new System.Drawing.Point(29, 173);
            this.LabBlock1.Name = "LabBlock1";
            this.LabBlock1.Size = new System.Drawing.Size(137, 122);
            this.LabBlock1.TabIndex = 3;
            this.LabBlock1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HistoryItems
            // 
            this.HistoryItems.BackColor = System.Drawing.Color.White;
            this.HistoryItems.BackgroundImage = global::X_GAME_O.Properties.Resources.XGAMEO_HisBacGrd;
            this.HistoryItems.BackgroundImageTiled = true;
            this.HistoryItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HistoryItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.HistoryItems.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryItems.ForeColor = System.Drawing.Color.Teal;
            this.HistoryItems.GridLines = true;
            this.HistoryItems.Location = new System.Drawing.Point(492, 49);
            this.HistoryItems.MultiSelect = false;
            this.HistoryItems.Name = "HistoryItems";
            this.HistoryItems.Size = new System.Drawing.Size(175, 504);
            this.HistoryItems.TabIndex = 4;
            this.HistoryItems.UseCompatibleStateImageBehavior = false;
            this.HistoryItems.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "History";
            this.columnHeader1.Width = 174;
            // 
            // labBacGrd2
            // 
            this.labBacGrd2.ForeColor = System.Drawing.Color.Black;
            this.labBacGrd2.Image = global::X_GAME_O.Properties.Resources.XGAMEO_Main_Frm;
            this.labBacGrd2.Location = new System.Drawing.Point(-1, -2);
            this.labBacGrd2.Name = "labBacGrd2";
            this.labBacGrd2.Size = new System.Drawing.Size(675, 566);
            this.labBacGrd2.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnClear);
            this.tabPage3.Controls.Add(this.LabWinBck);
            this.tabPage3.Controls.Add(this.ListTime);
            this.tabPage3.Controls.Add(this.ListDate);
            this.tabPage3.Controls.Add(this.ListName);
            this.tabPage3.Controls.Add(this.LabBacGrd3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(675, 565);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.Location = new System.Drawing.Point(575, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 35);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "<< Clear >>";
            this.toolTip1.SetToolTip(this.btnClear, "Clear The List of Winners");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // LabWinBck
            // 
            this.LabWinBck.Location = new System.Drawing.Point(3, 3);
            this.LabWinBck.Name = "LabWinBck";
            this.LabWinBck.Size = new System.Drawing.Size(49, 30);
            this.LabWinBck.TabIndex = 5;
            this.toolTip1.SetToolTip(this.LabWinBck, "Go Back To Welcome Form");
            this.LabWinBck.Click += new System.EventHandler(this.LabWinBck_Click);
            // 
            // ListTime
            // 
            this.ListTime.BackgroundImage = global::X_GAME_O.Properties.Resources.XGAMEO_WinnersListBrd;
            this.ListTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListTime.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ListTime.Location = new System.Drawing.Point(454, 118);
            this.ListTime.Name = "ListTime";
            this.ListTime.Scrollable = false;
            this.ListTime.Size = new System.Drawing.Size(207, 441);
            this.ListTime.TabIndex = 4;
            this.ListTime.UseCompatibleStateImageBehavior = false;
            this.ListTime.View = System.Windows.Forms.View.List;
            // 
            // ListDate
            // 
            this.ListDate.BackgroundImage = global::X_GAME_O.Properties.Resources.XGAMEO_WinnersListBrd;
            this.ListDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListDate.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ListDate.Location = new System.Drawing.Point(216, 118);
            this.ListDate.Name = "ListDate";
            this.ListDate.Scrollable = false;
            this.ListDate.Size = new System.Drawing.Size(206, 441);
            this.ListDate.TabIndex = 4;
            this.ListDate.UseCompatibleStateImageBehavior = false;
            this.ListDate.View = System.Windows.Forms.View.List;
            // 
            // ListName
            // 
            this.ListName.BackgroundImage = global::X_GAME_O.Properties.Resources.XGAMEO_WinnersListBrd;
            this.ListName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListName.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ListName.Location = new System.Drawing.Point(2, 118);
            this.ListName.Name = "ListName";
            this.ListName.Scrollable = false;
            this.ListName.Size = new System.Drawing.Size(207, 441);
            this.ListName.TabIndex = 4;
            this.ListName.UseCompatibleStateImageBehavior = false;
            this.ListName.View = System.Windows.Forms.View.List;
            // 
            // LabBacGrd3
            // 
            this.LabBacGrd3.Image = global::X_GAME_O.Properties.Resources.XGAMEO_WinnersFrm1;
            this.LabBacGrd3.Location = new System.Drawing.Point(-1, 0);
            this.LabBacGrd3.Name = "LabBacGrd3";
            this.LabBacGrd3.Size = new System.Drawing.Size(680, 565);
            this.LabBacGrd3.TabIndex = 3;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(673, 561);
            this.Controls.Add(this.TabsFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Play Game XGAMEO";
            this.TabsFrm.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabsFrm;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labBacGrd1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labBacGrd2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label LabBacGrd3;
        private System.Windows.Forms.Label labBack;
        private System.Windows.Forms.Label labForward;
        private System.Windows.Forms.Label LabBlock2;
        private System.Windows.Forms.Label LabBlock9;
        private System.Windows.Forms.Label LabBlock6;
        private System.Windows.Forms.Label LabBlock3;
        private System.Windows.Forms.Label LabBlock8;
        private System.Windows.Forms.Label LabBlock7;
        private System.Windows.Forms.Label LabBlock5;
        private System.Windows.Forms.Label LabBlock4;
        private System.Windows.Forms.ListView HistoryItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label LabPlyrO;
        private System.Windows.Forms.Label LabPlyrX;
        private System.Windows.Forms.Label DisPlyrO;
        private System.Windows.Forms.Label DisPlyrX;
        private System.Windows.Forms.Label LabCnl;
        private System.Windows.Forms.Label LabFstPlyrNam;
        private System.Windows.Forms.Label LabPlyrTrn;
        private System.Windows.Forms.ListView ListTime;
        private System.Windows.Forms.ListView ListDate;
        private System.Windows.Forms.ListView ListName;
        private System.Windows.Forms.Label LabWinBck;
        private System.Windows.Forms.Label LabUndo;
        private System.Windows.Forms.Label LabFstWon;
        private System.Windows.Forms.Label LabSecWon;
        private System.Windows.Forms.Label LabSecPlyrNam;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label LabBlock1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

