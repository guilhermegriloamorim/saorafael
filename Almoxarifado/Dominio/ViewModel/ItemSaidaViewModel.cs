namespace Almoxarifado.Dominio.ViewModel
{
    public class ItemSaidaViewModel
    {
        public int? Id { get; set; }
        public DateTime? DT_SAIDA { get; set; }
        public string? NOME_BARRCA { get; set; }
        public int? COD_ITEM { get; set; }
        public string? DESCR_ITEM { get; set; }
        public string? UNIDADE { get; set; }
        public decimal? QTD { get; set; }
        public string? OBSERVACAO { get; set; }
        public int? BarracaId { get; set; }
    }
}
