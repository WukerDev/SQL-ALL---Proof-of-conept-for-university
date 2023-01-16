using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_ALL;
namespace SQL_ALL
{
    public partial class Form1 : Form
    {
        SqlAllInOne sqlAllInOne = new SqlAllInOne();
        public Form1()
        {
            InitializeComponent();
            
            

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            GridRefresh();
            }
            private void GridRefresh()
             {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            SqlAllInOne sqlAllInOne = new SqlAllInOne();
            string[,] tabelaString = new string[sqlAllInOne.rowsAmount(), BazyDanychOpis.DANE_BAZA.Length];
            tabelaString = sqlAllInOne.selectSQLDataALL();
            dataGridView1.Columns.Add("ID", "ID");
            for (int i = 0; i < BazyDanychOpis.DANE_BAZA.Length; i++)
            {
                dataGridView1.Columns.Add(BazyDanychOpis.DANE_BAZA[i], BazyDanychOpis.DANE_BAZA[i]);
            }
            for (int i = 0; i < tabelaString.GetLength(0); i++)
            {
                dataGridView1.Rows.Add(i + 1, tabelaString[i, 0], tabelaString[i, 1], tabelaString[i, 2], tabelaString[i, 3]);
            }
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void buttonZapiszRekord_Click(object sender, EventArgs e)
        {
            string[] dodawanie = { textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text };
            sqlAllInOne.insertSQLData(dodawanie);
            GridRefresh();


        }

        private void buttonWczytajRekord_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            string[] outputString = new string[BazyDanychOpis.DANE_BAZA.Length];
            outputString = sqlAllInOne.selectSQLDataID(int.Parse(textBox2.Text));
            for (int i = 0; i < outputString.Length; i++)
            {
                textBox1.Text += outputString[i] + ", ";
            }
        }

        private void buttonZapiszPole_Click(object sender, EventArgs e)
        {
            int idlocal=0, pole=0;
            string wartosc = "";
            idlocal = int.Parse(textBox3.Text);
            pole = int.Parse(textBox9.Text);
            wartosc = textBox10.Text;
            sqlAllInOne.changeSQLDataPole(idlocal, pole, wartosc);
            GridRefresh();

        }

        private void Odśwież_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Proof of koncept
    }

}
