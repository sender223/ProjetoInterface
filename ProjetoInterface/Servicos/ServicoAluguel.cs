//CLASSE DO TIPO SERVIÇO

using System;
using ProjetoInterface.Entidades;

namespace ProjetoInterface.Servicos {
    class ServicoAluguel {

        //propriedade autocomplementada com trava para mudança
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }

        //criando uma dependencia do servicoAluguel com a TaxaServicoBrasil
        private TaxaServicoBrasil _taxaServicoBrasil = new TaxaServicoBrasil();

        //construtor padrão
        public ServicoAluguel(double precoPorHora, double precoPorDia) {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
        }

        //criando um metodo para processar a fatura.
        public void ProcessoFatura(AluguelDeCarros aluguelDeCarros) {
            //utilizamos o TimeSpan para calcular a duração do inicio e fim da locação
            TimeSpan duracao = aluguelDeCarros.Termino.Subtract(aluguelDeCarros.Inicio);
            //variavel pagamento basico que recebe 0.0 inicialmente.
            double pagamentoBasico = 0.0;
            //se a duração for menor que 12 horas
            if (duracao.TotalHours <= 12.0) {
                //pagamento base recebe o preço por hora * duração das horas arredondado pra cima
                //usando a classe Math com a propriedade Ceiling. 
                pagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else {
                //o pagamento base recebe o preço por dia * a duração arredondado pra cima
                pagamentoBasico = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }

            //calculando o valor do imposto
            //taxa recebe a variavel _taxaServicoBrasil pega a taxa e coloca como atributo
            //o pagamento basico que calculamos logo a cima. 
            double taxa = _taxaServicoBrasil.Taxa(pagamentoBasico);

            //agora instanciamos a Fatura pois ja temos o pagamento basico e a taxa
            aluguelDeCarros.Fatura = new Fatura(pagamentoBasico, taxa);

        }
    }
}
