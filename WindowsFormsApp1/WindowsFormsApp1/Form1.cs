using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Threading;
using CsvHelper;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public delegate void ThreadStart();
        
        DB db = new DB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Welcome.Visible = true;
        }

         
        public DataTable ReadCsvFile(string file)
            {
                Loading.Visible = true;
                progressBar1.Visible = true;
                Welcome.Visible = false;

                DataTable dtrd = new DataTable();
                using (StreamReader streamReaderr = new StreamReader(file))
                {
                    while (!streamReaderr.EndOfStream)
                    {
                        string text = streamReaderr.ReadToEnd();

                        string[] rows = text.Split('\n');
                        if (rows.Length > 0)
                        {
                            progressBar1.Maximum = rows.Length;
                            progressBar1.Minimum = 2;
                            //Add columns
                            string[] columns = rows[0].Split(';');
                            for (int j = 0; j < columns.Count(); j++)
                            {
                                dtrd.Columns.Add(columns[j]);

                            }

                            //Add rows
                            for (int i = 1; i < rows.Count() - 1; i++)
                            {

                                string[] data = rows[i].Split(';');
                                DataRow dr = dtrd.NewRow();
                                for (int k = 0; k < data.Count(); k++)

                                    dr[k] = data[k];

                                dtrd.Rows.Add(dr);

                                progressBar1.Value++;


                                MySqlCommand command = new MySqlCommand("INSERT INTO `documents` (`Id`, `Type`, `Date`, `FirstName`, `LastName`, `City`) VALUES (@id, @ttype, @date, @firstname, @lastname, @city)", db.GetConnection());

                                command.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(dr.ItemArray[0]);
                                command.Parameters.Add("@ttype", MySqlDbType.VarChar).Value = dr.ItemArray[1];
                                command.Parameters.Add("@date", MySqlDbType.VarChar).Value = dr.ItemArray[2];
                                command.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = dr.ItemArray[3];
                                command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = dr.ItemArray[4];
                                command.Parameters.Add("@city", MySqlDbType.VarChar).Value = dr.ItemArray[5];

                                db.openConnection();

                                if (command.ExecuteNonQuery() == 1)
                                {

                                }

                            }
                            db.closeConnection();
                            progressBar1.Visible = false;
                           // Loading.Visible = false;
                            dataGridView1.Visible = true;
                        }
                    }
                
                }
                return dtrd;        
            }///Wczyt pierwszej tabeli 
        public DataTable ReadCsvFileItem(string file)
        {
            dataGridView1.Visible = true;
            progressBar1.Visible = true;
            Loading.Visible = true;
            DataTable dti = new DataTable();
             using (StreamReader streamReader = new StreamReader(file))
             {
                while (!streamReader.EndOfStream)
                 {
                    
                    string text = streamReader.ReadToEnd();
                     string[] rows = text.Split('\n');

                    int qt = rows.Length;
                    progressBar1.Maximum = qt;
                    progressBar1.Minimum = 2;

                    if (rows.Length > 0)
                     {
                         //Add columns
                         string[] columns = rows[0].Split(';');
                         for (int j = 0; j < columns.Count(); j++)
                         {
                             dti.Columns.Add(columns[j]);

                         }

                         //Add rows
                         for (int i = 1; i < rows.Count() - 1; i++)
                         {
                             string[] data = rows[i].Split(';');
                             DataRow dr = dti.NewRow();
                             for (int k = 0; k < data.Count(); k++)

                                 dr[k] = data[k];       
                                 dti.Rows.Add(dr);

                            progressBar1.Value++;

                            MySqlCommand command = new MySqlCommand("INSERT INTO `documentitems` (`DocumentId`, `Ordinal`, `Product`, `Quantity`, `Price`, `TaxRate`) VALUES (@documentId, @ordinal, @product, @quantity, @price, @taxRate)", db.GetConnection());

                                 command.Parameters.Add("@documentId", MySqlDbType.Int32).Value =Convert.ToInt32(dr.ItemArray[0]);
                                 command.Parameters.Add("@ordinal", MySqlDbType.VarChar).Value = dr.ItemArray[1];
                                 command.Parameters.Add("@product", MySqlDbType.VarChar).Value = dr.ItemArray[2];
                                 command.Parameters.Add("@quantity", MySqlDbType.VarChar).Value = dr.ItemArray[3];
                                 command.Parameters.Add("@price", MySqlDbType.VarChar).Value = dr.ItemArray[4];
                                 command.Parameters.Add("@taxRate", MySqlDbType.VarChar).Value = dr.ItemArray[5];

                             db.openConnection();

                             if (command.ExecuteNonQuery() == 1)
                             {

                             }
                         }
                        db.closeConnection();
                        progressBar1.Visible = false;
                        Loading.Visible = false;
                        dataGridView1.Visible = true;

                    }
                }
             }
             return dti;
         }///Wczyt drugiej tabeli Items

        public void SortBase(string file)
        {
            DataTable dTable = ReadCsvFile(file);
            string ddsff=" ";
            string ddsf=ReadCsvFile(file).Columns.Count.ToString(ddsff);


        }
        private void btnRead_Click(object sender, EventArgs e)
        {
          using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Document|*.csv" })
          {
                 if (ofd.ShowDialog() == DialogResult.OK)
                 {
                    dataGridView1.DataSource = ReadCsvFile(ofd.FileName);
                 }
          }
        }
        
        private void btnReadIt_Click(object sender, EventArgs e)
        {
            Welcome.Visible = false;
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Document|*.csv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.DataSource = ReadCsvFileItem(ofd.FileName);
                }
            }
        }

        private void btnClearDB_Click(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 1)
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
            db.cleardate();
            Welcome.Visible = true;
            Welcome.Text = "Clear";
            dataGridView1.Visible = false;
            progressBar1.Visible = false;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortBase(null);
        }

        private void btnSaveDB_Click(object sender, EventArgs e)
        {
            /* using(SaveFileDialog sfd=new SaveFileDialog() { Filter="CSV|*.csv", ValidateNames=true})
             {
                 if(sfd.ShowDialog()==DialogResult.OK)
                 {
                     using(var sw = new StreamWriter(sfd.FileName))
                     {
                         var writer = new CsvWriter(sw);
                         writer.WriteHeader(typeof(Student));
                         foreach(Student s in studentBindingSource.DataSource as List<Student>)
                         {
                             writer.WritRecord(s);
                         }
                     }
                 }
             }*/
        }

    }
}
