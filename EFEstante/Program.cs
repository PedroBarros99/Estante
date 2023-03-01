using EFEstante.Data;
using EFEstante.Models;


using DBEstante context = new DBEstante();



Autor Pedro = new Autor()
{
    NomeAutor = "Pedro"
};

Livro oParaiso = new Livro()
{
    ISBN = 925868656,
    nomeLivro = "O Paraiso",
    precoLivro = (decimal)25.99,
    IDAutor = Pedro

};

context.Add(Pedro);
context.Add(oParaiso);

context.SaveChanges();
