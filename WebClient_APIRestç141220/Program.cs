using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using WebClient_APIRest141220;

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


            Console.Write("Choose a planet id, a number please ? : ");
            string id = Console.ReadLine();
            Console.WriteLine();

            string swapiAdressPlanet2 = $"https://swapi.dev/api/planets/{id}/";
            //client.BaseAddress = swapiAdressPlanet2;
            string response = client.DownloadString(swapiAdressPlanet2);
                        
                        
            Planet planet = JsonConvert.DeserializeObject<Planet>(response);
            //Warning : l'objet JSON a des champs qui sont des string ou string[] -> erreur

                      
            Console.WriteLine("Name : " + planet.Name);
            Console.WriteLine("Rotation_period : " + planet.Rotation_period);
            Console.WriteLine("Diameter : " + planet.Diameter);
            Console.WriteLine("Climate : " + planet.Climate);
            Console.WriteLine("Residents : " + planet.Residents[0]);
            Console.WriteLine("Films : " + planet.Films[0]);
            Console.WriteLine("Created : " + planet.Created);
            Console.WriteLine("Url : " + planet.Url);




        }
    }
}
