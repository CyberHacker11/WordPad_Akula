using System;
using System.IO;
using System.Text;
using System.Drawing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuButton;

namespace WordPad
{
    public partial class Form1 : Form
    {
        [Obsolete]
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] size = new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var font in FontFamily.Families) cbx_Fonts.Items.Add(font.Name);
            for (int i = 0; i < size.Length; i++) cbx_FontSize.Items.Add(size[i]);
            richTextBox1.DragDrop += RichTextBox1_DragDrop;
            richTextBox1.AllowDrop = true;
            cbx_FontSize.SelectedIndex = 0;
            cbx_Fonts.SelectedIndex = 0;
        }

        private void RichTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            richTextBox1.Text += e.Data.GetData(DataFormats.UnicodeText)?.ToString();
        }

        private void FontAndFontSize(object sender, EventArgs e)
        {
           richTextBox1.Font = new System.Drawing.Font(cbx_Fonts.Text, float.Parse(cbx_FontSize.Text));
        }

        private void FontStyle(object sender, EventArgs e)
        {
            richTextBox1.Font = new System.Drawing.Font(cbx_Fonts.Text, float.Parse(cbx_FontSize.Text),
                (icbx_Bold.Checked ? System.Drawing.FontStyle.Bold : System.Drawing.FontStyle.Regular)|
                (icbx_Underline.Checked ? System.Drawing.FontStyle.Underline : System.Drawing.FontStyle.Regular)|
                (icbx_Italic.Checked ? System.Drawing.FontStyle.Italic : System.Drawing.FontStyle.Regular));
        }

        private void MoveText(object sender, EventArgs e)
        {
            if(sender is BunifuButton btn)
            {
                switch (btn.Text)
                {
                    case "L": richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                        break;
                    case "C": richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                        break;
                    case "R": richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                        break;
                }
            }
        }

        private void ColorSelect(object sender, EventArgs e)
        {
            ColorDialog colors = new ColorDialog();
            if (colors.ShowDialog() == DialogResult.OK) 
            {
                if (sender is Bunifu.UI.WinForms.BunifuImageButton btn)
                {
                    switch (btn.Name)
                    {
                        case "btn_ForeColor": richTextBox1.ForeColor = colors.Color;
                            break;
                        case "btn_BackColor":
                            richTextBox1.BackColor = colors.Color;
                            break;
                    }
                }
            }
        }

        private void tsm_SaveAs_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "TXT Format(*.txt)|*.txt|PDF Format(*.pdf)|*.pdf", ValidateNames = true, })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName.EndsWith(".txt")) File.WriteAllText(sfd.FileName, richTextBox1?.Text, Encoding.Unicode);
                    else
                    {
                        Document doc = new Document(PageSize.A4.Rotate());
                        try
                        {
                            PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.OpenOrCreate));
                            doc.Open();
                            doc.Add(new Paragraph(richTextBox1?.Text));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            doc.Close();
                        }
                    }
                }
            }
        }

        private void tsm_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TXT File | *txt";
            if (ofd.ShowDialog() == DialogResult.OK) richTextBox1.Text = File.ReadAllText((Path = ofd.FileName));
        }

        private void tsm_New_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("When you open a new one, the old one is lost! Are you sure?", 
                "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) richTextBox1.Text = null;
        }

        private void tsm_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Path)) tsm_SaveAs_Click(this, e);
            else
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { FileName = Path, ValidateNames = true, })
                {
                    if (sfd.FileName.EndsWith(".txt"))
                    {
                        File.WriteAllText(sfd.FileName, richTextBox1?.Text, Encoding.Unicode);
                        MessageBox.Show("Saved successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Document doc = new Document(PageSize.A4.Rotate());
                        try
                        {
                            PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.OpenOrCreate));
                            doc.Open();
                            doc.Add(new Paragraph(richTextBox1?.Text));
                            MessageBox.Show("Saved successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            doc.Close();
                        }
                    }
                }
            }
        }

        public string Path { get; set; }

        private void tsm_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsm_Print_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.ShowDialog();
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 150, 125);
        }
        
        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) tsm_Save_Click(this, e);
        }
    }
}
