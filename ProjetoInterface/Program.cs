using System;
using System.Globalization;
using ProjetoInterface.Entidades;
using ProjetoInterface.Servicos;

namespace ProjetoInterface {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com os dados do Aluguel: ");
            Console.Write("Modelo do Carro: ");
            //digita o modelo do carro
            string modelo = Console.ReadLine();
            Console.Write("Data de Inicio do Aluguel: (dd/MM/yyyy hh:mm): ");
            //digita a data de inicio especificando o formato da data com o ParseExact
            DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Data de Termino do Aluguel: (dd/MM/yyyy hh:mm): ");
            DateTime termino = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            //solicitamos para digitar o valor por hora 
            Console.Write("Entre com o valor por Hora: ");
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //solicitamos para digitar o valor por dia
            Console.Write("Entre com o valor por Dia: ");
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();


            //iremos instanciar a classe AluguelDeCarros.
            //colocando como atributos, o inicio, o termino e instanciando a classe Veiculo(colocando o modelo do mesmo)
            AluguelDeCarros aluguelDeCarros = new AluguelDeCarros(inicio, termino, new Veiculo(modelo));

            //instanciamos o ServicoAluguel e atribuimos os valores hora e dia, e instanciamos a taxa que do país desejado
            ServicoAluguel servicoAluguel = new ServicoAluguel(hora, dia, new TaxaServicoBrasil());

            //finalizando usamos a variavel servicoAluguel e chamando o metodo ProcessoFatura colocando os atributos aluguelCarro
            //aqui tem que gerar  objeto Fatura e associar ela ao aluguelDeCarros.
            servicoAluguel.ProcessoFatura(aluguelDeCarros);

            Console.WriteLine("FATURA: ");
            Console.WriteLine(aluguelDeCarros.Fatura);
        }
    }
}
