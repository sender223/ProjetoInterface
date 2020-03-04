//CLASSE DO TIPO DOMINIO
namespace ProjetoInterface.Entidades {
    class Veiculo {
        //propriedade autocomplementada
        public string Modelo { get; set; }

        //construtor padrão
        public Veiculo (string modelo) {
            Modelo = modelo;
        }
    }
}
