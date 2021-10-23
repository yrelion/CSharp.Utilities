using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Utilities.Extensions
{
    public static class GuidExtensions
    {
        /// <summary>
        /// A CLSCompliant method to convert a Java big-endian <see cref="Guid"/> to a .NET little-endian <see cref="Guid"/>.
        /// The Guid Constructor (UInt32, UInt16, UInt16, Byte, Byte, Byte, Byte, Byte, Byte,
        /// Byte, Byte) is not CLSCompliant.
        /// </summary>
        /// <param name="javaGuid">The JAVA stored <see cref="Guid"/> to flip</param>
        /// <returns>The flipped <see cref="Guid"/></returns>
        public static Guid ToLittleEndian(this Guid javaGuid)
        {
            byte[] net = new byte[16];
            byte[] java = javaGuid.ToByteArray();

            for (int i = 8; i < 16; i++)
            {
                net[i] = java[i];
            }

            net[3] = java[0];
            net[2] = java[1];
            net[1] = java[2];
            net[0] = java[3];
            net[5] = java[4];
            net[4] = java[5];
            net[6] = java[7];
            net[7] = java[6];

            return new Guid(net);
        }

        /// <summary>
        /// Converts a little-endian .NET <see cref="Guid"/> to big-endian Java <see cref="Guid"/>:
        /// </summary>
        /// <param name="netGuid">The .NET stored <see cref="Guid"/> to flip</param>
        /// <returns>The flipped <see cref="Guid"/></returns>
        public static Guid ToBigEndian(this Guid netGuid)
        {
            byte[] java = new byte[16];
            byte[] net = netGuid.ToByteArray();

            for (int i = 8; i < 16; i++)
            {
                java[i] = net[i];
            }

            java[0] = net[3];
            java[1] = net[2];
            java[2] = net[1];
            java[3] = net[0];
            java[4] = net[5];
            java[5] = net[4];
            java[6] = net[7];
            java[7] = net[6];

            return new Guid(java);
        }
    }
}
