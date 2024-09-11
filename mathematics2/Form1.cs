using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.IO;
using System.Globalization;
using System.Collections.Generic;

namespace mathematics2
{
    public partial class MaximumLevelLabel : Form
    {
        public MaximumLevelLabel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string[] jsonFiles = Directory.GetFiles(currentDirectory, "heroes.json");

            if (jsonFiles.Length == 0)
            {
                File.WriteAllText(currentDirectory + "\\heroes.json", "[]");
            }

            FilePath.Text = currentDirectory + "\\heroes.json";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string[] jsonFiles = Directory.GetFiles(currentDirectory, "heroes.json");

            string filePath = jsonFiles[0];

            FilePath.Text = filePath;

            Hero currentHero = new Hero();

            currentHero.name = HeroName.Text;
            currentHero.mass = Double.Parse(HeroMass.Text);
            currentHero.eatableMass = Double.Parse(EatableMass.Text);
            currentHero.fuelType = FuelType.Text;

            HeroManager.SaveHeroToFile(currentHero, filePath);

            double summMass = 0;
            double minMass = 0;
            double maxMass = 0;
            double avgMass = 0;
            int count = 0;
            double criterion = 0;
            Hero bestOne = new Hero();
            
            List<Hero> heroes = HeroManager.LoadHeroesFromFile(filePath);

            foreach (var hero in heroes)
            {
                if (hero.mass > maxMass)
                {
                    maxMass = hero.mass;
                }
                if (hero.mass < minMass)
                {
                    minMass = hero.mass;
                }
                summMass += hero.mass;
                avgMass = summMass / ++count;
                if (criterion < hero.eatableMass / hero.mass)
                {
                    criterion = hero.eatableMass / hero.mass;
                    bestOne = hero;
                }
            }

            MinimumLevel.Text = minMass.ToString(); ;
            MaximumLevel.Text = maxMass.ToString();
            AverageLevel.Text = avgMass.ToString();
            FirstNumber.Text = bestOne.name;
        }
    }

    public class HeroManager
    {
        public static void SaveHeroToFile(Hero hero, string filePath)
        {
            List<Hero> heroesList = LoadHeroesFromFile(filePath);

            heroesList.Add(hero);

            string newJson = JsonSerializer.Serialize(heroesList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, newJson);
        }

        public static List<Hero> LoadHeroesFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new List<Hero>();
            }

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Hero>>(json);
        }
    }
        public class Hero
    {
        public string name;
        public double mass;
        public double eatableMass;
        public string fuelType;
    }
}
