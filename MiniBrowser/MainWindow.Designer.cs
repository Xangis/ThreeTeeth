using System.Windows.Forms;

namespace ThreeTeeth
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtUrlBar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBookmark = new System.Windows.Forms.Button();
            this.cbBookmarks = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnViewSource = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 68);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1049, 629);
            this.webBrowser1.TabIndex = 10;
            // 
            // txtUrlBar
            // 
            this.txtUrlBar.Location = new System.Drawing.Point(4, 34);
            this.txtUrlBar.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrlBar.Name = "txtUrlBar";
            this.txtUrlBar.Size = new System.Drawing.Size(1008, 22);
            this.txtUrlBar.TabIndex = 1;
            this.txtUrlBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrlBar_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBookmark);
            this.panel1.Controls.Add(this.cbBookmarks);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.btnViewSource);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.txtUrlBar);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnForward);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 64);
            this.panel1.TabIndex = 8;
            // 
            // btnBookmark
            // 
            this.btnBookmark.Image = ((System.Drawing.Image)(resources.GetObject("btnBookmark.Image")));
            this.btnBookmark.Location = new System.Drawing.Point(610, 0);
            this.btnBookmark.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookmark.Name = "btnBookmark";
            this.btnBookmark.Size = new System.Drawing.Size(29, 27);
            this.btnBookmark.TabIndex = 13;
            this.btnBookmark.UseVisualStyleBackColor = true;
            this.btnBookmark.Click += new System.EventHandler(this.btnBookmark_Click);
            // 
            // cbBookmarks
            // 
            this.cbBookmarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBookmarks.FormattingEnabled = true;
            this.cbBookmarks.Location = new System.Drawing.Point(335, 0);
            this.cbBookmarks.Name = "cbBookmarks";
            this.cbBookmarks.Size = new System.Drawing.Size(268, 26);
            this.cbBookmarks.TabIndex = 12;
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::ThreeTeeth.Properties.Resources.openfolder_orange;
            this.btnOpen.Location = new System.Drawing.Point(176, 0);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(29, 27);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::ThreeTeeth.Properties.Resources.home;
            this.btnHome.Location = new System.Drawing.Point(141, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(29, 27);
            this.btnHome.TabIndex = 7;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Image = global::ThreeTeeth.Properties.Resources.question2;
            this.btnAbout.Location = new System.Drawing.Point(299, 0);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(29, 27);
            this.btnAbout.TabIndex = 11;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnViewSource
            // 
            this.btnViewSource.Image = global::ThreeTeeth.Properties.Resources.code;
            this.btnViewSource.Location = new System.Drawing.Point(243, 0);
            this.btnViewSource.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewSource.Name = "btnViewSource";
            this.btnViewSource.Size = new System.Drawing.Size(51, 27);
            this.btnViewSource.TabIndex = 10;
            this.btnViewSource.UseVisualStyleBackColor = true;
            this.btnViewSource.Click += new System.EventHandler(this.btnViewSource_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::ThreeTeeth.Properties.Resources.icon_print;
            this.btnPrint.Location = new System.Drawing.Point(208, 0);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(29, 27);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnGo
            // 
            this.btnGo.Image = global::ThreeTeeth.Properties.Resources.right;
            this.btnGo.Location = new System.Drawing.Point(1016, 31);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(29, 27);
            this.btnGo.TabIndex = 2;
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::ThreeTeeth.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(107, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(29, 27);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::ThreeTeeth.Properties.Resources.left;
            this.btnBack.Location = new System.Drawing.Point(4, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 27);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::ThreeTeeth.Properties.Resources.stop2;
            this.btnStop.Location = new System.Drawing.Point(72, 0);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(29, 27);
            this.btnStop.TabIndex = 5;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnForward
            // 
            this.btnForward.Image = global::ThreeTeeth.Properties.Resources.right;
            this.btnForward.Location = new System.Drawing.Point(37, 0);
            this.btnForward.Margin = new System.Windows.Forms.Padding(4);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(29, 27);
            this.btnForward.TabIndex = 4;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 697);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(660, 440);
            this.Name = "MainWindow";
            this.Text = "ThreeTeeth Browser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txtUrlBar;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRefresh;
        private Panel panel1;
        private Button btnViewSource;
        private Button btnPrint;
        private Button btnAbout;
        private Button btnHome;
        private Button btnOpen;
        private Button btnBookmark;
        private ComboBox cbBookmarks;
    }
}

