namespace AlmoxarifadoService.Dominio.DTO
{
    public class ItemSaidaDtoRead
    {
        public int? Id { get; set; }
        public DateTime? DtSaida { get; set; }
        public decimal? Quantidade { get; set; }
        public string? Unidade { get; set; }
        public string? Observacao { get; set; }
        public int? BarracaId { get; set; }
        public int? ItemId { get; set; }
    }
}
