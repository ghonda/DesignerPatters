namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var livro = new Livro("João", "Design Patters", 10);
            livro.Exibe();

            var video = new Video("Rodrigo", "Video aulas avançadas", 20, 3);
            video.Exibe();


            var emprestado = new Emprestado(video);
            emprestado.EmprestarItem("Carlos");
            emprestado.EmprestarItem("Maria");

            emprestado.Exibe();

        }
    }
}
