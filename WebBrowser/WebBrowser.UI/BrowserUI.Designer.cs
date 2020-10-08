﻿namespace WebBrowser.UI
{
     partial class BrowserUI
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
               this.menuStrip1 = new System.Windows.Forms.MenuStrip();
               this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.closeCurrentTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.savePageAsHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.printPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.exitWebBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.manageHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.manageBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.clearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.tabControl = new System.Windows.Forms.TabControl();
               this.tabPage1 = new System.Windows.Forms.TabPage();
               this.newTabFunctionality1 = new WebBrowser.UI.NewTabFunctionality();
               this.menuStrip1.SuspendLayout();
               this.tabControl.SuspendLayout();
               this.tabPage1.SuspendLayout();
               this.SuspendLayout();
               // 
               // menuStrip1
               // 
               this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
               this.menuStrip1.Location = new System.Drawing.Point(0, 0);
               this.menuStrip1.Name = "menuStrip1";
               this.menuStrip1.Size = new System.Drawing.Size(806, 24);
               this.menuStrip1.TabIndex = 0;
               this.menuStrip1.Text = "menuStrip1";
               // 
               // fileToolStripMenuItem
               // 
               this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem,
            this.closeCurrentTabToolStripMenuItem,
            this.savePageAsHTMLToolStripMenuItem,
            this.printPageToolStripMenuItem,
            this.exitWebBrowserToolStripMenuItem});
               this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
               this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
               this.fileToolStripMenuItem.Text = "File";
               // 
               // newTabToolStripMenuItem
               // 
               this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
               this.newTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
               this.newTabToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
               this.newTabToolStripMenuItem.Text = "New Tab";
               this.newTabToolStripMenuItem.Click += new System.EventHandler(this.newTabToolStripMenuItem_Click);
               // 
               // closeCurrentTabToolStripMenuItem
               // 
               this.closeCurrentTabToolStripMenuItem.Name = "closeCurrentTabToolStripMenuItem";
               this.closeCurrentTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
               this.closeCurrentTabToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
               this.closeCurrentTabToolStripMenuItem.Text = "Close Current Tab";
               this.closeCurrentTabToolStripMenuItem.Click += new System.EventHandler(this.closeCurrentTabToolStripMenuItem_Click);
               // 
               // savePageAsHTMLToolStripMenuItem
               // 
               this.savePageAsHTMLToolStripMenuItem.Name = "savePageAsHTMLToolStripMenuItem";
               this.savePageAsHTMLToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
               this.savePageAsHTMLToolStripMenuItem.Text = "Save Page as HTML";
               // 
               // printPageToolStripMenuItem
               // 
               this.printPageToolStripMenuItem.Name = "printPageToolStripMenuItem";
               this.printPageToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
               this.printPageToolStripMenuItem.Text = "Print Page";
               // 
               // exitWebBrowserToolStripMenuItem
               // 
               this.exitWebBrowserToolStripMenuItem.Name = "exitWebBrowserToolStripMenuItem";
               this.exitWebBrowserToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
               this.exitWebBrowserToolStripMenuItem.Text = "Exit Web Browser";
               this.exitWebBrowserToolStripMenuItem.Click += new System.EventHandler(this.exitWebBrowserToolStripMenuItem_Click);
               // 
               // toolsToolStripMenuItem
               // 
               this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageHistoryToolStripMenuItem,
            this.manageBookmarksToolStripMenuItem,
            this.clearHistoryToolStripMenuItem});
               this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
               this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
               this.toolsToolStripMenuItem.Text = "Tools";
               // 
               // manageHistoryToolStripMenuItem
               // 
               this.manageHistoryToolStripMenuItem.Name = "manageHistoryToolStripMenuItem";
               this.manageHistoryToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
               this.manageHistoryToolStripMenuItem.Text = "Manage History";
               this.manageHistoryToolStripMenuItem.Click += new System.EventHandler(this.manageHistoryToolStripMenuItem_Click);
               // 
               // manageBookmarksToolStripMenuItem
               // 
               this.manageBookmarksToolStripMenuItem.Name = "manageBookmarksToolStripMenuItem";
               this.manageBookmarksToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
               this.manageBookmarksToolStripMenuItem.Text = "Manage Bookmarks";
               this.manageBookmarksToolStripMenuItem.Click += new System.EventHandler(this.manageBookmarksToolStripMenuItem_Click);
               // 
               // clearHistoryToolStripMenuItem
               // 
               this.clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
               this.clearHistoryToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
               this.clearHistoryToolStripMenuItem.Text = "Clear History";
               this.clearHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearHistoryToolStripMenuItem_Click);
               // 
               // helpToolStripMenuItem
               // 
               this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
               this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
               this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
               this.helpToolStripMenuItem.Text = "Help";
               // 
               // aboutToolStripMenuItem
               // 
               this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
               this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
               this.aboutToolStripMenuItem.Text = "About";
               this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
               // 
               // tabControl
               // 
               this.tabControl.Controls.Add(this.tabPage1);
               this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
               this.tabControl.Location = new System.Drawing.Point(0, 24);
               this.tabControl.Name = "tabControl";
               this.tabControl.SelectedIndex = 0;
               this.tabControl.Size = new System.Drawing.Size(806, 429);
               this.tabControl.TabIndex = 1;
               // 
               // tabPage1
               // 
               this.tabPage1.Controls.Add(this.newTabFunctionality1);
               this.tabPage1.Location = new System.Drawing.Point(4, 22);
               this.tabPage1.Name = "tabPage1";
               this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
               this.tabPage1.Size = new System.Drawing.Size(798, 403);
               this.tabPage1.TabIndex = 0;
               this.tabPage1.Text = "tabPage1";
               this.tabPage1.UseVisualStyleBackColor = true;
               // 
               // newTabFunctionality1
               // 
               this.newTabFunctionality1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.newTabFunctionality1.Location = new System.Drawing.Point(3, 3);
               this.newTabFunctionality1.Name = "newTabFunctionality1";
               this.newTabFunctionality1.Size = new System.Drawing.Size(792, 397);
               this.newTabFunctionality1.TabIndex = 0;
               this.newTabFunctionality1.Load += new System.EventHandler(this.newTabFunctionality1_Load);
               // 
               // BrowserUI
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(806, 453);
               this.Controls.Add(this.tabControl);
               this.Controls.Add(this.menuStrip1);
               this.MainMenuStrip = this.menuStrip1;
               this.Name = "BrowserUI";
               this.Text = "BrowserUI";
               this.menuStrip1.ResumeLayout(false);
               this.menuStrip1.PerformLayout();
               this.tabControl.ResumeLayout(false);
               this.tabPage1.ResumeLayout(false);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.MenuStrip menuStrip1;
          private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem closeCurrentTabToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem savePageAsHTMLToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem printPageToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem exitWebBrowserToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem manageHistoryToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem manageBookmarksToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
          private System.Windows.Forms.TabControl tabControl;
          private System.Windows.Forms.TabPage tabPage1;
          private System.Windows.Forms.ToolStripMenuItem clearHistoryToolStripMenuItem;
          public NewTabFunctionality newTabFunctionality1;
     }
}