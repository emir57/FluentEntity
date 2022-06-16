﻿using FluentEntity_ConsoleApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace FluentEntity_ConsoleApp.FEntity
{
    public abstract class FluentEntityBase<T>
        where T : class, new()
    {
        protected T entity;
        public FluentEntityBase()
        {
            entity = new T();
        }
        public virtual FluentEntityBase<T> AddParameter<P>(Expression<Func<T, P>> exp, object value)
        {
            string propertyName = (exp.Body as MemberExpression).Member.Name;
            PropertyInfo propertyInfo = entity.GetType().GetProperty(propertyName);

            if (propertyInfo == null) throw new FluentException("Property Not Found");

            propertyInfo.SetValue(entity, value);
            return this;
        }
        public virtual FluentEntityBase<T> AddParameter(string propertyName, object value)
        {
            PropertyInfo propertyInfo = entity.GetType().GetProperty(propertyName);

            if (propertyInfo == null) throw new FluentException("Property Not Found");

            propertyInfo.SetValue(entity, value);
            return this;
        }

        public T GetEntity()
        {
            return entity;
        }
    }
}
