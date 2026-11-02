using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// A local-only profile: no account, no sign-in, no server. The mask can be swapped for
/// any curio already pinned to the wall, and the change shows at once in the ring.
/// </summary>
public sealed class _0xb5f4e158 : MonoBehaviour, _0xeb461ae5
{
    private void _0x630d69fa()
    {
        int _0x9f6bdcda = _0x0331a644.TrinketsOwned();
        int _0x61dde132 = _0x0331a644._0xeec1adba;
        for (int _0xa0bea026 = 0; _0xa0bea026 < _0x0331a644.TrinketCount + 1; _0xa0bea026++)
        {
            _0x61dde132 = (_0x61dde132 + 1) % (_0x0331a644.TrinketCount + 1);
            if (_0x61dde132 == 0)
                break;
            if (_0x0331a644.TrinketUnlocked(_0x61dde132 - 1))
                break;
        }

        if (_0x9f6bdcda <= 0)
            _0x61dde132 = 0;
        _0x0331a644._0xeec1adba = _0x61dde132;
        PlayerPrefs.Save();
        this._0x6876c77e();
        this._0xb2b29299._0x612335fc();
        if (this._0x05b49d81 != null)
            this._0x05b49d81.DOPunchScale(new Vector3(0.08f, 0.08f, 0f), 0.3f, 7, 0.7f).SetLink(this._0x05b49d81.gameObject);
    }

    private void _0x6876c77e()
    {
        this._0xfe2f863c.sprite = this._0x21335344._0x2b503346(_0x0331a644._0xeec1adba);
        this._0xfe2f863c.enabled = this._0xfe2f863c.sprite != null;
        this._0xa2ba9c64.text = _0x0331a644._0xe07e3fcb;
        this._0x04dcb8e0[0].text = _0x0331a644._0x98e65b37;
        this._0x04dcb8e0[1].text = _0x4b563ca7.StageName(_0x0331a644._0xb9e14fc1);
        this._0x04dcb8e0[2].text = _0x0331a644._0xac075e85.ToString();
        this._0x04dcb8e0[3].text = _0x0331a644.Money(_0x0331a644._0x7c678146);
        for (int _0x31eff240 = 0; _0x31eff240 < RowCount; _0x31eff240++)
            _0xf9bbd821.ApplyOutline(this._0x04dcb8e0[_0x31eff240]);
    }

    private RectTransform _0x05b49d81;
    private _0x51685ac3 _0x21335344;
    private _0x529d8e09 _0xb2b29299;
    private const int RowCount = 4;
    private readonly TextMeshProUGUI[] _0x04dcb8e0 = new TextMeshProUGUI[RowCount];
    public RectTransform Root
    {
        get
        {
            return this._0x97c7754d == null ? null : this._0x97c7754d._0x10966145;
        }
    }

    public void Enter()
    {
        this._0x6876c77e();
        if (this._0x97c7754d != null)
            this._0x97c7754d.Enter();
    }

    public _0xb5f4e158 _0x7f98dee0(_0x51685ac3 _0x8cfa9946, _0x529d8e09 _0x5708be5a)
    {
        this._0x21335344 = _0x8cfa9946;
        this._0xb2b29299 = _0x5708be5a;
        this._0x97c7754d = this.gameObject.AddComponent<_0x25979831>()._0x03be6e46(this.transform as RectTransform, _0x8cfa9946, _0xe5fc837b._0x52fbefbe(new byte[7] { 147, 145, 140, 133, 138, 143, 134 }, 195), true, () => _0x5708be5a._0xbda30b26());
        RectTransform _0x66926425 = this._0x97c7754d._0x81b31132;
        this._0x05b49d81 = _0x211a051a.Box(_0x66926425, _0xe5fc837b._0x52fbefbe(new byte[4] { 80, 107, 108, 101 }, 2), 0.5f, 0.820f, 340f, 340f);
        _0x211a051a.Plate(this._0x05b49d81, _0xe5fc837b._0x52fbefbe(new byte[5] { 63, 5, 4, 21, 2 }, 112), _0x8cfa9946._0xf4df0193, _0xdc7245d7.Gold, 1.4f);
        RectTransform _0x5fe4ccd0 = _0x211a051a.Node(this._0x05b49d81, _0xe5fc837b._0x52fbefbe(new byte[5] { 32, 7, 7, 12, 27 }, 105), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-22f, -22f));
        _0x211a051a.Plate(_0x5fe4ccd0, _0xe5fc837b._0x52fbefbe(new byte[4] { 87, 120, 125, 125 }, 17), _0x8cfa9946._0xf4df0193, _0xdc7245d7.PanelBase, 1.6f);
        this._0xfe2f863c = _0x211a051a.Picture(this._0x05b49d81, _0xe5fc837b._0x52fbefbe(new byte[4] { 125, 81, 67, 91 }, 48), _0x8cfa9946._0x2d9ff0d6, 0.5f, 0.5f, 240f, 240f, Color.white);
        this._0xa2ba9c64 = _0x211a051a.Label(_0x66926425, _0xe5fc837b._0x52fbefbe(new byte[5] { 111, 66, 71, 79, 93 }, 46), _0x8cfa9946._0x50577ddc, "", 64f, _0xdc7245d7.Gold, TextAlignmentOptions.Center, 0.5f, 0.660f, 1000f, 96f);
        _0x211a051a.Label(_0x66926425, _0xe5fc837b._0x52fbefbe(new byte[9] { 93, 112, 117, 125, 111, 84, 117, 114, 104 }, 28), _0x8cfa9946._0x50577ddc, _0xe5fc837b._0x52fbefbe(new byte[35] { 170, 188, 166, 161, 211, 189, 178, 190, 182, 211, 191, 186, 165, 182, 160, 211, 188, 189, 211, 167, 187, 186, 160, 211, 183, 182, 165, 186, 176, 182, 211, 188, 189, 191, 170 }, 243), 28f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 0.5f, 0.610f, 1000f, 48f);
        Button _0xf17b8b3b = _0x211a051a.Action(_0x66926425, _0xe5fc837b._0x52fbefbe(new byte[10] { 84, 127, 118, 121, 112, 114, 90, 118, 100, 124 }, 23), _0x8cfa9946._0x50577ddc, _0x8cfa9946._0xcef53720, _0xe5fc837b._0x52fbefbe(new byte[11] { 6, 13, 4, 11, 2, 0, 101, 8, 4, 22, 14 }, 69), 36f, _0xdc7245d7.Scarlet, _0xdc7245d7.Gold, _0xdc7245d7.Parchment, 0.5f, 0.535f, 460f, 118f);
        _0xf17b8b3b.onClick.AddListener(() => this._0x630d69fa());
        RectTransform _0xa38fb664 = _0x211a051a.Box(_0x66926425, _0xe5fc837b._0x52fbefbe(new byte[4] { 244, 201, 209, 213 }, 166), 0.5f, 0.300f, RowWidth, 640f);
        string[] _0x48c1e54d =
        {
            _0xe5fc837b._0x52fbefbe(new byte[12] { 86, 94, 86, 89, 94, 73, 59, 72, 82, 85, 88, 94 }, 27),
            _0xe5fc837b._0x52fbefbe(new byte[15] { 118, 113, 102, 127, 101, 98, 121, 100, 117, 16, 99, 100, 113, 119, 117 }, 48),
            _0xe5fc837b._0x52fbefbe(new byte[11] { 152, 159, 133, 131, 149, 240, 156, 149, 134, 149, 156 }, 208),
            _0xe5fc837b._0x52fbefbe(new byte[14] { 157, 140, 155, 154, 151, 138, 141, 254, 155, 159, 140, 144, 155, 154 }, 222)
        };
        for (int _0x43f46a43 = 0; _0x43f46a43 < RowCount; _0x43f46a43++)
        {
            float _0x3923f3c4 = (640f - 20f - 70f - _0x43f46a43 * 160f) / 640f;
            RectTransform _0xe82c5c39 = _0x211a051a.Box(_0xa38fb664, _0xe5fc837b._0x52fbefbe(new byte[3] { 180, 137, 145 }, 230), 0.5f, _0x3923f3c4, RowWidth, 140f);
            _0x211a051a.Plate(_0xe82c5c39, _0xe5fc837b._0x52fbefbe(new byte[5] { 237, 217, 202, 198, 206 }, 171), _0x8cfa9946._0xcef53720, _0xdc7245d7.Divider, 2.6f);
            RectTransform _0x23aea6e4 = _0x211a051a.Node(_0xe82c5c39, _0xe5fc837b._0x52fbefbe(new byte[5] { 127, 88, 88, 83, 68 }, 54), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-6f, -6f));
            _0x211a051a.Plate(_0x23aea6e4, _0xe5fc837b._0x52fbefbe(new byte[4] { 218, 245, 240, 240 }, 156), _0x8cfa9946._0xcef53720, _0xdc7245d7.PanelBase, 2.8f);
            _0x211a051a.Label(_0xe82c5c39, _0xe5fc837b._0x52fbefbe(new byte[5] { 135, 170, 169, 174, 167 }, 203), _0x8cfa9946._0x50577ddc, _0x48c1e54d[_0x43f46a43], 30f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Left, 320f / RowWidth, 0.5f, 460f, 60f);
            this._0x04dcb8e0[_0x43f46a43] = _0x211a051a.Label(_0xe82c5c39, _0xe5fc837b._0x52fbefbe(new byte[5] { 208, 231, 234, 243, 227 }, 134), _0x8cfa9946._0x50577ddc, "", 36f, _0xdc7245d7.GoldLight, TextAlignmentOptions.Right, 790f / RowWidth, 0.5f, 400f, 60f);
        }

        _0x211a051a.Label(_0x66926425, _0xe5fc837b._0x52fbefbe(new byte[6] { 98, 75, 75, 80, 65, 86 }, 36), _0x8cfa9946._0x50577ddc, _0xe5fc837b._0x52fbefbe(new byte[63] { 40, 41, 70, 39, 37, 37, 41, 51, 40, 50, 74, 70, 40, 41, 70, 53, 47, 33, 40, 75, 47, 40, 72, 108, 50, 46, 47, 53, 70, 54, 52, 41, 32, 47, 42, 35, 70, 42, 47, 48, 35, 53, 70, 41, 40, 70, 50, 46, 47, 53, 70, 34, 35, 48, 47, 37, 35, 70, 41, 40, 42, 63, 72 }, 102), 28f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 0.5f, 0.085f, 1050f, 90f);
        return this;
    }

    private const float RowWidth = 1050f;
    private _0x25979831 _0x97c7754d;
    private Image _0xfe2f863c;
    public void Tick()
    {
    }

    private TextMeshProUGUI _0xa2ba9c64;
    private void OnDestroy()
    {
        if (this._0x05b49d81 != null)
            DOTween.Kill(this._0x05b49d81);
    }
}

internal static class _0xe5fc837b
{
    internal static string _0x52fbefbe(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}