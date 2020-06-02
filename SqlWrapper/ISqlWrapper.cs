using SqlWrapper.Models;
using System;
using System.Collections.Generic;

namespace SqlWrapper
{
    public interface ISqlWrapper : IDisposable
    {
        void Create(Expense data);
        Expense Read(int id);
        IList<Expense> Read();
        void Update(Expense data);
        void Delete(Expense data);
    }
}
