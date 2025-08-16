namespace cycle_scheduler_api.DTOs
{
    public class Cycle
    {
        private readonly string _id = string.Empty;
        private int _number = 0;
        private DateOnly _startDate = DateOnly.MinValue;
        private DateOnly _endDate = DateOnly.MinValue;
        private readonly List<Day> _days = new List<Day>();

        public Cycle(string ID)
        {
            _id = ID;

            for (int i = 0; i < 6; i++)
            {
                _days.Add(new Day($"{ID}-day-{i}"));
            }
        }

        public List<Day> Days
        {
            get => _days;
        }

        public string ID
        {
            get => _id;
        }

        public int Number
        {
            get => _number;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Number must be non-negative.");
                }
                _number = value;
            }
        }

        public DateOnly StartDate
        {
            get => _startDate;
            set
            {
                if (value < DateOnly.MinValue || value > DateOnly.MaxValue)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Start date is out of range.");
                }
                _startDate = value;
            }
        }

        public DateOnly EndDate
        {
            get => _endDate;
            set
            {
                if (value < DateOnly.MinValue || value > DateOnly.MaxValue)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "End date is out of range.");
                }
                if (value < _startDate)
                {
                    throw new ArgumentException("End date cannot be earlier than start date.", nameof(value));
                }
                _endDate = value;
            }
        }
    }
}
