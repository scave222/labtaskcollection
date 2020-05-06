using System;
using System.Collections;

namespace SoftwareEducationalService
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] col =new string[15,5] {{"Chromatography", "Soji", "Chemistry", "4", "Primary"},
                            {"Lemon Volcano", "Samuel", "Physics", "2", "Higher"},
                            {"DIY Bouncy Balls", "Ifeanyi", "Integrated Science", "1", "Labs"},
                            {"Shiny Pennies", "Abayomi", "Chemistry", "1", "Higher"},
                            {"Regrow Vegetable Scraps", "Gozie", "Agric", "3", "Primary"},
                            {"DIY Stethoscope", "Buhary", "Physics", "2", "Labs"},
                            {"Simple Circuit", "Bankole", "Physics", "2", "Primary"},
                            {"Exploring Density with Salt", "Fatai", "Geography", "4", "Higher"},
                            {"Rainbow Rubber Eggs", "Michael", "Maths", "3", "Labs"},
                            {"Magic Rollback Can", "Tolu", "Futher Maths", "1", "Primary"},
                            {"Bleeding Blossoms", "Grace", "Biology", "5", "Labs"},
                            {"Teleidoscopes", "Faith", "Integrated Science", "3", "Higher"},
                            {"Density Tower", "May", "Physics", "5", "Primary"},
                            {"Magnet Magic", "John", "Chemistry", "4", "Labs"},
                            {"Overnight Crystals", "Caleb", "Geography", "5", "Higher"}};

            ArrayList list = new ArrayList(15);

            for (int i = 0; i < 15; i++)
            {
                
                   list.Add($"{col[i,0]},{col[i,1]},{col[i,2]},{col[i,3]},{col[i,4]}"); 

            }
            list.RemoveAt(3);
             foreach(var item in list)
            {
                //list.Add(item);
                Console.WriteLine($"{item}");
            }
            Console.WriteLine($"{list.Count}");
            Hashtable col1 = new Hashtable();
            col1.Add(60, "58 2000");
            col1.Add(70, "67 2001");
            col1.Add(50, "45 2000");
            col1.Add(90, "85 2001");
            col1.Add(80, "76 2000");
            col1.Add(69, "64 2001");
            col1.Add(78, "69 2000");
            col1.Add(53, "46 2001");
            col1.Add(66, "60 2000");
            col1.Add(93, "87 2001");
            col1.Add(59, "57 2000");
            col1.Add(72, "68 2001");
            col1.Add(87, "83 2000");
            col1.Add(47, "55 2001");
            col1.Add(57, "56 2000");
             ICollection objCollection = col1.Keys;

            // for(var i = 0; i < col1.Count; i++)
            // {
            //     foreach(var item in objCollection){
            //         if( > 70)
            //     }
            // }

        //    list.RemoveAt(3);
        //     foreach(var item in list)
        //     {
        //         //list.Add(item);
        //         Console.WriteLine($"{item}");
        //     }
           
        //     Console.WriteLine($"{list.Count}");
        }
    }
}
