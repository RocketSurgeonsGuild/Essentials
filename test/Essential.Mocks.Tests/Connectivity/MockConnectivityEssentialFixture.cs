using System.Collections.Generic;
using System.Reactive.Concurrency;
using Essentials.Mocks;
using Microsoft.Reactive.Testing;
using Rocket.Surgery.Extensions.Testing.Fixtures;
using Xamarin.Essentials;

namespace Essentials.Mocks.Tests
{
    public class MockConnectivityEssentialFixture : ITestFixtureBuilder
    {
        private IScheduler _scheduler;
        private IEnumerable<NetworkAccess> _accesses;

        public MockConnectivityEssentialFixture() { _scheduler = new TestScheduler(); }

        public MockConnectivityEssentialFixture WithAccesses(IEnumerable<NetworkAccess> accesses) =>
            this.With(ref _accesses, accesses);

        public MockConnectivityEssentialFixture WithScheduler(IScheduler scheduler) => this.With(ref _scheduler, scheduler);

        public static implicit operator MockConnectivityEssential(MockConnectivityEssentialFixture fixture) =>
            fixture.Build();

        private MockConnectivityEssential Build() =>
            new MockConnectivityEssential(_scheduler, networkAccesses: _accesses);
    }
}