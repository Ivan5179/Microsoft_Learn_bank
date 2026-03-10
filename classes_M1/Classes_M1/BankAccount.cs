namespace Classes_M1;

public class BankAccount
{
    private static int s_nextAccountNumber = 1;
    public int AccountNumber;
    public double Balance = 0;
    public static double InterestRate; // Campos estáticos são acessados usando o nome da classe, não uma instância da classe, e são compartilhados entre todas as instâncias de uma classe. O valor de um campo estático é inicializado antes que uma instância da classe seja criada
    public string AccountType = "Checking";
    public readonly string CustomerId; // Campos somente leitura só podem receber um valor quando são declarados ou em um construtor.
    static BankAccount()
    {
        Random random = new Random();
        s_nextAccountNumber = random.Next(10000000, 20000000);
        InterestRate = 0;
    }

    public BankAccount(string customerIdNumber)
    {
        AccountNumber = s_nextAccountNumber++;
       CustomerId = customerIdNumber;
    }

    public BankAccount(string customerIdNumber, double balance, string accountType)
    {
        AccountNumber = s_nextAccountNumber++;
        CustomerId = customerIdNumber;
        Balance = balance;
        AccountType = accountType;
    }

}