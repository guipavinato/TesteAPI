namespace TesteBackEnd.Models
{
    public class TelefoneModel
    {
        public int? UsuarioId { get; set; }
        public string? Numero { get; set; }
        public virtual UsuarioModel? Usuario { get; set; }
    }
}