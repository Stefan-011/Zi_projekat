using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_projekat
{
    // referenca https://link.springer.com/content/pdf/10.1007/3-540-60865-6_46.pdf
    internal class Tiger_hash
    {
        private ulong A, B, C;
        private ulong AA, BB, CC;
        private const int
            lockSize = 64,
            hashSize = 192,
            msgBlkSizeBit = 512,
            msgBlkSizeByte = 64;
        public ulong dataSize;
        private ulong[] x;
        private int blockHashed;
        public int GetBlockHashed() 
        { return blockHashed; }

        public Tiger_hash()
        {
            A = 0x0123456789ABCDEF;
            B = 0xFEDCBA9876543210;
            C = 0xF096A5B4C3B2E187;
            AA = BB = CC = 0;
            x = new ulong[8];
            blockHashed = 0;
        }

        public void SetupX(byte[] msgBlk)
        {
            for( int i = 0; i < msgBlk.Length; i++)
                x[i] = msgBlk[i];
        }

        public void KeySchedule()
        {
            x[0] -= x[7] ^ 0xA5A5A5A5A5A5A5A5;
            x[1] ^= x[0];
            x[2] += x[1];
            x[3] -= x[2] ^ (( ~x[1] <<19 ));
            x[4] ^= x[3];
            x[5] += x[6];
            x[6] -= x[5] ^ ((~x[4]) >> 23); 
            x[7] ^= x[6];
        }
    }
}
