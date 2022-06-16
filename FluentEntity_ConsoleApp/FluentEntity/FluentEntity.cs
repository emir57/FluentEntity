using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace FluentEntity_ConsoleApp.FluentEntity
{
    public class FluentEntity<T> : IFluentEntity<T>
    {
        private T entity;
        public FluentEntity()
        {
            entity = new T();
        }
        public IFluentEntity<T> AddParameter<P>(Expression<Func<T, P>> exp, object value)
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
