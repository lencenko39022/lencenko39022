using DG.Tweening;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Dresses the three template popups - win 7, lose 8, pause 6 - in the club's own words
/// and colours. Every template caption inside them is blanked, the close cross gets a
/// real icon instead of the default blank plate, and the action buttons are told apart
/// by their template GROUP rather than by traversal order or by name.
/// </summary>
public sealed class _0xe0317038 : MonoBehaviour
{
    private _0x525b96d0 _0x08b95c59(_0xd25c6be7 _0x4d79aeb7)
    {
        if (_0x4d79aeb7 == null || _0x4d79aeb7.Content == null)
            return null;
        RectTransform _0x03b940c6 = _0x4d79aeb7.Content.transform as RectTransform;
        if (_0x03b940c6 == null)
            return null;
        _0x525b96d0 _0x993d1c2e = new _0x525b96d0();
        _0x993d1c2e.Pop = _0x4d79aeb7;
        Button[] _0xa4a8f4c2 = _0x03b940c6.GetComponentsInChildren<Button>(true);
        for (int _0x75148ffd = 0; _0x75148ffd < _0xa4a8f4c2.Length; _0x75148ffd++)
        {
            Button _0x6c7991fa = _0xa4a8f4c2[_0x75148ffd];
            if (_0x6c7991fa == null)
                continue;
            int _0x6d953112 = this._0x3d1fd2d3(_0x6c7991fa.transform, _0x03b940c6);
            RectTransform _0x648fee16 = this._0x0facb0c8(_0x6c7991fa.transform, _0x03b940c6);
            if (_0x6d953112 >= 3)
            {
                _0x993d1c2e.Close = _0x6c7991fa;
                continue;
            }

            if (_0x648fee16 == null)
                continue;
            float _0x02b89284 = (_0x648fee16.anchorMin.x + _0x648fee16.anchorMax.x) * 0.5f;
            if (_0x02b89284 < 0.5f)
                _0x993d1c2e.Left = _0x6c7991fa;
            else
                _0x993d1c2e.Right = _0x6c7991fa;
        }

        if (_0x993d1c2e.Left != null)
            _0x993d1c2e.LeftLabel = _0x993d1c2e.Left.GetComponentInChildren<TextMeshProUGUI>(true);
        if (_0x993d1c2e.Right != null)
            _0x993d1c2e.RightLabel = _0x993d1c2e.Right.GetComponentInChildren<TextMeshProUGUI>(true);
        this._0x448b981d(_0x03b940c6, _0x993d1c2e);
        this._0xc8c72d33(_0x03b940c6, _0x993d1c2e);
        this._0x866b7812(_0x993d1c2e);
        this._0x8b851161(_0x993d1c2e.Left, () => this._0xe4e45b0e(_0x993d1c2e));
        this._0x8b851161(_0x993d1c2e.Right, () => this._0x67b56ded(_0x993d1c2e));
        return _0x993d1c2e;
    }

    [SerializeField]
    private _0xd25c6be7 _pausePop;
    private _0x525b96d0 _0x2eef5d44;
    public void _0x58abd2ca(string _0x601ecaf3, string _0x1a940aee, string _0x7cc2ce9d, string _0x6b43b1d6, System.Action _0x394c7027, string _0x54a00da5, System.Action _0x56ec0482)
    {
        this.Show(_0x0a549333._0x3ccaa3c8.PAUSE, this._0x4512cb41, _0x601ecaf3, _0x1a940aee, _0x7cc2ce9d, _0x6b43b1d6, _0x394c7027, _0x54a00da5, _0x56ec0482);
    }

    private _0x525b96d0 _0x5699e7c2;
    [SerializeField]
    private _0xd25c6be7 _losePop;
    [SerializeField]
    private _0x51685ac3 _theme;
    [SerializeField]
    private _0xd25c6be7 _winPop;
    /// <summary>One dressed popup and the three buttons it really has.</summary>
    private sealed class _0x525b96d0
    {
        public _0xd25c6be7 Pop;
        public Button Close;
        public Button Left;
        public Button Right;
        public TextMeshProUGUI LeftLabel;
        public TextMeshProUGUI RightLabel;
        public TextMeshProUGUI Header;
        public TextMeshProUGUI Body;
        public TextMeshProUGUI Extra;
        public System.Action LeftAction;
        public System.Action RightAction;
    }

    public void _0x3386dec3()
    {
        _0xefee00e5.Instance._0x4d93ed74();
    }

    private bool _0xeadf5c0e;
    private int _0x3d1fd2d3(Transform _0xdabb4180, RectTransform _0xe88d0ab3)
    {
        int _0x4b30f1ad = 0;
        Transform _0x0fbdacde = _0xdabb4180;
        while (_0x0fbdacde != null && _0x0fbdacde != _0xe88d0ab3 && _0x4b30f1ad < 12)
        {
            _0x4b30f1ad++;
            _0x0fbdacde = _0x0fbdacde.parent;
        }

        return _0x4b30f1ad;
    }

    private void _0x77fe84d1(Button _0x3c821ea5, TextMeshProUGUI _0x751a1999, string _0xd90becd5)
    {
        if (_0x3c821ea5 == null)
            return;
        bool _0xe0eaaba3 = !string.IsNullOrEmpty(_0xd90becd5);
        _0x3c821ea5.gameObject.SetActive(_0xe0eaaba3);
        if (_0x751a1999 == null)
            return;
        _0x751a1999.text = _0xe0eaaba3 ? _0xd90becd5 : string.Empty;
        _0x751a1999.color = _0xdc7245d7.Parchment;
        _0xf9bbd821.ApplyFlow(_0x751a1999, 36f);
        _0xf9bbd821.ApplyOutline(_0x751a1999);
    }

    [SerializeField]
    private Sprite _closeIcon;
    private void _0x8b851161(Button _0x8142c50f, System.Action _0xe1c9e37a)
    {
        if (_0x8142c50f == null)
            return;
        _0x8142c50f.onClick.RemoveAllListeners();
        _0x8142c50f.onClick.AddListener(() => _0xe1c9e37a());
    }

    private void Start()
    {
        this.StartCoroutine(this._0x28ad2a09());
    }

    private _0x92ec325d _0x85732262;
    /// <summary>
    /// Waits one frame so every template driver has subscribed, then replaces those
    /// subscriptions with the club's own. Doing it in Start would race them.
    /// </summary>
    private IEnumerator _0x28ad2a09()
    {
        yield return null;
        if (this._theme == null)
            yield break;
        this._0x5699e7c2 = this._0x08b95c59(this._winPop);
        this._0x2eef5d44 = this._0x08b95c59(this._losePop);
        this._0x4512cb41 = this._0x08b95c59(this._pausePop);
        if (this._0x5699e7c2 != null && this._0x5699e7c2.Pop != null && this._0x5699e7c2.Pop.Content != null)
            this._0x85732262 = this.gameObject.AddComponent<_0x92ec325d>()._0xb3465c94(this._0x5699e7c2.Pop.Content.transform as RectTransform, this._theme);
        this._0xeadf5c0e = true;
    }

    public void _0x0f98293d(string _0x8e432b36, string _0x016a8517, string _0x4a3d0015, string _0x216a3f5f, System.Action _0x35301b32, string _0xf5902d34, System.Action _0x8be10f81)
    {
        this.Show(_0x0a549333._0x3ccaa3c8.LOSE, this._0x2eef5d44, _0x8e432b36, _0x016a8517, _0x4a3d0015, _0x216a3f5f, _0x35301b32, _0xf5902d34, _0x8be10f81);
    }

    private RectTransform _0x0facb0c8(Transform _0x444a34e3, RectTransform _0xe74e97e7)
    {
        Transform _0x974df30b = _0x444a34e3;
        while (_0x974df30b != null && _0x974df30b.parent != null && _0x974df30b.parent != (Transform)_0xe74e97e7)
            _0x974df30b = _0x974df30b.parent;
        return _0x974df30b == null ? null : _0x974df30b as RectTransform;
    }

    public void _0x93aebe7c(string _0x4a87a404, string _0x1309e4d6, string _0xe43512f9, string _0xf36cd9ca, System.Action _0xafcde860, string _0xa89e03ed, System.Action _0xfea13c4b, bool _0x48208df2)
    {
        this.Show(_0x0a549333._0x3ccaa3c8.WIN, this._0x5699e7c2, _0x4a87a404, _0x1309e4d6, _0xe43512f9, _0xf36cd9ca, _0xafcde860, _0xa89e03ed, _0xfea13c4b);
        if (_0x48208df2 && this._0x85732262 != null)
            this._0x85732262._0x3bd2bfe7(0.5f, 0.55f);
    }

    private void _0x67b56ded(_0x525b96d0 _0xe727db66)
    {
        System.Action _0xb1217621 = _0xe727db66.RightAction;
        if (_0xb1217621 != null)
            _0xb1217621();
    }

    private void _0x866b7812(_0x525b96d0 _0xbeb65529)
    {
        if (_0xbeb65529.Close == null)
            return;
        RectTransform _0xa510c73c = _0xbeb65529.Close.transform as RectTransform;
        if (_0xa510c73c != null)
        {
            Image _0x8cefc8d0 = _0x211a051a.Picture(_0xa510c73c, _0xfb4aa4a2._0x13fd71f3(new byte[9] { 28, 51, 48, 44, 58, 22, 60, 48, 49 }, 95), this._closeIcon, 0.5f, 0.5f, 56f, 56f, _0xdc7245d7.Gold);
            _0x8cefc8d0.rectTransform.SetAsLastSibling();
        }

        _0xbeb65529.Close.onClick.RemoveAllListeners();
        _0xbeb65529.Close.onClick.AddListener(() => this._0x3386dec3());
    }

    private void _0xc8c72d33(RectTransform _0x0f965e2b, _0x525b96d0 _0xb50c45aa)
    {
        _0xb50c45aa.Header = _0x211a051a.Label(_0x0f965e2b, _0xfb4aa4a2._0x13fd71f3(new byte[9] { 153, 166, 185, 129, 172, 168, 173, 172, 187 }, 201), this._theme._0x50577ddc, "", 56f, _0xdc7245d7.Gold, TextAlignmentOptions.Center, 0.5f, 0.635f, 900f, 110f);
        _0xb50c45aa.Body = _0x211a051a.Label(_0x0f965e2b, _0xfb4aa4a2._0x13fd71f3(new byte[7] { 30, 33, 62, 12, 33, 42, 55 }, 78), this._theme._0x50577ddc, "", 40f, _0xdc7245d7.Parchment, TextAlignmentOptions.Center, 0.5f, 0.520f, 900f, 140f);
        _0xb50c45aa.Extra = _0x211a051a.Label(_0x0f965e2b, _0xfb4aa4a2._0x13fd71f3(new byte[8] { 115, 76, 83, 102, 91, 87, 81, 66 }, 35), this._theme._0x50577ddc, "", 30f, _0xdc7245d7.GoldLight, TextAlignmentOptions.Center, 0.5f, 0.438f, 900f, 90f);
    }

    public bool _0x4507b1bc
    {
        get
        {
            return this._0xeadf5c0e;
        }
    }

    /// <summary>
    /// Clears every caption the template brought with it. The button labels and the club's
    /// own block are built afterwards, so nothing that still shows is template copy.
    /// </summary>
    private void _0x448b981d(RectTransform _0x94646a46, _0x525b96d0 _0xc2bc2ae2)
    {
        TMP_Text[] _0xbecd573a = _0x94646a46.GetComponentsInChildren<TMP_Text>(true);
        for (int _0xe3f86c4d = 0; _0xe3f86c4d < _0xbecd573a.Length; _0xe3f86c4d++)
        {
            TMP_Text _0xf0edb3b9 = _0xbecd573a[_0xe3f86c4d];
            if (_0xf0edb3b9 == null)
                continue;
            if (_0xf0edb3b9 == _0xc2bc2ae2.LeftLabel || _0xf0edb3b9 == _0xc2bc2ae2.RightLabel)
                continue;
            _0xf0edb3b9.text = string.Empty;
        }
    }

    private void _0xe4e45b0e(_0x525b96d0 _0x94837622)
    {
        System.Action _0x8914eaac = _0x94837622.LeftAction;
        if (_0x8914eaac != null)
            _0x8914eaac();
    }

    private void Show(int _0x1c0a0619, _0x525b96d0 _0x6ca1fb01, string _0x3d62e282, string _0xa87ddbf8, string _0xbc459119, string _0xca4ee3f4, System.Action _0x053b80d8, string _0xd8a19c54, System.Action _0x7c0e042c)
    {
        if (_0x6ca1fb01 == null)
            return;
        _0x6ca1fb01.Header.text = _0x3d62e282;
        _0x6ca1fb01.Body.text = _0xa87ddbf8;
        _0x6ca1fb01.Extra.text = _0xbc459119;
        _0xf9bbd821.ApplyOutline(_0x6ca1fb01.Header);
        _0xf9bbd821.ApplyOutline(_0x6ca1fb01.Body);
        _0xf9bbd821.ApplyOutline(_0x6ca1fb01.Extra);
        _0x6ca1fb01.LeftAction = _0x053b80d8;
        _0x6ca1fb01.RightAction = _0x7c0e042c;
        this._0x77fe84d1(_0x6ca1fb01.Left, _0x6ca1fb01.LeftLabel, _0xca4ee3f4);
        this._0x77fe84d1(_0x6ca1fb01.Right, _0x6ca1fb01.RightLabel, _0xd8a19c54);
        _0xefee00e5.Instance._0x13bc7317(_0x1c0a0619);
    }

    private _0x525b96d0 _0x4512cb41;
}

internal static class _0xfb4aa4a2
{
    internal static string _0x13fd71f3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}