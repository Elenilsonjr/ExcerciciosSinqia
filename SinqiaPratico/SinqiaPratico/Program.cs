namespace SinqiaPratico {
    internal class Program {
        static void Main(string[] args) 
            {
            Boletim aluno = new Boletim("Jaque", 1965, 13);
            aluno.adicionarMedias(4.0);
            aluno.adicionarMedias(3.0);
            aluno.adicionarMedias(5.9);
            aluno.adicionarMedias(6.5);
            aluno.adicionarMedias(4.0);
            aluno.adicionarMedias(6.0);
            //aluno.adicionarMedias(5.0); // não entra na condição, pois a lista so recebe 6 medias
            aluno.ListarMedias();                        
        }

    }
}