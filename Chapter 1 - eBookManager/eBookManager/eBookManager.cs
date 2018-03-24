using eBookManager.Engine;
using eBookManager.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;

namespace eBookManager
{
    public partial class eBookManager : Form
    {
        private string _jsonPath;
        private List<StorageSpace> spaces;

        public eBookManager()
        {
            InitializeComponent();

            _jsonPath = Path.Combine(Application.StartupPath, "bookData.txt");

            spaces = spaces.ReadFromDataStore(_jsonPath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateStorageSpaceList();
        }

        private void PopulateStorageSpaceList()
        {
            lstStorageSpaces.Clear();
            if (!(spaces == null))
            {
                foreach (StorageSpace space in spaces)
                {
                    ListViewItem lvItem = new ListViewItem(space.Name, 0);
                    lvItem.Tag = space.BookList;
                    lvItem.Name = space.ID.ToString();
                    lstStorageSpaces.Items.Add(lvItem);
                }
            }
        }

        private void PopulateContainedEbooks(List<Document> ebookList)
        {
            lstBooks.Clear();
            ClearSelectedBook();

            if (ebookList != null)
            {
                foreach (Document eBook in ebookList)
                {
                    ListViewItem book = new ListViewItem(eBook.Title, 1);
                    book.Tag = eBook;
                    lstBooks.Items.Add(book);
                }
            }
            else
            {
                ListViewItem book = new ListViewItem("This storage space contains no eBooks", 2);
                book.Tag = "";
                lstBooks.Items.Add(book);
            }
        }

        private void ClearSelectedBook()
        {
            foreach (Control ctrl in gbBookDetails.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = "";
            }

            foreach (Control ctrl in gbFileDetails.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = "";
            }

            dtLastAccessed.Value = DateTime.Now;
            dtCreated.Value = DateTime.Now;
            dtDatePublished.Value = DateTime.Now;
        }

        private void mnuImportEbooks_Click(object sender, EventArgs e)
        {
            ImportBooks import = new ImportBooks();
            import.ShowDialog();
            spaces = spaces.ReadFromDataStore(_jsonPath);
            PopulateStorageSpaceList();
        }

        private void lstStorageSpaces_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedStorageSpace = lstStorageSpaces.SelectedItems[0];
            int spaceID = selectedStorageSpace.Name.ToInt();

            txtStorageSpaceDescription.Text = (from d in spaces
                                               where d.ID == spaceID
                                               select d.Description).First();

            List<Document> ebookList = (List<Document>)selectedStorageSpace.Tag;
            PopulateContainedEbooks(ebookList);
        }

        private void lstBooks_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedBook = lstBooks.SelectedItems[0];
            if (!String.IsNullOrEmpty(selectedBook.Tag.ToString()))
            {
                Document ebook = (Document)selectedBook.Tag;
                txtFileName.Text = ebook.FileName;
                txtExtension.Text = ebook.Extension;
                dtLastAccessed.Value = ebook.LastAccessed;
                dtCreated.Value = ebook.Created;
                txtFilePath.Text = ebook.FilePath;
                txtFileSize.Text = ebook.FileSize;
                txtTitle.Text = ebook.Title;
                txtAuthor.Text = ebook.Author;
                txtPublisher.Text = ebook.Publisher;
                txtPrice.Text = ebook.Price;
                txtISBN.Text = ebook.ISBN;
                dtDatePublished.Value = ebook.PublishDate;
                txtCategory.Text = ebook.Category;
            }
        }

        private void btnReadEbook_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;
            FileInfo fi = new FileInfo(filePath);
            if (fi.Exists)
            {
                Process.Start(Path.GetDirectoryName(filePath));
            }
        }
    }
}
