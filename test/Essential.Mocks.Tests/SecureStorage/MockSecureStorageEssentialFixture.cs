using System.Collections.Generic;
using System.Reactive.Concurrency;
using Microsoft.Reactive.Testing;
using Rocket.Surgery.Extensions.Testing.Fixtures;

namespace Essentials.Mocks.Tests
{
    public class MockSecureStorageEssentialFixture : ITestFixtureBuilder
    {
        private IScheduler _scheduler;
        private IDictionary<string, string> _storage;

        public MockSecureStorageEssentialFixture()
        {
            _scheduler = new TestScheduler();
            _storage = new Dictionary<string, string>();
        }

        public MockSecureStorageEssentialFixture WithDictionary(IDictionary<string, string> storage) =>
            this.With(ref _storage, storage);

        public MockSecureStorageEssentialFixture WithScheduler(IScheduler scheduler) =>
            this.With(ref _scheduler, scheduler);

        public static implicit operator MockSecureStorageEssential(MockSecureStorageEssentialFixture fixture) =>
            fixture.Build();

        private MockSecureStorageEssential Build() => new MockSecureStorageEssential(_storage);
    }
}