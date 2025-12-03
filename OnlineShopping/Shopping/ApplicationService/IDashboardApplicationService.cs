using OnlineShopping.Shopping.ViewModels;

namespace OnlineShopping.Shopping.ApplicationService
{
    public interface IDashboardApplicationService
    {
        Task<IQueryable<KpiDto>> Kpi();
    }
}
