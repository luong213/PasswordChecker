namespace PasswordChecker
{
    public partial class FrmMain : Form
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain());
        }
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ResetMessage();
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Up)
            {
                Btn_Up_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Down)
            {
                Btn_Down_Click(sender, e);
            }
        }

        private void Txt_Encrypt_Enter(object sender, EventArgs e)
        {
            ResetMessage();
        }

        private void Txt_Decrypt_Enter(object sender, EventArgs e)
        {
            ResetMessage();
        }

        private void Btn_Down_Click(object sender, EventArgs e)
        {
            ResetMessage();
            if (this.Txt_Encrypt.Text == string.Empty || this.Txt_Encrypt.Text == null)
            {
                SetMessage("Input the encrypted password.");
                return;
            }
            try
            {
                this.Txt_Decrypt.Text = PasswordTransfer.Decrypt(this.Txt_Encrypt.Text);
            }
            catch (Exception ex)
            {
                SetMessage(ex.Message);
            }
        }

        private void Btn_Up_Click(object sender, EventArgs e)
        {
            ResetMessage();
            try
            {
                this.Txt_Encrypt.Text = PasswordTransfer.Encrypt(this.Txt_Decrypt.Text);
            }
            catch (Exception ex)
            {
                SetMessage(ex.Message);
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            this.Txt_Decrypt.Text = string.Empty;
            this.Txt_Encrypt.Text = string.Empty;
            this.Txt_Encrypt.Focus();
        }

        private void ResetMessage()
        {
            this.Tss_Message.Text = string.Empty;
        }

        private void SetMessage(string message)
        {
            this.Tss_Message.Text = message;
        }
    }
}