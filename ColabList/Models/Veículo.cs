using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ColabList.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Placa { get; set; }
        [Required]
        public int AnoFabricacao { get; set; }
        [Required]
        public int AnoModelo { get; set; }
        [Required]
        // como a relação com entity é 1:n não é necessário criar uma prop de consumo mas sim a naveção virtual, sendo:
        public ICollection<Consumo> Consumos { get; set; }
        // com isso ue falo que a minha class veiculo tem N consumos e que esses consumos estão associados apenas a um veículo
    }
}
