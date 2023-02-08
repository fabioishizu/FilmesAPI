using ApiFilme.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiFilme.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();

    [HttpPost]
    public void AdicionaFilme([FromBody] Filme filme)
    {
        
        filmes.Add(filme);
        Console.WriteLine($"Duracao: {filme.TempoDuracao} Nome: {filme.Titulo} Genero: {filme.Genero}");
    }

    [HttpGet]
    public List<Filme> RecuperarFilmes()
    {
        return filmes;
    }
}
