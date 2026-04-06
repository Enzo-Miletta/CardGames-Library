namespace CardGames.Core.Models
{
    public class Partida
    {
        public List<Jogador> Jogadores { get; }
        public List<Rodada> HistoricoRodadas { get; }
        public Baralho Baralho { get; }

        public Partida(List<Jogador> jogadores)
        {
            Jogadores = jogadores;
            HistoricoRodadas = new List<Rodada>();
            Baralho = new Baralho();
        }

        public void IniciarNovaRodada()
        {
            var rodada = new Rodada(Jogadores);
            HistoricoRodadas.Add(rodada);
        }
    }
}
