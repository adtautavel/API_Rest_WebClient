using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace WebClient_APIRestç141220
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            //L'API suivante permet de récupérer des informations sur la saga Star Wars: https://swapi.dev/.
            // Une application console qui récupère des informations sur une planète identifiée par son identifiant numérique (exemple https://swapi.dev/api/planets/1)


          /*  string response = client.DownloadString(" https://swapi.dev/api/planets/2/");
            Console.WriteLine(response);*/

            
                        string swapiAdressPlanet2 = "https://swapi.dev/api/planets/2/";
                        //client.BaseAddress = swapiAdressPlanet2;
                        string response = client.DownloadString(swapiAdressPlanet2);
                        
                        
                        Dictionary < string, string> dicoSwapiPlanet = JsonConvert.DeserializeObject<Dictionary<string, string>>(response);
                        //Warning : l'objet JSON a des champs qui sont des string ou string[] -> erreur

                        foreach (string field in dicoSwapiPlanet.Keys)
                        {
                            Console.WriteLine("Field : " + field);
                            Console.WriteLine("Value : " + dicoSwapiPlanet[field]);
                            Console.WriteLine();
                        }
                        Console.WriteLine(response);

        }
    }
}
