﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimeListMvc.Models
{
    public class Animes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public int QuantidadeTemporadas { get; set; }
        public int QuantidadeEpisodios { get; set; }
    }
}