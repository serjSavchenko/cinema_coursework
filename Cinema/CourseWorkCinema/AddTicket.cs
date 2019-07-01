using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CourseWorkCinema
{
    public partial class AddTicket : Form
    {
        ClassDataBase db = new ClassDataBase();
        ClassSetupProgram stp = new ClassSetupProgram();
        List<Film> films = new List<Film>();
        List<Session> sessions = new List<Session>();
        List<Hall> halls = new List<Hall>();
        List<Place> places = new List<Place>();
        List<Price> prices = new List<Price>();


        public AddTicket()
        {
            InitializeComponent();

            //-------------------------------
            films.Clear();
            sessions.Clear();
            halls.Clear();
            places.Clear();
            prices.Clear();
            
            //-----------------------------------

            db.Execute<Film>(ref stp, "SELECT * FROM cinema.films;", ref films);
            db.Execute<Session>(ref stp, "SELECT * FROM cinema.sessions;", ref sessions);
            db.Execute<Hall>(ref stp, "SELECT * FROM cinema.halls;", ref halls);
            db.Execute<Place>(ref stp, "SELECT * FROM cinema.places;", ref places);
            db.Execute<Price>(ref stp, "SELECT * FROM cinema.price;", ref prices);
            //-------------------------------
            cmbFilm.Items.Clear();
            cmbSession.Items.Clear();
            cmbPlace.Items.Clear();
            //-----------------------------------

            for (int i = 0; i < films.Count; i++)
            {
                cmbFilm.Items.Add(films[i].FilmName);
            }
            cmbFilm.SelectedIndex = 0;
            for (int i = 0; i < sessions.Count; i++)
            {
                cmbSession.Items.Add(sessions[i].Date + " " + halls.Where(h => h.idHall == sessions[i].idHall).FirstOrDefault().HallName);
            }
            cmbSession.SelectedIndex = 0;
            for (int i = 0; i < Convert.ToInt32(halls.Where(h => h.idHall == sessions.Where(s => s.idSession == cmbSession.SelectedIndex + 1).FirstOrDefault().idHall).FirstOrDefault().QuantityRows); i++)
            {
                for (int j = 0; j < Convert.ToInt32(halls.Where(h => h.idHall == sessions.Where(s => s.idSession == cmbSession.SelectedIndex + 1).FirstOrDefault().idHall).FirstOrDefault().PlacesByRow); j++)
                {
                    cmbPlace.Items.Add((j+1).ToString() + " место " + (i+1).ToString() + " ряд");
                }
            }
            cmbPlace.SelectedIndex = 0;
            //------------------------------------
        }

        private void AddTicket_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void AddTicket_Load(object sender, EventArgs e)
        {

        }

        private void CmbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSession.Enabled = true;
        }

        private void CmbSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPlace.Enabled = true;
            
            labelPrice.Text = prices.Where(p => p.idSession == (cmbSession.SelectedIndex + 1)).FirstOrDefault().PriceValue.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //INSERT INTO `cinema`.`tickets` (`idFilm`, `idSession`, `idPlace`, `Armor`, `idEmployee`) VALUES ('3', '2', '2', '1', '1');
            int ifChecked = (cbArmor.Checked == true) ? 1 : 0;
            string resultString = string.Join("_", Regex.Matches(cmbPlace.Text, @"\d+").OfType<Match>().Select(m => m.Value));
            string[] outPut = resultString.Split('_');

            //INSERT INTO `cinema`.`places` (`idPlace`, `idHall`, `#row`, `#place`) VALUES ('2', '1', '3', '2');

            db.ExecuteNonQuery(ref stp, "INSERT INTO `cinema`.`places` (`idPlace`, `idHall`, `#row`, `#place`) VALUES ('" + (places.Count + 1).ToString() + "', '" + halls.Where(h => h.idHall == sessions.Where(s => s.idSession == cmbSession.SelectedIndex + 1).FirstOrDefault().idHall).FirstOrDefault().idHall.ToString() + "', '"+ outPut[1] +"', '"+ outPut[0] +"');");

            db.ExecuteNonQuery(ref stp, "INSERT INTO `cinema`.`tickets` (`idFilm`, `idSession`, `idPlace`, `Armor`, `idEmployee`) VALUES ('"+ (cmbFilm.SelectedIndex + 1).ToString() + "', '" + (cmbSession.SelectedIndex + 1).ToString() + "', '"+ (places.Count + 1).ToString() + "', '"+ ifChecked.ToString() +"', '1');");
            MessageBox.Show("Новый билет оформлен!","Оформлено",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
