namespace PasswordChecker
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            Lbl_Encrypt = new Label();
            Txt_Encrypt = new TextBox();
            Btn_Up = new Button();
            Btn_Down = new Button();
            Txt_Decrypt = new TextBox();
            Lbl_Decrypt = new Label();
            Ss_Status = new StatusStrip();
            Tss_Message = new ToolStripStatusLabel();
            Btn_Clear = new Button();
            Ss_Status.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_Encrypt
            // 
            Lbl_Encrypt.ForeColor = Color.Red;
            Lbl_Encrypt.Location = new Point(12, 13);
            Lbl_Encrypt.Name = "Lbl_Encrypt";
            Lbl_Encrypt.Size = new Size(143, 19);
            Lbl_Encrypt.TabIndex = 0;
            Lbl_Encrypt.Text = "Password after Encrypt";
            Lbl_Encrypt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Txt_Encrypt
            // 
            Txt_Encrypt.Location = new Point(161, 13);
            Txt_Encrypt.Multiline = true;
            Txt_Encrypt.Name = "Txt_Encrypt";
            Txt_Encrypt.Size = new Size(350, 19);
            Txt_Encrypt.TabIndex = 1;
            Txt_Encrypt.WordWrap = false;
            Txt_Encrypt.Enter += Txt_Encrypt_Enter;
            // 
            // Btn_Up
            // 
            Btn_Up.Location = new Point(211, 38);
            Btn_Up.Name = "Btn_Up";
            Btn_Up.Size = new Size(45, 23);
            Btn_Up.TabIndex = 3;
            Btn_Up.Text = "▲";
            Btn_Up.UseVisualStyleBackColor = true;
            Btn_Up.Click += Btn_Up_Click;
            // 
            // Btn_Down
            // 
            Btn_Down.Location = new Point(160, 38);
            Btn_Down.Name = "Btn_Down";
            Btn_Down.Size = new Size(45, 23);
            Btn_Down.TabIndex = 2;
            Btn_Down.Text = "▼";
            Btn_Down.UseVisualStyleBackColor = true;
            Btn_Down.Click += Btn_Down_Click;
            // 
            // Txt_Decrypt
            // 
            Txt_Decrypt.Location = new Point(161, 67);
            Txt_Decrypt.Multiline = true;
            Txt_Decrypt.Name = "Txt_Decrypt";
            Txt_Decrypt.Size = new Size(350, 19);
            Txt_Decrypt.TabIndex = 6;
            Txt_Decrypt.WordWrap = false;
            Txt_Decrypt.Enter += Txt_Decrypt_Enter;
            // 
            // Lbl_Decrypt
            // 
            Lbl_Decrypt.ForeColor = Color.Blue;
            Lbl_Decrypt.Location = new Point(12, 67);
            Lbl_Decrypt.Name = "Lbl_Decrypt";
            Lbl_Decrypt.Size = new Size(143, 19);
            Lbl_Decrypt.TabIndex = 5;
            Lbl_Decrypt.Text = "Password after Decrypt";
            Lbl_Decrypt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Ss_Status
            // 
            Ss_Status.Items.AddRange(new ToolStripItem[] { Tss_Message });
            Ss_Status.Location = new Point(0, 251);
            Ss_Status.Name = "Ss_Status";
            Ss_Status.Size = new Size(686, 22);
            Ss_Status.SizingGrip = false;
            Ss_Status.TabIndex = 6;
            // 
            // Tss_Message
            // 
            Tss_Message.Name = "Tss_Message";
            Tss_Message.Size = new Size(0, 17);
            // 
            // Btn_Clear
            // 
            Btn_Clear.Location = new Point(262, 38);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Size = new Size(45, 23);
            Btn_Clear.TabIndex = 4;
            Btn_Clear.Text = "Clear";
            Btn_Clear.UseVisualStyleBackColor = true;
            Btn_Clear.Click += Btn_Clear_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(686, 273);
            Controls.Add(Btn_Clear);
            Controls.Add(Ss_Status);
            Controls.Add(Txt_Decrypt);
            Controls.Add(Lbl_Decrypt);
            Controls.Add(Btn_Down);
            Controls.Add(Btn_Up);
            Controls.Add(Txt_Encrypt);
            Controls.Add(Lbl_Encrypt);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(545, 195);
            Name = "FrmMain";
            Text = "PassWord Checker";
            Load += FrmMain_Load;
            KeyDown += FrmMain_KeyDown;
            Ss_Status.ResumeLayout(false);
            Ss_Status.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Encrypt;
        private TextBox Txt_Encrypt;
        private Button Btn_Up;
        private Button Btn_Down;
        private TextBox Txt_Decrypt;
        private Label Lbl_Decrypt;
        private StatusStrip Ss_Status;
        private ToolStripStatusLabel Tss_Message;
        private Button Btn_Clear;
    }
}
