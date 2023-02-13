using System;
using Newtonsoft.Json;
using System.Net;

namespace Deck_of_Cards_API_Lab.Models
{
	public class ShuffleDAL
	{
        public static ShuffleDeck GetHand()//adjust here
        {
            //Adjust here
            //Setup
            string url = "https://deckofcardsapi.com/api/deck/new/draw/?count=5";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Convert it to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //Adjust here
            //Convert to C#
            ShuffleDeck result = JsonConvert.DeserializeObject<ShuffleDeck>(JSON);
            return result;
        }
    }
}

