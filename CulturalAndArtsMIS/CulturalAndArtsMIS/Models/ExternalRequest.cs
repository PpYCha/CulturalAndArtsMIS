using System;

namespace CulturalAndArtsMIS.Models
{
    public class ExternalRequest
    {
        public int er_ID { get; set; }
        public string partyOrganization { get; set; }
        public string contactPerson { get; set; }
        public string contactNo { get; set; }
        public string titleOfEvent { get; set; }
        public DateTime? dateOfEvent { get; set; }
        public string timeOfEvent { get; set; }
        public string venueOfEvent { get; set; }
        public bool pd_Solo { get; set; }
        public bool pd_Duet { get; set; }
        public bool pd_Chorale { get; set; }
        public bool pd_RondallaBand { get; set; }
        public bool pd_FolkDance { get; set; }
        public bool pd_HipHop { get; set; }
        public bool pd_Contemporary { get; set; }
        public bool pd_DanceSports { get; set; }
        public string noOfPerformance { get; set; }
        public string noOfPerformer { get; set; }
        public bool bitaw { get; set; }
        public string specify { get; set; }

        public bool? granted { get; set; }
        public bool? denied { get; set; }
        public string denied_Reason { get; set; }
        public string notedBy { get; set; }
        public string ApprovedBy { get; set; }

    }
}