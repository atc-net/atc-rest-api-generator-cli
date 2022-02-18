using System;
using System.CodeDom.Compiler;
using Microsoft.Extensions.Logging;
using Scenario2.Domain.Handlers.Accounts;
using Xunit;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator x.x.x.x.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Scenario2.Domain.Tests.Handlers.Accounts.Generated
{
    [GeneratedCode("ApiGenerator", "x.x.x.x")]
    public class SetAccountNameHandlerGeneratedTests
    {
        [Fact]
        public void InstantiateConstructor()
        {
            // Act
            var actual = new SetAccountNameHandler();

            // Assert
            Assert.NotNull(actual);
        }

        [Fact]
        public void ParameterArgumentNullCheck()
        {
            // Arrange
            var sut = new SetAccountNameHandler();

            // Act & Assert
            Assert.ThrowsAsync<ArgumentException>(() => sut.ExecuteAsync(null!));
        }
    }
}