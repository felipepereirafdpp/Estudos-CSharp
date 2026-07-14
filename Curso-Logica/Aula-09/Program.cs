using Aula_09;


//int M, N;

//string[] vet = Console.ReadLine().Split(" ");
//M = int.Parse(vet[0]);
//N = int.Parse(vet[1]);

//int[,] A = new int[M, N];

//// Percorre todas as linhas da matriz.
//// A variável 'i' representa o índice da linha atual.
//for (int i = 0; i < M; i++)
//{
//    // Lê uma linha inteira digitada pelo usuário
//    // e separa os valores pelo espaço.
//    string[] dados = Console.ReadLine().Split(" ");

//    // Percorre todas as colunas da linha atual.
//    // A variável 'x' representa o índice da coluna.
//    for (int x = 0; x < N; x++)
//    {
//        // Converte o valor da posição 'x' para inteiro
//        // e armazena na posição correspondente da matriz.
//        //
//        // Exemplo:
//        // Entrada: 10 20 30
//        //
//        // x = 0 -> A[i,0] = 10
//        // x = 1 -> A[i,1] = 20
//        // x = 2 -> A[i,2] = 30
//        A[i, x] = int.Parse(dados[x]);
//    }
//}


//// Percorre todas as linhas da matriz.
//// A variável 'i' representa a linha atual.
//for (int i = 0; i < M; i++)
//{
//    // Percorre todas as colunas da linha atual.
//    // A variável 'x' representa a coluna atual.
//    for (int x = 0; x < N; x++)
//    {
//        // Exibe o valor armazenado na posição [i, x]
//        // seguido de um espaço para separar os elementos.
//        Console.Write(A[i, x] + " ");
//    }

//    // pula para a próxima linha da saída.
//    Console.WriteLine();
//}
//Console.WriteLine("|---------------------Exercicio 01---------------------|");
//Exercicio01 exercicio01 = new Exercicio01();
//exercicio01.Executar();
Console.WriteLine("|---------------------Exercicio 02---------------------|");
Exercicio02 exercicio02 = new Exercicio02();
exercicio02.Executar();
Console.ReadLine();