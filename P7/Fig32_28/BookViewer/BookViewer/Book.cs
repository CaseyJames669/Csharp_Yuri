// Book.cs
// Class representing a book.
namespace BookViewer
{
   public class Book
   {
      // book title
      public string Title { get; set; }

      // book ISBN number
      public string ISBN { get; set; }

      // source of book cover's thumbnail image
      public string ThumbImage { get; set; }

      // source of book cover's fullsize image
      public string LargeImage { get; set; }
      
      public Book( string title, string isbn, string thumb, string large )
      {
         // set properties
         Title = title;
         ISBN = isbn;
         ThumbImage = thumb;
         LargeImage = large;
      } // end constructor
   } // end class Book
} // end namespace BookViewer

