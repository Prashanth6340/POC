public class SG
    {
        public string ShipmentStatusCode { get; set; }
        public string StatusResonCode { get; set; }
        public string DispostionCode { get; set; }
        //[JsonIgnore]
        public string Date { get; set; }
        //[JsonIgnore]
        public string Time { get; set; }
        // public string DateTime{
        //     get{
        //         return string.Concat("20", Date.Substring(0, 2), "-", Date.Substring(2, 2), "-", Date.Substring(4, 2), "T", Time.Substring(0, 2), ":", Time.Substring(2, 2), ":00");
        //     }
        // }
        public string TimeCode { get; set; }
        public string DateTime{get; set; }
    }
