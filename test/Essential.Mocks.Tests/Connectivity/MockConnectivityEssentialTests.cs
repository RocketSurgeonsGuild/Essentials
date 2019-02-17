using System;
using System.Collections.Generic;
using System.Linq;
using Essentials.Mocks;
using FluentAssertions;
using Microsoft.Reactive.Testing;
using ReactiveUI.Testing;
using Xamarin.Essentials;
using Xunit;

namespace Essentials.Mocks.Tests
{
    public sealed class MockConnectivityEssentialTests
    {
        private readonly IEnumerable<NetworkAccess> NetworkAccesses = new[]
        {
            NetworkAccess.Unknown,
            NetworkAccess.Internet
        };

        [Fact]
        public void Connectivity_Should_Change()
        {
            // Given
            NetworkAccess access = NetworkAccess.None;
            var testScheduler = new TestScheduler();
            MockConnectivityEssential sut =
                new MockConnectivityEssentialFixture()
                    .WithScheduler(testScheduler)
                    .WithAccesses(NetworkAccesses);

            sut
                .ConnectivityChanged
                .Subscribe(_ =>
                {
                    access = _.NetworkAccess;
                });

            // When
            testScheduler.AdvanceToMs(TimeSpan.FromSeconds(2.5).TotalMilliseconds);

            // Then
            access.Should().Be(NetworkAccess.Internet);
        }

        [Fact]
        public void Connectivity_Should_Connect_And_Disconnect()
        {
            // Given
            NetworkAccess access = NetworkAccess.None;
            var testScheduler = new TestScheduler();
            MockConnectivityEssential connectivity =
                new MockConnectivityEssentialFixture()
                    .WithScheduler(testScheduler)
                    .WithAccesses(NetworkAccesses);

            connectivity
                .ConnectivityChanged
                .Subscribe(_ =>
                {
                    access = _.NetworkAccess;
                });

            // When
            testScheduler.AdvanceToMs(TimeSpan.FromSeconds(2.5).TotalMilliseconds);

            // Then
            access.Should().Be(NetworkAccess.Internet);

            // When
            testScheduler.AdvanceByMs(TimeSpan.FromSeconds(2).TotalMilliseconds);

            // Then
            access.Should().Be(NetworkAccess.Unknown);
        }

        [Fact]
        public void Connectivity_Should_Connect_Disconnect_And_Connect()
        {
            // Given
            NetworkAccess access = NetworkAccess.None;
            var testScheduler = new TestScheduler();
            MockConnectivityEssential connectivity =
                new MockConnectivityEssentialFixture()
                    .WithScheduler(testScheduler)
                    .WithAccesses(NetworkAccesses);

            connectivity
                .ConnectivityChanged
                .Subscribe(_ =>
                {
                    access = _.NetworkAccess;
                });

            // When
            testScheduler.AdvanceToMs(TimeSpan.FromSeconds(2.5).TotalMilliseconds);

            // Then
            access.Should().Be(NetworkAccess.Internet);

            // When
            testScheduler.AdvanceToMs(TimeSpan.FromSeconds(4.5).TotalMilliseconds);

            // Then
            access.Should().Be(NetworkAccess.Unknown);

            // When
            testScheduler.AdvanceToMs(TimeSpan.FromSeconds(6.5).TotalMilliseconds);

            // Then
            access.Should().Be(NetworkAccess.Internet);

        }
    }
}
