namespace CardGames.Core.Models
{
    public class Jogador
    {
        public string Nome { get; }
        public List<Carta> Mao { get; }

        public Jogador(string nome)
        {
            Nome = nome;
            Mao = new List<Carta>();
        }

        public void AdicionarCarta(Carta carta)
        {
            Mao.Add(carta);
        }

        public void LimparMao()
        {
            Mao.Clear();
        }
    }
}
