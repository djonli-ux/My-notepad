using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HwUniversity
{
    public partial class TextEditor : Form
    {
        private string? FileContent { get; set; }
        private string? FilePath { get; set; }
        private Regex reg;
        public TextEditor()
        {
            InitializeComponent();
        }

        #region System events
        private void btnOpen_Click(object sender, EventArgs e)
        {
            FilePath = string.Empty;
            FileContent = string.Empty;

            OpeningFile();
            SavingFileData();

            var statistics = GetStatistics(FileContent);
            UpdateStatisticsDisplay(statistics);
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStatisticsLabels(true);
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStatisticsLabels(false);
        }

        private void chooseAnoterFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpeningFile();
            SavingFileData();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This's 「 ✦ Jonatan's ✦ 」 text editor!", "Antiplagiate warning⚠️", MessageBoxButtons.OK);
        }

        private void findAnyEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindEmails();
        }

        private void findUniqueWordInTehTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindUniqueWordsAndDisplay(FileContent);
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            SaveDataToFile();
        }

        private void uploadArticleFromWebsiteZnuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadingArticleFromWebsite("https://www.znu.edu.ua/cms/index.php?action=news/view&start=0&site_id=27&lang=ukr");
        }
        #endregion

        #region MyMethods
        private void UpdateStatisticsDisplay((int characters, int words, int paragraphs, int vowels, int consonants) statistics)
        {
            lblCharacters.Text = $"Characters: {statistics.characters}";
            lblWords.Text = $"Words: {statistics.words}";
            lblParagraphs.Text = $"Paragraphs: {statistics.paragraphs}";
            lblVowels.Text = $"Vowels: {statistics.vowels}";
            lblConsonants.Text = $"Consonants: {statistics.consonants}";
        }

        private (int characters, int words, int paragraphs, int vowels, int consonants) GetStatistics(string text)
        {
            int characters = text.Length;
            int words = text.Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int paragraphs = text.Split(new[] { "\r\n\r\n", "\n\n" }, StringSplitOptions.RemoveEmptyEntries).Length;
            int vowels = text.Count(c => "aeiouAEIOU".Contains(c));
            int consonants = text.Count(c => char.IsLetter(c) && !"aeiouAEIOU".Contains(c));

            return (characters, words, paragraphs, vowels, consonants);
        }

        private void OpeningFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        FileContent = reader.ReadToEnd();
                    }
                }
            }
        }

        private void SavingFileData()
        {
            tbFileName.PlaceholderText = FilePath;
            rtField.Text = FileContent;
        }

        private void ShowStatisticsLabels(bool visible)
        {
            lblCharacters.Visible = visible;
            lblWords.Visible = visible;
            lblVowels.Visible = visible;
            lblConsonants.Visible = visible;
            lblParagraphs.Visible = visible;
        }

        private void FindEmails()
        {
            string emailPattern = @"\b[\w\.-]+@[\w\.-]+\.\w+\b";

            try
            {
                reg = new Regex(emailPattern);

                MatchCollection matches = reg.Matches(FileContent);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                        MessageBox.Show($"Email: {match.Value}");
                }
                else
                    MessageBox.Show("No emails found!", "Not found", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private List<string> FindUniqueWords(string text)
        {
            var uniqueWords = new List<string>();
            var wordCounts = new Dictionary<string, int>();

            string[] words = text.Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                string cleanedWord = word.Trim(new char[] { '.', ',', '!', '?' });

                if (wordCounts.ContainsKey(cleanedWord))
                    wordCounts[cleanedWord]++;
                else
                    wordCounts[cleanedWord] = 1;
            }

            foreach (var kvp in wordCounts)
            {
                if (kvp.Value == 1)
                    uniqueWords.Add(kvp.Key);
            }

            return uniqueWords;
        }

        private void FindUniqueWordsAndDisplay(string text)
        {
            List<string> uniqueWords = FindUniqueWords(text);

            if (uniqueWords.Count > 0)
            {
                MessageBox.Show("Unique words in the text:\n\n" + string.Join(", ", uniqueWords));
            }
            else
            {
                MessageBox.Show("No found any unique words", "Not Found", MessageBoxButtons.OK);
            }
        }

        private void UploadingArticleFromWebsite(string url)
        {
            WebRequest request = WebRequest.Create(url);

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(dataStream);

                        string content = reader.ReadToEnd();
                        
                        rtField.Text = content;
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void SaveDataToFile()
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.Title = "Save an txt file";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, rtField.Text);
                    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        #endregion
    }
}