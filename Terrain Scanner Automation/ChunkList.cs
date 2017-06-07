using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terrain_Scanner_Automation
{
    static class ChunkList
    {
        public struct Chunk
        {
            public int X { get; private set; }
            public int Z { get; private set; }

            public Chunk(int x, int z)
            {
                X = x;
                Z = z;
            }

            public override string ToString()
            {
                return X + " " + Z;
            }
        }

        static List<Chunk> Chunks;

        static ChunkList()
        {
            Chunks = new List<Chunk>();
        }

        public static Chunk AddChunk(int x, int z)
        {
            Chunk chunk = new Chunk(x, z);

            if (!Chunks.Any(c => c.Equals(chunk)))
            {
                Chunks.Add(chunk);
                Console.WriteLine("Chunk Added: (" + x + ", " + z + ")");
            }

            return chunk;
        }

        public static Chunk GetAndRemoveFirstChunk()
        {
            Chunk chunk = Chunks.FirstOrDefault();
            Chunks.RemoveAt(0);

            return chunk;
        }

    }
}
