using Cemiterio;

Registro[] registros = new Registro[10];
bool loop = true; 

for (int i = 0; i < registros.Length; i++)
{
    registros[i] = new Registro();
}

while (loop)
{
    Console.WriteLine("Bem-vindo ao cemitério Morada da Paz\n Selecione uma das opções do menu:\n 1 - Enterro\n 2 - Conferir disponibilidade de cova\n 3 - Sair");
    string opcaoMenu = Console.ReadLine();

    if (opcaoMenu == "1")
    {
        bool achouCova = false;
        for (int i = 0; i < registros.Length; i++)
        {
            if (registros[i].Nome == null)
            {
                Console.Clear();
                achouCova = true;
                registros[i].Enterro(i);
                break;
            }
        }
        if (achouCova == false)
        {
            Console.Clear();
            Console.WriteLine("Não existe espaço disponível\n");
        }
    }
    if (opcaoMenu == "2")
    {
        for (int i = 0; i < registros.Length; i++)
        {
            Console.Clear();
            Console.WriteLine($"Nome: {registros[i].Nome} - Ano da morte {registros[i].AnoMorte} - Cova {registros[i].Cova}");
        }
    }
    if (opcaoMenu == "3")
    {
        Console.WriteLine("Obrigado por se enterrar aqui!");
        break;
    }
    else
    {
        Console.WriteLine("Selecione uma das opções do menu");
    }
}