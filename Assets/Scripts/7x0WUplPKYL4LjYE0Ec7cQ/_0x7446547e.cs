using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The eight sheets that sit over the lobby: the table list, the nightly gift, the
// mission card, the gallery, progress, the guest page, the rules and the settings.
//
// A sheet occupies the upper two thirds of the panel only. The row of doors underneath
// stays visible and live, so every door swaps one sheet for another and nothing ever has
// to be dismissed before the next screen can be reached - which also means no two frames
// of a walkthrough can come out identical.
//
// A sheet is rebuilt on every open rather than cached: captions and handlers are
// captured when the card is built, so a cached sheet would keep offering last visit's
// state and run last visit's handler.
public sealed class _0x7446547e : MonoBehaviour
{
    private void _0xdfcf001a(int _0xfb101d04)
    {
        int _0x22b1b5fc = this._0x5bfe9b76._0xb8844111;
        int _0xd7a86e55 = this._0xcad0c737._0x74a52e89(_0xfb101d04);
        if (_0xd7a86e55 <= 0)
        {
            return;
        }

        this._0x1f2fe672._0xef910fb8(_0x22b1b5fc, this._0x5bfe9b76._0xb8844111);
        if (this._0x36766cfc != null)
        {
            this._0x36766cfc._0x1ed714fa(this._0x5bfe9b76._0x54d74316);
        }

        this._0xc2131c56(SheetMissions);
        this._0x42ffce38(_0xc5c1e78e._0xe0a69b88(new byte[7] { 237, 252, 244, 249, 157, 144, 157 }, 189) + _0x1bad1984.Credits(_0xd7a86e55) + _0xc5c1e78e._0xe0a69b88(new byte[8] { 82, 49, 32, 55, 54, 59, 38, 33 }, 114));
    }

    private Sprite _0x264b2cfc;
    private Sprite _0x12caa0ef;
    private Sprite[] _0xf04887b1;
    // --- progress -------------------------------------------------------------
    private void _0xd1524edd()
    {
        int _0x8d6786b0 = this._0x5bfe9b76._0x75a6ad47;
        int _0xad07c457 = _0x8e9129d3.RankFor(_0x8d6786b0);
        this._0x331aa624(_0xc5c1e78e._0xe0a69b88(new byte[14] { 207, 200, 210, 212, 194, 167, 215, 213, 200, 192, 213, 194, 212, 212 }, 135), _0x8e9129d3.NameFor(_0xad07c457) + _0xc5c1e78e._0xe0a69b88(new byte[8] { 105, 100, 105, 27, 8, 7, 2, 105 }, 73) + _0x1bad1984.Pad2(_0xad07c457));
        RectTransform _0xca0f8cdf = _0x891ecf84.TopBox(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[13] { 252, 222, 195, 203, 222, 201, 223, 223, 225, 201, 200, 205, 192 }, 172), 0f, 300f, 240f, 240f);
        _0x891ecf84.Plate(_0xca0f8cdf, this._0xad20a59f, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.92f), 1.3f);
        RectTransform _0xffe58bca = _0x891ecf84.Stretch(_0xca0f8cdf, _0xc5c1e78e._0xe0a69b88(new byte[18] { 78, 108, 113, 121, 108, 123, 109, 109, 83, 123, 122, 127, 114, 87, 112, 112, 123, 108 }, 30));
        _0xffe58bca.offsetMin = new Vector2(10f, 10f);
        _0xffe58bca.offsetMax = new Vector2(-10f, -10f);
        _0x891ecf84.Plate(_0xffe58bca, this._0xad20a59f, _0xc5c3f38d.VelvetDeep, 1.5f);
        RectTransform _0x11fee21c = _0x891ecf84.Stretch(_0xca0f8cdf, _0xc5c1e78e._0xe0a69b88(new byte[17] { 131, 161, 188, 180, 161, 182, 160, 160, 158, 182, 183, 178, 191, 135, 182, 171, 167 }, 211));
        _0x891ecf84.Label(_0x11fee21c, this._0xa9b02f67, _0x1bad1984.Pad2(_0xad07c457), 74f, _0xc5c3f38d.Gold, TextAlignmentOptions.Center);
        int _0xb5065523 = _0x8e9129d3.FloorThreshold(_0xad07c457);
        int _0x67047806 = _0x8e9129d3.NextThreshold(_0xad07c457);
        RectTransform _0x91123f18 = _0x891ecf84.TopBox(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[11] { 237, 207, 210, 218, 207, 216, 206, 206, 255, 220, 207 }, 189), 0f, 470f, 880f, 44f);
        RectTransform _0xcf05f243 = _0x891ecf84.Meter(_0x91123f18, this._0xad20a59f, _0xc5c3f38d.With(_0xc5c3f38d.Ink, 0.85f), _0xc5c3f38d.Gold, 880f);
        _0x891ecf84.SetMeter(_0xcf05f243, 880f, _0x8e9129d3.Fraction(_0x8d6786b0));
        RectTransform _0x2dde5134 = _0x891ecf84.TopBox(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[15] { 19, 49, 44, 36, 49, 38, 48, 48, 1, 34, 49, 23, 38, 59, 55 }, 67), 0f, 528f, 880f, 46f);
        _0x891ecf84.Label(_0x2dde5134, this._0xa9b02f67, _0x1bad1984.Credits(_0x8d6786b0 - _0xb5065523) + _0xc5c1e78e._0xe0a69b88(new byte[3] { 11, 4, 11 }, 43) + _0x1bad1984.Credits(_0x67047806 - _0xb5065523) + _0xc5c1e78e._0xe0a69b88(new byte[3] { 168, 208, 216 }, 136), 30f, _0xc5c3f38d.Cream, TextAlignmentOptions.Center);
        string[] _0x739b51c2 =
        {
            _0xc5c1e78e._0xe0a69b88(new byte[6] { 236, 241, 235, 240, 250, 237 }, 190),
            _0xc5c1e78e._0xe0a69b88(new byte[4] { 84, 74, 77, 80 }, 3),
            _0xc5c1e78e._0xe0a69b88(new byte[9] { 63, 56, 46, 41, 93, 49, 52, 51, 56 }, 125),
            _0xc5c1e78e._0xe0a69b88(new byte[6] { 196, 209, 210, 220, 213, 195 }, 144),
            _0xc5c1e78e._0xe0a69b88(new byte[5] { 207, 193, 206, 220, 219 }, 136),
            _0xc5c1e78e._0xe0a69b88(new byte[5] { 70, 68, 87, 65, 86 }, 5)
        };
        string[] _0xb3e5b825 =
        {
            _0x1bad1984.Credits(this._0x5bfe9b76._0xa6100c56),
            _0x1bad1984.Credits(this._0x5bfe9b76._0xd99795a1),
            _0x1bad1984.Multiplier(this._0x5bfe9b76._0xa9560cca),
            _0x1bad1984.Pad2(this._0x5bfe9b76._0x3134c85a),
            _0x1bad1984.Pad2(this._0x5bfe9b76._0x6a89ca01),
            _0x1bad1984.Pad2(this._0x5bfe9b76._0xdcb87af9),
        };
        float[] _0xe13fd7de =
        {
            0.195f,
            0.5f,
            0.805f
        };
        for (int _0xe7b34ca1 = 0; _0xe7b34ca1 < 6; _0xe7b34ca1++)
        {
            int _0x865a00e4 = _0xe7b34ca1 / 3;
            int _0xc835d813 = _0xe7b34ca1 % 3;
            this._0x529d8e09(_0xe7b34ca1, _0xe13fd7de[_0xc835d813], 640f + _0x865a00e4 * 190f, _0x739b51c2[_0xe7b34ca1], _0xb3e5b825[_0xe7b34ca1]);
        }
    }

    // --- the mission card -----------------------------------------------------
    private void _0x880d68b6()
    {
        this._0x331aa624(_0xc5c1e78e._0xe0a69b88(new byte[12] { 157, 153, 131, 131, 153, 159, 158, 240, 147, 145, 130, 148 }, 208), _0xc5c1e78e._0xe0a69b88(new byte[33] { 42, 54, 44, 59, 59, 94, 52, 49, 60, 45, 94, 83, 94, 46, 63, 55, 58, 94, 55, 48, 94, 56, 44, 59, 59, 94, 61, 44, 59, 58, 55, 42, 45 }, 126));
        bool _0x0eb5088d = false;
        for (int _0x1d1f4027 = 0; _0x1d1f4027 < _0xbbd798a9.MissionSlots; _0x1d1f4027++)
        {
            if (!this._0xcad0c737._0xafab931d(_0x1d1f4027))
            {
                _0x0eb5088d = true;
            }

            this._0x0772b40a(_0x1d1f4027);
        }

        if (!_0x0eb5088d)
        {
            RectTransform _0x2ea8d939 = _0x891ecf84.BottomBox(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[12] { 73, 109, 119, 119, 109, 107, 106, 65, 105, 116, 112, 125 }, 4), 0f, 190f, 920f, 110f);
            _0x891ecf84.Label(_0x2ea8d939, this._0xa9b02f67, _0xc5c1e78e._0xe0a69b88(new byte[50] { 8, 5, 5, 105, 3, 6, 11, 26, 105, 10, 5, 12, 8, 27, 12, 13, 67, 8, 105, 7, 12, 30, 105, 10, 8, 27, 13, 105, 8, 15, 29, 12, 27, 105, 29, 1, 12, 105, 7, 12, 17, 29, 105, 26, 0, 29, 29, 0, 7, 14 }, 73), 31f, _0xc5c3f38d.Cream, TextAlignmentOptions.Center);
        }
    }

    private float _0x149228fb;
    // --- the nightly gift -----------------------------------------------------
    private void _0x4aa23789()
    {
        bool _0x211910e0 = this._0x4be4c0ec._0x5d45a0ca();
        this._0x331aa624(_0xc5c1e78e._0xe0a69b88(new byte[12] { 88, 95, 81, 94, 66, 90, 79, 54, 81, 95, 80, 66 }, 22), _0xc5c1e78e._0xe0a69b88(new byte[44] { 86, 64, 83, 64, 75, 37, 75, 76, 66, 77, 81, 86, 37, 40, 37, 67, 87, 64, 64, 37, 70, 87, 64, 65, 76, 81, 86, 37, 40, 37, 75, 74, 81, 77, 76, 75, 66, 37, 81, 74, 37, 71, 80, 92 }, 5));
        float[] _0x3bc58374 =
        {
            0.185f,
            0.395f,
            0.605f,
            0.815f
        };
        for (int _0x2f7f56ff = 0; _0x2f7f56ff < _0xbbd798a9.GiftDays; _0x2f7f56ff++)
        {
            int _0xd4abd1e7 = _0x2f7f56ff < 4 ? 0 : 1;
            int _0x036e62d6 = _0x2f7f56ff < 4 ? _0x2f7f56ff : _0x2f7f56ff - 4;
            float _0xc47b017a = _0xd4abd1e7 == 0 ? _0x3bc58374[_0x036e62d6] : _0x3bc58374[_0x036e62d6] + 0.105f;
            this._0x7fdf7489(_0x2f7f56ff, _0xc47b017a, _0xd4abd1e7 == 0 ? 300f : 530f);
        }

        RectTransform _0xcfaea2d5 = _0x891ecf84.TopBox(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[10] { 92, 114, 125, 111, 72, 111, 105, 126, 122, 112 }, 27), 0f, 790f, 920f, 54f);
        _0x891ecf84.Label(_0xcfaea2d5, this._0xa9b02f67, _0xc5c1e78e._0xe0a69b88(new byte[7] { 111, 104, 110, 121, 125, 119, 28 }, 60) + _0x1bad1984.Pad2(this._0x4be4c0ec._0x27772547()) + _0xc5c1e78e._0xe0a69b88(new byte[7] { 43, 69, 66, 76, 67, 95, 88 }, 11), 32f, _0xc5c3f38d.Cream, TextAlignmentOptions.Center);
        Button _0xbc460cbb = this._0xad2ba807(_0xc5c1e78e._0xe0a69b88(new byte[9] { 236, 194, 205, 223, 232, 199, 202, 194, 198 }, 171), 150f, 740f, 152f, _0x211910e0 ? _0xc5c1e78e._0xe0a69b88(new byte[18] { 168, 164, 166, 174, 203, 169, 170, 168, 160, 203, 191, 164, 166, 164, 185, 185, 164, 188 }, 235) : _0xc5c1e78e._0xe0a69b88(new byte[13] { 249, 246, 251, 243, 247, 154, 238, 245, 244, 243, 253, 242, 238 }, 186), 42f);
        _0xbc460cbb.interactable = !_0x211910e0;
        _0xbc460cbb.onClick.AddListener(() => this._0xcf25118e());
    }

    // The row keeps two columns that never share x space (C.25): a medal gutter on the
    // left and the text column a clear gap to its right. Measured below.
    private void _0x0772b40a(int _0x11501a8c)
    {
        _0xcffa2836 _0x5ff143a2 = this._0xcad0c737._0xb6850feb[_0x11501a8c];
        if (_0x5ff143a2 == null)
        {
            return;
        }

        int _0xf3638c21 = this._0xcad0c737._0x5ec2cf7b(_0x11501a8c);
        bool _0x3bd2bfe7 = this._0xcad0c737._0x0ce6684f(_0x11501a8c);
        bool _0x718c4c01 = this._0xcad0c737._0xafab931d(_0x11501a8c);
        Image _0xd7e84cf7;
        RectTransform _0x7fe176cd = this._0x10a59fea(_0xc5c1e78e._0xe0a69b88(new byte[10] { 193, 229, 255, 255, 229, 227, 226, 222, 227, 251 }, 140) + _0x11501a8c.ToString(), 250f + _0x11501a8c * 260f, 960f, 236f, out _0xd7e84cf7, _0x718c4c01 ? _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.95f) : _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.45f));
        // Three bands that never share x space (C.25). The row is 960 wide, so the
        // numbers on the right need a band of their own rather than a position nudged
        // in from the edge - at 150 wide and 60 from the edge they ran 15 units off the
        // card and straight through the title.
        //   gutter  36 .. 132   (medal)
        //   text   180 .. 650
        //   right  682 .. 922   (counter, reward, state)
        const float _0x8d6f6fbf = 84f;
        const float _0xb13e577e = 96f;
        const float _0xeddb9370 = 180f; // gutter right edge 132 plus a 48 gap
        const float _0x5156c69a = 470f; // 180 + 470 = 650, and 682 - 650 = 32 of clear air
        const float _0xd3dffa58 = 158f; // from the RIGHT edge: 960 - 158 = 802, half of 240 either side
        const float _0x676c3bb9 = 240f;
        RectTransform _0x19d22bff = _0x891ecf84.LeftBox(_0x7fe176cd, _0xc5c1e78e._0xe0a69b88(new byte[12] { 111, 75, 81, 81, 75, 77, 76, 111, 71, 70, 67, 78 }, 34) + _0x11501a8c.ToString(), _0x8d6f6fbf, 0f, _0xb13e577e, 132f);
        _0x891ecf84.Plate(_0x19d22bff, this._0xad20a59f, _0x718c4c01 ? _0xc5c3f38d.Gold : _0xc5c3f38d.With(_0xc5c3f38d.VelvetDeep, 0.95f), 1.4f);
        RectTransform _0x1f4f4fef = _0x891ecf84.Stretch(_0x19d22bff, _0xc5c1e78e._0xe0a69b88(new byte[16] { 227, 199, 221, 221, 199, 193, 192, 227, 203, 202, 207, 194, 250, 203, 214, 218 }, 174) + _0x11501a8c.ToString());
        _0x1f4f4fef.offsetMin = new Vector2(6f, 6f);
        _0x1f4f4fef.offsetMax = new Vector2(-6f, -6f);
        _0x891ecf84.Label(_0x1f4f4fef, this._0xa9b02f67, _0x1bad1984.Pad2(_0x11501a8c + 1), 40f, _0x718c4c01 ? _0xc5c3f38d.VelvetDeep : _0xc5c3f38d.Gold, TextAlignmentOptions.Center);
        float _0x228c328c = _0xeddb9370 + _0x5156c69a * 0.5f;
        RectTransform _0x3fdb6473 = _0x891ecf84.Node(_0x7fe176cd, _0xc5c1e78e._0xe0a69b88(new byte[12] { 173, 137, 147, 147, 137, 143, 142, 180, 137, 148, 140, 133 }, 224) + _0x11501a8c.ToString(), new Vector2(0f, 0.5f), new Vector2(0f, 0.5f), new Vector2(_0x228c328c, 56f), new Vector2(_0x5156c69a, 54f));
        _0x891ecf84.Label(_0x3fdb6473, this._0xa9b02f67, _0x5ff143a2._0xd7110322, 38f, _0xc5c3f38d.Gold, TextAlignmentOptions.Left);
        RectTransform _0xf5de102e = _0x891ecf84.Node(_0x7fe176cd, _0xc5c1e78e._0xe0a69b88(new byte[11] { 22, 50, 40, 40, 50, 52, 53, 19, 50, 53, 47 }, 91) + _0x11501a8c.ToString(), new Vector2(0f, 0.5f), new Vector2(0f, 0.5f), new Vector2(_0x228c328c, 8f), new Vector2(_0x5156c69a, 42f));
        _0x891ecf84.Label(_0xf5de102e, this._0xa9b02f67, _0x5ff143a2._0x7c678146, 26f, _0xc5c3f38d.CreamDim, TextAlignmentOptions.Left);
        RectTransform _0xd88900d0 = _0x891ecf84.Node(_0x7fe176cd, _0xc5c1e78e._0xe0a69b88(new byte[10] { 82, 118, 108, 108, 118, 112, 113, 93, 126, 109 }, 31) + _0x11501a8c.ToString(), new Vector2(0f, 0.5f), new Vector2(0f, 0.5f), new Vector2(_0x228c328c, -46f), new Vector2(_0x5156c69a, 26f));
        RectTransform _0x413be909 = _0x891ecf84.Meter(_0xd88900d0, this._0xad20a59f, _0xc5c3f38d.With(_0xc5c3f38d.Ink, 0.85f), _0xc5c3f38d.Gold, _0x5156c69a);
        _0x891ecf84.SetMeter(_0x413be909, _0x5156c69a, _0x5ff143a2._0xe985d815(_0xf3638c21));
        RectTransform _0xab9c6e26 = _0x891ecf84.RightBox(_0x7fe176cd, _0xc5c1e78e._0xe0a69b88(new byte[12] { 84, 112, 106, 106, 112, 118, 119, 90, 118, 108, 119, 109 }, 25) + _0x11501a8c.ToString(), _0xd3dffa58, 56f, _0x676c3bb9, 44f);
        _0x891ecf84.Label(_0xab9c6e26, this._0xa9b02f67, _0x5ff143a2._0xb22436e9(_0xf3638c21), 28f, _0xc5c3f38d.Cream, TextAlignmentOptions.Right);
        RectTransform _0x2a99a98b = _0x891ecf84.RightBox(_0x7fe176cd, _0xc5c1e78e._0xe0a69b88(new byte[13] { 210, 246, 236, 236, 246, 240, 241, 205, 250, 232, 254, 237, 251 }, 159) + _0x11501a8c.ToString(), _0xd3dffa58, 0f, _0x676c3bb9, 48f);
        _0x891ecf84.Label(_0x2a99a98b, this._0xa9b02f67, _0xc5c1e78e._0xe0a69b88(new byte[1] { 123 }, 80) + _0x5ff143a2._0x626dd4e4.ToString(), 34f, _0xc5c3f38d.GoldLit, TextAlignmentOptions.Right);
        RectTransform _0x9584386c = _0x891ecf84.RightBox(_0x7fe176cd, _0xc5c1e78e._0xe0a69b88(new byte[12] { 84, 112, 106, 106, 112, 118, 119, 74, 109, 120, 109, 124 }, 25) + _0x11501a8c.ToString(), _0xd3dffa58, -58f, _0x676c3bb9, 44f);
        _0x891ecf84.Label(_0x9584386c, this._0xa9b02f67, _0x718c4c01 ? _0xc5c1e78e._0xe0a69b88(new byte[7] { 83, 92, 81, 89, 93, 85, 84 }, 16) : (_0x3bd2bfe7 ? _0xc5c1e78e._0xe0a69b88(new byte[12] { 182, 163, 178, 194, 182, 173, 194, 161, 174, 163, 171, 175 }, 226) : _0xc5c1e78e._0xe0a69b88(new byte[11] { 36, 35, 77, 61, 63, 34, 42, 63, 40, 62, 62 }, 109)), 25f, _0x718c4c01 ? _0xc5c3f38d.GoldLit : _0xc5c3f38d.CreamDim, TextAlignmentOptions.Right);
        if (_0x3bd2bfe7 && !_0x718c4c01)
        {
            _0xd7e84cf7.raycastTarget = true;
            Button _0xb81fa600 = _0x891ecf84.Touchable(_0x7fe176cd, _0xd7e84cf7);
            _0xb81fa600.onClick.AddListener(() => this._0xdfcf001a(_0x11501a8c));
        }
    }

    private int _0x9ade1df1 = -1;
    private _0x9a16fc44 _0x4be4c0ec;
    private RectTransform _0xed0a6a60;
    private void _0xc34315ec()
    {
        if (this._0xfd60f159 != null)
        {
            this._0xfd60f159.SetParent(null, false);
            Destroy(this._0xfd60f159.gameObject);
            this._0xfd60f159 = null;
            this._0xed0a6a60 = null;
            this._0x980e728c = null;
        }
    }

    // A confirmation card, not a popup: the menu scene wires no popups at all, so one
    // raised here would have nothing to show.
    private void _0x71135ecc()
    {
        this._0xc34315ec();
        this._0x9ade1df1 = SheetSettings;
        this._0xfd60f159 = _0x891ecf84.Node(this._0x3a298449, _0xc5c1e78e._0xe0a69b88(new byte[5] { 124, 71, 74, 74, 91 }, 47), new Vector2(0f, this._0xb880c2d7), new Vector2(1f, this._0x394c2816), Vector2.zero, new Vector2(-180f, 0f));
        this._0xfd60f159.SetAsLastSibling();
        _0x891ecf84.Plate(this._0xfd60f159, this._0xad20a59f, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.92f), 2.2f);
        RectTransform _0x154f5df6 = _0x891ecf84.Stretch(this._0xfd60f159, _0xc5c1e78e._0xe0a69b88(new byte[9] { 65, 122, 119, 119, 102, 80, 125, 118, 107 }, 18));
        _0x154f5df6.offsetMin = new Vector2(8f, 8f);
        _0x154f5df6.offsetMax = new Vector2(-8f, -8f);
        _0x891ecf84.Plate(_0x154f5df6, this._0xad20a59f, _0xc5c3f38d.Velvet, 2.4f);
        this._0xed0a6a60 = _0x891ecf84.Stretch(this._0xfd60f159, _0xc5c1e78e._0xe0a69b88(new byte[12] { 2, 57, 52, 52, 37, 18, 62, 63, 37, 52, 63, 37 }, 81));
        this._0x331aa624(_0xc5c1e78e._0xe0a69b88(new byte[12] { 109, 126, 105, 12, 117, 99, 121, 12, 127, 121, 126, 105 }, 44), _0xc5c1e78e._0xe0a69b88(new byte[37] { 96, 124, 125, 103, 20, 119, 120, 113, 117, 102, 103, 20, 113, 98, 113, 102, 109, 96, 124, 125, 122, 115, 20, 123, 122, 20, 96, 124, 125, 103, 20, 112, 113, 98, 125, 119, 113 }, 52));
        RectTransform _0xa0d94457 = _0x891ecf84.TopBox(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[9] { 234, 221, 203, 221, 204, 250, 215, 220, 193 }, 184), 0f, 420f, 900f, 260f);
        _0x891ecf84.Label(_0xa0d94457, this._0xa9b02f67, _0xc5c1e78e._0xe0a69b88(new byte[89] { 140, 154, 128, 135, 245, 135, 148, 155, 158, 249, 245, 146, 148, 153, 153, 144, 135, 140, 249, 245, 134, 129, 135, 144, 148, 158, 245, 148, 155, 145, 223, 152, 156, 134, 134, 156, 154, 155, 245, 150, 148, 135, 145, 245, 148, 135, 144, 245, 144, 135, 148, 134, 144, 145, 251, 223, 140, 154, 128, 135, 245, 134, 144, 148, 129, 245, 135, 144, 129, 128, 135, 155, 134, 245, 129, 154, 245, 227, 229, 229, 245, 150, 135, 144, 145, 156, 129, 134, 251 }, 213), 34f, _0xc5c3f38d.Cream, TextAlignmentOptions.Center);
        Button _0xd3573ea0 = this._0xad2ba807(_0xc5c1e78e._0xe0a69b88(new byte[8] { 211, 228, 242, 228, 245, 216, 228, 242 }, 129), 320f, 700f, 134f, _0xc5c1e78e._0xe0a69b88(new byte[13] { 229, 249, 239, 144, 156, 255, 240, 249, 253, 238, 156, 245, 232 }, 188), 40f);
        _0xd3573ea0.onClick.AddListener(() => this._0xf1dbc47c());
        Button _0x3f1115c2 = this._0xc0eec4d8(_0xc5c1e78e._0xe0a69b88(new byte[7] { 127, 72, 94, 72, 89, 99, 66 }, 45), 170f, 560f, 112f, _0xc5c1e78e._0xe0a69b88(new byte[16] { 223, 209, 209, 196, 180, 217, 205, 180, 196, 198, 219, 211, 198, 209, 199, 199 }, 148), 34f);
        _0x3f1115c2.onClick.AddListener(() => this._0xc2131c56(SheetSettings));
    }

    private Button _0xc0eec4d8(string _0xbd721d55, float _0xe1493462, float _0x16c4a927, float _0x9c9fbe12, string _0x79299594, float _0x0dcf96d1)
    {
        RectTransform _0x3560247b = _0x891ecf84.BottomBox(this._0xed0a6a60, _0xbd721d55, 0f, _0xe1493462, _0x16c4a927, _0x9c9fbe12);
        return _0x891ecf84.Cta(_0x3560247b, this._0xa9b02f67, null, this._0xad20a59f, _0x79299594, _0x0dcf96d1, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.6f), _0xc5c3f38d.With(_0xc5c3f38d.VelvetDeep, 0.9f), _0xc5c3f38d.Gold);
    }

    // A short line that appears for a moment after an action, so a tap always leaves a
    // mark a still frame can show (C.7).
    private void _0x42ffce38(string _0xe6a3a74c)
    {
        if (this._0xed0a6a60 == null)
        {
            return;
        }

        if (this._0x980e728c == null)
        {
            RectTransform _0xdd75d2de = _0x891ecf84.BottomBox(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[11] { 179, 136, 133, 133, 148, 162, 129, 142, 142, 133, 146 }, 224), 0f, 34f, 940f, 56f);
            this._0x980e728c = _0x891ecf84.Label(_0xdd75d2de, this._0xa9b02f67, "", 31f, _0xc5c3f38d.GoldLit, TextAlignmentOptions.Center);
        }

        _0x1bad1984.SetText(this._0x980e728c, _0xe6a3a74c);
        this._0x980e728c.transform.localScale = Vector3.one * 0.9f;
        this._0x980e728c.transform.DOScale(1f, 0.3f).SetEase(Ease.OutBack).SetLink(this._0x980e728c.gameObject);
    }

    private RectTransform[] _0x2fc4aab6 = new RectTransform[8];
    private void _0x61e57c8e(int _0x81501b9c)
    {
        _0x9aaba7e8 _0xb0eac4fa = _0xdfaf60d5.At(_0x81501b9c);
        bool _0x3cf74407 = this._0x5bfe9b76._0x97795416 == _0x81501b9c;
        Image _0xca4a1cd3;
        RectTransform _0xaf173d28 = this._0x10a59fea(_0xc5c1e78e._0xe0a69b88(new byte[8] { 200, 253, 254, 240, 249, 206, 243, 235 }, 156) + _0x81501b9c.ToString(), 310f + _0x81501b9c * 250f, 960f, 224f, out _0xca4a1cd3, _0x3cf74407 ? _0xc5c3f38d.Gold : _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.45f));
        _0xca4a1cd3.raycastTarget = true;
        if (_0x81501b9c >= 0 && _0x81501b9c < this._0x2fc4aab6.Length)
        {
            this._0x2fc4aab6[_0x81501b9c] = _0xaf173d28;
        }

        RectTransform _0xc915322b = _0x891ecf84.LeftBox(_0xaf173d28, _0xc5c1e78e._0xe0a69b88(new byte[10] { 243, 198, 197, 203, 194, 228, 213, 194, 212, 211 }, 167) + _0x81501b9c.ToString(), 96f, 0f, 128f, 168f);
        _0x891ecf84.Plate(_0xc915322b, this._0xad20a59f, _0xc5c3f38d.With(_0xc5c3f38d.RubyDeep, 0.95f), 1.6f);
        Sprite _0xbcb47b3e = this._0x8b72f75c(_0x81501b9c);
        if (_0xbcb47b3e != null)
        {
            RectTransform _0xb8e01959 = _0x891ecf84.Stretch(_0xc915322b, _0xc5c1e78e._0xe0a69b88(new byte[13] { 57, 12, 15, 1, 8, 46, 31, 8, 30, 25, 44, 31, 25 }, 109) + _0x81501b9c.ToString());
            _0xb8e01959.offsetMin = new Vector2(18f, 18f);
            _0xb8e01959.offsetMax = new Vector2(-18f, -18f);
            _0x891ecf84.Picture(_0xb8e01959, _0xbcb47b3e, Color.white);
        }

        const float _0xc497e21f = 196f;
        const float _0x4044c4e3 = 560f;
        RectTransform _0x228db458 = _0x891ecf84.Node(_0xaf173d28, _0xc5c1e78e._0xe0a69b88(new byte[9] { 57, 12, 15, 1, 8, 35, 12, 0, 8 }, 109) + _0x81501b9c.ToString(), new Vector2(0f, 0.5f), new Vector2(0f, 0.5f), new Vector2(_0xc497e21f + _0x4044c4e3 * 0.5f, 40f), new Vector2(_0x4044c4e3, 58f));
        _0x891ecf84.Label(_0x228db458, this._0xa9b02f67, _0xb0eac4fa._0x374268d8, 42f, _0xc5c3f38d.Gold, TextAlignmentOptions.Left);
        RectTransform _0x5e65bb1e = _0x891ecf84.Node(_0xaf173d28, _0xc5c1e78e._0xe0a69b88(new byte[9] { 89, 108, 111, 97, 104, 65, 100, 99, 104 }, 13) + _0x81501b9c.ToString(), new Vector2(0f, 0.5f), new Vector2(0f, 0.5f), new Vector2(_0xc497e21f + _0x4044c4e3 * 0.5f, -32f), new Vector2(_0x4044c4e3, 46f));
        _0x891ecf84.Label(_0x5e65bb1e, this._0xa9b02f67, _0xb0eac4fa._0x7f1ca861, 27f, _0xc5c3f38d.CreamDim, TextAlignmentOptions.Left);
        RectTransform _0xe2293573 = _0x891ecf84.RightBox(_0xaf173d28, _0xc5c1e78e._0xe0a69b88(new byte[9] { 246, 195, 192, 206, 199, 225, 202, 203, 210 }, 162) + _0x81501b9c.ToString(), 110f, 0f, 176f, 72f);
        _0x891ecf84.Plate(_0xe2293573, this._0xad20a59f, _0x3cf74407 ? _0xc5c3f38d.Gold : _0xc5c3f38d.With(_0xc5c3f38d.VelvetDeep, 0.95f), 1.5f);
        RectTransform _0x569109a0 = _0x891ecf84.Stretch(_0xe2293573, _0xc5c1e78e._0xe0a69b88(new byte[13] { 37, 16, 19, 29, 20, 50, 25, 24, 1, 37, 20, 9, 5 }, 113) + _0x81501b9c.ToString());
        _0x569109a0.offsetMin = new Vector2(10f, 8f);
        _0x569109a0.offsetMax = new Vector2(-10f, -8f);
        _0x891ecf84.Label(_0x569109a0, this._0xa9b02f67, _0x3cf74407 ? _0xc5c1e78e._0xe0a69b88(new byte[6] { 180, 162, 166, 179, 162, 163 }, 231) : _0xc5c1e78e._0xe0a69b88(new byte[8] { 80, 74, 87, 35, 75, 70, 81, 70 }, 3), 28f, _0x3cf74407 ? _0xc5c3f38d.VelvetDeep : _0xc5c3f38d.Cream, TextAlignmentOptions.Center);
        Button _0x4488a182 = _0x891ecf84.Touchable(_0xaf173d28, _0xca4a1cd3);
        _0x4488a182.onClick.AddListener(() => this._0x8aca55d2(_0x81501b9c));
    }

    // Choosing a seat changes four visible things at once, so the tap is unmistakable
    // in a still frame (C.7): the frame and the chip move to the new row, the lobby
    // card behind the sheet is repainted, the row takes a knock and a line is printed.
    private void _0x8aca55d2(int _0x9114cda6)
    {
        _0x9aaba7e8 _0x5d2d4d26 = _0xdfaf60d5.At(_0x9114cda6);
        this._0x5bfe9b76._0x97795416 = _0x9114cda6;
        this._0x5bfe9b76._0x45319abc = _0x5d2d4d26._0xc24dddd0;
        this._0x5bfe9b76._0xae49789f(_0x9114cda6);
        this._0x5bfe9b76._0x55475292();
        this._0x1f2fe672._0x3ebf3aa2();
        this._0xc2131c56(SheetLibrary);
        this._0x42ffce38(_0xc5c1e78e._0xe0a69b88(new byte[13] { 230, 240, 244, 225, 149, 225, 244, 254, 240, 251, 149, 152, 149 }, 181) + _0x5d2d4d26._0x374268d8);
        RectTransform _0xc0a1c3c6 = _0x9114cda6 >= 0 && _0x9114cda6 < this._0x2fc4aab6.Length ? this._0x2fc4aab6[_0x9114cda6] : null;
        if (_0xc0a1c3c6 != null)
        {
            _0xc0a1c3c6.DOPunchScale(new Vector3(0.04f, 0.04f, 0f), 0.5f, 1, 0.5f).SetLink(_0xc0a1c3c6.gameObject);
        }
    }

    private float _0x394c2816;
    // A stat plate carries a colour dot, a big figure and a caption - and no picture at
    // all. Every painted sprite has its own subject inside the frame, so a row of them
    // reads as six different sizes; colour and type do the work instead.
    private void _0x529d8e09(int _0xd5770378, float _0x257de1f6, float _0xe9cfe39d, string _0xf17bc634, string _0x056420d3)
    {
        RectTransform _0xa5c2bc0e = _0x891ecf84.Node(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[8] { 89, 126, 107, 126, 94, 99, 102, 111 }, 10) + _0xd5770378.ToString(), new Vector2(_0x257de1f6, 1f), new Vector2(_0x257de1f6, 1f), new Vector2(0f, -_0xe9cfe39d), new Vector2(286f, 170f));
        _0x891ecf84.Plate(_0xa5c2bc0e, this._0xad20a59f, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.5f), 2f);
        RectTransform _0xeea8aa65 = _0x891ecf84.Stretch(_0xa5c2bc0e, _0xc5c1e78e._0xe0a69b88(new byte[8] { 139, 172, 185, 172, 154, 183, 188, 161 }, 216) + _0xd5770378.ToString());
        _0xeea8aa65.offsetMin = new Vector2(5f, 5f);
        _0xeea8aa65.offsetMax = new Vector2(-5f, -5f);
        _0x891ecf84.Plate(_0xeea8aa65, this._0xad20a59f, _0xc5c3f38d.VelvetDeep, 2.2f);
        RectTransform _0x63185666 = _0x891ecf84.Node(_0xa5c2bc0e, _0xc5c1e78e._0xe0a69b88(new byte[7] { 142, 169, 188, 169, 153, 178, 169 }, 221) + _0xd5770378.ToString(), new Vector2(0f, 1f), new Vector2(0f, 1f), new Vector2(28f, -26f), new Vector2(16f, 16f));
        _0x891ecf84.Plate(_0x63185666, this._0xad20a59f, _0xc5c3f38d.Rank(_0xd5770378 % 5), 1f);
        RectTransform _0xce8154d7 = _0x891ecf84.TopBox(_0xa5c2bc0e, _0xc5c1e78e._0xe0a69b88(new byte[9] { 245, 210, 199, 210, 240, 199, 202, 211, 195 }, 166) + _0xd5770378.ToString(), 0f, 72f, 250f, 62f);
        _0x891ecf84.Label(_0xce8154d7, this._0xa9b02f67, _0x056420d3, 46f, _0xc5c3f38d.Gold, TextAlignmentOptions.Center);
        RectTransform _0x43d200ee = _0x891ecf84.BottomBox(_0xa5c2bc0e, _0xc5c1e78e._0xe0a69b88(new byte[11] { 13, 42, 63, 42, 29, 63, 46, 42, 55, 49, 48 }, 94) + _0xd5770378.ToString(), 0f, 34f, 250f, 42f);
        _0x891ecf84.Label(_0x43d200ee, this._0xa9b02f67, _0xf17bc634, 26f, _0xc5c3f38d.CreamDim, TextAlignmentOptions.Center);
    }

    private Sprite _0xad20a59f;
    // --- the gallery ----------------------------------------------------------
    private void _0x33447242()
    {
        int _0xd7f11057 = this._0x5bfe9b76._0xdcb87af9;
        this._0x331aa624(_0xc5c1e78e._0xe0a69b88(new byte[11] { 35, 63, 50, 87, 48, 54, 59, 59, 50, 37, 46 }, 119), _0xc5c1e78e._0xe0a69b88(new byte[8] { 160, 166, 171, 171, 162, 181, 190, 199 }, 231) + _0x1bad1984.Pad2(_0xd7f11057) + _0xc5c1e78e._0xe0a69b88(new byte[4] { 148, 251, 242, 148 }, 180) + _0x1bad1984.Pad2(_0xbbd798a9.CollectionSlots));
        float[] _0x166249f3 =
        {
            0.195f,
            0.5f,
            0.805f
        };
        for (int _0xaaa3f2ec = 0; _0xaaa3f2ec < _0xbbd798a9.CollectionSlots; _0xaaa3f2ec++)
        {
            int _0x0568357a = _0xaaa3f2ec / 3;
            int _0x82ee0748 = _0xaaa3f2ec % 3;
            this._0xeb461ae5(_0xaaa3f2ec, _0x166249f3[_0x82ee0748], 380f + _0x0568357a * 350f, _0xaaa3f2ec < _0xd7f11057);
        }

        if (_0xd7f11057 == 0)
        {
            RectTransform _0xbe0a0eb4 = _0x891ecf84.BottomBox(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[12] { 240, 214, 219, 219, 210, 197, 206, 242, 218, 199, 195, 206 }, 183), 0f, 42f, 940f, 60f);
            _0x891ecf84.Label(_0xbe0a0eb4, this._0xa9b02f67, _0xc5c1e78e._0xe0a69b88(new byte[30] { 58, 33, 35, 32, 44, 36, 79, 44, 46, 61, 43, 60, 79, 45, 54, 79, 63, 35, 46, 54, 38, 33, 40, 79, 61, 32, 58, 33, 43, 60 }, 111), 30f, _0xc5c3f38d.Cream, TextAlignmentOptions.Center);
        }
    }

    private void _0xcf25118e()
    {
        int _0x92ec325d = this._0x5bfe9b76._0xb8844111;
        int _0xb3465c94 = this._0x4be4c0ec._0xba46b02e();
        if (_0xb3465c94 <= 0)
        {
            this._0x42ffce38(_0xc5c1e78e._0xe0a69b88(new byte[38] { 116, 111, 110, 105, 103, 104, 116, 7, 115, 0, 103, 105, 102, 116, 0, 105, 115, 0, 97, 108, 114, 101, 97, 100, 121, 0, 105, 110, 0, 116, 104, 101, 0, 112, 117, 114, 115, 101 }, 32));
            return;
        }

        this._0xcad0c737._0x5dc80aab();
        this._0x1f2fe672._0xef910fb8(_0x92ec325d, this._0x5bfe9b76._0xb8844111);
        if (this._0x36766cfc != null)
        {
            this._0x36766cfc._0x1ed714fa(this._0x5bfe9b76._0x54d74316);
        }

        this._0xc2131c56(SheetDaily);
        this._0x42ffce38(_0xc5c1e78e._0xe0a69b88(new byte[10] { 152, 151, 154, 146, 150, 158, 159, 251, 246, 251 }, 219) + _0x1bad1984.Credits(_0xb3465c94) + _0xc5c1e78e._0xe0a69b88(new byte[13] { 198, 160, 180, 163, 163, 198, 165, 180, 163, 162, 175, 178, 181 }, 230));
    }

    public void _0x82082b76(_0x5e7f3d72 _0x8e624fe3, RectTransform _0xb9f3f286, _0xe54e0344 _0x8506a94b, _0x9a16fc44 _0x32c083b3, _0x542b1bfd _0x10827951, TMP_FontAsset _0x0b56dd7f, Sprite _0x44964b69, Sprite _0x348cc641, Sprite _0x75b94f99, Sprite _0x9808d76f, Sprite[] _0x476e4d80, float _0x499ca3d3, float _0x0e83c85d, float _0x5a765745)
    {
        this._0x1f2fe672 = _0x8e624fe3;
        this._0x3a298449 = _0xb9f3f286;
        this._0x5bfe9b76 = _0x8506a94b;
        this._0x4be4c0ec = _0x32c083b3;
        this._0xcad0c737 = _0x10827951;
        this._0xa9b02f67 = _0x0b56dd7f;
        this._0xad20a59f = _0x44964b69;
        this._0x264b2cfc = _0x348cc641;
        this._0x6067fd77 = _0x75b94f99;
        this._0x12caa0ef = _0x9808d76f;
        this._0xf04887b1 = _0x476e4d80;
        this._0xb880c2d7 = _0x499ca3d3;
        this._0x394c2816 = _0x0e83c85d;
        this._0x149228fb = _0x5a765745;
        this._0x2f6b21d9 = _0x891ecf84.Node(_0xb9f3f286, _0xc5c1e78e._0xe0a69b88(new byte[10] { 161, 154, 151, 151, 134, 161, 145, 128, 155, 159 }, 242), new Vector2(0f, _0x5a765745), new Vector2(1f, 1f), Vector2.zero, Vector2.zero);
        Image _0x831f9173 = _0x891ecf84.Quad(this._0x2f6b21d9, _0xc5c3f38d.With(_0xc5c3f38d.Ink, 0.86f));
        _0x831f9173.raycastTarget = true;
        Button _0x74f50680 = _0x891ecf84.Touchable(this._0x2f6b21d9, _0x831f9173);
        _0x74f50680.transition = Selectable.Transition.None;
        _0x74f50680.onClick.AddListener(() => this._0x921c31f4());
        this._0x2f6b21d9.gameObject.SetActive(false);
        RectTransform _0x462a8ec6 = _0x891ecf84.Stretch(_0xb9f3f286, _0xc5c1e78e._0xe0a69b88(new byte[13] { 133, 166, 171, 171, 176, 138, 166, 167, 175, 172, 189, 189, 160 }, 201));
        this._0x36766cfc = _0x462a8ec6.gameObject.AddComponent<_0xfc35b876>();
        this._0x36766cfc._0x3e47e0b4(this._0xad20a59f, this._0xf04887b1);
    }

    private _0xe54e0344 _0x5bfe9b76;
    // --- the rules ------------------------------------------------------------
    private void _0xa58f604b()
    {
        string[] _0x414bcd5d =
        {
            _0xc5c1e78e._0xe0a69b88(new byte[17] { 89, 94, 70, 49, 80, 49, 67, 94, 68, 95, 85, 49, 70, 94, 67, 90, 66 }, 17),
            _0xc5c1e78e._0xe0a69b88(new byte[17] { 151, 148, 153, 131, 130, 246, 130, 158, 147, 246, 149, 132, 147, 146, 159, 130, 133 }, 214),
            _0xc5c1e78e._0xe0a69b88(new byte[9] { 162, 190, 179, 171, 210, 180, 179, 187, 160 }, 242)
        };
        string[] _0x311f06c1 =
        {
            _0xc5c1e78e._0xe0a69b88(new byte[131] { 70, 95, 85, 93, 54, 87, 54, 69, 83, 87, 66, 54, 87, 88, 82, 54, 87, 54, 69, 66, 87, 93, 83, 56, 28, 66, 94, 68, 83, 83, 54, 85, 89, 90, 67, 91, 88, 69, 54, 69, 66, 89, 70, 54, 89, 88, 54, 80, 95, 64, 83, 54, 90, 95, 88, 83, 69, 56, 28, 66, 94, 68, 83, 83, 54, 91, 87, 66, 85, 94, 95, 88, 81, 54, 80, 87, 85, 83, 69, 54, 70, 87, 79, 54, 66, 94, 83, 54, 90, 95, 88, 83, 56, 28, 66, 94, 83, 54, 65, 95, 90, 82, 54, 91, 87, 69, 93, 54, 69, 66, 87, 88, 82, 69, 54, 95, 88, 54, 80, 89, 68, 54, 87, 88, 79, 54, 80, 87, 85, 83, 56 }, 22),
            _0xc5c1e78e._0xe0a69b88(new byte[152] { 121, 104, 127, 126, 115, 110, 105, 26, 123, 104, 127, 26, 124, 104, 127, 127, 20, 48, 110, 114, 127, 99, 26, 121, 123, 116, 116, 117, 110, 26, 120, 127, 26, 120, 117, 111, 125, 114, 110, 22, 26, 105, 117, 118, 126, 22, 48, 109, 115, 110, 114, 126, 104, 123, 109, 116, 26, 117, 104, 26, 127, 98, 121, 114, 123, 116, 125, 127, 126, 20, 48, 110, 114, 127, 99, 26, 114, 123, 108, 127, 26, 116, 117, 26, 121, 123, 105, 114, 26, 108, 123, 118, 111, 127, 20, 48, 104, 111, 116, 116, 115, 116, 125, 26, 117, 111, 110, 26, 121, 117, 105, 110, 105, 26, 116, 117, 110, 114, 115, 116, 125, 26, 23, 48, 110, 114, 127, 26, 114, 117, 111, 105, 127, 26, 104, 127, 124, 115, 118, 118, 105, 26, 99, 117, 111, 104, 26, 105, 127, 123, 110, 20 }, 58),
            _0xc5c1e78e._0xe0a69b88(new byte[140] { 254, 247, 239, 159, 131, 154, 156, 225, 239, 138, 129, 155, 138, 157, 155, 142, 134, 129, 130, 138, 129, 155, 239, 128, 129, 131, 150, 225, 197, 138, 153, 138, 157, 150, 239, 157, 128, 154, 129, 139, 239, 134, 156, 239, 139, 157, 142, 152, 129, 239, 128, 129, 239, 134, 155, 156, 239, 128, 152, 129, 239, 142, 129, 139, 197, 132, 129, 128, 152, 156, 239, 129, 128, 155, 135, 134, 129, 136, 239, 128, 137, 239, 155, 135, 138, 239, 128, 129, 138, 239, 141, 138, 137, 128, 157, 138, 239, 134, 155, 225, 197, 155, 142, 132, 138, 239, 141, 157, 138, 142, 132, 156, 225, 239, 155, 135, 138, 157, 138, 239, 134, 156, 239, 129, 128, 155, 135, 134, 129, 136, 239, 155, 128, 239, 140, 135, 142, 156, 138, 225 }, 207),
        };
        int _0xb1e95508 = this._0x457dca0a < 0 ? 0 : (this._0x457dca0a > 2 ? 2 : this._0x457dca0a);
        this._0x331aa624(_0xc5c1e78e._0xe0a69b88(new byte[11] { 187, 188, 166, 160, 182, 211, 161, 166, 191, 182, 160 }, 243), _0xc5c1e78e._0xe0a69b88(new byte[5] { 75, 90, 92, 94, 59 }, 27) + (_0xb1e95508 + 1).ToString() + _0xc5c1e78e._0xe0a69b88(new byte[5] { 33, 78, 71, 33, 50 }, 1));
        RectTransform _0x64359f76 = _0x891ecf84.TopBox(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[9] { 239, 200, 209, 216, 206, 245, 216, 220, 217 }, 189), 0f, 260f, 900f, 66f);
        _0x891ecf84.Label(_0x64359f76, this._0xa9b02f67, _0x414bcd5d[_0xb1e95508], 40f, _0xc5c3f38d.Gold, TextAlignmentOptions.Center);
        RectTransform _0x04bc4d8a = _0x891ecf84.TopBox(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[9] { 37, 2, 27, 18, 4, 53, 24, 19, 14 }, 119), 0f, 520f, 920f, 420f);
        _0x891ecf84.Label(_0x04bc4d8a, this._0xa9b02f67, _0x311f06c1[_0xb1e95508], 34f, _0xc5c3f38d.Cream, TextAlignmentOptions.Center);
        if (_0xb1e95508 == 0)
        {
            this._0x074f6f24();
        }

        float[] _0x85ada6be =
        {
            0.42f,
            0.5f,
            0.58f
        };
        for (int _0x30ddc409 = 0; _0x30ddc409 < 3; _0x30ddc409++)
        {
            RectTransform _0xa6d15ade = _0x891ecf84.Node(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[8] { 248, 223, 198, 207, 217, 238, 197, 222 }, 170) + _0x30ddc409.ToString(), new Vector2(_0x85ada6be[_0x30ddc409], 0f), new Vector2(_0x85ada6be[_0x30ddc409], 0f), new Vector2(0f, 150f), new Vector2(18f, 18f));
            _0x891ecf84.Plate(_0xa6d15ade, this._0xad20a59f, _0x30ddc409 == _0xb1e95508 ? _0xc5c3f38d.Gold : _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.3f), 1f);
        }

        RectTransform _0x34965976 = _0x891ecf84.BottomBox(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[9] { 97, 70, 95, 86, 64, 99, 65, 86, 69 }, 51), -230f, 68f, 300f, 108f);
        Button _0x3cb95c8a = _0x891ecf84.Cta(_0x34965976, this._0xa9b02f67, null, this._0xad20a59f, _0xc5c1e78e._0xe0a69b88(new byte[4] { 19, 17, 6, 21 }, 67), 34f, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.6f), _0xc5c3f38d.VelvetDeep, _0xc5c3f38d.Gold);
        _0x3cb95c8a.onClick.AddListener(() => this._0x8e963894(-1));
        RectTransform _0x3fb2b235 = _0x891ecf84.BottomBox(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[9] { 36, 3, 26, 19, 5, 56, 19, 14, 2 }, 118), 230f, 68f, 300f, 108f);
        Button _0xdcc791f7 = _0x891ecf84.Cta(_0x3fb2b235, this._0xa9b02f67, this._0x264b2cfc, this._0xad20a59f, _0xc5c1e78e._0xe0a69b88(new byte[4] { 208, 219, 198, 202 }, 158), 34f, _0xc5c3f38d.Gold, _0xc5c3f38d.Ruby, _0xc5c3f38d.Cream);
        _0xdcc791f7.onClick.AddListener(() => this._0x8e963894(1));
    }

    private void _0xf3a351b2()
    {
        this._0x5bfe9b76._0x8e61fb97();
        this._0x5bfe9b76._0x55475292();
        this._0xc2131c56(SheetProfile);
        this._0x42ffce38(_0xc5c1e78e._0xe0a69b88(new byte[13] { 180, 191, 173, 218, 178, 187, 180, 190, 182, 191, 218, 215, 218 }, 250) + this._0x5bfe9b76._0x39f516fc);
    }

    private RectTransform _0x3a298449;
    public const int SheetMissions = 2;
    private void _0xf1dbc47c()
    {
        this._0x5bfe9b76._0xf94f394d();
        this._0x1f2fe672._0x3ebf3aa2();
        this._0xc2131c56(SheetSettings);
        this._0x42ffce38(_0xc5c1e78e._0xe0a69b88(new byte[41] { 47, 60, 47, 56, 51, 62, 34, 35, 36, 45, 74, 41, 38, 47, 43, 56, 47, 46, 74, 71, 74, 92, 90, 90, 74, 41, 56, 47, 46, 35, 62, 57, 74, 56, 47, 57, 62, 37, 56, 47, 46 }, 106));
    }

    private _0x5e7f3d72 _0x1f2fe672;
    private RectTransform _0x10a59fea(string _0x26a0882d, float _0x19eaaacc, float _0xc36cce5b, float _0xdb76c888, out Image _0x29ae6ddf, Color _0x62ddfec0)
    {
        RectTransform _0xe7302b8f = _0x891ecf84.TopBox(this._0xed0a6a60, _0x26a0882d, 0f, _0x19eaaacc, _0xc36cce5b, _0xdb76c888);
        _0x29ae6ddf = _0x891ecf84.Plate(_0xe7302b8f, this._0xad20a59f, _0x62ddfec0, 1.9f);
        RectTransform _0xb9c6b6c2 = _0x891ecf84.Stretch(_0xe7302b8f, _0x26a0882d + _0xc5c1e78e._0xe0a69b88(new byte[4] { 58, 23, 28, 1 }, 120));
        _0xb9c6b6c2.offsetMin = new Vector2(6f, 6f);
        _0xb9c6b6c2.offsetMax = new Vector2(-6f, -6f);
        _0x891ecf84.Plate(_0xb9c6b6c2, this._0xad20a59f, _0xc5c3f38d.VelvetLit, 2.1f);
        return _0xe7302b8f;
    }

    public const int SheetRules = 6;
    public const int SheetSettings = 7;
    private float _0xb880c2d7;
    public const int SheetLibrary = 0;
    private TextMeshProUGUI _0x980e728c;
    private _0xfc35b876 _0x36766cfc;
    private void _0xeb461ae5(int _0x3cb547e5, float _0x863c5bec, float _0xfc1cce5c, bool _0x4c42bb27)
    {
        RectTransform _0xf14e69dd = _0x891ecf84.Node(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[11] { 78, 104, 101, 101, 108, 123, 112, 93, 96, 101, 108 }, 9) + _0x3cb547e5.ToString(), new Vector2(_0x863c5bec, 1f), new Vector2(_0x863c5bec, 1f), new Vector2(0f, -_0xfc1cce5c), new Vector2(286f, 330f));
        _0x891ecf84.Plate(_0xf14e69dd, this._0xad20a59f, _0x4c42bb27 ? _0xc5c3f38d.Gold : _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.3f), 1.8f);
        RectTransform _0xa5b4398c = _0x891ecf84.Stretch(_0xf14e69dd, _0xc5c1e78e._0xe0a69b88(new byte[11] { 48, 22, 27, 27, 18, 5, 14, 53, 24, 19, 14 }, 119) + _0x3cb547e5.ToString());
        _0xa5b4398c.offsetMin = new Vector2(6f, 6f);
        _0xa5b4398c.offsetMax = new Vector2(-6f, -6f);
        _0x891ecf84.Plate(_0xa5b4398c, this._0xad20a59f, _0x4c42bb27 ? _0xc5c3f38d.VelvetLit : _0xc5c3f38d.VelvetDeep, 2f);
        Sprite _0x720d2a30 = this._0x8b72f75c(_0x3cb547e5);
        RectTransform _0x08b1e447 = _0x891ecf84.TopBox(_0xf14e69dd, _0xc5c1e78e._0xe0a69b88(new byte[10] { 9, 47, 34, 34, 43, 60, 55, 15, 60, 58 }, 78) + _0x3cb547e5.ToString(), 0f, 126f, 190f, 190f);
        if (_0x720d2a30 != null)
        {
            _0x891ecf84.Picture(_0x08b1e447, _0x720d2a30, _0x4c42bb27 ? Color.white : new Color(0.45f, 0.4f, 0.42f, 0.9f));
        }
        else
        {
            _0x891ecf84.Plate(_0x08b1e447, this._0xad20a59f, _0x4c42bb27 ? _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.7f) : _0xc5c3f38d.With(_0xc5c3f38d.Ink, 0.7f), 1.5f);
        }

        RectTransform _0xe56e1900 = _0x891ecf84.BottomBox(_0xf14e69dd, _0xc5c1e78e._0xe0a69b88(new byte[11] { 203, 237, 224, 224, 233, 254, 245, 194, 237, 225, 233 }, 140) + _0x3cb547e5.ToString(), 0f, 78f, 250f, 44f);
        _0x891ecf84.Label(_0xe56e1900, this._0xa9b02f67, _0x4c42bb27 ? _0xd5682da9.NameAt(_0x3cb547e5) : _0xc5c1e78e._0xe0a69b88(new byte[6] { 22, 21, 25, 17, 31, 30 }, 90), 28f, _0x4c42bb27 ? _0xc5c3f38d.Gold : _0xc5c3f38d.CreamDim, TextAlignmentOptions.Center);
        RectTransform _0x8cb1bb35 = _0x891ecf84.BottomBox(_0xf14e69dd, _0xc5c1e78e._0xe0a69b88(new byte[11] { 25, 63, 50, 50, 59, 44, 39, 16, 59, 59, 58 }, 94) + _0x3cb547e5.ToString(), 0f, 28f, 250f, 36f);
        _0x891ecf84.Label(_0x8cb1bb35, this._0xa9b02f67, _0x4c42bb27 ? _0xc5c1e78e._0xe0a69b88(new byte[5] { 222, 215, 205, 214, 220 }, 152) : _0x1bad1984.Credits(_0xd5682da9.MilestoneAt(_0x3cb547e5)) + _0xc5c1e78e._0xe0a69b88(new byte[7] { 41, 91, 70, 92, 71, 77, 90 }, 9), 24f, _0xc5c3f38d.CreamDim, TextAlignmentOptions.Center);
    }

    private void _0x62457792(int _0x0e778370)
    {
        if (_0x0e778370 == 0)
        {
            this._0x5bfe9b76._0x1ac99480 = !this._0x5bfe9b76._0x1ac99480;
            if (this._0x5bfe9b76._0x1ac99480)
            {
                Handheld.Vibrate();
            }
        }
        else if (_0x0e778370 == 1)
        {
            this._0x5bfe9b76._0x54d74316 = !this._0x5bfe9b76._0x54d74316;
        }
        else
        {
            this._0x5bfe9b76._0x73072a1c = !this._0x5bfe9b76._0x73072a1c;
        }

        this._0x5bfe9b76._0x55475292();
        this._0xc2131c56(SheetSettings);
        if (_0x0e778370 == 0)
        {
            this._0x42ffce38(this._0x5bfe9b76._0x1ac99480 ? _0xc5c1e78e._0xe0a69b88(new byte[35] { 35, 60, 55, 39, 52, 33, 60, 58, 59, 85, 58, 59, 85, 88, 85, 33, 61, 52, 33, 85, 34, 52, 38, 85, 52, 85, 33, 48, 38, 33, 85, 55, 32, 47, 47 }, 117) : _0xc5c1e78e._0xe0a69b88(new byte[13] { 112, 111, 100, 116, 103, 114, 111, 105, 104, 6, 105, 96, 96 }, 38));
        }
        else if (_0x0e778370 == 1)
        {
            this._0x42ffce38(this._0x5bfe9b76._0x54d74316 ? _0xc5c1e78e._0xe0a69b88(new byte[14] { 141, 143, 148, 137, 143, 142, 224, 146, 133, 132, 149, 131, 133, 132 }, 192) : _0xc5c1e78e._0xe0a69b88(new byte[11] { 134, 149, 140, 140, 224, 141, 143, 148, 137, 143, 142 }, 192));
        }
        else
        {
            this._0x42ffce38(this._0x5bfe9b76._0x73072a1c ? _0xc5c1e78e._0xe0a69b88(new byte[17] { 131, 143, 142, 148, 146, 143, 140, 147, 224, 141, 137, 146, 146, 143, 146, 133, 132 }, 192) : _0xc5c1e78e._0xe0a69b88(new byte[21] { 57, 53, 52, 46, 40, 53, 54, 41, 90, 53, 52, 90, 46, 50, 63, 90, 40, 51, 61, 50, 46 }, 122));
        }
    }

    public void _0x921c31f4()
    {
        this._0xc34315ec();
        this._0x9ade1df1 = -1;
        if (this._0x2f6b21d9 != null)
        {
            this._0x2f6b21d9.gameObject.SetActive(false);
        }
    }

    private void _0x8e963894(int _0x53d27873)
    {
        this._0x457dca0a = this._0x457dca0a + _0x53d27873;
        if (this._0x457dca0a < 0)
        {
            this._0x457dca0a = 2;
        }

        if (this._0x457dca0a > 2)
        {
            this._0x457dca0a = 0;
        }

        this._0xc2131c56(SheetRules);
    }

    private void _0x7fdf7489(int _0xbbeb9d97, float _0x79881a77, float _0xfbb481fa)
    {
        bool _0x25eac1e2 = this._0x4be4c0ec._0x32697c26(_0xbbeb9d97);
        bool _0x1ac9fc57 = _0xbbeb9d97 == this._0x4be4c0ec._0x8539c4d5() && !this._0x4be4c0ec._0x5d45a0ca();
        RectTransform _0xc690ee37 = _0x891ecf84.Node(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[8] { 229, 203, 196, 214, 246, 203, 206, 199 }, 162) + _0xbbeb9d97.ToString(), new Vector2(_0x79881a77, 1f), new Vector2(_0x79881a77, 1f), new Vector2(0f, -_0xfbb481fa), new Vector2(196f, 196f));
        _0x891ecf84.Plate(_0xc690ee37, this._0xad20a59f, _0x25eac1e2 ? _0xc5c3f38d.Gold : _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.45f), 1.7f);
        RectTransform _0x20a53da3 = _0x891ecf84.Stretch(_0xc690ee37, _0xc5c1e78e._0xe0a69b88(new byte[12] { 188, 146, 157, 143, 175, 146, 151, 158, 185, 148, 159, 130 }, 251) + _0xbbeb9d97.ToString());
        _0x20a53da3.offsetMin = new Vector2(6f, 6f);
        _0x20a53da3.offsetMax = new Vector2(-6f, -6f);
        _0x891ecf84.Plate(_0x20a53da3, this._0xad20a59f, _0x25eac1e2 ? _0xc5c3f38d.VelvetDeep : _0xc5c3f38d.VelvetLit, 1.9f);
        RectTransform _0x5e2eb84f = _0x891ecf84.TopBox(_0xc690ee37, _0xc5c1e78e._0xe0a69b88(new byte[9] { 141, 163, 172, 190, 132, 163, 173, 162, 190 }, 202) + _0xbbeb9d97.ToString(), 0f, 42f, 160f, 44f);
        _0x891ecf84.Label(_0x5e2eb84f, this._0xa9b02f67, _0xc5c1e78e._0xe0a69b88(new byte[6] { 51, 52, 58, 53, 41, 93 }, 125) + (_0xbbeb9d97 + 1).ToString(), 26f, _0xc5c3f38d.CreamDim, TextAlignmentOptions.Center);
        RectTransform _0x6011872c = _0x891ecf84.CentreBox(_0xc690ee37, _0xc5c1e78e._0xe0a69b88(new byte[10] { 150, 184, 183, 165, 144, 188, 190, 164, 191, 165 }, 209) + _0xbbeb9d97.ToString(), 0f, 4f, 170f, 58f);
        _0x891ecf84.Label(_0x6011872c, this._0xa9b02f67, _0x1bad1984.Credits(this._0x4be4c0ec._0xa6aa1935(_0xbbeb9d97)), 40f, _0xc5c3f38d.Gold, TextAlignmentOptions.Center);
        RectTransform _0xfd1c286f = _0x891ecf84.BottomBox(_0xc690ee37, _0xc5c1e78e._0xe0a69b88(new byte[9] { 128, 174, 161, 179, 148, 179, 166, 179, 162 }, 199) + _0xbbeb9d97.ToString(), 0f, 34f, 170f, 40f);
        _0x891ecf84.Label(_0xfd1c286f, this._0xa9b02f67, _0x25eac1e2 ? _0xc5c1e78e._0xe0a69b88(new byte[4] { 161, 170, 171, 160 }, 229) : (_0x1ac9fc57 ? _0xc5c1e78e._0xe0a69b88(new byte[7] { 65, 90, 91, 92, 82, 93, 65 }, 21) : _0xc5c1e78e._0xe0a69b88(new byte[6] { 241, 242, 254, 246, 248, 249 }, 189)), 25f, _0x25eac1e2 ? _0xc5c3f38d.GoldLit : _0xc5c3f38d.CreamDim, TextAlignmentOptions.Center);
        if (_0x1ac9fc57)
        {
            _0xc690ee37.DOScale(1.06f, 1.1f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(_0xc690ee37.gameObject);
        }
    }

    // --- the guest page -------------------------------------------------------
    private void _0xb379543f()
    {
        int _0x9b79807d = _0x8e9129d3.RankFor(this._0x5bfe9b76._0x75a6ad47);
        this._0x331aa624(_0xc5c1e78e._0xe0a69b88(new byte[9] { 133, 147, 137, 142, 252, 140, 157, 155, 153 }, 220), _0xc5c1e78e._0xe0a69b88(new byte[30] { 166, 199, 180, 162, 166, 179, 199, 179, 175, 162, 199, 180, 179, 166, 161, 161, 199, 166, 171, 181, 162, 166, 163, 190, 199, 172, 169, 168, 176, 180 }, 231));
        RectTransform _0x8007e822 = _0x891ecf84.TopBox(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[11] { 182, 148, 137, 128, 143, 138, 131, 180, 143, 136, 129 }, 230), 0f, 300f, 250f, 250f);
        this._0xf37238ea = _0x8007e822;
        _0x891ecf84.Plate(_0x8007e822, this._0xad20a59f, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.92f), 1.3f);
        RectTransform _0x8cd16ed0 = _0x891ecf84.Stretch(_0x8007e822, _0xc5c1e78e._0xe0a69b88(new byte[13] { 156, 190, 163, 170, 165, 160, 169, 141, 186, 173, 184, 173, 190 }, 204));
        _0x8cd16ed0.offsetMin = new Vector2(12f, 12f);
        _0x8cd16ed0.offsetMax = new Vector2(-12f, -12f);
        Color _0x0d6c86a1 = _0xc5c3f38d.Rank(this._0x5bfe9b76._0x4eee2880 % 4);
        if (this._0x12caa0ef != null)
        {
            _0x891ecf84.Picture(_0x8cd16ed0, this._0x12caa0ef, _0x0d6c86a1);
        }
        else
        {
            _0x891ecf84.Plate(_0x8cd16ed0, this._0xad20a59f, _0x0d6c86a1, 1.5f);
        }

        RectTransform _0x43147f9d = _0x891ecf84.TopBox(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[13] { 228, 198, 219, 210, 221, 216, 209, 252, 213, 218, 208, 216, 209 }, 180), 0f, 470f, 880f, 62f);
        _0x891ecf84.Label(_0x43147f9d, this._0xa9b02f67, this._0x5bfe9b76._0x39f516fc, 46f, _0xc5c3f38d.Gold, TextAlignmentOptions.Center);
        RectTransform _0x6a3aaf9c = _0x891ecf84.TopBox(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[11] { 33, 3, 30, 23, 24, 29, 20, 35, 16, 31, 26 }, 113), 0f, 536f, 880f, 48f);
        _0x891ecf84.Label(_0x6a3aaf9c, this._0xa9b02f67, _0x8e9129d3.NameFor(_0x9b79807d) + _0xc5c1e78e._0xe0a69b88(new byte[8] { 98, 111, 98, 16, 3, 12, 9, 98 }, 66) + _0x1bad1984.Pad2(_0x9b79807d), 31f, _0xc5c3f38d.Cream, TextAlignmentOptions.Center);
        RectTransform _0xbda30b26 = _0x891ecf84.TopBox(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[12] { 159, 189, 160, 169, 166, 163, 170, 156, 166, 161, 172, 170 }, 207), 0f, 594f, 880f, 46f);
        _0x891ecf84.Label(_0xbda30b26, this._0xa9b02f67, _0xc5c1e78e._0xe0a69b88(new byte[13] { 105, 97, 105, 102, 97, 118, 4, 119, 109, 106, 103, 97, 4 }, 36) + this._0x5bfe9b76._0xbc48bfb6, 28f, _0xc5c3f38d.CreamDim, TextAlignmentOptions.Center);
        Button _0x612335fc = this._0xad2ba807(_0xc5c1e78e._0xe0a69b88(new byte[11] { 33, 3, 30, 23, 24, 29, 20, 60, 16, 2, 26 }, 113), 320f, 620f, 134f, _0xc5c1e78e._0xe0a69b88(new byte[11] { 44, 39, 46, 33, 40, 42, 79, 34, 46, 60, 36 }, 111), 40f);
        _0x612335fc.onClick.AddListener(() => this._0xca554d0a());
        Button _0xf8e41753 = this._0xc0eec4d8(_0xc5c1e78e._0xe0a69b88(new byte[12] { 186, 152, 133, 140, 131, 134, 143, 184, 143, 153, 143, 158 }, 234), 170f, 520f, 112f, _0xc5c1e78e._0xe0a69b88(new byte[12] { 0, 23, 1, 23, 6, 114, 26, 19, 28, 22, 30, 23 }, 82), 34f);
        _0xf8e41753.onClick.AddListener(() => this._0xf3a351b2());
    }

    private Sprite _0x8b72f75c(int _0x63dc1f3d)
    {
        if (this._0xf04887b1 == null || this._0xf04887b1.Length == 0)
        {
            return null;
        }

        int _0x5d5f67dd = ((_0x63dc1f3d % this._0xf04887b1.Length) + this._0xf04887b1.Length) % this._0xf04887b1.Length;
        return this._0xf04887b1[_0x5d5f67dd];
    }

    private TMP_FontAsset _0xa9b02f67;
    private Sprite _0x6067fd77;
    public int _0xb160193b => this._0x9ade1df1;

    // --- shared furniture -----------------------------------------------------
    private void _0x331aa624(string _0x02af6c9b, string _0xdb2a25f4)
    {
        RectTransform _0xa1659ed5 = _0x891ecf84.TopBox(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[10] { 146, 169, 164, 164, 181, 149, 168, 181, 173, 164 }, 193), 0f, 78f, 880f, 86f);
        TextMeshProUGUI _0x1a707a4c = _0x891ecf84.Label(_0xa1659ed5, this._0xa9b02f67, _0x02af6c9b, 52f, _0xc5c3f38d.Gold, TextAlignmentOptions.Center);
        _0x1a707a4c.characterSpacing = 6f;
        RectTransform _0xa66a0a89 = _0x891ecf84.TopBox(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[8] { 24, 35, 46, 46, 63, 24, 62, 41 }, 75), 0f, 152f, 920f, 48f);
        _0x891ecf84.Label(_0xa66a0a89, this._0xa9b02f67, _0xdb2a25f4, 29f, _0xc5c3f38d.CreamDim, TextAlignmentOptions.Center);
    }

    private RectTransform _0x2f6b21d9;
    public const int SheetGallery = 3;
    public void _0xc2131c56(int _0xdee1b938)
    {
        this._0xc34315ec();
        this._0x9ade1df1 = _0xdee1b938;
        this._0x2f6b21d9.gameObject.SetActive(true);
        this._0x2f6b21d9.SetAsLastSibling();
        this._0xfd60f159 = _0x891ecf84.Node(this._0x3a298449, _0xc5c1e78e._0xe0a69b88(new byte[5] { 202, 241, 252, 252, 237 }, 153), new Vector2(0f, this._0xb880c2d7), new Vector2(1f, this._0x394c2816), Vector2.zero, new Vector2(-180f, 0f));
        this._0xfd60f159.SetAsLastSibling();
        _0x891ecf84.Plate(this._0xfd60f159, this._0xad20a59f, _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.92f), 2.2f);
        RectTransform _0x0f612988 = _0x891ecf84.Stretch(this._0xfd60f159, _0xc5c1e78e._0xe0a69b88(new byte[9] { 229, 222, 211, 211, 194, 244, 217, 210, 207 }, 182));
        _0x0f612988.offsetMin = new Vector2(8f, 8f);
        _0x0f612988.offsetMax = new Vector2(-8f, -8f);
        _0x891ecf84.Plate(_0x0f612988, this._0xad20a59f, _0xc5c3f38d.Velvet, 2.4f);
        Image _0xc0c8d465 = _0x891ecf84.Quad(_0x891ecf84.Stretch(this._0xfd60f159, _0xc5c1e78e._0xe0a69b88(new byte[12] { 242, 201, 196, 196, 213, 226, 192, 213, 194, 201, 196, 211 }, 161)), new Color(1f, 1f, 1f, 0.004f));
        _0xc0c8d465.raycastTarget = true;
        if (_0xc0c8d465.canvasRenderer != null)
        {
            _0xc0c8d465.canvasRenderer.cullTransparentMesh = false;
        }

        this._0xed0a6a60 = _0x891ecf84.Stretch(this._0xfd60f159, _0xc5c1e78e._0xe0a69b88(new byte[12] { 149, 174, 163, 163, 178, 133, 169, 168, 178, 163, 168, 178 }, 198));
        if (_0xdee1b938 == SheetLibrary)
        {
            this._0x692fdf49();
        }
        else if (_0xdee1b938 == SheetDaily)
        {
            this._0x4aa23789();
        }
        else if (_0xdee1b938 == SheetMissions)
        {
            this._0x880d68b6();
        }
        else if (_0xdee1b938 == SheetGallery)
        {
            this._0x33447242();
        }
        else if (_0xdee1b938 == SheetProgress)
        {
            this._0xd1524edd();
        }
        else if (_0xdee1b938 == SheetProfile)
        {
            this._0xb379543f();
        }
        else if (_0xdee1b938 == SheetRules)
        {
            this._0xa58f604b();
        }
        else
        {
            this._0x54cd8f1f();
        }

        this._0xfd60f159.anchoredPosition = new Vector2(0f, -36f);
        this._0xfd60f159.DOAnchorPosY(0f, 0.26f).SetEase(Ease.OutCubic).SetLink(this._0xfd60f159.gameObject);
        CanvasGroup _0x05e19db4 = this._0xfd60f159.gameObject.AddComponent<CanvasGroup>();
        _0x05e19db4.alpha = 0f;
        DOTween.To(() => _0x05e19db4.alpha, _0x671b8410 => _0x05e19db4.alpha = _0x671b8410, 1f, 0.22f).SetLink(this._0xfd60f159.gameObject);
    }

    private RectTransform _0xfd60f159;
    private _0x542b1bfd _0xcad0c737;
    private void _0x074f6f24()
    {
        _0x9aaba7e8 _0x315a20e8 = _0xdfaf60d5.At(this._0x5bfe9b76._0x97795416);
        for (int _0x8e8086bb = 0; _0x8e8086bb < _0xbbd798a9.Symbols; _0x8e8086bb++)
        {
            float _0xbe23696b = 790f + _0x8e8086bb * 58f;
            RectTransform _0x7e2812de = _0x891ecf84.Node(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[7] { 47, 30, 6, 49, 30, 18, 26 }, 127) + _0x8e8086bb.ToString(), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(-160f, -_0xbe23696b), new Vector2(460f, 50f));
            _0x891ecf84.Label(_0x7e2812de, this._0xa9b02f67, _0xdfaf60d5.FaceName(_0x8e8086bb), 30f, _0xc5c3f38d.Cream, TextAlignmentOptions.Left);
            RectTransform _0x719373c7 = _0x891ecf84.Node(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[8] { 164, 149, 141, 162, 149, 152, 129, 145 }, 244) + _0x8e8086bb.ToString(), new Vector2(0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(240f, -_0xbe23696b), new Vector2(240f, 50f));
            _0x891ecf84.Label(_0x719373c7, this._0xa9b02f67, _0x1bad1984.Multiplier(_0x315a20e8._0xa9537078[_0x8e8086bb]), 30f, _0xc5c3f38d.Gold, TextAlignmentOptions.Right);
        }
    }

    private void _0x4f8e0882(int _0x6469f28c, float _0xf62bed44, string _0xcdabc3ad, bool _0xe4613abc)
    {
        Image _0x6c6de225;
        RectTransform _0x9a22ed4f = this._0x10a59fea(_0xc5c1e78e._0xe0a69b88(new byte[6] { 107, 80, 88, 88, 83, 90 }, 63) + _0x6469f28c.ToString(), _0xf62bed44, 920f, 140f, out _0x6c6de225, _0xe4613abc ? _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.9f) : _0xc5c3f38d.With(_0xc5c3f38d.Gold, 0.4f));
        _0x6c6de225.raycastTarget = true;
        RectTransform _0x5dbc770e = _0x891ecf84.LeftBox(_0x9a22ed4f, _0xc5c1e78e._0xe0a69b88(new byte[9] { 168, 147, 155, 155, 144, 153, 191, 157, 140 }, 252) + _0x6469f28c.ToString(), 290f, 0f, 500f, 56f);
        _0x891ecf84.Label(_0x5dbc770e, this._0xa9b02f67, _0xcdabc3ad, 36f, _0xc5c3f38d.Cream, TextAlignmentOptions.Left);
        RectTransform _0x4254503d = _0x891ecf84.RightBox(_0x9a22ed4f, _0xc5c1e78e._0xe0a69b88(new byte[11] { 226, 217, 209, 209, 218, 211, 226, 196, 215, 213, 221 }, 182) + _0x6469f28c.ToString(), 110f, 0f, 160f, 76f);
        _0x891ecf84.Plate(_0x4254503d, this._0xad20a59f, _0xe4613abc ? _0xc5c3f38d.Gold : _0xc5c3f38d.With(_0xc5c3f38d.VelvetDeep, 0.95f), 1.2f);
        RectTransform _0x4ffa2f03 = _0x891ecf84.Node(_0x4254503d, _0xc5c1e78e._0xe0a69b88(new byte[10] { 101, 94, 86, 86, 93, 84, 122, 95, 94, 83 }, 49) + _0x6469f28c.ToString(), new Vector2(_0xe4613abc ? 1f : 0f, 0.5f), new Vector2(_0xe4613abc ? 1f : 0f, 0.5f), new Vector2(_0xe4613abc ? -36f : 36f, 0f), new Vector2(60f, 60f));
        _0x891ecf84.Plate(_0x4ffa2f03, this._0xad20a59f, _0xe4613abc ? _0xc5c3f38d.VelvetDeep : _0xc5c3f38d.CreamDim, 1f);
        _0x4ffa2f03.DOPunchScale(new Vector3(0.1f, 0.1f, 0f), 0.22f, 1, 0.5f).SetLink(_0x4ffa2f03.gameObject);
        RectTransform _0x5dbca1a9 = _0x891ecf84.RightBox(_0x9a22ed4f, _0xc5c1e78e._0xe0a69b88(new byte[11] { 219, 224, 232, 232, 227, 234, 220, 251, 238, 251, 234 }, 143) + _0x6469f28c.ToString(), 272f, 0f, 140f, 48f);
        _0x891ecf84.Label(_0x5dbca1a9, this._0xa9b02f67, _0xe4613abc ? _0xc5c1e78e._0xe0a69b88(new byte[2] { 9, 8 }, 70) : _0xc5c1e78e._0xe0a69b88(new byte[3] { 229, 236, 236 }, 170), 30f, _0xe4613abc ? _0xc5c3f38d.Gold : _0xc5c3f38d.CreamDim, TextAlignmentOptions.Right);
        Button _0xa05f98d8 = _0x891ecf84.Touchable(_0x9a22ed4f, _0x6c6de225);
        _0xa05f98d8.onClick.AddListener(() => this._0x62457792(_0x6469f28c));
    }

    // --- the table list -------------------------------------------------------
    private void _0x692fdf49()
    {
        this._0x331aa624(_0xc5c1e78e._0xe0a69b88(new byte[10] { 117, 105, 100, 1, 117, 96, 99, 109, 100, 114 }, 33), _0xc5c1e78e._0xe0a69b88(new byte[28] { 125, 97, 123, 108, 108, 9, 123, 102, 102, 100, 122, 9, 4, 9, 121, 96, 106, 98, 9, 112, 102, 124, 123, 9, 122, 108, 104, 125 }, 41));
        for (int _0x9bc3b625 = 0; _0x9bc3b625 < _0xdfaf60d5._0xc0c6bbec; _0x9bc3b625++)
        {
            this._0x61e57c8e(_0x9bc3b625);
        }
    }

    private void _0xca554d0a()
    {
        this._0x5bfe9b76._0x4eee2880 = (this._0x5bfe9b76._0x4eee2880 + 1) % 4;
        this._0x5bfe9b76._0x55475292();
        this._0xc2131c56(SheetProfile);
        this._0x42ffce38(_0xc5c1e78e._0xe0a69b88(new byte[12] { 239, 227, 241, 233, 130, 225, 234, 227, 236, 229, 231, 230 }, 162));
        if (this._0xf37238ea != null)
        {
            this._0xf37238ea.DOPunchScale(new Vector3(0.08f, 0.08f, 0f), 0.4f, 1, 0.5f).SetLink(this._0xf37238ea.gameObject);
        }

        this._0x1f2fe672._0x2ecda3c3();
    }

    public const int SheetDaily = 1;
    private Button _0xad2ba807(string _0xf0f3806a, float _0x912dd2f0, float _0xa4c7b1d9, float _0x05db5bfd, string _0x15ab5d04, float _0xec73e7d1)
    {
        RectTransform _0x8ba06358 = _0x891ecf84.BottomBox(this._0xed0a6a60, _0xf0f3806a, 0f, _0x912dd2f0, _0xa4c7b1d9, _0x05db5bfd);
        return _0x891ecf84.Cta(_0x8ba06358, this._0xa9b02f67, this._0x264b2cfc, this._0xad20a59f, _0x15ab5d04, _0xec73e7d1, _0xc5c3f38d.Gold, _0xc5c3f38d.Ruby, _0xc5c3f38d.Cream);
    }

    public const int SheetProfile = 5;
    private RectTransform _0xf37238ea;
    public const int SheetProgress = 4;
    private int _0x457dca0a;
    // --- settings -------------------------------------------------------------
    // No sound row and no volume control: this game has no audio at all, so a switch
    // there would change nothing a player could see or hear (C.20).
    private void _0x54cd8f1f()
    {
        this._0x331aa624(_0xc5c1e78e._0xe0a69b88(new byte[8] { 194, 212, 197, 197, 216, 223, 214, 194 }, 145), _0xc5c1e78e._0xe0a69b88(new byte[27] { 189, 180, 180, 190, 187, 188, 183, 210, 223, 210, 188, 189, 210, 179, 177, 177, 189, 167, 188, 166, 210, 188, 183, 183, 182, 183, 182 }, 242));
        this._0x4f8e0882(0, 250f, _0xc5c1e78e._0xe0a69b88(new byte[9] { 238, 241, 250, 234, 249, 236, 241, 247, 246 }, 184), this._0x5bfe9b76._0x1ac99480);
        this._0x4f8e0882(1, 410f, _0xc5c1e78e._0xe0a69b88(new byte[14] { 34, 53, 52, 37, 51, 53, 52, 80, 61, 63, 36, 57, 63, 62 }, 112), this._0x5bfe9b76._0x54d74316);
        this._0x4f8e0882(2, 570f, _0xc5c1e78e._0xe0a69b88(new byte[11] { 239, 230, 229, 247, 131, 235, 226, 237, 231, 230, 231 }, 163), this._0x5bfe9b76._0x73072a1c);
        RectTransform _0x943062e1 = _0x891ecf84.TopBox(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[12] { 33, 23, 6, 6, 27, 28, 21, 1, 60, 29, 6, 23 }, 114), 0f, 720f, 920f, 104f);
        _0x891ecf84.Label(_0x943062e1, this._0xa9b02f67, _0xc5c1e78e._0xe0a69b88(new byte[57] { 195, 212, 213, 196, 210, 212, 213, 177, 220, 222, 197, 216, 222, 223, 177, 194, 217, 222, 195, 197, 212, 223, 194, 177, 212, 199, 212, 195, 200, 177, 194, 193, 216, 223, 155, 208, 223, 213, 177, 197, 195, 216, 220, 194, 177, 197, 217, 212, 177, 210, 222, 223, 215, 212, 197, 197, 216 }, 145), 28f, _0xc5c3f38d.CreamDim, TextAlignmentOptions.Center);
        Button _0xa5539a18 = this._0xc0eec4d8(_0xc5c1e78e._0xe0a69b88(new byte[13] { 176, 134, 151, 151, 138, 141, 132, 144, 177, 134, 144, 134, 151 }, 227), 220f, 700f, 128f, _0xc5c1e78e._0xe0a69b88(new byte[16] { 197, 210, 196, 210, 195, 183, 210, 193, 210, 197, 206, 195, 223, 222, 217, 208 }, 151), 36f);
        _0xa5539a18.onClick.AddListener(() => this._0x71135ecc());
        RectTransform _0xd7e7d508 = _0x891ecf84.BottomBox(this._0xed0a6a60, _0xc5c1e78e._0xe0a69b88(new byte[14] { 96, 86, 71, 71, 90, 93, 84, 64, 117, 92, 92, 71, 86, 65 }, 51), 0f, 110f, 980f, 48f);
        _0x891ecf84.Label(_0xd7e7d508, this._0xa9b02f67, _0xc5c1e78e._0xe0a69b88(new byte[43] { 26, 19, 19, 25, 28, 27, 16, 117, 120, 117, 27, 26, 117, 20, 22, 22, 26, 0, 27, 1, 117, 27, 16, 16, 17, 16, 17, 117, 120, 117, 27, 26, 117, 7, 16, 20, 25, 117, 24, 26, 27, 16, 12 }, 85), 27f, _0xc5c3f38d.CreamDim, TextAlignmentOptions.Center);
    }
}

internal static class _0xc5c1e78e
{
    internal static string _0xe0a69b88(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}