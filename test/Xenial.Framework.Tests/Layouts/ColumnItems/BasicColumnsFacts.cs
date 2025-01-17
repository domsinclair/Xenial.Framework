﻿using System;
using System.Linq;

using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Model.NodeGenerators;

using Shouldly;

using Xenial.Framework.Layouts;
using Xenial.Framework.Layouts.ColumnItems;
using Xenial.Framework.Layouts.Items.Base;
using Xenial.Framework.Layouts.Items.LeafNodes;
using Xenial.Framework.Tests.Assertions;

using static Xenial.Framework.Tests.Layouts.TestModelApplicationFactory;
using static Xenial.Tasty;

namespace Xenial.Framework.Tests.Layouts.ColumnItems
{
    [DomainComponent]
    [ListViewColumnsBuilder(typeof(SimpleBusinessObjectColumnsBuilder))]
    public sealed class SimpleBusinessObject
    {
        public string? StringProperty { get; set; }
        public bool BoolProperty { get; set; }
        public bool? NullableBoolProperty { get; set; }
        public int IntegerProperty { get; set; }
        public int? NullableIntegerProperty { get; set; }
        public object? ObjectProperty { get; set; }
    }

    public static class SimpleBusinessObjectColumnsBuilder
    {
        internal static bool BuildColumnsWasCalled;
        public static Columns BuildColumns()
        {
            BuildColumnsWasCalled = true;
            //var column = new Column(nameof(SimpleBusinessObject.StringProperty));

            return new()
            {
                //column
            };
        }
    }

    [DomainComponent]
    [ListViewColumnsBuilder(nameof(BuildExoticColumns))]
    public sealed class SimpleBusinessObjectWithStaticBuilder
    {
        public string? StringProperty { get; set; }

        internal static bool BuildExoticColumnsWasCalled;

        public static Columns BuildExoticColumns()
        {
            BuildExoticColumnsWasCalled = true;
            return new();
        }
    }

    [DomainComponent]
    [ListViewColumnsBuilder]
    public sealed class SimpleBusinessObjectWithStaticBuilderConvention
    {
        internal static bool BuildColumnsWasCalled;

        public static Columns BuildColumns()
        {
            BuildColumnsWasCalled = true;
            return new();
        }
    }

    public static class BasicColumnsFacts
    {
        public static void BasicColumnsTests() => Describe("Basic Columns", () =>
        {
            It($"creates {nameof(IModelApplication)}", () =>
            {
                var model = CreateApplication(new[] { typeof(SimpleBusinessObject) });

                model.ShouldBeAssignableTo<IModelApplication>();
            });

            Describe("use generator buddy type logic", () =>
            {
                var model = CreateApplication(new[] { typeof(SimpleBusinessObject) });

                It($"Finds {typeof(SimpleBusinessObject)}  ListView", () =>
                {
                    var listView = model.FindListView<SimpleBusinessObject>();

                    listView.ShouldNotBeNull();
                });

                It("static buddy builder was called", () =>
                {
                    var listView = model.FindListView<SimpleBusinessObject>();

                    var _ = listView?.Columns?.FirstOrDefault(); //We need to access the columns node cause it's lazy evaluated

                    SimpleBusinessObjectColumnsBuilder.BuildColumnsWasCalled.ShouldBeTrue();
                });
            });

            Describe("use static type on model class", () =>
            {
                var model = CreateApplication(new[] { typeof(SimpleBusinessObjectWithStaticBuilder) });

                It("returns the list view", () =>
                {
                    var listView = model.FindListView<SimpleBusinessObjectWithStaticBuilder>();

                    listView.ShouldNotBeNull();
                });

                It("static builder was called", () =>
                {
                    var listView = model.FindListView<SimpleBusinessObjectWithStaticBuilder>();

                    var _ = listView?.Columns?.FirstOrDefault(); //We need to access the layout node cause it's lazy evaluated

                    SimpleBusinessObjectWithStaticBuilder.BuildExoticColumnsWasCalled.ShouldBeTrue();
                });
            });

            Describe("use static type on model class with convention", () =>
            {
                var model = CreateApplication(new[] { typeof(SimpleBusinessObjectWithStaticBuilderConvention) });

                It("returns the list view", () =>
                {
                    var listView = model.FindListView<SimpleBusinessObjectWithStaticBuilderConvention>();

                    listView.ShouldNotBeNull();
                });

                It("static builder was called", () =>
                {
                    var listView = model.FindListView<SimpleBusinessObjectWithStaticBuilderConvention>();

                    var _ = listView?.Columns?.FirstOrDefault(); //We need to access the layout node cause it's lazy evaluated

                    SimpleBusinessObjectWithStaticBuilderConvention.BuildColumnsWasCalled.ShouldBeTrue();
                });
            });
        });
    }
}
