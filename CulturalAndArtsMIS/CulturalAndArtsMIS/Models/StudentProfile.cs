using System;

namespace CulturalAndArtsMIS.Models
{
    public class StudentProfile
    {
        //Part 1
        public int studentProfile_ID { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public string Course { get; set; }
        public string Year { get; set; }
        public string CellphoneNo { get; set; }
        public string EmailAddress { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string HomeAddress { get; set; }
        public string CampusAddress { get; set; }

        //Part 2
        public bool HavePerformed { get; set; }
        public bool HaveTrainings { get; set; }
        public bool HaveExperience { get; set; }
        public bool CanAttend { get; set; }
        public bool Commuter { get; set; }
        public string Skills { get; set; }
        public string Finance { get; set; }

        //Part 3
        public bool FolkDance { get; set; }
        public bool HipHop { get; set; }
        public bool Contemporary { get; set; }
        public bool Theater { get; set; }
        public bool LiteraryArts { get; set; }
        public bool RadioTalents { get; set; }
        public bool ManagementTechnical { get; set; }
        public bool Chorale { get; set; }
        public bool LiveBand { get; set; }
        public bool RondallaBand { get; set; }
        public bool PaintingDrawing { get; set; }
        public bool MakeUp { get; set; }
        public bool Photography { get; set; }
        public bool Multimedia { get; set; }

    }
}