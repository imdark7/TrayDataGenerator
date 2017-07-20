using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrayGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            RefreshListBox();
        }

        private void InnIpGenButton_Click(object sender, EventArgs e)
        {
            var text = DataGenerator.InnIp;
            Clipboard.SetText(innIpLabel.Text = text);
            NotificationIcon.AddElementToDataArrayList(text);
        }

        private void InnUlGenButton_Click(object sender, EventArgs e)
        {
            var text = DataGenerator.InnUl;
            Clipboard.SetText(innUlLabel.Text = text);
            NotificationIcon.AddElementToDataArrayList(text);
        }

        private void OgrnIpGenButton_Click(object sender, EventArgs e)
        {
            var text = DataGenerator.OgrnIp;
            Clipboard.SetText(ogrnIpLabel.Text = text);
            NotificationIcon.AddElementToDataArrayList(text);
        }

        private void OgrnUlGenButton_Click(object sender, EventArgs e)
        {
            var text = DataGenerator.OgrnUl;
            Clipboard.SetText(ogrnUlLabel.Text = text);
            NotificationIcon.AddElementToDataArrayList(text);
        }

        private void SnilsGenButton_Click(object sender, EventArgs e)
        {
            var text = DataGenerator.Snils;
            Clipboard.SetText(snilsLabel.Text = DataGenerator.Snils);
            NotificationIcon.AddElementToDataArrayList(text);
        }

        public void RefreshListBox()
        {
            DataList.Items.Clear();
            for (var i = 0; i < 14; i++)
            {
                if (NotificationIcon.DataArrayList.Count == i) { break; }
                DataList.Items.Add(NotificationIcon.DataArrayList[i].ToString());
            }
        }

        private async void Label_DoubleClick(object sender, EventArgs e)
        {
            var label = ((Label) sender);
            Clipboard.SetText(label.Text);
            await Task.Factory.StartNew(() => 
            {
                label.ForeColor = Color.MediumSeaGreen;
                Thread.Sleep(1000);
                label.ForeColor = DefaultForeColor;
            });
        }

        private async void DataList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = ((ListBox) sender).IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches) return;
            Clipboard.SetText(((ListBox) sender).Items[index].ToString());
            await Task.Factory.StartNew(() =>
            {
                groupBox1.BackColor = Color.MediumSeaGreen;
                Thread.Sleep(1000);
                groupBox1.BackColor = DefaultBackColor;
            });
        }
    }
}
