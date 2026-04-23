using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;

namespace FileOrganizer
{
    public partial class LoginForm : Form
    {
        private string credFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "auth.dat");
        private bool isSetup = false;
        private string authMode = "password"; // "password" or "pin"
        private int failedAttempts = 0;
        private const int MAX_ATTEMPTS = 5;

        public LoginForm()
        {
            InitializeComponent();
            CheckFirstRun();
        }

        private void CheckFirstRun()
        {
            if (!File.Exists(credFile))
            {
                isSetup = true;
                ShowSetupUI();
            }
            else
            {
                isSetup = false;
                LoadAuthMode();
                ShowLoginUI();
            }
        }

        private void LoadAuthMode()
        {
            try
            {
                string[] lines = File.ReadAllLines(credFile);
                authMode = lines[0];
                UpdateLoginUI();
            }
            catch { authMode = "password"; }
        }

        private void ShowSetupUI()
        {
            lblTitle.Text = "Welcome to File Organizer";
            lblSubtitle.Text = "Set up your security method to get started.";
            panelSetup.Visible = true;
            panelLogin.Visible = false;
            panelPinLogin.Visible = false;
        }

        private void ShowLoginUI()
        {
            lblTitle.Text = "File Organizer";
            lblSubtitle.Text = authMode == "pin" ? "Enter your PIN to continue." : "Enter your password to continue.";

            if (authMode == "pin")
            {
                panelSetup.Visible = false;
                panelLogin.Visible = false;
                panelPinLogin.Visible = true;
            }
            else
            {
                panelSetup.Visible = false;
                panelLogin.Visible = true;
                panelPinLogin.Visible = false;
            }
        }

        private void UpdateLoginUI()
        {
            lblSubtitle.Text = authMode == "pin" ? "Enter your PIN to continue." : "Enter your password to continue.";
        }

        // SETUP: choose mode
        private void btnChoosePassword_Click(object sender, EventArgs e)
        {
            authMode = "password";
            ShowPasswordSetup();
        }

        private void btnChoosePin_Click(object sender, EventArgs e)
        {
            authMode = "pin";
            ShowPinSetup();
        }

        private void ShowPasswordSetup()
        {
            panelChoose.Visible = false;
            panelPasswordSetup.Visible = true;
            panelPinSetup.Visible = false;
        }

        private void ShowPinSetup()
        {
            panelChoose.Visible = false;
            panelPasswordSetup.Visible = false;
            panelPinSetup.Visible = true;
            pinSetupDisplay.Text = "";
            pinSetupConfirmDisplay.Text = "";
            pinSetupEntry = "";
            pinSetupConfirmEntry = "";
            pinSetupStage = 1;
            lblPinSetupPrompt.Text = "Enter a 4-digit PIN:";
        }

        // PASSWORD SETUP
        private void btnConfirmPassword_Click(object sender, EventArgs e)
        {
            string pass = txtSetupPassword.Text;
            string confirm = txtSetupConfirm.Text;

            if (pass.Length < 4)
            {
                lblSetupError.Text = "Password must be at least 4 characters.";
                lblSetupError.Visible = true;
                return;
            }

            if (pass != confirm)
            {
                lblSetupError.Text = "Passwords do not match!";
                lblSetupError.Visible = true;
                return;
            }

            SaveCredentials("password", HashString(pass));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // PIN SETUP
        private string pinSetupEntry = "";
        private string pinSetupConfirmEntry = "";
        private int pinSetupStage = 1;

        private void PinSetupButton_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn.Tag?.ToString() == "del")
            {
                if (pinSetupStage == 1 && pinSetupEntry.Length > 0)
                    pinSetupEntry = pinSetupEntry[..^1];
                else if (pinSetupStage == 2 && pinSetupConfirmEntry.Length > 0)
                    pinSetupConfirmEntry = pinSetupConfirmEntry[..^1];
            }
            else
            {
                string digit = btn.Text;
                if (pinSetupStage == 1 && pinSetupEntry.Length < 4)
                    pinSetupEntry += digit;
                else if (pinSetupStage == 2 && pinSetupConfirmEntry.Length < 4)
                    pinSetupConfirmEntry += digit;
            }

            UpdatePinSetupDisplay();

            if (pinSetupStage == 1 && pinSetupEntry.Length == 4)
            {
                pinSetupStage = 2;
                lblPinSetupPrompt.Text = "Confirm your PIN:";
                pinSetupDisplay.Text = "● ● ● ●";
            }
            else if (pinSetupStage == 2 && pinSetupConfirmEntry.Length == 4)
            {
                if (pinSetupEntry == pinSetupConfirmEntry)
                {
                    SaveCredentials("pin", HashString(pinSetupEntry));
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblPinSetupError.Text = "PINs don't match! Try again.";
                    lblPinSetupError.Visible = true;
                    pinSetupEntry = "";
                    pinSetupConfirmEntry = "";
                    pinSetupStage = 1;
                    lblPinSetupPrompt.Text = "Enter a 4-digit PIN:";
                    pinSetupDisplay.Text = "";
                    pinSetupConfirmDisplay.Text = "";
                }
            }
        }

        private void UpdatePinSetupDisplay()
        {
            string dots = "";
            int len = pinSetupStage == 1 ? pinSetupEntry.Length : pinSetupConfirmEntry.Length;
            for (int i = 0; i < 4; i++)
                dots += i < len ? "● " : "○ ";

            if (pinSetupStage == 1)
                pinSetupDisplay.Text = dots.Trim();
            else
                pinSetupConfirmDisplay.Text = dots.Trim();
        }

        // PASSWORD LOGIN
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (failedAttempts >= MAX_ATTEMPTS)
            {
                lblLoginError.Text = "Too many attempts! Restart the app.";
                lblLoginError.Visible = true;
                return;
            }

            string[] lines = File.ReadAllLines(credFile);
            string savedHash = lines[1];
            string inputHash = HashString(txtLoginPassword.Text);

            if (inputHash == savedHash)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                failedAttempts++;
                int remaining = MAX_ATTEMPTS - failedAttempts;
                lblLoginError.Text = remaining > 0
                    ? $"Wrong password! {remaining} attempts left."
                    : "Too many attempts! Restart the app.";
                lblLoginError.Visible = true;
                txtLoginPassword.Clear();
            }
        }

        // PIN LOGIN
        private string pinLoginEntry = "";

        private void PinLoginButton_Click(object sender, EventArgs e)
        {
            if (failedAttempts >= MAX_ATTEMPTS) return;

            var btn = (Button)sender;
            if (btn.Tag?.ToString() == "del")
            {
                if (pinLoginEntry.Length > 0)
                    pinLoginEntry = pinLoginEntry[..^1];
            }
            else
            {
                if (pinLoginEntry.Length < 4)
                    pinLoginEntry += btn.Text;
            }

            UpdatePinLoginDisplay();

            if (pinLoginEntry.Length == 4)
            {
                string[] lines = File.ReadAllLines(credFile);
                string savedHash = lines[1];
                string inputHash = HashString(pinLoginEntry);

                if (inputHash == savedHash)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    failedAttempts++;
                    int remaining = MAX_ATTEMPTS - failedAttempts;
                    lblPinLoginError.Text = remaining > 0
                        ? $"Wrong PIN! {remaining} attempts left."
                        : "Too many attempts! Restart the app.";
                    lblPinLoginError.Visible = true;
                    pinLoginEntry = "";
                    UpdatePinLoginDisplay();
                }
            }
        }

        private void UpdatePinLoginDisplay()
        {
            string dots = "";
            for (int i = 0; i < 4; i++)
                dots += i < pinLoginEntry.Length ? "● " : "○ ";
            pinLoginDisplay.Text = dots.Trim();
        }

        // UTILS
        private void SaveCredentials(string mode, string hash)
        {
            File.WriteAllLines(credFile, new[] { mode, hash });
        }

        private string HashString(string input)
        {
            using var sha = SHA256.Create();
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input + "FO_SALT_2024"));
            return Convert.ToBase64String(bytes);
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            txtLoginPassword.UseSystemPasswordChar = !txtLoginPassword.UseSystemPasswordChar;
            btnShowHide.Text = txtLoginPassword.UseSystemPasswordChar ? "👁" : "🙈";
        }

        private void btnShowHideSetup_Click(object sender, EventArgs e)
        {
            txtSetupPassword.UseSystemPasswordChar = !txtSetupPassword.UseSystemPasswordChar;
            txtSetupConfirm.UseSystemPasswordChar = !txtSetupConfirm.UseSystemPasswordChar;
            btnShowHideSetup.Text = txtSetupPassword.UseSystemPasswordChar ? "👁" : "🙈";
        }
    }
}