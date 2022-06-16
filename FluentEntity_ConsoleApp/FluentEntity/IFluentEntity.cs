using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FluentEntity_ConsoleApp.FluentEntity
{
    public interface IFluentEntity<T>
    {
        IFluentEntity<T> AddParameter<P>(Expression<Func<T, P>> exp, object value);
        T GetEntity();
    }
}
