//CLASSE DO TIPO SERVIÇO

namespace ProjetoInterface.Servicos {
    class TaxaServicoBrasil {

        public double Taxa(double montante) {
            //se o montante for abaixo de 100 reais
            if (montante <= 100.0) {
                //calcule o imposto sobre 20%
                return montante * 0.2;
            }
            else {
                //se não calcule o imposto sobre 15%
                return montante * 0.15;
            }
        }
    }
}
