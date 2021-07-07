Factory Method

- Classificado pelo propósitop de criação
- Escopo: Classe
- Também conhecido como Construtor Virtual
- Seu objetivo é criar uma "fábrica" de classes em tempo de execução e deixar que a classe decida seu tipo dinamicamente
- Dispõe uma interface, e as subclasses decidirão qual classe concreta deve ser instanciada

"Abstração não deve depender de detalhes, detalhes são quem devem depender de abstrações"


Desafio: Criação dinâmica de personagem de acordo com a opção escolhida

- Os personagens herdam e implementam a interface IPersonagem
- Cada personagem possui um comportamento diferente dentro de um mesmo método de criação
