using Eblcu.Bi.EntityFrameworkCore;

namespace Eblcu.Bi.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly BiDbContext _context;

        public InitialHostDbBuilder(BiDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
