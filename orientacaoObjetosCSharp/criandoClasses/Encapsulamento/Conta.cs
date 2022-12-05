using System;

//Sempre começamos uma classe, informando qual o seu namespace
namespace ContasBancarias
{
    public class ContaBancaria
    {
        public string NumeroConta = string.Empty;
        public DateTime DataAberturaConta;
        public double SaldoConta;
        public static double TaxaRendimentoPoupanca = 1;
        /*
        public void InformacoesDaConta()
        {
            Console.WriteLine($"Conta Nº:         {NumeroConta}");
            Console.WriteLine($"Data de Abertura: {DataAberturaConta.ToString("dd/mm/yyyy")}");
            Console.WriteLine($"Saldo:            {SaldoConta.ToString("C")}");
        }
        */

        //Método Construtor: Responsável por realizar o instanciamento da classe, definindo os valores padrões para cada um de seus atributos e métodos.
        public ContaBancaria()
        {
            //Instancia um objeto da classe Random, para que seja possível utilizar o método que gera inteiros aleatórios
            Random numeroContaRandom = new Random();
            //Gera um inteiro aleatório, converte ele para String e seleciona apenas os 6 primeiros números, após isso, armazena essa informação na variável NumeroConta. 
            NumeroConta = numeroContaRandom.Next().ToString().Substring(0,6);
            DataAberturaConta = DateTime.Now;
            SaldoConta = 0;
        }
        
        public ContaBancaria(string numeroConta, DateTime dataAberturaConta, double saldoConta)
        {
            NumeroConta = numeroConta;
            DataAberturaConta = dataAberturaConta;
            SaldoConta = saldoConta;
        }

        public string InformacoesDaConta()
        {
            return $" Conta N:          { NumeroConta }{ Environment.NewLine }" +
                   $" Data de Abertura: { DataAberturaConta }{ Environment.NewLine }" +
                   $" Saldo Atual:      { SaldoConta.ToString("C")}{ Environment.NewLine }"+
                   "---------------------------------------------------------------";
        }

        public void DepositarValor (double valorDepositado)
        {
            SaldoConta += valorDepositado;
            Console.WriteLine($"Depósito de {valorDepositado.ToString("C")}, realizado com sucesso!");
            Console.WriteLine($"Saldo atual de: {SaldoConta.ToString("C")}");

        }

        public void SacarValor (double valorSacado)
        {
            if (SaldoConta < valorSacado)             
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine($"É impossível realizar o saque de { valorSacado.ToString("C")}, pois não há saldo em conta!");
                Console.WriteLine($"Saldo atual de: {SaldoConta.ToString("C")}");
                Console.WriteLine("---------------------------------------------------------");
            }
            else
            {
                SaldoConta -= valorSacado;
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine($"Saque de {valorSacado.ToString("C")}, realizado com sucesso!");
                Console.WriteLine($"Saldo atual de: {SaldoConta.ToString("C")}");
                Console.WriteLine("---------------------------------------------------------");
            }
        }

        public void RealizarEmprestimo (double valorEmprestimo) 
        {
            SaldoConta += valorEmprestimo;
            Console.WriteLine("Empréstimo realizado com sucesso!"); 
            Console.WriteLine($"O valor de { valorEmprestimo.ToString("C")} foi adicionado a sua conta! "); 
            Console.WriteLine($"Saldo atual de: {SaldoConta.ToString("C")}");
            Console.WriteLine("---------------------------------------------------------");
        }

        //Sobrecarga do método anterior
        public void RealizarEmprestimo(double valorEmprestimo, int numeroParcelas)
        {
            SaldoConta += valorEmprestimo;
            Console.WriteLine("Empréstimo realizado com sucesso!"); 
            Console.WriteLine($"O valor de { valorEmprestimo.ToString("C")} foi adicionado a sua conta! ");
            Console.WriteLine($"O pagamento acontecerá em { numeroParcelas } vezes.");
            Console.WriteLine($"Saldo atual de: {SaldoConta.ToString("C")}");
            Console.WriteLine("---------------------------------------------------------");
        }

        //Métodos estáticos são aqueles que pertencem a classe, porém não precisam de uma instancia da classe para existir. 
        //Ou seja, são acessados a partir da própria definição da classe. 
        //Por isso deve ser um método que diz respeito a classe e é aplicácel a todos os objetos

        public static double CalcularRendimento(double capital, int periodo)
        {
            return capital * Math.Pow(1 + TaxaRendimentoPoupanca, periodo);
        }
    }

    public class ClienteBanco
    {
        public string NomeCliente = string.Empty;

        //Criar atributos (quando é privado) e propriedades (quando é público), nos permite encapsular o acesso direto, criando assim uma interface de comunicação do atributo com o mundo externo. 
        private string cpfCliente;
        public string CPFCliente
        {
            //Retirando os pontos e traços que o usuário pode inserir. 
            get { return cpfCliente.Replace(".", "").Replace("-", ""); } //Leitura
            //Value: Parâmetro oculto, que é o próprio valor atribuido a variável. 
            set { cpfCliente = value; }
        }


        public ClienteBanco(string nomeCliente, string _cpfCliente)
        {
            NomeCliente = nomeCliente;
            cpfCliente = _cpfCliente;
        }

        public string InformacoesDoCliente()
        {
            return $" Nome:          { NomeCliente }{ Environment.NewLine }" +
                   $" CPF:           { CPFCliente }{ Environment.NewLine }" +            
                   "---------------------------------------------------------------";
        }

    }
}



