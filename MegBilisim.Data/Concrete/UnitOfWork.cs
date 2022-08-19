using MegBilisim.Data.Abstract;
using MegBilisim.Data.Concrete.EntityFramework.Contexts;
using MegBilisim.Data.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegBilisim.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private EfCompanyRepository _companyRepository;
        private EfDuesRepository _duesRepository;
        private EfElectricRepository _electricRepository;
        private EfRoleRepository _roleRepository;
        private EfSubscribeRepository _subscribeRepository;
        private EfUserRepository _userRepository;
        private EfWaterRepository _waterRepository;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public ICompanyRepository Companies => _companyRepository ?? new EfCompanyRepository(_context); 
        public IDuesRepository Dues => _duesRepository ?? new EfDuesRepository(_context);
        public IElectricRepository Electrics => _electricRepository ?? new EfElectricRepository(_context);
        public IRoleRepository Roles => _roleRepository ?? new EfRoleRepository(_context);
        public ISubscribeRepository Subscribies => _subscribeRepository ?? new EfSubscribeRepository(_context);
        public IUserRepository Users => _userRepository ?? new EfUserRepository(_context);
        public IWaterRepository Waters => _waterRepository ?? new EfWaterRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
