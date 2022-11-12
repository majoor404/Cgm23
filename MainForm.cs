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

                // save tags
                Save_Text();

                Laad();

            }
        }

        private void Save_Text()
        {
            File.WriteAllText("Charts.txt", DataText.Text);
        }


        private void Laad()
        {
            try
            {
                DataText.Text = File.ReadAllText("Charts.txt");
                AantalCharts.Text = DataText.Lines.Length.ToString();
                DataText.SelectionStart = 0;
                DataText.ScrollToCaret();
                _ = DataText.Focus();
            }
            catch { }
        }
        

        private void HerschrijfTextVeld(object sender, EventArgs e)
        {
            DataText.Clear();
            Laad();

            var Lijst = new List<string>();

            if (checkBoxAs01.Checked)
                Lijst.Add("As01");
            if (checkBoxAs02.Checked)
                Lijst.Add("As02");
            if (checkBoxAs03.Checked)
                Lijst.Add("As03");
            if (checkBoxAs09.Checked)
                Lijst.Add("As09");
            if (checkBoxAs11.Checked)
                Lijst.Add("As11");
            if (checkBoxAs12.Checked)
                Lijst.Add("As12");
            if (checkBoxAs13.Checked)
                Lijst.Add("As13");
            if (checkBoxAs14.Checked)
                Lijst.Add("As14");
            if (checkBoxAs15.Checked)
                Lijst.Add("As15");
            if (checkBoxAs21.Checked)
                Lijst.Add("As21");
            if (checkBoxAs22.Checked)
                Lijst.Add("As22");
            if (checkBoxAs23.Checked)
                Lijst.Add("As23");
            if (checkBoxAs24.Checked)
                Lijst.Add("As24");
            if (checkBoxAs25.Checked)
                Lijst.Add("As25");

            List<string> nieuwe_lijst = new List<string>();
            //bool delete_regel = true;

            for (int i = 0; i < DataText.Lines.Length; i++)
            {
                for (int q = 0; q < Lijst.Count; q++)
                {
                    if (DataText.Lines[i].Contains(Lijst[q]))
                    {
                        nieuwe_lijst.Add(DataText.Lines[i]);
                        break;
                    }
                }
            }
            
            DataText.Lines = nieuwe_lijst.ToArray();

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
                                DataText.AppendText($"{woord,-25} - {AS,-8}");
                                DataText.AppendText(Environment.NewLine);
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

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Laad();
        }
    }
}

