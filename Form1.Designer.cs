namespace PokePad
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            pageSetupToolStripMenuItem = new ToolStripMenuItem();
            prntprvw = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            findToolStripMenuItem = new ToolStripMenuItem();
            findOneToolStripMenuItem = new ToolStripMenuItem();
            findAllToolStripMenuItem = new ToolStripMenuItem();
            replaceToolStripMenuItem = new ToolStripMenuItem();
            replaceOneToolStripMenuItem = new ToolStripMenuItem();
            replaceAllToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            statusBarToolStripMenuItem = new ToolStripMenuItem();
            worldWrapToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            bgeditor = new ToolStripMenuItem();
            fgeditor = new ToolStripMenuItem();
            fonteditor = new ToolStripMenuItem();
            menuBarBackColorToolStripMenuItem = new ToolStripMenuItem();
            bgmenu = new ToolStripMenuItem();
            fgmenu = new ToolStripMenuItem();
            fontmenu = new ToolStripMenuItem();
            statusBarBackColorToolStripMenuItem = new ToolStripMenuItem();
            bgstatus = new ToolStripMenuItem();
            fgstatus = new ToolStripMenuItem();
            fontstatus = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            plainWhiteToolStripMenuItem = new ToolStripMenuItem();
            blueLightToolStripMenuItem = new ToolStripMenuItem();
            blueDarkToolStripMenuItem = new ToolStripMenuItem();
            violetLightToolStripMenuItem = new ToolStripMenuItem();
            violetDarkToolStripMenuItem = new ToolStripMenuItem();
            blackDarkToolStripMenuItem = new ToolStripMenuItem();
            tealToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tslfile = new ToolStripStatusLabel();
            tslsave = new ToolStripStatusLabel();
            tslww = new ToolStripStatusLabel();
            tsltheme = new ToolStripStatusLabel();
            tslcnt = new ToolStripStatusLabel();
            richTextBox1 = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            pageSetupDialog1 = new PageSetupDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDialog1 = new PrintDialog();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Red;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, formatToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1276, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator1, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator2, pageSetupToolStripMenuItem, prntprvw, printToolStripMenuItem, toolStripSeparator3, exitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.FromArgb(192, 192, 255);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.BackColor = Color.Transparent;
            newToolStripMenuItem.Image = Properties.Resources.pnew;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.N;
            newToolStripMenuItem.Size = new Size(319, 34);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.BackColor = Color.Transparent;
            openToolStripMenuItem.Image = Properties.Resources.popen1;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.O;
            openToolStripMenuItem.Size = new Size(319, 34);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(316, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.BackColor = Color.Transparent;
            saveToolStripMenuItem.Image = Properties.Resources.psave;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.S;
            saveToolStripMenuItem.Size = new Size(319, 34);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Image = Properties.Resources.psaveas;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(319, 34);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(316, 6);
            // 
            // pageSetupToolStripMenuItem
            // 
            pageSetupToolStripMenuItem.Image = Properties.Resources.ppgstup;
            pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            pageSetupToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.P;
            pageSetupToolStripMenuItem.Size = new Size(319, 34);
            pageSetupToolStripMenuItem.Text = "Page Setup";
            pageSetupToolStripMenuItem.Click += pageSetupToolStripMenuItem_Click;
            // 
            // prntprvw
            // 
            prntprvw.Image = Properties.Resources.pprevw;
            prntprvw.Name = "prntprvw";
            prntprvw.ShortcutKeys = Keys.Alt | Keys.Shift | Keys.P;
            prntprvw.Size = new Size(319, 34);
            prntprvw.Text = "Print Preview";
            prntprvw.Click += prntprvw_Click;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Image = Properties.Resources.twnmap;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.P;
            printToolStripMenuItem.Size = new Size(319, 34);
            printToolStripMenuItem.Text = "Print";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(316, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = Properties.Resources.fire;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            exitToolStripMenuItem.Size = new Size(319, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator4, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator5, findToolStripMenuItem, replaceToolStripMenuItem, toolStripSeparator6, selectAllToolStripMenuItem });
            editToolStripMenuItem.ForeColor = Color.FromArgb(192, 192, 255);
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Image = Properties.Resources.heal;
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.Z;
            undoToolStripMenuItem.Size = new Size(243, 34);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Image = Properties.Resources.repeatt;
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.Y;
            redoToolStripMenuItem.Size = new Size(243, 34);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(240, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = Properties.Resources.pcut2;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.X;
            cutToolStripMenuItem.Size = new Size(243, 34);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = Properties.Resources.sditto;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            copyToolStripMenuItem.Size = new Size(243, 34);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = Properties.Resources.goomy;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.V;
            pasteToolStripMenuItem.Size = new Size(243, 34);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(240, 6);
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { findOneToolStripMenuItem, findAllToolStripMenuItem });
            findToolStripMenuItem.Image = Properties.Resources.pfind3;
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(243, 34);
            findToolStripMenuItem.Text = "Find";
            // 
            // findOneToolStripMenuItem
            // 
            findOneToolStripMenuItem.Name = "findOneToolStripMenuItem";
            findOneToolStripMenuItem.Size = new Size(186, 34);
            findOneToolStripMenuItem.Text = "Find One";
            findOneToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // findAllToolStripMenuItem
            // 
            findAllToolStripMenuItem.Name = "findAllToolStripMenuItem";
            findAllToolStripMenuItem.Size = new Size(186, 34);
            findAllToolStripMenuItem.Text = "Find All";
            findAllToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // replaceToolStripMenuItem
            // 
            replaceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { replaceOneToolStripMenuItem, replaceAllToolStripMenuItem });
            replaceToolStripMenuItem.Image = Properties.Resources.preplace;
            replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            replaceToolStripMenuItem.Size = new Size(243, 34);
            replaceToolStripMenuItem.Text = "Replace";
            // 
            // replaceOneToolStripMenuItem
            // 
            replaceOneToolStripMenuItem.Name = "replaceOneToolStripMenuItem";
            replaceOneToolStripMenuItem.Size = new Size(212, 34);
            replaceOneToolStripMenuItem.Text = "Replace One";
            replaceOneToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // replaceAllToolStripMenuItem
            // 
            replaceAllToolStripMenuItem.Name = "replaceAllToolStripMenuItem";
            replaceAllToolStripMenuItem.Size = new Size(212, 34);
            replaceAllToolStripMenuItem.Text = "Replace All";
            replaceAllToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(240, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Image = Properties.Resources.mew;
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(243, 34);
            selectAllToolStripMenuItem.Text = "Select All";
            selectAllToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { statusBarToolStripMenuItem, worldWrapToolStripMenuItem });
            viewToolStripMenuItem.ForeColor = Color.FromArgb(192, 192, 255);
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(65, 29);
            viewToolStripMenuItem.Text = "&View";
            // 
            // statusBarToolStripMenuItem
            // 
            statusBarToolStripMenuItem.Checked = true;
            statusBarToolStripMenuItem.CheckState = CheckState.Checked;
            statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            statusBarToolStripMenuItem.Size = new Size(210, 34);
            statusBarToolStripMenuItem.Text = "Status Bar";
            statusBarToolStripMenuItem.Click += statusBarToolStripMenuItem_Click;
            // 
            // worldWrapToolStripMenuItem
            // 
            worldWrapToolStripMenuItem.Checked = true;
            worldWrapToolStripMenuItem.CheckState = CheckState.Checked;
            worldWrapToolStripMenuItem.Name = "worldWrapToolStripMenuItem";
            worldWrapToolStripMenuItem.Size = new Size(210, 34);
            worldWrapToolStripMenuItem.Text = "World Wrap";
            worldWrapToolStripMenuItem.Click += worldWrapToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, menuBarBackColorToolStripMenuItem, statusBarBackColorToolStripMenuItem, themeToolStripMenuItem });
            formatToolStripMenuItem.ForeColor = Color.DarkTurquoise;
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(85, 29);
            formatToolStripMenuItem.Text = "Fo&rmat";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bgeditor, fgeditor, fonteditor });
            fontToolStripMenuItem.Image = Properties.Resources.bulbasaur1;
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(197, 34);
            fontToolStripMenuItem.Text = "Editor";
            // 
            // bgeditor
            // 
            bgeditor.Name = "bgeditor";
            bgeditor.Size = new Size(257, 34);
            bgeditor.Text = "Background Color";
            bgeditor.Click += bgeditor_Click;
            // 
            // fgeditor
            // 
            fgeditor.Name = "fgeditor";
            fgeditor.Size = new Size(257, 34);
            fgeditor.Text = "Foreground Color";
            fgeditor.Click += bgeditor_Click;
            // 
            // fonteditor
            // 
            fonteditor.Name = "fonteditor";
            fonteditor.Size = new Size(257, 34);
            fonteditor.Text = "Font";
            fonteditor.Click += fonteditor_Click;
            // 
            // menuBarBackColorToolStripMenuItem
            // 
            menuBarBackColorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bgmenu, fgmenu, fontmenu });
            menuBarBackColorToolStripMenuItem.Image = Properties.Resources.treeko;
            menuBarBackColorToolStripMenuItem.Name = "menuBarBackColorToolStripMenuItem";
            menuBarBackColorToolStripMenuItem.Size = new Size(197, 34);
            menuBarBackColorToolStripMenuItem.Text = "Menu Bar";
            // 
            // bgmenu
            // 
            bgmenu.Name = "bgmenu";
            bgmenu.Size = new Size(257, 34);
            bgmenu.Text = "Background Color";
            bgmenu.Click += bgeditor_Click;
            // 
            // fgmenu
            // 
            fgmenu.Name = "fgmenu";
            fgmenu.Size = new Size(257, 34);
            fgmenu.Text = "Foreground Color";
            fgmenu.Click += bgeditor_Click;
            // 
            // fontmenu
            // 
            fontmenu.Name = "fontmenu";
            fontmenu.Size = new Size(257, 34);
            fontmenu.Text = "Font";
            fontmenu.Click += fonteditor_Click;
            // 
            // statusBarBackColorToolStripMenuItem
            // 
            statusBarBackColorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bgstatus, fgstatus, fontstatus });
            statusBarBackColorToolStripMenuItem.Image = Properties.Resources.squirtle;
            statusBarBackColorToolStripMenuItem.Name = "statusBarBackColorToolStripMenuItem";
            statusBarBackColorToolStripMenuItem.Size = new Size(197, 34);
            statusBarBackColorToolStripMenuItem.Text = "Status Bar ";
            // 
            // bgstatus
            // 
            bgstatus.Name = "bgstatus";
            bgstatus.Size = new Size(257, 34);
            bgstatus.Text = "Background Color";
            bgstatus.Click += bgeditor_Click;
            // 
            // fgstatus
            // 
            fgstatus.Name = "fgstatus";
            fgstatus.Size = new Size(257, 34);
            fgstatus.Text = "Foreground Color";
            fgstatus.Click += bgeditor_Click;
            // 
            // fontstatus
            // 
            fontstatus.Name = "fontstatus";
            fontstatus.Size = new Size(257, 34);
            fontstatus.Text = "Font";
            fontstatus.Click += fonteditor_Click;
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { plainWhiteToolStripMenuItem, blueLightToolStripMenuItem, blueDarkToolStripMenuItem, violetLightToolStripMenuItem, violetDarkToolStripMenuItem, blackDarkToolStripMenuItem, tealToolStripMenuItem });
            themeToolStripMenuItem.Image = Properties.Resources.smeargle2;
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(197, 34);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // plainWhiteToolStripMenuItem
            // 
            plainWhiteToolStripMenuItem.Image = Properties.Resources.prmrballl;
            plainWhiteToolStripMenuItem.Name = "plainWhiteToolStripMenuItem";
            plainWhiteToolStripMenuItem.Size = new Size(204, 34);
            plainWhiteToolStripMenuItem.Text = "White Light";
            plainWhiteToolStripMenuItem.Click += plainWhiteToolStripMenuItem_Click;
            // 
            // blueLightToolStripMenuItem
            // 
            blueLightToolStripMenuItem.Image = Properties.Resources.gr8ball1;
            blueLightToolStripMenuItem.Name = "blueLightToolStripMenuItem";
            blueLightToolStripMenuItem.Size = new Size(204, 34);
            blueLightToolStripMenuItem.Text = "Blue Light";
            blueLightToolStripMenuItem.Click += plainWhiteToolStripMenuItem_Click;
            // 
            // blueDarkToolStripMenuItem
            // 
            blueDarkToolStripMenuItem.Image = Properties.Resources.beastball;
            blueDarkToolStripMenuItem.Name = "blueDarkToolStripMenuItem";
            blueDarkToolStripMenuItem.Size = new Size(204, 34);
            blueDarkToolStripMenuItem.Text = "Blue Dark";
            blueDarkToolStripMenuItem.Click += plainWhiteToolStripMenuItem_Click;
            // 
            // violetLightToolStripMenuItem
            // 
            violetLightToolStripMenuItem.Image = Properties.Resources.luvball;
            violetLightToolStripMenuItem.Name = "violetLightToolStripMenuItem";
            violetLightToolStripMenuItem.Size = new Size(204, 34);
            violetLightToolStripMenuItem.Text = "Violet Light";
            violetLightToolStripMenuItem.Click += plainWhiteToolStripMenuItem_Click;
            // 
            // violetDarkToolStripMenuItem
            // 
            violetDarkToolStripMenuItem.Image = Properties.Resources.mstrball;
            violetDarkToolStripMenuItem.Name = "violetDarkToolStripMenuItem";
            violetDarkToolStripMenuItem.Size = new Size(204, 34);
            violetDarkToolStripMenuItem.Text = "Violet Dark";
            violetDarkToolStripMenuItem.Click += plainWhiteToolStripMenuItem_Click;
            // 
            // blackDarkToolStripMenuItem
            // 
            blackDarkToolStripMenuItem.Image = Properties.Resources.heavyball1;
            blackDarkToolStripMenuItem.Name = "blackDarkToolStripMenuItem";
            blackDarkToolStripMenuItem.Size = new Size(204, 34);
            blackDarkToolStripMenuItem.Text = "Black Dark";
            blackDarkToolStripMenuItem.Click += plainWhiteToolStripMenuItem_Click;
            // 
            // tealToolStripMenuItem
            // 
            tealToolStripMenuItem.Image = Properties.Resources.nettbll;
            tealToolStripMenuItem.Name = "tealToolStripMenuItem";
            tealToolStripMenuItem.Size = new Size(204, 34);
            tealToolStripMenuItem.Text = "Teal ";
            tealToolStripMenuItem.Click += plainWhiteToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.BackColor = Color.Transparent;
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.ForeColor = Color.FromArgb(192, 192, 255);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Image = Properties.Resources.rotomdex;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(164, 34);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(0, 0, 64);
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslfile, tslsave, tslww, tsltheme, tslcnt });
            statusStrip1.Location = new Point(0, 657);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1276, 32);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslfile
            // 
            tslfile.BackColor = Color.MediumBlue;
            tslfile.Name = "tslfile";
            tslfile.Size = new Size(172, 25);
            tslfile.Text = "PokePad_Untitled.txt";
            // 
            // tslsave
            // 
            tslsave.BackColor = Color.Navy;
            tslsave.Name = "tslsave";
            tslsave.Size = new Size(80, 25);
            tslsave.Text = "Unsaved";
            // 
            // tslww
            // 
            tslww.BackColor = Color.SlateBlue;
            tslww.Name = "tslww";
            tslww.Size = new Size(142, 25);
            tslww.Text = "Word Wrap : On";
            // 
            // tsltheme
            // 
            tsltheme.Name = "tsltheme";
            tsltheme.Size = new Size(168, 25);
            tsltheme.Text = "Theme : Violet Light";
            // 
            // tslcnt
            // 
            tslcnt.BackColor = Color.DarkGreen;
            tslcnt.Name = "tslcnt";
            tslcnt.Size = new Size(163, 25);
            tslcnt.Text = "Character Count : 0";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.MistyRose;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(0, 33);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1276, 624);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 689);
            Controls.Add(richTextBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "PokePad";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem pageSetupToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem replaceToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem statusBarToolStripMenuItem;
        private ToolStripMenuItem worldWrapToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private StatusStrip statusStrip1;
        private RichTextBox richTextBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripStatusLabel tslfile;
        private ToolStripStatusLabel tslsave;
        private ToolStripStatusLabel tslww;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem menuBarBackColorToolStripMenuItem;
        private ToolStripMenuItem statusBarBackColorToolStripMenuItem;
        private ToolStripMenuItem bgmenu;
        private ToolStripMenuItem fgmenu;
        private ToolStripMenuItem bgstatus;
        private ToolStripMenuItem fgstatus;
        private ToolStripMenuItem bgeditor;
        private ToolStripMenuItem fgeditor;
        private ToolStripMenuItem fonteditor;
        private ToolStripMenuItem fontmenu;
        private ToolStripMenuItem fontstatus;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem plainWhiteToolStripMenuItem;
        private ToolStripMenuItem blueLightToolStripMenuItem;
        private ToolStripMenuItem blueDarkToolStripMenuItem;
        private ToolStripMenuItem violetLightToolStripMenuItem;
        private ToolStripMenuItem violetDarkToolStripMenuItem;
        private ToolStripMenuItem blackDarkToolStripMenuItem;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private ToolStripStatusLabel tsltheme;
        private ToolStripStatusLabel tslcnt;
        private ToolStripMenuItem tealToolStripMenuItem;
        private ToolStripMenuItem findOneToolStripMenuItem;
        private ToolStripMenuItem findAllToolStripMenuItem;
        private ToolStripMenuItem replaceOneToolStripMenuItem;
        private ToolStripMenuItem replaceAllToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private ToolStripMenuItem prntprvw;
        private PageSetupDialog pageSetupDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDialog printDialog1;
    }
}
