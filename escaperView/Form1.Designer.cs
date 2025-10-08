namespace escaperView
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            menuBar = new ToolStrip();
            newGameBtn = new ToolStripButton();
            mapSizeLabel = new ToolStripLabel();
            mapSize = new ToolStripComboBox();
            pauseBtn = new ToolStripButton();
            saveBtn = new ToolStripButton();
            loadBtn = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            gameBoard = new Panel();
            statusStrip = new StatusStrip();
            labelTime = new ToolStripStatusLabel();
            labelStatus = new ToolStripStatusLabel();
            menuBar.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuBar
            // 
            menuBar.BackColor = SystemColors.ControlDarkDark;
            menuBar.ImageScalingSize = new Size(24, 24);
            menuBar.Items.AddRange(new ToolStripItem[] { newGameBtn, mapSizeLabel, mapSize, pauseBtn, saveBtn, loadBtn });
            menuBar.Location = new Point(0, 0);
            menuBar.Name = "menuBar";
            menuBar.Size = new Size(800, 34);
            menuBar.TabIndex = 0;
            menuBar.Text = "menuBar";
            // 
            // newGameBtn
            // 
            newGameBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            newGameBtn.Image = (Image)resources.GetObject("newGameBtn.Image");
            newGameBtn.ImageTransparentColor = Color.Magenta;
            newGameBtn.Name = "newGameBtn";
            newGameBtn.Size = new Size(102, 29);
            newGameBtn.Text = "New Game";
            newGameBtn.Click += newGameBtn_Click;
            // 
            // mapSizeLabel
            // 
            mapSizeLabel.Name = "mapSizeLabel";
            mapSizeLabel.Size = new Size(88, 29);
            mapSizeLabel.Text = "Map Size:";
            // 
            // mapSize
            // 
            mapSize.Items.AddRange(new object[] { "11x11", "15x15", "21x21" });
            mapSize.Name = "mapSize";
            mapSize.Size = new Size(121, 34);
            // 
            // pauseBtn
            // 
            pauseBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            pauseBtn.Image = (Image)resources.GetObject("pauseBtn.Image");
            pauseBtn.ImageTransparentColor = Color.Magenta;
            pauseBtn.Name = "pauseBtn";
            pauseBtn.Size = new Size(104, 29);
            pauseBtn.Text = "Pause/Start";
            // 
            // saveBtn
            // 
            saveBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveBtn.Image = (Image)resources.GetObject("saveBtn.Image");
            saveBtn.ImageTransparentColor = Color.Magenta;
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(53, 29);
            saveBtn.Text = "Save";
            // 
            // loadBtn
            // 
            loadBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            loadBtn.Image = (Image)resources.GetObject("loadBtn.Image");
            loadBtn.ImageTransparentColor = Color.Magenta;
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(55, 29);
            loadBtn.Text = "Load";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // gameBoard
            // 
            gameBoard.BackColor = SystemColors.ButtonFace;
            gameBoard.Location = new Point(173, 37);
            gameBoard.Name = "gameBoard";
            gameBoard.Size = new Size(380, 356);
            gameBoard.TabIndex = 2;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { labelTime, labelStatus });
            statusStrip.Location = new Point(0, 396);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 32);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip";
            // 
            // labelTime
            // 
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(69, 25);
            labelTime.Text = "Time: 0";
            // 
            // labelStatus
            // 
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(99, 25);
            labelStatus.Text = "Start Game";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip);
            Controls.Add(gameBoard);
            Controls.Add(statusStrip1);
            Controls.Add(menuBar);
            Name = "mainForm";
            Text = "Escaper";
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip menuBar;
        private ToolStripButton newGameBtn;
        private ToolStripButton pauseBtn;
        private ToolStripButton saveBtn;
        private ToolStripButton loadBtn;
        private StatusStrip statusStrip1;
        private Panel gameBoard;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel labelTime;
        private ToolStripStatusLabel labelStatus;
        private ToolStripLabel mapSizeLabel;
        private ToolStripComboBox mapSize;
    }
}
