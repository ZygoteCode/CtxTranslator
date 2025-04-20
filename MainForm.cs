using MetroSuite;
using System;
using System.IO;
using System.Windows.Forms;
using OpenAI_API;
using OpenAI_API.Chat;
using OpenAI_API.Models;

public partial class MainForm : MetroForm
{
    private const string _initialPrompt = "Da ora in poi, ogni prompt che ti fornirò sarà di questo formato:\r\n\r\n" +
        "Lingua del testo sorgente: specifica la lingua del testo sorgente da tradurre\r\n" +
        "Lingua del testo output: specifica la lingua del testo tradotto in output\r\n" +
        "Testo sorgente: specifica il testo sorgente da tradurre, incluso fra i doppi apici\r\n\r\n" +
        "Ogni qualvolta che ti manderò un prompt, quindi, dovrai rispondere solo con la traduzione del testo sorgente sulla base degli altri fattori che ti ho specificato, evita quindi di rispondere con qualsiasi altra considerazione. Grazie.";
    
    private string _languagePrompt = "Lingua del testo sorgente: $INPUT_LANGUAGE\r\n" +
        "Lingua del testo output: $OUTPUT_LANGUAGE\r\n" +
        "Testo sorgente: \"$SOURCE_TEXT\"";

    private OpenAIAPI _api;
    private Conversation _chat;

    public MainForm()
    {
        InitializeComponent();

        guna2ComboBox1.SelectedIndex = 0;
        guna2ComboBox2.SelectedIndex = 1;

        if (File.Exists("openai_api_key.txt"))
        {
            string openaiApiKey = File.ReadAllText("openai_api_key.txt");
            _api = new OpenAIAPI(openaiApiKey);
            _chat = _api.Chat.CreateConversation();
            _chat.Model = Model.GPT4_Turbo;
            _chat.RequestParameters.Temperature = 1.0;
            _chat.AppendSystemMessage(_initialPrompt);
        }
        else
        {
            MessageBox.Show("The file 'openai_api_key.txt' was not found.");
            Environment.Exit(0);
        }
    }

    private void guna2Button1_Click(object sender, System.EventArgs e)
    {
        ToggleElements(true);

        if (guna2ComboBox1.SelectedIndex == guna2ComboBox2.SelectedIndex)
        {
            guna2TextBox2.Text = guna2TextBox1.Text;
        }

        string inputLanguage = guna2ComboBox3.Items[guna2ComboBox1.SelectedIndex].ToString();
        string outputLanguage = guna2ComboBox3.Items[guna2ComboBox2.SelectedIndex].ToString();
        string languagePrompt = CreateLanguagePrompt(inputLanguage, outputLanguage, guna2TextBox1.Text);

        Translate(languagePrompt);
    }

    private async void Translate(string languagePrompt)
    {
        _chat.AppendUserInput(languagePrompt);
        string outputResult = await _chat.GetResponseFromChatbotAsync();

        if (outputResult.StartsWith("\"") && outputResult.EndsWith("\""))
        {
            outputResult = outputResult.Substring(1);

            if (outputResult.EndsWith("\""))
            {
                outputResult = outputResult.Substring(0, outputResult.Length - 1);
            }
        }

        guna2TextBox2.Text = outputResult;
        ToggleElements(false);
    }

    private string CreateLanguagePrompt(string inputLanguage, string outputLanguage, string sourceText)
    {
        return _languagePrompt.Replace("$INPUT_LANGUAGE", inputLanguage)
            .Replace("$OUTPUT_LANGUAGE", outputLanguage)
            .Replace("$SOURCE_TEXT", sourceText);
    }

    private void ToggleElements(bool disable)
    {
        guna2TextBox1.ReadOnly = disable;
        guna2Button1.Enabled = !disable;
        guna2ComboBox1.Enabled = !disable;
        guna2ComboBox2.Enabled = !disable;
    }
}