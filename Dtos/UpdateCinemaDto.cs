using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Dtos;

public class UpdateCinemaDto
{
    [Required]
    public string Nome { get; set; }
}
