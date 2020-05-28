namespace TimeObject
{
    public abstract class TimeBase
    {
        public TimeBase(TimeType _type)
        {
            foreach (var item in TimeOptions._options)
            {
                if (_type == item.Key)
                {
                    this.Options = item.Value;
                }
            }

            ProgramMessageForUser();

            TimeMessageForUser();
        }

        private void ProgramMessageForUser()
        {
            Options.ProgramMessage = message =>
            {
                Options.FlagTag();
                Options.ProgramTag(message);

                return 1;
            };
        }

        private void TimeMessageForUser()
        {
            Options.TimeMessage = message =>
            {
                Options.FlagTag();
                Options.TimeTag(message);

                return 1;
            };
        }

        protected TimeOptions Options { get; set; } = TimeOptions.Default;
    }
}
