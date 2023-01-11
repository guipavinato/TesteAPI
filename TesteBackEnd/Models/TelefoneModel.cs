namespace TesteBackEnd.Models
{
    public class TelefoneModel
    {
        public string? Numero { get; set; }
        public int? UsuarioId { get; set; }
        public virtual UsuarioModel? Usuario { get; set; }
    }
}