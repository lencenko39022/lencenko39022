using TMPro;
using UnityEngine;

/// <summary>
/// Captions built from code never reach the scene files, so the file-based contrast
/// stage cannot see them. This helper gives each one its own material instance with an
/// outline that contrasts with the face colour, and keeps wrapping off / autosize on.
/// </summary>
public static class _0xf9bbd821
{
    /// <summary>Wrapping off, autosize on, floor at the readability threshold.</summary>
    public static void ApplyFlow(TMP_Text _0xd3f4c729, float _0x77cb32e3)
    {
        if (_0xd3f4c729 == null)
            return;
        _0xd3f4c729.enableWordWrapping = false;
        _0xd3f4c729.overflowMode = TextOverflowModes.Overflow;
        _0xd3f4c729.enableAutoSizing = true;
        _0xd3f4c729.fontSizeMin = MinFontSize;
        _0xd3f4c729.fontSizeMax = Mathf.Max(MinFontSize, _0x77cb32e3);
        _0xd3f4c729.fontSize = Mathf.Max(MinFontSize, _0x77cb32e3);
    }

    /// <summary>
    /// Reading fontMaterial on a label whose Awake has not run throws, so the font and
    /// its shared material are guaranteed first.
    /// </summary>
    public static void ApplyOutline(TMP_Text _0x68c4ee05)
    {
        if (_0x68c4ee05 == null)
            return;
        if (_0x68c4ee05.font == null)
            _0x68c4ee05.font = TMP_Settings.defaultFontAsset;
        if (_0x68c4ee05.font == null)
            return;
        if (_0x68c4ee05.fontSharedMaterial == null)
            _0x68c4ee05.fontSharedMaterial = _0x68c4ee05.font.material;
        if (_0x68c4ee05.fontSharedMaterial == null)
            return;
        Color _0x828e751a = _0x68c4ee05.color;
        float _0x1e94d904 = 0.299f * _0x828e751a.r + 0.587f * _0x828e751a.g + 0.114f * _0x828e751a.b;
        Material _0x8b7153c1 = _0x690e2e79.InstanceOf(_0x68c4ee05);
        if (_0x8b7153c1 == null)
            return;
        _0x8b7153c1.SetColor(ShaderUtilities.ID_OutlineColor, _0x1e94d904 < 0.5f ? _0xdc7245d7.Parchment : _0xdc7245d7.Ink);
        _0x8b7153c1.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.18f);
    }

    /// <summary>UGUI readability floor - never go below it, add a line break instead.</summary>
    public const float MinFontSize = 28f;
}