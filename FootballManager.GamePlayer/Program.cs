using FootballManager.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace FootballManager.GamePlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            //HttpClient httpClient = new HttpClient();
            //HttpResponseMessage response = httpClient.GetAsync("https://localhost:44363/api/team/1").Result;
            //Console.WriteLine((int)response.StatusCode);
            //if (response.IsSuccessStatusCode)
            //{
            //    Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            //    string colts = response.Content.ReadAsStringAsync().Result;
            //    string jsonFormatted = JValue.Parse(colts).ToString(Formatting.Indented);
            //    Console.WriteLine(jsonFormatted);
            //    Team teamResponse = response.Content.ReadAsAsync<Team>().Result;
            //    Console.WriteLine($"{teamResponse.TeamName} is a circus");
            //    //    //foreach (string teamURL in teamResponse.TeamName)
            //    {
            //        Console.WriteLine(teamURL);
            //        HttpResponseMessage teamResponse1 = httpClient.GetAsync(teamURL).Result;
            //        Console.WriteLine(teamResponse1.Content.ReadAsStringAsync().Result);
            //        Team team = teamResponse1.Content.ReadAsAsync<Team>().Result;
            //        Console.WriteLine($"{team.TeamID} was directed by {team.TeamName}");
            //    }
            //}
            ProgramUI game = new ProgramUI();
            game.Run();
            //}
        }
    }
}