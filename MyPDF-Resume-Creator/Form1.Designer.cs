namespace MyPDF_Resume_Creator
{
    partial class PDFConverter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGen = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.rchbxChoosenfile = new System.Windows.Forms.RichTextBox();
            this.lablTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGen
            // 
            this.btnGen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGen.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGen.Location = new System.Drawing.Point(428, 263);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(105, 31);
            this.btnGen.TabIndex = 5;
            this.btnGen.Text = "Generate PDF";
            this.btnGen.UseVisualStyleBackColor = false;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChoose.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChoose.Location = new System.Drawing.Point(57, 263);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 31);
            this.btnChoose.TabIndex = 4;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // rchbxChoosenfile
            // 
            this.rchbxChoosenfile.BackColor = System.Drawing.Color.White;
            this.rchbxChoosenfile.Location = new System.Drawing.Point(57, 76);
            this.rchbxChoosenfile.Name = "rchbxChoosenfile";
            this.rchbxChoosenfile.Size = new System.Drawing.Size(476, 171);
            this.rchbxChoosenfile.TabIndex = 3;
            this.rchbxChoosenfile.Text = "";
            // 
            // lablTitle
            // 
            this.lablTitle.AutoSize = true;
            this.lablTitle.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lablTitle.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablTitle.Location = new System.Drawing.Point(55, 31);
            this.lablTitle.Name = "lablTitle";
            this.lablTitle.Size = new System.Drawing.Size(484, 32);
            this.lablTitle.TabIndex = 6;
            this.lablTitle.Text = "CONVERT YOUR JSON RESUME TO PDF";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.Location = new System.Drawing.Point(12, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(564, 298);
            this.dataGridView1.TabIndex = 7;
            // 
            // PDFConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 321);
            this.Controls.Add(this.lablTitle);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.rchbxChoosenfile);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PDFConverter";
            this.Text = "PDF CONVERTER";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGen;
        private Button btnChoose;
        private RichTextBox rchbxChoosenfile;
        private Label lablTitle;
        private DataGridView dataGridView1;
    }
}