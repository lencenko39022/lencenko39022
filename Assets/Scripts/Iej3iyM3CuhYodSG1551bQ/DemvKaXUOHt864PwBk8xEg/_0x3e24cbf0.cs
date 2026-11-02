using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x3e24cbf0 : MonoBehaviour
{
    private static void ResolutionChanged()
    {
        _0x91a1ea86.x = Screen.width;
        _0x91a1ea86.y = Screen.height;
        _0x17b78224.Invoke();
    }

    private RectTransform _0xb30f39e7;
    private void Update()
    {
        if (_0x5f1e2e01[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x7e31d4e7)
            OrientationChanged();
        if (Screen.safeArea != _0x5df4ba62)
            SafeAreaChanged();
        if (Screen.width != _0x91a1ea86.x || Screen.height != _0x91a1ea86.y)
            ResolutionChanged();
    }

    private static UnityEvent _0x17b78224 = new();
    private Canvas _0x60496811;
    private static void OrientationChanged()
    {
        _0x7e31d4e7 = Screen.orientation;
        _0x91a1ea86.x = Screen.width;
        _0x91a1ea86.y = Screen.height;
        _0x17b78224.Invoke();
    }

    private static Vector2 _0x91a1ea86 = Vector2.zero;
    private void Awake()
    {
        if (!_0x5f1e2e01.Contains(this))
            _0x5f1e2e01.Add(this);
        this._0x60496811 = this.GetComponent<Canvas>();
        this._0xb30f39e7 = this.GetComponent<RectTransform>();
        this._0x3d702a0d = this.transform.Find(_0x093ebf1b._0x9f2af8db(new byte[8] { 130, 176, 183, 180, 144, 163, 180, 176 }, 209)) as RectTransform;
        if (!_0xfea8ede8)
        {
            _0x7e31d4e7 = Screen.orientation;
            _0x91a1ea86.x = Screen.width;
            _0x91a1ea86.y = Screen.height;
            _0x5df4ba62 = Screen.safeArea;
            _0xfea8ede8 = true;
        }

        this._0xdc6149ef();
    }

    private void _0xdc6149ef()
    {
        if (this._0x3d702a0d == null)
            return;
        Rect _0x8c21a9f5 = Screen.safeArea;
        Vector2 _0x1c901548 = _0x8c21a9f5.position;
        Vector2 _0xe9c21996 = _0x8c21a9f5.position + _0x8c21a9f5.size;
        _0x1c901548.x /= this._0x60496811.pixelRect.width;
        _0x1c901548.y /= this._0x60496811.pixelRect.height;
        _0xe9c21996.x /= this._0x60496811.pixelRect.width;
        _0xe9c21996.y /= this._0x60496811.pixelRect.height;
        this._0x3d702a0d.anchorMin = _0x1c901548;
        this._0x3d702a0d.anchorMax = _0xe9c21996;
    }

    private void OnDestroy()
    {
        if (_0x5f1e2e01 != null && _0x5f1e2e01.Contains(this))
            _0x5f1e2e01.Remove(this);
    }

    private static bool _0xfea8ede8;
    private static void SafeAreaChanged()
    {
        _0x5df4ba62 = Screen.safeArea;
        for (int _0xc66b5af8 = 0; _0xc66b5af8 < _0x5f1e2e01.Count; _0xc66b5af8++)
            _0x5f1e2e01[_0xc66b5af8]._0xdc6149ef();
    }

    private static ScreenOrientation _0x7e31d4e7 = ScreenOrientation.LandscapeLeft;
    private static Rect _0x5df4ba62 = Rect.zero;
    private static readonly List<_0x3e24cbf0> _0x5f1e2e01 = new();
    private RectTransform _0x3d702a0d;
}

internal static class _0x093ebf1b
{
    internal static string _0x9f2af8db(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}