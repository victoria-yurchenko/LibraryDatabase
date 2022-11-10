using LibraryDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDatabase
{
    public partial class Form1 : Form
    {
        LibraryDbContext _db = null;
        public Form1()
        {
            InitializeComponent();

            lbReaders.ForeColor = Color.DarkBlue;
            lbReaders.BackColor = Color.GhostWhite;

            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;

            _db = new LibraryDbContext();
            PopulateListBox();
        }

        private void RedrawListBooks()
        {
            clbSelectBooks.Items.Clear();
            List<Book> books = _db.Books.ToList<Book>();
            foreach (var book in books)
            {
                clbSelectBooks.Items.Add(book);
            }
        }

        private class CountedBooks
        {
            public string Title { get; set; }
            public int Count { get; set; }
            public override string ToString()
            {
                return $"<{Title}> was taken: {Count} time(s)."; 
            }
        }

        private void FillLbCountBooks()
        {
            lbCountBooks.Items.Clear();

            var books = _db.Books.ToList<Book>();
            var history = _db.Histories.ToList<History>();
            var list = new List<CountedBooks>();
            
            foreach (var book in books)
            {
                int count = history.Count(record => record.BookId == book.Id);
                list.Add(new CountedBooks()
                { 
                    Title = book.Title,
                    Count = count
                });
            }
            var sortedList = list.OrderByDescending(book => book.Count);

            foreach (var item in sortedList)
            {
                lbCountBooks.Items.Add(item.ToString());
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {

            }

            if (tabControl1.SelectedIndex == 1)
            {
                var list = _db.Readers.ToList<Reader>();
                cbReaders.DataSource = list;
                cbReaders.ValueMember = "Id";
                cbReaders.DisplayMember = "LastName";
                //PopulateLibrary();
                RedrawListBooks();

            }

            if (tabControl1.SelectedIndex == 2)
            {
                FillLbCountBooks();

                listViewDebts.View = View.Details;
                listViewDebts.Columns.Add("Title", 80);
                listViewDebts.Columns.Add("Book Id", 30);
                listViewDebts.Columns.Add("Reader", 120);
                listViewDebts.Columns.Add("Date Out", 70);
                listViewDebts.Columns.Add("Date Due", 70);
                listViewDebts.ItemActivate += ListViewDebts_ItemActivate;

                var list = _db.Histories.Where(record => record.DateReturn == null).Select(record => new
                {
                    record.Book.Title,
                    record.Book.Id,
                    record.Reader.FirstName,
                    record.Reader.LastName,
                    record.DateOut,
                    record.DateToReturn
                }).ToList();

                foreach (var obj in list)
                {
                    var item = new ListViewItem(obj.Title);
                    if (obj.DateToReturn < DateTime.Today)
                    {
                        item.ForeColor = Color.Red;
                    }
                    else
                    {
                        item.ForeColor = Color.Green;
                    }
                    var subitem = new ListViewItem.ListViewSubItem();
                    subitem.Text = obj.Id.ToString();

                    var subitem2 = new ListViewItem.ListViewSubItem();
                    subitem2.Text = $"{obj.FirstName} {obj.LastName}";

                    var subitem3 = new ListViewItem.ListViewSubItem();
                    subitem3.Text = $"{obj.DateOut.Year}.{obj.DateOut.Month}.{obj.DateOut.Day}";

                    var subitem4 = new ListViewItem.ListViewSubItem();
                    subitem4.Text = $"{obj.DateToReturn.Value.Year}." +
                        $"{obj.DateToReturn.Value.Month}." +
                        $"{obj.DateToReturn.Value.Day}";
                    subitem4.ForeColor = Color.YellowGreen;

                    item.SubItems.Add(subitem);
                    item.SubItems.Add(subitem2);
                    item.SubItems.Add(subitem3);
                    item.SubItems.Add(subitem4);

                    listViewDebts.Items.Add(item);
                }
            }
        }

        private void ListViewDebts_ItemActivate(object sender, EventArgs e)
        {
            //MessageBox.Show(listViewDebts.FocusedItem.ToString());
            MessageBox.Show(((ListViewItem)sender).Text);
        }

        private void PopulateComboBox()
        {
            var list = _db.Readers.ToList<Reader>();
            clbSelectBooks.DataSource = list;
            clbSelectBooks.ValueMember = "Id";
            clbSelectBooks.DisplayMember = "LastName";
        }

        private void PopulateLibrary()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book { Title = "Goblin Reservation", AuthorId = 1, Price = 220, BookState = "Good", BookCount = 5 });
            books.Add(new Book { Title = "All Flesh Is Grass", AuthorId = 1, Price = 250, BookState = "Good", BookCount = 5 });
            books.Add(new Book { Title = "Ring Around The Sun", AuthorId = 1, Price = 200, BookState = "Good", BookCount = 5 });
            books.Add(new Book { Title = "I, Robot", AuthorId = 3, Price = 210, BookState = "Good", BookCount = 4 });
            _db.Books.AddRange(books);
            _db.SaveChanges();
        }

        private void PopulateListBox()
        {
            var list = _db.Readers.ToList<Reader>();
            lbReaders.DataSource = list;
            lbReaders.ValueMember = "Id";
            lbReaders.DisplayMember = "LastName";

        }

        private void lbReaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            var reader = lbReaders.SelectedItem as Reader;
            if (reader == null)
            {
                return;
            }
            var listBooks = new List<string>();
            var history = _db.Histories.ToList<History>();
            foreach (var record in history)
            {
                if (record.ReaderId == reader.Id)
                {
                    var book = $"{_db.Books.Find(record.BookId).Title} {record.DateOut.Year}." +
                        $"{record.DateOut.Month}.{record.DateOut.Day}";
                    listBooks.Add(book);
                }
            }

            lbBooksReader.DataSource = null;
            lbBooksReader.DataSource = listBooks;
        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            Reader reader = new Reader()
            {
                FirstName = tbFirstName.Text.Trim(),
                LastName = tbLastName.Text.Trim(),
                Email = tbEmail.Text.Trim()
            };

            tbFirstName.Text = tbLastName.Text = tbEmail.Text = String.Empty;

            _db.Readers.Add(reader);
            _db.SaveChanges();
            PopulateListBox();
        }

        private void btnGiveBooks_Click(object sender, EventArgs e)
        {
            //get id of selected reader
            string index = cbReaders.SelectedValue.ToString();
            //get all checked books
            var cbooks = clbSelectBooks.CheckedItems;

            //for every checked book insert a record into history table
            foreach (object obj in cbooks)
            {
                Book book = obj as Book;

                if (book.BookCount != 0)
                {
                    History record = new History()
                    {
                        ReaderId = Convert.ToInt32(index),
                        BookId = book.Id,
                        DateOut = DateTime.Today,
                        DateToReturn = DateTime.Now.AddDays(14)
                    };
                    _db.Histories.Add(record);
                    Book book1 = _db.Books.Find(book.Id);
                    book1.BookCount--;
                    _db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Book is not available!");
                }
            }

            RedrawListBooks();
        }

        private void RedrawListReaderBooks(int id)
        {
            clbReadersBooks.Items.Clear();
            List<Book> books = _db.Histories
                .Where(record => record.ReaderId == id && record.DateReturn == null)
                .Select(book => book.Book)
                .ToList<Book>();
            foreach (var book in books)
            {
                clbReadersBooks.Items.Add(book);
            }
        }

        private void cbReaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            int readerId = ((Reader)cbReaders.Items[cbReaders.SelectedIndex]).Id;
            RedrawListReaderBooks(readerId);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //get id of selected reader
            string index = cbReaders.SelectedValue.ToString();
            //get all checked books
            var cbooks = clbReadersBooks.CheckedItems;
            var readerId = Convert.ToInt32(index);

            //for every checked book insert a record into history table
            foreach (object obj in cbooks)
            {
                Book book = obj as Book;

                Book book1 = _db.Books.Find(book.Id);
                book1.BookCount++;

                History history = _db.Histories.Where(h => h.ReaderId == readerId &&
                h.BookId == book.Id &&
                h.DateReturn == null).FirstOrDefault<History>();
                history.DateReturn = DateTime.Today;

                _db.SaveChanges();
            }

            RedrawListReaderBooks(readerId);
            RedrawListBooks();
        }
    }
}

// пробел в стринге считается окончанием парсинга
// dotnet ef scaffold "Server=DESKTOP-GDVFM0R;Database=Library;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context "LibraryDbContext" -DataAnnotations
// Scaffold-DbContext "Server=DESKTOP-GDVFM0R;Database=Library;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context "LibraryDbContext" -DataAnnotations