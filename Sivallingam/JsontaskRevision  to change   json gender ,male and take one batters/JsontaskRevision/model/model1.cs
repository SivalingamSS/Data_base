namespace JsontaskRevision.model
{
     // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
        public class Batter
        {
            public int id { get; set; }
            public string? type { get; set; }
        }

        public class Batters
        {
            public List<Batter> batter { get; set; }
        }

        public class Root
        {
            public int id { get; set; }
            public string type { get; set; }
            public string name { get; set; }
            public double ppu { get; set; }
            public Batters batters { get; set; }
           public List<Topping> topping { get; set; }
        }

        public class Topping
        {
            public int id { get; set; }
            public string type { get; set; }
        }



    }


