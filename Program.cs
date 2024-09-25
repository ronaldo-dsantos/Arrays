Console.Clear();

// Declarando um array e adicionando valores na inicialização
var meuArray = new int[5] { 1, 2, 3, 4, 5 }; 

// Adicionando valor na posição 0 do array
meuArray[0] = 12; 

// Exibindo valores do array de forma manual
Console.WriteLine(meuArray[0]);
Console.WriteLine(meuArray[1]);
Console.WriteLine(meuArray[2]);
Console.WriteLine(meuArray[3]);
Console.WriteLine(meuArray[4]);

// Exibindo valores do array utilizando o for para percorrer o array e o Length para verificar o tamanho do array
for (int index = 0; index < meuArray.Length; index++)
{
  Console.WriteLine(meuArray[index]);
}

// Exibindo valores do array utilizando o foreach, forma mais utilizada para percorrer arrays
foreach (var item in meuArray)
{
  Console.WriteLine(item);
}

// Arrays são reference type, se copiar um array para o outro conforme o exemplo comentado, quando mudar o valor de um dos arrays, o outro também terá o seu valor alterado
var primeiroArray = new int[4];
// var segundoArray = primeiroArray
var segundoArray = new int[4];

segundoArray[0] = primeiroArray[0];
primeiroArray[0] = 23;

Console.WriteLine(segundoArray[0]);

// Declarando um array e adicionando uma struct ao array com 5 posições
var funcionarios = new Funcionario[5];

// Adicionando valores na posição zero do array
funcionarios[0] = new Funcionario() { Id = 2579, Nome = "Ronaldo" };

// Exibindo valores do array de forma manual
Console.WriteLine(funcionarios[0].Id);
Console.WriteLine(funcionarios[0].Nome);

// Exibindo valores do array utilizando o foreach, forma mais utilizada para percorrer arrays
foreach (var funcionario in funcionarios)
{
  Console.WriteLine(funcionario.Id);
  Console.WriteLine(funcionario.Nome);
}

struct Funcionario
{
  public int Id { get; set; }
  public string Nome { get; set; }
}


