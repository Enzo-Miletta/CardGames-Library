namespace CardGames.Core.Models
{
    public class Rodada
    {
        public List<Jogador> Jogadores { get; }
        public Dictionary<Jogador, Carta> CartasJogadas { get; }

        public Rodada(List<Jogador> jogadores)
        {
            Jogadores = jogadores;
            CartasJogadas = new Dictionary<Jogador, Carta>();
        }

        public void JogarCarta(Jogador jogador, Carta carta)
        {
            if (Jogadores.Contains(jogador) && jogador.Mao.Contains(carta))
            {
                CartasJogadas[jogador] = carta;
                jogador.Mao.Remove(carta);
            }
        }
    }
}
