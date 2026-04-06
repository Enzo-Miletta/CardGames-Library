# CardGames.Core

Esta é uma biblioteca de classes genérica para modelar características comuns a jogos de cartas.

## Estrutura do Projeto

O projeto `CardGames.Core` contém as seguintes classes e enums:

### Enums

- `Naipe`: Representa os naipes de um baralho (Paus, Ouros, Copas, Espadas).
- `ValorCarta`: Representa os valores das cartas (Ás a Rei).

### Models

- `Carta`: Representa uma carta de baralho, com um `Valor` and `Naipe`.
- `Jogador`: Representa um jogador, com um `Nome` e uma `Mao` (lista de `Carta`).
- `Baralho`: Representa um baralho de 52 cartas. Possui métodos para `Embaralhar` e `TirarCarta`.
- `Rodada`: Modela uma rodada de um jogo, contendo os `Jogadores` e as `CartasJogadas` em um dicionário.
- `Partida`: Gerencia o estado de uma partida, incluindo a lista de `Jogadores`, o `HistoricoRodadas` e o `Baralho`.

## Como Usar

Esta biblioteca pode ser usada como base para a criação de diversos jogos de cartas. As classes foram desenhadas para serem genéricas e extensíveis.

## Membros do Grupo

- Fabricio Bettarello Heluani / RM 554638
- Enzo Miletta Herrera da Silva / RM 98677
