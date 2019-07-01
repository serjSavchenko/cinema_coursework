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
    public partial class ViewFilms : Form
    {
        ClassDataBase db = new ClassDataBase();
        ClassSetupProgram stp = new ClassSetupProgram();
        List<Film> films = new List<Film>();
        List<Session> sessions = new List<Session>();
        string tempName = "";
        string tempGenre = "";
        string tempDuration = "";
        string tempTime = "";

        public ViewFilms()
        {
            InitializeComponent();
            //-------------------------------
            films.Clear();
            sessions.Clear();
            tbName.ReadOnly = true;
            tbGenre.ReadOnly = true;
            tbDuration.ReadOnly = true;
            tbTime.ReadOnly = true;

            //-----------------------------------

            db.Execute<Film>(ref stp, "SELECT * FROM cinema.films;", ref films);
            db.Execute<Session>(ref stp, "SELECT * FROM cinema.sessions;", ref sessions);

            dgvFilms.Rows.Clear();

            if (films.Count != 0)
            {
                for (int i = 0; i < films.Count; i++)
                {
                    dgvFilms.Rows.Add(films[i].FilmName, films[i].FilmGenre, films[i].Duration, films[i].Time);
                }
            }
            else
            {
                MessageBox.Show("Подключение к базе удачно, но база пуста!","Error",MessageBoxButtons.OK);
            }
        }

        private void DgvFilms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbName.Text = dgvFilms.CurrentRow.Cells[0].Value.ToString();
            tbGenre.Text = dgvFilms.CurrentRow.Cells[1].Value.ToString();
            tbDuration.Text = dgvFilms.CurrentRow.Cells[2].Value.ToString();
            tbTime.Text = dgvFilms.CurrentRow.Cells[3].Value.ToString();
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            if (btnEdit.Text == "Редактировать выбранный")
            {
                btnEdit.Text = "Применить изменения";
                tbName.ReadOnly = false;
                tbGenre.ReadOnly = false;
                tbDuration.ReadOnly = false;
                tbTime.ReadOnly = false;
                tempName = tbName.Text;
                tempGenre = tbGenre.Text;
                tempDuration = tbDuration.Text;
                tempTime = tbTime.Text;
            }
            else
            {
                btnEdit.Text = "Редактировать выбранный";
                tbName.ReadOnly = true;
                tbGenre.ReadOnly = true;
                tbDuration.ReadOnly = true;
                tbTime.ReadOnly = true;
                if (tempDuration == tbDuration.Text && tempGenre == tbGenre.Text && tempName == tbName.Text && tempTime == tbTime.Text)
                {
                    MessageBox.Show("Вы нечего не изменили!", "Info", MessageBoxButtons.OK);
                }
                else
                {
                    db.ExecuteNonQuery(ref stp, "UPDATE `cinema`.`films` SET `FilmName` = '" + tbName.Text.ToString() + "', `FilmGenre` = '" + tbGenre.Text.ToString() + "', `Duration` = '" + tbDuration.Text.ToString() + "', `Time` = '"+ tbTime.Text.ToString() +"' WHERE (`idFilm` = '" + films.Where(f => f.FilmName == tempName).FirstOrDefault().idFilm.ToString() + "');");
                    MessageBox.Show("Отредактировано!", "Info", MessageBoxButtons.OK);
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Добавить новый")
            {
                tbName.ReadOnly = false;
                tbGenre.ReadOnly = false;
                tbDuration.ReadOnly = false;
                tbTime.ReadOnly = false;
                tbName.Text = "";
                tbGenre.Text = "";
                tbDuration.Text = "";
                tbTime.Text = "";
                btnAdd.Text = "Применить";
            }
            else
            {
                if (tbDuration.Text.Trim() == "" || tbGenre.Text.Trim() == "" || tbName.Text.Trim() == "" || tbTime.Text.Trim() == "")
                {
                    MessageBox.Show("Вы нечего не ввели!", "Info", MessageBoxButtons.OK);
                }
                else
                {
                    //INSERT INTO `cinema`.`price` (`idSession`, `Price`) VALUES ('1', '87');
                    //INSERT INTO `cinema`.`sessions` (`idSession`, `idHall`, `Date`, `idFilm`) VALUES ('2', '1', '12 jule', '2');


                    db.ExecuteNonQuery(ref stp, "INSERT INTO `cinema`.`films` (`idFilm`, `FilmName`, `FilmGenre`, `Duration`, `Time`) VALUES ('" + (films.Count + 1).ToString() + "', '" + tbName.Text.Trim().ToString() + "', '" + tbGenre.Text.Trim().ToString() + "', '" + tbDuration.Text.Trim().ToString() + "', '" + tbTime.Text.Trim().ToString() + "');");

                    db.ExecuteNonQuery(ref stp, "INSERT INTO `cinema`.`sessions` (`idSession`, `idHall`, `Date`, `idFilm`) VALUES ('" + (sessions.Count + 1).ToString() + "', '1', '" + DateTime.Now + "', '" + (films.Count + 1).ToString() + "');");

                    db.ExecuteNonQuery(ref stp, "INSERT INTO `cinema`.`price` (`idSession`, `Price`) VALUES ('" + (sessions.Count + 1).ToString() + "', '75');");

                    MessageBox.Show("Добалено!", "Info", MessageBoxButtons.OK);
                }
                tbName.ReadOnly = true;
                tbGenre.ReadOnly = true;
                tbDuration.ReadOnly = true;
                tbTime.ReadOnly = true;
                tbName.Text = "";
                tbGenre.Text = "";
                tbDuration.Text = "";
                tbTime.Text = "";
                btnAdd.Text = "Добавить новый";
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить выделенный?","Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                db.ExecuteNonQuery(ref stp, "DELETE FROM `cinema`.`films` WHERE (`idFilm` = '"+ films.Where(f => f.FilmName == dgvFilms.CurrentRow.Cells[0].Value.ToString()).FirstOrDefault().idFilm.ToString() +"');");
                MessageBox.Show("Удалено!", "Info", MessageBoxButtons.OK);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
