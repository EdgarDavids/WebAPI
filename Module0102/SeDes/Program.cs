using System;
using Newtonsoft.Json;

namespace SeDes
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serialization rockets");
            string json=DoSerialization();
            Console.WriteLine(json);
            Console.WriteLine("DeSerialization rockets");
            DoDeserialization(json);
            Console.ReadLine();
        }

        public static string DoSerialization(){
            Rocket[] rockets={
                new Rocket{ID=0, Builder="NASA", Target="Moon", Speed=7.8},
                new Rocket{ID=1, Builder="NASA", Target="Mars", Speed=10.9},
                new Rocket{ID=2, Builder="NASA", Target="Kepler-452b", Speed=42.1},
                new Rocket{ID=3, Builder="NASA", Target="N/A", Speed=0}
            };

            string json=JsonConvert.SerializeObject(rockets);
            return json;
        }

        public static void DoDeserialization(string json){
            Rocket[] rockets=Newtonsoft.Json.JsonConvert.DeserializeObject<Rocket[]>(json);

            foreach(Rocket rocket in rockets) Console.WriteLine("ID = {0} - Builder = {1} - Target = {2} - Speed = {3}", 
                            rocket.ID, 
                            rocket.Builder, 
                            rocket.Target, 
                            rocket.Speed);
        }
    }
}
