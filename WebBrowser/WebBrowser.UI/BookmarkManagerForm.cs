using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
     public partial class BookmarkManagerForm : Form
     {
          public BookmarkManagerForm()
          {
               InitializeComponent();
          }

          private void BookmarkManagerForm_Load(object sender, EventArgs e)
          {
               var items = BookmarkManager.GetBookmarkItems();
               listBoxBookmarks.Items.Clear();

               foreach (var item in items)
               {
                    listBoxBookmarks.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
               }
          }

          private void toolStripButton2_Click(object sender, EventArgs e)
          {
               BookmarkManager.DeleteBookmarkItem(listBoxBookmarks.SelectedItem.ToString());
               var items = BookmarkManager.GetBookmarkItems();
               listBoxBookmarks.Items.Clear();

               foreach (var item in items)
               {
                    listBoxBookmarks.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
               }
          }

          private void toolStripButtonSearchBookmarks_Click(object sender, EventArgs e)
          {
               List<BookmarkItem> searchedBookmarkItems = BookmarkManager.SearchBookmarks(toolStripTextBoxSearchBookmarks.Text);
               listBoxBookmarks.Items.Clear();

               foreach (BookmarkItem item in searchedBookmarkItems)
               {
                    listBoxBookmarks.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
               }
          }

          private void toolStripButtonGo_Click(object sender, EventArgs e)
          {
               string output;
               char[] delims = { '(', ')' };
               String[] strings = listBoxBookmarks.SelectedItem.ToString().Split(delims);
               output = strings[1];
               BrowserUI browser = new BrowserUI();
               browser.newTabFunctionality1.Navigator(sender, e, output);
               browser.Show();
          }
     }
}
