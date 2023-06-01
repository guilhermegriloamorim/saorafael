namespace AlmoxarifadoService.Dominio.DTO
{
    public class ItemDtoRead
    {
        public int? Id { get; set; }    
        public string? Codigo { get; set; }
        public string? Descricao { get; set; }
        public string? Tipo { get; set; }

        public override string ToString()
        {
            return ($"{Id} {Codigo} {Descricao}").Trim();
        }
    }
}
