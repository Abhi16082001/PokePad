using System.Drawing;
using System.Drawing.Printing;

namespace PokePad
{
    public partial class Form1 : Form
    {
        string currentfile = "";
        string paste = "";
        public static string find = "";
        public RichTextBox richtxtbx => richTextBox1;
        public Form1()
        {
            InitializeComponent();
            //printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string filecontent = File.ReadAllText(filename);
                richTextBox1.Text = "";
                richTextBox1.Text = filecontent;
                currentfile = filename;
                tslfile.Text = currentfile.Substring(currentfile.LastIndexOf('\\') + 1);
                tslcnt.Text = "Character Count : " + richTextBox1.Text.Length.ToString();
            }
        }



        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;

            if (tsmi.Name == "saveAsToolStripMenuItem" || currentfile == "")
            {
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.FileName = "PokePad.txt";
                saveFileDialog1.Filter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*";
                DialogResult dr = saveFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string filename = saveFileDialog1.FileName;
                    string content = richTextBox1.Text;
                    if (File.Exists(filename))
                    {
                        DialogResult fe = MessageBox.Show("File already exist ! \nDo you want to overwrite ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (fe == DialogResult.Yes)
                        {
                            File.WriteAllText(filename, content);
                            currentfile = filename;
                            tslsave.Text = "Saved";
                            tslfile.Text = currentfile.Substring(currentfile.LastIndexOf('\\') + 1);
                            //tslfile.Text = currentfile;
                        }
                    }
                    File.WriteAllText(filename, content);
                    currentfile = filename;
                    tslsave.Text = "Saved";
                    tslfile.Text = currentfile.Substring(currentfile.LastIndexOf('\\') + 1);
                    //tslfile.Text = currentfile;
                }
            }

            else
            {
                string content = richTextBox1.Text;
                File.WriteAllText(currentfile, content);
                tslsave.Text = "Saved";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            tslsave.Text = "Unsaved";
            tslcnt.Text = "Character Count : " + richTextBox1.Text.Length.ToString();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tslsave.Text = "Unsave";
            currentfile = "";
            tslfile.Text = "PokePad.txt";
            richTextBox1.Clear();
            tslcnt.Text = "Character Count : 0";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tslsave.Text == "Saved") this.Close();
            else
            {
                DialogResult dr = MessageBox.Show("File is not Saved !\nDo you really want to Exit ?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void bgeditor_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem t = sender as ToolStripMenuItem;
            if (t.Name == "bgeditor")
            {
                colorDialog1.Color = richTextBox1.BackColor;
                DialogResult dr = colorDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    richTextBox1.BackColor = colorDialog1.Color;
                }
            }
            if (t.Name == "fgeditor")
            {
                colorDialog1.Color = richTextBox1.ForeColor;
                DialogResult dr = colorDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    richTextBox1.ForeColor = colorDialog1.Color;
                }
            }
            if (t.Name == "bgmenu")
            {
                colorDialog1.Color = menuStrip1.BackColor;
                DialogResult dr = colorDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    menuStrip1.BackColor = colorDialog1.Color;
                }
            }
            if (t.Name == "fgmenu")
            {
                colorDialog1.Color = menuStrip1.ForeColor;
                DialogResult dr = colorDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    foreach (ToolStripMenuItem ti in menuStrip1.Items)
                    {
                        ti.ForeColor = colorDialog1.Color;
                    }
                }
            }
            if (t.Name == "bgstatus")
            {
                colorDialog1.Color = statusStrip1.BackColor;
                DialogResult dr = colorDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    foreach (ToolStripItem ti in statusStrip1.Items)
                    {
                        ti.BackColor = colorDialog1.Color;
                    }
                }
                statusStrip1.BackColor = colorDialog1.Color;
            }
            if (t.Name == "fgstatus")
            {
                colorDialog1.Color = statusStrip1.ForeColor;
                DialogResult dr = colorDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    foreach (ToolStripItem ti in statusStrip1.Items)
                    {
                        ti.ForeColor = colorDialog1.Color;
                    }
                }
            }
        }

        private void fonteditor_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem t = sender as ToolStripMenuItem;
            if (t.Name == "fonteditor")
            {
                fontDialog1.Font = richTextBox1.Font;
                DialogResult dr = fontDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    richTextBox1.Font = fontDialog1.Font;
                }
            }

            if (t.Name == "fontmenu")
            {
                fontDialog1.Font = fileToolStripMenuItem.Font;
                DialogResult dr = fontDialog1.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    foreach (ToolStripMenuItem ti in menuStrip1.Items)
                    {
                        ti.Font = fontDialog1.Font;

                    }
                }
            }

            if (t.Name == "fontstatus")
            {
                fontDialog1.Font = tslfile.Font;
                DialogResult dr = fontDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    foreach (ToolStripItem ti in statusStrip1.Items)
                    {
                        ti.Font = fontDialog1.Font;
                    }
                }
            }
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusStrip1.Visible)
            {
                statusStrip1.Visible = false;
                statusBarToolStripMenuItem.Checked = false;
            }
            else
            {
                statusStrip1.Visible = true;
                statusBarToolStripMenuItem.Checked = true;
            }
        }

        private void worldWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.WordWrap)
            {
                richTextBox1.WordWrap = false;
                tslww.Text = "Word Wrap : Off";
                worldWrapToolStripMenuItem.Checked = false;
            }
            else
            {
                richTextBox1.WordWrap = true;
                tslww.Text = "Word Wrap : On";
                worldWrapToolStripMenuItem.Checked = true;
            }

        }

        private void plainWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font menufnt, stsfnt, editfnt;
            editfnt = new Font("RockWell", 14, FontStyle.Italic);
            menufnt = stsfnt = new Font("RockWell", 12, FontStyle.Regular);
            Color bgmenu, fgmenu, bgedit, fgedit, bgsts, bgsts2, fgsts;
            bgmenu = fgmenu = bgedit = fgedit = bgsts = bgsts2 = fgsts = Color.White;
            ToolStripMenuItem t = sender as ToolStripMenuItem;
            if (t.Name == "plainWhiteToolStripMenuItem")
            {
                tsltheme.Text = "Theme : White Light";  //fine
                bgmenu = Color.LightGray;
                fgmenu = Color.Black;
                bgedit = Color.White;
                fgedit = Color.Black;
                bgsts = Color.LightGray;
                bgsts2 = Color.DarkGray;
                fgsts = Color.Black;

            }
            if (t.Name == "blueLightToolStripMenuItem")
            {
                tsltheme.Text = "Theme : Blue Light"; //fine
                bgmenu = Color.LightSkyBlue;
                fgmenu = Color.DarkBlue;
                bgedit = Color.LightBlue;
                fgedit = Color.DarkBlue;
                bgsts = Color.LightSteelBlue;
                bgsts2 = Color.SteelBlue;
                fgsts = Color.DarkBlue;

            }
            if (t.Name == "violetLightToolStripMenuItem")
            {
                tsltheme.Text = "Theme : Violet Light"; //fine
                bgmenu = Color.DarkSlateBlue;
                fgmenu = Color.FromArgb(192, 192, 255);
                bgedit = Color.FromArgb(192, 192, 255);
                fgedit = Color.FromArgb(64, 0, 64);
                bgsts = Color.Lavender;
                bgsts2 = Color.FromArgb(128, 128, 255);
                fgsts = Color.DarkSlateBlue;

            }
            if (t.Name == "blueDarkToolStripMenuItem")
            {
                tsltheme.Text = "Theme : Blue Dark"; //fine
                bgmenu = Color.Navy;
                fgmenu = Color.LightBlue;
                bgedit = Color.FromArgb(0, 0, 64);
                fgedit = Color.LightBlue;
                bgsts = Color.Navy;
                bgsts2 = Color.MediumBlue;
                fgsts = Color.LightBlue;

            }
            if (t.Name == "violetDarkToolStripMenuItem")
            {
                tsltheme.Text = "Theme : Violet Dark"; //fine
                bgmenu = Color.Indigo;
                fgmenu = Color.FromArgb(192, 192, 255);
                bgedit = Color.FromArgb(64, 0, 64);
                fgedit = Color.Lavender;
                bgsts = Color.BlueViolet;
                bgsts2 = Color.Indigo;
                fgsts = Color.Lavender;

            }
            if (t.Name == "blackDarkToolStripMenuItem")
            {
                tsltheme.Text = "Theme : Black Dark";
                bgmenu = Color.FromArgb(64, 64, 64);
                fgmenu = Color.LightGray;
                bgedit = Color.Black;
                fgedit = Color.White;
                bgsts = Color.Gray;
                bgsts2 = Color.FromArgb(64, 64, 64);
                fgsts = Color.LightGray;

            }
            if (t.Name == "tealToolStripMenuItem")
            {
                tsltheme.Text = "Theme : Teal";
                bgmenu = Color.FromArgb(0, 64, 64);
                fgmenu = Color.PaleTurquoise;
                bgedit = Color.Teal;
                fgedit = Color.FromArgb(0, 64, 64);
                bgsts = Color.FromArgb(0, 64, 64);
                bgsts2 = Color.DarkGreen;
                fgsts = Color.PaleTurquoise;

            }


            statusStrip1.BackColor = bgsts;
            int cnt = 0;
            foreach (ToolStripItem ti in statusStrip1.Items)
            {
                cnt++;
                ti.ForeColor = fgsts;
                ti.BackColor = statusStrip1.BackColor;
                if (cnt % 2 != 0) ti.BackColor = bgsts2;
                ti.Font = stsfnt;
            }
            menuStrip1.BackColor = bgmenu;
            foreach (ToolStripMenuItem ti in menuStrip1.Items)
            {
                ti.Font = menufnt;
                ti.ForeColor = fgmenu;
            }
            //foreach (ToolStripMenuItem ti in fileToolStripMenuItem.DropDownItems)
            //{
            //    ti.Font = new Font("Algerian", 10, FontStyle.Italic);
            //    ti.ForeColor = Color.Red;
            //}
            richTextBox1.BackColor = bgedit;
            richTextBox1.ForeColor = fgedit;
            richTextBox1.Font = editfnt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pasteToolStripMenuItem.Enabled = false;
            Font menufnt, stsfnt, editfnt;
            editfnt = new Font("RockWell", 14, FontStyle.Italic);
            menufnt = stsfnt = new Font("RockWell", 12, FontStyle.Regular);
            Color bgmenu, fgmenu, bgedit, fgedit, bgsts, bgsts2, fgsts;
            tsltheme.Text = "Theme : White Light";  //fine
            bgmenu = Color.LightGray;
            fgmenu = Color.Black;
            bgedit = Color.White;
            fgedit = Color.Black;
            bgsts = Color.LightGray;
            bgsts2 = Color.DarkGray;
            fgsts = Color.Black;
            statusStrip1.BackColor = bgsts;
            int cnt = 0;
            foreach (ToolStripItem ti in statusStrip1.Items)
            {
                cnt++;
                ti.ForeColor = fgsts;
                ti.BackColor = statusStrip1.BackColor;
                if (cnt % 2 != 0) ti.BackColor = bgsts2;
                ti.Font = stsfnt;
            }
            menuStrip1.BackColor = bgmenu;
            foreach (ToolStripMenuItem ti in menuStrip1.Items)
            {
                ti.Font = menufnt;
                ti.ForeColor = fgmenu;
            }
            richTextBox1.BackColor = bgedit;
            richTextBox1.ForeColor = fgedit;
            richTextBox1.Font = editfnt;
        }



        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string search = "";
            ToolStripMenuItem t = sender as ToolStripMenuItem;
            if (t.Name == "selectAllToolStripMenuItem") richTextBox1.SelectAll();

            if (t.Name == "copyToolStripMenuItem")
            {

                paste = richTextBox1.SelectedText;
                pasteToolStripMenuItem.Enabled = true;
            }

            if (t.Name == "cutToolStripMenuItem")
            {
                pasteToolStripMenuItem.Enabled = true;
                paste = richTextBox1.SelectedText;
                richTextBox1.SelectedText = "";
            }

            if (t.Name == "pasteToolStripMenuItem") richTextBox1.SelectedText = paste;

            if (t.Name == "findOneToolStripMenuItem")
            {
                Form2 form2 = new Form2(richTextBox1);
                form2.btn.Text = "Find One";
                form2.Text = "FindOne";
                form2.ShowDialog();
                while (Form.ActiveForm == form2) ;
                int strt = richTextBox1.Find(Form1.find, 0, RichTextBoxFinds.None);
                int len = Form1.find.Length;
                if (strt >= 0) richTextBox1.Select(strt, len);


            }
            if (t.Name == "findAllToolStripMenuItem")
            {
                Form2 form2 = new Form2(richTextBox1);
                form2.btn.Text = "Find All";
                form2.Text = "FindAll";
                form2.Show();

            }
            if (t.Name == "replaceOneToolStripMenuItem")
            {
                Form2 form2 = new Form2(richTextBox1);
                form2.btn.Text = "Replace One What";
                form2.Text = "ReplaceOne";
                form2.Show();


            }
            if (t.Name == "replaceAllToolStripMenuItem")
            {
                Form2 form2 = new Form2(richTextBox1);
                form2.btn.Text = "Replace What All";
                form2.Text = "ReplaceAll";
                form2.ShowDialog();
                while (Form.ActiveForm == form2) ;
                Form2 frm2 = new Form2(richTextBox1, find);
                frm2.btn.Text = "Replace All With";
                frm2.Text = "ReplaceAll";
                frm2.Show();
            }
            if (t.Name == "redoToolStripMenuItem")
            {
                richTextBox1.Redo();
            }
            if (t.Name == "undoToolStripMenuItem")
            {
                richTextBox1.Undo();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the Text Editor like NotePad. \nBut just the Pokemon Version of the Normal one !! ", "Information About Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            DialogResult dr = printDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
               printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)  // Printpage event tells how the page will look when it will go for printing but we have to write the code for the look of page and this event will be trigerred not by any button or user interaction but by developer when developer will call the printDocument1.Print() or when PrintPreveiwDialog.ShowDialog() will be called and developer will call it in the event handler of print button. Every time we have to add the printDocument1 in every dialog box because all print dialog boxes like printDialog pagesetudialog or printpreviewdialog is associated to a document only, so they need a document to work !
        {
            string textToPrint = richTextBox1.Text;

            Font printFont = new Font("Arial", 12);
            SolidBrush printBrush = new SolidBrush(Color.Black);

            e.Graphics.DrawString(textToPrint, printFont, printBrush, e.MarginBounds.Left, e.MarginBounds.Top);
        }// e.Graphics is instance of Graphics class which allows to draw on pages and style the pages and we are calling the DrawString method defined in Graphics class using the instance to draw on or style the page.

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.ShowDialog();
        }

        private void prntprvw_Click(object sender, EventArgs e)
        {
            
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
