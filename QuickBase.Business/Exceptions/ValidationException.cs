using System;

namespace QuickBase.Business.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException()
        {
        }

        public ValidationException(EntityEnum entity)
        {
            Entity = entity;
        }

        public EntityEnum Entity { get; }
    }
}
