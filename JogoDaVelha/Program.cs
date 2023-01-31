namespace JogoDaVelha;
public class Program
{
    static char[] tabela = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int jogador = 1; 
    static int posicao; 
    static int temGanhador = 0;

    private static void Quadro()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", tabela[1], tabela[2], tabela[3]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", tabela[4], tabela[5], tabela[6]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", tabela[7], tabela[8], tabela[9]);
        Console.WriteLine("     |     |      ");
    }
    
    private static int Vencedor()
    {
        #region Horzontal Winning Condtion
     
        if (tabela[1] == tabela[2] && tabela[2] == tabela[3])
        {
            return 1;
        }
       
        else if (tabela[4] == tabela[5] && tabela[5] == tabela[6])
        {
            return 1;
        }
       
        else if (tabela[6] == tabela[7] && tabela[7] == tabela[8])
        {
            return 1;
        }
        #endregion
        #region vertical Winning Condtion
        
        else if (tabela[1] == tabela[4] && tabela[4] == tabela[7])
        {
            return 1;
        }
        
        else if (tabela[2] == tabela[5] && tabela[5] == tabela[8])
        {
            return 1;
        }
       
        else if (tabela[3] == tabela[6] && tabela[6] == tabela[9])
        {
            return 1;
        }
        #endregion
        #region Diagonal Winning Condition
        else if (tabela[1] == tabela[5] && tabela[5] == tabela[9])
        {
            return 1;
        }
        else if (tabela[3] == tabela[5] && tabela[5] == tabela[7])
        {
            return 1;
        }
        #endregion
        #region Checking For Draw
       
        else if (tabela[1] != '1' && tabela[2] != '2' && tabela[3] != '3' && tabela[4] != '4' && tabela[5] != '5' && tabela[6] != '6' && tabela[7] != '7' && tabela[8] != '8' && tabela[9] != '9')
        {
            return -1;
        }
        #endregion
        else
        {
            return 0;
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("***JOGO DA VELHA***");
        Console.WriteLine();
        Console.Write("Nome do jogador 1: ");
        string jogadorUm = Console.ReadLine();
        Console.Write("Nome do jogador 2: ");
        string jogadorDois = Console.ReadLine();
        do
        {
            
            Console.Clear();
            Console.WriteLine("***JOGO DA VELHA***");
            Console.WriteLine();
            Console.WriteLine("Para jogar escreva o número da tabela na posição desejada");
            Console.WriteLine($"{jogadorUm} você será o Jogador 1 e usará o 'X' \n{jogadorDois} você será o Jogador 2 e usará o 'O'");
            Console.WriteLine("\n");
            if (jogador % 2 == 0)
            {
                Console.WriteLine($"Vez do(a) {jogadorDois} 2");
            }
            else
            {
                Console.WriteLine($"Vez do(a) {jogadorUm} 1");
            }
            Console.WriteLine("\n");
            Quadro();
            posicao = int.Parse(Console.ReadLine());
                        
            if (tabela[posicao] != 'X' && tabela[posicao] != 'O')
            {
                if (jogador % 2 == 0) 
                {
                    tabela[posicao] = 'O';
                    jogador++;
                }
                else
                {
                    tabela[posicao] = 'X';
                    jogador++;
                }
            }
            else
    
            {
                Console.WriteLine("Desculpe, o numero {0} ja está marcado com {1}. Tente novamente", posicao, tabela[posicao]);
              
                Thread.Sleep(2000);
            }
            temGanhador = Vencedor();
        }
        while (temGanhador != 1 && temGanhador != -1);
        
        Console.Clear();
        Quadro();
        if (temGanhador == 1)
      
        {
            Console.WriteLine("Jogador {0} ganhou!", (jogador % 2) + 1);
        }
        else
        {
            Console.WriteLine("Empatou!");
        }
        Console.ReadLine();
    }
    





}