namespace FileOrganizer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.contentArea = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.pageOrganizer = new System.Windows.Forms.Panel();
            this.pageCategories = new System.Windows.Forms.Panel();
            this.pageCustom = new System.Windows.Forms.Panel();
            this.pageBehavior = new System.Windows.Forms.Panel();
            this.pageAppearance = new System.Windows.Forms.Panel();
            this.pageAbout = new System.Windows.Forms.Panel();
            this.btnNavOrganizer = new System.Windows.Forms.Button();
            this.btnNavCategories = new System.Windows.Forms.Button();
            this.btnNavCustom = new System.Windows.Forms.Button();
            this.btnNavBehavior = new System.Windows.Forms.Button();
            this.btnNavAppearance = new System.Windows.Forms.Button();
            this.btnNavAbout = new System.Windows.Forms.Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSub = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnOrganize = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnPreviewToggle = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnStartup = new System.Windows.Forms.Button();
            this.lblStartupStatus = new System.Windows.Forms.Label();
            this.lstRules = new System.Windows.Forms.ListBox();
            this.txtRuleName = new System.Windows.Forms.TextBox();
            this.txtRuleValue = new System.Windows.Forms.TextBox();
            this.txtRuleDest = new System.Windows.Forms.TextBox();
            this.cmbRuleType = new System.Windows.Forms.ComboBox();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.btnDeleteRule = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Colors
            var BG = System.Drawing.Color.FromArgb(255, 32, 32, 32);
            var Sidebar = System.Drawing.Color.FromArgb(255, 24, 24, 24);
            var Card = System.Drawing.Color.FromArgb(255, 42, 42, 42);
            var Accent = System.Drawing.Color.FromArgb(255, 98, 100, 245);
            var TextPrimary = System.Drawing.Color.FromArgb(255, 240, 240, 240);
            var TextSecondary = System.Drawing.Color.FromArgb(255, 160, 160, 160);
            var Green = System.Drawing.Color.FromArgb(255, 34, 197, 94);
            var Red = System.Drawing.Color.FromArgb(255, 239, 68, 68);
            var NavHover = System.Drawing.Color.FromArgb(255, 48, 48, 48);
            var NavActive = System.Drawing.Color.FromArgb(255, 55, 55, 55);
            var Border = System.Drawing.Color.FromArgb(255, 55, 55, 55);
            var InputBg = System.Drawing.Color.FromArgb(255, 55, 55, 55);

            // FORM
            this.Text = "File Organizer";
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.BackColor = BG;
            this.ForeColor = TextPrimary;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            string iconPath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "FileLogo.ico");
if (System.IO.File.Exists(iconPath))
    this.Icon = new System.Drawing.Icon(iconPath);

            // SIDEBAR
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Size = new System.Drawing.Size(200, 580);
            this.sidebarPanel.BackColor = Sidebar;

            this.lblAppName.Text = "File Organizer";
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = TextPrimary;
            this.lblAppName.BackColor = System.Drawing.Color.Transparent;
            this.lblAppName.Location = new System.Drawing.Point(16, 20);
            this.lblAppName.Size = new System.Drawing.Size(170, 30);

            void MakeNav(System.Windows.Forms.Button b, string text, int y)
            {
                b.Text = text;
                b.Location = new System.Drawing.Point(0, y);
                b.Size = new System.Drawing.Size(200, 40);
                b.Font = new System.Drawing.Font("Segoe UI", 10F);
                b.ForeColor = TextSecondary;
                b.BackColor = System.Drawing.Color.Transparent;
                b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.FlatAppearance.MouseOverBackColor = NavHover;
                b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                b.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
                b.Cursor = System.Windows.Forms.Cursors.Hand;
            }

            MakeNav(btnNavOrganizer,  "📁  Organizer",   80);
            MakeNav(btnNavCategories, "🗂️  Categories",  125);
            MakeNav(btnNavCustom,     "✏️  Custom",       170);
            MakeNav(btnNavBehavior,   "⚙️  Behavior",    215);
            MakeNav(btnNavAppearance, "🎨  Appearance",  260);
            MakeNav(btnNavAbout,      "ℹ️  About",       305);

            btnNavOrganizer.Click  += btnNavOrganizer_Click;
            btnNavCategories.Click += btnNavCategories_Click;
            btnNavCustom.Click     += btnNavCustom_Click;
            btnNavBehavior.Click   += btnNavBehavior_Click;
            btnNavAppearance.Click += btnNavAppearance_Click;
            btnNavAbout.Click      += btnNavAbout_Click;

            this.sidebarPanel.Controls.Add(lblAppName);
            this.sidebarPanel.Controls.Add(btnNavOrganizer);
            this.sidebarPanel.Controls.Add(btnNavCategories);
            this.sidebarPanel.Controls.Add(btnNavCustom);
            this.sidebarPanel.Controls.Add(btnNavBehavior);
            this.sidebarPanel.Controls.Add(btnNavAppearance);
            this.sidebarPanel.Controls.Add(btnNavAbout);

            // HEADER
            this.headerPanel.Location = new System.Drawing.Point(200, 0);
            this.headerPanel.Size = new System.Drawing.Size(700, 80);
            this.headerPanel.BackColor = BG;
            this.headerPanel.Paint += (s, e) =>
                e.Graphics.DrawLine(new System.Drawing.Pen(Border, 1), 0, 79, 700, 79);

            this.lblPageTitle.Text = "Organizer";
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = TextPrimary;
            this.lblPageTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPageTitle.Location = new System.Drawing.Point(30, 12);
            this.lblPageTitle.Size = new System.Drawing.Size(400, 32);

            this.lblPageSub.Text = "Organize your files into categorized folders automatically.";
            this.lblPageSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPageSub.ForeColor = TextSecondary;
            this.lblPageSub.BackColor = System.Drawing.Color.Transparent;
            this.lblPageSub.Location = new System.Drawing.Point(30, 46);
            this.lblPageSub.Size = new System.Drawing.Size(500, 20);

            this.headerPanel.Controls.Add(lblPageTitle);
            this.headerPanel.Controls.Add(lblPageSub);

            // CONTENT AREA
            this.contentArea.Location = new System.Drawing.Point(200, 80);
            this.contentArea.Size = new System.Drawing.Size(700, 500);
            this.contentArea.BackColor = BG;

            // Card helper
            System.Windows.Forms.Panel MakeCard(int y, int height)
            {
                var card = new System.Windows.Forms.Panel();
                card.Location = new System.Drawing.Point(30, y);
                card.Size = new System.Drawing.Size(640, height);
                card.BackColor = Card;
                card.Paint += (s, e) =>
                    e.Graphics.DrawRectangle(new System.Drawing.Pen(Border, 1), 0, 0, card.Width - 1, card.Height - 1);
                return card;
            }

            System.Windows.Forms.Label MakeLabel(string text, System.Drawing.Font font, System.Drawing.Color color, int x, int y, int w, int h)
            {
                var l = new System.Windows.Forms.Label();
                l.Text = text; l.Font = font; l.ForeColor = color;
                l.BackColor = System.Drawing.Color.Transparent;
                l.Location = new System.Drawing.Point(x, y);
                l.Size = new System.Drawing.Size(w, h);
                return l;
            }

            var boldFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            var subFont = new System.Drawing.Font("Segoe UI", 8F);
            var normalFont = new System.Drawing.Font("Segoe UI", 9F);

            // ── PAGE: ORGANIZER ───────────────────────────
            this.pageOrganizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageOrganizer.BackColor = System.Drawing.Color.Transparent;

            var card1 = MakeCard(20, 80);
            card1.Controls.Add(MakeLabel("Target Folder", boldFont, TextPrimary, 16, 10, 200, 22));
            card1.Controls.Add(MakeLabel("Choose which folder to organize", subFont, TextSecondary, 16, 30, 300, 18));

            this.txtFolder.Location = new System.Drawing.Point(16, 50);
            this.txtFolder.Size = new System.Drawing.Size(500, 22);
            this.txtFolder.Font = normalFont;
            this.txtFolder.BackColor = InputBg;
            this.txtFolder.ForeColor = TextPrimary;
            this.txtFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFolder.PlaceholderText = "No folder selected...";
            this.txtFolder.ReadOnly = true;

            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Location = new System.Drawing.Point(524, 48);
            this.btnBrowse.Size = new System.Drawing.Size(100, 26);
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.BackColor = Accent;
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Click += btnBrowse_Click;
            card1.Controls.Add(txtFolder);
            card1.Controls.Add(btnBrowse);

            var card2 = MakeCard(115, 70);
            card2.Controls.Add(MakeLabel("Actions", boldFont, TextPrimary, 16, 10, 200, 22));

            void MakeBtn(System.Windows.Forms.Button b, string text, int x, int w, System.Drawing.Color bg)
            {
                b.Text = text;
                b.Location = new System.Drawing.Point(x, 36);
                b.Size = new System.Drawing.Size(w, 26);
                b.Font = normalFont;
                b.BackColor = bg;
                b.ForeColor = System.Drawing.Color.White;
                b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.Cursor = System.Windows.Forms.Cursors.Hand;
            }

            MakeBtn(btnOrganize, "⚡ Organize Files", 16, 150, Green);
            MakeBtn(btnPreviewToggle, "👀 Preview OFF", 176, 130, InputBg);
            MakeBtn(btnUndo, "↩️ Undo", 316, 100, Red);
            MakeBtn(btnClearLog, "🗑️ Clear Log", 426, 110, InputBg);

            btnOrganize.Click += btnOrganize_Click;
            btnPreviewToggle.Click += btnPreviewToggle_Click;
            btnUndo.Click += btnUndo_Click;
            btnClearLog.Click += btnClearLog_Click;

            card2.Controls.Add(btnOrganize);
            card2.Controls.Add(btnPreviewToggle);
            card2.Controls.Add(btnUndo);
            card2.Controls.Add(btnClearLog);

            this.progressBar.Location = new System.Drawing.Point(30, 196);
            this.progressBar.Size = new System.Drawing.Size(640, 6);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.ForeColor = Accent;
            this.progressBar.BackColor = Card;

            var card3 = MakeCard(210, 265);
            card3.Controls.Add(MakeLabel("Activity Log", boldFont, TextPrimary, 16, 10, 200, 22));

            this.txtLog.Location = new System.Drawing.Point(16, 36);
            this.txtLog.Size = new System.Drawing.Size(608, 215);
            this.txtLog.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(255, 30, 30, 30);
            this.txtLog.ForeColor = System.Drawing.Color.FromArgb(255, 180, 255, 180);
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            card3.Controls.Add(txtLog);

            this.pageOrganizer.Controls.Add(card1);
            this.pageOrganizer.Controls.Add(card2);
            this.pageOrganizer.Controls.Add(progressBar);
            this.pageOrganizer.Controls.Add(card3);

            // ── PAGE: CATEGORIES ──────────────────────────
            this.pageCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageCategories.BackColor = System.Drawing.Color.Transparent;
            this.pageCategories.Visible = false;

            var cardCat = MakeCard(20, 400);
            cardCat.Controls.Add(MakeLabel("File Categories", boldFont, TextPrimary, 16, 12, 300, 22));
            cardCat.Controls.Add(MakeLabel("Default categories used to sort your files.", subFont, TextSecondary, 16, 34, 500, 18));

            string[] catNames = { "📷 Images", "🎬 Videos", "🎵 Music", "📄 Documents", "⚙️ Programs", "🗜️ Archives", "💻 Code" };
            string[] catExts = {
                ".png .jpg .jpeg .gif .bmp .webp",
                ".mp4 .mkv .avi .mov .wmv",
                ".mp3 .wav .flac .aac .ogg",
                ".pdf .docx .doc .txt .xlsx .pptx",
                ".exe .msi .bat .cmd",
                ".zip .rar .7z .tar .gz",
                ".py .cs .js .html .css .ts"
            };

            for (int i = 0; i < catNames.Length; i++)
            {
                var row = new System.Windows.Forms.Panel();
                row.Location = new System.Drawing.Point(16, 60 + i * 46);
                row.Size = new System.Drawing.Size(608, 40);
                row.BackColor = System.Drawing.Color.FromArgb(255, 50, 50, 50);
                row.Controls.Add(MakeLabel(catNames[i], new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold), TextPrimary, 12, 10, 140, 20));
                row.Controls.Add(MakeLabel(catExts[i], new System.Drawing.Font("Consolas", 8F), TextSecondary, 160, 11, 440, 18));
                cardCat.Controls.Add(row);
            }
            pageCategories.Controls.Add(cardCat);

            // ── PAGE: CUSTOM RULES ────────────────────────
            this.pageCustom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageCustom.BackColor = System.Drawing.Color.Transparent;
            this.pageCustom.Visible = false;

            var cardCustomAdd = MakeCard(20, 150);
            cardCustomAdd.Controls.Add(MakeLabel("Add Custom Rule", boldFont, TextPrimary, 16, 12, 300, 22));
            cardCustomAdd.Controls.Add(MakeLabel("Create rules to sort files by name, extension, size, or date.", subFont, TextSecondary, 16, 34, 500, 18));
            cardCustomAdd.Controls.Add(MakeLabel("Rule Name", subFont, TextSecondary, 16, 58, 100, 16));
            cardCustomAdd.Controls.Add(MakeLabel("Type", subFont, TextSecondary, 166, 58, 100, 16));
            cardCustomAdd.Controls.Add(MakeLabel("Value", subFont, TextSecondary, 316, 58, 100, 16));
            cardCustomAdd.Controls.Add(MakeLabel("Destination Folder", subFont, TextSecondary, 466, 58, 140, 16));

            void StyleInput(System.Windows.Forms.Control c, int x, int y, int w)
            {
                c.Location = new System.Drawing.Point(x, y);
                c.Size = new System.Drawing.Size(w, 26);
                c.Font = normalFont;
                c.BackColor = InputBg;
                c.ForeColor = TextPrimary;
            }

            StyleInput(txtRuleName, 16, 76, 140);
            txtRuleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtRuleName.PlaceholderText = "e.g. Invoice";

            this.cmbRuleType.Location = new System.Drawing.Point(166, 76);
            this.cmbRuleType.Size = new System.Drawing.Size(140, 26);
            this.cmbRuleType.Font = normalFont;
            this.cmbRuleType.BackColor = InputBg;
            this.cmbRuleType.ForeColor = TextPrimary;
            this.cmbRuleType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRuleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRuleType.Items.AddRange(new object[] { "Contains", "Extension", "Size", "Date" });
            this.cmbRuleType.SelectedIndex = 0;

            StyleInput(txtRuleValue, 316, 76, 140);
            txtRuleValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtRuleValue.PlaceholderText = "e.g. Invoice";

            StyleInput(txtRuleDest, 466, 76, 140);
            txtRuleDest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtRuleDest.PlaceholderText = "e.g. Invoice";

            this.btnAddRule.Text = "+ Add Rule";
            this.btnAddRule.Location = new System.Drawing.Point(16, 112);
            this.btnAddRule.Size = new System.Drawing.Size(120, 28);
            this.btnAddRule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddRule.BackColor = Accent;
            this.btnAddRule.ForeColor = System.Drawing.Color.White;
            this.btnAddRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRule.FlatAppearance.BorderSize = 0;
            this.btnAddRule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRule.Click += btnAddRule_Click;

            cardCustomAdd.Controls.Add(txtRuleName);
            cardCustomAdd.Controls.Add(cmbRuleType);
            cardCustomAdd.Controls.Add(txtRuleValue);
            cardCustomAdd.Controls.Add(txtRuleDest);
            cardCustomAdd.Controls.Add(btnAddRule);

            var cardCustomList = MakeCard(185, 280);
            cardCustomList.Controls.Add(MakeLabel("Active Rules", boldFont, TextPrimary, 16, 12, 300, 22));
            cardCustomList.Controls.Add(MakeLabel("Rules are checked before default categories.", subFont, TextSecondary, 16, 34, 400, 18));

            this.lstRules.Location = new System.Drawing.Point(16, 56);
            this.lstRules.Size = new System.Drawing.Size(608, 180);
            this.lstRules.Font = new System.Drawing.Font("Consolas", 9F);
            this.lstRules.BackColor = System.Drawing.Color.FromArgb(255, 30, 30, 30);
            this.lstRules.ForeColor = System.Drawing.Color.FromArgb(255, 180, 255, 180);
            this.lstRules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstRules.SelectionMode = System.Windows.Forms.SelectionMode.One;

            this.btnDeleteRule.Text = "🗑️ Delete Selected";
            this.btnDeleteRule.Location = new System.Drawing.Point(16, 244);
            this.btnDeleteRule.Size = new System.Drawing.Size(150, 26);
            this.btnDeleteRule.Font = normalFont;
            this.btnDeleteRule.BackColor = Red;
            this.btnDeleteRule.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRule.FlatAppearance.BorderSize = 0;
            this.btnDeleteRule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteRule.Click += btnDeleteRule_Click;

            cardCustomList.Controls.Add(lstRules);
            cardCustomList.Controls.Add(btnDeleteRule);

            pageCustom.Controls.Add(cardCustomAdd);
            pageCustom.Controls.Add(cardCustomList);

            // ── PAGE: BEHAVIOR ────────────────────────────
            this.pageBehavior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageBehavior.BackColor = System.Drawing.Color.Transparent;
            this.pageBehavior.Visible = false;

            var cardBeh = MakeCard(20, 90);
            cardBeh.Controls.Add(MakeLabel("Run on Startup", boldFont, TextPrimary, 16, 12, 300, 22));
            cardBeh.Controls.Add(MakeLabel("Automatically launch File Organizer when Windows starts.", subFont, TextSecondary, 16, 34, 400, 18));

            this.btnStartup.Text = "Add to Startup";
            this.btnStartup.Location = new System.Drawing.Point(16, 56);
            this.btnStartup.Size = new System.Drawing.Size(140, 26);
            this.btnStartup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnStartup.BackColor = Accent;
            this.btnStartup.ForeColor = System.Drawing.Color.White;
            this.btnStartup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartup.FlatAppearance.BorderSize = 0;
            this.btnStartup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartup.Click += btnStartup_Click;

            this.lblStartupStatus.Text = "Status: Disabled";
            this.lblStartupStatus.Font = normalFont;
            this.lblStartupStatus.ForeColor = TextSecondary;
            this.lblStartupStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStartupStatus.Location = new System.Drawing.Point(170, 60);
            this.lblStartupStatus.Size = new System.Drawing.Size(200, 20);

            cardBeh.Controls.Add(btnStartup);
            cardBeh.Controls.Add(lblStartupStatus);
            pageBehavior.Controls.Add(cardBeh);

            // ── PAGE: APPEARANCE ──────────────────────────
            this.pageAppearance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageAppearance.BackColor = System.Drawing.Color.Transparent;
            this.pageAppearance.Visible = false;

            var cardApp = MakeCard(20, 80);
            cardApp.Controls.Add(MakeLabel("Appearance", boldFont, TextPrimary, 16, 12, 300, 22));
            cardApp.Controls.Add(MakeLabel("More appearance settings coming soon!", normalFont, TextSecondary, 16, 40, 400, 20));
            pageAppearance.Controls.Add(cardApp);

            // ── PAGE: ABOUT ───────────────────────────────
            this.pageAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageAbout.BackColor = System.Drawing.Color.Transparent;
            this.pageAbout.Visible = false;

            var cardAbt = MakeCard(20, 160);
            cardAbt.Controls.Add(MakeLabel("File Organizer", new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold), TextPrimary, 16, 16, 300, 34));
            cardAbt.Controls.Add(MakeLabel("Version 1.0.1", normalFont, TextSecondary, 16, 54, 200, 20));
            cardAbt.Controls.Add(MakeLabel("A clean, open source file organizer for Windows.\nAutomatically sorts your files into categorized folders.", normalFont, TextSecondary, 16, 80, 500, 40));
            cardAbt.Controls.Add(MakeLabel("Made with 💜 — Open Source on GitHub", normalFont, Accent, 16, 124, 400, 20));
            pageAbout.Controls.Add(cardAbt);

            // ASSEMBLE
            this.contentArea.Controls.Add(pageOrganizer);
            this.contentArea.Controls.Add(pageCategories);
            this.contentArea.Controls.Add(pageCustom);
            this.contentArea.Controls.Add(pageBehavior);
            this.contentArea.Controls.Add(pageAppearance);
            this.contentArea.Controls.Add(pageAbout);

            this.Controls.Add(sidebarPanel);
            this.Controls.Add(headerPanel);
            this.Controls.Add(contentArea);

            this.ResumeLayout(false);
            this.PerformLayout();

            ShowPage(pageOrganizer, btnNavOrganizer);
        }

        // Controls
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel contentArea;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel pageOrganizer;
        private System.Windows.Forms.Panel pageCategories;
        private System.Windows.Forms.Panel pageCustom;
        private System.Windows.Forms.Panel pageBehavior;
        private System.Windows.Forms.Panel pageAppearance;
        private System.Windows.Forms.Panel pageAbout;
        private System.Windows.Forms.Button btnNavOrganizer;
        private System.Windows.Forms.Button btnNavCategories;
        private System.Windows.Forms.Button btnNavCustom;
        private System.Windows.Forms.Button btnNavBehavior;
        private System.Windows.Forms.Button btnNavAppearance;
        private System.Windows.Forms.Button btnNavAbout;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSub;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnOrganize;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnPreviewToggle;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnStartup;
        private System.Windows.Forms.Label lblStartupStatus;
        private System.Windows.Forms.ListBox lstRules;
        private System.Windows.Forms.TextBox txtRuleName;
        private System.Windows.Forms.TextBox txtRuleValue;
        private System.Windows.Forms.TextBox txtRuleDest;
        private System.Windows.Forms.ComboBox cmbRuleType;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.Button btnDeleteRule;
    }
}