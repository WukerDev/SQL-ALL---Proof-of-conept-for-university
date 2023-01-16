using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//potrzebny SQLite z pakietu nuget SQL lite core
using System.Data.SQLite;
using static System.Data.Entity.Infrastructure.Design.Executor;
using System.Data.SqlTypes;

namespace SQL_ALL
{
    //konfiguracja
    public class BazyDanychOpis
    {
        //dodaj to do pliku Forms.cs
        //using SQL_ALL;

        //nazwa tabeli
        public static string BAZYDANYCH_TABELA = "test";
        //nazwa pliku
        public static string BAZA_DANYCH_PLIK = "test.db";
        //klucz główny tabeli
        public static string BAZA_DANYCH_KLUCZ = "ID";

        //nazwa kolumn jako tablica string
        public static string[] DANE_BAZA = { "Field2", "Field3", "Field4", "Field5" };
        //aby dodać dane użyj komendy SqlAllInOne.insertSQLData(argument)
        //jako arguemnt podaj tablicę string np string[] dane = {"Jan", "Kowalski", "20", "ul. Kowalska 1", "00-000"};
        //pamiętaj o stworzeniu nowego obieku typu SqlAllInOne w pliku forms.cs aby cały program działał


        //lista dostępnych metod:
        //SqlAllInOne.insertSQLData(tablicaWartości)     <-- funkcja wsadzi cały wiersz
        //SqlAllInOne.changeSQLDataPole(int id_local, string nazwaPola, string wartoscPola)   <--funckja zmieni 1 pole na inna wartość!
        //SqlAllInOne.selectSQLDataAll()     <-- funkcja zwraca całą tabelę jako tablica 2 wymiarowa np string[][] dane, dane[0][0] to 1 rekord 1 wierszu itd
        //SqlAllInOne.selectSQLDataID(idRekordu, tablicaStringZWynikami)     <-- funkcja zwróci wiersz jako tablica string, więc żeby użyć
        //go w innym kodzie użyj wcześniej zadeklarowanej zmiennej np tablicaStringZWynikami[0] to będzie pierwszy element z wiersza

        //PAMIĘTAJ O USUNIĘCIU KOMENTARZY PO NAPISANIU PROJEKTU
    }



    //łączenie, rozłączanie
    public class BazaLaczkaRozlaczka
    {
        public static SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        public static string BAZA_DANYCH_KSIAZKA_NAD_LACZKA = "Data Source=" + BazyDanychOpis.BAZA_DANYCH_PLIK + ";Version=3;New=False;Compress=True;";
        public SQLiteCommand Polacz()
        {
            try { sql_con = new SQLiteConnection(BAZA_DANYCH_KSIAZKA_NAD_LACZKA); sql_con.Open(); sql_cmd = sql_con.CreateCommand(); }
            catch { MessageBox.Show("Błąd połączenia z bazą danych"); }
            return sql_cmd;
        }
        public void Rozlacz()
        {
            try { sql_con.Close(); }
            catch { MessageBox.Show("Błąd rozłączenia z bazą danych"); }
        }
    }

    public class BazyDanychSQLSelect
    {
        public string zmienJednoPole(int idPola, int Pole, string wartoscPola)
        {
            string[] nazwaPola = BazyDanychOpis.DANE_BAZA;
            string nazwaTabeli = BazyDanychOpis.BAZYDANYCH_TABELA;
            string sqlString = null;
            try
            {
                sqlString = "UPDATE `" + nazwaTabeli + "` SET `" + nazwaPola[Pole - 1] + "`= '" + wartoscPola + "' WHERE `_rowid_`= '" + idPola + "'";

            }
            catch
            {
                MessageBox.Show("Błąd zmiany pola w bazie danych, sprawdź funkcję zmienJednoPole()!");

            }
            return sqlString;
        }


        public string dodajRekordWiele(string[] wartoscPola)
        {
            string nazwaTabeli = BazyDanychOpis.BAZYDANYCH_TABELA;
            string[] nazwaPola = BazyDanychOpis.DANE_BAZA;
            int ilosc = nazwaPola.Length;
            string sqlString = null;
            try
            {
                sqlString += "INSERT INTO " + nazwaTabeli + " ('";
                for (int i = 0; i < ilosc; i++)
                {
                    sqlString += nazwaPola[i];
                    if (i < ilosc - 1) { sqlString += "', '"; }
                }
                sqlString += "') VALUES ('";
                for (int i = 0; i < ilosc; i++)
                {
                    sqlString += wartoscPola[i];
                    if (i < ilosc - 1) { sqlString += "', '"; }
                }
                sqlString += "')";
            }
            catch
            {
                MessageBox.Show("Błąd zmiany pola w bazie danych, sprawdź funkcję zmienJednoPole()!");

            }
            return sqlString;
        }


        public string wczytajTabeleCala(string nazwaTabeli)
        {
            string sqlString = null;
            try
            {
                sqlString = "SELECT * FROM " + nazwaTabeli + ";";
            }
            catch
            {
                MessageBox.Show("Błąd wczytania pola w bazie danych, sprawdź funkcję wczytajTabeleCala()!");
            }
            return sqlString;
        }
        public string iloscRekordow(string nazwaTabeli)
        {
            string sqlString = null;
            try
            {
                sqlString = "SELECT COUNT(*) FROM " + nazwaTabeli + ";";
            }
            catch
            {
                MessageBox.Show("Błąd w funkcji ilość rekordów!");
            }

            return sqlString;
        }

        public string wczytajTRekordPoID(int id)
        {
            string nazwaTabeli = BazyDanychOpis.BAZYDANYCH_TABELA;
            string sqlString = null;
            try
            {
                sqlString = "SELECT * FROM " + nazwaTabeli + " WHERE " + BazyDanychOpis.BAZA_DANYCH_KLUCZ + " = " + id + ";";
            }
            catch
            {
                MessageBox.Show("Błąd podczas wczytywania rekordu!");

            }
            return sqlString;
        }
    }
        public class SqlAllInOne
        {

            public int rowsAmount()
            {
                string nazwaTabeli = BazyDanychOpis.BAZYDANYCH_TABELA;
                int rows = 0;
                try
                {
                    BazaLaczkaRozlaczka baza = new BazaLaczkaRozlaczka();
                    SQLiteCommand sql_cmd = baza.Polacz();
                    BazyDanychSQLSelect select = new BazyDanychSQLSelect();
                    sql_cmd.CommandText = select.iloscRekordow(nazwaTabeli);
                    SQLiteDataReader reader = sql_cmd.ExecuteReader();

                    while (reader.Read()) { rows = reader.GetInt32(0); }
                    baza.Rozlacz();
                }
                catch
                {
                    MessageBox.Show("Błąd podczas wczytywania rekordu!");
                }
                return rows;
            }


            //INSERTS
            public void insertSQLData(string[] dane)
            {
                try
                {
                    BazaLaczkaRozlaczka bazaLaczkaRozlaczka = new BazaLaczkaRozlaczka();
                    BazyDanychSQLSelect insertSQL = new BazyDanychSQLSelect();
                    SQLiteCommand sql_cmd = bazaLaczkaRozlaczka.Polacz();
                    string[] sqlDane = dane;
                    sql_cmd.CommandText = insertSQL.dodajRekordWiele(sqlDane);
                    SQLiteDataReader sql_datareader = sql_cmd.ExecuteReader();
                    bazaLaczkaRozlaczka.Rozlacz();
                }
                catch
                {
                    MessageBox.Show("Błąd podczas dodawania rekordu!");
                }

            }

            public void changeSQLDataPole(int id_local, int nazwaPola, string wartoscPola)
            {

                string nazwaTabeli = BazyDanychOpis.BAZYDANYCH_TABELA;
                BazaLaczkaRozlaczka bazaLaczkaRozlaczka = new BazaLaczkaRozlaczka();
                BazyDanychSQLSelect insertSQL = new BazyDanychSQLSelect();
                SQLiteCommand sql_cmd = bazaLaczkaRozlaczka.Polacz();
                sql_cmd.CommandText = insertSQL.zmienJednoPole(id_local, nazwaPola, wartoscPola);
                SQLiteDataReader sql_datareader = sql_cmd.ExecuteReader();
                bazaLaczkaRozlaczka.Rozlacz();
            }

            //SELECTS
            public string[] selectSQLDataID(int id_local)
            {
                string[] stringZwracany = new string[BazyDanychOpis.DANE_BAZA.Length];
                string nazwaTabeli = BazyDanychOpis.BAZYDANYCH_TABELA;
                int i = 0;
                BazaLaczkaRozlaczka bazaLaczkaRozlaczka = new BazaLaczkaRozlaczka();
                BazyDanychSQLSelect selectSQL = new BazyDanychSQLSelect();
                SQLiteCommand sql_cmd = bazaLaczkaRozlaczka.Polacz();
                sql_cmd.CommandText = selectSQL.wczytajTRekordPoID(id_local);
                SQLiteDataReader sql_datareader = sql_cmd.ExecuteReader();
                while (sql_datareader.Read())
                {
                    for (i = 0; i < BazyDanychOpis.DANE_BAZA.Length; i++)
                    {
                        stringZwracany[i] = sql_datareader[i + 1].ToString();

                    }
                }
                bazaLaczkaRozlaczka.Rozlacz();
                return stringZwracany;
            }





            public string[,] selectSQLDataALL()
            {
                string[,] roboczy = new string[rowsAmount(), BazyDanychOpis.DANE_BAZA.Length];
                SqlAllInOne sqlAllInOne = new SqlAllInOne();
                for (int i = 0; i < rowsAmount(); i++)
                {
                    for (int j = 0; j < BazyDanychOpis.DANE_BAZA.Length; j++)
                    {
                        roboczy[i, j] = sqlAllInOne.selectSQLDataID(i + 1)[j];

                    }


                }
                // MessageBox.Show(sqlAllInOne.selectSQLDataID(0)[0]); 
                return roboczy;
            }



        }
    }


