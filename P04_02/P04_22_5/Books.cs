using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04_22_7
{
    public partial class Books : Form
    {
        private BooksDataSetTableAdapters.TableAdapterManager Adapters { get; set; }
        private List<Book> BookList { get; set; }
        public Books()
        {
            InitializeComponent();
            Adapters = new BooksDataSetTableAdapters.TableAdapterManager();
            Adapters.AuthorISBNTableAdapter = new BooksDataSetTableAdapters.AuthorISBNTableAdapter();
            Adapters.AuthorsTableAdapter = new BooksDataSetTableAdapters.AuthorsTableAdapter();
            Adapters.TitlesTableAdapter = new BooksDataSetTableAdapters.TitlesTableAdapter();          
        }

        private void Books_Load(object sender, EventArgs e)
        {            
            Adapters.AuthorISBNTableAdapter.Fill(booksDataSet.AuthorISBN);
            Adapters.AuthorsTableAdapter.Fill(booksDataSet.Authors);
            Adapters.TitlesTableAdapter.Fill(booksDataSet.Titles);
            
            // Initalize the bok list based on a link query
            this.BookList = (from titles in this.booksDataSet.Titles
                             join authors in this.booksDataSet.AuthorISBN on titles.ISBN equals authors.ISBN
                             join authorsName in this.booksDataSet.Authors on authors.AuthorID equals authorsName.AuthorID                                                          
                             select new Book
                             {
                                 Title = titles.Title,
                                 LastName = authorsName.LastName,
                                 FirstName = authorsName.FirstName
                             }).ToList();
        }

        private void titleButton_Click(object sender, EventArgs e)
        {
            this.booksGridView.DataSource = (from books in this.BookList orderby books.Title select books).ToList();
        }

        private void titleByAuthorButton_Click(object sender, EventArgs e)
        {
            this.booksGridView.DataSource = (from books in this.BookList orderby books.Title orderby books.LastName, books.FirstName select books).ToList();
        }

        private void authorsButton_Click(object sender, EventArgs e)
        {

            List<Book> orderedBooks = (from books in this.BookList
                                             orderby books.Title
                                             orderby books.LastName, books.FirstName select books).ToList();
            this.booksGridView.DataSource = (from a in orderedBooks group a by a.Title into groupedBook
                                             select new Book 
                                             { 
                                                 Title = groupedBook.Key, 
                                                 LastName = groupedBook.FirstOrDefault(f => f.Title == groupedBook.Key).LastName, 
                                                 FirstName = groupedBook.FirstOrDefault(f => f.Title == groupedBook.Key).FirstName 
                                             }).ToList(); ;
        }
    }
}
