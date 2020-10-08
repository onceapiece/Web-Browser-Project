namespace WebBrowser.UI
{
     partial class BookmarkManagerForm
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookmarkManagerForm));
               this.listBoxBookmarks = new System.Windows.Forms.ListBox();
               this.toolStripBookmarkManager = new System.Windows.Forms.ToolStrip();
               this.toolStripTextBoxSearchBookmarks = new System.Windows.Forms.ToolStripTextBox();
               this.toolStripButtonSearchBookmarks = new System.Windows.Forms.ToolStripButton();
               this.toolStripLabelSearchBookmarks = new System.Windows.Forms.ToolStripLabel();
               this.toolStripButtonDeleteSelectedBookmark = new System.Windows.Forms.ToolStripButton();
               this.toolStripLabelDeleteBookmark = new System.Windows.Forms.ToolStripLabel();
               this.toolStripButtonGo = new System.Windows.Forms.ToolStripButton();
               this.toolStripLabelGo = new System.Windows.Forms.ToolStripLabel();
               this.toolStripBookmarkManager.SuspendLayout();
               this.SuspendLayout();
               // 
               // listBoxBookmarks
               // 
               this.listBoxBookmarks.Dock = System.Windows.Forms.DockStyle.Fill;
               this.listBoxBookmarks.FormattingEnabled = true;
               this.listBoxBookmarks.Location = new System.Drawing.Point(0, 0);
               this.listBoxBookmarks.Name = "listBoxBookmarks";
               this.listBoxBookmarks.Size = new System.Drawing.Size(800, 450);
               this.listBoxBookmarks.TabIndex = 0;
               // 
               // toolStripBookmarkManager
               // 
               this.toolStripBookmarkManager.BackColor = System.Drawing.SystemColors.ControlDark;
               this.toolStripBookmarkManager.Dock = System.Windows.Forms.DockStyle.Bottom;
               this.toolStripBookmarkManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxSearchBookmarks,
            this.toolStripButtonSearchBookmarks,
            this.toolStripLabelSearchBookmarks,
            this.toolStripButtonDeleteSelectedBookmark,
            this.toolStripLabelDeleteBookmark,
            this.toolStripButtonGo,
            this.toolStripLabelGo});
               this.toolStripBookmarkManager.Location = new System.Drawing.Point(0, 425);
               this.toolStripBookmarkManager.Name = "toolStripBookmarkManager";
               this.toolStripBookmarkManager.Size = new System.Drawing.Size(800, 25);
               this.toolStripBookmarkManager.TabIndex = 1;
               this.toolStripBookmarkManager.Text = "toolStrip1";
               // 
               // toolStripTextBoxSearchBookmarks
               // 
               this.toolStripTextBoxSearchBookmarks.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.toolStripTextBoxSearchBookmarks.Name = "toolStripTextBoxSearchBookmarks";
               this.toolStripTextBoxSearchBookmarks.Size = new System.Drawing.Size(100, 25);
               // 
               // toolStripButtonSearchBookmarks
               // 
               this.toolStripButtonSearchBookmarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.toolStripButtonSearchBookmarks.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearchBookmarks.Image")));
               this.toolStripButtonSearchBookmarks.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.toolStripButtonSearchBookmarks.Name = "toolStripButtonSearchBookmarks";
               this.toolStripButtonSearchBookmarks.Size = new System.Drawing.Size(23, 22);
               this.toolStripButtonSearchBookmarks.Text = "Search";
               this.toolStripButtonSearchBookmarks.Click += new System.EventHandler(this.toolStripButtonSearchBookmarks_Click);
               // 
               // toolStripLabelSearchBookmarks
               // 
               this.toolStripLabelSearchBookmarks.Name = "toolStripLabelSearchBookmarks";
               this.toolStripLabelSearchBookmarks.Size = new System.Drawing.Size(42, 22);
               this.toolStripLabelSearchBookmarks.Text = "Search";
               // 
               // toolStripButtonDeleteSelectedBookmark
               // 
               this.toolStripButtonDeleteSelectedBookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.toolStripButtonDeleteSelectedBookmark.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteSelectedBookmark.Image")));
               this.toolStripButtonDeleteSelectedBookmark.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.toolStripButtonDeleteSelectedBookmark.Name = "toolStripButtonDeleteSelectedBookmark";
               this.toolStripButtonDeleteSelectedBookmark.Size = new System.Drawing.Size(23, 22);
               this.toolStripButtonDeleteSelectedBookmark.Text = "Delete Selected Item";
               this.toolStripButtonDeleteSelectedBookmark.Click += new System.EventHandler(this.toolStripButton2_Click);
               // 
               // toolStripLabelDeleteBookmark
               // 
               this.toolStripLabelDeleteBookmark.Name = "toolStripLabelDeleteBookmark";
               this.toolStripLabelDeleteBookmark.Size = new System.Drawing.Size(40, 22);
               this.toolStripLabelDeleteBookmark.Text = "Delete";
               // 
               // toolStripButtonGo
               // 
               this.toolStripButtonGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.toolStripButtonGo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGo.Image")));
               this.toolStripButtonGo.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.toolStripButtonGo.Name = "toolStripButtonGo";
               this.toolStripButtonGo.Size = new System.Drawing.Size(23, 22);
               this.toolStripButtonGo.Text = "Go";
               this.toolStripButtonGo.Click += new System.EventHandler(this.toolStripButtonGo_Click);
               // 
               // toolStripLabelGo
               // 
               this.toolStripLabelGo.Name = "toolStripLabelGo";
               this.toolStripLabelGo.Size = new System.Drawing.Size(22, 22);
               this.toolStripLabelGo.Text = "Go";
               // 
               // BookmarkManagerForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.toolStripBookmarkManager);
               this.Controls.Add(this.listBoxBookmarks);
               this.Name = "BookmarkManagerForm";
               this.Text = "BookmarkManagerForm";
               this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
               this.toolStripBookmarkManager.ResumeLayout(false);
               this.toolStripBookmarkManager.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.ListBox listBoxBookmarks;
          private System.Windows.Forms.ToolStrip toolStripBookmarkManager;
          private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearchBookmarks;
          private System.Windows.Forms.ToolStripButton toolStripButtonSearchBookmarks;
          private System.Windows.Forms.ToolStripLabel toolStripLabelSearchBookmarks;
          private System.Windows.Forms.ToolStripButton toolStripButtonDeleteSelectedBookmark;
          private System.Windows.Forms.ToolStripLabel toolStripLabelDeleteBookmark;
          private System.Windows.Forms.ToolStripButton toolStripButtonGo;
          private System.Windows.Forms.ToolStripLabel toolStripLabelGo;
     }
}