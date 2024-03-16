namespace Assignment1.Models
{
    public class Address
    {
        public string StreetNum { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public StateEnum State { get; set; }

        public Address(string streetNum, string streetName, string suburb, string postcode, StateEnum state)
        {
            StreetNum = streetNum;
            StreetName = streetName;
            Suburb = suburb;
            Postcode = postcode;
            State = state;
        }

        public override string ToString()
        {
            return $"{StreetNum} {StreetName}, {Suburb}, {State} {Postcode}";
        }
    }
    public enum StateEnum
    {
        NotProvided,
        NSW,
        ACT,
        VIC,
        QLD,
        SA,
        WA,
        TAS,
        NT
    }
}
