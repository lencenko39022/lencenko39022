using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x0ed56143 : MonoBehaviour
{
    private static UnityEvent _0xbbab8dd8 = new();
    private Canvas _0x23e4ed58;
    private static Rect _0xbe652d98 = Rect.zero;
    private static void SafeAreaChanged()
    {
        _0xbe652d98 = Screen.safeArea;
        for (int _0x0858a471 = 0; _0x0858a471 < _0xd8201296.Count; _0x0858a471++)
            _0xd8201296[_0x0858a471]._0x41a26cd9();
    }

    private void Awake()
    {
        if (!_0xd8201296.Contains(this))
            _0xd8201296.Add(this);
        this._0x23e4ed58 = this.GetComponent<Canvas>();
        this._0xd5836e39 = this.GetComponent<RectTransform>();
        this._0x39d2a06c = this.transform.Find(_0x969b869c._0x41b99d6c(new byte[8] { 214, 228, 227, 224, 196, 247, 224, 228 }, 133)) as RectTransform;
        if (!_0x48b58047)
        {
            _0x2855ec1b = Screen.orientation;
            _0x7fe8c123.x = Screen.width;
            _0x7fe8c123.y = Screen.height;
            _0xbe652d98 = Screen.safeArea;
            _0x48b58047 = true;
        }

        this._0x41a26cd9();
    }

    private void _0x41a26cd9()
    {
        if (this._0x39d2a06c == null)
            return;
        Rect _0x9c513b32 = Screen.safeArea;
        Vector2 _0xd8b78889 = _0x9c513b32.position;
        Vector2 _0xd2f29bf7 = _0x9c513b32.position + _0x9c513b32.size;
        _0xd8b78889.x /= this._0x23e4ed58.pixelRect.width;
        _0xd8b78889.y /= this._0x23e4ed58.pixelRect.height;
        _0xd2f29bf7.x /= this._0x23e4ed58.pixelRect.width;
        _0xd2f29bf7.y /= this._0x23e4ed58.pixelRect.height;
        this._0x39d2a06c.anchorMin = _0xd8b78889;
        this._0x39d2a06c.anchorMax = _0xd2f29bf7;
    }

    private static void ResolutionChanged()
    {
        _0x7fe8c123.x = Screen.width;
        _0x7fe8c123.y = Screen.height;
        _0xbbab8dd8.Invoke();
    }

    private RectTransform _0xd5836e39;
    private static bool _0x48b58047;
    private static void OrientationChanged()
    {
        _0x2855ec1b = Screen.orientation;
        _0x7fe8c123.x = Screen.width;
        _0x7fe8c123.y = Screen.height;
        _0xbbab8dd8.Invoke();
    }

    private void OnDestroy()
    {
        if (_0xd8201296 != null && _0xd8201296.Contains(this))
            _0xd8201296.Remove(this);
    }

    private static readonly List<_0x0ed56143> _0xd8201296 = new();
    private void Update()
    {
        if (_0xd8201296[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x2855ec1b)
            OrientationChanged();
        if (Screen.safeArea != _0xbe652d98)
            SafeAreaChanged();
        if (Screen.width != _0x7fe8c123.x || Screen.height != _0x7fe8c123.y)
            ResolutionChanged();
    }

    private static ScreenOrientation _0x2855ec1b = ScreenOrientation.LandscapeLeft;
    private RectTransform _0x39d2a06c;
    private static Vector2 _0x7fe8c123 = Vector2.zero;
}

internal static class _0x969b869c
{
    internal static string _0x41b99d6c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}