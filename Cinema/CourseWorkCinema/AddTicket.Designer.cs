namespace CourseWorkCinema
{
    partial class AddTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFilmChoose = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPlace = new System.Windows.Forms.ComboBox();
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.cbArmor = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbFilmChoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilmChoose
            // 
            this.gbFilmChoose.Controls.Add(this.label4);
            this.gbFilmChoose.Controls.Add(this.cmbPlace);
            this.gbFilmChoose.Controls.Add(this.cmbSession);
            this.gbFilmChoose.Controls.Add(this.label3);
            this.gbFilmChoose.Controls.Add(this.label1);
            this.gbFilmChoose.Controls.Add(this.cmbFilm);
            this.gbFilmChoose.Controls.Add(this.cbArmor);
            this.gbFilmChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbFilmChoose.Location = new System.Drawing.Point(12, 12);
            this.gbFilmChoose.Name = "gbFilmChoose";
            this.gbFilmChoose.Padding = new System.Windows.Forms.Padding(7);
            this.gbFilmChoose.Size = new System.Drawing.Size(356, 229);
            this.gbFilmChoose.TabIndex = 0;
            this.gbFilmChoose.TabStop = false;
            this.gbFilmChoose.Text = "Выбор фильма и сеанса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Место:";
            // 
            // cmbPlace
            // 
            this.cmbPlace.Enabled = false;
            this.cmbPlace.FormattingEnabled = true;
            this.cmbPlace.Location = new System.Drawing.Point(123, 132);
            this.cmbPlace.Name = "cmbPlace";
            this.cmbPlace.Size = new System.Drawing.Size(206, 24);
            this.cmbPlace.TabIndex = 5;
            // 
            // cmbSession
            // 
            this.cmbSession.Enabled = false;
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Location = new System.Drawing.Point(123, 81);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(206, 24);
            this.cmbSession.TabIndex = 4;
            this.cmbSession.SelectedIndexChanged += new System.EventHandler(this.CmbSession_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Сеанс в зале:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фильм:";
            // 
            // cmbFilm
            // 
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(123, 31);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(206, 24);
            this.cmbFilm.TabIndex = 1;
            this.cmbFilm.SelectedIndexChanged += new System.EventHandler(this.CmbFilm_SelectedIndexChanged);
            // 
            // cbArmor
            // 
            this.cbArmor.AutoSize = true;
            this.cbArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbArmor.Location = new System.Drawing.Point(107, 186);
            this.cbArmor.Name = "cbArmor";
            this.cbArmor.Size = new System.Drawing.Size(137, 21);
            this.cbArmor.TabIndex = 0;
            this.cbArmor.Text = "Забронировать?";
            this.cbArmor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(106, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цена билета:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(222, 269);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 17);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "0.00";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(67, 327);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(240, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Оформить билет";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(67, 376);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(240, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Вернуться на главную";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // AddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 411);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbFilmChoose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddTicket";
            this.Text = "Выдача билета";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddTicket_FormClosed);
            this.Load += new System.EventHandler(this.AddTicket_Load);
            this.gbFilmChoose.ResumeLayout(false);
            this.gbFilmChoose.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilmChoose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.CheckBox cbArmor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPlace;
        private System.Windows.Forms.ComboBox cmbSession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
    }
}