﻿namespace AzureSearchToolkit.Request.Criteria
{
    /// <summary>
    /// Criteria that selects documents if they have any value
    /// in the specified field.
    /// </summary>
    public class ExistsCriteria : SingleFieldCriteria, INegatableCriteria
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExistsCriteria"/> class.
        /// </summary>
        /// <param name="field">Field that must exist for this criteria to be satisfied.</param>
        public ExistsCriteria(string field)
            : base(field)
        {
        }

        /// <inheritdoc/>
        public override string Name => "exists";

        /// <summary>
        /// Negate this Exists criteria by turning it into a Missing criteria.
        /// </summary>
        /// <returns>Missing criteria for this field.</returns>
        public ICriteria Negate()
        {
            return new MissingCriteria(Field);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Field} ne null";
        }
    }
}
