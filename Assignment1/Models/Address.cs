namespace Assignment1.Models
{
    public class Address
    {
        public string StreetNum { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public StateEnum State { get; set; }

        const string DEF_STREET_NUM = "No Street Number Provided";
        const string DEF_STREET_NAME = "No Street Name Provided";
        const string DEF_SUBURB = "No Suburb Provided";
        const string DEF_POSTCODE = "No Postcode Provided";
        const StateEnum DEF_STATE = StateEnum.NotProvided;

        public Address()
        {
            StreetNum = DEF_STREET_NUM;
            StreetName = DEF_STREET_NAME;
            Suburb = DEF_SUBURB;
            Postcode = DEF_POSTCODE;
            State = DEF_STATE;
        }

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
