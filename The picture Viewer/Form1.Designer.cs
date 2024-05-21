
namespace The_picture_Viewer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListBox_Images = new System.Windows.Forms.ListBox();
            this.btnchoose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.slidebtn = new System.Windows.Forms.Button();
            this.multibtn = new System.Windows.Forms.Button();
            this.singlebtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.exitbtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slideModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(355, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Picture Viewer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ListBox_Images);
            this.panel1.Controls.Add(this.btnchoose);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 247);
            this.panel1.TabIndex = 1;
            // 
            // ListBox_Images
            // 
            this.ListBox_Images.BackColor = System.Drawing.Color.LightGray;
            this.ListBox_Images.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ListBox_Images.FormattingEnabled = true;
            this.ListBox_Images.ItemHeight = 29;
            this.ListBox_Images.Location = new System.Drawing.Point(5, 61);
            this.ListBox_Images.Name = "ListBox_Images";
            this.ListBox_Images.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox_Images.Size = new System.Drawing.Size(303, 178);
            this.ListBox_Images.TabIndex = 1;
            this.toolTip1.SetToolTip(this.ListBox_Images, "please, select photos");
            // 
            // btnchoose
            // 
            this.btnchoose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnchoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnchoose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnchoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnchoose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnchoose.Location = new System.Drawing.Point(5, 2);
            this.btnchoose.Name = "btnchoose";
            this.btnchoose.Size = new System.Drawing.Size(302, 54);
            this.btnchoose.TabIndex = 0;
            this.btnchoose.Text = "Select Images";
            this.toolTip1.SetToolTip(this.btnchoose, "press to select photos from your pc");
            this.btnchoose.UseVisualStyleBackColor = false;
            this.btnchoose.Click += new System.EventHandler(this.btnchoose_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.slidebtn);
            this.panel2.Controls.Add(this.multibtn);
            this.panel2.Controls.Add(this.singlebtn);
            this.panel2.Location = new System.Drawing.Point(12, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 176);
            this.panel2.TabIndex = 2;
            // 
            // slidebtn
            // 
            this.slidebtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.slidebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slidebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slidebtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.slidebtn.Location = new System.Drawing.Point(5, 84);
            this.slidebtn.Name = "slidebtn";
            this.slidebtn.Size = new System.Drawing.Size(301, 36);
            this.slidebtn.TabIndex = 2;
            this.slidebtn.Text = "Slide Show Mode";
            this.toolTip1.SetToolTip(this.slidebtn, "show photos sequentially");
            this.slidebtn.UseVisualStyleBackColor = false;
            this.slidebtn.Click += new System.EventHandler(this.slidebtn_Click);
            // 
            // multibtn
            // 
            this.multibtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.multibtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multibtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multibtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.multibtn.Location = new System.Drawing.Point(5, 45);
            this.multibtn.Name = "multibtn";
            this.multibtn.Size = new System.Drawing.Size(301, 37);
            this.multibtn.TabIndex = 1;
            this.multibtn.Text = "Multi  Mode";
            this.toolTip1.SetToolTip(this.multibtn, "show multi photos");
            this.multibtn.UseVisualStyleBackColor = false;
            this.multibtn.Click += new System.EventHandler(this.multibtn_Click);
            // 
            // singlebtn
            // 
            this.singlebtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.singlebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.singlebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.singlebtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.singlebtn.Location = new System.Drawing.Point(5, 5);
            this.singlebtn.Name = "singlebtn";
            this.singlebtn.Size = new System.Drawing.Size(301, 38);
            this.singlebtn.TabIndex = 0;
            this.singlebtn.Text = "Single Mode";
            this.toolTip1.SetToolTip(this.singlebtn, "show single photo");
            this.singlebtn.UseVisualStyleBackColor = false;
            this.singlebtn.Click += new System.EventHandler(this.singlebtn_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Location = new System.Drawing.Point(338, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 410);
            this.panel3.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusBar1
            // 
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusBar1.Location = new System.Drawing.Point(339, 469);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(599, 26);
            this.statusBar1.TabIndex = 4;
            this.statusBar1.UseWaitCursor = true;
            this.statusBar1.Visible = false;
            this.statusBar1.PanelClick += new System.Windows.Forms.StatusBarPanelClickEventHandler(this.statusBar1_PanelClick);
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Width = 1000;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Firebrick;
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitbtn.Location = new System.Drawing.Point(18, 447);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(301, 46);
            this.exitbtn.TabIndex = 3;
            this.exitbtn.Text = "EXIT";
            this.toolTip1.SetToolTip(this.exitbtn, "exit program");
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectImagesToolStripMenuItem,
            this.selectModeToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening_1);
            // 
            // selectImagesToolStripMenuItem
            // 
            this.selectImagesToolStripMenuItem.Name = "selectImagesToolStripMenuItem";
            this.selectImagesToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.selectImagesToolStripMenuItem.Text = "Select Images";
            this.selectImagesToolStripMenuItem.Click += new System.EventHandler(this.btnchoose_Click);
            // 
            // selectModeToolStripMenuItem
            // 
            this.selectModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleModeToolStripMenuItem,
            this.multiModeToolStripMenuItem,
            this.slideModeToolStripMenuItem});
            this.selectModeToolStripMenuItem.Name = "selectModeToolStripMenuItem";
            this.selectModeToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.selectModeToolStripMenuItem.Text = "Select Mode";
            // 
            // singleModeToolStripMenuItem
            // 
            this.singleModeToolStripMenuItem.Name = "singleModeToolStripMenuItem";
            this.singleModeToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.singleModeToolStripMenuItem.Text = "Single Mode";
            this.singleModeToolStripMenuItem.Click += new System.EventHandler(this.singlebtn_Click);
            // 
            // multiModeToolStripMenuItem
            // 
            this.multiModeToolStripMenuItem.Name = "multiModeToolStripMenuItem";
            this.multiModeToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.multiModeToolStripMenuItem.Text = "Multi Mode";
            this.multiModeToolStripMenuItem.Click += new System.EventHandler(this.multibtn_Click);
            // 
            // slideModeToolStripMenuItem
            // 
            this.slideModeToolStripMenuItem.Name = "slideModeToolStripMenuItem";
            this.slideModeToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.slideModeToolStripMenuItem.Text = "Slide Mode";
            this.slideModeToolStripMenuItem.Click += new System.EventHandler(this.slidebtn_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(948, 504);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnchoose;
        private System.Windows.Forms.ListBox ListBox_Images;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button singlebtn;
        private System.Windows.Forms.Button multibtn;
        private System.Windows.Forms.Button slidebtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slideModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
    }
}

