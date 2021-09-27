using System;
using System.Windows.Forms;
using CSharpWinFormsSQLCourse.Models;
using CSharpWinFormsSQLCourse.Integration.Spotify;

namespace CSharpWinFormsSQLCourse.integration
{
    public partial class SpotifyDataGrabber : Form
    {
        public SpotifyDataGrabber()
        {
            InitializeComponent();
        }

        private void SpotifyDataGrabber_Load(object sender, EventArgs e)
        {
            // Call the PopulateDataTable method with a new DanceabilityData object.
            PopulateDataTable(new DanceabilityData());
        }

        private async void PopulateDataTable(DanceabilityData table)
        {
            /// Get the required values from the Spotify API.
            // Get a new access token using OAuth 2.0.
            Spotify.GetAccessToken().Start();

            // Make a call to the Spotify API to get the most danceable songs.
            table.Album = "hello";

            // Make a call to the Spotify API to get the name, artist, and album of the songs.

        }
    }
}