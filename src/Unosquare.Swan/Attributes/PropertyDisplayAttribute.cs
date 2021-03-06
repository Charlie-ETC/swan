﻿namespace Unosquare.Swan.Attributes
{
    using System;

    /// <summary>
    /// An attribute used to include additional information to a Property for serialization.
    /// Previously we used DisplayAttribute from DataAnnotation
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class PropertyDisplayAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the name of the group.
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or sets the default value.
        /// </summary>
        public object DefaultValue { get; set; }
    }
}
