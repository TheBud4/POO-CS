using ApiBiblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoFinal.DataBase.Services;

public class LivroService(BibliotecaDbContext context) {
    public async Task<List<Livro>> GetLivrosAsync() {
        return await context.Livros.ToListAsync();
    }
    public async Task AddLivroAsync(Livro livro) {
        context.Livros.Add(livro);
        await context.SaveChangesAsync();
    }
}