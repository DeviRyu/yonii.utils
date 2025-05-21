using System;

namespace Yonii.Utils
{
    /// <summary>
    /// Represents an efficient, type-safe value object for identifying entities by either a numeric ID or a GUID (globally unique identifier).
    /// It is especially useful when you want to uniformly manage references to both static (predetermined) and dynamically created objects without ambiguity.
    /// </summary>
    public readonly struct ObjectKey : IEquatable<ObjectKey>
    {
        private readonly ulong _value;
        
        // Constructor for numeric ID (useful for predetermined/static objects)
        public ObjectKey(uint id)
        {
            _value = id;
        }
        
        /// <summary>
        /// Constructor for GUID (useful for dynamically created objects)
        /// This way of converting GUID to ulong is faster than using `Guid.ToByteArray()` (allocates a new 16-byte array each call)
        /// and `BitConverter.ToUInt64()` due to the use of Span
        /// No HEAP allocation is performed only stack allocation.
        /// </summary>
        /// <param name="guid"></param>
        public ObjectKey(Guid guid)
        {
            Span<byte> bytes = stackalloc byte[16];
            guid.TryWriteBytes(bytes);
            _value = BitConverter.ToUInt64(bytes);
        }

        public bool Equals(ObjectKey other) => _value == other._value;
        public override bool Equals(object? obj) => obj is ObjectKey other && Equals(other);
        public override int GetHashCode() => _value.GetHashCode();
        public static bool operator ==(ObjectKey left, ObjectKey right) => left.Equals(right);
        public static bool operator !=(ObjectKey left, ObjectKey right) => !left.Equals(right);
    }
}