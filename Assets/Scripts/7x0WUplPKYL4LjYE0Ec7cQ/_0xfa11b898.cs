using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The furniture around the window: the way out, the way to pause, the meter, the job in
// hand, the banner that announces a line, the stake row and the one control that turns
// the columns.
//
// Back and pause are OUR objects, not the template's two placeholder buttons: those are
// switched off by the pipeline before the build, so hanging this game's navigation on
// them would leave the player with nothing. The template's own wiring for them stays
// where it is and is simply never used (rule H, second option).
public sealed class _0xfa11b898 : MonoBehaviour
{
    public RectTransform _0x50f91b80 => this._0x3e419774;

    private void _0x314848d3()
    {
        if (this._0xc51c3543 != null)
        {
            this._0xc51c3543._0x9947eee4();
        }
    }

    private _0x9799df08 _0xc51c3543;
    // --- display --------------------------------------------------------------
    public void _0x23ff7f24()
    {
        _0x1bad1984.SetText(this._0xb8c11e65, _0x1bad1984.Credits(this._0xaea9010c._0xb8844111));
    }

    private TMP_FontAsset _0xbef6217f;
    private RectTransform _0xefd51ae4;
    public void _0x731c456e()
    {
        if (this._0x566e8898 != null)
        {
            this._0x566e8898.gameObject.SetActive(false);
        }
    }

    private TextMeshProUGUI _0xb8c11e65;
    private TextMeshProUGUI _0x79501ef9;
    public void _0x5908a2dd()
    {
        _0x1bad1984.SetText(this._0x69e87eb8, _0xb05b988d._0x5d2329d7(new byte[6] { 91, 92, 73, 67, 77, 40 }, 8) + this._0xaea9010c._0x45319abc.ToString());
        if (this._0x69e87eb8 != null)
        {
            this._0x69e87eb8.transform.DOPunchScale(new Vector3(0.06f, 0.06f, 0f), 0.3f, 1, 0.5f).SetLink(this._0x69e87eb8.gameObject);
        }
    }

    private const float BoardRow = 0.520f;
    private void _0x547fe7de(RectTransform _0x3973525f, bool _0x15f8fa79)
    {
        float _0xb8a880ed = _0x15f8fa79 ? 0.78f : 0.22f;
        float _0xcd164910 = _0x15f8fa79 ? 0.22f : 0.78f;
        RectTransform _0xa81b569d = _0x891ecf84.FracBox(_0x3973525f, _0xb05b988d._0x5d2329d7(new byte[9] { 130, 165, 176, 186, 180, 149, 190, 166, 191 }, 209), _0xb8a880ed, StakeRow, 120f, 120f);
        Button _0x2e265155 = _0x891ecf84.IconButton(_0xa81b569d, this._0xbef6217f, this._0x3333e3d0, this._0x1e356c0a, null, _0xb05b988d._0x5d2329d7(new byte[1] { 3 }, 46), _0xc5c3f38d.Gold, _0xc5c3f38d.Gold);
        _0x2e265155.onClick.AddListener(() => this._0x8ae46854(-1));
        RectTransform _0x67ed60de = _0x891ecf84.FracBox(_0x3973525f, _0xb05b988d._0x5d2329d7(new byte[7] { 251, 220, 201, 195, 205, 253, 216 }, 168), _0xcd164910, StakeRow, 120f, 120f);
        Button _0x5200a842 = _0x891ecf84.IconButton(_0x67ed60de, this._0xbef6217f, this._0x3333e3d0, this._0x1e356c0a, null, _0xb05b988d._0x5d2329d7(new byte[1] { 13 }, 38), _0xc5c3f38d.Gold, _0xc5c3f38d.Gold);
        _0x5200a842.onClick.AddListener(() => this._0x8ae46854(1));
        RectTransform _0xd87026df = _0x891ecf84.FracBox(_0x3973525f, _0xb05b988d._0x5d2329d7(new byte[10] { 32, 7, 18, 24, 22, 35, 31, 18, 7, 22 }, 115), 0.5f, StakeRow, 420f, 120f);
        _0x891ecf84.Plate(_0xd87026df, this._0x1e356c0a, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.75f), 1.7f);
        RectTransform _0x86f57035 = _0x891ecf84.Stretch(_0xd87026df, _0xb05b988d._0x5d2329d7(new byte[14] { 218, 253, 232, 226, 236, 217, 229, 232, 253, 236, 203, 230, 237, 240 }, 137));
        _0x86f57035.offsetMin = new Vector2(6f, 6f);
        _0x86f57035.offsetMax = new Vector2(-6f, -6f);
        _0x891ecf84.Plate(_0x86f57035, this._0x1e356c0a, _0xc5c3f38d.VelvetLit, 1.9f);
        RectTransform _0x36a65c44 = _0x891ecf84.Stretch(_0xd87026df, _0xb05b988d._0x5d2329d7(new byte[14] { 56, 31, 10, 0, 14, 59, 7, 10, 31, 14, 63, 14, 19, 31 }, 107));
        _0x36a65c44.offsetMin = new Vector2(22f, 10f);
        _0x36a65c44.offsetMax = new Vector2(-22f, -10f);
        this._0x69e87eb8 = _0x891ecf84.Label(_0x36a65c44, this._0xbef6217f, _0xb05b988d._0x5d2329d7(new byte[8] { 70, 65, 84, 94, 80, 53, 39, 37 }, 21), 44f, _0xc5c3f38d.Gold, TextAlignmentOptions.Center);
    }

    public void _0x7a56de0b(_0x542b1bfd _0x2cec66ee)
    {
        for (int _0xbed288e3 = 0; _0xbed288e3 < _0xbbd798a9.MissionSlots; _0xbed288e3++)
        {
            _0xcffa2836 _0xab3d0bd4 = _0x2cec66ee._0xb6850feb[_0xbed288e3];
            if (_0xab3d0bd4 == null || _0x2cec66ee._0xafab931d(_0xbed288e3))
            {
                continue;
            }

            _0x1bad1984.SetText(this._0x8c4fb977, _0xab3d0bd4._0xd7110322 + _0xb05b988d._0x5d2329d7(new byte[3] { 229, 229, 229 }, 197) + _0xab3d0bd4._0xb22436e9(_0x2cec66ee._0x5ec2cf7b(_0xbed288e3)));
            return;
        }

        _0x1bad1984.SetText(this._0x8c4fb977, _0xb05b988d._0x5d2329d7(new byte[20] { 197, 193, 219, 219, 193, 199, 198, 168, 203, 201, 218, 204, 168, 203, 196, 205, 201, 218, 205, 204 }, 136));
    }

    public _0xfc35b876 _0x2997eb52 => this._0x53cb179b;

    private Button _0x04cb8325;
    private RectTransform _0x3e419774;
    private _0xfc35b876 _0x53cb179b;
    public void _0x5e77d608(string _0x6c6e4c50)
    {
        if (this._0x566e8898 == null)
        {
            return;
        }

        _0x1bad1984.SetText(this._0x79501ef9, _0x6c6e4c50);
        this._0x566e8898.gameObject.SetActive(true);
        this._0x566e8898.localScale = new Vector3(0.9f, 0.9f, 1f);
        this._0x566e8898.DOScale(1f, 0.35f).SetEase(Ease.OutBack).SetLink(this._0x566e8898.gameObject);
    }

    public float _0x5255fac2 => BoardRow;

    private const float HudRow = 0.925f;
    public void _0x53b118fd(bool _0xfdf967e9)
    {
        if (this._0x04cb8325 != null)
        {
            this._0x04cb8325.interactable = _0xfdf967e9;
        }

        if (this._0xa608f988 != null)
        {
            this._0xa608f988.color = _0xfdf967e9 ? Color.white : new Color(1f, 1f, 1f, 0.45f);
        }

        if (this._0x9e37983b != null)
        {
            this._0x9e37983b.color = _0xfdf967e9 ? _0xc5c3f38d.Cream : _0xc5c3f38d.CreamDim;
        }
    }

    private void _0x9a0ff30e()
    {
        if (this._0xc51c3543 != null)
        {
            this._0xc51c3543._0xa053f3ec();
        }
    }

    private void _0x8ae46854(int _0xd1313731)
    {
        if (this._0xc51c3543 != null)
        {
            this._0xc51c3543._0xeaab87db(_0xd1313731);
        }
    }

    private const float BannerRow = 0.775f;
    private _0xe54e0344 _0xaea9010c;
    private Sprite _0xdaae7b0f;
    private TextMeshProUGUI _0x8c4fb977;
    public void _0xc79cc7dd(RectTransform _0x2c4356f4, _0x9799df08 _0xcaebee38, _0xe54e0344 _0x01f7f840, _0x542b1bfd _0x03cf8ceb, TMP_FontAsset _0x72f55e62, Sprite _0x57db5759, Sprite _0xdb641084, Sprite _0x2eec395a, Sprite _0x6ce477ec, Sprite _0x57c13242, Sprite[] _0x7ca70231)
    {
        this._0xc51c3543 = _0xcaebee38;
        this._0xaea9010c = _0x01f7f840;
        this._0xbef6217f = _0x72f55e62;
        this._0x1e356c0a = _0x57db5759;
        this._0xdaae7b0f = _0xdb641084;
        this._0x3333e3d0 = _0x2eec395a;
        this._0x3e419774 = _0x2c4356f4;
        bool _0x35e1a485 = _0x01f7f840._0x73072a1c;
        float _0xcdd33bb1 = _0x35e1a485 ? 0.91f : 0.09f;
        float _0x8394e0a9 = _0x35e1a485 ? 0.09f : 0.91f;
        RectTransform _0x24d0974e = _0x891ecf84.FracBox(_0x2c4356f4, _0xb05b988d._0x5d2329d7(new byte[8] { 2, 36, 40, 32, 7, 36, 38, 46 }, 69), _0xcdd33bb1, HudRow, 132f, 132f);
        Button _0x26ac35ca = _0x891ecf84.IconButton(_0x24d0974e, _0x72f55e62, _0x2eec395a, _0x57db5759, _0x6ce477ec, _0xb05b988d._0x5d2329d7(new byte[1] { 203 }, 247), _0xc5c3f38d.Gold, _0xc5c3f38d.Gold);
        _0x26ac35ca.onClick.AddListener(() => this._0x9a0ff30e());
        RectTransform _0x80ffeb86 = _0x891ecf84.FracBox(_0x2c4356f4, _0xb05b988d._0x5d2329d7(new byte[9] { 172, 138, 134, 142, 187, 138, 158, 152, 142 }, 235), _0x8394e0a9, HudRow, 132f, 132f);
        Button _0xb39629de = _0x891ecf84.IconButton(_0x80ffeb86, _0x72f55e62, _0x2eec395a, _0x57db5759, _0x57c13242, _0xb05b988d._0x5d2329d7(new byte[2] { 62, 62 }, 66), _0xc5c3f38d.Gold, _0xc5c3f38d.Gold);
        _0xb39629de.onClick.AddListener(() => this._0x314848d3());
        RectTransform _0x4d8ff16d = _0x891ecf84.FracBox(_0x2c4356f4, _0xb05b988d._0x5d2329d7(new byte[14] { 250, 220, 208, 216, 254, 207, 216, 217, 212, 201, 237, 212, 209, 209 }, 189), 0.5f, HudRow, 420f, 96f);
        this._0xefd51ae4 = _0x4d8ff16d;
        _0x891ecf84.Plate(_0x4d8ff16d, _0x57db5759, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.92f), 1.4f);
        RectTransform _0x3aa7a97c = _0x891ecf84.Stretch(_0x4d8ff16d, _0xb05b988d._0x5d2329d7(new byte[14] { 27, 61, 49, 57, 31, 46, 57, 56, 53, 40, 30, 51, 56, 37 }, 92));
        _0x3aa7a97c.offsetMin = new Vector2(5f, 5f);
        _0x3aa7a97c.offsetMax = new Vector2(-5f, -5f);
        _0x891ecf84.Plate(_0x3aa7a97c, _0x57db5759, _0xc5c3f38d.Velvet, 1.6f);
        RectTransform _0x1956b550 = _0x891ecf84.Stretch(_0x4d8ff16d, _0xb05b988d._0x5d2329d7(new byte[14] { 227, 197, 201, 193, 231, 214, 193, 192, 205, 208, 240, 193, 220, 208 }, 164));
        _0x1956b550.offsetMin = new Vector2(24f, 10f);
        _0x1956b550.offsetMax = new Vector2(-24f, -10f);
        this._0xb8c11e65 = _0x891ecf84.Label(_0x1956b550, _0x72f55e62, _0xb05b988d._0x5d2329d7(new byte[7] { 64, 64, 64, 64, 64, 64, 64 }, 112), 46f, _0xc5c3f38d.Gold, TextAlignmentOptions.Center);
        RectTransform _0x62ff7752 = _0x891ecf84.FracBox(_0x2c4356f4, _0xb05b988d._0x5d2329d7(new byte[15] { 126, 88, 84, 92, 116, 80, 74, 74, 80, 86, 87, 122, 81, 80, 73 }, 57), 0.5f, ChipRow, 780f, 76f);
        _0x891ecf84.Plate(_0x62ff7752, _0x57db5759, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.45f), 1.5f);
        RectTransform _0x272f7640 = _0x891ecf84.Stretch(_0x62ff7752, _0xb05b988d._0x5d2329d7(new byte[15] { 101, 67, 79, 71, 111, 75, 81, 81, 75, 77, 76, 96, 77, 70, 91 }, 34));
        _0x272f7640.offsetMin = new Vector2(4f, 4f);
        _0x272f7640.offsetMax = new Vector2(-4f, -4f);
        _0x891ecf84.Plate(_0x272f7640, _0x57db5759, _0xc5c3f38d.With(_0xc5c3f38d.VelvetLit, 0.95f), 1.7f);
        RectTransform _0x4a5eba5b = _0x891ecf84.Stretch(_0x62ff7752, _0xb05b988d._0x5d2329d7(new byte[15] { 29, 59, 55, 63, 23, 51, 41, 41, 51, 53, 52, 14, 63, 34, 46 }, 90));
        _0x4a5eba5b.offsetMin = new Vector2(20f, 8f);
        _0x4a5eba5b.offsetMax = new Vector2(-20f, -8f);
        this._0x8c4fb977 = _0x891ecf84.Label(_0x4a5eba5b, _0x72f55e62, "", 29f, _0xc5c3f38d.Cream, TextAlignmentOptions.Center);
        RectTransform _0x67f3e1b8 = _0x891ecf84.FracBox(_0x2c4356f4, _0xb05b988d._0x5d2329d7(new byte[10] { 236, 202, 198, 206, 233, 202, 197, 197, 206, 217 }, 171), 0.5f, BannerRow, 900f, 124f);
        this._0x566e8898 = _0x67f3e1b8;
        _0x891ecf84.Plate(_0x67f3e1b8, _0x57db5759, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.9f), 1.6f);
        RectTransform _0x2137c115 = _0x891ecf84.Stretch(_0x67f3e1b8, _0xb05b988d._0x5d2329d7(new byte[14] { 88, 126, 114, 122, 93, 126, 113, 113, 122, 109, 93, 112, 123, 102 }, 31));
        _0x2137c115.offsetMin = new Vector2(6f, 6f);
        _0x2137c115.offsetMax = new Vector2(-6f, -6f);
        _0x891ecf84.Plate(_0x2137c115, _0x57db5759, _0xc5c3f38d.With(_0xc5c3f38d.RubyDeep, 0.96f), 1.8f);
        RectTransform _0xf1fe01f4 = _0x891ecf84.Stretch(_0x67f3e1b8, _0xb05b988d._0x5d2329d7(new byte[14] { 214, 240, 252, 244, 211, 240, 255, 255, 244, 227, 197, 244, 233, 229 }, 145));
        _0xf1fe01f4.offsetMin = new Vector2(26f, 12f);
        _0xf1fe01f4.offsetMax = new Vector2(-26f, -12f);
        this._0x79501ef9 = _0x891ecf84.Label(_0xf1fe01f4, _0x72f55e62, "", 54f, _0xc5c3f38d.GoldLit, TextAlignmentOptions.Center);
        _0x67f3e1b8.gameObject.SetActive(false);
        this._0x547fe7de(_0x2c4356f4, _0x35e1a485);
        this._0x4dfef3e4(_0x2c4356f4);
        RectTransform _0xdfcba2f5 = _0x891ecf84.FracBox(_0x2c4356f4, _0xb05b988d._0x5d2329d7(new byte[8] { 75, 109, 97, 105, 68, 101, 98, 120 }, 12), 0.5f, HintRow, 1020f, 56f);
        _0x891ecf84.Label(_0xdfcba2f5, _0x72f55e62, _0xb05b988d._0x5d2329d7(new byte[26] { 3, 22, 7, 119, 4, 7, 30, 25, 119, 3, 24, 119, 7, 27, 22, 14, 119, 24, 25, 18, 119, 5, 24, 2, 25, 19 }, 87), 31f, _0xc5c3f38d.Cream, TextAlignmentOptions.Center);
        RectTransform _0x6e2a2bfa = _0x891ecf84.Stretch(_0x2c4356f4, _0xb05b988d._0x5d2329d7(new byte[12] { 177, 151, 155, 147, 181, 153, 152, 144, 147, 130, 130, 159 }, 246));
        this._0x53cb179b = _0x6e2a2bfa.gameObject.AddComponent<_0xfc35b876>();
        this._0x53cb179b._0x3e47e0b4(_0x57db5759, _0x7ca70231);
        this._0x23ff7f24();
        this._0x7a56de0b(_0x03cf8ceb);
        this._0x5908a2dd();
    }

    private const float ChipRow = 0.868f;
    public void _0x9210c455(int _0x1576dd6f, int _0x3aafe7af)
    {
        if (this._0xb8c11e65 == null)
        {
            this._0x23ff7f24();
            return;
        }

        int _0xca892e44 = _0x1576dd6f;
        DOTween.To(() => _0xca892e44, _0x16f7baa9 =>
        {
            _0xca892e44 = _0x16f7baa9;
            _0x1bad1984.SetText(this._0xb8c11e65, _0x1bad1984.Credits(_0x16f7baa9));
        }, _0x3aafe7af, _0xbbd798a9.NumberRollSeconds).SetEase(Ease.OutQuad).SetLink(this._0xb8c11e65.gameObject);
        if (this._0xefd51ae4 != null)
        {
            this._0xefd51ae4.DOPunchScale(new Vector3(0.08f, 0.08f, 0f), 0.4f, 1, 0.5f).SetLink(this._0xefd51ae4.gameObject);
        }
    }

    private Sprite _0x3333e3d0;
    private RectTransform _0x566e8898;
    private Sprite _0x1e356c0a;
    private TextMeshProUGUI _0x9e37983b;
    // --- controls -------------------------------------------------------------
    private void _0x3ae7643b()
    {
        if (this._0xc51c3543 != null)
        {
            this._0xc51c3543._0x7e3bd6e3();
        }
    }

    private TextMeshProUGUI _0x69e87eb8;
    private void _0x4dfef3e4(RectTransform _0x2a273dc9)
    {
        RectTransform _0x38f9a2fd = _0x891ecf84.FracBox(_0x2a273dc9, _0xb05b988d._0x5d2329d7(new byte[10] { 5, 38, 63, 56, 20, 35, 34, 34, 57, 56 }, 86), 0.5f, SpinRow, 700f, 176f);
        Image _0x956d886b = this._0xdaae7b0f != null ? _0x891ecf84.PlateArt(_0x38f9a2fd, this._0xdaae7b0f, Color.white) : _0x891ecf84.Plate(_0x38f9a2fd, this._0x1e356c0a, _0xc5c3f38d.Gold, 1.8f);
        _0x956d886b.raycastTarget = true;
        this._0xa608f988 = _0x956d886b;
        if (this._0xdaae7b0f == null)
        {
            RectTransform _0xec5d0b9f = _0x891ecf84.Stretch(_0x38f9a2fd, _0xb05b988d._0x5d2329d7(new byte[8] { 31, 60, 37, 34, 14, 35, 40, 53 }, 76));
            _0xec5d0b9f.offsetMin = new Vector2(8f, 8f);
            _0xec5d0b9f.offsetMax = new Vector2(-8f, -8f);
            _0x891ecf84.Plate(_0xec5d0b9f, this._0x1e356c0a, _0xc5c3f38d.Ruby, 2.1f);
        }

        RectTransform _0x35c675bd = _0x891ecf84.Stretch(_0x38f9a2fd, _0xb05b988d._0x5d2329d7(new byte[11] { 197, 230, 255, 248, 213, 247, 230, 226, 255, 249, 248 }, 150));
        _0x35c675bd.offsetMin = new Vector2(36f, 16f);
        _0x35c675bd.offsetMax = new Vector2(-36f, -16f);
        this._0x9e37983b = _0x891ecf84.Label(_0x35c675bd, this._0xbef6217f, _0xb05b988d._0x5d2329d7(new byte[4] { 208, 211, 202, 205 }, 131), 66f, _0xc5c3f38d.Cream, TextAlignmentOptions.Center);
        this._0x9e37983b.characterSpacing = 10f;
        this._0x04cb8325 = _0x891ecf84.Touchable(_0x38f9a2fd, _0x956d886b);
        this._0x04cb8325.onClick.AddListener(() => this._0x3ae7643b());
    }

    private void OnDestroy()
    {
        if (this._0xefd51ae4 != null)
        {
            DOTween.Kill(this._0xefd51ae4);
        }

        if (this._0x566e8898 != null)
        {
            DOTween.Kill(this._0x566e8898);
        }
    }

    private const float HintRow = 0.062f;
    private const float StakeRow = 0.262f;
    private Image _0xa608f988;
    private const float SpinRow = 0.150f;
}

internal static class _0xb05b988d
{
    internal static string _0x5d2329d7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}