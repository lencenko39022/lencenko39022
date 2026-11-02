using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The home screen of the club: valance, credit bar, tonight's stage, the tile grid and
/// the compliance footer. The Play button itself is the template one and is dressed by
/// the director, so this screen leaves a clear band for it.
/// </summary>
public sealed class _0x3fb2b235 : MonoBehaviour, _0xeb461ae5
{
    private static readonly string[] _0x3e419774 =
    {
        _0xb7a3d088._0xf5fa1df0(new byte[12] { 38, 32, 44, 36, 65, 45, 40, 35, 51, 32, 51, 56 }, 97),
        _0xb7a3d088._0xf5fa1df0(new byte[10] { 10, 15, 7, 2, 23, 110, 9, 7, 8, 26 }, 78),
        _0xb7a3d088._0xf5fa1df0(new byte[8] { 208, 212, 206, 206, 212, 210, 211, 206 }, 157),
        _0xb7a3d088._0xf5fa1df0(new byte[10] { 187, 183, 180, 180, 189, 187, 172, 177, 183, 182 }, 248),
        _0xb7a3d088._0xf5fa1df0(new byte[8] { 164, 166, 187, 179, 166, 177, 167, 167 }, 244),
        _0xb7a3d088._0xf5fa1df0(new byte[7] { 188, 190, 163, 170, 165, 160, 169 }, 236),
        _0xb7a3d088._0xf5fa1df0(new byte[5] { 50, 53, 44, 37, 51 }, 96),
        _0xb7a3d088._0xf5fa1df0(new byte[8] { 33, 55, 38, 38, 59, 60, 53, 33 }, 114),
    };
    private const float GridHeight = 700f;
    public RectTransform Root
    {
        get
        {
            return this._0x53cb179b;
        }
    }

    private void _0x0e778370(RectTransform _0x71135ecc, int _0x154f5df6, float _0xa0d94457, float _0xd3573ea0)
    {
        RectTransform _0x3f1115c2 = _0x211a051a.Box(_0x71135ecc, _0xb7a3d088._0xf5fa1df0(new byte[4] { 23, 42, 47, 38 }, 67), _0xa0d94457, _0xd3573ea0, TileWidth, TileHeight);
        Image _0xf1dbc47c = _0x211a051a.Plate(_0x3f1115c2, _0xb7a3d088._0xf5fa1df0(new byte[5] { 93, 105, 122, 118, 126 }, 27), this._0xa608f988._0xcef53720, _0xdc7245d7.GoldDark, 2.2f);
        _0xf1dbc47c.raycastTarget = true;
        RectTransform _0x8b72f75c = _0x211a051a.Node(_0x3f1115c2, _0xb7a3d088._0xf5fa1df0(new byte[5] { 254, 217, 217, 210, 197 }, 183), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-8f, -8f));
        _0x211a051a.Plate(_0x8b72f75c, _0xb7a3d088._0xf5fa1df0(new byte[4] { 127, 80, 85, 85 }, 57), this._0xa608f988._0xcef53720, _0xdc7245d7.PanelBase, 2.4f);
        _0x211a051a.Picture(_0x3f1115c2, _0xb7a3d088._0xf5fa1df0(new byte[4] { 10, 32, 44, 45 }, 67), this._0xe54e0344(_0x154f5df6), 70f / TileWidth, 0.5f, 88f, 88f, Color.white);
        _0x211a051a.Label(_0x3f1115c2, _0xb7a3d088._0xf5fa1df0(new byte[5] { 43, 22, 11, 19, 26 }, 127), this._0xa608f988._0x50577ddc, _0x3e419774[_0x154f5df6], 36f, _0xdc7245d7.Parchment, TextAlignmentOptions.Left, 325f / TileWidth, 0.66f, 382f, 58f);
        this._0x496f45ec[_0x154f5df6] = _0x211a051a.Label(_0x3f1115c2, _0xb7a3d088._0xf5fa1df0(new byte[6] { 40, 15, 26, 15, 14, 8 }, 123), this._0xa608f988._0x50577ddc, "", 28f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Left, 325f / TileWidth, 0.27f, 382f, 48f);
        Button _0x63dc1f3d = _0x3f1115c2.gameObject.AddComponent<Button>();
        _0x63dc1f3d.targetGraphic = _0xf1dbc47c;
        int _0x5d5f67dd = _0x566e8898[_0x154f5df6];
        _0x63dc1f3d.onClick.AddListener(() => this._0x04cb8325._0x9b79807d(_0x5d5f67dd));
    }

    private const int TileCount = 8;
    private TextMeshProUGUI _0x23444fd6;
    public _0x3fb2b235 _0xdcc791f7(RectTransform _0x074f6f24, _0x51685ac3 _0x315a20e8, _0x529d8e09 _0x8e8086bb)
    {
        this._0xa608f988 = _0x315a20e8;
        this._0x04cb8325 = _0x8e8086bb;
        this._0x53cb179b = _0x211a051a.Stretch(_0x074f6f24, _0xb7a3d088._0xf5fa1df0(new byte[5] { 58, 25, 20, 20, 15 }, 118));
        Image _0xbe23696b = _0x211a051a.Plate(this._0x53cb179b, _0xb7a3d088._0xf5fa1df0(new byte[5] { 6, 54, 39, 60, 56 }, 85), _0x315a20e8._0x9bc213f0, new Color(0.0431f, 0.0431f, 0.0588f, 0.58f), 1f);
        _0xbe23696b.raycastTarget = true;
        this._0x7e2812de();
        this._0x53d27873();
        this._0x4f8e0882();
        this._0xf62bed44();
        this._0x6c6de225();
        this._0x4d571aba();
        this._0x8908920a();
        return this;
    }

    public void _0x8908920a()
    {
        if (this._0xd4e6ebb0 == null)
            return;
        this._0xd4e6ebb0.text = _0x0331a644.Money(_0x0331a644._0x1ac99480);
        this._0x23444fd6.text = _0xb7a3d088._0xf5fa1df0(new byte[4] { 243, 233, 243, 159 }, 191) + _0x0331a644._0xac075e85;
        int _0x62d4e25c = Mathf.Clamp(_0x0331a644._0xb9e14fc1, 0, _0x4b563ca7.StageCount - 1);
        this._0x777d57aa.text = _0x4b563ca7.StageName(_0x62d4e25c);
        this._0xc857e02c(0, _0x4b563ca7.StageName(_0x62d4e25c), _0xdc7245d7.TextSecondary);
        bool _0x9408fb8c = _0x0331a644._0x626dd4e4 != _0x0331a644.Today();
        this._0xc857e02c(1, _0x9408fb8c ? _0xb7a3d088._0xf5fa1df0(new byte[5] { 122, 109, 105, 108, 113 }, 40) : _0xb7a3d088._0xf5fa1df0(new byte[3] { 121, 126, 16 }, 48) + _0x4b563ca7.TimeToMidnight(), _0x9408fb8c ? _0xdc7245d7.StatusWin : _0xdc7245d7.TextSecondary);
        int _0xd941b17e = 0;
        for (int _0x43d1c65e = 0; _0x43d1c65e < _0x0331a644.MissionCount; _0x43d1c65e++)
            if (_0x0331a644.MissionClaimed(_0x43d1c65e))
                _0xd941b17e++;
        this._0xc857e02c(2, _0xd941b17e + _0xb7a3d088._0xf5fa1df0(new byte[3] { 183, 184, 183 }, 151) + _0x0331a644.MissionCount + _0xb7a3d088._0xf5fa1df0(new byte[5] { 229, 129, 138, 139, 128 }, 197), _0xd941b17e >= _0x0331a644.MissionCount ? _0xdc7245d7.StatusWin : _0xdc7245d7.TextSecondary);
        this._0xc857e02c(3, _0x0331a644.TrinketsOwned() + _0xb7a3d088._0xf5fa1df0(new byte[3] { 71, 72, 71 }, 103) + _0x0331a644.TrinketCount + _0xb7a3d088._0xf5fa1df0(new byte[7] { 44, 92, 69, 66, 66, 73, 72 }, 12), _0xdc7245d7.TextSecondary);
        this._0xc857e02c(4, _0xb7a3d088._0xf5fa1df0(new byte[6] { 166, 175, 188, 175, 166, 202 }, 234) + _0x0331a644._0xac075e85, _0xdc7245d7.TextSecondary);
        this._0xc857e02c(5, _0x0331a644._0xe07e3fcb, _0xdc7245d7.TextSecondary);
        this._0xc857e02c(6, _0xb7a3d088._0xf5fa1df0(new byte[20] { 199, 214, 206, 195, 214, 213, 219, 210, 183, 186, 183, 209, 214, 222, 197, 183, 199, 219, 214, 206 }, 151), _0xdc7245d7.TextSecondary);
        this._0xc857e02c(7, _0xb7a3d088._0xf5fa1df0(new byte[25] { 100, 123, 112, 96, 115, 102, 123, 125, 124, 18, 31, 18, 127, 125, 102, 123, 125, 124, 18, 31, 18, 102, 119, 106, 102 }, 50), _0xdc7245d7.TextSecondary);
    }

    private void _0x4d571aba()
    {
        _0x211a051a.Label(this._0x53cb179b, _0xb7a3d088._0xf5fa1df0(new byte[7] { 7, 46, 46, 53, 36, 51, 0 }, 65), this._0xa608f988._0x50577ddc, _0xb7a3d088._0xf5fa1df0(new byte[45] { 100, 109, 126, 117, 120, 117, 6, 26, 22, 28, 20, 25, 117, 18, 20, 24, 16, 117, 120, 117, 27, 26, 117, 7, 16, 20, 25, 117, 24, 26, 27, 16, 12, 117, 120, 117, 27, 26, 117, 5, 7, 28, 15, 16, 6 }, 85), 30f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 0.5f, 0.155f, 1180f, 56f);
        _0x211a051a.Label(this._0x53cb179b, _0xb7a3d088._0xf5fa1df0(new byte[7] { 183, 158, 158, 133, 148, 131, 179 }, 241), this._0xa608f988._0x50577ddc, _0xb7a3d088._0xf5fa1df0(new byte[73] { 39, 54, 33, 32, 45, 48, 55, 68, 37, 54, 33, 68, 50, 45, 54, 48, 49, 37, 40, 74, 68, 48, 44, 33, 61, 68, 39, 37, 42, 42, 43, 48, 68, 38, 33, 68, 38, 43, 49, 35, 44, 48, 72, 110, 55, 43, 40, 32, 72, 68, 51, 45, 48, 44, 32, 54, 37, 51, 42, 68, 43, 54, 68, 33, 60, 39, 44, 37, 42, 35, 33, 32, 74 }, 100), 28f, _0xdc7245d7.TextMuted, TextAlignmentOptions.Center, 0.5f, 0.100f, 1180f, 96f);
    }

    private Sprite _0xe54e0344(int _0x5292f2a5)
    {
        if (_0x5292f2a5 == 1)
            return this._0xa608f988._0xa9537078;
        if (_0x5292f2a5 == 2)
            return this._0xa608f988._0xc24dddd0;
        if (_0x5292f2a5 == 3)
            return this._0xa608f988._0x81e6d18e;
        if (_0x5292f2a5 == 4)
            return this._0xa608f988._0xb6eb4455(_0x80ffeb86.Diamond);
        if (_0x5292f2a5 == 5)
            return this._0xa608f988._0x2d9ff0d6;
        if (_0x5292f2a5 == 6)
            return this._0xa608f988._0xb6eb4455(_0x80ffeb86.Ticket);
        if (_0x5292f2a5 == 7)
            return this._0xa608f988._0xb6eb4455(_0x80ffeb86.Bell);
        return this._0xa608f988._0xb6eb4455(_0x80ffeb86.Crown);
    }

    private _0x529d8e09 _0x04cb8325;
    private const float TileWidth = 540f;
    private _0x51685ac3 _0xa608f988;
    private void OnDestroy()
    {
        if (this._0x53cb179b != null)
            DOTween.Kill(this._0x53cb179b);
    }

    private const float GridWidth = 1140f;
    private void _0x4f8e0882()
    {
        RectTransform _0x6469f28c = _0x211a051a.Sheet(this._0x53cb179b, _0xb7a3d088._0xf5fa1df0(new byte[9] { 75, 108, 121, 127, 125, 91, 121, 106, 124 }, 24), 0.5f, 0.755f, 1140f, 300f, this._0xa608f988._0x9bc213f0, _0xdc7245d7.PanelBase, _0xdc7245d7.Gold, 10f);
        _0x211a051a.Label(_0x6469f28c, _0xb7a3d088._0xf5fa1df0(new byte[6] { 227, 193, 203, 195, 205, 218 }, 168), this._0xa608f988._0x50577ddc, _0xb7a3d088._0xf5fa1df0(new byte[16] { 28, 7, 6, 1, 15, 0, 28, 104, 7, 6, 104, 27, 28, 9, 15, 13 }, 72), 36f, _0xdc7245d7.GoldLight, TextAlignmentOptions.Left, 0.33f, 0.72f, 640f, 60f);
        this._0x777d57aa = _0x211a051a.Label(_0x6469f28c, _0xb7a3d088._0xf5fa1df0(new byte[5] { 0, 39, 50, 52, 54 }, 83), this._0xa608f988._0x50577ddc, "", 56f, _0xdc7245d7.Parchment, TextAlignmentOptions.Left, 0.33f, 0.38f, 640f, 92f);
        _0x211a051a.Picture(_0x6469f28c, _0xb7a3d088._0xf5fa1df0(new byte[6] { 162, 138, 133, 139, 130, 138 }, 231), this._0xa608f988._0x2d9ff0d6, 0.80f, 0.5f, 220f, 220f, Color.white);
    }

    private const float TileHeight = 150f;
    private RectTransform _0x53cb179b;
    public void Enter()
    {
        this._0x53cb179b.gameObject.SetActive(true);
        this._0x8908920a();
        DOTween.Kill(this._0x53cb179b, true);
        this._0x53cb179b.localScale = Vector3.one;
    }

    private void _0x6c6de225()
    {
        RectTransform _0x9a22ed4f = _0x211a051a.Box(this._0x53cb179b, _0xb7a3d088._0xf5fa1df0(new byte[5] { 141, 176, 181, 188, 170 }, 217), 0.5f, 0.350f, GridWidth, GridHeight);
        float _0x5dbc770e = (TileWidth * 0.5f + 11f) / GridWidth;
        for (int _0x4254503d = 0; _0x4254503d < TileCount; _0x4254503d++)
        {
            int _0x4ffa2f03 = _0x4254503d / 2;
            int _0x5dbca1a9 = _0x4254503d % 2;
            float _0xa05f98d8 = 0.5f + (_0x5dbca1a9 == 0 ? -_0x5dbc770e : _0x5dbc770e);
            float _0x62457792 = (GridHeight - 17f - TileHeight * 0.5f - _0x4ffa2f03 * (TileHeight + 22f)) / GridHeight;
            this._0x0e778370(_0x9a22ed4f, _0x4254503d, _0xa05f98d8, _0x62457792);
        }
    }

    private void _0x7e2812de()
    {
        RectTransform _0x719373c7 = _0x211a051a.Node(this._0x53cb179b, _0xb7a3d088._0xf5fa1df0(new byte[7] { 90, 109, 96, 109, 98, 111, 105 }, 12), new Vector2(0f, 0.94f), new Vector2(1f, 1f), Vector2.zero, Vector2.zero);
        Image _0x8e963894 = _0x719373c7.gameObject.AddComponent<Image>();
        _0x8e963894.sprite = this._0xa608f988._0xc5d1e44f;
        _0x8e963894.type = this._0xa608f988._0xc5d1e44f == null ? Image.Type.Simple : Image.Type.Sliced;
        _0x8e963894.color = this._0xa608f988._0xc5d1e44f == null ? _0xdc7245d7.ScarletDeep : Color.white;
        _0x211a051a.Slice(_0x8e963894, 1f);
        _0x8e963894.raycastTarget = false;
        _0x211a051a.Rule(_0x719373c7, _0xb7a3d088._0xf5fa1df0(new byte[6] { 96, 84, 79, 72, 65, 67 }, 38), this._0xa608f988._0x9bc213f0, 0.5f, 0.04f, 1242f, _0xdc7245d7.Gold);
    }

    private TextMeshProUGUI _0x777d57aa;
    /// <summary>Tile n opens this route.</summary>
    private static readonly int[] _0x566e8898 =
    {
        _0x529d8e09.RouteLibrary,
        _0x529d8e09.RouteGift,
        _0x529d8e09.RouteMissions,
        _0x529d8e09.RouteCollection,
        _0x529d8e09.RouteProgress,
        _0x529d8e09.RouteProfile,
        _0x529d8e09.RouteRules,
        _0x529d8e09.RouteSettings,
    };
    private void _0x53d27873()
    {
        RectTransform _0x54cd8f1f = _0x211a051a.Box(this._0x53cb179b, _0xb7a3d088._0xf5fa1df0(new byte[10] { 113, 64, 87, 86, 91, 70, 113, 90, 91, 66 }, 50), 0.30f, 0.893f, 600f, 170f);
        _0x211a051a.Plate(_0x54cd8f1f, _0xb7a3d088._0xf5fa1df0(new byte[5] { 58, 14, 29, 17, 25 }, 124), this._0xa608f988._0xf4df0193, _0xdc7245d7.Gold, 2.2f);
        RectTransform _0x943062e1 = _0x211a051a.Node(_0x54cd8f1f, _0xb7a3d088._0xf5fa1df0(new byte[5] { 198, 225, 225, 234, 253 }, 143), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-10f, -10f));
        _0x211a051a.Plate(_0x943062e1, _0xb7a3d088._0xf5fa1df0(new byte[4] { 29, 50, 55, 55 }, 91), this._0xa608f988._0xf4df0193, _0xdc7245d7.PanelBase, 2.4f);
        this._0xd4e6ebb0 = _0x211a051a.Label(_0x54cd8f1f, _0xb7a3d088._0xf5fa1df0(new byte[5] { 124, 75, 70, 95, 79 }, 42), this._0xa608f988._0x50577ddc, _0xb7a3d088._0xf5fa1df0(new byte[1] { 158 }, 174), 90f, _0xdc7245d7.Gold, TextAlignmentOptions.Center, 0.5f, 0.64f, 540f, 100f);
        _0x211a051a.Label(_0x54cd8f1f, _0xb7a3d088._0xf5fa1df0(new byte[7] { 239, 205, 220, 216, 197, 195, 194 }, 172), this._0xa608f988._0x50577ddc, _0xb7a3d088._0xf5fa1df0(new byte[12] { 237, 249, 238, 238, 139, 232, 249, 238, 239, 226, 255, 248 }, 171), 28f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 0.5f, 0.21f, 540f, 48f);
        RectTransform _0xa5539a18 = _0x211a051a.Box(this._0x53cb179b, _0xb7a3d088._0xf5fa1df0(new byte[9] { 156, 181, 166, 181, 188, 128, 185, 188, 188 }, 208), 0.805f, 0.893f, 300f, 118f);
        _0x211a051a.Plate(_0xa5539a18, _0xb7a3d088._0xf5fa1df0(new byte[5] { 7, 51, 32, 44, 36 }, 65), this._0xa608f988._0xf4df0193, _0xdc7245d7.GoldDark, 2.2f);
        RectTransform _0xd7e7d508 = _0x211a051a.Node(_0xa5539a18, _0xb7a3d088._0xf5fa1df0(new byte[5] { 173, 138, 138, 129, 150 }, 228), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-8f, -8f));
        _0x211a051a.Plate(_0xd7e7d508, _0xb7a3d088._0xf5fa1df0(new byte[4] { 236, 195, 198, 198 }, 170), this._0xa608f988._0xf4df0193, _0xdc7245d7.ScarletDeep, 2.4f);
        this._0x23444fd6 = _0x211a051a.Fill(_0xa5539a18, _0xb7a3d088._0xf5fa1df0(new byte[5] { 230, 209, 220, 197, 213 }, 176), this._0xa608f988._0x50577ddc, _0xb7a3d088._0xf5fa1df0(new byte[5] { 80, 74, 80, 60, 45 }, 28), 44f, _0xdc7245d7.GoldLight, TextAlignmentOptions.Center, 18f);
    }

    public void Tick()
    {
        this._0x8908920a();
    }

    private void _0xf62bed44()
    {
        RectTransform _0xcdabc3ad = _0x211a051a.Box(this._0x53cb179b, _0xb7a3d088._0xf5fa1df0(new byte[6] { 119, 76, 71, 71, 74, 75 }, 37), 0.5f, 0.520f, 1000f, 86f);
        _0x211a051a.Plate(_0xcdabc3ad, _0xb7a3d088._0xf5fa1df0(new byte[5] { 138, 190, 173, 161, 169 }, 204), this._0xa608f988._0x9bc213f0, _0xdc7245d7.GoldDark, 3f);
        RectTransform _0xe4613abc = _0x211a051a.Node(_0xcdabc3ad, _0xb7a3d088._0xf5fa1df0(new byte[5] { 210, 245, 245, 254, 233 }, 155), Vector2.zero, Vector2.one, Vector2.zero, new Vector2(-6f, -6f));
        _0x211a051a.Plate(_0xe4613abc, _0xb7a3d088._0xf5fa1df0(new byte[4] { 160, 143, 138, 138 }, 230), this._0xa608f988._0x9bc213f0, _0xdc7245d7.ScarletDeep, 3f);
        _0x211a051a.Fill(_0xcdabc3ad, _0xb7a3d088._0xf5fa1df0(new byte[4] { 197, 244, 233, 229 }, 145), this._0xa608f988._0x50577ddc, _0xb7a3d088._0xf5fa1df0(new byte[32] { 72, 92, 75, 75, 46, 77, 65, 71, 64, 93, 46, 35, 46, 64, 65, 46, 77, 79, 93, 70, 46, 35, 46, 64, 65, 46, 94, 92, 71, 84, 75, 93 }, 14), 34f, _0xdc7245d7.GoldLight, TextAlignmentOptions.Center, 16f);
    }

    private TextMeshProUGUI _0xd4e6ebb0;
    private void _0xc857e02c(int _0x23873c47, string _0xae49789f, Color _0x5b93ed9c)
    {
        TextMeshProUGUI _0x8e61fb97 = this._0x496f45ec[_0x23873c47];
        if (_0x8e61fb97 == null)
            return;
        _0x8e61fb97.text = _0xae49789f;
        _0x8e61fb97.color = _0x5b93ed9c;
        _0xf9bbd821.ApplyOutline(_0x8e61fb97);
    }

    private readonly TextMeshProUGUI[] _0x496f45ec = new TextMeshProUGUI[TileCount];
}

internal static class _0xb7a3d088
{
    internal static string _0xf5fa1df0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}