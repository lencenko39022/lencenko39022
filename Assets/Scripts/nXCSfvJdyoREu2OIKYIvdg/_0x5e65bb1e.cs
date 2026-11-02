using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Eight curios pinned to the velvet wall, three to a row. A locked slot shows the same
/// art as a dark silhouette with a padlock over it, never an empty hole.
/// </summary>
public sealed class _0x5e65bb1e : MonoBehaviour, _0xeb461ae5
{
    private readonly Image[] _0x4be4c0ec = new Image[_0x0331a644.TrinketCount];
    private readonly TextMeshProUGUI[] _0xcad0c737 = new TextMeshProUGUI[_0x0331a644.TrinketCount];
    private const float SlotHeight = 380f;
    private const float GridWidth = 1050f;
    private const float GridHeight = 1250f;
    private void _0x5e2eb84f()
    {
        this._0x2b9564c6._0xd8c998fc(_0x63cc982e._0x37befb80(new byte[11] { 196, 200, 203, 203, 194, 196, 211, 206, 200, 201, 167 }, 135) + _0x0331a644.TrinketsOwned() + _0x63cc982e._0x37befb80(new byte[3] { 35, 44, 35 }, 3) + _0x0331a644.TrinketCount);
        for (int _0x6011872c = 0; _0x6011872c < _0x0331a644.TrinketCount; _0x6011872c++)
        {
            bool _0xfd1c286f = _0x0331a644.TrinketUnlocked(_0x6011872c);
            this._0x3a298449[_0x6011872c].color = _0xfd1c286f ? _0xdc7245d7.Gold : _0xdc7245d7.Divider;
            this._0x5bfe9b76[_0x6011872c].color = _0xfd1c286f ? Color.white : new Color(0.08f, 0.04f, 0.05f, 0.85f);
            this._0x4be4c0ec[_0x6011872c].enabled = !_0xfd1c286f && this._0x38151ad4._0x30383bc4 != null;
            if (_0xfd1c286f)
            {
                this._0xcad0c737[_0x6011872c].text = _0x4b563ca7.TrinketName(_0x6011872c);
                this._0xcad0c737[_0x6011872c].color = _0xdc7245d7.Parchment;
            }
            else if (_0x6011872c == _0x0331a644.TrinketCount - 1)
            {
                this._0xcad0c737[_0x6011872c].text = _0x63cc982e._0x37befb80(new byte[14] { 78, 89, 55, 48, 62, 49, 45, 115, 42, 45, 43, 60, 56, 50 }, 121);
                this._0xcad0c737[_0x6011872c].color = _0xdc7245d7.TextSecondary;
            }
            else
            {
                this._0xcad0c737[_0x6011872c].text = _0x63cc982e._0x37befb80(new byte[6] { 68, 77, 94, 77, 68, 40 }, 8) + _0x0331a644.TrinketRequirement(_0x6011872c);
                this._0xcad0c737[_0x6011872c].color = _0xdc7245d7.TextSecondary;
            }

            _0xf9bbd821.ApplyOutline(this._0xcad0c737[_0x6011872c]);
        }
    }

    private readonly Image[] _0x3a298449 = new Image[_0x0331a644.TrinketCount];
    private _0x51685ac3 _0x38151ad4;
    public void Tick()
    {
    }

    private void OnDestroy()
    {
        for (int _0xcf25118e = 0; _0xcf25118e < this._0x1f2fe672.Length; _0xcf25118e++)
            if (this._0x1f2fe672[_0xcf25118e] != null)
                DOTween.Kill(this._0x1f2fe672[_0xcf25118e]);
    }

    private readonly RectTransform[] _0x1f2fe672 = new RectTransform[_0x0331a644.TrinketCount];
    private readonly Image[] _0x5bfe9b76 = new Image[_0x0331a644.TrinketCount];
    private void _0x2f7f56ff(RectTransform _0xd4abd1e7, int _0x036e62d6, float _0xc47b017a, float _0xcfaea2d5)
    {
        RectTransform _0xbc460cbb = _0x211a051a.Box(_0xd4abd1e7, _0x63cc982e._0x37befb80(new byte[4] { 221, 226, 225, 250 }, 142), _0xc47b017a, _0xcfaea2d5, SlotWidth, SlotHeight);
        this._0x1f2fe672[_0x036e62d6] = _0xbc460cbb;
        Image _0x7fdf7489 = _0x211a051a.Plate(_0xbc460cbb, _0x63cc982e._0x37befb80(new byte[5] { 196, 240, 227, 239, 231 }, 130), this._0x38151ad4._0xcef53720, _0xdc7245d7.GoldDark, 2.2f);
        _0x7fdf7489.raycastTarget = true;
        this._0x3a298449[_0x036e62d6] = _0x7fdf7489;
        RectTransform _0xbbeb9d97 = _0x211a051a.Node(_0xbc460cbb, _0x63cc982e._0x37befb80(new byte[5] { 181, 146, 146, 153, 142 }, 252), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-10f, -10f));
        _0x211a051a.Plate(_0xbbeb9d97, _0x63cc982e._0x37befb80(new byte[4] { 96, 79, 74, 74 }, 38), this._0x38151ad4._0xcef53720, _0xdc7245d7.PanelBase, 2.4f);
        this._0x5bfe9b76[_0x036e62d6] = _0x211a051a.Picture(_0xbc460cbb, _0x63cc982e._0x37befb80(new byte[3] { 64, 115, 117 }, 1), this._0x38151ad4._0xed029fc3(_0x036e62d6), 0.5f, 0.63f, 220f, 220f, Color.white);
        this._0x4be4c0ec[_0x036e62d6] = _0x211a051a.Picture(_0xbc460cbb, _0x63cc982e._0x37befb80(new byte[4] { 67, 96, 108, 100 }, 15), this._0x38151ad4._0x30383bc4, 0.5f, 0.63f, 110f, 110f, _0xdc7245d7.GoldLight);
        this._0xcad0c737[_0x036e62d6] = _0x211a051a.Label(_0xbc460cbb, _0x63cc982e._0x37befb80(new byte[4] { 171, 132, 136, 128 }, 229), this._0x38151ad4._0x50577ddc, "", 30f, _0xdc7245d7.Parchment, TextAlignmentOptions.Center, 0.5f, 0.18f, 280f, 100f);
        Button _0x79881a77 = _0xbc460cbb.gameObject.AddComponent<Button>();
        _0x79881a77.targetGraphic = _0x7fdf7489;
        int _0xfbb481fa = _0x036e62d6;
        _0x79881a77.onClick.AddListener(() => this._0x25eac1e2(_0xfbb481fa));
    }

    private void _0x25eac1e2(int _0x1ac9fc57)
    {
        RectTransform _0xc690ee37 = this._0x1f2fe672[_0x1ac9fc57];
        if (_0xc690ee37 != null)
            _0xc690ee37.DOPunchScale(new Vector3(0.08f, 0.08f, 0f), 0.25f, 7, 0.7f).SetLink(_0xc690ee37.gameObject);
        if (_0x0331a644.TrinketUnlocked(_0x1ac9fc57))
        {
            this._0x15de2089._0xa58f604b(_0x4b563ca7.TrinketName(_0x1ac9fc57), _0x4b563ca7.TrinketNote(_0x1ac9fc57), _0x63cc982e._0x37befb80(new byte[18] { 134, 159, 152, 152, 147, 146, 246, 130, 153, 246, 130, 158, 147, 246, 129, 151, 154, 154 }, 214), _0x63cc982e._0x37befb80(new byte[6] { 3, 11, 16, 100, 13, 16 }, 68), null, null);
            return;
        }

        string _0x20a53da3 = _0x1ac9fc57 == _0x0331a644.TrinketCount - 1 ? _0x63cc982e._0x37befb80(new byte[36] { 246, 249, 244, 252, 248, 149, 225, 253, 240, 149, 242, 252, 243, 225, 149, 230, 240, 227, 240, 251, 191, 251, 252, 242, 253, 225, 230, 149, 252, 251, 149, 244, 149, 231, 250, 226 }, 181) : _0x63cc982e._0x37befb80(new byte[12] { 220, 203, 207, 205, 198, 174, 194, 203, 216, 203, 194, 174 }, 142) + _0x0331a644.TrinketRequirement(_0x1ac9fc57);
        this._0x15de2089._0xa58f604b(_0x63cc982e._0x37befb80(new byte[6] { 84, 87, 91, 83, 93, 92 }, 24), _0x20a53da3, _0x63cc982e._0x37befb80(new byte[20] { 229, 235, 235, 254, 142, 254, 226, 239, 247, 231, 224, 233, 142, 250, 225, 224, 231, 233, 230, 250 }, 174), _0x63cc982e._0x37befb80(new byte[6] { 112, 120, 99, 23, 126, 99 }, 55), null, null);
    }

    public _0x5e65bb1e _0xe2293573(_0x51685ac3 _0x569109a0, _0x529d8e09 _0x4488a182)
    {
        this._0x38151ad4 = _0x569109a0;
        this._0x15de2089 = _0x4488a182;
        this._0x2b9564c6 = this.gameObject.AddComponent<_0x25979831>()._0x03be6e46(this.transform as RectTransform, _0x569109a0, _0x63cc982e._0x37befb80(new byte[10] { 236, 224, 227, 227, 234, 236, 251, 230, 224, 225 }, 175), true, () => _0x4488a182._0xbda30b26());
        RectTransform _0x8aca55d2 = this._0x2b9564c6._0x81b31132;
        RectTransform _0x9114cda6 = _0x211a051a.Box(_0x8aca55d2, _0x63cc982e._0x37befb80(new byte[4] { 11, 62, 37, 40 }, 76), 0.5f, 0.56f, GridWidth, GridHeight);
        for (int _0x5d2d4d26 = 0; _0x5d2d4d26 < _0x0331a644.TrinketCount; _0x5d2d4d26++)
        {
            int _0xc0a1c3c6 = _0x5d2d4d26 / 3;
            int _0x4aa23789 = _0x5d2d4d26 % 3;
            float _0x211910e0 = (165f + _0x4aa23789 * 360f) / GridWidth;
            float _0x3bc58374 = (GridHeight - 25f - SlotHeight * 0.5f - _0xc0a1c3c6 * (SlotHeight + 30f)) / GridHeight;
            this._0x2f7f56ff(_0x9114cda6, _0x5d2d4d26, _0x211910e0, _0x3bc58374);
        }

        _0x211a051a.Label(_0x8aca55d2, _0x63cc982e._0x37befb80(new byte[6] { 199, 238, 238, 245, 228, 243 }, 129), _0x569109a0._0x50577ddc, _0x63cc982e._0x37befb80(new byte[52] { 19, 5, 2, 25, 31, 3, 112, 17, 2, 21, 112, 20, 21, 19, 31, 2, 17, 4, 25, 31, 30, 112, 31, 30, 28, 9, 126, 90, 4, 24, 21, 9, 112, 24, 17, 6, 21, 112, 30, 31, 112, 19, 17, 3, 24, 112, 6, 17, 28, 5, 21, 126 }, 80), 28f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 0.5f, 0.10f, 1050f, 90f);
        return this;
    }

    public void Enter()
    {
        this._0x5e2eb84f();
        if (this._0x2b9564c6 != null)
            this._0x2b9564c6.Enter();
    }

    private _0x25979831 _0x2b9564c6;
    public RectTransform Root
    {
        get
        {
            return this._0x2b9564c6 == null ? null : this._0x2b9564c6._0x10966145;
        }
    }

    private _0x529d8e09 _0x15de2089;
    private const float SlotWidth = 320f;
}

internal static class _0x63cc982e
{
    internal static string _0x37befb80(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}