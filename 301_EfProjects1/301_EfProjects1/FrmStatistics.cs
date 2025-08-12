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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EğitimKampıEFTravelDbEntities db = new EğitimKampıEFTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.LocationSet.Count().ToString();
            lblSumCapacity.Text = db.LocationSet.Sum(x=> x.LocationCapacity).ToString();
            lblGuideCount1.Text = db.Guide.Count().ToString();
            lblAvgCapacity.Text = (db.LocationSet.Average(x => x.LocationCapacity)).ToString();
            lblAvgLocationPrice.Text = (db.LocationSet.Average(x => x.LocationPrica)).ToString();
            int lastCountryID = db.LocationSet.Max(x => x.LocationId);
            lblLastCountry.Text = db.LocationSet.Where(x => x.LocationId == lastCountryID).Select(y => y.LocationCountry).FirstOrDefault();

            lblcapadociacapacity.Text = db.LocationSet.Where(x=> x.LocationCity =="Kapadokya").Select(y=>y.LocationCapacity).FirstOrDefault().ToString();
            lblTurkeyCapacityAvg.Text = db.LocationSet.Where(x => x.LocationCountry =="Türkiye").Average(y => y.LocationCapacity).ToString();
            
            var RomeGuideID = db.LocationSet.Where(x=> x.LocationCity == "Roma").Select(y => y.Guideıd).FirstOrDefault();
            lblRomeGuide.Text = db.Guide.Where(x => x.GuideId == RomeGuideID).Select(y => y.GuideName).FirstOrDefault();

            var MaxCapacity = db.LocationSet.Max(x => x.LocationCapacity);  
            lblMaxCapacityLocation.Text = db.LocationSet.Where(x => x.LocationCapacity == MaxCapacity).Select(y => y.LocationCity).FirstOrDefault();

            var MaxPrice = db.LocationSet.Max(x => x.LocationPrica);
            lblMaxPriceLocation.Text = db.LocationSet.Where(x => x.LocationPrica == MaxPrice).Select(y => y.LocationCity).FirstOrDefault();

            var guideIdbyNameSergenYagli = db.Guide.Where(x => x.GuideName == "Sergen" && x.GuideSurname == "Yağlı").Select(y => y.GuideId).FirstOrDefault();
            lblSergenLocationCount.Text = db.LocationSet.Where(x => x.Guideıd == guideIdbyNameSergenYagli).Count().ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAvgLocationPrice_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
