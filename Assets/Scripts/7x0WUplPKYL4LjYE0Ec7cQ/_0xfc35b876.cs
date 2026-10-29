using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// A short, capped shower of gilt paper for a claim or a big line.
//
// Pooled plates on tweens rather than a particle emitter: the pieces are a fixed set,
// every one of them is linked to its own object so a scene change takes them with it
// (C.56), and the whole burst is over inside ClubConfig.ConfettiSeconds. Reduced motion
// cuts the count rather than the look.
public sealed class _0xfc35b876 : MonoBehaviour
{
    private System.Random _0xbec46d24 = new System.Random(20261029);
    private void _0xeca587f6(RectTransform _0xff1fc8d0)
    {
        if (_0xff1fc8d0 != null)
        {
            _0xff1fc8d0.gameObject.SetActive(false);
        }
    }

    private bool _0x82bd46ad;
    public void _0x3e47e0b4(Sprite _0x096eff40, Sprite[] _0x0d0c020c)
    {
        if (this._0x82bd46ad)
        {
            return;
        }

        this._0x82bd46ad = true;
        RectTransform _0x7af55869 = this.transform as RectTransform;
        if (_0x7af55869 == null)
        {
            return;
        }

        for (int _0xdb98c419 = 0; _0xdb98c419 < this._0x3a82e70a.Length; _0xdb98c419++)
        {
            RectTransform _0xb220ad69 = _0x891ecf84.Node(_0x7af55869, _0x3a1fbe78._0xc2e5103d(new byte[13] { 247, 219, 218, 210, 209, 192, 192, 221, 228, 221, 209, 215, 209 }, 180) + _0xdb98c419.ToString(), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), Vector2.zero, new Vector2(26f, 40f));
            this._0x7dde8dda[_0xdb98c419] = _0x891ecf84.Plate(_0xb220ad69, _0x096eff40, _0xc5c3f38d.Gold, 1.1f);
            _0xb220ad69.gameObject.SetActive(false);
            this._0x3a82e70a[_0xdb98c419] = _0xb220ad69;
        }
    }

    private Image[] _0x7dde8dda = new Image[_0xbbd798a9.ConfettiPieces];
    public void _0x1ed714fa(bool _0x71aeb091)
    {
        int _0xe69ef5e5 = _0x71aeb091 ? _0xbbd798a9.ConfettiPiecesReduced : _0xbbd798a9.ConfettiPieces;
        float _0x71b7a9b3 = _0x71aeb091 ? _0xbbd798a9.ConfettiSeconds * 0.6f : _0xbbd798a9.ConfettiSeconds;
        for (int _0xdfe23823 = 0; _0xdfe23823 < this._0x3a82e70a.Length; _0xdfe23823++)
        {
            RectTransform _0x59b54e84 = this._0x3a82e70a[_0xdfe23823];
            if (_0x59b54e84 == null)
            {
                continue;
            }

            if (_0xdfe23823 >= _0xe69ef5e5)
            {
                _0x59b54e84.gameObject.SetActive(false);
                continue;
            }

            this._0x3aeed246(_0x59b54e84, this._0x7dde8dda[_0xdfe23823], _0x71b7a9b3, _0xdfe23823);
        }
    }

    private RectTransform[] _0x3a82e70a = new RectTransform[_0xbbd798a9.ConfettiPieces];
    private void OnDestroy()
    {
        for (int _0x8b778f62 = 0; _0x8b778f62 < this._0x3a82e70a.Length; _0x8b778f62++)
        {
            if (this._0x3a82e70a[_0x8b778f62] != null)
            {
                DOTween.Kill(this._0x3a82e70a[_0x8b778f62]);
            }
        }
    }

    private void _0x3aeed246(RectTransform _0x93a921a7, Image _0xf185c08d, float _0xdf2032b3, int _0x30d967d6)
    {
        DOTween.Kill(_0x93a921a7);
        _0x93a921a7.gameObject.SetActive(true);
        float _0x512a82ae = (float)(this._0xbec46d24.NextDouble() * 1000d - 500d);
        float _0x8dfcdc2c = 900f + (float)(this._0xbec46d24.NextDouble() * 500d);
        float _0xc8999ec1 = (float)(this._0xbec46d24.NextDouble() * 720d - 360d);
        float _0x210beab1 = (float)(this._0xbec46d24.NextDouble() * 0.25d);
        _0x93a921a7.anchoredPosition = new Vector2(_0x512a82ae, -40f);
        _0x93a921a7.localScale = Vector3.one;
        _0x93a921a7.localEulerAngles = new Vector3(0f, 0f, (float)(this._0xbec46d24.NextDouble() * 360d));
        if (_0xf185c08d != null)
        {
            _0xf185c08d.color = _0x30d967d6 % 3 == 0 ? _0xc5c3f38d.RubyLit : (_0x30d967d6 % 3 == 1 ? _0xc5c3f38d.Gold : _0xc5c3f38d.GoldLit);
        }

        _0x93a921a7.DOAnchorPosY(-40f - _0x8dfcdc2c, _0xdf2032b3).SetEase(Ease.InQuad).SetDelay(_0x210beab1).SetLink(_0x93a921a7.gameObject);
        _0x93a921a7.DOLocalRotate(new Vector3(0f, 0f, _0xc8999ec1), _0xdf2032b3).SetEase(Ease.Linear).SetDelay(_0x210beab1).SetLink(_0x93a921a7.gameObject);
        DOVirtual.DelayedCall(_0xdf2032b3 + _0x210beab1, () => this._0xeca587f6(_0x93a921a7)).SetLink(this.gameObject);
    }
}

internal static class _0x3a1fbe78
{
    internal static string _0xc2e5103d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}