namespace AlmoxarifadoService.Dominio.DTO
{
    public class BarracaDtoRead
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }

        public override string ToString()
        {
            return ($"{Id} {Nome} {Descricao}").Trim();
        }

    }
}
