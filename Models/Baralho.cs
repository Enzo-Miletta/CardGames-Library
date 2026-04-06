using CardGames.Core.Enums;
using CardGames.Core.Models;

namespace CardGames.Core.Models
{
    public class Baralho
    {
        private readonly List<Carta> _cartas;
        private readonly Random _random = new Random();

        public Baralho()
        {
            _cartas = new List<Carta>();
            foreach (Naipe naipe in Enum.GetValues(typeof(Naipe)))
            {
                foreach (ValorCarta valor in Enum.GetValues(typeof(ValorCarta)))
                {
                    _cartas.Add(new Carta(valor, naipe));
                }
            }
        }

        public void Embaralhar()
        {
            int n = _cartas.Count;
            while (n > 1)
            {
                n--;
                int k = _random.Next(n + 1);
                (_cartas[k], _cartas[n]) = (_cartas[n], _cartas[k]);
            }
        }

        public Carta? TirarCarta()
        {
            if (_cartas.Count == 0)
            {
                return null;
            }

            Carta carta = _cartas[0];
            _cartas.RemoveAt(0);
            return carta;
        }
    }
}
