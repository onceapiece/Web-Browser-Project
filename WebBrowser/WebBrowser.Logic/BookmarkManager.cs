using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.WebBrowserDBDataSetTableAdapters;

namespace WebBrowser.Logic
{
     public class BookmarkManager
     {
          static public void AddBookmarkItem(BookmarkItem item)
          {
               BookmarksTableAdapter adapter = new BookmarksTableAdapter();
               adapter.Insert(item.URL, item.Title);
          }

          static public List<BookmarkItem> GetBookmarkItems()
          {
               BookmarksTableAdapter adapter = new BookmarksTableAdapter();
               List<BookmarkItem> result = new List<BookmarkItem>();
               var rows = adapter.GetData();

               foreach (var row in rows)
               {
                    BookmarkItem item = new BookmarkItem();
                    item.Title = row.Title;
                    item.URL = row.URL;

                    result.Add(item);
               }
               return result;
          } 

          static public void DeleteBookmarkItem(string input)
          {
               BookmarksTableAdapter adapter = new BookmarksTableAdapter();
               var rows = adapter.GetData();

               foreach (var row in rows)
               {
                    if (input.Equals(string.Format("{0} ({1})", row.Title, row.URL)))
                    {
                         adapter.Delete(row.Id);
                    }
               }
          }

          static public List<BookmarkItem> SearchBookmarks(string input)
          {
               BookmarkItem item = new BookmarkItem();
               List<BookmarkItem> result = new List<BookmarkItem>();
               BookmarksTableAdapter adapter = new BookmarksTableAdapter();
               var rows = adapter.GetData();

               foreach (var row in rows)
               {
                    if (row.URL.Contains(input))
                    {
                         item.URL = row.URL;
                         item.Title = row.Title;
                         result.Add(item);
                    }
               }
               return result;
          }
     }
}
