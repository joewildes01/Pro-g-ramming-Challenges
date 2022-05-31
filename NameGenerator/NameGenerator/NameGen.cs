using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameGenerator
{
    public partial class NameGen : Form
    {
        private string filePath;
        private List<string> FirstNames = new List<string>();
        private List<string> Surnames = new List<string>();
        private Random random = new Random();
        private int SelectFrom = 0;
        private string path = string.Empty;
        string? projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        private bool MaleChecked = false;
        private bool FemaleChecked = false;

        public NameGen()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            btnToClip.Text = "Copy to clipboard";

            if (!MaleChecked && !FemaleChecked)
            {
                path = Path.Combine(projectFolder, @"..\Resources\Mixedfirstnames.txt");
            }
            if (MaleChecked)
            {
                path = Path.Combine(projectFolder, @"..\Resources\Malefirstnames.txt");
            }
            if (FemaleChecked)
            {
                path = Path.Combine(projectFolder, @"..\Resources\femalefirstnames.txt");
            }
            
            FirstNames = File.ReadLines(path).ToList();

            path = Path.Combine(projectFolder, @"..\Resources\surnames.txt");
            Surnames = File.ReadLines(path).ToList();


            SelectFrom = random.Next(0, FirstNames.Count);

            FirstBox.Text = FirstNames[SelectFrom];
   
            SelectFrom = random.Next(0, Surnames.Count);

            SurBox.Text = Surnames[SelectFrom];

        }

        private void chkMale_CheckedChanged(object sender, EventArgs e)
        {
            if (!MaleChecked)
            {
                MaleChecked = true;
                chkFemale.Enabled = false;

            }
            else if (MaleChecked)
            {
                MaleChecked = false;
                path = string.Empty;
                chkFemale.Enabled = true;
            }
        }

        private void chkFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (!FemaleChecked)
            {
                FemaleChecked = true;
                chkMale.Enabled = false;
            }
            else if (FemaleChecked)
            {
                FemaleChecked= false;
                path = string.Empty;
                chkMale.Enabled = true;
            }
        }

        private void btnToClip_Click(object sender, EventArgs e)
        {
            string concatNames = $"{FirstBox.Text} {SurBox.Text}";

            Clipboard.SetText(concatNames);

            btnToClip.Text = "Copied!";
        }
    }
}
