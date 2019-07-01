namespace CourseWorkCinema
{
    partial class ViewFilms
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
            this.dgvFilms = new System.Windows.Forms.DataGridView();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.FilmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).BeginInit();
            this.gbEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFilms
            // 
            this.dgvFilms.AllowUserToAddRows = false;
            this.dgvFilms.AllowUserToDeleteRows = false;
            this.dgvFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilmName,
            this.FilmGenre,
            this.Duration,
            this.Time});
            this.dgvFilms.Location = new System.Drawing.Point(12, 12);
            this.dgvFilms.Name = "dgvFilms";
            this.dgvFilms.ReadOnly = true;
            this.dgvFilms.Size = new System.Drawing.Size(756, 478);
            this.dgvFilms.TabIndex = 0;
            this.dgvFilms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFilms_CellContentClick);
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.btnExit);
            this.gbEdit.Controls.Add(this.btnDelete);
            this.gbEdit.Controls.Add(this.btnAdd);
            this.gbEdit.Controls.Add(this.btnEdit);
            this.gbEdit.Controls.Add(this.label4);
            this.gbEdit.Controls.Add(this.tbTime);
            this.gbEdit.Controls.Add(this.label3);
            this.gbEdit.Controls.Add(this.tbDuration);
            this.gbEdit.Controls.Add(this.label2);
            this.gbEdit.Controls.Add(this.tbGenre);
            this.gbEdit.Controls.Add(this.label1);
            this.gbEdit.Controls.Add(this.tbName);
            this.gbEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbEdit.Location = new System.Drawing.Point(774, 12);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(422, 478);
            this.gbEdit.TabIndex = 1;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Управление";
            // 
            // FilmName
            // 
            this.FilmName.HeaderText = "Название";
            this.FilmName.Name = "FilmName";
            this.FilmName.ReadOnly = true;
            // 
            // FilmGenre
            // 
            this.FilmGenre.HeaderText = "Жанр";
            this.FilmGenre.Name = "FilmGenre";
            this.FilmGenre.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Продолжительность";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Time
            // 
            this.Time.HeaderText = "Время сеансов";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(160, 37);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(243, 23);
            this.tbName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название фильма:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Жанр фильма:";
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(160, 79);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(243, 23);
            this.tbGenre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Продолжительность:";
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(160, 123);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(243, 23);
            this.tbDuration.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Время сеанса:";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(160, 174);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(243, 23);
            this.tbTime.TabIndex = 6;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(101, 242);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(211, 34);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Редактировать выбранный";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(113, 291);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 34);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Добавить новый";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(113, 342);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(188, 33);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Удалить выбранный";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(113, 438);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(188, 34);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "На главную";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ViewFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 502);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.dgvFilms);
            this.Name = "ViewFilms";
            this.Text = "ViewFilms";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).EndInit();
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFilms;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
    }
}