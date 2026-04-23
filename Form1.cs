using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using Microsoft.Win32;
using System.Text.Json;

namespace FileOrganizer
{
    public partial class Form1 : Form
    {
        private string selectedFolder = "";
        private List<(string From, string To)> moveHistory = new();
        private bool previewMode = false;
        private Panel? activePage;
        private Button? activeNavBtn;

        private Dictionary<string, string[]> categories = new()
        {
            { "Images", new[] { ".png", ".jpg", ".jpeg", ".gif", ".bmp", ".webp" } },
            { "Videos", new[] { ".mp4", ".mkv", ".avi", ".mov", ".wmv" } },
            { "Music", new[] { ".mp3", ".wav", ".flac", ".aac", ".ogg" } },
            { "Documents", new[] { ".pdf", ".docx", ".doc", ".txt", ".xlsx", ".pptx" } },
            { "Programs", new[] { ".exe", ".msi", ".bat", ".cmd" } },
            { "Archives", new[] { ".zip", ".rar", ".7z", ".tar", ".gz" } },
            { "Code", new[] { ".py", ".cs", ".js", ".html", ".css", ".ts" } }
        };

        public class CustomRule
        {
            public string Name { get; set; } = "";
            public string Type { get; set; } = ""; // "contains", "extension", "size", "date"
            public string Value { get; set; } = "";
            public string Destination { get; set; } = "";
        }

        private List<CustomRule> customRules = new();
        private string rulesFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "rules.json");

        public Form1()
        {
            InitializeComponent();
            LoadRules();
            RefreshRulesList();
        }

        private void LoadRules()
        {
            try
            {
                if (File.Exists(rulesFile))
                {
                    string json = File.ReadAllText(rulesFile);
                    customRules = JsonSerializer.Deserialize<List<CustomRule>>(json) ?? new();
                }
                else
{
    customRules = new List<CustomRule>();
    SaveRules();
}
            }
            catch { customRules = new(); }
        }

        private void SaveRules()
        {
            try
            {
                string json = JsonSerializer.Serialize(customRules, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rulesFile, json);
            }
            catch { }
        }

        private void RefreshRulesList()
        {
            lstRules.Items.Clear();
            foreach (var rule in customRules)
            {
                string typeLabel = rule.Type switch
                {
                    "contains" => $"filename contains \"{rule.Value}\"",
                    "extension" => $"extension is {rule.Value}",
                    "size" => $"size over {rule.Value} MB",
                    "date" => $"older than {rule.Value} days",
                    _ => rule.Value
                };
                lstRules.Items.Add($"{rule.Name}  —  {typeLabel}  →  {rule.Destination}/");
            }
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            string name = txtRuleName.Text.Trim();
            string value = txtRuleValue.Text.Trim();
            string dest = txtRuleDest.Text.Trim();
            string type = cmbRuleType.SelectedItem?.ToString()?.ToLower() ?? "contains";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(value) || string.IsNullOrEmpty(dest))
            {
                MessageBox.Show("Please fill in all fields!", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            customRules.Add(new CustomRule { Name = name, Type = type, Value = value, Destination = dest });
            SaveRules();
            RefreshRulesList();

            txtRuleName.Clear();
            txtRuleValue.Clear();
            txtRuleDest.Clear();
            cmbRuleType.SelectedIndex = 0;

            LogMessage($"✅ Custom rule added: {name}");
        }

        private void btnDeleteRule_Click(object sender, EventArgs e)
        {
            if (lstRules.SelectedIndex < 0) { MessageBox.Show("Select a rule to delete!"); return; }
            string ruleName = customRules[lstRules.SelectedIndex].Name;
            customRules.RemoveAt(lstRules.SelectedIndex);
            SaveRules();
            RefreshRulesList();
            LogMessage($"🗑️ Deleted rule: {ruleName}");
        }

        // NAV
        private void ShowPage(Panel page, Button navBtn)
        {
            foreach (Control c in contentArea.Controls)
                c.Visible = false;

            page.Visible = true;
            activePage = page;

            if (activeNavBtn != null)
            {
                activeNavBtn.BackColor = Color.Transparent;
                activeNavBtn.ForeColor = Color.FromArgb(255, 160, 160, 160);
            }

            navBtn.BackColor = Color.FromArgb(255, 55, 55, 55);
            navBtn.ForeColor = Color.FromArgb(255, 240, 240, 240);
            activeNavBtn = navBtn;
            lblPageTitle.Text = navBtn.Text.Substring(3).Trim();
        }

        private void btnNavOrganizer_Click(object sender, EventArgs e) => ShowPage(pageOrganizer, btnNavOrganizer);
        private void btnNavCategories_Click(object sender, EventArgs e) => ShowPage(pageCategories, btnNavCategories);
        private void btnNavCustom_Click(object sender, EventArgs e) => ShowPage(pageCustom, btnNavCustom);
        private void btnNavBehavior_Click(object sender, EventArgs e) => ShowPage(pageBehavior, btnNavBehavior);
        private void btnNavAppearance_Click(object sender, EventArgs e) => ShowPage(pageAppearance, btnNavAppearance);
        private void btnNavAbout_Click(object sender, EventArgs e) => ShowPage(pageAbout, btnNavAbout);

        // ORGANIZER
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedFolder = dialog.SelectedPath;
                txtFolder.Text = selectedFolder;
                LogMessage($"📁 Selected: {selectedFolder}");
            }
        }

        private void btnOrganize_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFolder)) { LogMessage("⚠️ Please select a folder first!"); return; }
            if (previewMode) PreviewFiles(selectedFolder);
            else OrganizeFiles(selectedFolder);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (moveHistory.Count == 0) { LogMessage("⚠️ Nothing to undo!"); return; }
            int undone = 0;
            HashSet<string> foldersToCheck = new();

            for (int i = moveHistory.Count - 1; i >= 0; i--)
            {
                var (from, to) = moveHistory[i];
                if (File.Exists(to))
                {
                    foldersToCheck.Add(Path.GetDirectoryName(to)!);
                    File.Move(to, from);
                    LogMessage($"↩️ Restored: {Path.GetFileName(from)}");
                    undone++;
                }
            }

            foreach (string folder in foldersToCheck)
            {
                if (Directory.Exists(folder) && Directory.GetFiles(folder).Length == 0 && Directory.GetDirectories(folder).Length == 0)
                {
                    Directory.Delete(folder);
                    LogMessage($"🗑️ Removed empty folder: {Path.GetFileName(folder)}");
                }
            }

            moveHistory.Clear();
            LogMessage($"✅ Undo complete! Restored {undone} files and cleaned up empty folders.");
        }

        private void btnPreviewToggle_Click(object sender, EventArgs e)
        {
            previewMode = !previewMode;
            btnPreviewToggle.Text = previewMode ? "👀 Preview ON" : "👀 Preview OFF";
            btnOrganize.Text = previewMode ? "🔍 Preview Changes" : "⚡ Organize Files";
            LogMessage(previewMode ? "👀 Preview mode ON" : "👀 Preview mode OFF");
        }

        private void btnClearLog_Click(object sender, EventArgs e) => txtLog.Clear();

        private void PreviewFiles(string folderPath)
        {
            string[] files = Directory.GetFiles(folderPath);
            LogMessage($"👀 PREVIEW — {files.Length} files:");
            foreach (string file in files)
            {
                string dest = GetDestination(file);
                LogMessage($"  {Path.GetFileName(file)} → {dest}/");
            }
            LogMessage("👀 Preview done! Turn off preview to actually organize.");
        }

        private void OrganizeFiles(string folderPath)
        {
            string[] files = Directory.GetFiles(folderPath);
            progressBar.Maximum = files.Length;
            progressBar.Value = 0;
            moveHistory.Clear();
            int moved = 0;

            foreach (string file in files)
            {
                string dest = GetDestination(file);
                string destPath = Path.Combine(folderPath, dest);
                Directory.CreateDirectory(destPath);
                string destFile = Path.Combine(destPath, Path.GetFileName(file));
                if (!File.Exists(destFile))
                {
                    File.Move(file, destFile);
                    moveHistory.Add((file, destFile));
                    LogMessage($"✅ {Path.GetFileName(file)} → {dest}/");
                    moved++;
                }
                else LogMessage($"⚠️ Skipped: {Path.GetFileName(file)}");
                progressBar.Value++;
                Application.DoEvents();
            }
            LogMessage($"🎉 Done! Moved {moved} files.");
        }

        private string GetDestination(string filePath)
        {
            string fileName = Path.GetFileName(filePath).ToLower();
            string ext = Path.GetExtension(filePath).ToLower();
            var info = new FileInfo(filePath);

            // Check custom rules first
            foreach (var rule in customRules)
            {
                switch (rule.Type)
                {
                    case "contains":
                        if (fileName.Contains(rule.Value.ToLower())) return rule.Destination;
                        break;
                    case "extension":
                        if (ext == rule.Value.ToLower()) return rule.Destination;
                        break;
                    case "size":
                        if (long.TryParse(rule.Value, out long mb) && info.Length > mb * 1024 * 1024)
                            return rule.Destination;
                        break;
                    case "date":
                        if (int.TryParse(rule.Value, out int days) && (DateTime.Now - info.LastWriteTime).TotalDays > days)
                            return rule.Destination;
                        break;
                }
            }

            // Fall back to default categories
            foreach (var cat in categories)
                if (Array.IndexOf(cat.Value, ext) >= 0) return cat.Key;

            return "Other";
        }

        private string GetCategory(string ext)
        {
            foreach (var cat in categories)
                if (Array.IndexOf(cat.Value, ext) >= 0) return cat.Key;
            return "Other";
        }

        private void LogMessage(string msg)
        {
            txtLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {msg}{Environment.NewLine}");
            txtLog.ScrollToCaret();
        }

        private void btnStartup_Click(object sender, EventArgs e)
        {
            string appName = "FileOrganizer";
            using var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            if (key?.GetValue(appName) == null)
            {
                key?.SetValue(appName, Application.ExecutablePath);
                btnStartup.Text = "Remove from Startup";
                lblStartupStatus.Text = "Status: Enabled";
                lblStartupStatus.ForeColor = Color.FromArgb(255, 34, 197, 94);
            }
            else
            {
                key?.DeleteValue(appName);
                btnStartup.Text = "Add to Startup";
                lblStartupStatus.Text = "Status: Disabled";
                lblStartupStatus.ForeColor = Color.FromArgb(255, 160, 160, 160);
            }
        }
    }
}