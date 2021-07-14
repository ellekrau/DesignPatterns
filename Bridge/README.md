Bridge

- Classificado pelo propósito de estrutura
- Escopo: Objeto
- Tem como objetivo dividir uma classe ou um conjunto de classes relacionadas em duas hierarquias separadas: 
  - Responsável pela representação (abstração) do objeto que deverá ser criado
  - Responsável pela implementação
- Permite o desenvolvimento dos objetos que compõe essa hierarquia de maneira independente uma das outras

Desafio: Baseado no game Tetris
 - Criar formas diferentes com cores diferentes
 - Criação das classes forma e cor
 - Uma forma pode ter diversas cores
 - A referência funcionará como uma "ponte" (bridge) entre forma e cor, assim, sempre que novas cores forem adicionadas automaticamente estarão disponíveis para todas as formas
