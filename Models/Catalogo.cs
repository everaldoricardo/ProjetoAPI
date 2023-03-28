using System;

namespace APICatalogo.Models

{
    public class Catalogo
        {
            public int ID { get; set; }
            public string? Nome { get; set; }
            public string? Descrição { get; set; }
            public string? URL { get; set; }
            public DateTime EnrollmentDate { get; set; }
            public enum Acessibilidade : long { Interno, Exeterno }
            public string? Categoria { get; set; }
    }
}