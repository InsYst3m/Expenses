using System;

namespace SqlWrapper
{
    public interface ISqlWrapper<T> : IDisposable
    {
        void Create(T data);
        void Read();
        void Update();
        void Delete();
    }
}
