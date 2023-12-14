using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Dtos;

public class CreateCinemaDto
{
    [Required]
    public string Nome { get; set; }
}
