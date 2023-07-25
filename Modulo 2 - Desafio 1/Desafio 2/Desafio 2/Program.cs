using Desafio_2.Desafio_2;

public class Program
{
    static void Main()
    {
        Conta conta = new Conta
        {
            Titular = "João da Silva",
            Saldo = 1500.00
        };

        Requisicao requisicaoXML = new Requisicao(Formato.XML);
        Requisicao requisicaoCSV = new Requisicao(Formato.CSV);
        Requisicao requisicaoPorcento = new Requisicao(Formato.PORCENTO);

        Servidor servidor = new Servidor();

        servidor.ProcessarRequisicao(requisicaoXML, conta);
        servidor.ProcessarRequisicao(requisicaoCSV, conta);
        servidor.ProcessarRequisicao(requisicaoPorcento, conta);
    }
}
