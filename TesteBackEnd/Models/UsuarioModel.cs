namespace TesteBackEnd.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public DateOnly Nascimento { get; set; }
        public char? Cpf { get; set; }
        public ICollection<TelefoneModel> Telefones { get; set; }
    }
}
