using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The 18+ notice. Shown once before the lobby on a fresh install and reachable again
/// from the rules screen. It is the only screen without a back button: the player
/// acknowledges or leaves.
/// </summary>
public sealed class _0x24e0fb79 : MonoBehaviour, _0xeb461ae5
{
    public RectTransform Root
    {
        get
        {
            return this._0x26e930ad == null ? null : this._0x26e930ad._0x10966145;
        }
    }

    private void _0x8d41f560(_0x529d8e09 _0x6ab95f33)
    {
        _0x0331a644._0x50f91b80 = true;
        PlayerPrefs.Save();
        _0x6ab95f33._0xbda30b26();
    }

    private void _0x33a96c2c(RectTransform _0x9013ec9a, _0x51685ac3 _0x28770e79, float _0x861e3f5f, string _0x802794a4)
    {
        RectTransform _0x9431bf2e = _0x211a051a.Box(_0x9013ec9a, _0x861c89ee._0x295396b5(new byte[3] { 0, 61, 37 }, 82), 0.5f, _0x861e3f5f, 960f, 160f);
        _0x211a051a.Picture(_0x9431bf2e, _0x861c89ee._0x295396b5(new byte[4] { 187, 151, 132, 157 }, 246), _0x28770e79._0xc24dddd0, 92f / 960f, 0.5f, 76f, 76f, _0xdc7245d7.Gold);
        _0x211a051a.Label(_0x9431bf2e, _0x861c89ee._0x295396b5(new byte[4] { 75, 103, 120, 113 }, 8), _0x28770e79._0x50577ddc, _0x802794a4, 32f, _0xdc7245d7.TextPrimary, TextAlignmentOptions.Left, 568f / 960f, 0.5f, 800f, 130f);
    }

    public void Enter()
    {
        if (this._0x26e930ad != null)
            this._0x26e930ad.Enter();
    }

    private _0x25979831 _0x26e930ad;
    public void Tick()
    {
    }

    public _0x24e0fb79 _0xfff27da3(_0x51685ac3 _0xb129b6df, _0x529d8e09 _0xac44fc55)
    {
        this._0x26e930ad = this.gameObject.AddComponent<_0x25979831>()._0x03be6e46(this.transform as RectTransform, _0xb129b6df, string.Empty, false, () => _0xac44fc55._0xbda30b26());
        RectTransform _0x1727a82c = this._0x26e930ad._0x81b31132;
        RectTransform _0x213c0946 = _0x211a051a.Sheet(_0x1727a82c, _0x861c89ee._0x295396b5(new byte[4] { 220, 254, 237, 251 }, 159), 0.5f, 0.60f, 1050f, 1000f, _0xb129b6df._0x9bc213f0, _0xdc7245d7.PanelBase, _0xdc7245d7.Gold, 10f);
        _0x211a051a.Label(_0x213c0946, _0x861c89ee._0x295396b5(new byte[7] { 35, 14, 10, 15, 2, 5, 12 }, 107), _0xb129b6df._0x50577ddc, _0x861c89ee._0x295396b5(new byte[8] { 73, 64, 83, 88, 55, 54, 52, 33 }, 120), 64f, _0xdc7245d7.Gold, TextAlignmentOptions.Center, 0.5f, 0.88f, 940f, 110f);
        _0x211a051a.Rule(_0x213c0946, _0x861c89ee._0x295396b5(new byte[4] { 240, 215, 206, 199 }, 162), _0xb129b6df._0x9bc213f0, 0.5f, 0.80f, 880f, _0xdc7245d7.GoldDark);
        this._0x33a96c2c(_0x213c0946, _0xb129b6df, 0.655f, _0x861c89ee._0x295396b5(new byte[45] { 190, 162, 163, 185, 202, 163, 185, 202, 171, 202, 185, 165, 169, 163, 171, 166, 202, 173, 171, 167, 175, 224, 172, 165, 184, 202, 175, 164, 190, 175, 184, 190, 171, 163, 164, 167, 175, 164, 190, 202, 165, 164, 166, 179, 196 }, 234));
        this._0x33a96c2c(_0x213c0946, _0xb129b6df, 0.475f, _0x861c89ee._0x295396b5(new byte[73] { 140, 157, 138, 139, 134, 155, 156, 239, 142, 157, 138, 239, 153, 134, 157, 155, 154, 142, 131, 225, 239, 155, 135, 138, 150, 239, 140, 142, 129, 129, 128, 155, 239, 141, 138, 197, 141, 128, 154, 136, 135, 155, 227, 239, 156, 128, 131, 139, 227, 239, 152, 134, 155, 135, 139, 157, 142, 152, 129, 239, 128, 157, 239, 138, 151, 140, 135, 142, 129, 136, 138, 139, 225 }, 207));
        this._0x33a96c2c(_0x213c0946, _0xb129b6df, 0.295f, _0x861c89ee._0x295396b5(new byte[51] { 143, 141, 158, 156, 139, 150, 156, 154, 255, 143, 147, 158, 134, 255, 155, 144, 154, 140, 255, 145, 144, 139, 255, 143, 141, 154, 155, 150, 156, 139, 213, 141, 154, 158, 147, 242, 146, 144, 145, 154, 134, 255, 144, 138, 139, 156, 144, 146, 154, 140, 241 }, 223));
        _0x211a051a.Label(_0x213c0946, _0x861c89ee._0x295396b5(new byte[8] { 13, 44, 19, 49, 42, 57, 38, 48 }, 67), _0xb129b6df._0x50577ddc, _0x861c89ee._0x295396b5(new byte[39] { 62, 63, 80, 34, 53, 49, 60, 93, 61, 63, 62, 53, 41, 80, 55, 49, 61, 50, 60, 57, 62, 55, 94, 80, 62, 63, 80, 51, 49, 35, 56, 80, 32, 34, 57, 42, 53, 35, 94 }, 112), 30f, _0xdc7245d7.TextSecondary, TextAlignmentOptions.Center, 0.5f, 0.12f, 960f, 60f);
        Button _0x72628295 = _0x211a051a.Action(_0x1727a82c, _0x861c89ee._0x295396b5(new byte[6] { 187, 153, 153, 159, 138, 142 }, 250), _0xb129b6df._0x50577ddc, _0xb129b6df._0xcef53720, _0x861c89ee._0x295396b5(new byte[16] { 152, 241, 144, 156, 241, 224, 233, 241, 158, 131, 241, 158, 157, 149, 148, 131 }, 209), 44f, _0xdc7245d7.Scarlet, _0xdc7245d7.Gold, _0xdc7245d7.Parchment, 0.5f, 0.22f, 760f, 168f);
        _0x72628295.onClick.AddListener(() => this._0x8d41f560(_0xac44fc55));
        Button _0xf7fc0c3e = _0x211a051a.Action(_0x1727a82c, _0x861c89ee._0x295396b5(new byte[5] { 249, 208, 212, 195, 208 }, 181), _0xb129b6df._0x50577ddc, _0xb129b6df._0xcef53720, _0x861c89ee._0x295396b5(new byte[4] { 199, 218, 203, 214 }, 130), 38f, _0xdc7245d7.PanelBottom, _0xdc7245d7.GoldDark, _0xdc7245d7.TextSecondary, 0.5f, 0.115f, 460f, 118f);
        _0xf7fc0c3e.onClick.AddListener(() => Application.Quit());
        return this;
    }
}

internal static class _0x861c89ee
{
    internal static string _0x295396b5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}