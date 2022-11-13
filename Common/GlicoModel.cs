using System;

namespace Common
{
    public class GlicoModel
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        public decimal Batimentos { get; set; }
        public CategoriaG Categoria { get; set; }
    }
}
