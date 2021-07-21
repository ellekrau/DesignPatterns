Facade

- Classificado pelo propósito de estrutura
- Tem como princípio ocultar a complexidade de uma ou mais classes, permitindo isolar partes do sistema (subsistema)
- Pode-se criar uma "fachada" que contém alguns sistemas que poderão ser acessados somente por meio dessa "fachada"
  - A estrutura interna desses subsistemas fica oculta
  - Acessiveis pela "fachada"
  
 Desafio: Baseado em um jogo no estilo RTS  (Real-time-strategy), onde há diversos tipos de tropas e o objetivo é se fortalecer para vencer as tropas inimigas
 - Cada tropa tem uma construção fundamental, que é o centro de comando
 - No centro de comando são executadas diversas operações, como: 
    - Coleta de recursos de energia
    - Produção de armamentos
    - Treinamento de guerreiros
 - Não importa como cada operação (subsistema) do centro de controle é realizada internamente
 - Importa somente que o centro de controle execute o que é solicitado
 - O desafio é criar uma estrutura que ocupe como as operações internas são executadas, permitindo que o centro de controle apenas mande executá-las
    
