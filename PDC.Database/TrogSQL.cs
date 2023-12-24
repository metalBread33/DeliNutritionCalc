using System.Collections.Generic;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PDC.Database
{
    /*The purpose of this class is to act as a database that stores the nutional info
     of all items. Microsoft sql is busted on my computer and I cannot uninstall it. This
    will essentially be troglodyte sql*/
    public class TrogSQLEntry
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public float Calories { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
        public float Protein { get; set; }
        public float SaturatedFat { get; set; }
        public float TransFat { get; set; }
        public float Sodium { get; set; }
        public float Cholesterol { get; set; }
        
        public TrogSQLEntry(int id, string name, float calories, float carbs, float fat,
            float protein, float sat, float trans, float sod, float cholesterol)
        {
            Id = id;
            Name = name;
            Calories = calories;
            Carbs = carbs;
            Fat = fat;
            Protein = protein;
            SaturatedFat = sat;
            TransFat = trans;
            Sodium = sod;
            Cholesterol = cholesterol;
        }

        public override string ToString()
        {
            return $"{Id}) {Name}";
        }
    }

    public class TrogSQL
    {
        private static TrogSQL? _instance;
        public static TrogSQL current
        {
            get
            {
                if (_instance == null)
                    _instance = new TrogSQL();
                return _instance;
            }
        }
        private static string root = "C:\\Users\\kfoug\\Desktop\\Deli Calc\\PDC.Database\\Data";
        public List<TrogSQLEntry>? getFromFile(string filename)
        {
            if (filename == null)
            {
                Console.WriteLine("File does not exist");
                return null;
            }
            List<TrogSQLEntry> list = new List<TrogSQLEntry>();
            foreach (string line in File.ReadLines($"{root}{filename}"))
            {
                string[] info = line.Split(',');
                
                if (info[0] == "ID") //skips the first line with titles
                    continue;
                list.Add(new TrogSQLEntry(
                    int.Parse(info[0]), info[1], float.Parse(info[2]), float.Parse(info[3]),
                    float.Parse(info[4]), float.Parse(info[5]), float.Parse(info[6]),
                    float.Parse(info[7]), float.Parse(info[8]), float.Parse(info[9]))
                    );
            }
            return list;
        }
    }
}