using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
     public partial class BrowserUI : Form
     {
          public BrowserUI()
          {
               InitializeComponent();
          }

          private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }

          private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
          {
               MessageBox.Show("This is a web browser made for class CPSC 2713. My name is Collin Smith, and my ID is ces0155."
                    + " This is my first time creating a web browser.");
          }

          private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
          {
               TabPage newTab = new TabPage();
               NewTabFunctionality functionality = new NewTabFunctionality();
               functionality.Dock = tabControl.Dock;
               newTab.Controls.Add(functionality);
               tabControl.TabPages.Add(newTab);
          }

          private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
          {
               tabControl.TabPages.Remove(tabControl.SelectedTab);
          }

          private void newTabFunctionality1_Load(object sender, EventArgs e)
          {

          }

          private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
          {
               HistoryManagerForm historyform = new HistoryManagerForm();
               historyform.ShowDialog();
          }

          private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
          {
               BookmarkManagerForm bookmarkForm = new BookmarkManagerForm();
               bookmarkForm.ShowDialog();
          }

          private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
          {
               HistoryManagerForm form = new HistoryManagerForm();
               form.toolStripButtonDeleteAllHistory_Click(sender, e);
          }
     }
}
