using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Four missions that reset at local midnight. Each row keeps its indicator gutter and
/// its text column in separate horizontal bands, so nothing ever runs under the icon.
/// </summary>
public sealed class _0x12812932 : MonoBehaviour, _0xeb461ae5
{
    public void Enter()
    {
        this._0xc5729591();
        if (this._0x6d445b5f != null)
            this._0x6d445b5f.Enter();
    }

    private readonly TextMeshProUGUI[] _0x29b0646c = new TextMeshProUGUI[_0x0331a644.MissionCount];
    private const float RowHeight = 220f;
    public _0x12812932 _0x9109c60d(_0x51685ac3 _0x90bc098d, _0x529d8e09 _0x3580fe19)
    {
        this._0x253d87b0 = _0x90bc098d;
        this._0xf0e3a5f0 = _0x3580fe19;
        this._0x6d445b5f = this.gameObject.AddComponent<_0x25979831>()._0x03be6e46(this.transform as RectTransform, _0x90bc098d, _0xf5bbf542._0x9c33d395(new byte[14] { 76, 73, 65, 68, 81, 40, 69, 65, 91, 91, 65, 71, 70, 91 }, 8), true, () => _0x3580fe19._0xbda30b26());
        RectTransform _0xd61d9165 = this._0x6d445b5f._0x81b31132;
        this._0xc26ae5b6 = _0x211a051a.Label(_0xd61d9165, _0xf5bbf542._0x9c33d395(new byte[5] { 56, 15, 25, 15, 30 }, 106), _0x90bc098d._0x50577ddc, "", 32f, _0xdc7245d7.GoldLight, TextAlignmentOptions.Center, 0.5f, 0.915f, 1050f, 58f);
        this._0x4ebdf566 = _0x211a051a.Box(_0xd61d9165, _0xf5bbf542._0x9c33d395(new byte[4] { 108, 81, 73, 77 }, 62), 0.5f, 0.58f, RowWidth, 1000f);
        for (int _0x11358aac = 0; _0x11358aac < _0x0331a644.MissionCount; _0x11358aac++)
        {
            float _0x62199612 = (1000f - 110f - _0x11358aac * 256f) / 1000f;
            this._0xa04fdcd1(this._0x4ebdf566, _0x11358aac, _0x62199612);
        }

        RectTransform _0x3487bec5 = _0x211a051a.Sheet(_0xd61d9165, _0xf5bbf542._0x9c33d395(new byte[5] { 25, 49, 44, 40, 37 }, 92), 0.5f, 0.58f, 1000f, 420f, _0x90bc098d._0x9bc213f0, _0xdc7245d7.PanelBase, _0xdc7245d7.Gold, 10f);
        _0x211a051a.Picture(_0x3487bec5, _0xf5bbf542._0x9c33d395(new byte[4] { 114, 94, 77, 84 }, 63), _0x90bc098d._0xc24dddd0, 0.5f, 0.72f, 120f, 120f, _0xdc7245d7.StatusWin);
        _0x211a051a.Label(_0x3487bec5, _0xf5bbf542._0x9c33d395(new byte[4] { 168, 132, 155, 146 }, 235), _0x90bc098d._0x50577ddc, _0xf5bbf542._0x9c33d395(new byte[41] { 32, 45, 45, 65, 37, 46, 47, 36, 65, 53, 46, 47, 40, 38, 41, 53, 107, 47, 36, 54, 65, 44, 40, 50, 50, 40, 46, 47, 50, 65, 32, 53, 65, 44, 40, 37, 47, 40, 38, 41, 53 }, 97), 38f, _0xdc7245d7.TextPrimary, TextAlignmentOptions.Center, 0.5f, 0.33f, 900f, 180f);
        this._0x017f53a6 = _0x3487bec5.parent as RectTransform;
        _0x211a051a.Label(_0xd61d9165, _0xf5bbf542._0x9c33d395(new byte[6] { 71, 110, 110, 117, 100, 115 }, 1), _0x90bc098d._0x50577ddc, _0xf5bbf542._0x9c33d395(new byte[35] { 61, 57, 35, 35, 57, 63, 62, 80, 34, 53, 39, 49, 34, 52, 35, 80, 49, 34, 53, 80, 38, 57, 34, 36, 37, 49, 60, 80, 51, 34, 53, 52, 57, 36, 35 }, 112), 28f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 0.5f, 0.07f, 1050f, 50f);
        return this;
    }

    private readonly Image[] _0x8780a545 = new Image[_0x0331a644.MissionCount];
    private readonly TextMeshProUGUI[] _0xf6013265 = new TextMeshProUGUI[_0x0331a644.MissionCount];
    private _0x51685ac3 _0x253d87b0;
    private _0x25979831 _0x6d445b5f;
    private RectTransform _0x4ebdf566;
    private readonly Button[] _0x5f7ac4c4 = new Button[_0x0331a644.MissionCount];
    private Sprite _0x1bad1984(int _0x612117e9)
    {
        if (_0x612117e9 == _0x4b563ca7.MissionWilds)
            return this._0x253d87b0._0x2d9ff0d6;
        if (_0x612117e9 == _0x4b563ca7.MissionGift)
            return this._0x253d87b0._0xa9537078;
        if (_0x612117e9 == _0x4b563ca7.MissionBigWin)
            return this._0x253d87b0._0xb6eb4455(_0x80ffeb86.Crown);
        return this._0x253d87b0._0xb6eb4455(_0x80ffeb86.Bell);
    }

    private RectTransform _0x017f53a6;
    private const float RowWidth = 1050f;
    private readonly Image[] _0xf1119fe8 = new Image[_0x0331a644.MissionCount];
    private TextMeshProUGUI _0xc26ae5b6;
    private _0x529d8e09 _0xf0e3a5f0;
    private void _0xa04fdcd1(RectTransform _0x3058fef3, int _0x55475292, float _0xf94f394d)
    {
        RectTransform _0xf851f584 = _0x211a051a.Box(_0x3058fef3, _0xf5bbf542._0x9c33d395(new byte[3] { 21, 40, 48 }, 71), 0.5f, _0xf94f394d, RowWidth, RowHeight);
        this._0x80ae13cb[_0x55475292] = _0xf851f584;
        this._0x9ea29096[_0x55475292] = _0x211a051a.Plate(_0xf851f584, _0xf5bbf542._0x9c33d395(new byte[5] { 244, 192, 211, 223, 215 }, 178), this._0x253d87b0._0xcef53720, _0xdc7245d7.GoldDark, 2.2f);
        RectTransform _0xeaf3a2c0 = _0x211a051a.Node(_0xf851f584, _0xf5bbf542._0x9c33d395(new byte[5] { 179, 148, 148, 159, 136 }, 250), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-10f, -10f));
        _0x211a051a.Plate(_0xeaf3a2c0, _0xf5bbf542._0x9c33d395(new byte[4] { 197, 234, 239, 239 }, 131), this._0x253d87b0._0xcef53720, _0xdc7245d7.PanelBase, 2.4f);
        this._0x8780a545[_0x55475292] = _0x211a051a.Picture(_0xf851f584, _0xf5bbf542._0x9c33d395(new byte[4] { 55, 27, 8, 17 }, 122), this._0x1bad1984(_0x55475292), 92f / RowWidth, 0.5f, 100f, 100f, Color.white);
        this._0xf6013265[_0x55475292] = _0x211a051a.Label(_0xf851f584, _0xf5bbf542._0x9c33d395(new byte[5] { 226, 223, 194, 218, 211 }, 182), this._0x253d87b0._0x50577ddc, _0x4b563ca7.MissionTitle(_0x55475292), 38f, _0xdc7245d7.Parchment, TextAlignmentOptions.Left, TextX, 0.70f, TextWidth, 58f);
        this._0xcdf952d6[_0x55475292] = _0x211a051a.Box(_0xf851f584, _0xf5bbf542._0x9c33d395(new byte[7] { 64, 99, 112, 74, 109, 113, 118 }, 2), (168f + BarWidth * 0.5f) / RowWidth, 0.30f, BarWidth, 18f);
        this._0xf1119fe8[_0x55475292] = _0x211a051a.Bar(this._0xcdf952d6[_0x55475292], _0xf5bbf542._0x9c33d395(new byte[3] { 10, 41, 58 }, 72), this._0x253d87b0._0x9bc213f0, 0.5f, 0.5f, BarWidth, 18f, _0xdc7245d7.BgTertiary, _0xdc7245d7.Gold);
        this._0x29b0646c[_0x55475292] = _0x211a051a.Label(_0xf851f584, _0xf5bbf542._0x9c33d395(new byte[5] { 190, 146, 136, 147, 137 }, 253), this._0x253d87b0._0x50577ddc, "", 32f, _0xdc7245d7.GoldLight, TextAlignmentOptions.Left, 788f / RowWidth, 0.30f, 180f, 50f);
        this._0x5f7ac4c4[_0x55475292] = _0x211a051a.Action(_0xf851f584, _0xf5bbf542._0x9c33d395(new byte[5] { 132, 171, 166, 174, 170 }, 199), this._0x253d87b0._0x50577ddc, this._0x253d87b0._0xcef53720, _0xf5bbf542._0x9c33d395(new byte[5] { 52, 59, 54, 62, 58 }, 119), 34f, _0xdc7245d7.ScarletDeep, _0xdc7245d7.StatusWin, _0xdc7245d7.Parchment, 0.80f, 0.30f, 280f, 96f);
        int _0xddcf3da1 = _0x55475292;
        this._0x5f7ac4c4[_0x55475292].onClick.AddListener(() => this._0x6935cf16(_0xddcf3da1));
    }

    private const float TextWidth = 740f;
    private void _0x6935cf16(int _0x6daf7d4b)
    {
        if (_0x0331a644.MissionClaimed(_0x6daf7d4b))
            return;
        if (_0x0331a644.MissionProgress(_0x6daf7d4b) < _0x4b563ca7.MissionTarget(_0x6daf7d4b))
            return;
        _0x0331a644.SetMissionClaimed(_0x6daf7d4b, true);
        _0x0331a644.AddCredits(_0x4b563ca7.MissionReward(_0x6daf7d4b));
        PlayerPrefs.Save();
        RectTransform _0x7eae43ed = this._0x80ae13cb[_0x6daf7d4b];
        if (_0x7eae43ed != null)
            _0x7eae43ed.DOPunchScale(new Vector3(0.04f, 0.04f, 0f), 0.25f, 6, 0.6f).SetLink(_0x7eae43ed.gameObject);
        this._0xc5729591();
        this._0xf0e3a5f0._0x612335fc();
    }

    private readonly Image[] _0x9ea29096 = new Image[_0x0331a644.MissionCount];
    private void _0xc5729591()
    {
        this._0xc26ae5b6.text = _0xf5bbf542._0x9c33d395(new byte[10] { 15, 24, 14, 24, 9, 14, 125, 20, 19, 125 }, 93) + _0x4b563ca7.TimeToMidnight();
        int _0xac334ffb = 0;
        for (int _0x4e2c8362 = 0; _0x4e2c8362 < _0x0331a644.MissionCount; _0x4e2c8362++)
            if (_0x0331a644.MissionClaimed(_0x4e2c8362))
                _0xac334ffb++;
        bool _0x613e79fe = _0xac334ffb >= _0x0331a644.MissionCount;
        this._0x4ebdf566.gameObject.SetActive(!_0x613e79fe);
        if (this._0x017f53a6 != null)
            this._0x017f53a6.gameObject.SetActive(_0x613e79fe);
        if (_0x613e79fe)
            return;
        for (int _0x6d20286a = 0; _0x6d20286a < _0x0331a644.MissionCount; _0x6d20286a++)
        {
            int _0xf3d55b02 = _0x4b563ca7.MissionTarget(_0x6d20286a);
            int _0x8831ba03 = Mathf.Clamp(_0x0331a644.MissionProgress(_0x6d20286a), 0, _0xf3d55b02);
            bool _0x9f61c53a = _0x0331a644.MissionClaimed(_0x6d20286a);
            bool _0x706f6935 = !_0x9f61c53a && _0x8831ba03 >= _0xf3d55b02;
            this._0x9ea29096[_0x6d20286a].color = _0x706f6935 ? _0xdc7245d7.StatusWin : _0x9f61c53a ? _0xdc7245d7.Divider : _0xdc7245d7.GoldDark;
            this._0xf6013265[_0x6d20286a].color = _0x9f61c53a ? _0xdc7245d7.TextSecondary : _0xdc7245d7.Parchment;
            _0xf9bbd821.ApplyOutline(this._0xf6013265[_0x6d20286a]);
            this._0x8780a545[_0x6d20286a].sprite = _0x9f61c53a ? this._0x253d87b0._0xc24dddd0 : this._0x1bad1984(_0x6d20286a);
            this._0x8780a545[_0x6d20286a].color = _0x9f61c53a ? _0xdc7245d7.StatusWin : Color.white;
            this._0x8780a545[_0x6d20286a].enabled = this._0x8780a545[_0x6d20286a].sprite != null;
            this._0x5f7ac4c4[_0x6d20286a].gameObject.SetActive(_0x706f6935);
            this._0xcdf952d6[_0x6d20286a].gameObject.SetActive(!_0x706f6935);
            this._0x29b0646c[_0x6d20286a].gameObject.SetActive(!_0x706f6935);
            if (!_0x706f6935)
            {
                _0x211a051a.SetBar(this._0xf1119fe8[_0x6d20286a], _0xf3d55b02 <= 0 ? 0f : _0x8831ba03 / (float)_0xf3d55b02, BarWidth);
                this._0x29b0646c[_0x6d20286a].text = _0x9f61c53a ? _0xf5bbf542._0x9c33d395(new byte[1] { 89 }, 114) + _0x4b563ca7.MissionReward(_0x6d20286a) + _0xf5bbf542._0x9c33d395(new byte[3] { 43, 72, 89 }, 11) : _0x8831ba03 + _0xf5bbf542._0x9c33d395(new byte[3] { 83, 92, 83 }, 115) + _0xf3d55b02;
                this._0x29b0646c[_0x6d20286a].color = _0x9f61c53a ? _0xdc7245d7.StatusWin : _0xdc7245d7.GoldLight;
                _0xf9bbd821.ApplyOutline(this._0x29b0646c[_0x6d20286a]);
            }
        }
    }

    private void OnDestroy()
    {
        for (int _0x017fdb75 = 0; _0x017fdb75 < this._0x80ae13cb.Length; _0x017fdb75++)
            if (this._0x80ae13cb[_0x017fdb75] != null)
                DOTween.Kill(this._0x80ae13cb[_0x017fdb75]);
    }

    public void Tick()
    {
        this._0xc5729591();
    }

    private readonly RectTransform[] _0x80ae13cb = new RectTransform[_0x0331a644.MissionCount];
    private const float TextX = 538f / RowWidth;
    private readonly RectTransform[] _0xcdf952d6 = new RectTransform[_0x0331a644.MissionCount];
    public RectTransform Root
    {
        get
        {
            return this._0x6d445b5f == null ? null : this._0x6d445b5f._0x10966145;
        }
    }

    private const float BarWidth = 480f;
}

internal static class _0xf5bbf542
{
    internal static string _0x9c33d395(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}