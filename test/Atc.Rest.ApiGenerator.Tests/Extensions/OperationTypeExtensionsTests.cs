using Microsoft.OpenApi.Models;
using Xunit;

namespace Atc.Rest.ApiGenerator.Tests.Extensions
{
    public static class OperationTypeExtensionsTests
    {
        [Theory]
        [InlineData(false, OperationType.Get)]
        [InlineData(true, OperationType.Put)]
        [InlineData(true, OperationType.Post)]
        [InlineData(false, OperationType.Delete)]
        [InlineData(false, OperationType.Options)]
        [InlineData(false, OperationType.Head)]
        [InlineData(true, OperationType.Patch)]
        [InlineData(false, OperationType.Trace)]
        public static void XXX(bool expected, OperationType operationType)
            => Assert.Equal(expected, operationType.IsRequestBodySupported());
    }
}