using Microsoft.AspNetCore.Mvc;
using Warsztat_v2.Data;
using Warsztat_v2.Repositories.Interfaces;

namespace Warsztat_v2.Views.Employee.Components
{
    public class EmployeeStatisticsViewComponent : ViewComponent
    {
        private readonly ServiceContext _context;
        private readonly IEmployeeRepository _repository;

        public EmployeeStatisticsViewComponent(ServiceContext context, IEmployeeRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        public IEmployeeRepository Repository { get; }

        public IViewComponentResult Invoke()
        {
            var viewModel = new EmployeeStatiscsViewModel
            {
                FinishedOrders = _repository.HowManyFinishedOrder(),
                EmployeeOfMonthName = _repository.DisplayName()
            };
            return View(viewModel);
        }
    }
}
