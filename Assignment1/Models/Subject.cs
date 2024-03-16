namespace Assignment1.Models
{
    public class Subject
    {
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public decimal Cost { get; set; }

        private const string DEFAULT_SUBJECT_CODE = "No Subject Code Provided";
        private const string DEFAULT_SUBJECT_NAME = "No Subject Name Provided";
        private const decimal DEFAULT_COST = 0m;

        public Subject()
        {
            SubjectCode = DEFAULT_SUBJECT_CODE;
            SubjectName = DEFAULT_SUBJECT_NAME;
            Cost = DEFAULT_COST;
        }

        public Subject(string subjectCode, string subjectName, decimal cost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"Subject Code: {SubjectCode}, Subject Name: {SubjectName}, Cost: {Cost.ToString("C")}";
        }
    }
}
