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
    public partial class sellForm : Form
    {
        Gallery gallery = new Gallery();
        public sellForm()
        {
            InitializeComponent();
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            string message = gallery.sellArtPiece(pieceID_textbox.Text, Convert.ToDouble(estimate_textbox.Text));
            MessageBox.Show(message);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
