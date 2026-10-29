using UnityEngine;

// The single colour table for both scenes.
//
// Declaration order matters after obfuscation (C.52): string encryption turns compile
// time constants into runtime initialised fields and the declarations may be reordered,
// so no entry here is derived from another entry. Every colour is a literal.
//
// Text colours are ALWAYS light (C.14). One font material means one shared dark
// outline, so a dark face would merge with its own outline into a blot. Scarlet tones
// are FILL colours only and never reach a label.
public static class _0xc5c3f38d
{
    public static readonly Color Outline = new Color(0.078f, 0.016f, 0.031f, 1f); // #140408 - the TMP outline
    public static readonly Color Paper = new Color(1f, 1f, 1f, 1f);
    // --- text (all light) -----------------------------------------------------
    public static readonly Color Cream = new Color(0.965f, 0.906f, 0.784f, 1f); // #F6E7C8
    public static readonly Color Ruby = new Color(0.769f, 0.071f, 0.184f, 1f); // #C4122F
    public static readonly Color GoldLit = new Color(0.961f, 0.843f, 0.478f, 1f); // #F5D77A
    public static readonly Color Velvet = new Color(0.110f, 0.067f, 0.086f, 1f); // #1C1116
    public static readonly Color RubyLit = new Color(0.910f, 0.208f, 0.353f, 1f); // #E8355A
    // A copy of `source` at a different alpha. Written as a method, not as a derived
    // static field, so nothing here depends on the order the fields are initialised in.
    public static Color With(Color _0xc6f60014, float _0xa4a5c00e)
    {
        return new Color(_0xc6f60014.r, _0xc6f60014.g, _0xc6f60014.b, _0xa4a5c00e);
    }

    public static readonly Color CreamDim = new Color(0.851f, 0.788f, 0.659f, 1f); // #D9C9A8
    // --- gilt -----------------------------------------------------------------
    public static readonly Color Gold = new Color(0.831f, 0.686f, 0.216f, 1f); // #D4AF37
    // --- surfaces -------------------------------------------------------------
    public static readonly Color Ink = new Color(0.043f, 0.043f, 0.059f, 1f); // #0B0B0F
    public static readonly Color VelvetLit = new Color(0.141f, 0.078f, 0.098f, 1f); // #241419
    public static readonly Color VelvetDeep = new Color(0.078f, 0.078f, 0.094f, 1f); // #141418
    // The accent that carries a reel symbol's rank, used for win flashes and chips.
    public static Color Rank(int _0xb44def58)
    {
        if (_0xb44def58 <= 0)
        {
            return GoldLit;
        }

        if (_0xb44def58 == 1)
        {
            return Gold;
        }

        if (_0xb44def58 == 2)
        {
            return RubyLit;
        }

        if (_0xb44def58 == 3)
        {
            return Ruby;
        }

        return CreamDim;
    }

    // --- accents (FILL ONLY) --------------------------------------------------
    public static readonly Color RubyDeep = new Color(0.557f, 0.055f, 0.133f, 1f); // #8E0E22
}