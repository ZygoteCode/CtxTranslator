partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox3 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(849, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(798, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(153)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(29, 109);
            this.guna2TextBox1.Multiline = true;
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.SystemColors.ControlDark;
            this.guna2TextBox1.PlaceholderText = "Text to translate";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(420, 420);
            this.guna2TextBox1.TabIndex = 2;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownHeight = 420;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.DropDownWidth = 420;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.guna2ComboBox1.IntegralHeight = false;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Albanian",
            "Arabic",
            "Armenian",
            "Awadhi",
            "Azerbaijani",
            "Bashkir",
            "Basque",
            "Belarusian",
            "Bengali",
            "Bojpuri",
            "Bosnian",
            "Brazilian Portuguese",
            "Bulgarian",
            "Cantonese (Yue)",
            "Catalan",
            "Chattisgarhi",
            "Chinese",
            "Croatian",
            "Czech",
            "Danish",
            "Dogri",
            "Dutch",
            "English",
            "Estonian",
            "Faroese",
            "Finnish",
            "French",
            "Galician",
            "Georgian",
            "German",
            "Greek",
            "Gujarati",
            "Haryanvi",
            "Hindi",
            "Hungarian",
            "Indonesian Irish",
            "Italian",
            "Japanese",
            "Javanese",
            "Kannada",
            "Kashmir",
            "kazakh",
            "Conkani",
            "Korean",
            "Kyrgyzstan",
            "Latvian",
            "Lithuanian",
            "Macedonian",
            "Maithili",
            "Malaysian",
            "Maltese",
            "Mandarin",
            "Mandarin Chinese",
            "Marathi",
            "Marwari",
            "Min Nan",
            "Moldovan",
            "Mongolian",
            "Montenegrin",
            "Nepalese",
            "Norwegian",
            "Oria",
            "Pashto",
            "Persian (Farsi)",
            "Polish",
            "Portuguese",
            "Punjabi",
            "Rajasthani",
            "Romanian",
            "Russian",
            "Sanskrit",
            "Santa them",
            "Serbian",
            "Sindhi",
            "Sinhalese",
            "Slovak",
            "Slovenian",
            "Slovenian",
            "Spanish",
            "Swahili",
            "Swedish",
            "Tajik",
            "Tamil",
            "Tartar",
            "Telugu",
            "Thai",
            "Turkish",
            "Turkmen",
            "Ukrainian",
            "Urdu",
            "Uzbek",
            "Vietnamese",
            "Welsh",
            "Wu"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(29, 63);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(420, 36);
            this.guna2ComboBox1.TabIndex = 3;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Animated = true;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(153)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(455, 109);
            this.guna2TextBox2.Multiline = true;
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderForeColor = System.Drawing.SystemColors.ControlDark;
            this.guna2TextBox2.PlaceholderText = "Output translated text";
            this.guna2TextBox2.ReadOnly = true;
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(420, 420);
            this.guna2TextBox2.TabIndex = 4;
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownHeight = 420;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.guna2ComboBox2.IntegralHeight = false;
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.Items.AddRange(new object[] {
            "Albanian",
            "Arabic",
            "Armenian",
            "Awadhi",
            "Azerbaijani",
            "Bashkir",
            "Basque",
            "Belarusian",
            "Bengali",
            "Bojpuri",
            "Bosnian",
            "Brazilian Portuguese",
            "Bulgarian",
            "Cantonese (Yue)",
            "Catalan",
            "Chattisgarhi",
            "Chinese",
            "Croatian",
            "Czech",
            "Danish",
            "Dogri",
            "Dutch",
            "English",
            "Estonian",
            "Faroese",
            "Finnish",
            "French",
            "Galician",
            "Georgian",
            "German",
            "Greek",
            "Gujarati",
            "Haryanvi",
            "Hindi",
            "Hungarian",
            "Indonesian Irish",
            "Italian",
            "Japanese",
            "Javanese",
            "Kannada",
            "Kashmir",
            "kazakh",
            "Conkani",
            "Korean",
            "Kyrgyzstan",
            "Latvian",
            "Lithuanian",
            "Macedonian",
            "Maithili",
            "Malaysian",
            "Maltese",
            "Mandarin",
            "Mandarin Chinese",
            "Marathi",
            "Marwari",
            "Min Nan",
            "Moldovan",
            "Mongolian",
            "Montenegrin",
            "Nepalese",
            "Norwegian",
            "Oria",
            "Pashto",
            "Persian (Farsi)",
            "Polish",
            "Portuguese",
            "Punjabi",
            "Rajasthani",
            "Romanian",
            "Russian",
            "Sanskrit",
            "Santa them",
            "Serbian",
            "Sindhi",
            "Sinhalese",
            "Slovak",
            "Slovenian",
            "Slovenian",
            "Spanish",
            "Swahili",
            "Swedish",
            "Tajik",
            "Tamil",
            "Tartar",
            "Telugu",
            "Thai",
            "Turkish",
            "Turkmen",
            "Ukrainian",
            "Urdu",
            "Uzbek",
            "Vietnamese",
            "Welsh",
            "Wu"});
            this.guna2ComboBox2.Location = new System.Drawing.Point(455, 63);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(420, 36);
            this.guna2ComboBox2.TabIndex = 5;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(153)))));
            this.guna2Button1.Location = new System.Drawing.Point(361, 538);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "Translate now";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2ComboBox3
            // 
            this.guna2ComboBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox3.DropDownHeight = 420;
            this.guna2ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox3.DropDownWidth = 420;
            this.guna2ComboBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2ComboBox3.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.guna2ComboBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.guna2ComboBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.guna2ComboBox3.IntegralHeight = false;
            this.guna2ComboBox3.ItemHeight = 30;
            this.guna2ComboBox3.Items.AddRange(new object[] {
            "Albanese",
            "Arabo",
            "armeno",
            "Awadhi",
            "Azero",
            "Baschiro",
            "Basco",
            "Bielorusso",
            "Bengalese",
            "Bojpuri",
            "Bosniaco",
            "Portoghese Brasiliano",
            "Bulgaro",
            "Cantonese (Yue)",
            "Catalano",
            "Chattisgarhi",
            "Cinese",
            "Croato",
            "Ceco",
            "Danese",
            "Dogri",
            "Olandese",
            "Inglese",
            "Estone",
            "Faroese",
            "Finlandese",
            "Francese",
            "Galiziano",
            "Georgiano",
            "Tedesco",
            "Greco",
            "Gujarati",
            "Haryanvi",
            "Hindi",
            "Ungherese",
            "IndonesianoIrlandese",
            "Italiano",
            "Giapponese",
            "Giavanese",
            "Kannada",
            "Kashmir",
            "kazako",
            "Conkani",
            "Coreano",
            "Kirghizistan",
            "Lettone",
            "Lituano",
            "Macedone",
            "Maithili",
            "Malese",
            "maltese",
            "Mandarino",
            "Cinese mandarino",
            "Marathi",
            "Marwari",
            "Min Nan",
            "Moldavo",
            "Mongolo",
            "Montenegrino",
            "Nepalese",
            "Norvegese",
            "Oria",
            "Pashtu",
            "Persiano (Farsi)",
            "Polacco",
            "Portoghese",
            "Punjabi",
            "Rajasthani",
            "Rumeno",
            "Russo",
            "Sanscrito",
            "Santali",
            "Serbo",
            "Sindhi",
            "Singalese",
            "Slovacco",
            "Sloveno",
            "Sloveno",
            "Spagnolo",
            "Swahili",
            "Svedese",
            "Tagico",
            "Tamil",
            "Tartaro",
            "Telugu",
            "Tailandese",
            "Turco",
            "Turkmeno",
            "Ucraino",
            "Urdu",
            "Uzbeco",
            "Vietnamita",
            "Gallese",
            "Wu"});
            this.guna2ComboBox3.Location = new System.Drawing.Point(874, 556);
            this.guna2ComboBox3.Name = "guna2ComboBox3";
            this.guna2ComboBox3.Size = new System.Drawing.Size(20, 36);
            this.guna2ComboBox3.TabIndex = 7;
            this.guna2ComboBox3.Visible = false;
            // 
            // MainForm
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 608);
            this.Controls.Add(this.guna2ComboBox3);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2ComboBox2);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.State = MetroSuite.MetroForm.FormState.Normal;
            this.Style = MetroSuite.Design.Style.Dark;
            this.Text = "CtxTranslator";
            this.ResumeLayout(false);

    }

    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
    private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
    private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
    private Guna.UI2.WinForms.Guna2Button guna2Button1;
    private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox3;
}