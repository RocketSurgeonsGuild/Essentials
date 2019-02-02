using System;
using System.Diagnostics.CodeAnalysis;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to the <see cref="Preferences"/> API.
    /// </summary>
    /// <seealso cref="IPreferences" />
    [SuppressMessage("Naming", "CA1716:Identifiers should not match keywords", Justification = "Decorating API methods")]
    public class PreferencesEssential : IPreferences
    {
        /// <inheritdoc />
        public void Clear() => Preferences.Clear();

        /// <inheritdoc />
        public void Clear(string sharedName) => Preferences.Clear(sharedName);

        /// <inheritdoc />
        public bool ContainsKey(string key) => Preferences.ContainsKey(key);

        /// <inheritdoc />
        public bool ContainsKey(string key, string sharedName) => Preferences.ContainsKey(key, sharedName);

        /// <inheritdoc />
        public string Get(string key, string defaultValue) => Preferences.Get(key, defaultValue);

        /// <inheritdoc />
        public bool Get(string key, bool defaultValue) => Preferences.Get(key, defaultValue);

        /// <inheritdoc />
        public int Get(string key, int defaultValue) => Preferences.Get(key, defaultValue);

        /// <inheritdoc />
        public double Get(string key, double defaultValue) => Preferences.Get(key, defaultValue);

        /// <inheritdoc />
        public float Get(string key, float defaultValue) => Preferences.Get(key, defaultValue);

        /// <inheritdoc />
        public long Get(string key, long defaultValue) => Preferences.Get(key, defaultValue);

        /// <inheritdoc />
        public string Get(string key, string defaultValue, string sharedName) => Preferences.Get(key, defaultValue, sharedName);

        /// <inheritdoc />
        public bool Get(string key, bool defaultValue, string sharedName) => Preferences.Get(key, defaultValue, sharedName);

        /// <inheritdoc />
        public int Get(string key, int defaultValue, string sharedName) => Preferences.Get(key, defaultValue, sharedName);

        /// <inheritdoc />
        public double Get(string key, double defaultValue, string sharedName) => Preferences.Get(key, defaultValue, sharedName);

        /// <inheritdoc />
        public float Get(string key, float defaultValue, string sharedName) => Preferences.Get(key, defaultValue, sharedName);

        /// <inheritdoc />
        public long Get(string key, long defaultValue, string sharedName) => Preferences.Get(key, defaultValue, sharedName);

        /// <inheritdoc />
        public DateTime Get(string key, DateTime defaultValue) => Preferences.Get(key, defaultValue);

        /// <inheritdoc />
        public DateTime Get(string key, DateTime defaultValue, string sharedName) => Preferences.Get(key, defaultValue, sharedName);

        /// <inheritdoc />
        public void Remove(string key) => Preferences.Remove(key);

        /// <inheritdoc />
        public void Remove(string key, string sharedName) => Preferences.Remove(key, sharedName);

        /// <inheritdoc />
        public void Set(string key, string value) => Preferences.Set(key, value);

        /// <inheritdoc />
        public void Set(string key, bool value) => Preferences.Set(key, value);

        /// <inheritdoc />
        public void Set(string key, int value) => Preferences.Set(key, value);

        /// <inheritdoc />
        public void Set(string key, double value) => Preferences.Set(key, value);

        /// <inheritdoc />
        public void Set(string key, float value) => Preferences.Set(key, value);

        /// <inheritdoc />
        public void Set(string key, long value) => Preferences.Set(key, value);

        /// <inheritdoc />
        public void Set(string key, string value, string sharedName) => Preferences.Set(key, value, sharedName);

        /// <inheritdoc />
        public void Set(string key, bool value, string sharedName) => Preferences.Set(key, value, sharedName);

        /// <inheritdoc />
        public void Set(string key, int value, string sharedName) => Preferences.Set(key, value, sharedName);

        /// <inheritdoc />
        public void Set(string key, double value, string sharedName) => Preferences.Set(key, value, sharedName);

        /// <inheritdoc />
        public void Set(string key, float value, string sharedName) => Preferences.Set(key, value, sharedName);

        /// <inheritdoc />
        public void Set(string key, long value, string sharedName) => Preferences.Set(key, value, sharedName);

        /// <inheritdoc />
        public void Set(string key, DateTime value) => Preferences.Set(key, value);

        /// <inheritdoc />
        public void Set(string key, DateTime value, string sharedName) => Preferences.Set(key, value, sharedName);
    }
}
