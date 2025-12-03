using OnlineShopping.Shopping.Context;
using OnlineShopping.Shopping.ViewModels;

namespace OnlineShopping.Shopping.ApplicationService
{
    public class DashboardApplicationService : IDashboardApplicationService
    {
        private readonly ShoppingContext _shoppingContext;
        public DashboardApplicationService(ShoppingContext shoppingContext)
        {
            _shoppingContext = shoppingContext;
        }

        public async Task<IQueryable<KpiDto>> Kpi()
        {
            var result = new List<KpiDto>
            {
                new KpiDto
                {
                    totalProducts = 546,
                    totalUsers = 567,
                    totalOrders = 78,
                    totalSales = 456
                }
            }.AsQueryable();

            return result;
        }

    }
}
