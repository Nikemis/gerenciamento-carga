Este projeto é um desafio acadêmico, simulado como um hackathon. O objetivo principal é desenvolver um sistema para otimizar o armazenamento e o carregamento de contêineres em um terminal portuário. O porto é organizado em um layout de grid onde cada célula representa um espaço de armazenamento para contêineres.

Problema

O seu grupo de desenvolvedores foi contratado por uma empresa de logística para criar um sistema que gerencie o armazenamento de contêineres no porto. A solução deve abordar os seguintes aspectos:

Matriz de Armazenamento:

O porto é representado por uma matriz n x m, onde cada célula pode estar vazia ou conter um contêiner.
Cada célula da matriz pode ser:
0 se estiver vazia
Um número positivo representando o tipo do contêiner (por exemplo, 1 para produtos químicos, 2 para alimentos, etc.).
Requisito de Carregamento:

O objetivo é otimizar o processo de carregamento garantindo que contêineres do mesmo tipo sejam agrupados em blocos contíguos para facilitar o transporte.
A tarefa é identificar todos os blocos contíguos de contêineres do mesmo tipo e calcular a quantidade total de contêineres em cada bloco.
Tarefas Específicas
Identificação de Blocos:

Desenvolva uma função para identificar e contar todos os blocos contíguos de contêineres do mesmo tipo na matriz.
Um bloco é definido como um conjunto de células adjacentes que contêm o mesmo tipo de contêiner. As adjacências são consideradas na horizontal e vertical (não diagonal).
Cálculo de Tamanho dos Blocos:

Para cada bloco identificado, calcule o número total de contêineres no bloco.
Otimização:

Proponha uma maneira de reorganizar a matriz para agrupar contêineres do mesmo tipo, maximizando o tamanho dos blocos contíguos.
Entrada e Saída
Entrada:

Uma matriz n x m onde cada célula contém um número inteiro que representa o tipo de contêiner ou 0 se estiver vazia.

Uma lista de blocos encontrados, onde cada bloco é representado por uma lista de coordenadas (células) e o tipo de contêiner.
A quantidade total de contêineres em cada bloco.
Uma sugestão de reordenação da matriz para maximizar os blocos contíguos.
