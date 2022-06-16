using System;
using System.Collections.Generic;
using System.Text;

namespace FluentEntity_ConsoleApp.FEntity2
{
    public class FluentEntity2<T> : FluentEntityBase<T>
        where T : class, new()
    {
        public override FluentEntityBase<T> AddParameter<P>(System.Linq.Expressions.Expression<Func<T, P>> exp, object value)
        {
            //custom settings
            return base.AddParameter(exp, value);
        }
    }
}
