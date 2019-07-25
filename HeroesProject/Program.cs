using System;

namespace HeroesProject {
    class Program {
        static void Main(string[] args) {
            Hero tryn = new Hero();
            tryn.HeroName = "Tryndamere";
            tryn.SetPosition("Top");
            tryn.Type = "Bruiser";
            tryn.SetDefaultAD(88);
            tryn.SetStartingHealth(750);

            Hero leblanc = new Hero();
            leblanc.HeroName = "LeBlanc";
            leblanc.Type = "Mage";
            leblanc.SetPosition("Mid");
            leblanc.SetDefaultAD(60);
            leblanc.SetStartingHealth(575);

            Hero lee = new Hero();
            lee.HeroName = "Lee Sin";
            lee.Type = "Assassin";
            lee.SetPosition("Jungle");
            lee.SetDefaultAD(80);
            lee.SetStartingHealth(660);

            Hero vayne = new Hero();
            vayne.HeroName = "Vayne";
            vayne.Type = "Marksman";
            vayne.SetPosition("Bot");
            vayne.SetDefaultAD(82);
            vayne.SetStartingHealth(550);

            Hero janna = new Hero();
            janna.HeroName = "Janna";
            janna.Type = "Support";
            janna.SetPosition("Bot");
            janna.SetPosition("Bobott");
            janna.SetDefaultAD(20);
            janna.SetDefaultAD(50);
            janna.SetStartingHealth(200);
            janna.SetStartingHealth(450);

            Console.WriteLine($"HeroName: {janna.HeroName}");
            Console.WriteLine($"Class: {janna.Type}");
            Console.WriteLine($"Position {janna.Position}");
            Console.WriteLine($"Starting Health: {janna.StartingHealth}");
            Console.WriteLine($"Starting Attack Damage: {janna.DefaultAD}");

        }
    }
    class Hero {
        public string HeroName { get; set; }
        public string Type { get; set; }
        public string Position { get; private set; }
        public int StartingHealth { get; private set; }
        public int DefaultAD { get; private set; }
        public void SetStartingHealth(int health) {
            if (health >= 300 && health <= 800) {
                this.StartingHealth = health;
            } else {
                Console.WriteLine("Health must be between 300 and 800");  
            }
        }
        public void SetDefaultAD(int AD) {
            if (AD >= 40 && AD <= 100) {
                this.DefaultAD = AD;
            }
            else {
                Console.WriteLine("Starting AD Must be between 40 and 100");
            }
        }
        public void SetPosition(string place) {
            if ((place == "Top") || (place == "Mid") || (place == "Bot") || (place == "Jungle")) {
                this.Position = place;
            }
            
            else {
                Console.WriteLine("Position must be declared Top, Mid, Bot, or Jungle");
            }
        }
    }
        
}
