using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cgm23
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void NieuweIndexAsbutton_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show("Selecteer de TataCC23 folder");

            DialogResult = folderBrowserDialog.ShowDialog(); // Show the dialog.
            if (DialogResult == DialogResult.OK)
            {
                DataText.Visible = false;
                DataText.Clear();
                LeesAS("As01");
                LeesAS("As02");
                LeesAS("As03");
                LeesAS("As09");
                LeesAS("As11");
                LeesAS("As12");
                LeesAS("As13");
                LeesAS("As14");
                LeesAS("As15");
                LeesAS("As21");
                LeesAS("As22");
                LeesAS("As23");
                LeesAS("As24");
                LeesAS("As25");
                AantalCharts.Text = DataText.Lines.Length.ToString();
                DataText.Visible = true;
                DataText.SelectionStart = 0;
                DataText.ScrollToCaret();
                _ = DataText.Focus();

            }
        }

        private void Laad(string AS)
        {
            try
            {
                DataText.AppendText(File.ReadAllText($"{AS}.txt"));
            }
            catch { }

            //try
            //{
            //    var data = File.ReadAllLines($"{AS}.txt");  // data is een array
            //    var data1 = new List<string>(data);         // data1 is een list van strings
            //    for (int i = 0; i < data1.Count; i++)
            //    {
            //        DataText.AppendText(data1[i]);
            //        DataText.AppendText(Environment.NewLine);
            //    }
            //}
            //catch { }
        }
        

        private void HerschrijfTextVeld(object sender, EventArgs e)
        {
            DataText.Clear();
            
            if (checkBoxAs01.Checked)
                Laad("As01");
            if (checkBoxAs02.Checked)
                Laad("As02");
            if (checkBoxAs03.Checked)
                Laad("As03");
            if (checkBoxAs09.Checked)
                Laad("As09");
            if (checkBoxAs11.Checked)
                Laad("As11");
            if (checkBoxAs12.Checked)
                Laad("As12");
            if (checkBoxAs13.Checked)
                Laad("As13");
            if (checkBoxAs14.Checked)
                Laad("As14");
            if (checkBoxAs15.Checked)
                Laad("As15");
            if (checkBoxAs21.Checked)
                Laad("As21");
            if (checkBoxAs22.Checked)
                Laad("As22");
            if (checkBoxAs23.Checked)
                Laad("As23");
            if (checkBoxAs24.Checked)
                Laad("As24");
            if (checkBoxAs25.Checked)
                Laad("As25");

            FilterText.Text = "";
            textBoxFilter.Text = "";

            AantalCharts.Text = DataText.Lines.Length.ToString();
            DataText.SelectionStart = 0;
            DataText.ScrollToCaret();
            _ = DataText.Focus();

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
            AantalCharts.Text = DataText.Lines.Length.ToString();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            Filter(textBoxFilter.Text);
            AantalCharts.Text = DataText.Lines.Length.ToString();
            if (FilterText.Text.Length > 0)
            {
                FilterText.Text = FilterText.Text + " + " + textBoxFilter.Text;
            }
            else
            {
                FilterText.Text = textBoxFilter.Text;
            }
            textBoxFilter.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://github.com/majoor404/Cgm23");
        }

        private void LeesAS(string AS)
        {
            string test = $"{folderBrowserDialog.SelectedPath}\\{AS}\\ES_LOC\\1\\ENV\\DOTS02.DAT";
            if (File.Exists($"{folderBrowserDialog.SelectedPath}\\{AS}\\ES_LOC\\1\\ENV\\DOTS02.DAT"))
            {
                Lees_AS_uit_Text(AS, $"{folderBrowserDialog.SelectedPath}\\{AS}\\ES_LOC\\1\\ENV\\DOTS02.DAT");
            }
            if (File.Exists($"{folderBrowserDialog.SelectedPath}\\{AS}\\ES_LOC\\2\\ENV\\DOTS02.DAT"))
            {
                Lees_AS_uit_Text(AS, $"{folderBrowserDialog.SelectedPath}\\{AS}\\ES_LOC\\2\\ENV\\DOTS02.DAT");
            }
        }

        private void Lees_AS_uit_Text(string AS, string path)
        {
            StringBuilder woord = new StringBuilder();
            List<string> gevonden_charts = new List<string>();
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
                                gevonden_charts.Add($"{woord,-25} - {AS,-8}");
                                //DataText.AppendText($"{woord,-25} - {AS,-8}");
                                //DataText.AppendText(Environment.NewLine);
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
            File.WriteAllLines($"{AS}.txt", gevonden_charts);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            HerschrijfTextVeld(this, null);
        }
    }
}

