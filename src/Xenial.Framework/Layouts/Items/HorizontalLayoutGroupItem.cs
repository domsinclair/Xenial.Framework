﻿
using DevExpress.ExpressApp.Layout;

using Xenial.Framework.Layouts.Items.Base;

namespace Xenial.Framework.Layouts.Items
{
    /// <summary>
    /// 
    /// </summary>
    [XenialCheckLicence]
    public partial record HorizontalLayoutGroupItem : LayoutGroupItem
    {
        private const FlowDirection defaultFlowDirection = FlowDirection.Horizontal;

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>Xenial.Framework.Layouts.Items.LayoutGroupItem.</returns>
        /// <autogeneratedoc />
        public static new HorizontalLayoutGroupItem Create()
            => new();

        /// <summary>
        /// Creates the specified nodes.
        /// </summary>
        /// <param name="nodes">The nodes.</param>
        /// <returns>Xenial.Framework.Layouts.Items.LayoutGroupItem.</returns>
        /// <autogeneratedoc />
        public static new HorizontalLayoutGroupItem Create(params LayoutItemNode[] nodes)
            => Create() with { Children = new(nodes) };

        /// <summary>
        /// Creates the specified caption.
        /// </summary>
        /// <param name="caption">The caption.</param>
        /// <returns>Xenial.Framework.Layouts.Items.LayoutGroupItem.</returns>
        /// <autogeneratedoc />
        public static new HorizontalLayoutGroupItem Create(string caption)
            => new(caption);

        /// <summary>
        /// Creates the specified caption.
        /// </summary>
        /// <param name="caption">The caption.</param>
        /// <param name="nodes">The nodes.</param>
        /// <returns>Xenial.Framework.Layouts.Items.LayoutGroupItem.</returns>
        /// <autogeneratedoc />
        public static new HorizontalLayoutGroupItem Create(string caption, params LayoutItemNode[] nodes)
            => Create(caption) with { Children = new(nodes) };

        /// <summary>
        /// Creates the specified caption.
        /// </summary>
        /// <param name="caption">The caption.</param>
        /// <param name="imageName">Name of the image.</param>
        /// <returns>Xenial.Framework.Layouts.Items.LayoutGroupItem.</returns>
        /// <autogeneratedoc />
        public static new HorizontalLayoutGroupItem Create(string caption, string imageName)
            => new(caption, imageName);

        /// <summary>
        /// Creates the specified caption.
        /// </summary>
        /// <param name="caption">The caption.</param>
        /// <param name="imageName">Name of the image.</param>
        /// <param name="nodes">The nodes.</param>
        /// <returns>Xenial.Framework.Layouts.Items.LayoutGroupItem.</returns>
        /// <autogeneratedoc />
        public static new HorizontalLayoutGroupItem Create(string caption, string imageName, params LayoutItemNode[] nodes)
            => Create(caption, imageName) with { Children = new(nodes) };

        /// <summary>
        /// Creates the specified caption.
        /// </summary>
        /// <param name="caption">The caption.</param>
        /// <param name="imageName">Name of the image.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>Xenial.Framework.Layouts.Items.HorizontalLayoutGroupItem.</returns>
        /// <autogeneratedoc />
        public static new HorizontalLayoutGroupItem Create(string caption, string? imageName, string id)
            => new HorizontalLayoutGroupItem(caption, imageName, id);

        /// <summary>
        /// Creates the specified caption.
        /// </summary>
        /// <param name="caption">The caption.</param>
        /// <param name="imageName">Name of the image.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="nodes">The nodes.</param>
        /// <returns>Xenial.Framework.Layouts.Items.HorizontalLayoutGroupItem.</returns>
        /// <autogeneratedoc />
        public static new HorizontalLayoutGroupItem Create(string caption, string? imageName, string id, params LayoutItemNode[] nodes)
            => Create(caption, imageName, id) with { Children = new(nodes) };

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutGroupItem"/> class.
        /// </summary>
        /// <autogeneratedoc />
        public HorizontalLayoutGroupItem()
            => Direction = defaultFlowDirection;

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutGroupItem"/> class.
        /// </summary>
        /// <param name="caption">The identifier.</param>
        /// <autogeneratedoc />
        public HorizontalLayoutGroupItem(string caption)
            : base(caption, defaultFlowDirection) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutGroupItem"/> class.
        /// </summary>
        /// <param name="caption">The caption.</param>
        /// <param name="imageName">Name of the image.</param>
        /// <autogeneratedoc />
        public HorizontalLayoutGroupItem(string caption, string imageName)
            : base(caption, imageName, caption, defaultFlowDirection) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="HorizontalLayoutGroupItem"/> class.
        /// </summary>
        /// <param name="caption">The caption.</param>
        /// <param name="imageName">Name of the image.</param>
        /// <param name="id">The identifier.</param>
        /// <autogeneratedoc />
        public HorizontalLayoutGroupItem(string caption, string? imageName, string id)
            : base(caption, imageName, id, defaultFlowDirection) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutGroupItem"/> class.
        /// </summary>
        /// <param name="caption">The caption.</param>
        /// <param name="imageName">Name of the image.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="flowDirection">The flow direction.</param>
        /// <autogeneratedoc />
        protected HorizontalLayoutGroupItem(string caption, string? imageName, string id, FlowDirection flowDirection)
            : base(caption, imageName, id, flowDirection) { }
    }
}
