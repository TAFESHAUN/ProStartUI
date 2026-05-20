namespace ProStartUI.DataModel
{

    public class Activity
    {
        public int ActivityID { get; set; }
        public DateTime DateStartTime { get; set; }
        public string Title { get; set; } = "";

        public decimal Cost { get; set; }

        public string ActivityType { get; set; } = "";
    }
}
