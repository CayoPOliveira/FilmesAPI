using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Endereco
{
    [Key]
    [Required]
    public int Id { get; set; }
    public string Logradouro {  get; set; }
    public int Numero { get; set; }

    //Relação com a entidade Cinema
    public virtual Cinema Cinema {  get; set; }
}
