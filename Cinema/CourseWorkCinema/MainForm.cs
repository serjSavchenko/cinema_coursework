using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkCinema
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            ViewFilms viewFilms = new ViewFilms();
            viewFilms.Show();
            this.Hide();
        }

        private void BtnAddTicket_Click(object sender, EventArgs e)
        {
            AddTicket addTicket = new AddTicket();
            addTicket.Show();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
