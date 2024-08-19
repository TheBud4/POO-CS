using ApiBiblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAppBiblioteca.DataBase.Services;

public class LivroService {
    private readonly BibliotecaDbContext _context;

    public LivroService(BibliotecaDbContext context) {
        _context = context;
    }

    public async Task<List<Livro>> GetLivrosAsync() {
        return await _context.Livros.ToListAsync();
    }

    public async Task AddLivroAsync(Livro livro) {
        _context.Livros.Add(livro);
        await _context.SaveChangesAsync();
    }
}