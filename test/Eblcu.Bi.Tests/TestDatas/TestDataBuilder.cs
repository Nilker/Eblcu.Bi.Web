﻿using Eblcu.Bi.EntityFrameworkCore;

namespace Eblcu.Bi.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly BiDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(BiDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();
            new TestSubscriptionPaymentBuilder(_context, _tenantId).Create();

            _context.SaveChanges();
        }
    }
}
