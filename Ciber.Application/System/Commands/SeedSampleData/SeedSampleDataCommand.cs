using Ciber.Application.Common.Interfaces;
using Ciber.Application.System.Commands.SeedSampleData;
using MediatR;


using System.Threading;
using System.Threading.Tasks;

namespace Northwind.Application.System.Commands.SeedSampleData
{
    public class SeedSampleDataCommand : IRequest
    {
    }

    public class SeedSampleDataCommandHandler : IRequestHandler<SeedSampleDataCommand>
    {
        private readonly ICiberDbContext _context;
        private readonly IUserManager _userManager;

        public SeedSampleDataCommandHandler(ICiberDbContext context, IUserManager userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<Unit> Handle(SeedSampleDataCommand request, CancellationToken cancellationToken)
        {
            var seeder = new SampleDataSeeder(_context, _userManager);

            await seeder.SeedAllAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
