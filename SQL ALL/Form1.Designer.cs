namespace SQL_ALL
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonWczytajRekord = new System.Windows.Forms.Button();
            this.buttonZapiszPole = new System.Windows.Forms.Button();
            this.buttonZapiszRekord = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonWczytajRekord
            // 
            this.buttonWczytajRekord.Location = new System.Drawing.Point(987, 34);
            this.buttonWczytajRekord.Name = "buttonWczytajRekord";
            this.buttonWczytajRekord.Size = new System.Drawing.Size(137, 23);
            this.buttonWczytajRekord.TabIndex = 1;
            this.buttonWczytajRekord.Text = "Wczytaj Rekord";
            this.buttonWczytajRekord.UseVisualStyleBackColor = true;
            this.buttonWczytajRekord.Click += new System.EventHandler(this.buttonWczytajRekord_Click);
            // 
            // buttonZapiszPole
            // 
            this.buttonZapiszPole.Location = new System.Drawing.Point(12, 406);
            this.buttonZapiszPole.Name = "buttonZapiszPole";
            this.buttonZapiszPole.Size = new System.Drawing.Size(219, 23);
            this.buttonZapiszPole.TabIndex = 2;
            this.buttonZapiszPole.Text = "Zmień";
            this.buttonZapiszPole.UseVisualStyleBackColor = true;
            this.buttonZapiszPole.Click += new System.EventHandler(this.buttonZapiszPole_Click);
            // 
            // buttonZapiszRekord
            // 
            this.buttonZapiszRekord.Location = new System.Drawing.Point(13, 34);
            this.buttonZapiszRekord.Name = "buttonZapiszRekord";
            this.buttonZapiszRekord.Size = new System.Drawing.Size(418, 23);
            this.buttonZapiszRekord.TabIndex = 3;
            this.buttonZapiszRekord.Text = "Zapisz Rekord";
            this.buttonZapiszRekord.UseVisualStyleBackColor = true;
            this.buttonZapiszRekord.Click += new System.EventHandler(this.buttonZapiszRekord_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(724, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(948, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(894, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Podaj ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(406, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(718, 295);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 380);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(69, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(118, 12);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(224, 12);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(330, 12);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 12;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(87, 380);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(69, 20);
            this.textBox9.TabIndex = 14;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(162, 380);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(69, 20);
            this.textBox10.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID pozostaje niezmienne";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonZapiszRekord);
            this.Controls.Add(this.buttonZapiszPole);
            this.Controls.Add(this.buttonWczytajRekord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonWczytajRekord;
        private System.Windows.Forms.Button buttonZapiszPole;
        private System.Windows.Forms.Button buttonZapiszRekord;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label2;
    }
}

