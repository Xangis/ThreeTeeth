using System.Windows.Forms;

namespace MiniBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.cbSearchProviders = new System.Windows.Forms.ComboBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(689, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearchText);
            this.panel1.Controls.Add(this.cbSearchProviders);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.btnViewSource);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnForward);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 64);
            this.panel1.TabIndex = 8;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::ThreeTeeth.Properties.Resources.home;
            this.btnHome.Location = new System.Drawing.Point(174, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(26, 26);
            this.btnHome.TabIndex = 16;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::ThreeTeeth.Properties.Resources.right;
            this.btnSearch.Location = new System.Drawing.Point(1014, 32);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 26);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(846, 34);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(161, 22);
            this.txtSearchText.TabIndex = 14;
            this.txtSearchText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchText_KeyPress);
            // 
            // cbSearchProviders
            // 
            this.cbSearchProviders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchProviders.FormattingEnabled = true;
            this.cbSearchProviders.Items.AddRange(new object[] {
            "Amazon",
            "eBay"});
            this.cbSearchProviders.Location = new System.Drawing.Point(738, 32);
            this.cbSearchProviders.Name = "cbSearchProviders";
            this.cbSearchProviders.Size = new System.Drawing.Size(102, 24);
            this.cbSearchProviders.TabIndex = 13;
            // 
            // btnAbout
            // 
            this.btnAbout.Image = global::ThreeTeeth.Properties.Resources.question2;
            this.btnAbout.Location = new System.Drawing.Point(264, 0);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(26, 26);
            this.btnAbout.TabIndex = 12;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnViewSource
            // 
            this.btnViewSource.Image = global::ThreeTeeth.Properties.Resources.code;
            this.btnViewSource.Location = new System.Drawing.Point(208, 0);
            this.btnViewSource.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewSource.Name = "btnViewSource";
            this.btnViewSource.Size = new System.Drawing.Size(48, 26);
            this.btnViewSource.TabIndex = 11;
            this.btnViewSource.UseVisualStyleBackColor = true;
            this.btnViewSource.Click += new System.EventHandler(this.btnViewSource_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::ThreeTeeth.Properties.Resources.icon_print;
            this.btnPrint.Location = new System.Drawing.Point(140, 0);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(26, 26);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnGo
            // 
            this.btnGo.Image = global::ThreeTeeth.Properties.Resources.right;
            this.btnGo.Location = new System.Drawing.Point(701, 32);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(30, 26);
            this.btnGo.TabIndex = 9;
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::ThreeTeeth.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(106, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(26, 26);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::ThreeTeeth.Properties.Resources.left;
            this.btnBack.Location = new System.Drawing.Point(4, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(26, 26);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::ThreeTeeth.Properties.Resources.stop2;
            this.btnStop.Location = new System.Drawing.Point(72, 0);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(26, 26);
            this.btnStop.TabIndex = 3;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnForward
            // 
            this.btnForward.Image = global::ThreeTeeth.Properties.Resources.right;
            this.btnForward.Location = new System.Drawing.Point(38, 0);
            this.btnForward.Margin = new System.Windows.Forms.Padding(4);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(26, 26);
            this.btnForward.TabIndex = 2;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 697);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ThreeTeeth Browser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRefresh;
        private Panel panel1;
        private Button btnViewSource;
        private Button btnPrint;
        private Button btnAbout;
        private Button btnSearch;
        private TextBox txtSearchText;
        private ComboBox cbSearchProviders;
        private Button btnHome;
    }
}

