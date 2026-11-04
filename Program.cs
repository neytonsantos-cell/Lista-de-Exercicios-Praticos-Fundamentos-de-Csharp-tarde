/*
Exercício 1 — Calculando uma compra
Uma papelaria deseja calcular o valor de uma compra.
Crie um programa que:
1. Solicite o nome de um produto, a quantidade comprada e o preço unitário.
2. Calcule o valor total da compra.
3. Exiba o nome do produto, a quantidade, o preço unitário e o valor total.
Utilize decimal para os valores monetários e apresente os resultados com duas
casas decimais.
*/
// Console.Write("Digite o nome do produto: ");
// string? nome = Console.ReadLine();

// Console.Write("Digite a quantidade comprada: ");
// int quantidade = int.Parse(Console.ReadLine());

// Console.Write("Digite o preço unitário: ");
// decimal preco = decimal.Parse(Console.ReadLine());

// decimal total = quantidade * preco;

// Console.WriteLine("");
// Console.WriteLine($"Produto: {nome}");
// Console.WriteLine($"Quantidade: {quantidade}");
// Console.WriteLine($"Preço unitário: {preco:F2}");
// Console.WriteLine($"Valor total: {total:F2}");

/*
Crie um programa que receba o nome de um aluno e sua nota, de 0 a 10.
Utilize as seguintes regras:

Nota Classificação
Maior ou igual a 7 Aprovado
Maior ou igual a 5 e menor que 7 Recuperação
Menor que 5 Reprovado

O programa deverá:
1. Solicitar o nome do aluno e sua nota.
2. Verificar se a nota está entre 0 e 10.
3. Apresentar a classificação correspondente ou informar que a nota é inválida.
*/
// int verificador = 0;
// do
// {
//     Console.WriteLine("");
//     Console.Write("Digite o nome do aluno: ");
//     string? nomeAluno = Console.ReadLine();

//     Console.Write("Digite a nota do aluno: ");
//     decimal nota = decimal.Parse(Console.ReadLine());

//     if (nota < 0 || nota > 10)
//     {
//         Console.WriteLine("Nota inválida. Por favor, digite uma nota entre 0 e 10.");
//     }
//     else if (nota >= 7)
//     {
//         Console.WriteLine($"Aluno: {nomeAluno} - Classificação: Aprovado");
//         verificador = 1; // Sair do loop após uma nota válida
//     }
//     else if (nota >= 5)
//     {
//         Console.WriteLine($"Aluno: {nomeAluno} - Classificação: Recuperação");
//         verificador = 1; // Sair do loop após uma nota válida
//     }
//     else
//     {
//         Console.WriteLine($"Aluno: {nomeAluno} - Classificação: Reprovado");
//         verificador = 1; // Sair do loop após uma nota válida
//     }
// } while (verificador == 0);

/*
Exercício 3 — Adivinhe o número
Crie um programa no qual o usuário deverá descobrir um número secreto
definido previamente no código.
O programa deverá:
1. Definir um número inteiro como número secreto.
2. Solicitar tentativas do usuário utilizando 'while'.
3. Informar se cada tentativa é menor ou maior que o número secreto.
4. Encerrar quando o usuário acertar.
5. Exibir a quantidade de tentativas realizadas.
Desafio adicional: adapte o programa para utilizar 'do while' em vez de 'while'.
*/

// int numeroSecreto = Random.Shared.Next(1, 101); 
// int tentativas = 0;
// int palpite;

// do
// {
//     Console.Write("Digite seu palpite: ");
//     palpite = int.Parse(Console.ReadLine());
//     tentativas++;

//     if (palpite < numeroSecreto)
//     {
//         Console.WriteLine("Seu palpite é menor que o número secreto.");
//     }
//     else if (palpite > numeroSecreto)
//     {
//         Console.WriteLine("Seu palpite é maior que o número secreto.");
//     }
//     else
//     {
//         Console.WriteLine($"Parabéns! Você acertou o número secreto em {tentativas} tentativas.");
//     }
// } while (palpite != numeroSecreto);

/*
Exercício 4 — Calculadora com métodos
Crie um programa que realize operações matemáticas utilizando métodos
próprios.
O programa deverá:
1. Criar um método chamado Somar que receba dois números e retorne a soma.
2. Criar um método chamado Multiplicar que receba dois números e retorne a multiplicação.
3. Solicitar dois números ao usuário.
4. Chamar os métodos e exibir os resultados.
*/
// int numero1, numero2;
// Console.Write("Digite o primeiro número: ");
// numero1 = int.Parse(Console.ReadLine());
// Console.Write("Digite o segundo número: ");
// numero2 = int.Parse(Console.ReadLine());

// decimal resultadoSoma = Somar(numero1, numero2);
// decimal resultadoMultiplicacao = Multiplicar(numero1, numero2);

// Console.WriteLine($"Soma: {resultadoSoma}");
// Console.WriteLine($"Multiplicação: {resultadoMultiplicacao}");

// // Método para somar dois números
// static decimal Somar(decimal a, decimal b)
// {
//     return a + b;
// }

// // Método para multiplicar dois números
// static decimal Multiplicar(decimal a, decimal b)
// {
//     return a * b;
// }

/*
Exercício 5 — Cadastro de notas em um array
Crie um programa que armazene 3 notas de um aluno em um array.
O programa deverá:
1. Declarar um array capaz de armazenar 3 notas.
2. Solicitar as 3 notas ao usuário e armazená-las no array.
3. Percorrer o array utilizando for e exibir todas as notas.
4. Percorrer novamente o array utilizando foreach e calcular a média das notas.
5. Exibir a média calculada.
*/

// int[] notas = new int[3];
// for (int i = 0; i < 3; i++)
// {
//     Console.Write($"Digite a {i + 1}ª nota: ");
//     notas[i] = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("Notas cadastradas:");
// for (int i = 0; i < 3; i++)
// {
//     Console.WriteLine($"Nota {i + 1}: {notas[i]}");
// }

// decimal soma = 0;
// foreach (int nota in notas)
// {
//     soma += nota;
// }
// decimal media = soma / 3;
// Console.WriteLine($"Média das notas: {media:F2}");

/*
Exercício 6 — Lista de produtos
Crie um programa que permita cadastrar nomes de produtos em uma lista
utilizando 'List<string>'.
O programa deverá:
1. Criar uma lista vazia de produtos.
2. Solicitar o nome de três produtos e adicioná-los utilizando 'Add()'.
3. Exibir todos os produtos cadastrados.
4. Solicitar o nome de um produto e verificar se ele está na lista.
5. Solicitar o nome de um produto e removê-lo.
6. Exibir a lista atualizada.
*/
// List<string> produtos = new List<string>();
// for (int i = 0; i < 3; i++)
// {
//     Console.Write($"Digite o nome do {i + 1}º produto: ");
//     produtos.Add(Console.ReadLine());
// }

// Console.WriteLine("Produtos cadastrados:");
// foreach (string produto in produtos)
// {
//     Console.WriteLine(produto);
// }

// Console.Write("Digite o nome de um produto para verificar se está na lista: ");
// string produtoVerificar = Console.ReadLine();
// if (produtos.Contains(produtoVerificar))
// {
//     Console.WriteLine("O produto está na lista.");
// }
// else
// {
//     Console.WriteLine("O produto não está na lista.");
// }

// Console.Write("Digite o nome de um produto para remover: ");
// string produtoRemover = Console.ReadLine();
// if (produtos.Contains(produtoRemover))
// {
//     produtos.Remove(produtoRemover);
//     Console.WriteLine("Produto removido com sucesso.");
// }
// else
// {
//     Console.WriteLine("O produto não está na lista.");
// }

// Console.WriteLine("Lista atualizada:");
// foreach (string produto in produtos)
// {
//     Console.WriteLine(produto);
// }