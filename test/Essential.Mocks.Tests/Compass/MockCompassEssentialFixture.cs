using System.Reactive.Concurrency;
using Microsoft.Reactive.Testing;
using Rocket.Surgery.Extensions.Testing.Fixtures;

namespace Essentials.Mocks.Tests
{
    internal class MockCompassEssentialFixture : ITestFixtureBuilder
    {
        private IScheduler _scheduler;

        public MockCompassEssentialFixture() { _scheduler = new TestScheduler(); }

        public MockCompassEssentialFixture WithScheduler(IScheduler scheduler) => this.With(ref _scheduler, scheduler);

        public static implicit operator MockCompassEssential(MockCompassEssentialFixture fixture) => fixture.Build();

        private MockCompassEssential Build() => new MockCompassEssential(_scheduler);
    }
}