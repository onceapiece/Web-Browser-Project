namespace WebBrowser.UI
{
     partial class NewTabFunctionality
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

          #region Component Designer generated code

          /// <summary> 
          /// Required method for Designer support - do not modify 
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTabFunctionality));
               this.toolStrip = new System.Windows.Forms.ToolStrip();
               this.backToolStripButton = new System.Windows.Forms.ToolStripButton();
               this.backToolStripLabel = new System.Windows.Forms.ToolStripLabel();
               this.forwardToolStripButton = new System.Windows.Forms.ToolStripButton();
               this.forwardToolStripLabel = new System.Windows.Forms.ToolStripLabel();
               this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
               this.refreshToolStripLabel = new System.Windows.Forms.ToolStripLabel();
               this.homeToolStripButton = new System.Windows.Forms.ToolStripButton();
               this.homeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
               this.toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
               this.goToolStripButton = new System.Windows.Forms.ToolStripButton();
               this.goToolStripLabel = new System.Windows.Forms.ToolStripLabel();
               this.bookmarkToolStripButton = new System.Windows.Forms.ToolStripButton();
               this.bookmarkToolStripLabel = new System.Windows.Forms.ToolStripLabel();
               this.webBrowser = new System.Windows.Forms.WebBrowser();
               this.statusStripLoading = new System.Windows.Forms.StatusStrip();
               this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
               this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
               this.toolStrip.SuspendLayout();
               this.statusStripLoading.SuspendLayout();
               this.SuspendLayout();
               // 
               // toolStrip
               // 
               this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripButton,
            this.backToolStripLabel,
            this.forwardToolStripButton,
            this.forwardToolStripLabel,
            this.refreshToolStripButton,
            this.refreshToolStripLabel,
            this.homeToolStripButton,
            this.homeToolStripLabel,
            this.toolStripTextBox,
            this.goToolStripButton,
            this.goToolStripLabel,
            this.bookmarkToolStripButton,
            this.bookmarkToolStripLabel});
               this.toolStrip.Location = new System.Drawing.Point(0, 0);
               this.toolStrip.Name = "toolStrip";
               this.toolStrip.Size = new System.Drawing.Size(615, 25);
               this.toolStrip.TabIndex = 0;
               this.toolStrip.Text = "toolStrip1";
               // 
               // backToolStripButton
               // 
               this.backToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.backToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("backToolStripButton.Image")));
               this.backToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.backToolStripButton.Name = "backToolStripButton";
               this.backToolStripButton.Size = new System.Drawing.Size(23, 22);
               this.backToolStripButton.Text = "Back";
               this.backToolStripButton.Click += new System.EventHandler(this.backToolStripButton_Click);
               // 
               // backToolStripLabel
               // 
               this.backToolStripLabel.Name = "backToolStripLabel";
               this.backToolStripLabel.Size = new System.Drawing.Size(32, 22);
               this.backToolStripLabel.Text = "Back";
               // 
               // forwardToolStripButton
               // 
               this.forwardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.forwardToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("forwardToolStripButton.Image")));
               this.forwardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.forwardToolStripButton.Name = "forwardToolStripButton";
               this.forwardToolStripButton.Size = new System.Drawing.Size(23, 22);
               this.forwardToolStripButton.Text = "Forward";
               this.forwardToolStripButton.Click += new System.EventHandler(this.forwardToolStripButton_Click);
               // 
               // forwardToolStripLabel
               // 
               this.forwardToolStripLabel.Name = "forwardToolStripLabel";
               this.forwardToolStripLabel.Size = new System.Drawing.Size(50, 22);
               this.forwardToolStripLabel.Text = "Forward";
               // 
               // refreshToolStripButton
               // 
               this.refreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.refreshToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripButton.Image")));
               this.refreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.refreshToolStripButton.Name = "refreshToolStripButton";
               this.refreshToolStripButton.Size = new System.Drawing.Size(23, 22);
               this.refreshToolStripButton.Text = "Refresh";
               this.refreshToolStripButton.Click += new System.EventHandler(this.refreshToolStripButton_Click);
               // 
               // refreshToolStripLabel
               // 
               this.refreshToolStripLabel.Name = "refreshToolStripLabel";
               this.refreshToolStripLabel.Size = new System.Drawing.Size(46, 22);
               this.refreshToolStripLabel.Text = "Refresh";
               // 
               // homeToolStripButton
               // 
               this.homeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.homeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripButton.Image")));
               this.homeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.homeToolStripButton.Name = "homeToolStripButton";
               this.homeToolStripButton.Size = new System.Drawing.Size(23, 22);
               this.homeToolStripButton.Text = "Home";
               // 
               // homeToolStripLabel
               // 
               this.homeToolStripLabel.Name = "homeToolStripLabel";
               this.homeToolStripLabel.Size = new System.Drawing.Size(40, 22);
               this.homeToolStripLabel.Text = "Home";
               // 
               // toolStripTextBox
               // 
               this.toolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.toolStripTextBox.Name = "toolStripTextBox";
               this.toolStripTextBox.Size = new System.Drawing.Size(100, 25);
               this.toolStripTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox_KeyDown);
               // 
               // goToolStripButton
               // 
               this.goToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.goToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("goToolStripButton.Image")));
               this.goToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.goToolStripButton.Name = "goToolStripButton";
               this.goToolStripButton.Size = new System.Drawing.Size(23, 22);
               this.goToolStripButton.Text = "Go";
               this.goToolStripButton.Click += new System.EventHandler(this.goToolStripButton_Click);
               // 
               // goToolStripLabel
               // 
               this.goToolStripLabel.Name = "goToolStripLabel";
               this.goToolStripLabel.Size = new System.Drawing.Size(22, 22);
               this.goToolStripLabel.Text = "Go";
               // 
               // bookmarkToolStripButton
               // 
               this.bookmarkToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.bookmarkToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("bookmarkToolStripButton.Image")));
               this.bookmarkToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.bookmarkToolStripButton.Name = "bookmarkToolStripButton";
               this.bookmarkToolStripButton.Size = new System.Drawing.Size(23, 22);
               this.bookmarkToolStripButton.Text = "Bookmark";
               this.bookmarkToolStripButton.Click += new System.EventHandler(this.bookmarkToolStripButton_Click);
               // 
               // bookmarkToolStripLabel
               // 
               this.bookmarkToolStripLabel.Name = "bookmarkToolStripLabel";
               this.bookmarkToolStripLabel.Size = new System.Drawing.Size(61, 22);
               this.bookmarkToolStripLabel.Text = "Bookmark";
               // 
               // webBrowser
               // 
               this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
               this.webBrowser.Location = new System.Drawing.Point(0, 25);
               this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
               this.webBrowser.Name = "webBrowser";
               this.webBrowser.Size = new System.Drawing.Size(615, 318);
               this.webBrowser.TabIndex = 1;
               this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
               this.webBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser_Navigating);
               this.webBrowser.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser_ProgressChanged);
               // 
               // statusStripLoading
               // 
               this.statusStripLoading.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel});
               this.statusStripLoading.Location = new System.Drawing.Point(0, 321);
               this.statusStripLoading.Name = "statusStripLoading";
               this.statusStripLoading.Size = new System.Drawing.Size(615, 22);
               this.statusStripLoading.TabIndex = 2;
               this.statusStripLoading.Text = "statusStrip1";
               // 
               // toolStripProgressBar
               // 
               this.toolStripProgressBar.Name = "toolStripProgressBar";
               this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
               this.toolStripProgressBar.Step = 1;
               // 
               // toolStripStatusLabel
               // 
               this.toolStripStatusLabel.Name = "toolStripStatusLabel";
               this.toolStripStatusLabel.Size = new System.Drawing.Size(34, 17);
               this.toolStripStatusLabel.Text = "done";
               // 
               // NewTabFunctionality
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.statusStripLoading);
               this.Controls.Add(this.webBrowser);
               this.Controls.Add(this.toolStrip);
               this.Name = "NewTabFunctionality";
               this.Size = new System.Drawing.Size(615, 343);
               this.toolStrip.ResumeLayout(false);
               this.toolStrip.PerformLayout();
               this.statusStripLoading.ResumeLayout(false);
               this.statusStripLoading.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.ToolStrip toolStrip;
          private System.Windows.Forms.WebBrowser webBrowser;
          private System.Windows.Forms.ToolStripButton backToolStripButton;
          private System.Windows.Forms.ToolStripLabel backToolStripLabel;
          private System.Windows.Forms.ToolStripButton forwardToolStripButton;
          private System.Windows.Forms.ToolStripLabel forwardToolStripLabel;
          private System.Windows.Forms.ToolStripButton refreshToolStripButton;
          private System.Windows.Forms.ToolStripLabel refreshToolStripLabel;
          private System.Windows.Forms.ToolStripButton homeToolStripButton;
          private System.Windows.Forms.ToolStripLabel homeToolStripLabel;
          private System.Windows.Forms.ToolStripTextBox toolStripTextBox;
          private System.Windows.Forms.ToolStripButton goToolStripButton;
          private System.Windows.Forms.ToolStripLabel goToolStripLabel;
          private System.Windows.Forms.ToolStripButton bookmarkToolStripButton;
          private System.Windows.Forms.ToolStripLabel bookmarkToolStripLabel;
          private System.Windows.Forms.StatusStrip statusStripLoading;
          private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
          private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
     }
}
