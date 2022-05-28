using AutoMapper;
using AutoMapper.QueryableExtensions;
using AutoMapperQueryProjection.Repositories;
using AutoMapperQueryProjection.Resources;
using Microsoft.EntityFrameworkCore;

namespace AutoMapperQueryProjection.Services;

public interface IPersonService
{
    Task<List<PersonResponse>> GetAll();
}

public class PersonService : IPersonService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public PersonService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<PersonResponse>> GetAll()
    {
        return await _context.Person
            .Where(x => x.Name.Contains("Jul"))
            .OrderBy(x => x.Name)
            .ProjectTo<PersonResponse>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }
}