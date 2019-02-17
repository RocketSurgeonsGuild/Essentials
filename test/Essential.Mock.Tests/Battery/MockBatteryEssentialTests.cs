using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Microsoft.Reactive.Testing;
using Rocket.Surgery.Extensions.Testing.Fixtures;
using Rocket.Surgery.Xamarin.Essentials.Mock;
using Xamarin.Essentials;
using Xunit;

namespace Essentials.Mock.Tests.Battery
{
    public sealed class MockBatteryEssentialTests
    {
        public class TheStateProperty
        {
            [Fact]
            public void Should()
            {
                // Given
                var testScheduler = new TestScheduler();
                MockBatteryEssential sut = new MockBatteryEssentialFixture().WithScheduler(testScheduler);
                testScheduler.AdvanceTo(TimeSpan.FromSeconds(2).Ticks);
                // Then
                sut.State.Should().Be(BatteryState.Charging);
            }
        }
    }

    public class MockBatteryEssentialFixture : ITestFixtureBuilder
    {
        private static double _level;
        private static BatteryState _state;
        private static BatteryPowerSource _source;
        private TestScheduler _scheduler;

        public MockBatteryEssentialFixture() { _scheduler = new TestScheduler(); }

        public MockBatteryEssentialFixture WithScheduler(TestScheduler testScheduler) =>
            this.With(ref _scheduler, _scheduler);

        public static implicit operator MockBatteryEssential(MockBatteryEssentialFixture fixture) => fixture.Build();

        private MockBatteryEssential Build() => new MockBatteryEssential(_scheduler);
    }
}
