using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Themes the template splash from the scene side only: the splash script itself is the
/// template owner's and is never touched. The loading bar keeps a visible fill because
/// its fill area is inset by a SHARE of the bar height, never by fixed units.
/// </summary>
public sealed class _0x92f3c8ff : MonoBehaviour
{
    /// <summary>
    /// Re-anchors the bar and its fill area by share. Fixed vertical insets are exactly
    /// what used to swallow the fill once the frame got thicker.
    /// </summary>
    private void _0xe4ac5608(_0x92b6f7a4 _0x184baaa5)
    {
        Slider _0xbdfc3466 = _0x184baaa5.AnimationSlider;
        if (_0xbdfc3466 == null || _0xbdfc3466.fillRect == null)
            return;
        RectTransform _0xcdd03712 = _0xbdfc3466.transform as RectTransform;
        if (_0xcdd03712 != null)
        {
            _0xcdd03712.anchorMin = new Vector2(0f, 0f);
            _0xcdd03712.anchorMax = new Vector2(1f, 1f);
            _0xcdd03712.offsetMin = new Vector2(0f, 0f);
            _0xcdd03712.offsetMax = new Vector2(0f, 0f);
        }

        RectTransform _0x443fff95 = _0xcdd03712 == null ? null : _0xcdd03712.parent as RectTransform;
        if (_0x443fff95 != null)
        {
            _0x443fff95.anchorMin = new Vector2(0f, 0f);
            _0x443fff95.anchorMax = new Vector2(1f, 1f);
            _0x443fff95.offsetMin = new Vector2(0f, 0f);
            _0x443fff95.offsetMax = new Vector2(0f, 0f);
        }

        RectTransform _0x6993206e = _0x443fff95 == null ? null : _0x443fff95.parent as RectTransform;
        if (_0x6993206e != null)
        {
            _0x6993206e.anchorMin = new Vector2(0.14f, 0.148f);
            _0x6993206e.anchorMax = new Vector2(0.86f, 0.182f);
            _0x6993206e.offsetMin = new Vector2(0f, 0f);
            _0x6993206e.offsetMax = new Vector2(0f, 0f);
            Image _0x22e15ac2 = _0x211a051a.Plate(_0x6993206e, _0xe070e214._0x76d065e3(new byte[8] { 2, 33, 50, 6, 50, 33, 45, 37 }, 64), this._theme._0x9bc213f0, _0xdc7245d7.GoldDark, 2.2f);
            _0x22e15ac2.rectTransform.SetAsFirstSibling();
        }

        RectTransform _0x8e9129d3 = _0xbdfc3466.fillRect.parent as RectTransform;
        if (_0x8e9129d3 != null)
        {
            _0x8e9129d3.anchorMin = new Vector2(0f, 0.2f);
            _0x8e9129d3.anchorMax = new Vector2(1f, 0.8f);
            _0x8e9129d3.offsetMin = new Vector2(10f, 0f);
            _0x8e9129d3.offsetMax = new Vector2(-10f, 0f);
            Image _0x0c1f1505 = _0x8e9129d3.GetComponent<Image>();
            if (_0x0c1f1505 != null)
            {
                _0x0c1f1505.color = new Color(0.1647f, 0.0275f, 0.0627f, 0.92f);
                _0x0c1f1505.enabled = true;
            }

            _0x8e9129d3.gameObject.SetActive(true);
        }

        Image _0xf4034cd6 = _0xbdfc3466.fillRect.GetComponent<Image>();
        if (_0xf4034cd6 != null)
        {
            _0xf4034cd6.color = _0xdc7245d7.Gold;
            _0xf4034cd6.enabled = true;
        }

        _0xbdfc3466.fillRect.gameObject.SetActive(true);
        if (_0xbdfc3466.handleRect != null)
            _0xbdfc3466.handleRect.gameObject.SetActive(false);
    }

    private void Start()
    {
        if (this._theme == null)
            return;
        _0x92b6f7a4 _0x2733b30f = this.GetComponentInParent<_0x92b6f7a4>();
        if (_0x2733b30f == null)
            return;
        RectTransform _0xeb3f9592 = this.transform as RectTransform;
        if (_0xeb3f9592 == null)
            return;
        _0xeb3f9592.anchorMin = Vector2.zero;
        _0xeb3f9592.anchorMax = Vector2.one;
        _0xeb3f9592.offsetMin = Vector2.zero;
        _0xeb3f9592.offsetMax = Vector2.zero;
        this._0xef8967f0(_0xeb3f9592);
        this._0x2c711c17(_0xeb3f9592);
        this._0xe4ac5608(_0x2733b30f);
    }

    [SerializeField]
    private _0x51685ac3 _theme;
    private void _0x2c711c17(RectTransform _0xe3df6bc5)
    {
        this._0x328e68d0 = _0x211a051a.Box(_0xe3df6bc5, _0xe070e214._0x76d065e3(new byte[10] { 165, 134, 154, 151, 133, 158, 187, 151, 132, 157 }, 246), 0.5f, 0.60f, 440f, 440f);
        this._0x0967259a = this._0x328e68d0.gameObject.AddComponent<CanvasGroup>();
        _0x211a051a.Picture(this._0x328e68d0, _0xe070e214._0x76d065e3(new byte[3] { 74, 121, 127 }, 11), this._theme._0x2d9ff0d6, 0.5f, 0.5f, 420f, 420f, Color.white);
        _0x211a051a.Label(_0xe3df6bc5, _0xe070e214._0x76d065e3(new byte[13] { 59, 24, 4, 9, 27, 0, 43, 9, 24, 28, 1, 7, 6 }, 104), this._theme._0x50577ddc, _0xe070e214._0x76d065e3(new byte[7] { 38, 37, 43, 46, 35, 36, 45 }, 106), 40f, _0xdc7245d7.GoldLight, TextAlignmentOptions.Center, 0.5f, 0.235f, 900f, 66f);
        this._0x0967259a.alpha = 0f;
        this._0x328e68d0.localScale = new Vector3(0.86f, 0.86f, 1f);
        this._0x0967259a.DOFade(1f, 0.5f).SetEase(Ease.OutQuad).SetLink(this._0x328e68d0.gameObject);
        this._0x328e68d0.DOScale(1f, 0.6f).SetEase(Ease.OutBack, 1.7f).SetLink(this._0x328e68d0.gameObject);
    }

    private void _0xef8967f0(RectTransform _0x54ce807a)
    {
        Image _0xb498f1ce = _0x211a051a.Plate(_0x54ce807a, _0xe070e214._0x76d065e3(new byte[11] { 60, 31, 3, 14, 28, 7, 60, 12, 29, 6, 2 }, 111), this._theme._0x9bc213f0, new Color(0.0431f, 0.0431f, 0.0588f, 0.88f), 1f);
        _0xb498f1ce.raycastTarget = false;
        _0xb498f1ce.rectTransform.SetAsFirstSibling();
        RectTransform _0x94b2a7ce = _0x211a051a.Node(_0x54ce807a, _0xe070e214._0x76d065e3(new byte[13] { 234, 201, 213, 216, 202, 209, 239, 216, 213, 216, 215, 218, 220 }, 185), new Vector2(0f, 0.90f), new Vector2(1f, 1f), Vector2.zero, Vector2.zero);
        Image _0x3706af25 = _0x94b2a7ce.gameObject.AddComponent<Image>();
        _0x3706af25.sprite = this._theme._0xc5d1e44f;
        _0x3706af25.type = this._theme._0xc5d1e44f == null ? Image.Type.Simple : Image.Type.Sliced;
        _0x3706af25.color = this._theme._0xc5d1e44f == null ? _0xdc7245d7.ScarletDeep : new Color(1f, 1f, 1f, 0.85f);
        _0x211a051a.Slice(_0x3706af25, 1f);
        _0x3706af25.raycastTarget = false;
    }

    private RectTransform _0x328e68d0;
    private void OnDestroy()
    {
        if (this._0x328e68d0 != null)
            DOTween.Kill(this._0x328e68d0);
        if (this._0x0967259a != null)
            DOTween.Kill(this._0x0967259a);
    }

    private CanvasGroup _0x0967259a;
}

internal static class _0xe070e214
{
    internal static string _0x76d065e3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}