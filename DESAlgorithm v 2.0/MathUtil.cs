﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAlgorithm_v_2._0
{
    internal static class MathUtil
    {
        public static BitArray FeistelFunction(BitArray toProcess, int withKeyCykle, BitArray[] subkeys)
        {
            byte[] expansionMatrix = new byte[] {32,   1,   2,   3,   4,   5,
                                                4,   5,   6,   7,   8,   9,
                                                8,   9,  10,  11,  12,  13,
                                               12,  13,  14,  15,  16,  17,
                                               16,  17,  18,  19,  20,  21,
                                               20,  21,  22,  23,  24,  25,
                                               24,  25,  26,  27,  28,  29,
                                               28,  29,  30,  31,  32,   1 };
            toProcess = MathUtil.BitArrayPermutate(toProcess, expansionMatrix);
            toProcess.Xor(subkeys[withKeyCykle-1]);
            toProcess = Sbox.SBoxSubstitution(toProcess);
            byte[] permutation = new byte[]  {16,   7,  20,  21,  29,  12,  28,  17,
                                                1 ,  15,  23,  26,  5 ,  18,  31,  10,
                                                2 ,  8 ,  24,  14,  32,  27,  3 ,  9 ,
                                                19,  13,  30,  6 ,  22,  11,  4 ,  25 };
            toProcess = MathUtil.BitArrayPermutate(toProcess, permutation);
            return toProcess;
        }

        public static BitArray BitArrayPermutate(BitArray toPermutate, byte[] permutatior)
        {
            BitArray permutated = new BitArray(permutatior.Length);

            for (int i = 0; i < permutatior.Length; i++)
            {
                permutated[i] = toPermutate[permutatior[i] - 1];
            }
            return permutated;
        }
    }
}
