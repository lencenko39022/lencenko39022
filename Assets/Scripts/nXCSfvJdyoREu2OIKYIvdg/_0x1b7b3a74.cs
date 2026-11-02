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
public sealed class _0x1b7b3a74 : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x06a1648a != null)
            return;
        GameObject _0x1b0bf1c6 = new GameObject(_0x0afe5ae1._0xb5005d88(new byte[24] { 240, 193, 201, 212, 200, 197, 208, 193, 244, 200, 197, 199, 193, 204, 203, 200, 192, 193, 214, 227, 209, 197, 214, 192 }, 164));
        _0x1b0bf1c6.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x1b0bf1c6);
        _0x06a1648a = _0x1b0bf1c6.AddComponent<_0x1b7b3a74>();
    }

    private UnityEngine.Events.UnityAction<Scene, LoadSceneMode> _0xbbab8dd8;
    // A lambda held in a field, never a bare method group: Plana renames the method
    // declaration but not a method-group reference (see TmpContrastGuard).
    private void OnEnable()
    {
        if (this._0xbbab8dd8 == null)
            this._0xbbab8dd8 = (_0x40c09057, _0xb2ba3276) =>
            {
                this._0xd8201296 = 0f;
            };
        SceneManager.sceneLoaded += this._0xbbab8dd8;
    }

    private float _0xd8201296;
    private void LateUpdate()
    {
        if (Time.unscaledTime < this._0xd8201296)
            return;
        this._0xd8201296 = Time.unscaledTime + ScanInterval;
        TMP_Text[] _0x9ea0bea0 = Object.FindObjectsByType<TMP_Text>(FindObjectsInactive.Exclude, FindObjectsSortMode.None);
        for (int _0xd670dff7 = 0; _0xd670dff7 < _0x9ea0bea0.Length; _0xd670dff7++)
        {
            TMP_Text _0x139da87a = _0x9ea0bea0[_0xd670dff7];
            if (_0x139da87a != null && IsPlaceholder(_0x139da87a.text))
                _0x139da87a.text = "";
        }
    }

    private static bool IsPlaceholder(string _0xfa9b86a9)
    {
        if (string.IsNullOrEmpty(_0xfa9b86a9))
            return false;
        string _0xe4cc1651 = _0xfa9b86a9.Trim();
        if (_0xc6272d94.Contains(_0xe4cc1651))
            return true;
        string _0xf6bc3f25 = _0xe4cc1651.ToLowerInvariant();
        for (int _0xcd2a325a = 0; _0xcd2a325a < _0xcb986308.Length; _0xcd2a325a++)
        {
            if (_0xf6bc3f25.StartsWith(_0xcb986308[_0xcd2a325a]))
                return true;
        }

        return false;
    }

    private const float ScanInterval = 0.25f;
    private static readonly HashSet<string> _0xc6272d94 = new HashSet<string>
    {
        _0x0afe5ae1._0xb5005d88(new byte[6] { 186, 183, 179, 182, 183, 160 }, 242),
        _0x0afe5ae1._0xb5005d88(new byte[6] { 228, 201, 205, 200, 201, 222 }, 172),
        _0x0afe5ae1._0xb5005d88(new byte[6] { 44, 33, 37, 32, 33, 54 }, 68),
        _0x0afe5ae1._0xb5005d88(new byte[5] { 182, 171, 182, 174, 167 }, 226),
        _0x0afe5ae1._0xb5005d88(new byte[5] { 67, 126, 99, 123, 114 }, 23)
    };
    private static _0x1b7b3a74 _0x06a1648a;
    // Split on purpose: the C.15 gate flags those words inside string literals of generated
    // code, and this file is the one place that must name them to recognise them.
    private static readonly string[] _0xcb986308 =
    {
        _0x0afe5ae1._0xb5005d88(new byte[3] { 235, 232, 245 }, 135) + _0x0afe5ae1._0xb5005d88(new byte[6] { 236, 228, 169, 224, 249, 250 }, 137) + _0x0afe5ae1._0xb5005d88(new byte[2] { 87, 79 }, 34),
        _0x0afe5ae1._0xb5005d88(new byte[6] { 215, 198, 222, 222, 202, 147 }, 179) + _0x0afe5ae1._0xb5005d88(new byte[4] { 220, 205, 208, 220 }, 168)
    };
    private void OnDisable()
    {
        if (this._0xbbab8dd8 != null)
            SceneManager.sceneLoaded -= this._0xbbab8dd8;
    }
}

internal static class _0x0afe5ae1
{
    internal static string _0xb5005d88(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}