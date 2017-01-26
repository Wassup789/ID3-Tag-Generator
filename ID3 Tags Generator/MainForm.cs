using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ID3_Tags_Generator
{
    public partial class MainForm : Form
    {
        public ITunesRawData CurrentData = null;
        public ITunesRawData_Result CurrentCollectionData = null;
        public static string UID;
        public string TemporaryArtworkPath;

        public MainForm()
        {
            InitializeComponent();

            UID = RandomString(10);
            TemporaryArtworkPath = System.IO.Path.GetTempPath() + "artwork_" + UID + ".jpg";
        }

        private void its_searchQueryAction(object sender = null, EventArgs e = null)
        {
            GenerateITunesRequest(its_searchQueryInput.Text);
        }
        private void its_searchQueryKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                its_searchQueryAction();
        }

        public const int REQUEST_FILTER_NORMAL = 0;
        public const int REQUEST_FILTER_BRACKETS = 1;
        public const int REQUEST_FILTER_ALL = 2; //Includes parentheses
        public void GenerateITunesRequest(string title, int filter = REQUEST_FILTER_NORMAL)
        {
            title = parseITunesTitle(title);

            its_dataSelector.DroppedDown = false;
            its_dataSelector.SelectedIndex = -1;
            its_dataSelector.Items.Clear();

            string url = "https://itunes.apple.com/search?term=" + Uri.EscapeUriString(title) + "&entity=song&country=us&limit=50";
            string data = GenerateGetRequest(url);

            CurrentData = new JavaScriptSerializer().Deserialize<ITunesRawData>(data);

            if (filter != REQUEST_FILTER_ALL && CurrentData.results.Count < 1)
            {
                string output = its_searchQueryInput.Text;
                output = Regex.Replace(output, @" ?\[.*?\]", string.Empty); // Remove brackets and parentheses to broaden search
                output = (filter == REQUEST_FILTER_BRACKETS ? Regex.Replace(output, @" ?\(.*?\)", string.Empty) : output); // Remove parentheses post because ex: "(Original Mix)" or "(Extended Mix)"

                GenerateITunesRequest(output, ++filter);

                return;
            }

            ParseITunesData();
        }

        private string parseITunesTitle(string title)
        {
            return title.Replace("&", " "); // iTunes Search API does not like the ampersand sign
        }

        public void ParseITunesData()
        {
            foreach (ITunesRawData_Result item in CurrentData.results)
            {
                its_dataSelector.Items.Add(item.artistName + " - [" + item.collectionName + "] " + item.trackName);
            }

            if (CurrentData.results.Count < 1)
                its_dataSelector.Items.Add("No tracks found");
            
            its_dataSelector.DroppedDown = true;
        }

        public DataGridViewRow GenerateDataRow(string name, string value)
        {
            DataGridViewRow dataGridViewRow = new DataGridViewRow();

            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell());
            dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell());

            dataGridViewRow.Cells[0].Value = name;
            dataGridViewRow.Cells[1].Value = value;

            return dataGridViewRow;
        }

        private void its_dataSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (its_dataSelector.SelectedIndex == -1 || CurrentData.results.Count < 1)
                return;

            ITunesRawData_Result data = CurrentData.results[its_dataSelector.SelectedIndex];

            if (CurrentCollectionData == null || !CurrentCollectionData.collectionId.Equals(data.collectionId))
            {
                string url = "https://itunes.apple.com/lookup?id=" + data.collectionId + "&entity=album";
                string data2 = GenerateGetRequest(url);

                CurrentCollectionData = new JavaScriptSerializer().Deserialize<ITunesRawData>(data2).results[0];
            }

            DateTime date = DateTime.Parse(data.releaseDate);

            id3_dataGridView.Rows.Clear();

            id3_dataGridView.Rows.Add(GenerateDataRow("Artist", data.artistName));
            id3_dataGridView.Rows.Add(GenerateDataRow("Title", data.trackName));
            id3_dataGridView.Rows.Add(GenerateDataRow("Album", data.collectionName));
            id3_dataGridView.Rows.Add(GenerateDataRow("Track", data.trackNumber + "/" + data.trackCount));
            id3_dataGridView.Rows.Add(GenerateDataRow("Year", "" + date.Year));
            id3_dataGridView.Rows.Add(GenerateDataRow("Genre", data.primaryGenreName));
            id3_dataGridView.Rows.Add(GenerateDataRow("Comment", ""));
            id3_dataGridView.Rows.Add(GenerateDataRow("Album Artist", CurrentCollectionData.artistName));
            id3_dataGridView.Rows.Add(GenerateDataRow("Album Sort", data.collectionName));
            id3_dataGridView.Rows.Add(GenerateDataRow("Artist Sort", data.artistName));
            id3_dataGridView.Rows.Add(GenerateDataRow("Compilation", "0"));
            id3_dataGridView.Rows.Add(GenerateDataRow("Content Rating", data.trackExplicitness.Equals("notExplicit") ? "None" : "1"));
            id3_dataGridView.Rows.Add(GenerateDataRow("Copyright", CurrentCollectionData.copyright));
            id3_dataGridView.Rows.Add(GenerateDataRow("Disc", data.discNumber + "/" + data.discCount));
            id3_dataGridView.Rows.Add(GenerateDataRow("MediaType", "Music"));
            id3_dataGridView.Rows.Add(GenerateDataRow("Play Gap", "0"));
            id3_dataGridView.Rows.Add(GenerateDataRow("Title Sort", data.trackName));
            
            albumArt_picture.LoadAsync(data.GetArtwork(albumArt_picture.Width));
        }

        public string GenerateGetRequest(string url)
        {
            Console.WriteLine(string.Format("Creating GET request to: \"{0}\"", url));

            string output = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                output = reader.ReadToEnd();
            }

            return output;
        }

        private void file_selectFileButton_Click(object sender, EventArgs e)
        {
            if (mainOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                file_selectFileText.Text = mainOpenFileDialog.FileName;
            }
        }

        private void file_actionApplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (file_selectFileText.Text.Length > 0)
                {
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(new Uri(CurrentData.results[its_dataSelector.SelectedIndex].GetArtwork()),
                            TemporaryArtworkPath);
                    }

                    string metadata = string.Empty;
                    foreach (DataGridViewRow row in id3_dataGridView.Rows)
                    {
                        if (row.Cells[0].Value == null || row.Cells[1].Value == null ||
                            ((string) row.Cells[0].Value).Length < 1 || ((string) row.Cells[1].Value).Length < 1)
                            continue;

                        metadata += string.Format("-metadata \"{0}={1}\" ",
                            ParseMetadataTitle((string) row.Cells[0].Value), (string) row.Cells[1].Value);
                    }

                    string command =
                        string.Format(
                            "-i \"{0}\" -i \"{1}\" -map 0:0 -map 1:0 -y -map_metadata -1 -id3v2_version 3 -acodec copy -vcodec mjpeg {2}-metadata:s:v comment=\"Cover (Front)\" \"{3}\"",
                            ParseTemporaryFile(file_selectFileText.Text), TemporaryArtworkPath, metadata,
                            file_selectFileText.Text);

                    File.Copy(file_selectFileText.Text, ParseTemporaryFile(file_selectFileText.Text));

                    Process process = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = "ffmpeg.exe",
                            Arguments = command,
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        }
                    };
                    process.Start();
                    process.WaitForExit();

                    File.Delete(ParseTemporaryFile(file_selectFileText.Text));
                    File.Delete(TemporaryArtworkPath);

                    MessageBox.Show("ID3 Tags successfully applied", "Processing Complete", MessageBoxButtons.OK,
                        MessageBoxIcon.None);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An unknown error has occured\n\nMessage: " + ex.Message, "Error processing file", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public string ParseTemporaryFile(string file)
        {
            string[] arr = file.Split('.');
            arr[arr.Length - 2 > -1 ? arr.Length - 2 : arr.Length - 1] += "_" + UID;

            return string.Join(".", arr);
        }

        public string[][] id3Map =
        new[]{
            new[]{"Artist", "artist"},
            new[]{"Title", "title"},
            new[]{"Album", "album"},
            new[]{"Track", "track"},
            new[]{"Year", "date"},
            new[]{"Genre", "genre"},
            new[]{"Comment", "comment"},
            new[]{"Album Artist", "album_artist"},
            new[]{"Album Sort", "album-sort"},
            new[]{"Artist Sort", "artist-sort"},
            new[]{"Compilation", "compilation"},
            new[]{"Copyright", "copyright"},
            new[]{"Disc", "disc"},
            new[]{"Title Sort", "title-sort"}
        };
        public string ParseMetadataTitle(string title)
        {
            /*foreach (string[] comparator in id3Map)
            {
                if (title.Equals(comparator[0]))
                    return comparator[1];
            }*/
            return title;
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
