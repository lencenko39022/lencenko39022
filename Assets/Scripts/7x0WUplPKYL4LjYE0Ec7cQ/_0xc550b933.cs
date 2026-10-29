using TMPro;
using UnityEngine;

// The template ships seven indexed tutorial boards and this game dresses none of them.
// Controls are a single tap on one button, the game screen carries a permanent hint
// label, and the flag that would show the boards stays off - with it on they would
// appear in the GAME scene, between the hand off and the first round, stalling both the
// player and the review capture.
//
// What IS owed is that none of those undressed boards can ever put template filler on a
// screen (C.15). Their labels are emptied at run time. The boards themselves stay in
// place: the controllers address them by index, and pulling one out breaks navigation.
public sealed class _0xc550b933 : MonoBehaviour
{
    public void _0xaab641ee()
    {
        _0x5bc6383a _0x83b0f48f = _0x5bc6383a.Instance;
        if (_0x83b0f48f == null || _0x83b0f48f.Panels == null)
        {
            return;
        }

        int[] _0xb109a9fe =
        {
            _0xa93ecf08._0x27eba83c.TUTORIAL0,
            _0xa93ecf08._0x27eba83c.TUTORIAL1,
            _0xa93ecf08._0x27eba83c.TUTORIAL2,
            _0xa93ecf08._0x27eba83c.TUTORIAL3,
            _0xa93ecf08._0x27eba83c.TUTORIAL4,
            _0xa93ecf08._0x27eba83c.TUTORIAL5,
            _0xa93ecf08._0x27eba83c.TUTORIAL6,
        };
        for (int _0x38fa1f3c = 0; _0x38fa1f3c < _0xb109a9fe.Length; _0x38fa1f3c++)
        {
            int _0x6c239e79 = _0xb109a9fe[_0x38fa1f3c];
            if (_0x6c239e79 < 0 || _0x6c239e79 >= _0x83b0f48f.Panels.Count)
            {
                continue;
            }

            _0xd8539b11 _0x7a9cb001 = _0x83b0f48f.Panels[_0x6c239e79];
            if (_0x7a9cb001 == null)
            {
                continue;
            }

            TMP_Text[] _0x60d4232b = _0x7a9cb001.GetComponentsInChildren<TMP_Text>(true);
            for (int _0x48e5bc52 = 0; _0x48e5bc52 < _0x60d4232b.Length; _0x48e5bc52++)
            {
                if (_0x60d4232b[_0x48e5bc52] != null)
                {
                    _0x60d4232b[_0x48e5bc52].text = string.Empty;
                }
            }
        }
    }
}