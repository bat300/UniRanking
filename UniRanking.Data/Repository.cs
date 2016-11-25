using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniRanking.Data
{
    class UniScores
    {
        public string NameOfUni { get; set; }
        public double MinScore { get; set; }
        public double MaxScore { get; set; }
        public double AverageScore { get; set; }
    }
    public class Repository
    {
        
        Context cont = new Context();
        public List<string> GetRatingByYear(int Year)
        {
            List<string> Rating = new List<string>();
            if ((Year == 2012) || (Year == 2013))
            {
                Rating.Add(string.Format("{0,-70}\t{1,15}\t{2,15}\t{3,15}\t{4,15}\t{5,15}\t{6,15}\t{7,15}\t{8,15}\t{9,15}"
                        , "Institution", "Location", "WorldRank", "NationalRank",
                        "QualityOfEducation", "Publications", "Influence", "Citations", "Patents", "Score"));
                var RatingByYear = from rating in cont.Ratings
                                   where rating.Year == Year
                                   select new
                                   {
                                       Institition = rating.Universiry.NameOfUniversity,
                                       Location = rating.Universiry.CountryOfUniversity.CountryOfUni,
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
                    string r = string.Format("{0,-70}\t{1,-15}\t{2,-15}\t{3,-15}\t{4,-15}\t{5,-15}\t{6,-15}\t{7,-15}\t{8,-15}\t{9,-15}"
                        , item.Institition,item.Location,item.WorldRank,item.NationalRank,
                        item.QualityOfEducation,item.Publications,item.Influence,item.Citations,item.Patents,item.Score);
                    Rating.Add(r);
                }
            }
            else
            {
                Rating.Add(string.Format("{0,-70}\t{1,15}\t{2,15}\t{3,15}\t{4,15}\t{5,15}\t{6,15}\t{7,15}\t{8,15}\t{9,15}\t{10,15}"
                        , "Institution", "Location", "WorldRank", "NationalRank",
                        "QualityOfEducation", "Publications", "Influence", "Citations", "Patents","BroadImpact", "Score"));
                var RatingByYear = from rating in cont.Ratings
                                   where rating.Year == Year
                                   select new
                                   {
                                       Institition = rating.Universiry.NameOfUniversity,
                                       Location = rating.Universiry.CountryOfUniversity.CountryOfUni,
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
                    string r = string.Format("{0,-70}\t{1,-15}\t{2,-15}\t{3,-15}\t{4,-15}\t{5,-15}\t{6,-15}\t{7,-15}\t{8,-15}\t{9,-15}\t{10,-15}"
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
                Rating.Add(string.Format("{0,-70}\t{1,15}\t{2,15}\t{3,15}\t{4,15}\t{5,15}\t{6,15}\t{7,15}\t{8,15}\t{9,15}"
                        , "Institution", "Location", "WorldRank", "NationalRank",
                        "QualityOfEducation", "Publications", "Influence", "Citations", "Patents", "Score"));
                var RatingByYear = cont.Ratings
                 .Where(r => r.Year == Year)
                 .Select(rat => new
                 {
                     Institition = rat.Universiry.NameOfUniversity,
                     Location = rat.Universiry.CountryOfUniversity.CountryOfUni,
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
                 .GroupBy(rat => rat.Location);
                foreach (var group in RatingByYear)
                {
                    var OrderedRating = group
                            .OrderByDescending(r => r.Score);
                    foreach(var item in OrderedRating)
                    {
                        string r = string.Format("{0,-70}\t{1,-15}\t{2,-15}\t{3,-15}\t{4,-15}\t{5,-15}\t{6,-15}\t{7,-15}\t{8,-15}\t{9,-15}"
                        , item.Institition, item.Location,
                        item.WorldRank, item.NationalRank, item.QualityOfEducation, item.Publications, 
                        item.Influence, item.Citations, item.Patents, item.Score);
                        Rating.Add(r);
                    }
                }
            }
            else
            {
                Rating.Add(string.Format("{0,-70}\t{1,15}\t{2,15}\t{3,15}\t{4,15}\t{5,15}\t{6,15}\t{7,15}\t{8,15}\t{9,15}\t{10,15}"
                        , "Institution", "Location", "WorldRank", "NationalRank",
                        "QualityOfEducation", "Publications", "Influence", "Citations", "Patents","BroadImpact", "Score"));
                var RatingByYear = cont.Ratings
                                 .Where(r => r.Year == Year)
                                 .Select(rat => new
                                 {
                                     Institition = rat.Universiry.NameOfUniversity,
                                     Location = rat.Universiry.CountryOfUniversity.CountryOfUni,
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
                foreach(var group in RatingByYear )
                {
                    var OrderedRating = group
                            .OrderByDescending(r => r.Score);
                    foreach (var item in OrderedRating)
                    {
                        string r = string.Format("{0,-70}\t{1,-15}\t{2,-15}\t{3,-15}\t{4,-15}\t{5,-15}\t{6,-15}\t{7,-15}\t{8,-15}\t{9,-15}\t{10,-15}"
                        , item.Institition, item.Location, item.WorldRank, item.NationalRank,
                        item.QualityOfEducation, item.Publications, item.Influence, item.Citations,
                        item.Patents, item.BroadImpact, item.Score);
                        Rating.Add(r);
                    }
                }
            }
            return Rating;
        }
        



        public List<string> DinamicOfUni(string NameOfUni)
        {
            List<string> DinamicOfUni = new List<string>();
            DinamicOfUni.Add(string.Format("{0,-15}\t{1,-15}\t{2,-15}\t{3,-15}\t{4,-15}\t{5,-15}\t{6,-15}\t{7,-15}\t{8,-15}\t{9,-15}"
                        , "Year", "WorldRank", "NationalRank",
                        "QualityOfEducation", "Publications", "Influence", "Citations", "Patents", "BroadImpact", "Score"));
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
                string d = string.Format("{0,-15}\t{1,-15}\t{2,-15}\t{3,-15}\t{4,-15}\t{5,-15}\t{6,-15}\t{7,-15}\t{8,-15}\t{9,-15}"
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
            List<UniScores> UniversitiesScores = new List<UniScores>();
            Rating.Add(string.Format("{0,-90}\t{1,15}\t{2,15}\t{3,15}","Institution","MinScore","MaxScore","AverageScore"));
            var GroupsOfUnis = cont.Ratings
                             .GroupBy(r => r.Universiry.NameOfUniversity);
            foreach(var gr in GroupsOfUnis)
            {
                double minimum = gr
                            .Select(g => g.Score)
                            .Min();
                double maximum = gr
                                .Select(g => g.Score)
                                .Max();
                double average = gr
                                .Select(g => g.Score)
                                .Average();
                UniversitiesScores.Add(new UniScores
                { NameOfUni=gr.Key, MinScore = minimum,
                    MaxScore = maximum, AverageScore = average });
            }
            var OrderedByAvgScoreRatingOfUni = UniversitiesScores
                                            .OrderByDescending(u => u.AverageScore);
             foreach(var item in OrderedByAvgScoreRatingOfUni)
            {
                Rating.Add(string.Format("{0,-90}\t{1,-15}\t{2,-15}\t{3,-15}", item.NameOfUni,
                    item.MinScore,item.MaxScore,item.AverageScore));
            }
            return Rating;
        }
        
    }
}
