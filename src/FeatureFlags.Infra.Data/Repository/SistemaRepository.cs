using Microsoft.EntityFrameworkCore;
using UnimedFESP.Domain.Core.Data;
using FeatureFlags.Domain.Entities;
using FeatureFlags.Domain.Repository.Interface;
using FeatureFlags.Infra.Data.Context;

namespace FeatureFlags.Infra.Data.Repository
{
    public class SistemaRepository : RepositoryBase<Sistema>, ISistemaRepository
    {
        protected new readonly FeatureFlagContext _context;
        private new readonly DbSet<Sistema> _dbSet;

        public SistemaRepository(FeatureFlagContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<Sistema>();
        }

        public IUnitOfWork UnitOfWork => _context;
    }
}
