using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniRanking.Data
{
    public class UniversitysInfo
    {
        public int ID { get; set; }
        public string NameOfUniversity { get; set; }


        public Country CountryOfUniversity { get; set; }
        public List<RatingData> Ratigns { get; set; }
    }
}
