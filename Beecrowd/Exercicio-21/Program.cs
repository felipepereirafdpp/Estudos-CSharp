    int N;
    int[] vetorA;
    int[] vetorB;
    int[] vetorC;

    N = int.Parse(Console.ReadLine());
    vetorA = new int[N];
    vetorB = new int[N];
    vetorC = new int[N];

    string numerosVetA = Console.ReadLine();
    string numerosVetB = Console.ReadLine();

    string[] vet1 = numerosVetA.Split(" ");
    string[] vet2 = numerosVetB.Split(" ");

    for (int i = 0; i < N; i++)
    {
        vetorA[i] = int.Parse(vet1[i]);
        vetorB[i] = int.Parse(vet2[i]);
    }

    for (int i = 0; i < N; i++)
    {
        vetorC[i] = vetorA[i] + vetorB[i];
    }

    foreach(int numero in vetorC)
    {
        Console.Write(numero + " ");
    }