using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace Essentials.Mock.Tests.SecureStorage
{
    public sealed class MockSecureStorageEssentialTests
    {
        private static readonly IDictionary<string, string> Dictionary = new Dictionary<string, string>
        {
            {"key", "value"},
            {"window", "door"}
        };

        public class TheGetMethod
        {
            [Fact]
            public void Should_Get_Value()
            {
                // Given
                MockSecureStorageEssential sut = new MockSecureStorageEssentialFixture();

                // When
                sut.Set("key", "value");

                // Then
                sut.Get("key").Subscribe(_ => _.Should().Be("value"));
            }
        }

        public class TheSetMethod
        {
            [Fact]
            public void Should_Set_Key_Value()
            {
                // Given
                MockSecureStorageEssential sut = new MockSecureStorageEssentialFixture();

                // When
                sut.Set("key", "value");

                // Then
                sut.Get("key").Subscribe(_ => _.Should().Be("value"));
            }
        }

        public class TheRemoveMethod
        {
            [Fact]
            public void Should_Remove_Key_Value()
            {
                // Given
                MockSecureStorageEssential sut = new MockSecureStorageEssentialFixture().WithDictionary(Dictionary);

                // When, Then
                sut.Remove("window").Should().BeTrue();
            }

            [Fact]
            public void Should_Not_Remove_Key_Value()
            {
                // Given, When
                MockSecureStorageEssential sut = new MockSecureStorageEssentialFixture().WithDictionary(Dictionary);

                // Then
                sut.Remove("clock").Should().BeFalse();
            }
        }
    }
}
