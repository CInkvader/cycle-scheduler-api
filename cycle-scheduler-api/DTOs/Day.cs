namespace cycle_scheduler_api.DTOs
{
    public class Day
    {
        private readonly string _id = string.Empty;
        private int _number = 0;
        private DateOnly _date = DateOnly.MinValue;
        private string _dayType = string.Empty;

        public Day(string ID)
        {
            _id = ID;
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

        public DateOnly Date
        {
            get => _date;
            set
            {
                if (value < DateOnly.MinValue || value > DateOnly.MaxValue)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Date is out of range.");
                }
                _date = value;
            }
        }

        public string DayType
        {
            get => _dayType;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Day type cannot be null or empty.", nameof(value));
                }
                _dayType = value;
            }
        }
    }
}
