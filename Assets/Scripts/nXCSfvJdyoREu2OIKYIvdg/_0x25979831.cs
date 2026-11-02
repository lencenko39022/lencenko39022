using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Shared chrome of a secondary screen: full-bleed dim, a heading, a back button and an
/// empty body the owning screen fills. Screens hold one of these rather than deriving
/// from it, so there is no base class to inherit from.
/// </summary>
public sealed class _0x25979831 : MonoBehaviour
{
    public _0x25979831 _0x03be6e46(RectTransform _0x42b28b1e, _0x51685ac3 _0x9b2aacdc, string _0xa6d61189, bool _0xf86e409c, System.Action _0xe5780cf0)
    {
        this._0x40c7c18d = _0x211a051a.Stretch(_0x42b28b1e, _0xcf5ed15a._0x0058bd4e(new byte[7] { 218, 236, 234, 253, 224, 230, 231 }, 137));
        this._0x1e51fb7a = this._0x40c7c18d.gameObject.AddComponent<CanvasGroup>();
        _0x211a051a.Plate(this._0x40c7c18d, _0xcf5ed15a._0x0058bd4e(new byte[3] { 27, 54, 50 }, 95), _0x9b2aacdc._0x9bc213f0, new Color(0.0431f, 0.0431f, 0.0588f, 0.92f), 1f);
        if (!string.IsNullOrEmpty(_0xa6d61189))
            this._0x1e82071b = _0x211a051a.Label(this._0x40c7c18d, _0xcf5ed15a._0x0058bd4e(new byte[7] { 80, 125, 121, 124, 113, 118, 127 }, 24), _0x9b2aacdc._0x50577ddc, _0xa6d61189, 56f, _0xdc7245d7.Gold, TextAlignmentOptions.Center, 0.5f, 0.952f, 820f, 96f);
        if (_0xf86e409c)
        {
            Button _0xd578f20e = _0x211a051a.Action(this._0x40c7c18d, _0xcf5ed15a._0x0058bd4e(new byte[4] { 174, 141, 143, 135 }, 236), _0x9b2aacdc._0x50577ddc, _0x9b2aacdc._0xf4df0193, _0xcf5ed15a._0x0058bd4e(new byte[1] { 85 }, 105), 52f, _0xdc7245d7.ScarletDeep, _0xdc7245d7.Gold, _0xdc7245d7.Parchment, 0.115f, 0.952f, 150f, 110f);
            _0xd578f20e.onClick.AddListener(() => _0xe5780cf0());
        }

        this._0x8c8f780f = _0x211a051a.Node(this._0x40c7c18d, _0xcf5ed15a._0x0058bd4e(new byte[4] { 88, 117, 126, 99 }, 26), new Vector2(0.03f, 0.06f), new Vector2(0.97f, 0.912f), Vector2.zero, Vector2.zero);
        this._0x40c7c18d.gameObject.SetActive(false);
        return this;
    }

    private TextMeshProUGUI _0x1e82071b;
    private RectTransform _0x40c7c18d;
    public void _0xd8c998fc(string _0x4bc9fd33)
    {
        if (this._0x1e82071b != null)
            this._0x1e82071b.text = _0x4bc9fd33;
    }

    private RectTransform _0x8c8f780f;
    public RectTransform _0x81b31132
    {
        get
        {
            return this._0x8c8f780f;
        }
    }

    public RectTransform _0x10966145
    {
        get
        {
            return this._0x40c7c18d;
        }
    }

    private void OnDestroy()
    {
        if (this._0x1e51fb7a != null)
            DOTween.Kill(this._0x1e51fb7a);
        if (this._0x40c7c18d != null)
            DOTween.Kill(this._0x40c7c18d);
    }

    private CanvasGroup _0x1e51fb7a;
    /// <summary>Slides in from the right and fades up; every tween dies with the screen.</summary>
    public void Enter()
    {
        this._0x40c7c18d.gameObject.SetActive(true);
        DOTween.Kill(this._0x1e51fb7a, true);
        DOTween.Kill(this._0x40c7c18d, true);
        this._0x1e51fb7a.alpha = 0f;
        this._0x40c7c18d.offsetMin = new Vector2(48f, 0f);
        this._0x40c7c18d.offsetMax = new Vector2(48f, 0f);
        this._0x1e51fb7a.DOFade(1f, 0.26f).SetEase(Ease.OutQuad).SetLink(this._0x40c7c18d.gameObject);
        this._0x40c7c18d.DOAnchorPosX(0f, 0.26f).SetEase(Ease.OutQuad).SetLink(this._0x40c7c18d.gameObject);
    }

    public void _0xc07ff068()
    {
        DOTween.Kill(this._0x1e51fb7a, true);
        DOTween.Kill(this._0x40c7c18d, true);
        this._0x40c7c18d.gameObject.SetActive(false);
    }
}

internal static class _0xcf5ed15a
{
    internal static string _0x0058bd4e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}