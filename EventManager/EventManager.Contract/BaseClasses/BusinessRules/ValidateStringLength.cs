using System;
using System.Linq;

namespace EventManager.Contract.BaseClasses.BusinessRules
{
    public class ValidateStringLength : BusinessRule
    {
        private int minimalLength;
        private int maximalLength;

        public ValidateStringLength(string propertyName): this(propertyName, 0, 0)
        {
            
        }

        public ValidateStringLength(string propertyName, int minimalLength, int maximalLenth) : base(propertyName)
        {
            this.minimalLength = minimalLength;
            this.maximalLength = maximalLenth;
        }

        public ValidateStringLength(string propertyName, string errorMessage, int minimalLength, int maximalLenth)
            : this(propertyName, minimalLength,maximalLenth)
        {
            base.ErrorMessage = errorMessage;
        }

        public override bool Validate(BaseEntity businessObject)
        {
            var data = GetPropertyValue(businessObject) as string;
            if (string.IsNullOrEmpty(data))
            {
                return false;
            }
            return data.Length > minimalLength && data.Length < maximalLength;
        }
    }
}
