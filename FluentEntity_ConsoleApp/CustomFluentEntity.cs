using FluentEntity_ConsoleApp.FEntity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace FluentEntity_ConsoleApp
{
    public class CustomFluentEntity<T> : FluentEntityBase<T>
        where T : class, new()
    {
        public CustomFluentEntity()
        {
        }

        public CustomFluentEntity(T entity) : base(entity)
        {
        }

        public override FluentEntityBase<T> AddParameter<P>(Expression<Func<T, P>> exp, object value)
        {
            //custom settings
            if (value.GetType() == typeof(int))
                Console.WriteLine($"integer--{value}--");
            if(value.GetType() == typeof(string))
                Console.WriteLine($"string--{value}--");
            return base.AddParameter(exp, value);
        }

        protected override void CheckExceptions(PropertyInfo propertyInfo)
        {
            //custom exceptions
            base.CheckExceptions(propertyInfo);
        }
    }
}
