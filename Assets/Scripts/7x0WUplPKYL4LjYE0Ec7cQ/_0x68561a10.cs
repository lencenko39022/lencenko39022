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
public sealed class _0x68561a10 : MonoBehaviour
{
    private readonly HashSet<TMP_Text> _0x7b31710f = new HashSet<TMP_Text>();
    private static _0x68561a10 _0x1ab23759;
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x1ab23759 != null)
            return;
        GameObject _0xf20523f7 = new GameObject(_0x14e0754d._0x4cdf19f0(new byte[16] { 181, 140, 145, 162, 142, 143, 149, 147, 128, 146, 149, 166, 148, 128, 147, 133 }, 225));
        _0xf20523f7.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xf20523f7);
        _0x1ab23759 = _0xf20523f7.AddComponent<_0x68561a10>();
    }

    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x7f952c02)
    {
        return 0.2126f * Linear(_0x7f952c02.r) + 0.7152f * Linear(_0x7f952c02.g) + 0.0722f * Linear(_0x7f952c02.b);
    }

    private void OnDisable()
    {
        if (this._0xaa74036b != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0xaa74036b);
    }

    private static float Linear(float _0x70dc1a63)
    {
        _0x70dc1a63 = Mathf.Clamp01(_0x70dc1a63);
        return _0x70dc1a63 <= 0.03928f ? _0x70dc1a63 / 12.92f : Mathf.Pow((_0x70dc1a63 + 0.055f) / 1.055f, 2.4f);
    }

    private const float MinOutlineWidth = 0.01f;
    private static void Fix(TMP_Text _0xf39e0082)
    {
        if (_0xf39e0082 == null || !_0xf39e0082.isActiveAndEnabled)
            return;
        Material _0x41fba942 = _0xf39e0082.fontSharedMaterial;
        if (_0x41fba942 == null || !_0x41fba942.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x41fba942.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x41fba942.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x626204e9 = _0xf39e0082.color;
        if (_0x626204e9.a <= 0f)
            return;
        Color _0xb5e82de1 = _0x41fba942.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x626204e9, _0xb5e82de1) >= MinRatio)
            return;
        Color _0xe2a4c369 = Luminance(_0xb5e82de1) < 0.5f ? Color.white : Color.black;
        Color _0x37e00a87;
        if (Ratio(_0xe2a4c369, _0xb5e82de1) < TargetRatio)
        {
            _0x37e00a87 = _0xe2a4c369;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x876ba444 = 0f;
            float _0xf9c5c99f = 1f;
            for (int _0xd7828afc = 0; _0xd7828afc < 20; _0xd7828afc++)
            {
                float _0x6793063b = (_0x876ba444 + _0xf9c5c99f) * 0.5f;
                if (Ratio(Color.Lerp(_0x626204e9, _0xe2a4c369, _0x6793063b), _0xb5e82de1) >= TargetRatio)
                    _0xf9c5c99f = _0x6793063b;
                else
                    _0x876ba444 = _0x6793063b;
            }

            _0x37e00a87 = Color.Lerp(_0x626204e9, _0xe2a4c369, _0xf9c5c99f);
        }

        _0x37e00a87.a = _0x626204e9.a;
        _0xf39e0082.color = _0x37e00a87;
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0xaa74036b;
    private void OnEnable()
    {
        if (this._0xaa74036b == null)
            this._0xaa74036b = _0x436ca63c => this._0x6e3b1778(_0x436ca63c);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0xaa74036b);
    }

    private void LateUpdate()
    {
        if (this._0x7b31710f.Count == 0)
            return;
        this._0x4e58eb3e.Clear();
        this._0x4e58eb3e.AddRange(this._0x7b31710f);
        this._0x7b31710f.Clear();
        for (int _0x73f347ea = 0; _0x73f347ea < this._0x4e58eb3e.Count; _0x73f347ea++)
            Fix(this._0x4e58eb3e[_0x73f347ea]);
    }

    private readonly List<TMP_Text> _0x4e58eb3e = new List<TMP_Text>();
    private static float Ratio(Color _0x78c2bf98, Color _0x13fe5be3)
    {
        float _0x0a87ad7c = Luminance(_0x78c2bf98);
        float _0x0f425e55 = Luminance(_0x13fe5be3);
        return (Mathf.Max(_0x0a87ad7c, _0x0f425e55) + 0.05f) / (Mathf.Min(_0x0a87ad7c, _0x0f425e55) + 0.05f);
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x6e3b1778(Object _0xf020ec6e)
    {
        TMP_Text _0xf1f886b8 = _0xf020ec6e as TMP_Text;
        if (_0xf1f886b8 != null)
            this._0x7b31710f.Add(_0xf1f886b8);
    }

    private const float MinRatio = 4.5f;
    private const float TargetRatio = 7f;
}

internal static class _0x14e0754d
{
    internal static string _0x4cdf19f0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}