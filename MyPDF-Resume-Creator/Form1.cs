using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
namespace MyPDF_Resume_Creator
{
    public partial class PDFConverter : Form
    {
        
        public PDFConverter()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {

        }
    }
}