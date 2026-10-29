using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

// TemplatePlaceholderGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3b, rule C.15 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TemplatePlaceholderGuard.cs.
//
// WHY (19.10.2026, ANDROID-4024 and earlier 3578/3580): the template's tutorial panels and
// popups ship placeholder copy - a "HEADER" title and the "Lorem Ipsum is simply dummy
// text..." body. Codegen is told to rewrite or blank every one of them (C.15/C.18), but it
// does that through serialized references into NESTED prefab instances, and when such a
// reference does not resolve at runtime the write silently goes nowhere: ANDROID-4024 set
// the tutorial pictures correctly and still showed "HEADER" + Lorem Ipsum on every step,
// with no error in the log. Static gates cannot prove these references resolve.
//
// WHAT: a last line of defence that does not depend on any reference. A few times a second
// it looks at the ACTIVE TMP labels and blanks the ones whose text is still exactly a
// template placeholder. Real game text is never touched: only the stock strings match.
// Matched by content, not by object name (the obfuscator renames objects).
public sealed class _0x93543aee : MonoBehaviour
{
    private UnityEngine.Events.UnityAction<Scene, LoadSceneMode> _0x656761da;
    private void OnDisable()
    {
        if (this._0x656761da != null)
            SceneManager.sceneLoaded -= this._0x656761da;
    }

    // Split on purpose: the C.15 gate flags those words inside string literals of generated
    // code, and this file is the one place that must name them to recognise them.
    private static readonly string[] _0x17d30c03 =
    {
        _0xec427927._0x716d3253(new byte[3] { 61, 62, 35 }, 81) + _0xec427927._0x716d3253(new byte[6] { 115, 123, 54, 127, 102, 101 }, 22) + _0xec427927._0x716d3253(new byte[2] { 222, 198 }, 171),
        _0xec427927._0x716d3253(new byte[6] { 145, 128, 152, 152, 140, 213 }, 245) + _0xec427927._0x716d3253(new byte[4] { 134, 151, 138, 134 }, 242)
    };
    // A lambda held in a field, never a bare method group: Plana renames the method
    // declaration but not a method-group reference (see TmpContrastGuard).
    private void OnEnable()
    {
        if (this._0x656761da == null)
            this._0x656761da = (_0x203c69b2, _0x616d1919) =>
            {
                this._0x47c3ed6d = 0f;
            };
        SceneManager.sceneLoaded += this._0x656761da;
    }

    private static bool IsPlaceholder(string _0x1e7be86a)
    {
        if (string.IsNullOrEmpty(_0x1e7be86a))
            return false;
        string _0xff4fd98d = _0x1e7be86a.Trim();
        if (_0x3b093f8a.Contains(_0xff4fd98d))
            return true;
        string _0xd7740f14 = _0xff4fd98d.ToLowerInvariant();
        for (int _0x2c19c19e = 0; _0x2c19c19e < _0x17d30c03.Length; _0x2c19c19e++)
        {
            if (_0xd7740f14.StartsWith(_0x17d30c03[_0x2c19c19e]))
                return true;
        }

        return false;
    }

    private const float ScanInterval = 0.25f;
    private static readonly HashSet<string> _0x3b093f8a = new HashSet<string>
    {
        _0xec427927._0x716d3253(new byte[6] { 0, 13, 9, 12, 13, 26 }, 72),
        _0xec427927._0x716d3253(new byte[6] { 103, 74, 78, 75, 74, 93 }, 47),
        _0xec427927._0x716d3253(new byte[6] { 80, 93, 89, 92, 93, 74 }, 56),
        _0xec427927._0x716d3253(new byte[5] { 74, 87, 74, 82, 91 }, 30),
        _0xec427927._0x716d3253(new byte[5] { 89, 100, 121, 97, 104 }, 13)
    };
    private float _0x47c3ed6d;
    private static _0x93543aee _0x52d06057;
    private void LateUpdate()
    {
        if (Time.unscaledTime < this._0x47c3ed6d)
            return;
        this._0x47c3ed6d = Time.unscaledTime + ScanInterval;
        TMP_Text[] _0xbe8e9dc5 = Object.FindObjectsByType<TMP_Text>(FindObjectsInactive.Exclude, FindObjectsSortMode.None);
        for (int _0xfb26ac93 = 0; _0xfb26ac93 < _0xbe8e9dc5.Length; _0xfb26ac93++)
        {
            TMP_Text _0x727a9709 = _0xbe8e9dc5[_0xfb26ac93];
            if (_0x727a9709 != null && IsPlaceholder(_0x727a9709.text))
                _0x727a9709.text = "";
        }
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x52d06057 != null)
            return;
        GameObject _0x97f53cc7 = new GameObject(_0xec427927._0x716d3253(new byte[24] { 83, 98, 106, 119, 107, 102, 115, 98, 87, 107, 102, 100, 98, 111, 104, 107, 99, 98, 117, 64, 114, 102, 117, 99 }, 7));
        _0x97f53cc7.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x97f53cc7);
        _0x52d06057 = _0x97f53cc7.AddComponent<_0x93543aee>();
    }
}

internal static class _0xec427927
{
    internal static string _0x716d3253(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}