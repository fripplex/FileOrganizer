namespace FileOrganizer
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            var BG = System.Drawing.Color.FromArgb(255, 24, 24, 24);
            var Card = System.Drawing.Color.FromArgb(255, 36, 36, 36);
            var Accent = System.Drawing.Color.FromArgb(255, 98, 100, 245);
            var TextPrimary = System.Drawing.Color.FromArgb(255, 240, 240, 240);
            var TextSecondary = System.Drawing.Color.FromArgb(255, 160, 160, 160);
            var InputBg = System.Drawing.Color.FromArgb(255, 50, 50, 50);
            var Border = System.Drawing.Color.FromArgb(255, 60, 60, 60);
            var Green = System.Drawing.Color.FromArgb(255, 34, 197, 94);
            var Red = System.Drawing.Color.FromArgb(255, 239, 68, 68);
            var PinBtn = System.Drawing.Color.FromArgb(255, 50, 50, 60);

            this.Text = "File Organizer";
            this.ClientSize = new System.Drawing.Size(420, 520);
            this.BackColor = BG;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            string iconPath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "FileLogo.ico");
if (System.IO.File.Exists(iconPath))
    this.Icon = new System.Drawing.Icon(iconPath);

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.Text = "File Organizer";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = TextPrimary;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(0, 40);
            this.lblTitle.Size = new System.Drawing.Size(420, 40);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblSubtitle.Text = "Set up your security to get started.";
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = TextSecondary;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Location = new System.Drawing.Point(0, 85);
            this.lblSubtitle.Size = new System.Drawing.Size(420, 20);
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // SETUP PANEL
            this.panelSetup = new System.Windows.Forms.Panel();
            this.panelSetup.Location = new System.Drawing.Point(30, 120);
            this.panelSetup.Size = new System.Drawing.Size(360, 360);
            this.panelSetup.BackColor = System.Drawing.Color.Transparent;

            this.panelChoose = new System.Windows.Forms.Panel();
            this.panelChoose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChoose.BackColor = System.Drawing.Color.Transparent;

            var lblChoose = new System.Windows.Forms.Label();
            lblChoose.Text = "Choose your security method:";
            lblChoose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblChoose.ForeColor = TextPrimary;
            lblChoose.BackColor = System.Drawing.Color.Transparent;
            lblChoose.Location = new System.Drawing.Point(0, 20);
            lblChoose.Size = new System.Drawing.Size(360, 24);
            lblChoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnChoosePassword = new System.Windows.Forms.Button();
            this.btnChoosePassword.Text = "🔒  Password";
            this.btnChoosePassword.Location = new System.Drawing.Point(30, 70);
            this.btnChoosePassword.Size = new System.Drawing.Size(300, 60);
            this.btnChoosePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnChoosePassword.BackColor = Card;
            this.btnChoosePassword.ForeColor = TextPrimary;
            this.btnChoosePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoosePassword.FlatAppearance.BorderColor = Border;
            this.btnChoosePassword.FlatAppearance.BorderSize = 1;
            this.btnChoosePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoosePassword.Click += btnChoosePassword_Click;

            var lblPassDesc = new System.Windows.Forms.Label();
            lblPassDesc.Text = "Use a custom text password";
            lblPassDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblPassDesc.ForeColor = TextSecondary;
            lblPassDesc.BackColor = System.Drawing.Color.Transparent;
            lblPassDesc.Location = new System.Drawing.Point(30, 136);
            lblPassDesc.Size = new System.Drawing.Size(300, 18);
            lblPassDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnChoosePin = new System.Windows.Forms.Button();
            this.btnChoosePin.Text = "🔢  PIN Code";
            this.btnChoosePin.Location = new System.Drawing.Point(30, 168);
            this.btnChoosePin.Size = new System.Drawing.Size(300, 60);
            this.btnChoosePin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnChoosePin.BackColor = Card;
            this.btnChoosePin.ForeColor = TextPrimary;
            this.btnChoosePin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoosePin.FlatAppearance.BorderColor = Border;
            this.btnChoosePin.FlatAppearance.BorderSize = 1;
            this.btnChoosePin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoosePin.Click += btnChoosePin_Click;

            var lblPinDesc = new System.Windows.Forms.Label();
            lblPinDesc.Text = "Use a 4-digit numeric PIN";
            lblPinDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblPinDesc.ForeColor = TextSecondary;
            lblPinDesc.BackColor = System.Drawing.Color.Transparent;
            lblPinDesc.Location = new System.Drawing.Point(30, 234);
            lblPinDesc.Size = new System.Drawing.Size(300, 18);
            lblPinDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            panelChoose.Controls.Add(lblChoose);
            panelChoose.Controls.Add(btnChoosePassword);
            panelChoose.Controls.Add(lblPassDesc);
            panelChoose.Controls.Add(btnChoosePin);
            panelChoose.Controls.Add(lblPinDesc);

            // PASSWORD SETUP
            this.panelPasswordSetup = new System.Windows.Forms.Panel();
            this.panelPasswordSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPasswordSetup.BackColor = System.Drawing.Color.Transparent;
            this.panelPasswordSetup.Visible = false;

            var lblSetupTitle = new System.Windows.Forms.Label();
            lblSetupTitle.Text = "Create a Password";
            lblSetupTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblSetupTitle.ForeColor = TextPrimary;
            lblSetupTitle.BackColor = System.Drawing.Color.Transparent;
            lblSetupTitle.Location = new System.Drawing.Point(0, 10);
            lblSetupTitle.Size = new System.Drawing.Size(360, 26);
            lblSetupTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            var lblPass1 = new System.Windows.Forms.Label();
            lblPass1.Text = "Password";
            lblPass1.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblPass1.ForeColor = TextSecondary;
            lblPass1.BackColor = System.Drawing.Color.Transparent;
            lblPass1.Location = new System.Drawing.Point(10, 50);
            lblPass1.Size = new System.Drawing.Size(200, 18);

            this.txtSetupPassword = new System.Windows.Forms.TextBox();
            this.txtSetupPassword.Location = new System.Drawing.Point(10, 70);
            this.txtSetupPassword.Size = new System.Drawing.Size(300, 28);
            this.txtSetupPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSetupPassword.BackColor = InputBg;
            this.txtSetupPassword.ForeColor = TextPrimary;
            this.txtSetupPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSetupPassword.UseSystemPasswordChar = true;

            this.btnShowHideSetup = new System.Windows.Forms.Button();
            this.btnShowHideSetup.Text = "👁";
            this.btnShowHideSetup.Location = new System.Drawing.Point(316, 70);
            this.btnShowHideSetup.Size = new System.Drawing.Size(34, 28);
            this.btnShowHideSetup.BackColor = InputBg;
            this.btnShowHideSetup.ForeColor = TextPrimary;
            this.btnShowHideSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHideSetup.FlatAppearance.BorderSize = 0;
            this.btnShowHideSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowHideSetup.Click += btnShowHideSetup_Click;

            var lblPass2 = new System.Windows.Forms.Label();
            lblPass2.Text = "Confirm Password";
            lblPass2.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblPass2.ForeColor = TextSecondary;
            lblPass2.BackColor = System.Drawing.Color.Transparent;
            lblPass2.Location = new System.Drawing.Point(10, 110);
            lblPass2.Size = new System.Drawing.Size(200, 18);

            this.txtSetupConfirm = new System.Windows.Forms.TextBox();
            this.txtSetupConfirm.Location = new System.Drawing.Point(10, 130);
            this.txtSetupConfirm.Size = new System.Drawing.Size(340, 28);
            this.txtSetupConfirm.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSetupConfirm.BackColor = InputBg;
            this.txtSetupConfirm.ForeColor = TextPrimary;
            this.txtSetupConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSetupConfirm.UseSystemPasswordChar = true;

            this.lblSetupError = new System.Windows.Forms.Label();
            this.lblSetupError.Text = "";
            this.lblSetupError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSetupError.ForeColor = Red;
            this.lblSetupError.BackColor = System.Drawing.Color.Transparent;
            this.lblSetupError.Location = new System.Drawing.Point(10, 168);
            this.lblSetupError.Size = new System.Drawing.Size(340, 20);
            this.lblSetupError.Visible = false;

            this.btnConfirmPassword = new System.Windows.Forms.Button();
            this.btnConfirmPassword.Text = "Set Password";
            this.btnConfirmPassword.Location = new System.Drawing.Point(10, 196);
            this.btnConfirmPassword.Size = new System.Drawing.Size(340, 36);
            this.btnConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmPassword.BackColor = Accent;
            this.btnConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPassword.FlatAppearance.BorderSize = 0;
            this.btnConfirmPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmPassword.Click += btnConfirmPassword_Click;

            panelPasswordSetup.Controls.Add(lblSetupTitle);
            panelPasswordSetup.Controls.Add(lblPass1);
            panelPasswordSetup.Controls.Add(txtSetupPassword);
            panelPasswordSetup.Controls.Add(btnShowHideSetup);
            panelPasswordSetup.Controls.Add(lblPass2);
            panelPasswordSetup.Controls.Add(txtSetupConfirm);
            panelPasswordSetup.Controls.Add(lblSetupError);
            panelPasswordSetup.Controls.Add(btnConfirmPassword);

            // PIN SETUP
            this.panelPinSetup = new System.Windows.Forms.Panel();
            this.panelPinSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPinSetup.BackColor = System.Drawing.Color.Transparent;
            this.panelPinSetup.Visible = false;

            this.lblPinSetupPrompt = new System.Windows.Forms.Label();
            this.lblPinSetupPrompt.Text = "Enter a 4-digit PIN:";
            this.lblPinSetupPrompt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPinSetupPrompt.ForeColor = TextPrimary;
            this.lblPinSetupPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblPinSetupPrompt.Location = new System.Drawing.Point(0, 10);
            this.lblPinSetupPrompt.Size = new System.Drawing.Size(360, 24);
            this.lblPinSetupPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pinSetupDisplay = new System.Windows.Forms.Label();
            this.pinSetupDisplay.Text = "○ ○ ○ ○";
            this.pinSetupDisplay.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.pinSetupDisplay.ForeColor = Accent;
            this.pinSetupDisplay.BackColor = System.Drawing.Color.Transparent;
            this.pinSetupDisplay.Location = new System.Drawing.Point(0, 40);
            this.pinSetupDisplay.Size = new System.Drawing.Size(360, 44);
            this.pinSetupDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pinSetupConfirmDisplay = new System.Windows.Forms.Label();
            this.pinSetupConfirmDisplay.Text = "";
            this.pinSetupConfirmDisplay.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.pinSetupConfirmDisplay.ForeColor = Green;
            this.pinSetupConfirmDisplay.BackColor = System.Drawing.Color.Transparent;
            this.pinSetupConfirmDisplay.Location = new System.Drawing.Point(0, 88);
            this.pinSetupConfirmDisplay.Size = new System.Drawing.Size(360, 44);
            this.pinSetupConfirmDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblPinSetupError = new System.Windows.Forms.Label();
            this.lblPinSetupError.Text = "";
            this.lblPinSetupError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPinSetupError.ForeColor = Red;
            this.lblPinSetupError.BackColor = System.Drawing.Color.Transparent;
            this.lblPinSetupError.Location = new System.Drawing.Point(0, 134);
            this.lblPinSetupError.Size = new System.Drawing.Size(360, 20);
            this.lblPinSetupError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPinSetupError.Visible = false;

            string[] pinLabels = { "1","2","3","4","5","6","7","8","9","⌫","0","" };
            for (int i = 0; i < 12; i++)
            {
                if (pinLabels[i] == "") continue;
                int col = i % 3;
                int row = i / 3;
                var pb = new System.Windows.Forms.Button();
                pb.Text = pinLabels[i];
                pb.Location = new System.Drawing.Point(30 + col * 100, 158 + row * 48);
                pb.Size = new System.Drawing.Size(85, 40);
                pb.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
                pb.BackColor = PinBtn;
                pb.ForeColor = TextPrimary;
                pb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                pb.FlatAppearance.BorderSize = 0;
                pb.Cursor = System.Windows.Forms.Cursors.Hand;
                if (pinLabels[i] == "⌫") pb.Tag = "del";
                pb.Click += PinSetupButton_Click;
                panelPinSetup.Controls.Add(pb);
            }

            panelPinSetup.Controls.Add(lblPinSetupPrompt);
            panelPinSetup.Controls.Add(pinSetupDisplay);
            panelPinSetup.Controls.Add(pinSetupConfirmDisplay);
            panelPinSetup.Controls.Add(lblPinSetupError);

            panelSetup.Controls.Add(panelChoose);
            panelSetup.Controls.Add(panelPasswordSetup);
            panelSetup.Controls.Add(panelPinSetup);

            // PASSWORD LOGIN
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelLogin.Location = new System.Drawing.Point(30, 120);
            this.panelLogin.Size = new System.Drawing.Size(360, 280);
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.Visible = false;

            var lblPassLogin = new System.Windows.Forms.Label();
            lblPassLogin.Text = "Password";
            lblPassLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblPassLogin.ForeColor = TextSecondary;
            lblPassLogin.BackColor = System.Drawing.Color.Transparent;
            lblPassLogin.Location = new System.Drawing.Point(10, 20);
            lblPassLogin.Size = new System.Drawing.Size(200, 18);

            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.txtLoginPassword.Location = new System.Drawing.Point(10, 40);
            this.txtLoginPassword.Size = new System.Drawing.Size(300, 28);
            this.txtLoginPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtLoginPassword.BackColor = InputBg;
            this.txtLoginPassword.ForeColor = TextPrimary;
            this.txtLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginPassword.UseSystemPasswordChar = true;
            this.txtLoginPassword.KeyDown += (s, e) => { if (e.KeyCode == System.Windows.Forms.Keys.Enter) btnLogin_Click(s, e); };

            this.btnShowHide = new System.Windows.Forms.Button();
            this.btnShowHide.Text = "👁";
            this.btnShowHide.Location = new System.Drawing.Point(316, 40);
            this.btnShowHide.Size = new System.Drawing.Size(34, 28);
            this.btnShowHide.BackColor = InputBg;
            this.btnShowHide.ForeColor = TextPrimary;
            this.btnShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHide.FlatAppearance.BorderSize = 0;
            this.btnShowHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowHide.Click += btnShowHide_Click;

            this.lblLoginError = new System.Windows.Forms.Label();
            this.lblLoginError.Text = "";
            this.lblLoginError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoginError.ForeColor = Red;
            this.lblLoginError.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginError.Location = new System.Drawing.Point(10, 78);
            this.lblLoginError.Size = new System.Drawing.Size(340, 20);
            this.lblLoginError.Visible = false;

            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogin.Text = "Unlock";
            this.btnLogin.Location = new System.Drawing.Point(10, 106);
            this.btnLogin.Size = new System.Drawing.Size(340, 38);
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.BackColor = Accent;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Click += btnLogin_Click;

            panelLogin.Controls.Add(lblPassLogin);
            panelLogin.Controls.Add(txtLoginPassword);
            panelLogin.Controls.Add(btnShowHide);
            panelLogin.Controls.Add(lblLoginError);
            panelLogin.Controls.Add(btnLogin);

            // PIN LOGIN
            this.panelPinLogin = new System.Windows.Forms.Panel();
            this.panelPinLogin.Location = new System.Drawing.Point(30, 110);
            this.panelPinLogin.Size = new System.Drawing.Size(360, 380);
            this.panelPinLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelPinLogin.Visible = false;

            this.pinLoginDisplay = new System.Windows.Forms.Label();
            this.pinLoginDisplay.Text = "○ ○ ○ ○";
            this.pinLoginDisplay.Font = new System.Drawing.Font("Segoe UI", 26F);
            this.pinLoginDisplay.ForeColor = Accent;
            this.pinLoginDisplay.BackColor = System.Drawing.Color.Transparent;
            this.pinLoginDisplay.Location = new System.Drawing.Point(0, 10);
            this.pinLoginDisplay.Size = new System.Drawing.Size(360, 54);
            this.pinLoginDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblPinLoginError = new System.Windows.Forms.Label();
            this.lblPinLoginError.Text = "";
            this.lblPinLoginError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPinLoginError.ForeColor = Red;
            this.lblPinLoginError.BackColor = System.Drawing.Color.Transparent;
            this.lblPinLoginError.Location = new System.Drawing.Point(0, 68);
            this.lblPinLoginError.Size = new System.Drawing.Size(360, 20);
            this.lblPinLoginError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPinLoginError.Visible = false;

            string[] loginPinLabels = { "1","2","3","4","5","6","7","8","9","⌫","0","" };
            for (int i = 0; i < 12; i++)
            {
                if (loginPinLabels[i] == "") continue;
                int col = i % 3;
                int row = i / 3;
                var pb = new System.Windows.Forms.Button();
                pb.Text = loginPinLabels[i];
                pb.Location = new System.Drawing.Point(30 + col * 100, 96 + row * 68);
                pb.Size = new System.Drawing.Size(85, 55);
                pb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
                pb.BackColor = PinBtn;
                pb.ForeColor = TextPrimary;
                pb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                pb.FlatAppearance.BorderSize = 0;
                pb.Cursor = System.Windows.Forms.Cursors.Hand;
                if (loginPinLabels[i] == "⌫") pb.Tag = "del";
                pb.Click += PinLoginButton_Click;
                panelPinLogin.Controls.Add(pb);
            }

            panelPinLogin.Controls.Add(pinLoginDisplay);
            panelPinLogin.Controls.Add(lblPinLoginError);

            // ASSEMBLE
            this.Controls.Add(lblTitle);
            this.Controls.Add(lblSubtitle);
            this.Controls.Add(panelSetup);
            this.Controls.Add(panelLogin);
            this.Controls.Add(panelPinLogin);

            this.SuspendLayout();
            this.ResumeLayout(false);
        }

        // Controls
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelSetup;
        private System.Windows.Forms.Panel panelChoose;
        private System.Windows.Forms.Panel panelPasswordSetup;
        private System.Windows.Forms.Panel panelPinSetup;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelPinLogin;
        private System.Windows.Forms.Button btnChoosePassword;
        private System.Windows.Forms.Button btnChoosePin;
        private System.Windows.Forms.TextBox txtSetupPassword;
        private System.Windows.Forms.TextBox txtSetupConfirm;
        private System.Windows.Forms.Button btnConfirmPassword;
        private System.Windows.Forms.Button btnShowHideSetup;
        private System.Windows.Forms.Label lblSetupError;
        private System.Windows.Forms.Label lblPinSetupPrompt;
        private System.Windows.Forms.Label pinSetupDisplay;
        private System.Windows.Forms.Label pinSetupConfirmDisplay;
        private System.Windows.Forms.Label lblPinSetupError;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Label lblLoginError;
        private System.Windows.Forms.Label pinLoginDisplay;
        private System.Windows.Forms.Label lblPinLoginError;
    }
}