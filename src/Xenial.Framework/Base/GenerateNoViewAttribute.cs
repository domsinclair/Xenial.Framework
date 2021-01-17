﻿using System;

namespace Xenial.Framework.Base
{
    /// <summary>
    /// Class GenerateNoDetailViewAttribute. This class cannot be inherited.
    /// Implements the <see cref="System.Attribute" />
    /// </summary>
    /// <seealso cref="System.Attribute" />
    /// <autogeneratedoc />
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed partial class GenerateNoDetailViewAttribute : Attribute { }

    /// <summary>
    /// Class GenerateNoLookupListViewAttribute. This class cannot be inherited.
    /// Implements the <see cref="System.Attribute" />
    /// </summary>
    /// <seealso cref="System.Attribute" />
    /// <autogeneratedoc />
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    [XenialCheckLicence]
    public sealed partial class GenerateNoLookupListViewAttribute : Attribute { }

    /// <summary>
    /// Class GenerateNoListViewAttribute. This class cannot be inherited.
    /// Implements the <see cref="System.Attribute" />
    /// </summary>
    /// <seealso cref="System.Attribute" />
    /// <autogeneratedoc />
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    [XenialCheckLicence]
    public sealed partial class GenerateNoListViewAttribute : Attribute { }

    /// <summary>
    /// Class GenerateNoViewAttribute. This class cannot be inherited.
    /// Implements the <see cref="System.Attribute" />
    /// </summary>
    /// <seealso cref="System.Attribute" />
    /// <autogeneratedoc />
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    [XenialCheckLicence]
    public sealed partial class GenerateNoViewAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateNoViewAttribute"/> class.
        /// </summary>
        /// <param name="viewId">The view identifier.</param>
        /// <autogeneratedoc />
        public GenerateNoViewAttribute(string viewId)
            => ViewId = viewId ?? throw new ArgumentNullException(nameof(viewId));

        /// <summary>
        /// Gets the view identifier.
        /// </summary>
        /// <value>The view identifier.</value>
        /// <autogeneratedoc />
        public string ViewId { get; }
    }
}
