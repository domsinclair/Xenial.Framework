﻿using System;

using Xenial.Framework.Base;

namespace Xenial.Framework.ModelBuilders
{
    public static partial class ModelBuilderExtensions
    {
        /// <summary>
        /// Generates the no detail view.
        /// </summary>
        /// <typeparam name="TClassType">The type of the t class type.</typeparam>
        /// <param name="modelBuilder">The model builder.</param>
        /// <returns>IModelBuilder&lt;TClassType&gt;.</returns>
        /// <exception cref="ArgumentNullException">modelBuilder</exception>
        /// <autogeneratedoc />
        public static IModelBuilder<TClassType> GenerateNoDetailView<TClassType>(
            this IModelBuilder<TClassType> modelBuilder
        )
        {
            _ = modelBuilder ?? throw new ArgumentNullException(nameof(modelBuilder));
            return modelBuilder.WithAttribute(new GenerateNoDetailViewAttribute());
        }

        /// <summary>
        /// Generates the no ListView.
        /// </summary>
        /// <typeparam name="TClassType">The type of the t class type.</typeparam>
        /// <param name="modelBuilder">The model builder.</param>
        /// <returns>IModelBuilder&lt;TClassType&gt;.</returns>
        /// <exception cref="ArgumentNullException">modelBuilder</exception>
        /// <autogeneratedoc />
        public static IModelBuilder<TClassType> GenerateNoListView<TClassType>(
            this IModelBuilder<TClassType> modelBuilder
        )
        {
            _ = modelBuilder ?? throw new ArgumentNullException(nameof(modelBuilder));
            return modelBuilder.WithAttribute(new GenerateNoListViewAttribute());
        }

        /// <summary>
        /// Generates the no lookup ListView.
        /// </summary>
        /// <typeparam name="TClassType">The type of the t class type.</typeparam>
        /// <param name="modelBuilder">The model builder.</param>
        /// <returns>IModelBuilder&lt;TClassType&gt;.</returns>
        /// <exception cref="ArgumentNullException">modelBuilder</exception>
        /// <autogeneratedoc />
        public static IModelBuilder<TClassType> GenerateNoLookupListView<TClassType>(
           this IModelBuilder<TClassType> modelBuilder
        )
        {
            _ = modelBuilder ?? throw new ArgumentNullException(nameof(modelBuilder));
            return modelBuilder.WithAttribute(new GenerateNoLookupListViewAttribute());
        }

        /// <summary>
        /// Generates the no view.
        /// </summary>
        /// <typeparam name="TClassType">The type of the t class type.</typeparam>
        /// <param name="modelBuilder">The model builder.</param>
        /// <param name="viewId">The view identifier.</param>
        /// <returns>IModelBuilder&lt;TClassType&gt;.</returns>
        /// <exception cref="ArgumentNullException">modelBuilder</exception>
        /// <exception cref="ArgumentNullException">viewId</exception>
        /// <autogeneratedoc />
        public static IModelBuilder<TClassType> GenerateNoView<TClassType>(
           this IModelBuilder<TClassType> modelBuilder,
           string viewId
        )
        {
            _ = modelBuilder ?? throw new ArgumentNullException(nameof(modelBuilder));
            _ = viewId ?? throw new ArgumentNullException(nameof(viewId));
            return modelBuilder.WithAttribute(new GenerateNoViewAttribute(viewId));
        }
    }
}
