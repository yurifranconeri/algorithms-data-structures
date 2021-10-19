# Engenheiros de Software

Conhecimento para um bom engenheiro de software.

## Sumário

1. [Conceitos](#conceitos)
    1. [Big O](#big-o)
    2. [Bit Manipulation](#bit)
    3. [Recursion](#recursion)
    4. [Dynamic Programming](#dinamic-programming)
    5. [Memoria (Stack vs. Heap)](#dinamic-programming)
2. [Estrutura de dados](#estrutura-de-dados)
    1. [Arrays](#arrays)
    2. [Matrix](#matrix)
    3. [Linked Lists](#linked-lists)
    4. [Stacks](#stacks)
    5. [Queues](#queues)
    6. [Hash Tables](#hash)
    7. [Trees](#trees)
        1. [Binary Trees](#binary-tree)
        2. [Binary Search Trees](#binary-search-tree)
    8. [Tries](#tries)
    9. [Graph](#graph)
    10. [Heaps](#heaps)
3. [Algorithms](#algorithms)
    1. [Sorting](#sorting)
        1. [Selection Sort](#selection-sort)
        2. [Bubble Sort](#bubble-sort)
        3. [Insertion Sort](#bubble-sort)
        4. [Merge Sort](#merge-sort)
        5. [Quick Sort](#quick-sort)
        6. [Heap Sort](#heap-sort)
    2. [Searching](#searching)
        1. [Linear Search](#linear-search)
        2. [Binary Search](#binary-search)
        3. [Jump Search](#jump-search)
        4. [Interpolation Search](#interpolation-search)
        5. [Exponential Search](#exponential-search)
        6. [Ternary Search](#interpolation-search)
        7. [Breadth-First Search](#bfs)
        8. [Depth-First Search](#bfs)
4. [Object-Oriented Programming](#oop)
    1. [Design Patterns](#design-patterns)
    2. [SOLID](#solid)
5. [Testing](#testing)
6. [System Design](#system-design)
7. Referências(#references)

# Conceitos

Conceitos importantes para engenheiros de software.

## Big O

Não podemos medir a eficiência de um algoritmo em tempo como segundos pois isso dependeria do hardware e do software em que o algoritmo está sendo executado. Como comparar dois algoritmos sem levar em consideração o hardware e sua utilização?

Podemos comparar usando complexidade assintótica e a notação Big O, que medem a eficiência do algoritmo quando o valor de entrada tende ao infinito. Sendo assim, é possível medir a complexidade de tempo e espaço no melhor, pior e no caso esperado para o algoritmo. Podemos pensar em quão bem o algoritmo pode escalar conforme a quantidade de dados aumenta.

Na análise assintótica, avaliamos o desempenho de um algoritmo em termos de tamanho de entrada (não medimos o tempo de execução real). Calculamos como o tempo (ou espaço) gasto por um algoritmo aumenta com a variação do tamanho da entrada.

> Big O é a linguagem e métrica para descrever a eficiência de um algoritmo.

Exemplo, procurar um caractere em uma string, levando em consideração o pior caso, em que o caractere que estamos procurando não existe na string, percorreríamos toda a string e com isso o tamanho dela (n) influencia linearmente no tempo, percorrer uma string de 10 (n=10) caracteres é o dobro do que percorrer uma de 5 (n=5) e metade de percorrer uma de 20 (n=20), ou seja, o tempo necessário para percorrer a string é proporcional a quantidade de caracteres. Com isso, podemos representar essa busca linear como O(n).

Também temos operações contantes, como ler valores de uma variável ou um caractere específico de uma string, seja ele o primeiro, o último, do meio, ou qualquer outro, ler o esse caracter leva o mesmo tempo em uma string com 10 caracteres ou com 100. Por exemplo, podemos ler o primeiro caracter de uma string passando o index 0, "nome[0]" e não importa o tamanho do nome da pessoa o tempo para acessar esse primeiro caractere é o mesmo. Ou seja, se um ou mais passos de uma operação não demoram mais com a mudança do tamanho da nossa entrada podemos definir que é uma complexidade assintótica constante. E com isso, podemos representar essa operação como O(1).

As notações mais comuns são O(1), O(n), O(n²), O(log n) e O(n log n)

### Exemplos

#### O(1) - Ler valores e fazer contas

```csharp
var startArray = 0;
var endArray = array.Length - 1;
var middleIndex = (startArray + endArray)/2;
var middleValue = array[middleIndex];
```

> Não importa se o array tem 3 ou 3 milhões de elementos, encontrar o elemento do meio com essas 4 operação irá demorar o mesmo tempo.

#### O(n) - Linear

```csharp
var array = new int[] { 1, 2, 3, 4 };
var valueToFind = 26;
var result = LinearSearch(valueToFind);
...
private static int LinearSearch(int valueToFind) {
    // Buscar o valor percorrendo todo o array, então o tempo aumenta proporcionalmente com a entrada.
    // 1 é igual a 26, não. Próximo, 2 é igual a 26, não. Próximo, e assim por diante. No pior caso que é quando não encontramos o valor percorremos todo o array, sendo assim O(n)
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == valueToFind)
        {
            return i;
        }
    }
    return -1;
}

```

#### O(n²) - Bubble sort

```csharp
var array = new int[] { 4, 3, 2, 1 };
var result = LinearSearch(array);
...
private static int[] BubbleSort(int[] array) {
    // Organiza o array passando cada elemento pela lista completa de elementos.
    // 1 é menor que 2? Troca! 1 é menor que 3? Troca! Assim por diante até termos o 1 na posição correta e depois voltamos para colocar o número 2 na posição correta. No pior cenário onde o array está invertido percorremos todo os elementos com cada um dos valors da list por isso (n*n) que é O(n²)

    for (int i = array.Length - 1; i > 1; i--)
    {
        for (int j = 0; j < i; j++) 
        {
            if (array[j] > array[j+1])
            {
                var temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
            }
        }
    }
    return -1;
}
```

#### O(log n) - Binary search

```csharp
var array = new int[] { 1, 2, 3, 4, 5 };
var valueToFind = 26;
var result = BinarySearch(valueToFind);
...
private static int BinarySearch(int valueToFind) {
    // Buscar o valor cortando o array na metade e repetindo  o processo irá encontrar o valor em log n. No entanto, para aplicar o BinarySearch o array deve estar organizado (sort)
    // Encontrar a metade, start = 0, end = array.Length = 5, metade = (5 + 0)/2 = 2.5, como trabalhamos com inteiros metade = 3. Verificar se array[3]  é 26, não. Como 26 é maior que 3, buscamos  a metade do "sub array" da direita {4, 5}, endArray = 3 + 1 = 4. array[4] é 26. Não! E assim por diante estamos cortando as possibilidades pela metade e em um array com 5 elementos são 3 passos para encontrar o valor, já com 10 elementos 4 passos, então dobrando os valores só aumentamos um passo e por isso O(log n)

    var startArray = 0;
    var endArray = array.Length - 1;

    while (startArray <= endArray) 
    {
        var middleIndex = (startArray + endArray)/2;
        var middleValue = array[middleIndex];
        if (middleValue == valueToFind)
        {
            return middleIndex;
        }

        if (middleValue < valueToFind)
        {
            startArray = middleIndex + 1;
            continue;
        }
        
        if (middleValue > valueToFind) {
            endArray = middleIndex - 1;
        }
    }
    return -1;
}
```

#### O(n log n) - Quick Sort

```csharp
private static void QuickSorting(int[] array, int start, int end)
{
    // Algoritmo que divide o array em partições menores de acordo com um pivot escolhido.
    // O pivot pode ser qualquer número, nesse caso estamos selecionando o último elemento do array
    // O algoritmo percorre todo o array e divide em partições por isso O(n log n).
    if (start < end)
    {
        var pivot = Partition(array, start, end);
        QuickSorting(array, start, pivot - 1);
        QuickSorting(array, pivot + 1, end);
    }
}

private static int Partition(int[] array, int start, int end)
{
    var pivotValue = array[end];
    int pseudoPivotIndex = start;
    for (int j = start; j < end; j++)
    {
        if (array[j] <= pivotValue)
        {
            var temp = array[j];
            array[j] = array[pseudoPivotIndex];
            array[pseudoPivotIndex] = temp;
            pseudoPivotIndex++;
        }
    }

    var aux = array[pseudoPivotIndex];
    array[pseudoPivotIndex] = array[end];
    array[end] = aux;

    return pseudoPivotIndex;
}

```

### Complexidade de Tempo

A complexidade do tempo descreve a quantidade de tempo computacional para executar um algoritmo.

### Complexidade de Espaço

A complexidade de espaço é quantidade de memória, ou espaço, necessária para executar um algoritmo.

A complexidade do espaço é um conceito paralelo à complexidade do tempo. Se precisarmos criar uma matriz de tamanho n, isso
requer O(n) de espaço. Se precisarmos de uma matriz bidimensional de tamanho n x n, isso exigirá O(n²).

### Big O, Big Ômega Ω e Big Teta Θ

Big O descreve o limite superior de tempo.

Big Ω, ômega, descreve o limite inferior de tempo.

Big Θ, teta, descreve quando Big Ômega e Big O são o mesmo valor.

### Melhor caso, pior caso e caso esperado

**Melhor caso** é o cenário mais rápido para resolvermos o algoritmo, por exemplo, em uma busca linear o valor à encontrar é o primeiro elemento então o melhor caso é o O(1) pois encontrará comparando apenas um valor. Na prática a industria não utiliza o melhor caso pois não há muito ganho em conhecer o melhor caso.

**Pior caso** é o cenário mais lento para resolvermos o algoritmo, por exemplo, em uma busca linear o valor à encontrar é o último ou não existe.

**Caso esperado** é o cenário esperado conhecendo a entrada, normalmente o pior e o melhor caso não acontecem com tanta frequência e sim o que é esperado do algoritmo e dos dados.

> Por exemplo, o quick sort teria o melhor caso como O(n), pior caso como O(n²) e o caso esperado é O(n log n)

### Valor mais significativo

Esqueça as constantes e os termos não dominantes.

Um algoritmo que poderia ser descrito como O(2n) é realmente O(n).

Um algoritmo que poderia ser descrito como O(45n³) + O(20n²) + O(19) é na verdade O(n3)

Vamos calcular o valor dessa equação, para entendermos na prática:

```math
45n³ + 20n² + 19
```

Para n = 1

```math
45(1)³ + 20(1)² + 19
45 + 20 + 19 = 84
```

Para n = 2

```math
45(2)³ + 20(2)² + 19
45(8) + 20(4) + 19
360 + 80 + 19 = 459
```

> Já podemos perceber que o valor 19 não tem tanta relevância para o valor final

Para n = 10

```math
45(10)³ + 20(10)² + 19
45(1000) + 20(100) + 19
45000 + 2000 + 19 = 47019
```

> Já comprovamos que o 19 não tem relevância quando aumentamos o valor de n e agora podemos perceber que até o n² não tem tanta relevância

Com o valor aumentando até o infinito  percebemos que o valor significativo da equação é o n³ já que até o 45 não é tão relevante para o valor final quanto é o n³. Resultando então em O(n³).

### Algoritmos com várias partes

Um conceito importante de destacar e que causa muitas é quando somamos ou multiplicamos os termos.

**Somamos o tempo de execução O(A + B):**

```csharp
foreach (var item in arrayA) 
{
    Console.WriteLine(item.toString());
}

foreach (var item in arrayB) 
{
    Console.WriteLine(item.toString());
}
```

**Multiplicamos o tempo de execução O(A * B):**

```csharp
foreach (var itemA in arrayA) 
{
    foreach (var itemB in arrayB) 
    {
        Console.WriteLine($"{itemA},{itemB}");
    }
}
```

### Tempo amortizado

Como calculamos a inserção de objetos dinâmicos? Por exemplo, listas são implementadas com array e quando o array chega na sua capacidade máxima, seu tamanho é dobrado. Como calculamos a inserção já que dependendo do caso a inserção terá o trabalho de aumentar o tamanho do array e outras vezes não.

O conceito de tempo amortizado leva em consideração esses dois casos, sabendo que a operação de dobrar o tamanho do array irá demorar para acontecer novamente então o custo dessa operação é amortizado. Podemos pensar que o custo é distribuído pelas demais operações

### Tempo de execução para Recursão

Qual o tempo de execução desse código:

```csharp
private int f(int n)
{
    if (n <= 1)
    {
        return 1;
    }

    return f(n - 1) + f(n - 1);
}
```

Muitas pessoas acreditam que é O(n²) por causa das duas chamadas, mas está errado.

Quando você tem uma função recursiva que faz várias chamadas, o tempo de execução frequentemente (mas nem sempre) se parece com O(profundidade dos níveis), isso nos dá O(2ⁿ).

### Tabela de Referências

#### Complexidade para estrutura de dados

| Estrutura de dados    | Tempo médio de Leitura    | Tempo médio de Busca  | Tempo médio de Inserção   | Tempo médio de Remoção    | Pior tempo de Leitura | Pior tempo de Busca   | Pior tempo de Inserção    |   Pior tempo de Remoção | Complexidade de Espaço |
|-----------------------|-----------|-----------|-----------|-----------|-----------|-----------|-----------|-----------|-----------|
| Array                 | Θ(1)      | Θ(n)      | Θ(n)      | Θ(n)      | O(1)      | O(n)      | O(n)      | O(n)      |O(n)       |
| Stack                 | Θ(n)      | Θ(n)      | Θ(1)      | Θ(1)      | O(n)      | O(n)      | O(1)      | O(1)      |O(n)       |
| Queue                 | Θ(n)      | Θ(n)      | Θ(1)      | Θ(1)      | O(n)      | O(n)      | O(1)      | O(1)      |O(n)       |
| Linked List           | Θ(n)      | Θ(n)      | Θ(1)      | Θ(1)      | O(n)      | O(n)      | O(1)      | O(1)      |O(n)       |
| Doubly Linked List    | Θ(n)      | Θ(n)      | Θ(1)      | Θ(1)      | O(n)      | O(n)      | O(1)      | O(1)      |O(n)       |
| Skip List             | Θ(log n)  | Θ(log n)  | Θ(log n)  | Θ(log n)  | O(n)      | O(n)      | O(n)      | O(n)      |O(n log n) |
| Hash Table            | -         | Θ(1)      | Θ(1)      | Θ(1)      | -         | O(n)      | O(n)      | O(n)      |O(n)       |
| Binary Search Tree    | Θ(log n)  | Θ(log n)  | Θ(log n)  | Θ(log n)  | O(n)      | O(n)      | O(n)      | O(n)      |O(n)       |
| B-Tree                | Θ(log n)  | Θ(log n)  | Θ(log n)  | Θ(log n)  | O(log n)  | O(log n)  | O(log n)  | O(log n)  | O(n)      |
| Red-Black Tree        | Θ(log n)  | Θ(log n)  | Θ(log n)  | Θ(log n)  | O(log n)  | O(log n)  | O(log n)  | O(log n)  |O(n)       |
| AVL Tree              | Θ(log n)  | Θ(log n)  | Θ(log n)  | Θ(log n)  | O(log n)  | O(log n)  | O(log n)  | O(log n)  |O(n)       |

#### Complexidade para algoritmos para ordenação de Arrays

|Algoritmo      | Melhor complexidade de tempo  | Complexidade de tempo média   | Pior complexidade de tempo    | Pior complexidade de Espaço   |
|---------------|-------------------------------|-------------------------------|-------------------------------|-------------------------------|
|Quicksort      | Ω((n log(n))                  | Θ(n log(n))                   | O(n²)                         | O(log (n))                    |
|Merge Sort      | Ω((n log(n))                  | Θ(n log(n))                   | O(n log(n))                   | O(n)                          |
|Bubble Sort    | Ω((n)                         | Θ(n²)                         | O(n²)                         | O(1)                          |
|Insertion Sort | Ω((n)                         | Θ(n²)                         | O(n²)                         | O(1)                          |
|Selection Sort | Ω((n²)                        | Θ(n²)                         | O(n²)                         | O(1)                          |
|Tim Sort        | Ω(n)                          | Θ((n log(n))                  | O(n log(n))                   | O(n)                          |
|Heap Sort       | Ω(n log(n))                   | Θ(n log(n))                   | O(n log(n))                   | O(1))                         |
|Tree Sort      | Ω(n log(n))                   | Θ(n log(n))                   | O(n^2)                        | O(n)                          |
|Shell Sort     | Ω(n log(n))                   | Θ(n(log(n))^2)                | O(n(log(n))^2)|O(1)           | O(1)                          |
|Bucket Sort    | Ω(n+k)                        | Θ(n+k)                        | O(n^2)                        | O(n)                          |
|Radix Sort     | Ω(nk)                         | Θ(nk)                         | O(nk)                         | O(n+k)                        |
|Counting Sort  | Ω(n+k)                        | Θ(n+k)                        | O(n+k)                        | O(k)                          |
|Cube Sort      | Ω(n)                          | Θ(n log(n))                   | O(n log(n))                   | O(n)                          |

# Estrutura de Dados

Estrutura de dados mais comuns

## Arrays

Um array é uma estrutura de dados que armazena uma coleção de elementos de tal forma que cada um dos elementos possa ser identificado por, pelo menos, um índice ou uma chave. Essa estrutura de dados também é conhecida como variável indexada, vetor (para array unidimensionais) e matriz (para array bidimensionais).

Array é uma área de memória contígua, ou seja ligada, o array "separa" uma área na memória para alocar seus elementos um seguido do outro. Cada elementos no array possui a mesma capacidade de memória ou espaço e são indexados por um valor inteiro normalmente iniciando de 0.

|                       |           |           |           |
|----------------------:|-----------| --------- |-----------|
|**Endereço de memória**| 200       | 201       | 202       |
| **Index**             | 0         | 1         | 2         |
| **Valor**             | 26        | 13        | 3         |

Um array possibilita armazenar diversas variáveis do mesmo tipo em uma mesma estrutura de dados, um array pode ser única dimensão, multidimensional ou jagged (denteada).

O valor padrão para array co tipos numéricos é 0 e para tipos de referência é null.

> Tipos de referência, podemos pensar em objetos e tipo numéricos como inteiro, float, double e etc

## Exemplos de código

Inicializar

```csharp
// Inicializar um array vazio
var array = new int[3];
// Inicializar um array com valores e o seu tamanho será a quantidade de elementos inicializados
var array = new int[] { 26, 13, 3};
int[] array = new int[] { 26, 13, 3};

```

Inserção em um array vazio

```csharp
var array = new int[4];
//Array vazio ou com valores padrões, somente inserir valores 
array[0] = 26;
array[1] = 13;
array[2] = 3;

// Se necessitamos inserir em outro lugar que não seja depois do último elemento inserido devemos deslocar todos os elementos para o próximo index
// Pois se tentarmos fazer o seguinte:
array[0] = 10;
// Iremos atualizar o valor do índice 0, podemos então criar um métdo para isso
// Esse método poderia receber como primeiro parâmetro o valor a ser inserido e o segundo a posição
private static void Insert(int value, int index) 
{
    // Devemos verificar se o array está cheio antes de inserir, mas para demonstrar a inserção vamos pular essa parte
    // Enquanto não chegarmos no final do array vamos guardar o valor atual em uma variável temporária e inserir o valor que queremos no lugar
    for (int i = index; i < array.Length; i++)
    {
        var temp = array[i];
        array[i] = value;
        value = temp;
    }
}
```

Atualização

```csharp
var array = new int[3];
// Atualizar um valor é somente inserir o novo valor no lugar do antigo
array[0] = 26;
array[0] = 10;
```

Remoção

```csharp
// Quando a instância de um array é criada todos os elementos são preenchidos com o valor padrão 0 ou null dependendo do tipo do array
// Para remover no final do array, ou o último valor preenchido, só precisamos atualizá-lo para o valor default

// Criando um array com um tipo referenciado com tamanho 6 [0-5]
var arrayStrings = new string[6];

arrayStrings[0] = "maça";
arrayStrings[1] = "banana";
arrayStrings[2] = "mamão";
// Preenchemos os 3 primeiros valores e o restante ainda está com o valor padrão
// ["maça", "banana", "mamão", null, null, null]
// Se queremos remover o "mamão" basta atualizá-lo para o valor default null
arrayStrings[2] = null;

// Criando um array com um tipo numérico com tamanho 6 [0-5]
var arrayIntegers = new int[6];

arrayIntegers[0] = 26;
arrayIntegers[1] = 13;
arrayIntegers[2] = 10;
// Preenchemos os 3 primeiros valores e o restante ainda está com o valor padrão
// [26, 13, 10, 0, 0, 0]
// Se queremos remover o 10 basta atualizá-lo para o valor default 0
arrayIntegers[2] = 0;

// Se quisermos remover um item que não for o último devemos mover todos os itens subsequentes para a posição anterior
// Por exemplo removendo o primeiro valor vamos percorrer todo array substituindo o valor da posição atual do array para o próximo
// Assim o array [26, 13] ficará [13] pois o 13 assumiu a posição anterior 0
var indexToRemove = 0;
arrayIntegers[indexToRemove] = 0;
// Trocando a posição atual até um item antes do final do array 
int i;
for ( i = indexToRemove; i < arrayIntegers.Length - 1; i++)
{
    arrayIntegers[i] = arrayIntegers[i + 1];
}
// Por fim o valor final que ficaria duplicado é removido
arrayIntegers[i]=0;
```

Verificar o tamanho do array

```csharp
var array = new int[] { 26, 13, 3};
var length = array.Length;

```

## Tempo para operações comuns

Tempo constante, O(1), para acesso de leitura ou escrita para qualquer elemento do array. Isso é possível por conhecermos o endereço de memória em que o elemento do array está;

Tempo linear, O(n), para adicionar ou remover um elemento no início ou no meio do array já que será necessário descolar ou outros elementos, no entanto, a mesma operação no final no array será O(1) pois para adicionar ou remover só é necessário atualizar o valor.

O grande valor de usar o array é para adicionar ou remover items no final e termos tempo de acesso constante.

## Dynamic Arrays

Também conhecidos como array redimensionável é a ideia de guardar um ponteiro para um array dinamicamente alocado e substituir para um novo array quando necessário.

Arrays dinâmicos é um tipo de dado abstrato que possuem as seguintes operações:

- Get



## Two Dimensional Arrays

## Multidimensional Arrays

## Jagged Arrays

Jagged Arrays é um array de arrays que possibilita termos diferente número de colunas para cada linha.

Inicializar o jagged array vazio

```csharp
// Jagged array com 3 linhas
int[][] jaggedArray = new int[3][];
// Especificando depois quantas colunas em cada linha
jaggedArray[0] = new int[5];
jaggedArray[1] = new int[4];
jaggedArray[2] = new int[2];
```

Inicializar o jagged array com elementos, linhas e colunas definidas

```csharp

int[][] jaggedArray3 =
{
    new int[] { 1, 3, 5, 7, 9 },
    new int[] { 0, 2, 4, 6 },
    new int[] { 11, 22 }
};
```

# Referências

<https://github.com/jwasham/coding-interview-university>
<https://www.geeksforgeeks.org/>
<https://www.amazon.com.br/Cracking-Coding-Interview-Programming-Questions/dp/0984782850>

## Referência Big O

<https://www.bigocheatsheet.com/>
<https://www.youtube.com/watch?v=UQzCFkRbIrE>
<https://www.youtube.com/watch?v=iOq5kSKqeR4>
<https://www.youtube.com/watch?v=V6mKVRU1evU>
<https://www.youtube.com/watch?v=CFElj9aqnrA&list=PL1BaGV1cIH4UhkL8a9bJGG356covJ76qN&index=1>

## Referência Array

<https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/arrays/>
<https://pt.wikipedia.org/wiki/Arranjo_(computa%C3%A7%C3%A3o)>
<https://www.geeksforgeeks.org/array-data-structure/>
<https://www.coursera.org/lecture/data-structures/arrays-OsBSF>
<https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/arrays/jagged-arrays>
