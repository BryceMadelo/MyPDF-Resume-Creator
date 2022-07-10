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
        string choosenfile;
        public PDFConverter()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                choosenfile = file.FileName;
                rchbxChoosenfile.Text = choosenfile;
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
           
        }

        public class ResumeInfo
        {
            public string Fullname { get; set; }

            public string Sex { get; set; }

            public string Age { get; set; }

            public string Bday { get; set; }

            public string add { get; set; }

            public string Nat { get; set; }

            public string Religion { get; set; }

            public string Phone { get; set; }

            public string Tel { get; set; }

            public string Email { get; set; }

            public string Fb { get; set; }

            public string AboutMe { get; set; }

            public string Tertiary { get; set; }

            public string Year1 { get; set; }

            public string SeniorHigh { get; set; }

            public string Year2 { get; set; }

            public string Secondary { get; set; }

            public string Year3 { get; set; }

            public string Primary { get; set; }

            public string Year4 { get; set; }

            public string Company1 { get; set; }

            public string Position1 { get; set; }

            public string Company2 { get; set; }

            public string Position2 { get; set; }

            public string Company3 { get; set; }

            public string Position3 { get; set; }

            public string Skill1 { get; set; }

            public string Skill2 { get; set; }

            public string Skill3 { get; set; }

            public string Reference { get; set; }
        }
    }
}