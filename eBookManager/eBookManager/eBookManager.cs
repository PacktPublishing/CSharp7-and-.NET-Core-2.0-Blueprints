using System;
using System.Windows.Forms;

namespace eBookManager
{
    public partial class eBookManager : Form
    {
        public eBookManager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void mnuImportEbooks_Click(object sender, EventArgs e)
        {
            ImportBooks import = new ImportBooks();
            import.ShowDialog();
        }
    }
}
