using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
     public partial class NewTabFunctionality : UserControl
     {
          Stack<String> backLinks = new Stack<string>();
          Stack<String> forwardLinks = new Stack<string>();
          String current = null;
          public NewTabFunctionality()
          {
               InitializeComponent();
          }

          private void goToolStripButton_Click(object sender, EventArgs e)
          {
               if (current != null)
               {
                    backLinks.Push(current);
               }
               webBrowser.Navigate(toolStripTextBox.Text);
               current = toolStripTextBox.Text;
          }

          private void toolStripTextBox_KeyDown(object sender, KeyEventArgs e)
          {
               if (e.KeyCode == Keys.Enter)
               {
                    goToolStripButton_Click(sender, e);
               }
          }

          private void backToolStripButton_Click(object sender, EventArgs e)
          {
               forwardLinks.Push(current);
               current = backLinks.Pop();
               webBrowser.Navigate(current);
          }

          private void forwardToolStripButton_Click(object sender, EventArgs e)
          {
               backLinks.Push(current);
               current = forwardLinks.Pop();
               webBrowser.Navigate(current);
          }

          private void refreshToolStripButton_Click(object sender, EventArgs e)
          {
               webBrowser.Navigate(current);
          }

          private void bookmarkToolStripButton_Click(object sender, EventArgs e)
          {
               BookmarkItem bookmark = new BookmarkItem();
               bookmark.Title = webBrowser.DocumentTitle;
               bookmark.URL = webBrowser.Url.ToString();
               BookmarkManager.AddBookmarkItem(bookmark);
          }

          private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
          {
               
               HistoryItem item = new HistoryItem();
               item.Title = webBrowser.DocumentTitle;
               item.URL = toolStripTextBox.Text;
               item.Date = DateTime.Now;
               List<HistoryItem> historyItems = HistoryManager.GetHistoryItems();
               if (!(historyItems.Count == 0))
               {
                    if (!historyItems.Last<HistoryItem>().URL.Contains(item.URL))
                    {
                         HistoryManager.AddHistoryItem(item);
                    }
               }
               else
               {
                    HistoryManager.AddHistoryItem(item);
               }
          }

          private void webBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
          {
               
          }

          private void webBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
          {
               
               if ((e.CurrentProgress > 0) && (e.CurrentProgress < e.MaximumProgress))
               {
                    toolStripStatusLabel.Text = "Loading...";
                    toolStripProgressBar.Value = (int)(e.CurrentProgress / e.MaximumProgress * 100);
               }
               if (e.CurrentProgress < 0)
               {
                    toolStripProgressBar.Value = 100;
                    toolStripStatusLabel.Text = "Done";
               }
          }
          public void Navigator(object sender, EventArgs e, String url)
          {
               toolStripTextBox.Text = url;
               goToolStripButton_Click(sender, e);
          }
     }
}
