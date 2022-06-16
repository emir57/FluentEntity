using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace FluentEntity_ConsoleApp.FEntity2
{
    public abstract class FluentEntityBase<T>
        where T : class, new()
    {
        protected T entity;
        public FluentEntityBase()
        {
            entity = new T();
        }
        public FluentEntityBase<T> AddParameter<P>(Expression<Func<T, P>> exp, object value)
        {
            string propertyName = (exp.Body as MemberExpression).Member.Name;
            PropertyInfo propertyInfo = entity.GetType().GetProperty(propertyName);
            propertyInfo.SetValue(entity, value);
            return this;
        }

        public T GetEntity()
        {
            return entity;
        }
    }
}
