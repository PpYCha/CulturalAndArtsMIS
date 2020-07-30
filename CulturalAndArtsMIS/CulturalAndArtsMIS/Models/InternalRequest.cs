using System;

namespace CulturalAndArtsMIS.Models
{
    public class InternalRequest
    {
        public int ir_ID { get; set; }
        public DateTime? date_Internal { get; set; }
        public string pary { get; set; }
        public string officeCollegeOrganization { get; set; }
        public string titleOfTheActivity { get; set; }
        public bool? conferenceSeminar { get; set; }
        public bool? recognitionRites { get; set; }
        public bool? generalAssembly { get; set; }
        public bool? program { get; set; }
        public bool? others { get; set; }
        public string specify { get; set; }
        public bool? pd_SoloDuet { get; set; }
        public bool? pd_LiveBand { get; set; }
        public bool? pd_Chorale { get; set; }
        public bool? pd_Rondalla { get; set; }
        public bool? pd_FolkDance { get; set; }
        public bool? pd_HipHop { get; set; }
        public bool? pd_DanceSports { get; set; }
        public bool? pd_Contemporary { get; set; }
        public string numberOfPerformance { get; set; }
        public string numberOfPerformer { get; set; }
        public string venueOfTheActivity { get; set; }
        public DateTime?  dateOfTheActivity { get; set; }
        public string timeOfTheActivity { get; set; }
    }
}