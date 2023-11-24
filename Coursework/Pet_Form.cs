using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Pet_Form : UserControl
    { /* Place connection string here in the connection */
        static string connection = "";
        static MongoClient client = new MongoClient(connection);
        static IMongoDatabase db = client.GetDatabase("lab14");
        static IMongoCollection<Pet> Petcollection = db.GetCollection<Pet>("pet");
        public Pet_Form()
        {
            InitializeComponent();
            ReadAllPets();
        }
        public void ReadAllPets()
        {
            List<Pet> list = Petcollection.AsQueryable().ToList<Pet>();
            dataGridView1.DataSource = list;
            txtID_Pet.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            txtName_Pet.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            btnSpecies.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            txtWeight.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            txtOwnerName_Pet.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            btnStatus.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                txtID_Pet.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName_Pet.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                btnSpecies.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtWeight.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtOwnerName_Pet.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                btnStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Pet p = new Pet(txtName_Pet.Text, btnSpecies.Text, Double.Parse(txtWeight.Text)
                    , txtOwnerName_Pet.Text, btnStatus.Text);
                Petcollection.InsertOne(p);
            } catch (FormatException)
            {
                MessageBox.Show("Weight input is not number", "Adding error");
            }

            
            ReadAllPets();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {   
            var temp = txtName_Pet.Text;
            var confirmResult = MessageBox.Show("Are you sure to abandon " + temp + " ?",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {

                Petcollection.DeleteOne(o => o.Id == ObjectId.Parse(txtID_Pet.Text));
                MessageBox.Show(temp + "Gone!");
            }
            else
            {

            }

            ReadAllPets();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                var updateDef = Builders<Pet>.Update.Set("Name", txtName_Pet.Text).Set("SpeciesName", btnSpecies.Text)
                                .Set("Weight", Double.Parse(txtWeight.Text)).Set("OwnerName", txtOwnerName_Pet.Text)
                                .Set("Status", btnStatus.Text);
                Petcollection.UpdateOne(o => o.Id == ObjectId.Parse(txtID_Pet.Text), updateDef);
            }

            catch (FormatException)
            {
                MessageBox.Show("Weight input is not number", "Update error");
            }
            ReadAllPets();
        }
    }
}
