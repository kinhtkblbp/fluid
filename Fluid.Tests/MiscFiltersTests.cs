﻿using Fluid.Filters;
using Fluid.Values;
using Xunit;

namespace Fluid.Tests
{
    public class MiscFiltersTests
    {
        [Fact]
        public void DefaultReturnsValueIfDefined()
        {
            var input = new StringValue("foo");

            var arguments = new FilterArguments().Add(new StringValue("bar"));
            var context = new TemplateContext();

            var result = MiscFilters.Default(input, arguments, context);

            Assert.Equal("foo", result.ToStringValue());
        }

        [Fact]
        public void DefaultReturnsDefaultIfNotDefined()
        {
            var input = EmptyValue.Instance;

            var arguments = new FilterArguments().Add(new StringValue("bar"));
            var context = new TemplateContext();

            var result = MiscFilters.Default(input, arguments, context);

            Assert.Equal("bar", result.ToStringValue());
        }
    }
}