using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.WebBrowserDBDataSetTableAdapters;

namespace WebBrowser.Logic
{
     public class HistoryManager
     {
          static public void AddHistoryItem(HistoryItem item)
          {
               HistoryTableAdapter adapter = new HistoryTableAdapter();
               adapter.Insert(item.URL, item.Title, item.Date);
          }

          static public List<HistoryItem> GetHistoryItems()
          {
               HistoryTableAdapter adapter = new HistoryTableAdapter();
               List<HistoryItem> result = new List<HistoryItem>();
               var rows = adapter.GetData();

               foreach (var row in rows)
               {
                    HistoryItem item = new HistoryItem();
                    item.Title = row.Title;
                    item.URL = row.URL;
                    item.Date = row.Date;

                    result.Add(item);
               }
               return result;
          }

          static public void DeleteHistoryItem(string item)
          {
               HistoryTableAdapter adapter = new HistoryTableAdapter();
               var rows = adapter.GetData();

               foreach (var row in rows)
               {
                    if (item.Equals(string.Format("[{0}] {1} ({2})", row.Date, row.Title, row.URL)))
                    {
                         adapter.Delete(row.Id, row.Date);
                    }
               }
          }

          static public void DeleteAllHistory()
          {
               HistoryTableAdapter adapter = new HistoryTableAdapter();
               var rows = adapter.GetData();

               foreach (var row in rows)
               {
                    adapter.Delete(row.Id, row.Date);
               }
          }

          static public List<HistoryItem> SearchHistory(string input)
          {
               HistoryItem item = new HistoryItem();
               List<HistoryItem> result = new List<HistoryItem>();
               HistoryTableAdapter adapter = new HistoryTableAdapter();
               var rows = adapter.GetData();

               foreach (var row in rows)
               {
                    if (row.URL.Contains(input))
                    {
                         item.URL = row.URL;
                         item.Title = row.Title;
                         item.Date = row.Date;
                         result.Add(item);
                    }
               }
               return result;
          }
         
     }
}
