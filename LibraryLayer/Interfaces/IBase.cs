using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryLayer.Interfaces
{
    public interface IBase<T>
    {
        T get(int id);
        List<T> list();
        bool save(T obj);
    }
}
