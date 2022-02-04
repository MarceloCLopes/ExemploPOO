using ExemploPOO.Helper;

namespace ExemploPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\Users\\marc0\\OneDrive\\Documentos\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");

            var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3"};
            var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

            FileHelper helper = new();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);

            //Console.WriteLine("Criando diretório: " + caminhoPathCombine);
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarArquivoTexto(caminhoArquivo, "Olá Teste de escrita de arquivo");
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            //helper.LerArquivoStream(caminhoArquivo);
            //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);

            //ICalculadora calc = new Calculadora();
            //Console.WriteLine(calc.Dividir(10, 2));

            //Computador comp = new();
            //Console.WriteLine(comp.ToString());

            //Corrente c = new();
            //c.Creditar(100);

            //c.ExibirSaldo();

            //Calculadora calc = new Calculadora();
            //Console.WriteLine("Resultado da primeira soma: " + calc.Somar(1, 1));
            //Console.WriteLine("Resultado da segunda soma: " + calc.Somar(1, 1, 2));

            //Aluno p1 = new()
            //{               
            //    Nome = "Marcelo",
            //    Idade = 20,
            //    Documento = "123456",
            //    Nota = 9,
            //};

            //p1.Apresentar();

            //Professor p2 = new()
            //{
            //    Salario = 20000,
            //    Nome = "Marcelo",
            //    Idade = 20,
            //    Documento = "123456",
            //};

            //p2.Apresentar();


            // Valores validos
            //Retangulo r = new();
            //r.DefinirMedidas(30, 30);

            //Console.WriteLine($"Área: {r.ObterArea()}");

            //// Valores inválidos
            //Retangulo r2 = new();
            //r2.DefinirMedidas(0, 0);

            //Console.WriteLine($"Área: {r2.ObterArea()}");

            //Pessoa p1 = new()
            //{
            //    Nome = "Bob",
            //    Idade = 20
            //};

            //p1.Apresentar();
        }
    }
}

