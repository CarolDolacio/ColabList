using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.PortableExecutable;

namespace ColabList.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public DateTime Data { get; set;}
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set;}
        [Required]
        public TipoCombustivel Tipo {  get; set; }
        [Required]
        public int VeiculoId { get; set; } // essa é  a configuração do entityframework onde o netity entende que veiculo é ta entidade veículo e ID é a chave primária
        public Veiculo Veiculo { get; set; } // criado objeto do tipo veículo para criar a navegação virtual, que é a possibilidade de navegar de uma entidade para outra. Ou seja, quando o entity carregar inf de uma entidade, ele automaticamente "navega", carregando info de outra 
        public Collection<Consumo> Consumos{ get; set; }
    
    }

    public enum TipoCombustivel
    {
        Diesel,
        Etanol,
        Gasolina
    }
}
