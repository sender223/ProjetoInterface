//CLASSE DO TIPO DOMINIO
using System.Globalization;

namespace ProjetoInterface.Entidades {
    class Fatura {

        //propriedades autocomplementadas
        public double PagamentoBasico { get; set; }
        public double Taxa { get; set; }

        //construtor padrão
        public Fatura (double pagamentoBasico, double taxa) {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
        }

        //propriedade calculada PagamentoTotal.
        public double PagamentoTotal {
            get { return PagamentoBasico + Taxa; }
        }

        //fazer o metodo ToString para retornar o resultado da classe
        public override string ToString() {
            return "Pagamento Basico: "
                + PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTaxa: "
                + Taxa.ToString("F2", CultureInfo.InvariantCulture)
                + "\nPagamentoTotal: "
                + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
