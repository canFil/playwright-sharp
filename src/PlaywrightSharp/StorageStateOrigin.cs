using System;
using System.Collections.Generic;
using System.Linq;

namespace PlaywrightSharp
{
    /// <summary>
    /// See <see cref="StorageState.Origins"/>.
    /// </summary>
    public class StorageStateOrigin : IEquatable<StorageStateOrigin>
    {
        /// <summary>
        /// Origin.
        /// </summary>
        public string Origin { get; set; }

        /// <summary>
        /// Local storage.
        /// </summary>
        public List<NameValueEntry> LocalStorage { get; set; } = new List<NameValueEntry>();

        /// <inheritdoc/>
        public bool Equals(StorageStateOrigin other)
            => other != null &&
                Origin == other.Origin &&
                LocalStorage.SequenceEqual(other.LocalStorage);

        /// <inheritdoc/>
        public override int GetHashCode()
            => 412870874 +
                EqualityComparer<string>.Default.GetHashCode(Origin) +
                EqualityComparer<List<NameValueEntry>>.Default.GetHashCode(LocalStorage);

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as StorageStateOrigin);
    }
}
