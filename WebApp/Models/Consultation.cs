namespace WebApp.Models
{
    public class Consultation
    {
        public int Id { get; set; }
        public int IdStudent { get; set; }
        public int IdTeacher { get; set; }
        public string ConsSubject { get; set; }
        public DateTime ConsTime { get; set; }
    }
}
