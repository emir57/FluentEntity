using System;
using System.Collections.Generic;
using System.Text;

namespace FluentEntity_ConsoleApp.FEntity
{
    public class FluentEntity<T> : FluentEntityBase<T>
        where T : class, new()
    {
        public override FluentEntityBase<T> AddParameter<P>(System.Linq.Expressions.Expression<Func<T, P>> exp, object value)
        {
            return base.AddParameter(exp, value);
        }
    }
}
