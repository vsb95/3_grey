namespace WindowsFormsApplication03
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonQuerry1 = new System.Windows.Forms.Button();
            this.buttonQuerry2 = new System.Windows.Forms.Button();
            this.buttonQuerry3 = new System.Windows.Forms.Button();
            this.buttonQuerry4 = new System.Windows.Forms.Button();
            this.listBoxTables = new System.Windows.Forms.ListBox();
            this.buttonShowMagazine = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonAdd.Location = new System.Drawing.Point(13, 562);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(220, 29);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonDelete.Location = new System.Drawing.Point(13, 634);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(220, 29);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonEdit.Location = new System.Drawing.Point(13, 598);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(220, 29);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonLogin.Location = new System.Drawing.Point(574, 479);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(174, 31);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Вход";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1070, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Таблица:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Пароль";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(96, 479);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 29);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Location = new System.Drawing.Point(383, 479);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 29);
            this.textBox2.TabIndex = 15;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 13);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1051, 458);
            this.dataGridView2.TabIndex = 16;
            // 
            // buttonQuerry1
            // 
            this.buttonQuerry1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonQuerry1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonQuerry1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonQuerry1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonQuerry1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonQuerry1.Location = new System.Drawing.Point(263, 517);
            this.buttonQuerry1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQuerry1.Name = "buttonQuerry1";
            this.buttonQuerry1.Size = new System.Drawing.Size(1041, 31);
            this.buttonQuerry1.TabIndex = 17;
            this.buttonQuerry1.Text = "Запрос \"1\"";
            this.buttonQuerry1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuerry1.UseVisualStyleBackColor = true;
            this.buttonQuerry1.Visible = false;
            // 
            // buttonQuerry2
            // 
            this.buttonQuerry2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonQuerry2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonQuerry2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonQuerry2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonQuerry2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonQuerry2.Location = new System.Drawing.Point(263, 556);
            this.buttonQuerry2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQuerry2.Name = "buttonQuerry2";
            this.buttonQuerry2.Size = new System.Drawing.Size(1041, 31);
            this.buttonQuerry2.TabIndex = 18;
            this.buttonQuerry2.Text = "Запрос \"2\"";
            this.buttonQuerry2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuerry2.UseVisualStyleBackColor = true;
            this.buttonQuerry2.Visible = false;
            // 
            // buttonQuerry3
            // 
            this.buttonQuerry3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonQuerry3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonQuerry3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonQuerry3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonQuerry3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonQuerry3.Location = new System.Drawing.Point(263, 595);
            this.buttonQuerry3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQuerry3.Name = "buttonQuerry3";
            this.buttonQuerry3.Size = new System.Drawing.Size(1041, 31);
            this.buttonQuerry3.TabIndex = 19;
            this.buttonQuerry3.Text = "Запрос \"3\"";
            this.buttonQuerry3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuerry3.UseVisualStyleBackColor = true;
            this.buttonQuerry3.Visible = false;
            // 
            // buttonQuerry4
            // 
            this.buttonQuerry4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonQuerry4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonQuerry4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonQuerry4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonQuerry4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonQuerry4.Location = new System.Drawing.Point(263, 634);
            this.buttonQuerry4.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQuerry4.Name = "buttonQuerry4";
            this.buttonQuerry4.Size = new System.Drawing.Size(1041, 31);
            this.buttonQuerry4.TabIndex = 20;
            this.buttonQuerry4.Text = "Запрос \"4\"";
            this.buttonQuerry4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuerry4.UseVisualStyleBackColor = true;
            this.buttonQuerry4.Visible = false;
            // 
            // listBoxTables
            // 
            this.listBoxTables.FormattingEnabled = true;
            this.listBoxTables.ItemHeight = 20;
            this.listBoxTables.Location = new System.Drawing.Point(1074, 45);
            this.listBoxTables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxTables.Name = "listBoxTables";
            this.listBoxTables.Size = new System.Drawing.Size(230, 424);
            this.listBoxTables.TabIndex = 21;
            this.listBoxTables.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxTables_MouseDoubleClick);
            // 
            // buttonShowMagazine
            // 
            this.buttonShowMagazine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonShowMagazine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonShowMagazine.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonShowMagazine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonShowMagazine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonShowMagazine.Location = new System.Drawing.Point(923, 480);
            this.buttonShowMagazine.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowMagazine.Name = "buttonShowMagazine";
            this.buttonShowMagazine.Size = new System.Drawing.Size(381, 29);
            this.buttonShowMagazine.TabIndex = 22;
            this.buttonShowMagazine.Text = "Показать журнал посещений";
            this.buttonShowMagazine.UseVisualStyleBackColor = true;
            this.buttonShowMagazine.Visible = false;
            this.buttonShowMagazine.Click += new System.EventHandler(this.buttonShowMagazine_Click);
            // 
            // buttonReg
            // 
            this.buttonReg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonReg.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonReg.Location = new System.Drawing.Point(12, 519);
            this.buttonReg.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(221, 29);
            this.buttonReg.TabIndex = 23;
            this.buttonReg.Text = "Регистрация";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Visible = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1334, 678);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.buttonShowMagazine);
            this.Controls.Add(this.listBoxTables);
            this.Controls.Add(this.buttonQuerry4);
            this.Controls.Add(this.buttonQuerry3);
            this.Controls.Add(this.buttonQuerry2);
            this.Controls.Add(this.buttonQuerry1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Курсовая \"\"";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonQuerry1;
        private System.Windows.Forms.Button buttonQuerry2;
        private System.Windows.Forms.Button buttonQuerry3;
        private System.Windows.Forms.Button buttonQuerry4;
        private System.Windows.Forms.ListBox listBoxTables;
        private System.Windows.Forms.Button buttonShowMagazine;
        private System.Windows.Forms.Button buttonReg;
    }
}

