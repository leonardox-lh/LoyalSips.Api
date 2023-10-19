using LearningCenter2.API.Learning.Domain.Repositories;
using LearningCenter2.API.Shared.Persistence.Contexts;

namespace LearningCenter2.API.Shared.Persistence.Repositories;
//patron de unidad de trabajo
public class UnitOfWork : IUnitOfWork
{

    private readonly AppDbContext _context;
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    //metodo se utiliza para guardaar los cambios en la BD que se realizaro en el _conyext
    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }

}
