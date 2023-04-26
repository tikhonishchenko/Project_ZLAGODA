using iTextSharp.text;
using iTextSharp.text.pdf;
using Syncfusion.Windows.Forms.PdfViewer;

namespace Project_ZLAGODA.Frontend
{
    public partial class PrintResultForm : Form
    {
        public PrintResultForm(DataGridView dataGridView)
        {
            InitializeComponent();
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("ais.pdf", FileMode.Create));
            document.Open();
            PdfPTable table = new PdfPTable(dataGridView.Columns.Count);
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                table.AddCell(cell);
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    table.AddCell(cell.Value.ToString());
                }
            }

            // Add the table to the document
            document.Add(table);

            // Close the document
            document.Close();
            PdfViewerControl pdfViewerControl = new PdfViewerControl();
            pdfViewerControl.Load("ais.pdf");
            pdfViewerControl.Dock = DockStyle.Fill;
            this.Controls.Add(pdfViewerControl);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
