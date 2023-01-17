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
    { (np
        SqlAllInOne sqlAllInOne = new SqlAllInOne();  // tworzę obiekt sqlAllInOne by korzystać z metod zawartych w klasie (np GridRefresh(); )
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
            dataGridView1.Rows.Clear(); //wyczysc rzedy przed odswieżeniem, zapobiega pojawianiu się kilka razy tego samego
            dataGridView1.Columns.Clear(); //wyczysc kolumny przed odswieżeniem, zapobiega pojawianiu się kilka razy tego samego
            SqlAllInOne sqlAllInOne = new SqlAllInOne();  //tworzymy nową instancje
            string[,] tabelaString = new string[sqlAllInOne.rowsAmount(), BazyDanychOpis.DANE_BAZA.Length]; //tablica dwuwymiarowa o nazwie tabelaString, wielkosc jest zależna od .rowsAmount czyli ilosci rzedów i długości bazy danych
            tabelaString = sqlAllInOne.selectSQLDataALL(); //tabelaString ma dane z Selecta zawartego w metodzie SQLDataAll
            dataGridView1.Columns.Add("ID", "ID"); //dodajemy kolumne o nazwie ID
            for (int i = 0; i < BazyDanychOpis.DANE_BAZA.Length; i++)  //pętla for wykonująca się tyle ile jest 'długa' baza danych
            {
                dataGridView1.Columns.Add(BazyDanychOpis.DANE_BAZA[i], BazyDanychOpis.DANE_BAZA[i]);  //dodaje kolumne w pozycji (i,i) 
            }
            for (int i = 0; i < tabelaString.GetLength(0); i++) 
            {
                dataGridView1.Rows.Add(i + 1, tabelaString[i, 0], tabelaString[i, 1], tabelaString[i, 2], tabelaString[i, 3]); //dodajemy +1 na początku bo progam liczy od 0 a baza danych od 1
            }
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void buttonZapiszRekord_Click(object sender, EventArgs e)
        {
            string[] dodawanie = { textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text }; //tworzymy tabelę string o nazwie dodawanie o wartościach textboxów .Text konweruje wartosci z textboxów na tekst
            sqlAllInOne.insertSQLData(dodawanie); //wywolujemy metodę insertSQLData, znajdującą się w w klasie sqlAllinOne, która wstawia dane i jako argument dajemy tabelę utwożoną wyżej
            GridRefresh();


        }

        private void buttonWczytajRekord_Click(object sender, EventArgs e) //wczytujemy rekord
        {
            textBox1.Text = ""; //ustawiamy text box żeby był pusty
            string[] outputString = new string[BazyDanychOpis.DANE_BAZA.Length]; //nowa tabela outputString o długości takiej jaka nasza baza danych
            outputString = sqlAllInOne.selectSQLDataID(int.Parse(textBox2.Text)); //tabela outputString jest równa metodzie która wywołuje Selecta w bazie danych, jako argument dajemy Tekst z textboxa2 przerobiony Parse na typ INT
            for (int i = 0; i < outputString.Length; i++) //pętla for wykonująca się na bazie tego jak dużo jest elementów w tablicy
            {
                textBox1.Text += outputString[i] + ", ";
            }
        }

        private void buttonZapiszPole_Click(object sender, EventArgs e)
        {
            int idlocal=0, pole=0;  //ustalamy lokalną zmienną na potrzeby wykonania tej metody
            string wartosc = "";  // ustalamy string na pusty
            idlocal = int.Parse(textBox3.Text);  //lokalna zmienna jest wartością tekstu z textboxa3 przerobioną przez Parse na typ INT
            pole = int.Parse(textBox9.Text);  // jak wyżej
            wartosc = textBox10.Text; // zmienna wartość to tekst  z textBoxa 10
            sqlAllInOne.changeSQLDataPole(idlocal, pole, wartosc);  // wywołujemy metodę changeSQLDataPole z klasy sqlAllInOne z argumentami idlocal, pole oraz wartość
            GridRefresh();  //używamy tej metody by odświeżyć grid 

        }

        private void Odśwież_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Proof of concept
    }

}
