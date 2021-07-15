Factory Method

- Classificado pelo propósito de criação
- Escopo: Classe
- Também conhecido como Construtor Virtual
- Seu objetivo é criar uma "fábrica" de classes em tempo de execução e deixar que a classe decida seu tipo dinamicamente
- Dispõe uma interface, e as subclasses decidirão qual classe concreta deve ser instanciada

> "Abstração não deve depender de detalhes, detalhes são quem devem depender de abstrações"

Desafio: Baseado no game Mortal Kombat, onde o usuário escolhe um personagem e este é utilizado para lutar
- Criação dinâmica de personagem de acordo com a opção escolhida pelo usuário
- Os personagens herdam e implementam a interface IPersonagem, que implementa o método Escolhido()
- Cada personagem possui um comportamento diferente para o método Escolhido()
