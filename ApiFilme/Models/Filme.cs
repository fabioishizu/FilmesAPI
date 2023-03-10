using System.ComponentModel.DataAnnotations;

namespace ApiFilme.Models;

public class Filme
{

    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O Título do filme precisa ser preenchido.")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O Gênero do filme precisa ser preenchido.")]
    [MaxLength(50, ErrorMessage = "O tamanho do gênero do filme precisa ser inferior a 50 caracteres.")]
    public string Genero { get; set; }
    [Required(ErrorMessage = "O Tempo de duração do filme precisa ser preenchido.")]
    [Range(70, 600, ErrorMessage = "A duração precisa ser entre 70 e 600 minutos.")]
    public int TempoDuracao { get; set; }

    public Filme(string titulo, string genero, int tempoDuracao, int id)
    {
        Titulo = titulo;
        Genero = genero;
        TempoDuracao = tempoDuracao;
        Id = id;
    }
}
