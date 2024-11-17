namespace Aprendendo.Test;

public class ProgramTest
{
    [Fact]
    public void Test1()
    {
        /// expected é o valor esperado ao executar o programa(uma var) 
        string expected = "Programa exercutado com sucesso";
        /// StringWriter tem a função de armazenar a saída do nosso programa
        using (StringWriter saida = new StringWriter())
        {
            /// Aqui definimos que a saída do console será nosso StringWriter
            Console.SetOut(saida);
            /// Simulamos a chamada do nosso programa
            Aprendendo.Program.Main(null);
            /// Testamos se a saída do programa é a que esperamos
            Assert.Contains(expected, saida.ToString());
        }
    }
}