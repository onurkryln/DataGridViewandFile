using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev
{
    public partial class Form1 : Form
    {
        List<Mammal> liste;
        string url = "C:\\Users\\Lenovo\\OneDrive\\Masaüstü\\mammal\\Mammal.csv";
        public Form1()
        {

            InitializeComponent();
            dataGridView1.DataSource = liste;
            oku();
        }

        private List<Mammal> MammalList(string name, double lenght, int population)
        {
            var list = new List<Mammal>();
            list.Add(new Mammal() { name = name, population = population, lenght = lenght });
            return list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oku();
        }
        public void oku() {
            List<Mammal> mammalList = new List<Mammal>();
            StreamReader reader = new StreamReader(url);
            while (!reader.EndOfStream)
            {
                string oku = reader.ReadLine().Trim();
                string[] satır = oku.Split(',');
                string name = satır[0];
                double lengt = Convert.ToDouble(satır[2]);
                int population = Convert.ToInt32(satır[1]);
                Mammal mammal = new Mammal();
                mammal.name = name;
                mammal.population = population;
                mammal.lenght = lengt;
                mammalList.Add(mammal);}
            reader.Close();
            dataGridView1.DataSource = mammalList;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter(url, true);
            try
            {
                using (streamWriter)
                {
                    streamWriter.WriteLine(nametxt.Text + ","
                        + Convert.ToInt32(nufusttxt.Text) + "," + 
                        Convert.ToDouble(lengttxt.Text));


                }
            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void güncellebtn_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;

            if (rowIndex >= 0 && columnIndex >= 0) // Sadece hücre seçilirse işlem yap
            {

                if (nametxt.Text == "" && lengttxt.Text != "" && nufusttxt.Text != "")
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                    int newPopulation = Convert.ToInt32(nufusttxt.Text);
                    double newLength = Convert.ToDouble(lengttxt.Text);
                    string name = selectedRow.Cells[0].Value.ToString();

                    selectedRow.Cells[0].Value = name;
                    selectedRow.Cells[2].Value = newLength;
                    selectedRow.Cells[1].Value = newPopulation;

                }
                else if (nametxt.Text != "" && lengttxt.Text == "" && nufusttxt.Text != "")
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                    string name = selectedRow.Cells[0].Value.ToString();
                    double length = Convert.ToDouble(selectedRow.Cells[2].Value);
                    string newName = nametxt.Text;
                    int newPopulation = Convert.ToInt32(nufusttxt.Text);
                    selectedRow.Cells[0].Value = newName;
                    selectedRow.Cells[2].Value = length;
                    selectedRow.Cells[1].Value = newPopulation;

                }
                else if (nametxt.Text != "" && lengttxt.Text != "" && nufusttxt.Text == "")
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                    string name = selectedRow.Cells[0].Value.ToString();
                    double length = Convert.ToDouble(selectedRow.Cells[2].Value);
                    int population = Convert.ToInt32(selectedRow.Cells[1].Value);
                    string newName = nametxt.Text;
                    double newLength = Convert.ToDouble(lengttxt.Text);
                    selectedRow.Cells[0].Value = newName;
                    selectedRow.Cells[2].Value = newLength;
                    selectedRow.Cells[1].Value = population;

                }
                else if (nametxt.Text == "" && lengttxt.Text == "" && nufusttxt.Text != "")
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                    string name = selectedRow.Cells[0].Value.ToString();
                    double length = Convert.ToDouble(selectedRow.Cells[2].Value);
                    int newPopulation = Convert.ToInt32(nufusttxt.Text);
                    selectedRow.Cells[0].Value = name;
                    selectedRow.Cells[2].Value = length;
                    selectedRow.Cells[1].Value = newPopulation;
                }
                else if (nametxt.Text == "" && lengttxt.Text != "" && nufusttxt.Text == "")
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                    string name = selectedRow.Cells[0].Value.ToString();
                    double newLength = Convert.ToDouble(lengttxt.Text);
                    int population = Convert.ToInt32(selectedRow.Cells[1].Value);
                    selectedRow.Cells[0].Value = name;
                    selectedRow.Cells[2].Value = newLength;
                    selectedRow.Cells[1].Value = population;
                }
                else if (nametxt.Text != "" && lengttxt.Text == "" && nufusttxt.Text == "")
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                    string name = selectedRow.Cells[0].Value.ToString();
                    double length = Convert.ToDouble(selectedRow.Cells[2].Value);
                    int population = Convert.ToInt32(selectedRow.Cells[1].Value);
                    string newName = nametxt.Text;
                    selectedRow.Cells[0].Value = newName;
                    selectedRow.Cells[2].Value = length;
                    selectedRow.Cells[1].Value = population;
                }
                else if (nametxt.Text == "" && lengttxt.Text == "" && nufusttxt.Text == "") {
                    DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

                    string name = selectedRow.Cells[0].Value.ToString();
                    double length = Convert.ToDouble(selectedRow.Cells[2].Value);
                    int population = Convert.ToInt32(selectedRow.Cells[1].Value);
                    selectedRow.Cells[0].Value = name;
                    selectedRow.Cells[2].Value = length;
                    selectedRow.Cells[1].Value = population;
                }



                else
                {

                    DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                    string name = selectedRow.Cells[0].Value.ToString();
                    double length = Convert.ToDouble(selectedRow.Cells[2].Value);
                    int population = Convert.ToInt32(selectedRow.Cells[1].Value);
                    string newName = nametxt.Text;
                    int newPopulation = Convert.ToInt32(nufusttxt.Text);
                    double newLength = Convert.ToDouble(lengttxt.Text);
                    selectedRow.Cells[0].Value = newName;
                    selectedRow.Cells[2].Value = newLength;
                    selectedRow.Cells[1].Value = newPopulation;



                } // Güncelleme işlemi için gerekli kodlar
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int seciliSutun = dataGridView1.CurrentCell.ColumnIndex;
                    DataGridViewRow seciliSatir = dataGridView1.SelectedRows[0];
            try
            {
                if (dataGridView1.SelectedRows.Count > 0) // Sadece hücre seçilirse işlem yap
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[seciliSatir.Index];
                    selectedRow.Cells[0].Value = "";
                    selectedRow.Cells[2].Value = null;
                    selectedRow.Cells[1].Value = null;
                    güncelle();
                }
                if (seciliSatir.Index < 0  ) {
                    throw new Exception("seçili satır yok");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            güncelle();
        }

        
        public void güncelle()
        {

            clear();
            StreamWriter streamWriter = new StreamWriter(url, true);


            using (streamWriter)
            {
                int i = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataGridViewCell cell1 = row.Cells[0]; // sadece ilk sütundaki hücreleri al
                    DataGridViewCell cell2 = row.Cells[1]; // sadece ilk sütundaki hücreleri al
                    DataGridViewCell cell3 = row.Cells[2];

                    streamWriter.WriteLine(cell1.Value + "," + cell2.Value + "," + cell3.Value);
                    i++;

                }


            }
        }



       




        public void clear() {

            using (FileStream dosya = new FileStream(url, FileMode.Truncate, FileAccess.Write))
            {
                using (StreamWriter yazici = new StreamWriter(dosya))
                {
                    yazici.Write("");
                }
            }


        }
        public List<string> okuma() {
            string filePath = url;
            List<string> updatedLines = new List<string>();
            StreamReader streamReader = new StreamReader(filePath);
            using (streamReader)
            {
                while (!streamReader.EndOfStream)
                {
                    updatedLines.Add(streamReader.ReadLine());
                }
            }
            return updatedLines;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
