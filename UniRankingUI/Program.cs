using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniRanking.Data;

namespace UniRankingUI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            using (var c = new Context())
            {
                
                foreach (var entity in c.Countries)
                {
                    c.Countries.Remove(entity);
                }
                
                foreach (var entity in c.Univesities)
                {
                    c.Univesities.Remove(entity);
                   
                }
                
                foreach (var entity in c.Ratings)
                {
                    c.Ratings.Remove(entity);
                    
                }
                c.SaveChanges();
                
                /*
                using (StreamReader rank2012 = new StreamReader("../../../2012Ranking.csv"))
                {
                    string LineWithEverithing;
                    while ((LineWithEverithing = rank2012.ReadLine()) != null)
                    {
                        var ArrayWithLines = LineWithEverithing.Split(';');
                        /*
                        for (int i=0;i<ArrayWithLines.Count(); i++)
                        {
                            Console.WriteLine(ArrayWithLines[i]);
                        }
                        
                        
                        Country CurrentCountry = new Country { CountryOfUni = ArrayWithLines[2] };
                        c.Countries.AddOrUpdate(cou => cou.CountryOfUni, CurrentCountry);
                        c.SaveChanges();
                        UniversitysInfo Univer = new UniversitysInfo { NameOfUniversity = ArrayWithLines[1], CountryOfUniversity = c.Countries.Single(country => country.CountryOfUni == CurrentCountry.CountryOfUni) };
                        c.Univesities.AddOrUpdate(u => u.NameOfUniversity, Univer);
                        c.SaveChanges();
                        Console.WriteLine(ArrayWithLines.Count().ToString());
                        RatingData rating = new RatingData
                        {

                            WorldRank = int.Parse(ArrayWithLines[0]),
                            Universiry = Univer,
                            NationalRank = int.Parse(ArrayWithLines[3]),
                            QualityOfEducation = int.Parse(ArrayWithLines[4]),
                            AlumniEmployment = int.Parse(ArrayWithLines[5]),
                            QualityOfFaculty = int.Parse(ArrayWithLines[6]),
                            Publications = int.Parse(ArrayWithLines[7]),
                            Influence = int.Parse(ArrayWithLines[8]),
                            Citations = int.Parse(ArrayWithLines[9]),
                            Patents = int.Parse(ArrayWithLines[10]),
                            Score = Convert.ToDouble(ArrayWithLines[11]),
                            Year = int.Parse(ArrayWithLines[12]),
                            BroadImpact = int.Parse(ArrayWithLines[13]),
                            MyID=int.Parse(ArrayWithLines[14])
                        };
                        c.Ratings.AddOrUpdate(r=>r.MyID,rating);
                        c.SaveChanges();
                    }
                    
                    
                }
                */
    
            }
        }
    }
}
