using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GOTapp
{
    public class CharactersManager
    {
        public ObservableCollection<CharacterClass> characterList { get; set; }

        string url = "https://raw.githubusercontent.com/jeffreylancaster/game-of-thrones/master/data/characters.json";
        HttpClient client = new HttpClient();


        public void downloadData()
        {
            // Get data from provided web service
            // parse json and deserialize it to ObservableCollection of CharacterClass
            // return Task<ObservableCollection<CharacterClass>> from this function
        }



    }
}
