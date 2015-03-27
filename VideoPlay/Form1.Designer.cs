namespace VideoPlay
{
    partial class Form1
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
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Player = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.VideoContainer = new System.Windows.Forms.PictureBox();
            this.VideoProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Volume = new System.Windows.Forms.TrackBar();
            this.Replay = new MetroFramework.Controls.MetroCheckBox();
            this.Previous = new MetroFramework.Controls.MetroButton();
            this.Stop = new MetroFramework.Controls.MetroButton();
            this.Pause = new MetroFramework.Controls.MetroButton();
            this.Play = new MetroFramework.Controls.MetroButton();
            this.Next = new MetroFramework.Controls.MetroButton();
            this.Media = new MetroFramework.Controls.MetroTabPage();
            this.Settings = new MetroFramework.Controls.MetroTabPage();
            this.vl = new MetroFramework.Controls.MetroTrackBar();
            this.tabControl1.SuspendLayout();
            this.Player.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoContainer)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Player);
            this.tabControl1.Controls.Add(this.Media);
            this.tabControl1.Controls.Add(this.Settings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 497);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.UseSelectable = true;
            // 
            // Player
            // 
            this.Player.Controls.Add(this.tableLayoutPanel1);
            this.Player.HorizontalScrollbarBarColor = true;
            this.Player.HorizontalScrollbarHighlightOnWheel = false;
            this.Player.HorizontalScrollbarSize = 10;
            this.Player.Location = new System.Drawing.Point(4, 38);
            this.Player.Name = "Player";
            this.Player.Padding = new System.Windows.Forms.Padding(3);
            this.Player.Size = new System.Drawing.Size(904, 455);
            this.Player.TabIndex = 0;
            this.Player.Text = "Player";
            this.Player.UseVisualStyleBackColor = true;
            this.Player.VerticalScrollbarBarColor = true;
            this.Player.VerticalScrollbarHighlightOnWheel = false;
            this.Player.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.VideoContainer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.VideoProgressBar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.01087F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.98913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(898, 449);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // VideoContainer
            // 
            this.VideoContainer.BackColor = System.Drawing.Color.SteelBlue;
            this.VideoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoContainer.Location = new System.Drawing.Point(3, 3);
            this.VideoContainer.Name = "VideoContainer";
            this.VideoContainer.Size = new System.Drawing.Size(892, 351);
            this.VideoContainer.TabIndex = 0;
            this.VideoContainer.TabStop = false;
            // 
            // VideoProgressBar
            // 
            this.VideoProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoProgressBar.Location = new System.Drawing.Point(3, 360);
            this.VideoProgressBar.Name = "VideoProgressBar";
            this.VideoProgressBar.Size = new System.Drawing.Size(892, 5);
            this.VideoProgressBar.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.Previous, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Stop, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Pause, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Play, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Next, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 371);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(892, 75);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.Volume, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Replay, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(693, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(196, 69);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // Volume
            // 
            this.Volume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Volume.Location = new System.Drawing.Point(3, 3);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(190, 28);
            this.Volume.TabIndex = 0;
            this.Volume.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // Replay
            // 
            this.Replay.AutoSize = true;
            this.Replay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Replay.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.Replay.Location = new System.Drawing.Point(3, 37);
            this.Replay.Name = "Replay";
            this.Replay.Size = new System.Drawing.Size(190, 29);
            this.Replay.TabIndex = 1;
            this.Replay.Text = "Replay";
            this.Replay.UseSelectable = true;
            // 
            // Previous
            // 
            this.Previous.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Previous.Location = new System.Drawing.Point(3, 3);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(132, 69);
            this.Previous.TabIndex = 1;
            this.Previous.Text = "Previous";
            this.Previous.UseSelectable = true;
            // 
            // Stop
            // 
            this.Stop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stop.Location = new System.Drawing.Point(141, 3);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(132, 69);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Stop";
            this.Stop.UseSelectable = true;
            // 
            // Pause
            // 
            this.Pause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pause.Location = new System.Drawing.Point(279, 3);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(132, 69);
            this.Pause.TabIndex = 3;
            this.Pause.Text = "Pause";
            this.Pause.UseSelectable = true;
            // 
            // Play
            // 
            this.Play.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Play.Location = new System.Drawing.Point(417, 3);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(132, 69);
            this.Play.TabIndex = 4;
            this.Play.Text = "Play";
            this.Play.UseSelectable = true;
            // 
            // Next
            // 
            this.Next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Next.Location = new System.Drawing.Point(555, 3);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(132, 69);
            this.Next.TabIndex = 5;
            this.Next.Text = "Next";
            this.Next.UseSelectable = true;
            // 
            // Media
            // 
            this.Media.HorizontalScrollbarBarColor = true;
            this.Media.HorizontalScrollbarHighlightOnWheel = false;
            this.Media.HorizontalScrollbarSize = 10;
            this.Media.Location = new System.Drawing.Point(4, 38);
            this.Media.Name = "Media";
            this.Media.Padding = new System.Windows.Forms.Padding(3);
            this.Media.Size = new System.Drawing.Size(904, 455);
            this.Media.TabIndex = 1;
            this.Media.Text = "Media";
            this.Media.UseVisualStyleBackColor = true;
            this.Media.VerticalScrollbarBarColor = true;
            this.Media.VerticalScrollbarHighlightOnWheel = false;
            this.Media.VerticalScrollbarSize = 10;
            // 
            // Settings
            // 
            this.Settings.HorizontalScrollbarBarColor = true;
            this.Settings.HorizontalScrollbarHighlightOnWheel = false;
            this.Settings.HorizontalScrollbarSize = 10;
            this.Settings.Location = new System.Drawing.Point(4, 38);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(904, 455);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.VerticalScrollbarBarColor = true;
            this.Settings.VerticalScrollbarHighlightOnWheel = false;
            this.Settings.VerticalScrollbarSize = 10;
            // 
            // vl
            // 
            this.vl.BackColor = System.Drawing.Color.Transparent;
            this.vl.Location = new System.Drawing.Point(0, 0);
            this.vl.Name = "vl";
            this.vl.Size = new System.Drawing.Size(0, 0);
            this.vl.TabIndex = 0;
            this.vl.Value = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 577);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "VideoPlay";
            this.tabControl1.ResumeLayout(false);
            this.Player.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VideoContainer)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl1;
        private MetroFramework.Controls.MetroTabPage Player;
        private MetroFramework.Controls.MetroTabPage Media;
        private MetroFramework.Controls.MetroTabPage Settings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox VideoContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroProgressBar VideoProgressBar;
        private System.Windows.Forms.TrackBar Volume;
        private MetroFramework.Controls.MetroTrackBar vl;
        private MetroFramework.Controls.MetroCheckBox Replay;
        private MetroFramework.Controls.MetroButton Previous;
        private MetroFramework.Controls.MetroButton Stop;
        private MetroFramework.Controls.MetroButton Pause;
        private MetroFramework.Controls.MetroButton Play;
        private MetroFramework.Controls.MetroButton Next;

    }
}

