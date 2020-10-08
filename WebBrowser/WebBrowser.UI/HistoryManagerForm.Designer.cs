namespace WebBrowser.UI
{
     partial class HistoryManagerForm
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryManagerForm));
               this.listBoxHistory = new System.Windows.Forms.ListBox();
               this.toolStripHistory = new System.Windows.Forms.ToolStrip();
               this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
               this.toolStripButtonSearchHistory = new System.Windows.Forms.ToolStripButton();
               this.toolStripLabelSearchHistory = new System.Windows.Forms.ToolStripLabel();
               this.toolStripButtonDeleteHistoryItem = new System.Windows.Forms.ToolStripButton();
               this.toolStripLabelDeleteHistoryItem = new System.Windows.Forms.ToolStripLabel();
               this.toolStripButtonDeleteAllHistory = new System.Windows.Forms.ToolStripButton();
               this.toolStripLabelDeleteAllHistory = new System.Windows.Forms.ToolStripLabel();
               this.toolStripButtonGo = new System.Windows.Forms.ToolStripButton();
               this.toolStripLabelGo = new System.Windows.Forms.ToolStripLabel();
               this.toolStripHistory.SuspendLayout();
               this.SuspendLayout();
               // 
               // listBoxHistory
               // 
               this.listBoxHistory.Dock = System.Windows.Forms.DockStyle.Fill;
               this.listBoxHistory.FormattingEnabled = true;
               this.listBoxHistory.Location = new System.Drawing.Point(0, 0);
               this.listBoxHistory.Name = "listBoxHistory";
               this.listBoxHistory.Size = new System.Drawing.Size(800, 450);
               this.listBoxHistory.TabIndex = 0;
               // 
               // toolStripHistory
               // 
               this.toolStripHistory.BackColor = System.Drawing.SystemColors.ControlDark;
               this.toolStripHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
               this.toolStripHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxSearch,
            this.toolStripButtonSearchHistory,
            this.toolStripLabelSearchHistory,
            this.toolStripButtonDeleteHistoryItem,
            this.toolStripLabelDeleteHistoryItem,
            this.toolStripButtonDeleteAllHistory,
            this.toolStripLabelDeleteAllHistory,
            this.toolStripButtonGo,
            this.toolStripLabelGo});
               this.toolStripHistory.Location = new System.Drawing.Point(0, 425);
               this.toolStripHistory.Name = "toolStripHistory";
               this.toolStripHistory.Size = new System.Drawing.Size(800, 25);
               this.toolStripHistory.TabIndex = 1;
               this.toolStripHistory.Text = "toolStrip1";
               // 
               // toolStripTextBoxSearch
               // 
               this.toolStripTextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
               this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
               this.toolStripTextBoxSearch.Size = new System.Drawing.Size(100, 25);
               // 
               // toolStripButtonSearchHistory
               // 
               this.toolStripButtonSearchHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.toolStripButtonSearchHistory.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearchHistory.Image")));
               this.toolStripButtonSearchHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.toolStripButtonSearchHistory.Name = "toolStripButtonSearchHistory";
               this.toolStripButtonSearchHistory.Size = new System.Drawing.Size(23, 22);
               this.toolStripButtonSearchHistory.Text = "toolStripButtonSearchHistory";
               this.toolStripButtonSearchHistory.Click += new System.EventHandler(this.toolStripButtonSearchHistory_Click);
               // 
               // toolStripLabelSearchHistory
               // 
               this.toolStripLabelSearchHistory.Name = "toolStripLabelSearchHistory";
               this.toolStripLabelSearchHistory.Size = new System.Drawing.Size(42, 22);
               this.toolStripLabelSearchHistory.Text = "Search";
               // 
               // toolStripButtonDeleteHistoryItem
               // 
               this.toolStripButtonDeleteHistoryItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.toolStripButtonDeleteHistoryItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteHistoryItem.Image")));
               this.toolStripButtonDeleteHistoryItem.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.toolStripButtonDeleteHistoryItem.Name = "toolStripButtonDeleteHistoryItem";
               this.toolStripButtonDeleteHistoryItem.Size = new System.Drawing.Size(23, 22);
               this.toolStripButtonDeleteHistoryItem.Text = "toolStripButtonDeleteHistoryItem";
               this.toolStripButtonDeleteHistoryItem.Click += new System.EventHandler(this.toolStripButtonDeleteHistoryItem_Click);
               // 
               // toolStripLabelDeleteHistoryItem
               // 
               this.toolStripLabelDeleteHistoryItem.Name = "toolStripLabelDeleteHistoryItem";
               this.toolStripLabelDeleteHistoryItem.Size = new System.Drawing.Size(87, 22);
               this.toolStripLabelDeleteHistoryItem.Text = "Delete Selected";
               // 
               // toolStripButtonDeleteAllHistory
               // 
               this.toolStripButtonDeleteAllHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.toolStripButtonDeleteAllHistory.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteAllHistory.Image")));
               this.toolStripButtonDeleteAllHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.toolStripButtonDeleteAllHistory.Name = "toolStripButtonDeleteAllHistory";
               this.toolStripButtonDeleteAllHistory.Size = new System.Drawing.Size(23, 22);
               this.toolStripButtonDeleteAllHistory.Text = "Delete All";
               this.toolStripButtonDeleteAllHistory.Click += new System.EventHandler(this.toolStripButtonDeleteAllHistory_Click);
               // 
               // toolStripLabelDeleteAllHistory
               // 
               this.toolStripLabelDeleteAllHistory.Name = "toolStripLabelDeleteAllHistory";
               this.toolStripLabelDeleteAllHistory.Size = new System.Drawing.Size(57, 22);
               this.toolStripLabelDeleteAllHistory.Text = "Delete All";
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
               // HistoryManagerForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.toolStripHistory);
               this.Controls.Add(this.listBoxHistory);
               this.Name = "HistoryManagerForm";
               this.Text = "HistoryManagerForm";
               this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
               this.toolStripHistory.ResumeLayout(false);
               this.toolStripHistory.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.ListBox listBoxHistory;
          private System.Windows.Forms.ToolStrip toolStripHistory;
          private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;
          private System.Windows.Forms.ToolStripButton toolStripButtonSearchHistory;
          private System.Windows.Forms.ToolStripLabel toolStripLabelSearchHistory;
          private System.Windows.Forms.ToolStripButton toolStripButtonDeleteHistoryItem;
          private System.Windows.Forms.ToolStripLabel toolStripLabelDeleteHistoryItem;
          private System.Windows.Forms.ToolStripButton toolStripButtonDeleteAllHistory;
          private System.Windows.Forms.ToolStripLabel toolStripLabelDeleteAllHistory;
          private System.Windows.Forms.ToolStripButton toolStripButtonGo;
          private System.Windows.Forms.ToolStripLabel toolStripLabelGo;
     }
}