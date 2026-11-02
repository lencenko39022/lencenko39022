using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x2a3a98e7 : MonoBehaviour
{
    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0xbe652d98;
    private static float Ratio(Color _0xd6e7eb21, Color _0xd53880a4)
    {
        float _0xa0c86542 = Luminance(_0xd6e7eb21);
        float _0x524112fe = Luminance(_0xd53880a4);
        return (Mathf.Max(_0xa0c86542, _0x524112fe) + 0.05f) / (Mathf.Min(_0xa0c86542, _0x524112fe) + 0.05f);
    }

    private void OnEnable()
    {
        if (this._0xbe652d98 == null)
            this._0xbe652d98 = _0xf19e0674 => this._0x5a617db0(_0xf19e0674);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0xbe652d98);
    }

    private const float TargetRatio = 7f;
    private readonly HashSet<TMP_Text> _0x2855ec1b = new HashSet<TMP_Text>();
    private const float MinRatio = 4.5f;
    private static float Linear(float _0xc146bb10)
    {
        _0xc146bb10 = Mathf.Clamp01(_0xc146bb10);
        return _0xc146bb10 <= 0.03928f ? _0xc146bb10 / 12.92f : Mathf.Pow((_0xc146bb10 + 0.055f) / 1.055f, 2.4f);
    }

    private const float MinOutlineWidth = 0.01f;
    private static _0x2a3a98e7 _0x48b58047;
    private void LateUpdate()
    {
        if (this._0x2855ec1b.Count == 0)
            return;
        this._0x7fe8c123.Clear();
        this._0x7fe8c123.AddRange(this._0x2855ec1b);
        this._0x2855ec1b.Clear();
        for (int _0x686b2ae5 = 0; _0x686b2ae5 < this._0x7fe8c123.Count; _0x686b2ae5++)
            Fix(this._0x7fe8c123[_0x686b2ae5]);
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x5a617db0(Object _0x7e94ac1f)
    {
        TMP_Text _0xf2c4b138 = _0x7e94ac1f as TMP_Text;
        if (_0xf2c4b138 != null)
            this._0x2855ec1b.Add(_0xf2c4b138);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x48b58047 != null)
            return;
        GameObject _0x216b09ad = new GameObject(_0x50d2ffa0._0x15c7f27b(new byte[16] { 170, 147, 142, 189, 145, 144, 138, 140, 159, 141, 138, 185, 139, 159, 140, 154 }, 254));
        _0x216b09ad.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x216b09ad);
        _0x48b58047 = _0x216b09ad.AddComponent<_0x2a3a98e7>();
    }

    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0xaed96954)
    {
        return 0.2126f * Linear(_0xaed96954.r) + 0.7152f * Linear(_0xaed96954.g) + 0.0722f * Linear(_0xaed96954.b);
    }

    private static void Fix(TMP_Text _0xe9f8b6ae)
    {
        if (_0xe9f8b6ae == null || !_0xe9f8b6ae.isActiveAndEnabled)
            return;
        Material _0x0feca0ec = _0xe9f8b6ae.fontSharedMaterial;
        if (_0x0feca0ec == null || !_0x0feca0ec.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x0feca0ec.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x0feca0ec.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x93784e2e = _0xe9f8b6ae.color;
        if (_0x93784e2e.a <= 0f)
            return;
        Color _0x18482977 = _0x0feca0ec.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x93784e2e, _0x18482977) >= MinRatio)
            return;
        Color _0x9e1b73d3 = Luminance(_0x18482977) < 0.5f ? Color.white : Color.black;
        Color _0x19e5e070;
        if (Ratio(_0x9e1b73d3, _0x18482977) < TargetRatio)
        {
            _0x19e5e070 = _0x9e1b73d3;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x43c8cfb9 = 0f;
            float _0x0b1cbb41 = 1f;
            for (int _0x10c68cd0 = 0; _0x10c68cd0 < 20; _0x10c68cd0++)
            {
                float _0xfd0596aa = (_0x43c8cfb9 + _0x0b1cbb41) * 0.5f;
                if (Ratio(Color.Lerp(_0x93784e2e, _0x9e1b73d3, _0xfd0596aa), _0x18482977) >= TargetRatio)
                    _0x0b1cbb41 = _0xfd0596aa;
                else
                    _0x43c8cfb9 = _0xfd0596aa;
            }

            _0x19e5e070 = Color.Lerp(_0x93784e2e, _0x9e1b73d3, _0x0b1cbb41);
        }

        _0x19e5e070.a = _0x93784e2e.a;
        _0xe9f8b6ae.color = _0x19e5e070;
    }

    private readonly List<TMP_Text> _0x7fe8c123 = new List<TMP_Text>();
    private void OnDisable()
    {
        if (this._0xbe652d98 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0xbe652d98);
    }
}

internal static class _0x50d2ffa0
{
    internal static string _0x15c7f27b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}