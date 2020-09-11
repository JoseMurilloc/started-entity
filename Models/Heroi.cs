using System.Collections.Generic;

namespace EFCore.WebApi.Models
{
    public class Heroi
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IdentidadeSecreta IdentidadeSecreta { get; set; }
        public List<Arma> Armas { get; set; }
        public List<Batalha> HeroisBatalhas { get; set; }
    }
}