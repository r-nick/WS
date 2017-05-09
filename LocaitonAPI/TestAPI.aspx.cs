using System;
using premium.localweather;
using premium.locationsearch;

public partial class TestPremiumAPI : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    } 

    protected void btnLocationSearchPremium_Click(object sender, EventArgs e)
    {
        // set input parameters for the API
        LocationSearchInput input = new LocationSearchInput();
        input.query = txtLocation.Text;
        input.num_of_results = "2";
        input.format = "JSON";

        if (!string.IsNullOrEmpty(input.query))
        {
            // call the location Search method with input parameters
            PremiumAPI api = new PremiumAPI();
            LocationSearch locationSearch = api.SearchLocation(input);

            // printing a few values to show how to get the output
            if (locationSearch.search_API != null && locationSearch.search_API.result != null)
            {
                txtOutput.Text = "";
                for (int i = 0; i < locationSearch.search_API.result.Count; i++)
                {
                    txtOutput.Text += "\r\n Area Name: " + locationSearch.search_API.result[i].areaName[0].value;
                    txtOutput.Text += "\r\n Country: " + locationSearch.search_API.result[i].country[0].value;
                    txtOutput.Text += "\r\n Latitude: " + locationSearch.search_API.result[i].latitude;
                    txtOutput.Text += "\r\n Longitude: " + locationSearch.search_API.result[i].longitude;
                    txtOutput.Text += "\r\n Population: " + locationSearch.search_API.result[i].population;
                    txtOutput.Text += "\r\n Region: " + locationSearch.search_API.result[i].region[0].value;
                    txtOutput.Text += "\r\n --------------------------";
                }
            }
            else
            {
                txtOutput.Text = "\r\n Something went wrong. Please make sure you entered city name!";
            }
        }
        else
        {
            txtOutput.Text = "\r\n Please enter location.";
        }
    }
}