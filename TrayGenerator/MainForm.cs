using System;
using System.Windows.Forms;

namespace TrayGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InnIpGenButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(innIpLabel.Text = DataGenerator.InnIp);
        }

        private void InnUlGenButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(innUlLabel.Text = DataGenerator.InnUl);
        }

        private void OgrnIpGenButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ogrnIpLabel.Text = DataGenerator.OgrnIp);
        }

        private void OgrnUlGenButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ogrnUlLabel.Text = DataGenerator.OgrnUl);
        }

        private void SnilsGenButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(snilsLabel.Text = DataGenerator.Snils);
        }
    }
}
