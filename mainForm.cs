using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGS_Classes;

namespace CGS_Win
{
    public partial class mainForm : Form
    {
        Gallery gallery = new Gallery();
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = gallery.addCurator(CID.Text, CFN.Text, CLN.Text);
            CID.Clear();
            CFN.Clear();
            CLN.Clear();
            MessageBox.Show(msg);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string allCuratorsInfo = gallery.getAllCuratorsInfo();
            richTextBox1.AppendText(allCuratorsInfo);
        }

        private void addArtistBtn_Click(object sender, EventArgs e)
        {
            string msg = gallery.addArtist(ArtistID_textbox.Text, FN_textbox.Text, LN_textbox.Text);
            MessageBox.Show(msg);
        }

        private void viewArtistBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string allArtistsInfo = gallery.getAllArtistsInfo();
            richTextBox1.AppendText(allArtistsInfo);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void saveCuratorBtn_Click(object sender, EventArgs e)
        {
            string msg = gallery.saveCuratorIntoFile();
            MessageBox.Show(msg);
        }

        private void saveArtistBtn_Click(object sender, EventArgs e)
        {
            string msg = gallery.saveArtistIntoFile();
            MessageBox.Show(msg);
        }

        private void saveAP_btn_Click(object sender, EventArgs e)
        {
            string msg = gallery.saveArtPieceIntoFile();
            MessageBox.Show(msg);
        }

        private void addAP_btn_Click(object sender, EventArgs e)
        {
            string message = gallery.addArtPiece(ID_txtbox.Text, title_txtbox.Text, Convert.ToInt32(year_txtbox.Text), Convert.ToDouble(value_txtbox.Text), artistID_txtbox.Text, curID_txtBox.Text);
            MessageBox.Show(message);
        }
    }
}
