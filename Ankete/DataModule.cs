using System;
using System.Data;
using System.Data.OleDb;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Test1
{

    public class DBAnkete
    {
        private string exepath="";
        private string connStr = "";
        private OleDbConnection conn = null;
        
        private DataSet dsPitanja = null;
        private OleDbDataAdapter adPitanja = null;
        private BindingSource bindPitanja=null;

        private DataSet dsOdgovori = null;
        private OleDbDataAdapter adOdgovori = null;
        private BindingSource bindOdgovori=null;

        //konstruktor za bazu podataka Ankete
        public DBAnkete(){
            exepath = Application.StartupPath;
            connStr = @"Provider=Microsoft.JET.OLEDB.4.0;" + @"data source=" + exepath + @"\ANKETE.mdb";
            conn = new OleDbConnection(connStr);
        }

        // create and open the connection        
        private bool openDB(){
            try{ conn.Open();}
            catch (OleDbException ex){MessageBox.Show(ex.Message); return false; }
            return true;
        }

        // close the connection
        private bool closeDB()
        {
            try{ conn.Close();}
            catch (OleDbException ex){MessageBox.Show(ex.Message); return false;}
            return true;
        }

        // Dali je konekcija aktivna tj. dali je uspješno instanciran objekt conn
        public bool IsActive(){
            if (conn != null) return true;
            else return false;
        }

        // Otvara tablicu Pitanja iz baze podataka Ankete
        public DataTable OpenPitanja()
        {
            // create the adapter and fill the DataSet
            String sql = "SELECT RBR,PITANJE,ID_ANKETE from PITANJA ORDER BY RBR";
            adPitanja = new OleDbDataAdapter();
            adPitanja.SelectCommand = new OleDbCommand(sql, conn);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(adPitanja);

            openDB();
            dsPitanja = new DataSet("PITANJA");
            adPitanja.Fill(dsPitanja, "PITANJA");

            DataTable dtPitanja = dsPitanja.Tables[0];
            dtPitanja.PrimaryKey=new DataColumn[]{dtPitanja.Columns["ID_ANKETE"]};

            // objekt za povezivanje tablice podataka i tablice prikaza 
            bindPitanja = new BindingSource();
            bindPitanja.DataSource = dtPitanja;

            closeDB();

            return dtPitanja;
        }

        // Pronalazi maksimalni redni broj ankete
        public int MaxRbrPitanja()
        {
            int rbr=0;
            String srbr;

            String sql = "SELECT MAX(RBR) from PITANJA";

            openDB();
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            try{
                rbr = Convert.ToInt32(cmd.ExecuteScalar());
            }catch (Exception) { }
                        
            closeDB();

            return rbr;
        }

        // Pronalazi maksimalni ID_ANKETE
        public int MaxIDAnkete()
        {
            int rbr = 0;
            String srbr;

            String sql = "SELECT MAX(ID_ANKETE) from PITANJA";

            openDB();
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            try
            {
                rbr = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception) { }

            closeDB();

            return rbr;
        }

        // Sprema sve promjene u tablici Odgovori
        public void UpdateOdgovori()
        {
            DataTable changes = dsOdgovori.Tables["ODGOVORI"].GetChanges();
            if(changes!=null) adOdgovori.Update(dsOdgovori,"ODGOVORI");
        }

        // Sprema sve promjene u tablici Pitanja
        public void UpdatePitanja()
        {
            DataTable changes = dsPitanja.Tables["PITANJA"].GetChanges();
            if (changes != null) adPitanja.Update(dsPitanja, "PITANJA");
        }


        // Otvara tablicu Odgovori iz baze podataka Ankete
        public DataTable OpenOdgovori(int id)
        {
            // create the adapter and fill the DataSet
            String sql = "SELECT RBR,ODGOVOR,GLASOVI,ID_ANKETE,ID_ODGOVORA FROM ODGOVORI WHERE ID_ANKETE=" + id.ToString() + " ORDER BY RBR";
            DataTable dtOdgovori=null;

            try
            {
                adOdgovori = new OleDbDataAdapter();
                adOdgovori.SelectCommand = new OleDbCommand(sql, conn);
                OleDbCommandBuilder cb = new OleDbCommandBuilder(adOdgovori);
                openDB();
                dsOdgovori = new DataSet("ODGOVORI");
                adOdgovori.Fill(dsOdgovori, "ODGOVORI");

                adOdgovori.UpdateCommand = cb.GetUpdateCommand();
                adOdgovori.InsertCommand = cb.GetInsertCommand();

                dtOdgovori = dsOdgovori.Tables[0];

                bindOdgovori = new BindingSource();
                bindOdgovori.DataSource = dtOdgovori;

                closeDB();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };

            return dtOdgovori;
        }

        public BindingSource getBind(String table){
            BindingSource bs=null;
            switch (table){
                case "PITANJA": bs = bindPitanja; break;
                case "ODGOVORI": bs = bindOdgovori; break;
            }
            return bs;
        }

    }


    //----------------------------------------------- kako dohvatiti podatke iz tablice
    //foreach (DataRow dr in dtPitanja.Rows){ /*MessageBox.Show(dr["PITANJE"].ToString());*/}
    //----------------------------------------------- Kako upisati u tablicu
    //DataRow newRow = ds.Tables["PITANJA"].NewRow();
    //newRow["RBR"] = 9;
    //newRow["PITANJE"] = "Koliko je sati ?";
    //ds.Tables["PITANJA"].Rows.Add(newRow);
    //adapter.Update(dt);

}