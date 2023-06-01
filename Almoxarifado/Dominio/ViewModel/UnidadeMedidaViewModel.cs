namespace Almoxarifado.Dominio.ViewModel
{
    public class UnidadeMedidaViewModel
    {
        public string? UNIDADE { get; set; }
        public string? DESCRICAO { get; set; }
        public override string ToString()
        {
            return DESCRICAO;
        }
    }
}
