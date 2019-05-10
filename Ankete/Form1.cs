using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        public DBAnkete ANKETE;
        public DataTable PITANJA;
        public DataTable ODGOVORI;
        public int ID_ANKETE=-1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ANKETE = new DBAnkete(); // Otvara bazu podataka Ankete.mdb
        }
              

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // funkcija koja razvlači tablicu s odgovorima da se vide svi odgovori
        private void ArrangeGridOdgovori(){
            int ret = 0,bord=0,head=0;
            var ds = gridOdgovori.DataSource;
            if (ds == null) return;
            gridOdgovori.Columns["RBR"].MinimumWidth = 30;
            gridOdgovori.Columns["RBR"].Width = 30;
            gridOdgovori.Columns["RBR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridOdgovori.Columns["ODGOVOR"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridOdgovori.Columns["GLASOVI"].MinimumWidth = 30;
            gridOdgovori.Columns["GLASOVI"].Width = 30;
            gridOdgovori.Columns["GLASOVI"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridOdgovori.Columns["ID_ODGOVORA"].Visible = false;
            gridOdgovori.Columns["ID_ANKETE"].Visible = false;


            bord=(gridOdgovori.BorderStyle==BorderStyle.None)?0:2;
            head = (gridOdgovori.ColumnHeadersVisible) ? gridOdgovori.ColumnHeadersHeight : 0;
            ret = gridOdgovori.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + head + bord + 6;
            splitGraf.SplitterDistance = splitGraf.Size.Height - ret;
            gridOdgovori.Update();
        }

        private void ArrangeGridPitanja()
        {
            gridPitanja.Columns["ID_ANKETE"].Visible = false; ;
            gridPitanja.Columns["RBR"].MinimumWidth = 30;
            gridPitanja.Columns["RBR"].Width = 30;
            gridPitanja.Columns["RBR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridPitanja.Columns["PITANJE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridPitanja.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenAnkete();
        }

        // Otvara bazu anketa i prikazuje tablice i graf 
        void OpenAnkete(){
            int selrow = -1;
            String pitanje;
            ANKETE = new DBAnkete(); // Otvara bazu podataka Ankete.mdb
            if (ANKETE.IsActive())
            {
                PITANJA = ANKETE.OpenPitanja(); // Otvara tablicu Pitanja
                gridPitanja.DataSource = ANKETE.getBind("PITANJA"); //Povezuje podatke i prikaz u tablici
                ArrangeGridPitanja();

                selrow = GetSelRowAnkete();
                if (selrow >= 0)
                {
                    pitanje = Convert.ToString(gridPitanja.Rows[selrow].Cells["PITANJE"].Value);
                    FillGridOdgovori(GetSelIDAnkete(), pitanje);
                    panPitanja.Enabled = true;
                }

            }
        }

        // daje index reda koji je selektiran u tabličnom prikazu anketa
        int GetSelRowAnkete()
        {
            int selrow = -1;
            if (gridPitanja.SelectedCells.Count > 0)
            {
                try{
                    selrow = gridPitanja.SelectedCells[0].RowIndex;
                }catch (Exception) { }
            }

            return selrow;
        }

        // daje ID_ANKETE za red koji je selektiran u tabličnom prikazu anketa
        int GetSelIDAnkete(){
            int id=-1,selrow=-1;
                        
            try{
                selrow = GetSelRowAnkete();
                if (selrow >= 0){
                    DataGridViewRow row = gridPitanja.Rows[selrow];
                    id = Convert.ToInt32(row.Cells["ID_ANKETE"].Value);
                }
            }catch (Exception){}

            return id;
        }

        //Otvara tablicu odgovora za zadanu anketu i popunjava tablicu prikaza odgovora ispod grafa
        private void FillGridOdgovori(int id_ankete,String pitanje)
        {
            if (id_ankete > -1)
            {
                ODGOVORI = ANKETE.OpenOdgovori(id_ankete); // Otvara tablicu Odgovori
                gridOdgovori.DataSource = ANKETE.getBind("ODGOVORI"); //Povezuje podatke i prikaz u tablici
                chart1.DataSource = ANKETE.getBind("ODGOVORI");
                chart1.Titles[0].Text = pitanje;
                chart1.ApplyPaletteColors();
                chart1.Update();
                ColorGridOdgovori();
                ArrangeGridOdgovori();
                chart1.Show();
                gridOdgovori.Show();
            }else{
                chart1.Titles[0].Text = "";
                chart1.Hide();
                gridOdgovori.Hide();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ArrangeGridOdgovori();
        }

        // stavlja odgovarajuću boju u prvi redak tablice sa prikazom odgovora
        private void ColorGridOdgovori()
        {
            chart1.ApplyPaletteColors();
            for (int i = 0; i < gridOdgovori.Rows.Count; i++)
            {
                if (chart1.Series[0].Points.Count > i)
                {
                    DataGridViewCellStyle vcs = new DataGridViewCellStyle();
                    vcs.BackColor = chart1.Series[0].Points[i].Color;
                    gridOdgovori.Rows[i].Cells[0].Style.BackColor = vcs.BackColor;
                }
            }
            gridOdgovori.Update();
        }

        private void gridOdgovori_SelectionChanged(object sender, EventArgs e)
        {
            gridOdgovori.ClearSelection();
        }

        private void gridPitanja_SelectionChanged(object sender, EventArgs e)
        {
            String pitanje = "";
            
            try
            {
                pitanje = Convert.ToString(gridPitanja.Rows[GetSelRowAnkete()].Cells["PITANJE"].Value);
            }catch (Exception){}
            
            FillGridOdgovori(GetSelIDAnkete(),pitanje);
        }

    

        // Popunjava tablični prikaz odgovora na kartici za izmjenu podataka o anketi
        private void FillTblOdgovori()
        {
            if (gridPitanja.RowCount < 1) return; // izlazi ako nije otvorena tablica s pitanjima

            String pitanje = Convert.ToString(gridPitanja.Rows[gridPitanja.SelectedCells[0].RowIndex].Cells["PITANJE"].Value);
            int id_ankete = Convert.ToInt32(gridPitanja.Rows[gridPitanja.SelectedCells[0].RowIndex].Cells["ID_ANKETE"].Value);

            txPitanje.Text = pitanje;
            ODGOVORI = ANKETE.OpenOdgovori(id_ankete); // Otvara tablicu Odgovori
            gridIzmjena.DataSource = ANKETE.getBind("ODGOVORI"); //Povezuje podatke i prikaz u tablici
            gridIzmjena.Columns["RBR"].MinimumWidth = 30;
            gridIzmjena.Columns["RBR"].Width = 30;
            gridIzmjena.Columns["RBR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridIzmjena.Columns["ODGOVOR"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridIzmjena.Columns["GLASOVI"].MinimumWidth = 30;
            gridIzmjena.Columns["GLASOVI"].Width = 30;
            gridIzmjena.Columns["GLASOVI"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridIzmjena.Columns["ID_ODGOVORA"].Visible = false;
            gridIzmjena.Columns["ID_ANKETE"].Visible = false;
                        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int selrow = 0;
            if (gridPitanja.RowCount < 1) return;
            selrow = gridPitanja.SelectedCells[0].RowIndex;

            int idankete = Convert.ToInt32(gridPitanja.Rows[gridPitanja.SelectedCells[0].RowIndex].Cells["ID_ANKETE"].Value);
            DataRow row = PITANJA.Rows.Find(idankete);
            if (row != null) row["PITANJE"] = txPitanje.Text;
            
            ANKETE.UpdateOdgovori();
            ANKETE.UpdatePitanja();
            FillTblOdgovori();
            OpenAnkete();

            if (selrow >= 0) gridPitanja.Rows[selrow].Selected = true; 
            btnPrihvati.Visible = false;
            btnOdustani.Visible = false;

        }

        private void gridIzmjena_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            int idankete=-1,rbr=-1;

            idankete = Convert.ToInt32(gridPitanja.Rows[gridPitanja.SelectedCells[0].RowIndex].Cells["ID_ANKETE"].Value);
            if (idankete == 0) return; // odustani ako nije izabran niti jedan redak

            if (gridIzmjena.RowCount <= 2) rbr = 1;
            else rbr = Convert.ToInt32(gridIzmjena.Rows[e.Row.Index - 2].Cells["RBR"].Value) + 1;

            gridIzmjena.Rows[e.Row.Index - 1].Cells["ID_ANKETE"].Value = idankete;
            gridIzmjena.Rows[e.Row.Index - 1].Cells["GLASOVI"].Value = 0;
            gridIzmjena.Rows[e.Row.Index - 1].Cells["RBR"].Value = rbr;
        }
               
        private void tabPage3_Enter(object sender, EventArgs e)
        {
            FillTblOdgovori();
        }

        private void btnBrisiPit_Click(object sender, EventArgs e)
        {
            ObrisiPitanje();
        }

        // Briše pitanje i sve povezane odgovore
        void ObrisiPitanje(){
            int idankete = 0,selrow=0;

            if (gridPitanja.SelectedCells.Count <= 0) return; // ako u tablici pitanja nema izabran red
            selrow = gridPitanja.SelectedCells[0].RowIndex;
            
            idankete = Convert.ToInt32(gridPitanja.Rows[selrow].Cells["ID_ANKETE"].Value);
            if (idankete == 0) return; // odustani ako nije izabran niti jedan redak
            
            if (selrow >= gridPitanja.RowCount - 1) selrow = gridPitanja.RowCount - 2;// ako je obrisan zadnji red u tablici
            
            var rows1 = PITANJA.Select("ID_ANKETE=" + idankete);
            foreach (var row in rows1) row.Delete();

            var rows2 = ODGOVORI.Select("ID_ANKETE=" + idankete);
            foreach (var row in rows2) row.Delete();

            ANKETE.UpdateOdgovori();
            ANKETE.UpdatePitanja();
            OpenAnkete();

            if (selrow >= 0) gridPitanja.Rows[selrow].Selected = true; 
            else txPitanje.Text = "";

            FillTblOdgovori();
        }

        private void btnBrisiOdg_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in gridIzmjena.SelectedCells)
            {
                if (cell.Selected) gridIzmjena.Rows.RemoveAt(cell.RowIndex);
            }
            btnPrihvati.Visible = true;
            btnOdustani.Visible = true;
        }
        

        // Otvori novo prazno pitanje
        void NovoPitanje(){
            txPitanje.Text = "Novo anketno pitanje";
            try
            {
                DataRow newRow = PITANJA.NewRow();
                newRow["ID_ANKETE"] = ANKETE.MaxIDAnkete() + 1;
                newRow["RBR"] = ANKETE.MaxRbrPitanja() + 1;
                newRow["PITANJE"] = txPitanje.Text;
                PITANJA.Rows.Add(newRow);
                ANKETE.UpdatePitanja();
                OpenAnkete();
                gridPitanja.Rows[gridPitanja.Rows.Count - 1].Selected = true;
                FillTblOdgovori();
            }
            catch (Exception) { }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoPitanje();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            int selrow;
            selrow = gridPitanja.SelectedCells[0].RowIndex;
            OpenAnkete();
            if (selrow >= 0) gridPitanja.Rows[selrow].Selected = true;
            FillTblOdgovori();
           
            btnOdustani.Visible = false;
            btnPrihvati.Visible = false;
        }

        private void gridIzmjena_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnPrihvati.Visible = true;
            btnOdustani.Visible = true;
        }

        private void txPitanje_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            btnOdustani.Visible = true;
            btnPrihvati.Visible = true;
        }
    }
}
