namespace cycle_scheduler_api.DTOs
{
    public class Reminder
    {
        private readonly string _id = string.Empty;
        private string _subject = string.Empty;
        private string _description = string.Empty;
        private TimeOnly _startTime = TimeOnly.MinValue;
        private TimeOnly _endTime = TimeOnly.MinValue;
        private string _cycleId = string.Empty;
        private string _dayId = string.Empty;
        private string _sessionId = string.Empty;

        public Reminder(string ID)
        {
            _id = ID;
        }

        public string Id
        {
            get => _id;
        }

        public string Subject
        {
            get => _subject;
            set => _subject = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
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

        public string CycleId
        {
            get => _cycleId;
            set => _cycleId = value;
        }

        public string DayId
        {
            get => _dayId;
            set => _cycleId = value;
        }

        public string SessionId
        {
            get => _sessionId;
            set => _sessionId = value;
        }

    }
}
}
