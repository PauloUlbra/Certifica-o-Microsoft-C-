// iniciando as variáveis
int notasAtuais = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

// Criando as variáveis que vão armazenar as somas
int somaSophia = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int somaNicolas = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int somaZahirah = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int somaJeong = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

// Criando e inicializando as variáveis que armazenam o cálculo da média
decimal notaSophia = (decimal)somaSophia / notasAtuais;
decimal notaNicolas = (decimal)somaNicolas / notasAtuais;
decimal notaZahirah = (decimal)somaZahirah / notasAtuais;
decimal notaJeong = (decimal)somaJeong / notasAtuais;

// Imprimindo as notas dos alunos no terminal
Console.WriteLine("Estudante\t\tNota:\n");
Console.WriteLine("Nota da Sophia:\t\t " + notaSophia + "\tA");
Console.WriteLine("Nota do Nicolas:\t " + notaNicolas + "\tB");
Console.WriteLine("Nota da Zanirah:\t " + notaZahirah + "\tB");
Console.WriteLine("Nota da Jeon:\t\t " + notaJeong + "\tA");