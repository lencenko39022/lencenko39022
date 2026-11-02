using DG.Tweening;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The Virtual Reels screen: five auto-stopping reels, a bet stepper, the credit HUD and
/// the three popups. Nothing here can end the session - the house tops the player up for
/// free - so a run outlasts any capture window by a wide margin.
/// </summary>
public sealed class _0x1576dd6f : MonoBehaviour
{
    private TextMeshProUGUI _0xa5e70fcf;
    /// <summary>Only a spin the player owns may raise a modal; the demo never interrupts.</summary>
    private IEnumerator _0x3e1691ec(int _0xc265d318, bool _0x9a30d1d9)
    {
        int _0x283650b1 = this._0xd8b4ea79.Win;
        int _0xad668fe5 = 0;
        for (int _0xdaa6b957 = 0; _0xdaa6b957 < this._0xd8b4ea79.Grid.Length; _0xdaa6b957++)
            if (this._0xd8b4ea79.Grid[_0xdaa6b957] == _0x80ffeb86.Jester)
                _0xad668fe5++;
        for (int _0x4449ed8c = 0; _0x4449ed8c < _0x80ffeb86.LineCount; _0x4449ed8c++)
        {
            if (this._0xd8b4ea79.LineMultiplier[_0x4449ed8c] <= 0)
                continue;
            this._0x5e851456[_0x4449ed8c].color = _0xdc7245d7.Gold;
            int[] _0x91da8006 = _0x80ffeb86.LineRows(_0x4449ed8c);
            for (int _0x0d497494 = 0; _0x0d497494 < this._0xd8b4ea79.LineRun[_0x4449ed8c] && _0x0d497494 < _0x80ffeb86.Reels; _0x0d497494++)
                this._0x4ea9d894[_0x0d497494]._0x57c13242(_0x91da8006[_0x0d497494], _0x0331a644._0x5255fac2);
            yield return new WaitForSeconds(_0x0331a644._0x5255fac2 ? 0.05f : 0.25f);
        }

        _0x0331a644._0xa0cd89da = _0x0331a644._0xa0cd89da + 1;
        _0x0331a644.SetMissionProgress(_0x4b563ca7.MissionSpins, _0x0331a644.MissionProgress(_0x4b563ca7.MissionSpins) + 1);
        if (_0xad668fe5 > 0)
            _0x0331a644.SetMissionProgress(_0x4b563ca7.MissionWilds, _0x0331a644.MissionProgress(_0x4b563ca7.MissionWilds) + _0xad668fe5);
        if (_0x283650b1 > 0)
        {
            _0x0331a644.AddCredits(_0x283650b1);
            this._0x098df5f6++;
            if (this._0x098df5f6 > _0x0331a644._0x23512045)
                _0x0331a644._0x23512045 = this._0x098df5f6;
            if (_0x283650b1 > _0x0331a644._0xb6850feb)
                _0x0331a644._0xb6850feb = _0x283650b1;
            if (_0x283650b1 >= _0xc265d318 * BigWinMultiple)
                _0x0331a644.SetMissionProgress(_0x4b563ca7.MissionBigWin, 1);
            this._0xa5e70fcf.text = _0xe5425e72._0x25ab9684(new byte[4] { 51, 45, 42, 68 }, 100) + _0x0331a644.Money(_0x283650b1);
            this._0xa5e70fcf.color = _0xdc7245d7.StatusWin;
        }
        else
        {
            this._0x098df5f6 = 0;
            this._0xa5e70fcf.text = this._0x4148cf45._0xc041f7a6 > 0 ? _0xe5425e72._0x25ab9684(new byte[11] { 42, 62, 41, 41, 76, 63, 60, 37, 34, 63, 76 }, 108) + this._0x4148cf45._0xc041f7a6 : _0xe5425e72._0x25ab9684(new byte[9] { 142, 134, 134, 141, 233, 133, 156, 138, 130 }, 201);
            this._0xa5e70fcf.color = _0xdc7245d7.TextSecondary;
        }

        _0xf9bbd821.ApplyOutline(this._0xa5e70fcf);
        PlayerPrefs.Save();
        this._0xa60bc526();
        if (_0x9a30d1d9 && _0x283650b1 >= _0xc265d318 * BigWinMultiple && this._pops != null && this._pops._0x4507b1bc)
        {
            if (_0x0331a644._0x2997eb52)
                Handheld.Vibrate();
            string _0x78bd0182 = this._0xd8b4ea79.BestLine >= 0 ? this._0xe5cb5cd6(this._0xd8b4ea79.BestLine) : _0xe5425e72._0x25ab9684(new byte[18] { 243, 239, 226, 135, 239, 232, 242, 244, 226, 135, 230, 247, 247, 235, 230, 242, 227, 244 }, 167);
            this._pops._0x93aebe7c(_0xe5425e72._0x25ab9684(new byte[6] { 183, 167, 180, 163, 186, 212 }, 245), _0xe5425e72._0x25ab9684(new byte[8] { 14, 24, 2, 119, 0, 24, 25, 119 }, 87) + _0x0331a644.Money(_0x283650b1) + _0xe5425e72._0x25ab9684(new byte[8] { 91, 18, 3, 20, 21, 24, 5, 2 }, 81), _0x78bd0182, _0xe5425e72._0x25ab9684(new byte[13] { 163, 160, 162, 170, 193, 181, 174, 193, 173, 174, 163, 163, 184 }, 225), () => this._0x8d7ff44d(), _0xe5425e72._0x25ab9684(new byte[10] { 213, 214, 207, 200, 166, 199, 193, 199, 207, 200 }, 134), () => this._0xbe4ccbe2(), true);
            yield break;
        }

        if (_0x9a30d1d9 && this._0xd8b4ea79.FreeSpinsAwarded > 0 && this._pops != null && this._pops._0x4507b1bc)
        {
            this._pops._0x93aebe7c(_0xe5425e72._0x25ab9684(new byte[16] { 24, 4, 9, 108, 24, 5, 15, 7, 9, 24, 31, 108, 0, 13, 2, 8 }, 76), _0xe5425e72._0x25ab9684(new byte[30] { 125, 113, 127, 112, 108, 24, 126, 106, 125, 125, 24, 107, 104, 113, 118, 107, 50, 121, 108, 24, 124, 119, 109, 122, 116, 125, 24, 104, 121, 97 }, 56), _0xe5425e72._0x25ab9684(new byte[17] { 176, 172, 161, 189, 196, 167, 171, 183, 176, 196, 170, 171, 176, 172, 173, 170, 163 }, 228), _0xe5425e72._0x25ab9684(new byte[13] { 47, 44, 46, 38, 77, 57, 34, 77, 33, 34, 47, 47, 52 }, 109), () => this._0x8d7ff44d(), _0xe5425e72._0x25ab9684(new byte[9] { 76, 80, 93, 69, 60, 72, 84, 89, 81 }, 28), () => this._0xbe4ccbe2(), true);
            yield break;
        }

        if (_0x9a30d1d9 && _0x0331a644._0x1ac99480 < this._0x9869eec2() && this._0x4148cf45._0xc041f7a6 <= 0)
            this._0x357cdfad();
    }

    private const float FreeSpinDelay = 1.9f;
    private TextMeshProUGUI _0xe1769e12;
    private void _0xa60bc526()
    {
        int _0x57abcce7 = Mathf.Clamp(_0x0331a644._0xb9e14fc1, 0, _0x4b563ca7.StageCount - 1);
        this._0xe1769e12.text = _0x0331a644.Money(_0x0331a644._0x1ac99480);
        this._0x7e95c098.text = _0x4b563ca7.StageName(_0x57abcce7) + _0xe5425e72._0x25ab9684(new byte[10] { 163, 174, 163, 182, 163, 207, 202, 205, 198, 208 }, 131);
        this._0x3d5f7f04.text = _0x0331a644.Money(this._0x9869eec2());
        bool _0xf9710cdc = this._0x4148cf45._0xc041f7a6 > 0;
        this._0x8c427937.interactable = !this._0xf34f5b78 && !_0xf9710cdc;
        this._0xf1e52b52.interactable = !this._0xf34f5b78 && !_0xf9710cdc;
        this._0xaca90837.interactable = !this._0xf34f5b78;
        if (this._0x081a7960 != null)
        {
            this._0x081a7960.text = _0xf9710cdc ? _0xe5425e72._0x25ab9684(new byte[9] { 218, 206, 217, 217, 188, 207, 204, 213, 210 }, 156) : _0xe5425e72._0x25ab9684(new byte[4] { 15, 12, 21, 18 }, 92);
            this._0x081a7960.color = this._0xf34f5b78 ? _0xdc7245d7.TextSecondary : _0xdc7245d7.Parchment;
            _0xf9bbd821.ApplyOutline(this._0x081a7960);
        }

        _0xf9bbd821.ApplyOutline(this._0xe1769e12);
        _0xf9bbd821.ApplyOutline(this._0x3d5f7f04);
    }

    private void _0x9732dc19()
    {
        if (this._0x6dfe89bb == null || _0x0331a644._0x5255fac2)
            return;
        DOTween.Kill(this._0x6dfe89bb, true);
        this._0x6dfe89bb.localScale = Vector3.one;
        this._0x6dfe89bb.DOScale(1.02f, 1.6f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(this._0x6dfe89bb.gameObject);
    }

    private bool _0xb249ef2b;
    private bool _0xf34f5b78;
    private _0x8170e3ef _0x4148cf45;
    private readonly Image[] _0x5e851456 = new Image[_0x80ffeb86.LineCount];
    private void _0xa57f6d4a(int _0xe943ebfd)
    {
        if (this._0xf34f5b78 || this._0x4148cf45._0xc041f7a6 > 0)
            return;
        int _0xfad0eb0c = Mathf.Clamp(_0x0331a644._0xb9e14fc1, 0, _0x4b563ca7.StageCount - 1);
        int[] _0x3091fcc7 = _0x0331a644.Bets();
        int _0x2da18e91 = this._0x9869eec2();
        int _0xca8c233e = 0;
        for (int _0x33b08799 = 0; _0x33b08799 < _0x3091fcc7.Length; _0x33b08799++)
            if (_0x3091fcc7[_0x33b08799] == _0x2da18e91)
                _0xca8c233e = _0x33b08799;
        _0xca8c233e = Mathf.Clamp(_0xca8c233e + _0xe943ebfd, 0, _0x3091fcc7.Length - 1);
        int _0xf450fe4a = Mathf.Clamp(_0x3091fcc7[_0xca8c233e], _0x4b563ca7.StageBetMin(_0xfad0eb0c), _0x4b563ca7.StageBetMax(_0xfad0eb0c));
        _0x0331a644._0x54d74316 = _0xf450fe4a;
        PlayerPrefs.Save();
        this._0xa60bc526();
        RectTransform _0x76b9a7fc = this._0x3d5f7f04 == null ? null : this._0x3d5f7f04.rectTransform;
        if (_0x76b9a7fc != null && !_0x0331a644._0x5255fac2)
            _0x76b9a7fc.DOPunchScale(new Vector3(0.08f, 0.08f, 0f), 0.22f, 6, 0.7f).SetLink(_0x76b9a7fc.gameObject);
        this._0x12954b79 = 0f;
    }

    // ------------------------------------------------------------------ building
    private void _0x16f7baa9()
    {
        Image _0x5908a2dd = _0x211a051a.Plate(this._0x2518dadf, _0xe5425e72._0x25ab9684(new byte[5] { 30, 46, 63, 36, 32 }, 77), this._theme._0x9bc213f0, new Color(0.0431f, 0.0431f, 0.0588f, 0.62f), 1f);
        _0x5908a2dd.raycastTarget = true;
        int _0x7a56de0b = Mathf.Clamp(_0x0331a644._0xb9e14fc1, 0, _0x4b563ca7.StageCount - 1);
        Image _0x2cec66ee = _0x211a051a.Plate(this._0x2518dadf, _0xe5425e72._0x25ab9684(new byte[9] { 236, 203, 222, 216, 218, 235, 214, 209, 203 }, 191), this._theme._0x9bc213f0, _0xdc7245d7.WithAlpha(_0x4b563ca7.StageTint(_0x7a56de0b), 0.16f), 1f);
        _0x2cec66ee.raycastTarget = false;
        RectTransform _0xbed288e3 = _0x211a051a.Node(this._0x2518dadf, _0xe5425e72._0x25ab9684(new byte[7] { 34, 21, 24, 21, 26, 23, 17 }, 116), new Vector2(0f, 0.90f), new Vector2(1f, 1f), Vector2.zero, Vector2.zero);
        Image _0xab3d0bd4 = _0xbed288e3.gameObject.AddComponent<Image>();
        _0xab3d0bd4.sprite = this._theme._0xc5d1e44f;
        _0xab3d0bd4.type = this._theme._0xc5d1e44f == null ? Image.Type.Simple : Image.Type.Sliced;
        _0xab3d0bd4.color = this._theme._0xc5d1e44f == null ? _0x4b563ca7.StageDrape(_0x7a56de0b) : Color.white;
        _0x211a051a.Slice(_0xab3d0bd4, 1f);
        _0xab3d0bd4.raycastTarget = false;
    }

    [SerializeField]
    private _0xe0317038 _pops;
    private const float IdleDemoDelay = 6f;
    private void _0xf9b5c467()
    {
        RectTransform _0xf3652cd0 = _0x211a051a.Box(this._0x2518dadf, _0xe5425e72._0x25ab9684(new byte[7] { 30, 32, 39, 11, 40, 39, 45 }, 73), 0.5f, 0.405f, WindowWidth, 110f);
        _0x211a051a.Plate(_0xf3652cd0, _0xe5425e72._0x25ab9684(new byte[5] { 54, 2, 17, 29, 21 }, 112), this._theme._0x9bc213f0, _0xdc7245d7.GoldDark, 2.6f);
        RectTransform _0x8e92634b = _0x211a051a.Node(_0xf3652cd0, _0xe5425e72._0x25ab9684(new byte[5] { 252, 219, 219, 208, 199 }, 181), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-8f, -8f));
        _0x211a051a.Plate(_0x8e92634b, _0xe5425e72._0x25ab9684(new byte[4] { 216, 247, 242, 242 }, 158), this._theme._0x9bc213f0, _0xdc7245d7.PanelBase, 2.8f);
        for (int _0x7697b799 = 0; _0x7697b799 < _0x80ffeb86.LineCount; _0x7697b799++)
        {
            RectTransform _0x2c8553d5 = _0x211a051a.Box(_0xf3652cd0, _0xe5425e72._0x25ab9684(new byte[3] { 74, 115, 106 }, 26), (40f + _0x7697b799 * 48f) / WindowWidth, 0.5f, 34f, 34f);
            Image _0x7259406b = _0x2c8553d5.gameObject.AddComponent<Image>();
            _0x7259406b.sprite = this._theme._0xf4df0193;
            _0x7259406b.type = this._theme._0xf4df0193 == null ? Image.Type.Simple : Image.Type.Sliced;
            _0x7259406b.color = _0xdc7245d7.BgTertiary;
            _0x7259406b.raycastTarget = false;
            _0x7259406b.pixelsPerUnitMultiplier = 1.4f;
            _0x211a051a.Slice(_0x7259406b, 1.4f);
            this._0x5e851456[_0x7697b799] = _0x7259406b;
        }

        this._0xa5e70fcf = _0x211a051a.Label(_0xf3652cd0, _0xe5425e72._0x25ab9684(new byte[3] { 95, 97, 102 }, 8), this._theme._0x50577ddc, _0xe5425e72._0x25ab9684(new byte[9] { 49, 57, 57, 50, 86, 58, 35, 53, 61 }, 118), 48f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 0.60f, 0.5f, 620f, 80f);
        RectTransform _0xd2361296 = _0x211a051a.Box(this._0x2518dadf, _0xe5425e72._0x25ab9684(new byte[4] { 11, 42, 45, 55 }, 67), 0.5f, 0.345f, 820f, 72f);
        _0x211a051a.Plate(_0xd2361296, _0xe5425e72._0x25ab9684(new byte[4] { 73, 102, 99, 99 }, 15), this._theme._0x9bc213f0, _0xdc7245d7.ScarletDeep, 2.8f);
        _0x211a051a.Fill(_0xd2361296, _0xe5425e72._0x25ab9684(new byte[4] { 86, 103, 122, 118 }, 2), this._theme._0x50577ddc, _0xe5425e72._0x25ab9684(new byte[36] { 95, 74, 91, 43, 88, 91, 66, 69, 43, 38, 43, 62, 43, 71, 66, 69, 78, 88, 43, 38, 43, 77, 89, 78, 78, 43, 72, 68, 66, 69, 88, 43, 68, 69, 71, 82 }, 11), 30f, _0xdc7245d7.Parchment, TextAlignmentOptions.Center, 14f);
    }

    private const float CellGap = 12f;
    private void _0x6576a594()
    {
        if (!this._0xb249ef2b)
            return;
        this._0xb249ef2b = false;
        this._0xdbce12c9(true);
    }

    private void Start()
    {
        if (this._theme == null)
            return;
        this._0x2518dadf = this.transform as RectTransform;
        if (this._0x2518dadf == null)
            return;
        this._0x2518dadf.anchorMin = Vector2.zero;
        this._0x2518dadf.anchorMax = Vector2.one;
        this._0x2518dadf.offsetMin = Vector2.zero;
        this._0x2518dadf.offsetMax = Vector2.zero;
        this._0x2518dadf.SetAsLastSibling();
        int _0x3aafe7af = (int)(System.DateTime.UtcNow.Ticks & 0x7FFFFFFF);
        this._0x4148cf45 = new _0x8170e3ef()._0x45c2e03a(_0x3aafe7af);
        this._0xd8b4ea79 = new _0x8170e3ef._0xf4931647()._0xef910fb8();
        this._0x16f7baa9();
        this._0x53b118fd();
        this._0x8ac43d6c();
        this._0xf9b5c467();
        this._0xd9804861();
        for (int _0xca892e44 = 0; _0xca892e44 < _0x80ffeb86.Reels; _0xca892e44++)
            this._0x4ea9d894[_0xca892e44]._0x512a82ae(this._0x4148cf45._0x0665f1a4(_0xca892e44));
        this._0xec0558a8(_0x3aafe7af);
        this._0xa60bc526();
    }

    private TextMeshProUGUI _0x7e95c098;
    private _0x8170e3ef._0xf4931647 _0xd8b4ea79;
    private Image _0x57045770;
    // ------------------------------------------------------------------ idle demo
    private void Update()
    {
        if (this._0xf34f5b78 || this._0x4148cf45 == null)
            return;
        this._0x12954b79 += Time.deltaTime;
        if (this._0x12954b79 < IdleDemoDelay)
            return;
        this._0x12954b79 = 0f;
        this._0x876efe94.gameObject.SetActive(true);
        this._0xdbce12c9(false);
    }

    private void _0x357cdfad()
    {
        if (this._pops == null || !this._pops._0x4507b1bc)
        {
            _0x0331a644.AddCredits(_0x0331a644.TopUpAmount);
            this._0xa60bc526();
            return;
        }

        this._pops._0x0f98293d(_0xe5425e72._0x25ab9684(new byte[17] { 4, 24, 21, 112, 24, 31, 5, 3, 21, 112, 25, 30, 3, 25, 3, 4, 3 }, 80), _0xe5425e72._0x25ab9684(new byte[22] { 246, 224, 250, 143, 238, 253, 234, 143, 224, 250, 251, 143, 224, 233, 143, 236, 253, 234, 235, 230, 251, 252 }, 175), _0xe5425e72._0x25ab9684(new byte[35] { 251, 234, 253, 252, 241, 236, 235, 152, 249, 234, 253, 152, 238, 241, 234, 236, 237, 249, 244, 152, 249, 246, 252, 152, 249, 244, 239, 249, 225, 235, 152, 254, 234, 253, 253 }, 184), _0xe5425e72._0x25ab9684(new byte[13] { 79, 76, 78, 70, 45, 89, 66, 45, 65, 66, 79, 79, 84 }, 13), () => this._0x8d7ff44d(), _0xe5425e72._0x25ab9684(new byte[23] { 163, 182, 188, 178, 215, 194, 199, 199, 215, 177, 165, 184, 186, 215, 163, 191, 178, 215, 191, 184, 162, 164, 178 }, 247), () => this._0xa73e7324());
    }

    private TextMeshProUGUI _0x081a7960;
    /// <summary>A still board on entry so the screen never opens empty.</summary>
    private void _0xec0558a8(int _0x5ed6d075)
    {
        System.Random _0x6d8e7473 = new System.Random(_0x5ed6d075 ^ 48271);
        int[] _0x2117fec2 = new int[_0x80ffeb86.Reels * _0x80ffeb86.Rows];
        for (int _0x0cebca2a = 0; _0x0cebca2a < _0x80ffeb86.Reels; _0x0cebca2a++)
        {
            int[] _0xe62504c2 = this._0x4148cf45._0x0665f1a4(_0x0cebca2a);
            _0x80ffeb86.ReadWindow(_0xe62504c2, _0x6d8e7473.Next(_0x80ffeb86.StripLength), _0x2117fec2, _0x0cebca2a * _0x80ffeb86.Rows);
            this._0x4ea9d894[_0x0cebca2a].Show(_0x2117fec2, _0x0cebca2a);
        }
    }

    private const float WindowHeight = 660f;
    private const float WindowWidth = 1050f;
    private RectTransform _0x6dfe89bb;
    private void _0xbe4ccbe2()
    {
        this._pops._0x3386dec3();
        this._0x12954b79 = 0f;
    }

    private bool _0x12cb3f88;
    private RectTransform _0x2518dadf;
    private float _0x12954b79;
    private string _0xe5cb5cd6(int _0x0370bc78)
    {
        int _0x4df6f599 = this._0xd8b4ea79.LineSymbol[_0x0370bc78];
        int _0x4abfc352 = this._0xd8b4ea79.LineRun[_0x0370bc78];
        if (_0x4df6f599 < 0 || _0x4abfc352 < 3)
            return _0xe5425e72._0x25ab9684(new byte[18] { 219, 199, 202, 175, 199, 192, 218, 220, 202, 175, 206, 223, 223, 195, 206, 218, 203, 220 }, 143);
        return _0x4abfc352 + _0xe5425e72._0x25ab9684(new byte[1] { 3 }, 35) + _0x80ffeb86.NameOf(_0x4df6f599) + _0xe5425e72._0x25ab9684(new byte[9] { 220, 179, 178, 220, 176, 181, 178, 185, 220 }, 252) + (_0x0370bc78 + 1);
    }

    // ------------------------------------------------------------------ spinning
    /// <summary>
    /// A tap on SPIN always counts, even when the idle demo is mid-spin: it is queued and
    /// played the moment the board is free. Without that the demo could swallow the
    /// player's first spin - and with it the showcase outcome.
    /// </summary>
    private void _0xb6ecee4a()
    {
        this._0x12954b79 = 0f;
        this._0xb249ef2b = true;
        if (!this._0xf34f5b78)
            this._0x6576a594();
    }

    private void _0xa73e7324()
    {
        _0x0331a644.AddCredits(_0x0331a644.TopUpAmount);
        PlayerPrefs.Save();
        this._pops._0x3386dec3();
        this._0xa60bc526();
        this._0x12954b79 = 0f;
    }

    private TextMeshProUGUI _0x3d5f7f04;
    private IEnumerator _0x71485c42(int _0x4d6f982c, bool _0x1c3b1692, bool _0xfbc68142)
    {
        this._0xf34f5b78 = true;
        this._0x12cb3f88 = !_0xfbc68142 && !_0x1c3b1692;
        this._0x876efe94.gameObject.SetActive(this._0x12cb3f88);
        for (int _0x7c8a9faa = 0; _0x7c8a9faa < _0x80ffeb86.LineCount; _0x7c8a9faa++)
            this._0x5e851456[_0x7c8a9faa].color = _0xdc7245d7.BgTertiary;
        for (int _0xf510a0bc = 0; _0xf510a0bc < _0x80ffeb86.Reels; _0xf510a0bc++)
        {
            this._0x4ea9d894[_0xf510a0bc]._0x8394e0a9();
            this._0x4ea9d894[_0xf510a0bc]._0x03cf8ceb();
        }

        if (!_0x1c3b1692)
        {
            _0x0331a644._0x1ac99480 = _0x0331a644._0x1ac99480 - _0x4d6f982c;
            _0x0331a644.AddWager(_0x4d6f982c);
        }

        this._0xa5e70fcf.text = _0x1c3b1692 ? _0xe5425e72._0x25ab9684(new byte[9] { 157, 137, 158, 158, 251, 136, 139, 146, 149 }, 219) : _0xe5425e72._0x25ab9684(new byte[8] { 54, 53, 44, 43, 43, 44, 43, 34 }, 101);
        this._0xa5e70fcf.color = _0xdc7245d7.GoldLight;
        _0xf9bbd821.ApplyOutline(this._0xa5e70fcf);
        this._0xa60bc526();
        float _0xc1ccd84a = _0x0331a644._0x5255fac2 ? 0.05f : 0.15f;
        yield return new WaitForSeconds(_0x0331a644._0x5255fac2 ? 0.2f : 0.45f);
        this._0x4148cf45._0x8d4ba13f(_0x4d6f982c, this._0xd8b4ea79, _0xfbc68142);
        for (int _0x1c33974c = 0; _0x1c33974c < _0x80ffeb86.Reels; _0x1c33974c++)
        {
            this._0x4ea9d894[_0x1c33974c]._0x57db5759(this._0xd8b4ea79.Grid, _0x1c33974c, _0x0331a644._0x5255fac2);
            yield return new WaitForSeconds(_0xc1ccd84a);
        }

        yield return new WaitForSeconds(0.3f);
        yield return this.StartCoroutine(this._0x3e1691ec(_0x4d6f982c, _0xfbc68142 || _0x1c3b1692));
        this._0xf34f5b78 = false;
        this._0x12cb3f88 = false;
        this._0x876efe94.gameObject.SetActive(false);
        this._0xa60bc526();
        if (this._0xb249ef2b)
        {
            this._0x6576a594();
            yield break;
        }

        if (this._0x4148cf45._0xc041f7a6 > 0)
        {
            yield return new WaitForSeconds(FreeSpinDelay);
            this._0xdbce12c9(false);
        }
    }

    private void _0x8ac43d6c()
    {
        RectTransform _0x733ed108 = _0x211a051a.Box(this._0x2518dadf, _0xe5425e72._0x25ab9684(new byte[6] { 233, 215, 208, 218, 209, 201 }, 190), 0.5f, 0.560f, WindowWidth, WindowHeight);
        _0x211a051a.Plate(_0x733ed108, _0xe5425e72._0x25ab9684(new byte[8] { 191, 156, 158, 150, 153, 143, 146, 141 }, 253), this._theme._0x9bc213f0, _0xdc7245d7.BgTertiary, 2.2f);
        this._0x57045770 = _0x211a051a.Plate(_0x733ed108, _0xe5425e72._0x25ab9684(new byte[5] { 55, 3, 16, 28, 20 }, 113), this._theme._0x7cfac638, Color.white, 1f);
        if (this._theme._0x7cfac638 == null)
            this._0x57045770.color = _0xdc7245d7.WithAlpha(_0xdc7245d7.Gold, 0.35f);
        float _0xee5fbc4e = _0x80ffeb86.Reels * CellSize + (_0x80ffeb86.Reels - 1) * CellGap;
        float _0x38bc0ad9 = _0x80ffeb86.Rows * CellSize + (_0x80ffeb86.Rows - 1) * CellGap;
        RectTransform _0x038e46d1 = _0x211a051a.Box(_0x733ed108, _0xe5425e72._0x25ab9684(new byte[5] { 69, 99, 106, 106, 117 }, 6), 0.5f, 0.5f, _0xee5fbc4e, _0x38bc0ad9);
        for (int _0xf3fa21bf = 0; _0xf3fa21bf < _0x80ffeb86.Reels; _0xf3fa21bf++)
        {
            float _0xe291a1b6 = (CellSize * 0.5f + _0xf3fa21bf * (CellSize + CellGap)) / _0xee5fbc4e;
            this._0x4ea9d894[_0xf3fa21bf] = this.gameObject.AddComponent<_0x1ed714fa>()._0x71aeb091(_0x038e46d1, this._theme, _0xe291a1b6, CellSize, CellGap);
        }
    }

    private Button _0xaca90837;
    private Button _0x8c427937;
    private int _0x098df5f6;
    [SerializeField]
    private _0x51685ac3 _theme;
    private void _0x53b118fd()
    {
        Button _0xfdf967e9 = _0x211a051a.Action(this._0x2518dadf, _0xe5425e72._0x25ab9684(new byte[4] { 163, 132, 134, 142 }, 235), this._theme._0x50577ddc, this._theme._0xf4df0193, string.Empty, 36f, _0xdc7245d7.ScarletDeep, _0xdc7245d7.Gold, _0xdc7245d7.Parchment, 0.095f, 0.845f, 140f, 140f);
        _0x211a051a.Picture(_0xfdf967e9.transform as RectTransform, _0xe5425e72._0x25ab9684(new byte[4] { 92, 118, 122, 123 }, 21), this._theme._0x374268d8, 0.5f, 0.5f, 76f, 76f, _0xdc7245d7.GoldLight);
        _0xfdf967e9.onClick.AddListener(() => this._0x8d7ff44d());
        Button _0x5e77d608 = _0x211a051a.Action(this._0x2518dadf, _0xe5425e72._0x25ab9684(new byte[5] { 55, 6, 18, 20, 2 }, 103), this._theme._0x50577ddc, this._theme._0xf4df0193, string.Empty, 36f, _0xdc7245d7.ScarletDeep, _0xdc7245d7.Gold, _0xdc7245d7.Parchment, 0.905f, 0.845f, 140f, 140f);
        _0x211a051a.Picture(_0x5e77d608.transform as RectTransform, _0xe5425e72._0x25ab9684(new byte[4] { 122, 80, 92, 93 }, 51), this._theme._0x7f1ca861, 0.5f, 0.5f, 76f, 76f, _0xdc7245d7.GoldLight);
        _0x5e77d608.onClick.AddListener(() => this._0x5c05a837());
        RectTransform _0x6c6e4c50 = _0x211a051a.Box(this._0x2518dadf, _0xe5425e72._0x25ab9684(new byte[10] { 47, 30, 9, 8, 5, 24, 47, 4, 5, 28 }, 108), 0.5f, 0.845f, 620f, 150f);
        _0x211a051a.Plate(_0x6c6e4c50, _0xe5425e72._0x25ab9684(new byte[5] { 132, 176, 163, 175, 167 }, 194), this._theme._0xf4df0193, _0xdc7245d7.Gold, 2.2f);
        RectTransform _0x731c456e = _0x211a051a.Node(_0x6c6e4c50, _0xe5425e72._0x25ab9684(new byte[5] { 229, 194, 194, 201, 222 }, 172), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-10f, -10f));
        _0x211a051a.Plate(_0x731c456e, _0xe5425e72._0x25ab9684(new byte[4] { 73, 102, 99, 99 }, 15), this._theme._0xf4df0193, _0xdc7245d7.PanelBase, 2.4f);
        _0x211a051a.Label(_0x6c6e4c50, _0xe5425e72._0x25ab9684(new byte[7] { 52, 22, 7, 3, 30, 24, 25 }, 119), this._theme._0x50577ddc, _0xe5425e72._0x25ab9684(new byte[7] { 32, 49, 38, 39, 42, 55, 48 }, 99), 28f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 0.5f, 0.76f, 560f, 44f);
        this._0xe1769e12 = _0x211a051a.Label(_0x6c6e4c50, _0xe5425e72._0x25ab9684(new byte[5] { 164, 147, 158, 135, 151 }, 242), this._theme._0x50577ddc, _0xe5425e72._0x25ab9684(new byte[1] { 134 }, 182), 64f, _0xdc7245d7.Gold, TextAlignmentOptions.Center, 0.5f, 0.36f, 560f, 84f);
        this._0x7e95c098 = _0x211a051a.Label(this._0x2518dadf, _0xe5425e72._0x25ab9684(new byte[5] { 120, 95, 74, 76, 78 }, 43), this._theme._0x50577ddc, "", 32f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 0.5f, 0.772f, 900f, 54f);
    }

    private const float CellSize = 168f;
    private void _0x5c05a837()
    {
        if (this._pops == null || !this._pops._0x4507b1bc)
            return;
        this._0x12954b79 = 0f;
        this._pops._0x58abd2ca(_0xe5425e72._0x25ab9684(new byte[12] { 199, 192, 218, 203, 220, 195, 199, 221, 221, 199, 193, 192 }, 142), _0xe5425e72._0x25ab9684(new byte[8] { 174, 191, 168, 169, 164, 185, 190, 205 }, 237) + _0x0331a644.Money(_0x0331a644._0x1ac99480), _0xe5425e72._0x25ab9684(new byte[4] { 162, 165, 180, 192 }, 224) + this._0x9869eec2() + _0xe5425e72._0x25ab9684(new byte[10] { 47, 34, 47, 58, 47, 67, 70, 65, 74, 92 }, 15), _0xe5425e72._0x25ab9684(new byte[13] { 145, 146, 144, 152, 243, 135, 156, 243, 159, 156, 145, 145, 138 }, 211), () => this._0x8d7ff44d(), _0xe5425e72._0x25ab9684(new byte[6] { 215, 192, 214, 208, 200, 192 }, 133), () => this._0xbe4ccbe2());
    }

    private void _0xdbce12c9(bool _0x07d523e5)
    {
        if (this._0xf34f5b78)
            return;
        int _0xe9dc466b = this._0x9869eec2();
        bool _0xa544f79b = this._0x4148cf45._0xc041f7a6 > 0;
        if (!_0xa544f79b && _0x0331a644._0x1ac99480 < _0xe9dc466b)
        {
            if (_0x07d523e5)
                this._0x357cdfad();
            else
                _0x0331a644.AddCredits(_0x0331a644.TopUpAmount);
            this._0xa60bc526();
            return;
        }

        this.StartCoroutine(this._0x71485c42(_0xe9dc466b, _0xa544f79b, _0x07d523e5));
    }

    private readonly _0x1ed714fa[] _0x4ea9d894 = new _0x1ed714fa[_0x80ffeb86.Reels];
    private RectTransform _0x876efe94;
    private void OnDestroy()
    {
        if (this._0x6dfe89bb != null)
            DOTween.Kill(this._0x6dfe89bb);
        if (this._0x3d5f7f04 != null)
            DOTween.Kill(this._0x3d5f7f04.rectTransform);
    }

    private Button _0xf1e52b52;
    private void _0x8d7ff44d()
    {
        _0x685a4663.Instance._0x96703be7(_0x0a549333._0xb5c50aa6.SCENE_0);
    }

    private const int BigWinMultiple = 10;
    private void _0xd9804861()
    {
        _0x211a051a.Label(this._0x2518dadf, _0xe5425e72._0x25ab9684(new byte[10] { 3, 36, 53, 2, 32, 49, 53, 40, 46, 47 }, 65), this._theme._0x50577ddc, _0xe5425e72._0x25ab9684(new byte[3] { 165, 162, 179 }, 231), 28f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 0.5f, 0.300f, 400f, 46f);
        this._0x8c427937 = _0x211a051a.Action(this._0x2518dadf, _0xe5425e72._0x25ab9684(new byte[5] { 120, 92, 91, 64, 70 }, 53), this._theme._0x50577ddc, this._theme._0xf4df0193, _0xe5425e72._0x25ab9684(new byte[1] { 158 }, 179), 56f, _0xdc7245d7.ScarletDeep, _0xdc7245d7.Gold, _0xdc7245d7.Parchment, 0.215f, 0.243f, 140f, 140f);
        this._0x8c427937.onClick.AddListener(() => this._0xa57f6d4a(-1));
        this._0xf1e52b52 = _0x211a051a.Action(this._0x2518dadf, _0xe5425e72._0x25ab9684(new byte[4] { 64, 124, 101, 99 }, 16), this._theme._0x50577ddc, this._theme._0xf4df0193, _0xe5425e72._0x25ab9684(new byte[1] { 161 }, 138), 56f, _0xdc7245d7.ScarletDeep, _0xdc7245d7.Gold, _0xdc7245d7.Parchment, 0.785f, 0.243f, 140f, 140f);
        this._0xf1e52b52.onClick.AddListener(() => this._0xa57f6d4a(1));
        RectTransform _0x47c0e35d = _0x211a051a.Box(this._0x2518dadf, _0xe5425e72._0x25ab9684(new byte[8] { 79, 104, 121, 91, 108, 97, 120, 104 }, 13), 0.5f, 0.243f, 320f, 120f);
        _0x211a051a.Plate(_0x47c0e35d, _0xe5425e72._0x25ab9684(new byte[5] { 127, 75, 88, 84, 92 }, 57), this._theme._0xf4df0193, _0xdc7245d7.GoldDark, 2.2f);
        RectTransform _0x8e5d8510 = _0x211a051a.Node(_0x47c0e35d, _0xe5425e72._0x25ab9684(new byte[5] { 6, 33, 33, 42, 61 }, 79), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-8f, -8f));
        _0x211a051a.Plate(_0x8e5d8510, _0xe5425e72._0x25ab9684(new byte[4] { 165, 138, 143, 143 }, 227), this._theme._0xf4df0193, _0xdc7245d7.PanelBase, 2.4f);
        this._0x3d5f7f04 = _0x211a051a.Fill(_0x47c0e35d, _0xe5425e72._0x25ab9684(new byte[5] { 70, 113, 124, 101, 117 }, 16), this._theme._0x50577ddc, "", 58f, _0xdc7245d7.Gold, TextAlignmentOptions.Center, 18f);
        this._0x876efe94 = _0x211a051a.Box(this._0x2518dadf, _0xe5425e72._0x25ab9684(new byte[8] { 206, 239, 231, 229, 201, 226, 227, 250 }, 138), 0.5f, 0.193f, 340f, 62f);
        _0x211a051a.Plate(this._0x876efe94, _0xe5425e72._0x25ab9684(new byte[4] { 55, 24, 29, 29 }, 113), this._theme._0x9bc213f0, _0xdc7245d7.GoldDark, 3f);
        _0x211a051a.Fill(this._0x876efe94, _0xe5425e72._0x25ab9684(new byte[4] { 16, 33, 60, 48 }, 68), this._theme._0x50577ddc, _0xe5425e72._0x25ab9684(new byte[9] { 217, 205, 204, 215, 184, 220, 221, 213, 215 }, 152), 28f, _0xdc7245d7.Parchment, TextAlignmentOptions.Center, 12f);
        this._0x876efe94.gameObject.SetActive(false);
        this._0xaca90837 = _0x211a051a.Action(this._0x2518dadf, _0xe5425e72._0x25ab9684(new byte[4] { 126, 93, 68, 67 }, 45), this._theme._0x50577ddc, this._theme._0xcef53720, _0xe5425e72._0x25ab9684(new byte[4] { 162, 161, 184, 191 }, 241), 60f, _0xdc7245d7.Scarlet, _0xdc7245d7.Gold, _0xdc7245d7.Parchment, 0.5f, 0.115f, 820f, 180f);
        this._0x081a7960 = this._0xaca90837.GetComponentInChildren<TextMeshProUGUI>(true);
        this._0x6dfe89bb = this._0xaca90837.transform as RectTransform;
        this._0xaca90837.onClick.AddListener(() => this._0xb6ecee4a());
        this._0x9732dc19();
    }

    // ------------------------------------------------------------------ hud
    private int _0x9869eec2()
    {
        int _0xd7ed0e32 = Mathf.Clamp(_0x0331a644._0xb9e14fc1, 0, _0x4b563ca7.StageCount - 1);
        return Mathf.Clamp(_0x0331a644._0x54d74316, _0x4b563ca7.StageBetMin(_0xd7ed0e32), _0x4b563ca7.StageBetMax(_0xd7ed0e32));
    }
}

internal static class _0xe5425e72
{
    internal static string _0x25ab9684(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}