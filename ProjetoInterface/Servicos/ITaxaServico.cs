//CLASSE DO TIPO INTERFACE
namespace ProjetoInterface.Servicos {
    //a interface apenas define o "contrato".
    interface ITaxaServico {
        //criamos uma operação para receber o montante.
        double Taxa(double montante);
    }
}
