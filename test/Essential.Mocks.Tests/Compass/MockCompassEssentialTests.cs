using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Microsoft.Reactive.Testing;
using ReactiveUI.Testing;
using Xamarin.Essentials;
using Xunit;

namespace Essentials.Mocks.Tests
{
    public sealed class MockCompassEssentialTests
    {
        public class TheCompassChangedProperty
        {
            [Fact]
            public void Compass_Should_Change()
            {
                // Given
                var testScheduler = new TestScheduler();
                CompassData reading = new CompassData();
                MockCompassEssential compass = new MockCompassEssentialFixture().WithScheduler(testScheduler);

                compass
                    .CompassChanged
                    .Subscribe(_ =>
                    {
                        reading = _.Reading;
                    });

                // When
                testScheduler.AdvanceToMs(TimeSpan.FromSeconds(2.5).TotalMilliseconds);

                // Then
                reading.HeadingMagneticNorth.Should().Be(10);
            }

            [Fact]
            public void Compass_Should_Change_Heading()
            {
                // Given
                var testScheduler = new TestScheduler();
                CompassData reading = new CompassData();
                MockCompassEssential compass = new MockCompassEssentialFixture().WithScheduler(testScheduler);

                compass
                    .CompassChanged
                    .Subscribe(_ =>
                    {
                        reading = _.Reading;
                    });

                // When
                testScheduler.AdvanceToMs(TimeSpan.FromSeconds(1).TotalMilliseconds);

                // Then
                reading.HeadingMagneticNorth.Should().Be(0);

                // When
                testScheduler.AdvanceBy(TimeSpan.FromSeconds(1).Ticks);

                // Then
                reading.HeadingMagneticNorth.Should().Be(10);

                // When
                testScheduler.AdvanceBy(TimeSpan.FromSeconds(1).Ticks);

                // Then
                reading.HeadingMagneticNorth.Should().Be(20);
            }
        }

        public class TheIsMonitoringProperty
        {
            [Fact]
            public void Should_Be_Monitoring()
            {
                // Given
                MockCompassEssential compass = new MockCompassEssentialFixture();

                // When
                compass.Start();

                // The
                compass.IsMonitoring.Should().BeTrue();
            }

            [Fact]
            public void Should_Not_Be_Monitoring()
            {
                // Given
                MockCompassEssential compass = new MockCompassEssentialFixture();

                // When
                compass.Start();

                // The
                compass.IsMonitoring.Should().BeTrue();

                // When
                compass.Stop();

                // The
                compass.IsMonitoring.Should().BeFalse();
            }
        }
    }
}
