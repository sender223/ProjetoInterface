//CLASSE DO TIPO DOMINIO
using System;

namespace ProjetoInterface.Entidades {
    class AluguelDeCarros {

        //propriedade autocomplementada
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public Veiculo Veiculo { get; set; }
        public Fatura Fatura { get; set; }

        //construtor padrão
        public AluguelDeCarros(DateTime inicio, DateTime termino, Veiculo veiculo) {
            Inicio = inicio;
            Termino = termino;
            Veiculo = veiculo;
            Fatura = null;
        }
    }
}
