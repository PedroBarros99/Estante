using EFEstante.Data;
using EFEstante.Models;


using DBEstante context = new DBEstante();

Livro joaoLindao = new Livro()
{
    ISBN = 9726629055,
    nomeLivro = "O João Lindão",
    IDAutor = 3,
    precoLivro = 13.50M
};
context.Livros.Add(joaoLindao);

context.SaveChanges();
