﻿using System;

using Xenial.Framework.StepProgressEditors.Model.GeneratorUpdaters;

namespace DevExpress.ExpressApp.Model.Core
{
    /// <summary>
    /// Class StepProgressBarEnumModelGeneratorUpdaterExtentions.
    /// </summary>
    public static partial class StepProgressBarEnumModelGeneratorUpdaterExtentions
    {
        /// <summary>
        /// Uses the detail view layout builders.
        /// </summary>
        /// <param name="updaters">The updaters.</param>
        /// <returns>ModelNodesGeneratorUpdaters.</returns>
        public static ModelNodesGeneratorUpdaters UseStepProgressEnumPropertyEditors(this ModelNodesGeneratorUpdaters updaters)
        {
            _ = updaters ?? throw new ArgumentNullException(nameof(updaters));

            updaters.Add(new StepProgressBarEnumModelGeneratorUpdater());

            return updaters;
        }
    }
}