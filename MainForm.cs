using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cgm23
{
    public partial class MainForm : Form
    {
        public List<Charts> Tags = new List<Charts>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Lees_AS_uit(string AS, string path)
        {
            StringBuilder woord = new StringBuilder();

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0)
                    {
                        char a = (char)sr.Read();

                        if (char.IsDigit(a) || char.IsLetter(a) || a == '-' || a == '_')
                        {
                            _ = woord.Append(a);
                        }
                        else
                        {
                            if (woord.Length > 5)
                            {
                                //DataText.AppendText(woord.ToString());
                                //DataText.AppendText(Environment.NewLine);

                                Charts nieuw = new Charts
                                {
                                    Tag_ = woord.ToString(),
                                    As_ = AS,
                                    Label_ = "",
                                    Reserve_ = ""
                                };
                                Tags.Add(nieuw);

                            }

                            _ = woord.Clear();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        private void NieuweIndexAsbutton_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show("Selecteer een As folder");
            string naam = "";

            DialogResult = folderBrowserDialog.ShowDialog(); // Show the dialog.
            if (DialogResult == DialogResult.OK)
            {
                if (File.Exists(folderBrowserDialog.SelectedPath + "\\ES_LOC\\1\\ENV\\DOTS02.DAT"))
                {
                    naam = new DirectoryInfo(folderBrowserDialog.SelectedPath).Name;
                    Tags.Clear();
                    Lees_AS_uit(naam, folderBrowserDialog.SelectedPath + "\\ES_LOC\\1\\ENV\\DOTS02.DAT");
                }

                if (File.Exists(folderBrowserDialog.SelectedPath + "\\ES_LOC\\2\\ENV\\DOTS02.DAT"))
                {
                    naam = new DirectoryInfo(folderBrowserDialog.SelectedPath).Name;
                    Tags.Clear();
                    Lees_AS_uit(naam, folderBrowserDialog.SelectedPath + "\\ES_LOC\\2\\ENV\\DOTS02.DAT");
                }

                // save tags

                Save(naam);

            }
        }


        private void Save(string naam)
        {
            string output = $"{naam}.xml";
            if (File.Exists(output))
            {
                File.Delete(output);
            }

            XmlSerializer serialiser = new XmlSerializer(typeof(List<Charts>));
            TextWriter FileStream = new StreamWriter(output);
            serialiser.Serialize(FileStream, Tags);
            FileStream.Close();
        }

        private void Laad(string naam)
        {
            Tags.Clear();
            if (File.Exists(naam))
            {
                XmlSerializer serialiser = new XmlSerializer(typeof(List<Charts>));
                using (FileStream stream = File.OpenRead(naam))
                {
                    Tags = (List<Charts>)serialiser.Deserialize(stream);
                }
            }
            else
            {
                MessageBox.Show($"File {naam} bestaat niet");
            }
        }

        private void HerschrijfTextVeld(object sender, EventArgs e)
        {
            // clear text
            DataText.Clear();
            DataText.Visible = false;

            // lees file
            if (checkBoxAs01.Checked)
                Regel("As01");
            if (checkBoxAs02.Checked)
                Regel("As02");
            if (checkBoxAs03.Checked)
                Regel("As03");
            if (checkBoxAs09.Checked)
                Regel("As09");
            if (checkBoxAs11.Checked)
                Regel("As11");
            if (checkBoxAs12.Checked)
                Regel("As12");
            if (checkBoxAs13.Checked)
                Regel("As13");
            if (checkBoxAs14.Checked)
                Regel("As14");
            if (checkBoxAs15.Checked)
                Regel("As15");
            if (checkBoxAs21.Checked)
                Regel("As21");
            if (checkBoxAs22.Checked)
                Regel("As22");
            if (checkBoxAs23.Checked)
                Regel("As23");
            if (checkBoxAs24.Checked)
                Regel("As24");
            if (checkBoxAs25.Checked)
                Regel("As25");

            DataText.Visible = true;
            DataText.SelectionStart = 0;
            DataText.ScrollToCaret();
            DataText.Focus();
        }

        private void Regel(String s)
        {
            Laad($"{s}.Xml");
            if (Tags.Count > 0)
            {
                foreach (Charts tag in Tags)
                {
                    DataText.AppendText($"{tag.Tag_,-25} - {tag.As_,-8}");
                    DataText.AppendText(Environment.NewLine);
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            HerschrijfTextVeld(this, null);
        }

        private void Filter(string fil)
        {
            if (string.IsNullOrEmpty(fil))
            {
                return;
            }
            DataText.Lines = DataText.Lines.Where(line => line.ToUpperInvariant().Contains(fil.ToUpperInvariant())).ToArray();
        }

        private void buttonClearFilter_Click(object sender, EventArgs e)
        {
            textBoxFilter.Text = "";
            HerschrijfTextVeld(this, null);
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            Filter(textBoxFilter.Text);
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            checkBoxAs01.Checked = true;
            checkBoxAs02.Checked = true;
            checkBoxAs03.Checked = true;
            checkBoxAs09.Checked = true;
            checkBoxAs11.Checked = true;
            checkBoxAs12.Checked = true;
            checkBoxAs13.Checked = true;
            checkBoxAs14.Checked = true;
            checkBoxAs15.Checked = true;
            checkBoxAs21.Checked = true;
            checkBoxAs22.Checked = true;
            checkBoxAs23.Checked = true;
            checkBoxAs24.Checked = true;
            checkBoxAs25.Checked = true;
        }

         private void SelectGeen_Click(object sender, EventArgs e)
        {
            checkBoxAs01.Checked = false;
            checkBoxAs02.Checked = false;
            checkBoxAs03.Checked = false;
            checkBoxAs09.Checked = false;
            checkBoxAs11.Checked = false;
            checkBoxAs12.Checked = false;
            checkBoxAs13.Checked = false;
            checkBoxAs14.Checked = false;
            checkBoxAs15.Checked = false;
            checkBoxAs21.Checked = false;
            checkBoxAs22.Checked = false;
            checkBoxAs23.Checked = false;
            checkBoxAs24.Checked = false;
            checkBoxAs25.Checked = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://github.com/majoor404/Cgm23");
        }
    }
}

