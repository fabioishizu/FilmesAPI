﻿using System.ComponentModel.DataAnnotations;

namespace ApiFilme.Data.Dtos;

public class ReadFilmeDto 
{ 
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int TempoDuracao { get; set; }
    public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
}
