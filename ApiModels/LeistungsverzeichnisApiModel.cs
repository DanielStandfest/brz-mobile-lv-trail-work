namespace  BrzMobileLvTrailWork.ApiModels
{
    public class LeistungsverzeichnisApiModel
    {
        public int Id { get; set; }
        public string Ordnungszahl { get; set; }
        public string Kurztext { get; set; }
        public decimal Gesamtpreis { get; set; }
        public string Langtext { get; set; }
        public bool IsNachtragsPosition { get; set; }
    }
}
