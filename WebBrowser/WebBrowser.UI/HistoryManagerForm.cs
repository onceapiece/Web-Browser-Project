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
     public partial class HistoryManagerForm : Form
     {
          public HistoryManagerForm()
          {
               InitializeComponent();
          }

          private void HistoryManagerForm_Load(object sender, EventArgs e)
          {
               var items = HistoryManager.GetHistoryItems();
               listBoxHistory.Items.Clear();

               foreach (var item in items)
               {
                    listBoxHistory.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
               }
          }

          private void toolStripButtonDeleteHistoryItem_Click(object sender, EventArgs e)
          {
               HistoryManager.DeleteHistoryItem(listBoxHistory.SelectedItem.ToString());
               var items = HistoryManager.GetHistoryItems();
               listBoxHistory.Items.Clear();

               foreach (var item in items)
               {
                    listBoxHistory.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
               }
          }

          public void toolStripButtonDeleteAllHistory_Click(object sender, EventArgs e)
          {
               HistoryManager.DeleteAllHistory();
               listBoxHistory.Items.Clear();
          }

          private void toolStripButtonSearchHistory_Click(object sender, EventArgs e)
          {
               List<HistoryItem> searchedHistoryItems = HistoryManager.SearchHistory(toolStripTextBoxSearch.Text);
               listBoxHistory.Items.Clear();

               foreach (HistoryItem item in searchedHistoryItems)
               {
                    listBoxHistory.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
               }
          }

          private void toolStripButtonGo_Click(object sender, EventArgs e)
          {
               string output;
               char[] delims = { '(', ')' };
               String[] strings = listBoxHistory.SelectedItem.ToString().Split(delims);
               output = strings[1];
               BrowserUI browser = new BrowserUI();
               browser.newTabFunctionality1.Navigator(sender, e, output);
               browser.Show();
          }
     }
}
