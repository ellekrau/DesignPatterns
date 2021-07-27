Template Method

- Classificado pelo propósito de comportamental
- Escopo: Classe
- Define um modelo de passos abstratos que serão fornecidos às subclasses para que possam implementar os passos de um algoritmo sem alterar a estrutura do próprio algoritmo
- Ao desenvolver os componentes deve-se decidir quais etapas de um algoritmo serão:
  - Invariantes (padrão): Implementados em uma classe abstrata
  - Variantes (personalizáveis): Implementação padrão ou nenhuma

Desafio: Baseado em jogos de corrida
- Possível escolher a dificuldade das corridas entre: fácil, normal e difícil
- A sequência das pistas e a trilha sonora são as mesmas (invariantes)
- Características variantes de acordo com a dificuldade escolhida
