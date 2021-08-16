using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace NASAForm
{
    public partial class NasaForm : Form
    {
        HttpClient client = new HttpClient();

        public NasaForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NearestObjects();
            GetAsteroid();
            GetEarthImage();
        }

        private async void NearestObjects()
        {
            using (var response = await client.SendAsync(GetRequest("https://api.nasa.gov/neo/rest/v1/stats?&api_key=o8rmZSQMj8aiirEiRInZyrPdCsAPR2nwlFGnkUU9")))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var info = JObject.Parse(body);

                objectLabel.Text = "Near Earth Object Count | \n" + info["near_earth_object_count"].ToString();
                approachLabel.Text = "Close Approach Count \n" + info["close_approach_count"].ToString();
                updatedLabel.Text = "Last Updated \n" + info["last_updated"].ToString();
            }
        }

        private async void GetAsteroid()
        {
            using (var response = await client.SendAsync(GetRequest("https://api.nasa.gov/neo/rest/v1/neo/2000433?api_key=o8rmZSQMj8aiirEiRInZyrPdCsAPR2nwlFGnkUU9")))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var info = JObject.Parse(body);
                asteroidLabel.Text = "Asteroid \n" + info["name"];
                hazardousLabel.Text = "Potenially Hazardous Asteroid \n" + info["is_potentially_hazardous_asteroid"];

                foreach (var item in info["close_approach_data"])
                {
                    speedLabel.Text = "Km/h \n" + item["relative_velocity"]["kilometers_per_hour"];
                    orbitLabel.Text = "Orbit \n" + item["orbiting_body"];
                    break;
                }
            }
        }

        private void GetEarthImage()
        {
            earthImage.Load("https://api.nasa.gov/EPIC/archive/natural/2019/05/30/png/epic_1b_20190530011359.png?api_key=o8rmZSQMj8aiirEiRInZyrPdCsAPR2nwlFGnkUU9");
        }

        private HttpRequestMessage GetRequest(string url)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
            };

            return request;
        }
    }
}
