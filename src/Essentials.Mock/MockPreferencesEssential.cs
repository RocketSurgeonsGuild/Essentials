using System;
using System.Collections.Generic;
using System.Text;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;

namespace Essentials.Mock
{
    /// <summary>
    /// Mock preferences essential.
    /// </summary>
    /// <seealso cref="IPreferences" />
    public class MockPreferencesEssential : IPreferences
    {
        private readonly IDictionary<string, object> _preferences = new Dictionary<string, object>();

        /// <inheritdoc />
        public void Clear() => _preferences.Clear();

        /// <inheritdoc />
        public void Clear(string sharedName) => _preferences.Remove(sharedName);

        /// <inheritdoc />
        public bool ContainsKey(string key) => _preferences.ContainsKey(key);

        /// <inheritdoc />
        public bool ContainsKey(string key, string sharedName) => _preferences.ContainsKey(key);

        /// <inheritdoc />
        public string Get(string key, string defaultValue) => GetPreference(key, defaultValue);

        /// <inheritdoc />
        public bool Get(string key, bool defaultValue) => GetPreference(key, defaultValue);

        /// <inheritdoc />
        public int Get(string key, int defaultValue) => GetPreference(key, defaultValue);

        /// <inheritdoc />
        public double Get(string key, double defaultValue) => GetPreference(key, defaultValue);

        /// <inheritdoc />
        public float Get(string key, float defaultValue) => GetPreference(key, defaultValue);

        /// <inheritdoc />
        public long Get(string key, long defaultValue) => GetPreference(key, defaultValue);

        /// <inheritdoc />
        public string Get(string key, string defaultValue, string sharedName) => GetPreference(key, defaultValue);

        /// <inheritdoc />
        public bool Get(string key, bool defaultValue, string sharedName) => GetPreference(key, defaultValue);

        /// <inheritdoc />
        public int Get(string key, int defaultValue, string sharedName) => GetPreference(key, defaultValue);

        /// <inheritdoc />
        public double Get(string key, double defaultValue, string sharedName) => GetPreference(key, defaultValue);

        /// <inheritdoc />
        public float Get(string key, float defaultValue, string sharedName) => GetPreference(key, defaultValue);

        /// <inheritdoc />
        public long Get(string key, long defaultValue, string sharedName) => GetPreference(key, defaultValue);

        /// <inheritdoc />
        public DateTime Get(string key, DateTime defaultValue) => GetPreference(key, defaultValue);

        /// <inheritdoc />
        public DateTime Get(string key, DateTime defaultValue, string sharedName) => GetPreference(key, defaultValue);

        /// <inheritdoc />
        public void Remove(string key) => _preferences.Remove(key);

        /// <inheritdoc />
        public void Remove(string key, string sharedName) => _preferences.Remove(key);

        /// <inheritdoc />
        public void Set(string key, string value) => SetPreference(key, value);

        /// <inheritdoc />
        public void Set(string key, bool value) => SetPreference(key, value);

        /// <inheritdoc />
        public void Set(string key, int value) => SetPreference(key, value);

        /// <inheritdoc />
        public void Set(string key, double value) => SetPreference(key, value);

        /// <inheritdoc />
        public void Set(string key, float value) => SetPreference(key, value);

        /// <inheritdoc />
        public void Set(string key, long value) => SetPreference(key, value);

        /// <inheritdoc />
        public void Set(string key, string value, string sharedName) => SetPreference(key, value);

        /// <inheritdoc />
        public void Set(string key, bool value, string sharedName) => SetPreference(key, value);

        /// <inheritdoc />
        public void Set(string key, int value, string sharedName) => SetPreference(key, value);

        /// <inheritdoc />
        public void Set(string key, double value, string sharedName) => SetPreference(key, value);

        /// <inheritdoc />
        public void Set(string key, float value, string sharedName) => SetPreference(key, value);

        /// <inheritdoc />
        public void Set(string key, long value, string sharedName) => SetPreference(key, value);

        /// <inheritdoc />
        public void Set(string key, DateTime value) => SetPreference(key, value);

        /// <inheritdoc />
        public void Set(string key, DateTime value, string sharedName) => Set(key, value);

        private T GetPreference<T>(string key, T defaultValue)
        {
            if (_preferences.ContainsKey(key))
            {
                return (T)_preferences[key];
            }

            return defaultValue;
        }

        private void SetPreference<T>(string key, T value) => _preferences.Add(key, value);
    }
}
