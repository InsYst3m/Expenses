using System;
using System.Collections.Generic;
using Expenses.API.Services;
using Microsoft.AspNetCore.Mvc;
using SqlWrapper.Models;

namespace Expenses.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpensesController : ControllerBase
    {
        private readonly IExpensesService _expensesService;

        public ExpensesController(IExpensesService expensesService)
        {
            _expensesService = expensesService;
        }

        [HttpPost]
        public IActionResult Set(Expense expense)
        {
            _expensesService.Add(expense);

            return Ok();
        }

        [HttpGet]
        public IEnumerable<Expense> Get()
        {
            return _expensesService.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public Expense Get(int id)
        {
            return _expensesService.Get(id);
        }

        [HttpGet]
        [Route("test")]
        public string Test()
        {
            return "test string";
        }
    }
}
