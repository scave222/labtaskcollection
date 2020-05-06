namespace SoftwareEducationalService
{
    public class Collections
    {
        public string ExhibitName{get; set;}
        public string PersonName{get; set;}
        public string SubjectName{get; set;}
        public int ExhibitFloor{get; set;}
        public string BuildingName{get; set;}

        public Collections(string exhibitName, string personName, string subjectName, int exhibitFloor, string buildingName)
        {
            ExhibitName = exhibitName;
            PersonName = personName;
            SubjectName = subjectName;
            ExhibitFloor = exhibitFloor;
            BuildingName = buildingName;
        }

        public override string ToString()
        {
            return $"========================\nExhibition Name: {ExhibitName}\nPerson Name: {PersonName}\nSubject Name: {SubjectName}\nExhibition Floor: {ExhibitFloor}\nBuilding Name: {BuildingName}";
        }
    }
}