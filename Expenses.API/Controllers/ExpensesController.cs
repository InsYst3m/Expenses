using System.Collections.Generic;
using Expenses.Domain.Entities;
using Expenses.Domain.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace Expenses.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpensesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExpensesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public IActionResult Set(Expense expense)
        {
            _unitOfWork.Expenses.Add(expense);

            return Ok();
        }

        [HttpGet]
        public IEnumerable<Expense> Get()
        {
            return _unitOfWork.Expenses.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public Expense Get(int id)
        {
            return _unitOfWork.Expenses.Get(id);
        }

        [HttpGet]
        [Route("test")]
        public string Test()
        {
            return "test string";
        }
    }
}
