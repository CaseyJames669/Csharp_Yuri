﻿// MainWindow.xaml.cs
// Using data binding (code-behind).
using System.Collections.Generic;
using System.Windows;

namespace BookViewer
{
   public partial class MainWindow : Window
   {
      private List< Book > books = new List< Book >();

      public MainWindow()
      {
         InitializeComponent();

         // add Book objects to the List
         books.Add( new Book( "C How to Program", "013299044X",
            "images/small/chtp.jpg", "images/large/chtp.jpg" ) );
         books.Add( new Book( "C++ How to Program", "0133378713",
            "images/small/cpphtp.jpg", "images/large/cpphtp.jpg" ) );
         books.Add( new Book(
            "Internet and World Wide Web How to Program", "0132151006",
            "images/small/iw3htp.jpg", "images/large/iw3htp.jpg" ) );
         books.Add( new Book( "Java How to Program", "0132940949",
            "images/small/jhtp.jpg", "images/large/jhtp.jpg" ) );
         books.Add( new Book( "Visual Basic How to Program", "0133406954",
            "images/small/vbhtp.jpg", "images/large/vbhtp.jpg" ) );
         books.Add( new Book( "Visual C# How to Program", "0133379337",
            "images/small/vcshtp.jpg", "images/large/vcshtp.jpg" ) );

         // bind data to the list
      } // end constructor
   } // end class MainWindow
} // end namespace BookViewer

