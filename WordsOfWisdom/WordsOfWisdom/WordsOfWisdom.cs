using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsOfWisdom
{
    public partial class WordsOfWisdom : Form
    {
        public WordsOfWisdom()
        {
            InitializeComponent();
        }

        private void lblQuoteOne_MouseEnter(object sender, EventArgs e)
            => lblQuoteOne.ForeColor = Color.White;
        private void lblQuoteOne_MouseLeave(object sender, EventArgs e)
            => lblQuoteOne.ForeColor = Color.Black;
        private void lblQuoteTwo_MouseEnter(object sender, EventArgs e)
            => lblQuoteTwo.ForeColor = Color.White;
        private void lblQuoteTwo_MouseLeave(object sender, EventArgs e)
            => lblQuoteTwo.ForeColor = Color.Black;
        private void lblQuoteThree_MouseEnter(object sender, EventArgs e)
            => lblQuoteThree.ForeColor = Color.White;
        private void lblQuoteThree_MouseLeave(object sender, EventArgs e)
            => lblQuoteThree.ForeColor = Color.Black;
        private void lblQuoteFour_MouseEnter(object sender, EventArgs e)
            => lblQuoteFour.ForeColor = Color.White;
        private void lblQuoteFour_MouseLeave(object sender, EventArgs e)
            => lblQuoteFour.ForeColor = Color.Black;
    }
}
