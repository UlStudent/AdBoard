using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardView
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormUsers>();
            form.ShowDialog();
        }

        private void buttonAds_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormAds>();
            form.ShowDialog();
        }

        private void buttonMessages_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormMessages>();
            form.ShowDialog();
        }

        private void buttonFavorites_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormFavorites>();
            form.ShowDialog();
        }

        private void buttonBalances_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormBalances>();
            form.ShowDialog();
        }

        private void buttonReq_Click(object sender, EventArgs e)
        {

        }
    }
}
