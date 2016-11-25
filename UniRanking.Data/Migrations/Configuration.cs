namespace UniRanking.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.IO;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<UniRanking.Data.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UniRanking.Data.Context context)
        {
            /*
            foreach (var entity in context.Countries)
            {
                context.Countries.Remove(entity);
            }

            foreach (var entity in context.Univesities)
            {
                context.Univesities.Remove(entity);

            }

            foreach (var entity in context.Ratings)
            {
                context.Ratings.Remove(entity);

            }
            context.SaveChanges();
            */
            using (StreamReader rank2012 = new StreamReader("2012Ranking.csv"))
            {
                string LineWithEverithing;
                while ((LineWithEverithing = rank2012.ReadLine()) != null)
                {
                    var ArrayWithLines = LineWithEverithing.Split(';');
                    Country CurrentCountry = new Country { CountryOfUni = ArrayWithLines[2] };
                    context.Countries.AddOrUpdate(cou => cou.CountryOfUni, CurrentCountry);
                    context.SaveChanges();
                    UniversitysInfo Univer = new UniversitysInfo
                    {
                        NameOfUniversity = ArrayWithLines[1],
                        CountryOfUniversity = context.Countries.Single(country => country.CountryOfUni == CurrentCountry.CountryOfUni)
                    };
                    context.Univesities.AddOrUpdate(u => u.NameOfUniversity, Univer);
                    context.SaveChanges();
                    Console.WriteLine(ArrayWithLines.Count().ToString());
                    RatingData rating = new RatingData
                    {

                        WorldRank = int.Parse(ArrayWithLines[0]),
                        Universiry = context.Univesities.Single(uni => uni.NameOfUniversity == Univer.NameOfUniversity),
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
                        MyID = int.Parse(ArrayWithLines[14])
                    };
                    context.Ratings.AddOrUpdate(r => r.MyID, rating);
                    context.SaveChanges();
                }
                rank2012.Close();
            }
            using (StreamReader rank2013 = new StreamReader("2013Ranking.csv"))
            {
                string LineWithEverithing;
                while ((LineWithEverithing = rank2013.ReadLine()) != null)
                {
                    var ArrayWithLines = LineWithEverithing.Split(';');
                    Country CurrentCountry = new Country { CountryOfUni = ArrayWithLines[2] };
                    context.Countries.AddOrUpdate(cou => cou.CountryOfUni, CurrentCountry);
                    context.SaveChanges();
                    UniversitysInfo Univer = new UniversitysInfo
                    {
                        NameOfUniversity = ArrayWithLines[1],
                        CountryOfUniversity = context.Countries.Single(country => country.CountryOfUni == CurrentCountry.CountryOfUni)
                    };
                    context.Univesities.AddOrUpdate(u => u.NameOfUniversity, Univer);
                    context.SaveChanges();
                    Console.WriteLine(ArrayWithLines.Count().ToString());
                    RatingData rating = new RatingData
                    {

                        WorldRank = int.Parse(ArrayWithLines[0]),
                        Universiry = context.Univesities.Single(uni => uni.NameOfUniversity == Univer.NameOfUniversity),
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
                        MyID = int.Parse(ArrayWithLines[14])
                    };
                    context.Ratings.AddOrUpdate(r => r.MyID, rating);
                    context.SaveChanges();
                }
                rank2013.Close();
            }
            using (StreamReader rank2014 = new StreamReader("2014Ranking.csv"))
            {
                string LineWithEverithing;
                while ((LineWithEverithing = rank2014.ReadLine()) != null)
                {
                    var ArrayWithLines = LineWithEverithing.Split(';');
                    Country CurrentCountry = new Country { CountryOfUni = ArrayWithLines[2] };
                    context.Countries.AddOrUpdate(cou => cou.CountryOfUni, CurrentCountry);
                    context.SaveChanges();
                    UniversitysInfo Univer = new UniversitysInfo
                    {
                        NameOfUniversity = ArrayWithLines[1],
                        CountryOfUniversity = context.Countries.Single(country => country.CountryOfUni == CurrentCountry.CountryOfUni)
                    };
                    context.Univesities.AddOrUpdate(u => u.NameOfUniversity, Univer);
                    context.SaveChanges();
                    Console.WriteLine(ArrayWithLines.Count().ToString());
                    RatingData rating = new RatingData
                    {

                        WorldRank = int.Parse(ArrayWithLines[0]),
                        Universiry = context.Univesities.Single(uni => uni.NameOfUniversity == Univer.NameOfUniversity),
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
                        MyID = int.Parse(ArrayWithLines[14])
                    };
                    context.Ratings.AddOrUpdate(r => r.MyID, rating);
                    context.SaveChanges();
                }
                rank2014.Close();
            }
            using (StreamReader rank2015 = new StreamReader("2015Ranking.csv"))
            {
                string LineWithEverithing;
                while ((LineWithEverithing = rank2015.ReadLine()) != null)
                {
                    var ArrayWithLines = LineWithEverithing.Split(';');
                    Country CurrentCountry = new Country { CountryOfUni = ArrayWithLines[2] };
                    context.Countries.AddOrUpdate(cou => cou.CountryOfUni, CurrentCountry);
                    context.SaveChanges();
                    UniversitysInfo Univer = new UniversitysInfo
                    {
                        NameOfUniversity = ArrayWithLines[1],
                        CountryOfUniversity = context.Countries.Single(country => country.CountryOfUni == CurrentCountry.CountryOfUni)
                    };
                    context.Univesities.AddOrUpdate(u => u.NameOfUniversity, Univer);
                    context.SaveChanges();
                    Console.WriteLine(ArrayWithLines.Count().ToString());
                    RatingData rating = new RatingData
                    {

                        WorldRank = int.Parse(ArrayWithLines[0]),
                        Universiry = context.Univesities.Single(uni => uni.NameOfUniversity == Univer.NameOfUniversity),
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
                        MyID = int.Parse(ArrayWithLines[14])
                    };
                    context.Ratings.AddOrUpdate(r => r.MyID, rating);
                    context.SaveChanges();
                }
                rank2015.Close();
            }
            using (StreamReader rank2016 = new StreamReader("2016Ranking.csv"))
            {
                string LineWithEverithing;
                while ((LineWithEverithing = rank2016.ReadLine()) != null)
                {
                    var ArrayWithLines = LineWithEverithing.Split(';');
                    Country CurrentCountry = new Country { CountryOfUni = ArrayWithLines[2] };
                    context.Countries.AddOrUpdate(cou => cou.CountryOfUni, CurrentCountry);
                    context.SaveChanges();
                    UniversitysInfo Univer = new UniversitysInfo
                    {
                        NameOfUniversity = ArrayWithLines[1],
                        CountryOfUniversity = context.Countries.Single(country => country.CountryOfUni == CurrentCountry.CountryOfUni)
                    };
                    context.Univesities.AddOrUpdate(u => u.NameOfUniversity, Univer);
                    context.SaveChanges();
                    Console.WriteLine(ArrayWithLines.Count().ToString());
                    RatingData rating = new RatingData
                    {

                        WorldRank = int.Parse(ArrayWithLines[0]),
                        Universiry = context.Univesities.Single(uni => uni.NameOfUniversity == Univer.NameOfUniversity),
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
                        MyID = int.Parse(ArrayWithLines[14])
                    };
                    context.Ratings.AddOrUpdate(r => r.MyID, rating);
                    context.SaveChanges();
                }
                rank2016.Close();
            }
            /*
            using (StreamReader rank2012 = new StreamReader("2012Ranking.csv"))
            {
                string LineWithEverithing;
                while ((LineWithEverithing = rank2012.ReadLine()) != null)
                {
                    var ArrayWithLines = LineWithEverithing.Split(';');

                    Country CurrentCountry = new Country { CountryOfUni = ArrayWithLines[2] };
                    context.Countries.AddOrUpdate(c => c.CountryOfUni, CurrentCountry);
                    UniversitysInfo Univer = new UniversitysInfo { NameOfUniversity = ArrayWithLines[1], CountryOfUniversity = CurrentCountry };
                    context.Univesities.AddOrUpdate(u => u.NameOfUniversity, Univer);
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
                        BroadImpact = int.Parse(ArrayWithLines[13])
                    };
                    context.Ratings.AddOrUpdate(r=>((r.WorldRank)&(r.Year)),rating);

                }
            }
            using (StreamReader rank2013 = new StreamReader("2013Ranking.csv"))
            {
                string LineWithEverithing;
                while ((LineWithEverithing = rank2013.ReadLine()) != null)
                {
                    var ArrayWithLines = LineWithEverithing.Split(';');

                    Country CurrentCountry = new Country { CountryOfUni = ArrayWithLines[2] };
                    context.Countries.AddOrUpdate(c => c.CountryOfUni, CurrentCountry);
                    UniversitysInfo Univer = new UniversitysInfo { NameOfUniversity = ArrayWithLines[1], CountryOfUniversity = CurrentCountry };
                    context.Univesities.AddOrUpdate(u => u.NameOfUniversity, Univer);
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
                        BroadImpact = int.Parse(ArrayWithLines[13])
                    };
                    context.Ratings.AddOrUpdate(r => ((r.WorldRank) & (r.Year)), rating);
                }
            }
            using (StreamReader rank2014 = new StreamReader("2014Ranking.csv"))
            {
                string LineWithEverithing;
                while ((LineWithEverithing = rank2014.ReadLine()) != null)
                {
                    var ArrayWithLines = LineWithEverithing.Split(';');

                    Country CurrentCountry = new Country { CountryOfUni = ArrayWithLines[2] };
                    context.Countries.AddOrUpdate(c => c.CountryOfUni, CurrentCountry);
                    UniversitysInfo Univer = new UniversitysInfo { NameOfUniversity = ArrayWithLines[1], CountryOfUniversity = CurrentCountry };
                    context.Univesities.AddOrUpdate(u => u.NameOfUniversity, Univer);
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
                        BroadImpact = int.Parse(ArrayWithLines[13])
                    };
                    context.Ratings.AddOrUpdate(r => ((r.WorldRank) & (r.Year)), rating);
                }
            }
            using (StreamReader rank2015 = new StreamReader("2015Ranking.csv"))
            {
                string LineWithEverithing;
                while ((LineWithEverithing = rank2015.ReadLine()) != null)
                {
                    var ArrayWithLines = LineWithEverithing.Split(';');

                    Country CurrentCountry = new Country { CountryOfUni = ArrayWithLines[2] };
                    context.Countries.AddOrUpdate(c => c.CountryOfUni, CurrentCountry);
                    UniversitysInfo Univer = new UniversitysInfo { NameOfUniversity = ArrayWithLines[1], CountryOfUniversity = CurrentCountry };
                    context.Univesities.AddOrUpdate(u => u.NameOfUniversity, Univer);
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
                        BroadImpact = int.Parse(ArrayWithLines[13])
                    };
                    context.Ratings.AddOrUpdate(r => ((r.WorldRank) & (r.Year)), rating);
                }
            }
            using (StreamReader rank2016 = new StreamReader("2016Ranking.csv"))
            {
                string LineWithEverithing;
                while ((LineWithEverithing = rank2016.ReadLine()) != null)
                {
                    var ArrayWithLines = LineWithEverithing.Split(';');

                    Country CurrentCountry = new Country { CountryOfUni = ArrayWithLines[2] };
                    context.Countries.AddOrUpdate(c => c.CountryOfUni, CurrentCountry);
                    UniversitysInfo Univer = new UniversitysInfo { NameOfUniversity = ArrayWithLines[1], CountryOfUniversity = CurrentCountry };
                    context.Univesities.AddOrUpdate(u => u.NameOfUniversity, Univer);
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
                        BroadImpact = int.Parse(ArrayWithLines[13])
                    };
                    context.Ratings.AddOrUpdate(r => ((r.WorldRank) & (r.Year)), rating);
                }
            }
            context.SaveChanges();*/
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
