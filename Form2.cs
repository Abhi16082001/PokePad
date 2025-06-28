using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokePad
{
    public partial class Form2 : Form
    {


        RichTextBox rtb;
        public string search = "";
        public Button btn => button1;
      
        Color bgclr,fgclr;
        string find = "";


        public Form2(RichTextBox richtxbx, string find="")
        {
            InitializeComponent();
            rtb = richtxbx;
             bgclr = rtb.BackColor;
             fgclr = rtb.ForeColor;
            this.find = find;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int strt;
            int len;
            search = textBox1.Text;
            strt = rtb.Find(search, 0, RichTextBoxFinds.None);
            len = search.Length;

               
            if (button1.Text=="Find One")
            {
                //strt = rtb.Find(search, 0,RichTextBoxFinds.None);
                //len = search.Length;
               
                Form1.find = textBox1.Text;
                Close();
            }
            else if(button1.Text=="Replace One What")
            {
                //strt = rtb.Find(search, 0, RichTextBoxFinds.None);
                //len = search.Length;
                if (strt >= 0)
                {
                    rtb.Select(strt, len);
                    textBox1.Clear();
                    button1.Text = "Replace One With";

                }
            }
            else if (button1.Text == "Replace What All")
            {
                //strt = rtb.Find(search, 0, RichTextBoxFinds.None);
                //len = search.Length;
                Form1.find = textBox1.Text;
                Close();
            }
            else if(button1.Text=="Replace All With")
            {
                string replace = textBox1.Text;
                strt = rtb.Find(find, 0, RichTextBoxFinds.None);
                len = find.Length;
                while (strt >= 0)
                {
                    rtb.Select(strt, len);
                    rtb.SelectedText = replace;
                    strt = strt + find.Length;
                    strt = rtb.Find(find, strt, RichTextBoxFinds.None);
                }
                Close();
            }
            else if (button1.Text == "Replace One With")
            {
                rtb.SelectedText = textBox1.Text;
                Close();
            }
            else if (button1.Text == "Find All")
            {
                //strt = rtb.Find(search, 0, RichTextBoxFinds.None);
                //len = search.Length;
                while (strt >= 0)
                {
                    rtb.Select(strt, len);
                    rtb.SelectionBackColor = Color.Aqua;
                    rtb.SelectionColor = Color.Black;
                    strt = strt + search.Length;
                    strt = rtb.Find(search, strt, RichTextBoxFinds.None);
                }
                button1.Text = "Cancel";
            }

            else if (button1.Text == "Cancel")
            {

                rtb.SelectAll();
                rtb.SelectionColor = fgclr;
                rtb.SelectionBackColor = bgclr;
                rtb.DeselectAll();

                Close();
            }

            }
    }
}

