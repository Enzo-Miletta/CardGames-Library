using CardGames.Core.Enums;

namespace CardGames.Core.Models
{
    public class Carta
    {
        public ValorCarta Valor { get; }
        public Naipe Naipe { get; }

        public Carta(ValorCarta valor, Naipe naipe)
        {
            Valor = valor;
            Naipe = naipe;
        }

        public override string ToString()
        {
            return $"{Valor} de {Naipe}";
        }
    }
}
