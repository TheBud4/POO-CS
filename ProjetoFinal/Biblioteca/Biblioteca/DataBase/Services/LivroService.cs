using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.DataBase.Services;

public class LivroService(BibliotecaDbContext context) {
    
    //Create
    public async Task AddLivroAsync(Livro livro) {
        context.Livros.Add(livro);
        await context.SaveChangesAsync();
    }
    
    //Read
    public async Task<List<Livro>> GetLivrosAsync() {
        return await context.Livros.ToListAsync();
    }
    
    //Update
    //ToDo: Implementar método de atualização
    
    //Delete
    //ToDo: Implementar método de exclusão
}