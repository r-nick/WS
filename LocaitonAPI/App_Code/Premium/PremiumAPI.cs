using System.Configuration;
using System.Web.Script.Serialization;
using premium.localweather;
using premium.locationsearch;

public class PremiumAPI
{
    public string ApiBaseURL = ConfigurationManager.AppSettings["PremiumApiBaseURL"];
    public string PremiumAPIKey = ConfigurationManager.AppSettings["PremiumAPIKey"];

   
    public LocationSearch SearchLocation(LocationSearchInput input)
    {
        // create URL based on input paramters
        string apiURL = ApiBaseURL + "search.ashx?q=" + input.query + "&format=" + input.format + "&timezone=" + input.timezone + "&popular=" + input.popular + "&num_of_results=" + input.num_of_results + "&callback=" + input.callback + "&key=" + PremiumAPIKey;

        // get the web response
        string result = RequestHandler.Process(apiURL);

        // serialize the json output and parse in the helper class
        LocationSearch locationSearch = (LocationSearch)new JavaScriptSerializer().Deserialize(result, typeof(LocationSearch));

        return locationSearch;
    }
}