using UnityEngine;

// One seed per sitting, built from the table and a session counter that moves every
// time the player takes a seat, so two sittings at the same table are different games
// (C.11) and a reported seed reproduces one exactly.
//
// System.Random, not the engine's global generator: the global one carries process wide
// state, so two systems drawing from it start steering each other and "the same seed"
// stops meaning the same thing. The namespace is written out at every use rather than
// imported, because `using System;` next to `using UnityEngine;` makes Random ambiguous.
public static class _0x5bbf3bb8
{
    public static int For(int _0xb0da1809, int _0xc200b7a4)
    {
        int _0x67d10d94 = (_0xb0da1809 * 7919) ^ (_0xc200b7a4 * 104729);
        if (_0x67d10d94 == 0)
        {
            _0x67d10d94 = 1;
        }

        {
#if B_LOGS
            {
                Debug.Log($"[session] seed={_0x67d10d94} table={_0xb0da1809} sitting={_0xc200b7a4}");
            }
#endif
        }

        return _0x67d10d94;
    }

    // A second, independent stream from the same sitting - used where a draw must not
    // disturb the strip generator's sequence (the mission card, the idle arrangement).
    public static System.Random Branch(int _0x35c55508, int _0xb0356416)
    {
        int _0x147fb033 = _0x35c55508 ^ (_0xb0356416 * 73856093);
        return new System.Random(_0x147fb033 == 0 ? 1 : _0x147fb033);
    }

    public static System.Random Open(int _0xec7a031b, int _0x534bfdc6)
    {
        return new System.Random(For(_0xec7a031b, _0x534bfdc6));
    }
}