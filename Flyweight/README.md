Flyweight

- Classificado pelo propósito de estrutura
- Escopo: Objeto
- Tem como objetivo melhorar o desempenho compartilhando objetos com características parecidas
- Provê recursos para que objetos existentes possam ser reaproveitados, modificando suas propriedades conforme solicitado, em vez da necessidade de sempre instanciar novos objetos

> Um dos requisitos não funcionais de grande importância de qualquer software é performance, e deixar o software mais rápido implica em pouco consumo de memória

Características de um objeto no padrão Flyweight:
- Intrínseca: Propriedade imutável (caracteriza o objeto compartilhado, mas não muda). Exemplo: Tartarugas
- Extrínseca: Propriedades variáveis que pode receber novos valores a cada acesso. Exemplo: Cor

Desafio: Baseado no game Super Mario, onde existem diversas tartarugas.
- Cada uma é um objeto e existem tartarguas de diversos tipos no decorrer do jogo
- Desenvolver uma solução que garanta apenas uma instância para cada tipo de tartaruga, para evitar sobrecarregar a memória
- Compartilhar objetos semelhantes que já estão instanciados e reduzir a quantidade de objetos alocados na memória
