using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using NUnit.Framework;

namespace serialize_deserialize_netcore
{
    public class SampleTests
    {

        //Serialization is save a structure, object or data.
        //Target: memory, protocol, server
        //Object (Model) -> JsonObject
        //Function: JsonConvert.SerializeObject
        [Test]
        public void Serialize()
        {
            Movie movie = new Movie {Id= 1, Title = "Django Unchained"};
            string result = JsonConvert.SerializeObject(movie);

            Console.WriteLine("Object serialized: " + result);
        }


        //Deserialization reading back to set the properties, fields of the object
        //JsonObject -> Object (Model)
        //Function: JsonConvert.DeserializeObject
        [Test]
        public void Deserialize()
        {
            string json = File.ReadAllText(GeneralHelpers.GetProjectPath() + @"\Model\Movie.json");
            Movie movie = JsonConvert.DeserializeObject<Movie>(json);

            Console.WriteLine("Object deserialized:");
            Console.WriteLine("Id is: " + movie.Id);
            Console.WriteLine("Title is: " + movie.Title);
        }


        //Collection Serialization
        //Target: memory, protocol, server
        //Object (Model) as a List -> JsonObject
        //Function: JsonConvert.SerializeObject
        [Test]
        public void CollectionSerialize()
        {
            List<Movie> movie = new List<Movie>
            {
                new Movie {Id= 1, Title = "Django Unchained"},
                new Movie {Id= 2, Title = "Inglourious Basterds"},
                new Movie {Id= 3, Title = "American Sniper"},
                new Movie {Id= 4, Title = "Birdman"}    
            };
            string result = JsonConvert.SerializeObject(movie);

            Console.WriteLine("Object serialized: " + result);
        }


        //Collection Deserialization
        //JsonObject -> Object (Model) as a List
        //Function: JsonConvert.DeserializeObject
        [Test]
        public void CollectionDeserialize()
        {
           string json = File.ReadAllText(GeneralHelpers.GetProjectPath() + @"\Model\MovieCollection.json");
            List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(json);

            foreach(var movie in movies)
            {
                Console.WriteLine("Id is: " + movie.Id+ "\t Title is: " + movie.Title);
            }
        }



    }
}