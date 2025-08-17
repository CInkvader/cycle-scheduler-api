namespace cycle_scheduler_api.DTOs
{
    public class Session
    {
        private readonly string _id = string.Empty;
        private string _dayId = string.Empty;
        private string _subjectId = string.Empty;
        private string _sectionId = string.Empty;
        private TimeOnly _startTime = TimeOnly.MinValue;
        private TimeOnly _endTime = TimeOnly.MinValue;
        private string _userId = string.Empty;
        private string _roomDescription = string.Empty;

        public Session(string ID)
        {
            _id = ID;
        }

        public string Id
        {
            get => _id;
        }

        public string DayId
        {
            get => _dayId;
        }

        public string SubjectId
        {
            get => _subjectId;
        }

        public string SectionId
        {
            get => _sectionId;
        }

        public TimeOnly StartTime
        {
            get => _startTime;
            set => _startTime = value;
        }

        public TimeOnly EndTime
        {
            get => _endTime;
            set => _endTime = value;
        }

        public string UserId
        {
            get => _userId;
            set => _userId = value;
        }
        public string RoomDescription
        {
            get => _roomDescription;
            set => _roomDescription = value;
        }
    }
}
