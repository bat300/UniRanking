using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniRanking.Data
{
    public class Repository
    {
        
        Context cont = new Context();
        public List<string> GetRatingByYear(int Year)
        {
            List<string> Rating = new List<string>();
            if ((Year == 2012) || (Year == 2013))
            {
                var RatingByYear = from rating in cont.Ratings
                                       /*
                                       join u in cont.Univesities
                                       on rating.Universiry equals u
                                       join c in cont.Countries
                                       on u.CountryOfUniversity equals c
                                       where rating.Year == Year
                                       select new
                                       {
                                           Institition = u.NameOfUniversity,
                                           Location = c.CountryOfUni,
                                           WorldRank = rating.WorldRank,
                                           NationalRank = rating.NationalRank,
                                           QualityOfEducation = rating.QualityOfEducation,
                                           Publications = rating.Publications,
                                           Influence = rating.Influence,
                                           Citations = rating.Citations,
                                           Patents = rating.Patents,
                                           Score = rating.Score
                                       };
                                       */
                                   where rating.Year == Year
                                   select new
                                   {
                                       Institition = rating.Universiry.NameOfUniversity,
                                       Location = rating.Universiry.CountryOfUniversity,
                                       WorldRank = rating.WorldRank,
                                       NationalRank = rating.NationalRank,
                                       QualityOfEducation = rating.QualityOfEducation,
                                       Publications = rating.Publications,
                                       Influence = rating.Influence,
                                       Citations = rating.Citations,
                                       Patents = rating.Patents,
                                       Score = rating.Score
                                   };
                foreach (var item in RatingByYear)
                {
                    string r = string.Format("{0,-15} {1,-10} {2,-4} {3,-4} {4,-4} {5,-4} {6,-4} {7,-4} {8,-4} {9,-6}"
                        ,item.Institition,item.Location,item.WorldRank,item.NationalRank,
                        item.QualityOfEducation,item.Publications,item.Influence,item.Citations,item.Patents,item.Score);
                    Rating.Add(r);
                }
            }
            else
            {
                var RatingByYear = from rating in cont.Ratings
                                       /*
                                       join u in cont.Univesities
                                       on rating.Universiry equals u
                                       join c in cont.Countries
                                       on u.CountryOfUniversity equals c
                                       where rating.Year == Year
                                       select new
                                       {
                                           Institition = u.NameOfUniversity,
                                           Location = c.CountryOfUni,
                                           WorldRank = rating.WorldRank,
                                           NationalRank = rating.NationalRank,
                                           QualityOfEducation = rating.QualityOfEducation,
                                           Publications = rating.Publications,
                                           Influence = rating.Influence,
                                           Citations = rating.Citations,
                                           Patents = rating.Patents,
                                           BroadImpact = rating.BroadImpact,
                                           Score = rating.Score
                                       };
                                       */
                                   where rating.Year == Year
                                   select new
                                   {
                                       Institition = rating.Universiry.NameOfUniversity,
                                       Location = rating.Universiry.CountryOfUniversity,
                                       WorldRank = rating.WorldRank,
                                       NationalRank = rating.NationalRank,
                                       QualityOfEducation = rating.QualityOfEducation,
                                       Publications = rating.Publications,
                                       Influence = rating.Influence,
                                       Citations = rating.Citations,
                                       Patents = rating.Patents,
                                       BroadImpact = rating.BroadImpact,
                                       Score = rating.Score
                                   };
                foreach (var item in RatingByYear)
                {
                    string r = string.Format("{0,-15} {1,-10} {2,-4} {3,-4} {4,-4} {5,-4} {6,-4} {7,-4} {8,-4} {9,-4} {10,-6}"
                        , item.Institition, item.Location, item.WorldRank, item.NationalRank,
                        item.QualityOfEducation, item.Publications, item.Influence, item.Citations,
                        item.Patents,item.BroadImpact, item.Score);
                    Rating.Add(r);
                }
            }
            return Rating;
        }
        
        public List<string> RatingByYearSortedByCountry(int Year)
        {
            List<string> Rating = new List<string>();
            if ((Year == 2012) || (Year == 2013))
            {

                var RatingByYear = from rating in cont.Ratings
                                   where rating.Year == Year
                                   orderby rating.Score descending
                                   group rating by rating.Universiry.NameOfUniversity into DataAboutRating
                                   select DataAboutRating;
                foreach (var item in RatingByYear)
                {
                    string r = string.Format("{0,-15} {1,-10} {2,-4} {3,-4} {4,-4} {5,-4} {6,-4} {7,-4} {8,-4} {9,-6}"
                        , item., item.Location, item.WorldRank, item.NationalRank,
                        item.QualityOfEducation, item.Publications, item.Influence, item.Citations, item.Patents, item.Score);
                    Rating.Add(r);
                }
            }
            else
            {
                var RatingByYear = cont.Ratings
                                 .Where(r => r.Year == Year)
                                 .OrderByDescending(r => r.Score)
                                 .Select(rat => new
                                 {
                                     Institition = rat.Universiry.NameOfUniversity,
                                     Location = rat.Universiry.CountryOfUniversity,
                                     WorldRank = rat.WorldRank,
                                     NationalRank = rat.NationalRank,
                                     QualityOfEducation = rat.QualityOfEducation,
                                     Publications = rat.Publications,
                                     Influence = rat.Influence,
                                     Citations = rat.Citations,
                                     Patents = rat.Patents,
                                     BroadImpact = rat.BroadImpact,
                                     Score = rat.Score
                                 })
                                 .GroupBy(rat=>rat.Location);
                foreach (var item in RatingByYear)
                {
                    string r = string.Format("{0,-15} {1,-10} {2,-4} {3,-4} {4,-4} {5,-4} {6,-4} {7,-4} {8,-4} {9,-4} {10,-6}"
                        , item.Institition, item.Location, item.WorldRank, item.NationalRank,
                        item.QualityOfEducation, item.Publications, item.Influence, item.Citations,
                        item.Patents, item.BroadImpact, item.Score);
                    Rating.Add(r);
                }
            }
            return Rating;
        }
        public List<string> DinamicOfUni(string NameOfUni)
        {
            List<string> DinamicOfUni = new List<string>();
            var Dinamic=from rat in cont.Ratings
                        where rat.Universiry.NameOfUniversity==NameOfUni
                        orderby rat.Year
                        select new
                        {
                            Year=rat.Year,
                            Institition = rat.Universiry.NameOfUniversity,
                            Location = rat.Universiry.CountryOfUniversity,
                            WorldRank = rat.WorldRank,
                            NationalRank = rat.NationalRank,
                            QualityOfEducation = rat.QualityOfEducation,
                            Publications = rat.Publications,
                            Influence = rat.Influence,
                            Citations = rat.Citations,
                            Patents = rat.Patents,
                            BroadImpact = rat.BroadImpact,
                            Score = rat.Score
                        };
            foreach (var item in Dinamic)
            {
                string d = string.Format("{0,-5} {1,-4} {2,-4} {3,-4} {4,-4} {5,-4} {6,-4} {7,-4} {8,-4} {9,-6}"
                        , item.Year, item.WorldRank, item.NationalRank,
                        item.QualityOfEducation, item.Publications, item.Influence, item.Citations,
                        item.Patents, item.BroadImpact, item.Score);
                DinamicOfUni.Add(d);
            }
            return DinamicOfUni;
        }
        public List<string> ScorsAboutUnis()
        {
            List<string> Rating = new List<string>();
            return Rating;
        }
        
    }
}
