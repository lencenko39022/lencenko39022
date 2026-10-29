using TMPro;
using UnityEngine;

// Every label in this game is created at RUNTIME, so stage 5c3 (enforce-text-contrast)
// reads files that do not contain it and guarantees nothing for it (C.10). The per
// label contract lives here instead:
//   * wrapping OFF - a line ends only where the author typed a line break;
//   * autosize ALWAYS on, with the minimum parked at the readability floor (C.12);
//   * an outline in the palette's darkest tone, so a light face reads on any backing.
//
// The floor: C.12 puts it at 24 px against a 1080 wide reference. This canvas is 1242
// wide, so the same physical size is 24 * 1242 / 1080 = 27.6, rounded up to 28.
//
// ASCII only. The atlas is a 256x256 ASCII sheet, so a star, a check, an arrow or a
// bullet renders as a missing glyph box. Words and plain punctuation only.
public static class _0x1bad1984
{
    public static void SetText(TextMeshProUGUI _0xc5729591, string _0xac334ffb)
    {
        if (_0xc5729591 != null)
        {
            _0xc5729591.text = _0xac334ffb;
        }
    }

    // "03" for a chip that must not change width as the number grows.
    public static string Pad2(int _0x706f6935)
    {
        int _0x017fdb75 = _0x706f6935 < 0 ? 0 : _0x706f6935;
        return _0x017fdb75 < 10 ? _0x2cd2bb2b._0x671197dc(new byte[1] { 2 }, 50) + _0x017fdb75.ToString() : _0x017fdb75.ToString();
    }

    public static string Multiplier(int _0xbaf9f7b6)
    {
        return _0xbaf9f7b6.ToString() + _0x2cd2bb2b._0x671197dc(new byte[1] { 236 }, 180);
    }

    public const float MinSize = 28f;
    // Credits are printed as plain ASCII digits with a space every three figures, which
    // the ASCII atlas can always draw: 1840 reads as "1 840".
    public static string Credits(int _0x4e2c8362)
    {
        int _0x613e79fe = _0x4e2c8362 < 0 ? 0 : _0x4e2c8362;
        string _0x6d20286a = _0x613e79fe.ToString();
        if (_0x6d20286a.Length <= 3)
        {
            return _0x6d20286a;
        }

        string _0xf3d55b02 = "";
        int _0x8831ba03 = _0x6d20286a.Length % 3;
        if (_0x8831ba03 > 0)
        {
            _0xf3d55b02 = _0x6d20286a.Substring(0, _0x8831ba03);
        }

        for (int _0x9f61c53a = _0x8831ba03; _0x9f61c53a < _0x6d20286a.Length; _0x9f61c53a += 3)
        {
            if (_0xf3d55b02.Length > 0)
            {
                _0xf3d55b02 = _0xf3d55b02 + _0x2cd2bb2b._0x671197dc(new byte[1] { 13 }, 45);
            }

            _0xf3d55b02 = _0xf3d55b02 + _0x6d20286a.Substring(_0x9f61c53a, 3);
        }

        return _0xf3d55b02;
    }

    public static void Apply(TextMeshProUGUI _0x612117e9, float _0x6935cf16, Color _0x6daf7d4b)
    {
        if (_0x612117e9 == null)
        {
            return;
        }

        _0x612117e9.textWrappingMode = TextWrappingModes.NoWrap;
        _0x612117e9.overflowMode = TextOverflowModes.Overflow;
        _0x612117e9.enableAutoSizing = true;
        _0x612117e9.fontSizeMax = _0x6935cf16;
        _0x612117e9.fontSizeMin = _0x6935cf16 < MinSize ? _0x6935cf16 : MinSize;
        _0x612117e9.fontSize = _0x6935cf16;
        _0x612117e9.color = _0x6daf7d4b;
        _0x612117e9.richText = false;
        _0x612117e9.raycastTarget = false;
        // C.65: a label built under an inactive parent has not run its own set up, so
        // reading fontMaterial would throw rather than return null. Give it a font and
        // a shared material first, then take the instance.
        if (_0x612117e9.font == null)
        {
            _0x612117e9.font = TMP_Settings.defaultFontAsset;
        }

        if (_0x612117e9.font == null)
        {
            return;
        }

        if (_0x612117e9.fontSharedMaterial == null)
        {
            _0x612117e9.fontSharedMaterial = _0x612117e9.font.material;
        }

        Material _0x7eae43ed = _0xbf524a91.InstanceOf(_0x612117e9); // reading this makes an INSTANCE; the shared asset is untouched
        if (_0x7eae43ed == null)
        {
            return;
        }

        _0x7eae43ed.EnableKeyword(_0x2cd2bb2b._0x671197dc(new byte[10] { 69, 95, 94, 70, 67, 68, 79, 85, 69, 68 }, 10));
        _0x7eae43ed.SetColor(ShaderUtilities.ID_OutlineColor, _0xc5c3f38d.Outline);
        _0x7eae43ed.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.22f);
        _0x7eae43ed.SetFloat(ShaderUtilities.ID_FaceDilate, 0.18f);
    }
}

internal static class _0x2cd2bb2b
{
    internal static string _0x671197dc(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}