Console.Clear();

int diaNascimento, mesNascimento;

Console.WriteLine("--- Noite de Terror ---");
Console.WriteLine("");

Console.Write("Qual o mês de nascimento da vítima (1 a 12): ");
mesNascimento = int.Parse(Console.ReadLine()!);

// Validando se o mês é válido
if (mesNascimento < 1 || mesNascimento > 12)
{
    Console.WriteLine("Mês inválido!");
    return;
}

Console.Write("Qual o dia de nascimento da vítima (1 a 31): ");
diaNascimento = int.Parse(Console.ReadLine()!);
Console.WriteLine("");

// Validando se o dia é válido
if (diaNascimento < 1 || diaNascimento > 31)
{
    Console.WriteLine("Dia inválido!");
    return;
}

string nomeMonstro = "";

switch (mesNascimento)
{
    case 1:
        nomeMonstro = "O Zumbi";
        break;
    case 2:
        nomeMonstro = "O Assassino";
        break;
    case 3:
        nomeMonstro = "O Psicopata";
        break;
    case 4:
        nomeMonstro = "O Alienígena";
        break;
    case 5:
        nomeMonstro = "O Carniceiro";
        break;
    case 6:
        nomeMonstro = "O Matador";
        break;
    case 7:
        nomeMonstro = "O Vampiro";
        break;
    case 8:
        nomeMonstro = "O Maluco";
        break;
    case 9:
        nomeMonstro = "O Vingador";
        break;
    case 10:
        nomeMonstro = "O Monstro";
        break;
    case 11:
        nomeMonstro = "O Bruxo";
        break;
    case 12:
        nomeMonstro = "O Demônio";
        break;
}

string[] sobrenomes = {
    "Endiabrado", "Radioativo", "Endemoniado", "Vermelho", "Possuído",
    "Macabro", "Sombrio", "Sem Cabeça", "Desconhecido", "Inconsciente",
    "Oculto", "Esquecido", "Lúgubre", "Invocado", "Caído",
    "Costurado", "Amaldiçoado", "Anormal", "Perturbado", "Sanguinário",
    "Tenebroso", "Imortal", "Ressuscitado", "do Pântano", "da Encruzilhada",
    "do Porão", "do Velho Poço", "sem Perdão", "do Cemitério", "da Meia-Noite",
    "da Lua Cheia"
};

string sobrenome = sobrenomes[diaNascimento - 1];

Console.WriteLine($"Fuja! Lá vem {nomeMonstro} {sobrenome}!");