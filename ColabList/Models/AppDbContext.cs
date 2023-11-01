using Microsoft.EntityFrameworkCore;

namespace ColabList.Models
{
    public class AppDbContext : DbContext 
    {
        //esse codigo abaixo é uma injeção de dependecia??
        // elas serão colocadas em Program.cs
        public AppDbContext(DbContextOptions options) : base(options) // preciso entender isso daqui melhor
        {
        }

        //agora vou colocar aqui quais são as tabela que ele vai criar
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Consumo> Consumos { get; set; }
        //essa é a config necessario para criar a Classe de contextou ou DbContext
    }
}
