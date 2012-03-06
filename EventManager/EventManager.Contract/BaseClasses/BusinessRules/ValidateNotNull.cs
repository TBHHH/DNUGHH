using System;

namespace EventManager.Contract.BaseClasses.BusinessRules
{
    public class ValidateNotNull : BusinessRule
    {
        public ValidateNotNull(string propertyName) : base(propertyName)
        {
        }

        public ValidateNotNull(string propertyName, string errorMessage) : base(propertyName, errorMessage)
        {
        }

        public override bool Validate(BaseEntity businessObject)
        {
            var value = base.GetPropertyValue(businessObject);
            return value != null;
        }
    }
}