using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xe98b8b64 : MonoBehaviour
{
    private static void OrientationChanged()
    {
        _0xfde88266 = Screen.orientation;
        _0xb2b7efa6.x = Screen.width;
        _0xb2b7efa6.y = Screen.height;
        _0xa2f433c6 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x6472dd7f.Invoke();
    }

    private static Vector2 _0xb2b7efa6 = Vector2.zero;
    private RectTransform _0x97795416;
    private static Rect _0xa2f433c6 = Rect.zero;
    private void OnDestroy()
    {
        if (_0x9f324222 != null && _0x9f324222.Contains(this))
            _0x9f324222.Remove(this);
    }

    private void Start()
    {
    }

    private static ScreenOrientation _0xfde88266 = ScreenOrientation.LandscapeLeft;
    private Vector2 _0x45319abc;
    private Canvas _0xe5094656;
    private RectTransform _0xb8844111;
    private CanvasScaler _0xb160193b;
    private static readonly List<_0xe98b8b64> _0x9f324222 = new();
    private static void ResolutionChanged()
    {
        _0xb2b7efa6.x = Screen.width;
        _0xb2b7efa6.y = Screen.height;
        _0xa2f433c6 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x6472dd7f.Invoke();
    }

    private static bool _0x1b489dab;
    private static UnityEvent _0x6472dd7f = new();
    private void _0x76cab882()
    {
        if (this._0x97795416 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x6bc173ab = Screen.safeArea;
        Vector2 _0xc245784e = _0x6bc173ab.position;
        Vector2 _0x7e3854b2 = _0x6bc173ab.position + _0x6bc173ab.size;
        _0xc245784e.x /= screenWidth;
        _0xc245784e.y /= screenHeight;
        _0x7e3854b2.x /= screenWidth;
        _0x7e3854b2.y /= screenHeight;
        this._0x97795416.anchorMin = _0xc245784e;
        this._0x97795416.anchorMax = _0x7e3854b2;
        this._0x97795416.offsetMin = Vector2.zero;
        this._0x97795416.offsetMax = Vector2.zero;
        if (this._0xb160193b == null)
            return;
        Vector2 _0xb97c6313 = _0x7e3854b2 - _0xc245784e;
        float _0x65ea5058 = 2f - _0xb97c6313.x;
        float _0x6c2daebf = 2f - _0xb97c6313.y;
        this._0xb160193b.referenceResolution = this._0x45319abc * new Vector2(_0x65ea5058, _0x6c2daebf);
    }

    private static void SafeAreaChanged()
    {
        _0xa2f433c6 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static void ApplySafeAreaToAll()
    {
        for (int _0xbb095b5c = 0; _0xbb095b5c < _0x9f324222.Count; _0xbb095b5c++)
            _0x9f324222[_0xbb095b5c]._0x76cab882();
    }

    private void Awake()
    {
        if (!_0x9f324222.Contains(this))
            _0x9f324222.Add(this);
        this._0xe5094656 = this.GetComponent<Canvas>();
        this._0xb160193b = this.GetComponent<CanvasScaler>();
        if (this._0xb160193b != null)
            this._0x45319abc = this._0xb160193b.referenceResolution;
        this._0xb8844111 = this.GetComponent<RectTransform>();
        this._0x97795416 = this.transform.Find(_0x8dba5cb5._0x01e0c92c(new byte[8] { 232, 218, 221, 222, 250, 201, 222, 218 }, 187)) as RectTransform;
        if (!_0x1b489dab)
        {
            _0xfde88266 = Screen.orientation;
            _0xb2b7efa6.x = Screen.width;
            _0xb2b7efa6.y = Screen.height;
            _0xa2f433c6 = Screen.safeArea;
            _0x1b489dab = true;
        }

        this._0x76cab882();
    }

    private void Update()
    {
        if (_0x9f324222.Count == 0 || _0x9f324222[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xfde88266)
            OrientationChanged();
        if (Screen.safeArea != _0xa2f433c6)
            SafeAreaChanged();
        if (Screen.width != _0xb2b7efa6.x || Screen.height != _0xb2b7efa6.y)
            ResolutionChanged();
    }
}

internal static class _0x8dba5cb5
{
    internal static string _0x01e0c92c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}