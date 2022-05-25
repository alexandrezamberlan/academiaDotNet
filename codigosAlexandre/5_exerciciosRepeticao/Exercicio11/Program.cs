Console.WriteLine("11. Ler as notas de uma turma de alunos e ao final imprimir a nota "+
"mais alta, a nota mais baixa, a média aritmética da turma e a quantidade de"+
"alunos da turma. Usar -1 para encerrar a leitura.");

List<float> listaNotasTurma = new List<float>();
float nota;
float notaMaisBaixa;
float notaMaisAlta;
float mediaNotas;
int totalAlunos;

do {
    Console.Clear();
    Console.Write("Informe uma nota válida para aluno da turma ou -1 para encerrar: ");
    nota = float.Parse( Console.ReadLine() );
    if (nota == -1) {
        break;
    }
    if (nota >=0 && nota <= 10) {
        listaNotasTurma.Add(nota);
    } else {
        Console.Write("Nota inválida. Tecle algo para continuar!"); Console.ReadKey();
    }
} while (true);

listaNotasTurma.Sort(); //lista é ordenada
notaMaisBaixa = listaNotasTurma[0]; //o primeiro elemento da lista é o menor valor
notaMaisAlta = listaNotasTurma[ listaNotasTurma.Count - 1 ]; //último elemento da lista é o maior valor
totalAlunos = listaNotasTurma.Count; //o atributo Count devolve quantos elementos há na lista

float soma = 0;
for (int i = 0; i < totalAlunos; i++) {
    soma = soma + listaNotasTurma[i];
}

mediaNotas = soma / totalAlunos;

Console.WriteLine("Total de alunos na turma: " + totalAlunos);
Console.WriteLine("Média das notas da turma: " + mediaNotas);
Console.WriteLine("Menor nota da turma: " + notaMaisBaixa);
Console.WriteLine("Maior nota da turma: " + notaMaisAlta);
