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
            //Reads the choosen file
            string openJson = File.ReadAllText(choosenfile);
            //Deserializing json file
            ResumeInfo finalJson = JsonConvert.DeserializeObject<ResumeInfo>(openJson);

            Paragraph name = new Paragraph(finalJson.Fullname + "\n\n");

            Paragraph PersonalInfo = new Paragraph("Personal Information: \n" + finalJson.Sex + "\n" + finalJson.Age + "\n" + finalJson.Bday + "\n" + finalJson.add + "\n" + finalJson.Nat + "\n" + finalJson.Religion + "\n\n");
            
            Paragraph ContactInfo = new Paragraph("Contact Information: \n" + finalJson.Phone + "\n" + finalJson.Tel + "\n" + finalJson.Email + "\n" + finalJson.Fb + "\n\n");
            
            Paragraph About = new Paragraph("About Me:\n" + finalJson.AboutMe + "\n\n");
           
            Paragraph educ = new Paragraph("Educational Attainment:\n" + finalJson.Tertiary + "\n" + finalJson.Year1 + "\n" + finalJson.SeniorHigh + "\n" + finalJson.Year2 + "\n" + finalJson.Secondary + "\n" + finalJson.Year3 + "\n" + finalJson.Primary + "\n" + finalJson.Year4 + "\n\n");
            
            Paragraph exp = new Paragraph("Experiences: \n" + finalJson.Company1 + "\n" + finalJson.Position1 + "\n" + finalJson.Company2 + "\n" + finalJson.Position2 + "\n" + finalJson.Company3 + "\n" + finalJson.Position3 + "\n\n");
            
            Paragraph skill = new Paragraph("Skills: \n" + finalJson.Skill1 + "\n" + finalJson.Skill2 + "\n" + finalJson.Skill3 + "\n\n");
            
            Paragraph reference = new Paragraph("Reference: \n" + finalJson.Reference);
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