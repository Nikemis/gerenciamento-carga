## Desafio Acadêmico: Otimização de Armazenamento de Contêineres

## Introdução

Este projeto é um desafio acadêmico simulado como um hackathon. O objetivo é desenvolver um sistema para otimizar o armazenamento e o carregamento de contêineres em um terminal portuário. O layout do porto é organizado em uma grade (grid), onde cada célula representa um espaço de armazenamento para contêineres.

## Objetivo

Desenvolver um sistema que gerencie eficientemente o armazenamento de contêineres no porto, otimizando o processo de carregamento para facilitar o transporte ao agrupar contêineres do mesmo tipo em blocos contíguos.

## Descrição do Problema

Você foi contratado por uma empresa de logística para criar uma solução

## Matriz de Armazenamento

O porto é representado por uma matriz n x m, onde:

Cada célula pode estar vazia ou conter um contêiner.
Cada célula da matriz pode ser:
0 se estiver vazia.
Um número positivo representando o tipo do contêiner (por exemplo, 1 para produtos químicos, 2 para alimentos, etc).

## Requisito de Carregamento

O objetivo é otimizar o carregamento garantindo que contêineres do mesmo tipo sejam agrupados em blocos contíguos para facilitar o transporte. A tarefa é:

Identificar Todos os Blocos Contíguos:

Desenvolver uma função para identificar e contar todos os blocos contíguos de contêineres do mesmo tipo na matriz.
Um bloco é definido como um conjunto de células adjacentes (horizontal e vertical, não diagonal) contendo o mesmo tipo de contêiner.
Calcular o Tamanho dos Blocos:

Para cada bloco identificado, calcular o número total de contêineres no bloco.
Otimização:

Propor uma maneira de reorganizar a matriz para agrupar contêineres do mesmo tipo, maximizando o tamanho dos blocos contíguos.

## Entrada e Saída

Entrada

Uma matriz n x m onde cada célula contém um número inteiro representando o tipo de contêiner ou 0 se estiver vazia.

Saída
Uma lista de blocos encontrados, onde cada bloco é representado por:

Uma lista de coordenadas (células).
O tipo de contêiner.
A quantidade total de contêineres em cada bloco.
Uma sugestão de reordenação da matriz para maximizar a formação de blocos contíguos.
