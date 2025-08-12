using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _301_EfProjects1
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
            EğitimKampıEFTravelDbEntities db = new EğitimKampıEFTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            List<Location> values = db.LocationSet.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          Location location = new Location();
            location.LocationName = TextCity.Text;
            location.LocationCountry = textCountry.Text;
            db.LocationSet.Add(location);
            db.SaveChanges();
            MessageBox.Show("Yeni Lokasyon Başarıyla Eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var removeValue = db.Guide.Find(id);
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Silindi");    
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.LocationCapacity=byte.Parse(nudCapacity.Value.ToString());
            location.LocationCity = TextCity.Text;
            location.LocationCountry = textCountry.Text;
            location.LocationPrica = decimal.Parse(textPrice.Text);
            location.Guideıd =int.Parse(comboBox1.SelectedValue.ToString());
            db.LocationSet.Add(location);
            db.SaveChanges();
            MessageBox.Show("Lokasyon Başarıyla Eklendi");
        }

        private void btnId_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var values = db.Guide.Where(x=>x.GuideId==id).ToList();
            dataGridView1.DataSource = values;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x=> new
            {
                FullName = x.GuideName + " " + x.GuideSurname,x.GuideId
            }).ToList();
            comboBox1.DisplayMember="FullName";
            comboBox1.ValueMember = "GuideId";
            comboBox1.DataSource = values;

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }
   
    }
}
