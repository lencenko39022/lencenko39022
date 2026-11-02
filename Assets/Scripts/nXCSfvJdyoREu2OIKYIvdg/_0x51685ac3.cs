using TMPro;
using UnityEngine;

/// <summary>
/// The one place that holds every art reference of the club. Both scene directors read
/// it through a serialized reference, so no component ever looks an asset up by name.
/// </summary>
public sealed class _0x51685ac3 : MonoBehaviour
{
    [SerializeField]
    private Sprite _trinket1;
    [SerializeField]
    private Sprite _iconHome;
    public Sprite _0xb6eb4455(int _0x92f67685)
    {
        if (_0x92f67685 == _0x80ffeb86.Spade)
            return this._symSpade;
        if (_0x92f67685 == _0x80ffeb86.Club)
            return this._symClub;
        if (_0x92f67685 == _0x80ffeb86.Heart)
            return this._symHeart;
        if (_0x92f67685 == _0x80ffeb86.Diamond)
            return this._symDiamond;
        if (_0x92f67685 == _0x80ffeb86.Bell)
            return this._symBell;
        if (_0x92f67685 == _0x80ffeb86.Mask)
            return this._symMask;
        if (_0x92f67685 == _0x80ffeb86.Crown)
            return this._symCrown;
        if (_0x92f67685 == _0x80ffeb86.Jester)
            return this._emblem;
        return this._symTicket;
    }

    [SerializeField]
    private Sprite _symBell;
    [SerializeField]
    private Sprite _stageArt2;
    public Sprite _0x7cfac638
    {
        get
        {
            return this._reelFrame;
        }
    }

    [SerializeField]
    private Sprite _stageArt3;
    public Sprite _0x87d5afad
    {
        get
        {
            return this._trinket2;
        }
    }

    public Sprite _0x374268d8
    {
        get
        {
            return this._iconHome;
        }
    }

    [SerializeField]
    private Sprite _symSpade;
    [SerializeField]
    private Sprite _buttonRound;
    [SerializeField]
    private Sprite _buttonRect;
    public TMP_FontAsset _0x50577ddc
    {
        get
        {
            return this._font;
        }
    }

    public Sprite _0x30383bc4
    {
        get
        {
            return this._iconLock;
        }
    }

    [SerializeField]
    private Sprite _iconLock;
    /// <summary>Art of a collection slot: the five stage curios, then the two trinkets, then the casket.</summary>
    public Sprite _0xed029fc3(int _0x91301698)
    {
        if (_0x91301698 == 0)
            return this._stageArt1;
        if (_0x91301698 == 1)
            return this._stageArt2;
        if (_0x91301698 == 2)
            return this._stageArt3;
        if (_0x91301698 == 3)
            return this._stageArt4;
        if (_0x91301698 == 4)
            return this._stageArt5;
        if (_0x91301698 == 5)
            return this._trinket1;
        if (_0x91301698 == 6)
            return this._trinket2;
        return this._giftChest;
    }

    /// <summary>Art used beside a stage row in the library.</summary>
    public Sprite _0xf6fcdc90(int _0x3a4fb5e9)
    {
        if (_0x3a4fb5e9 == 1)
            return this._symCrown;
        if (_0x3a4fb5e9 == 2)
            return this._symMask;
        if (_0x3a4fb5e9 == 3)
            return this._symDiamond;
        return this._symBell;
    }

    [SerializeField]
    private Sprite _iconCheck;
    public Sprite _0xa9537078
    {
        get
        {
            return this._giftChest;
        }
    }

    [SerializeField]
    private Sprite _stageArt4;
    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private Sprite _emblem;
    [SerializeField]
    private Sprite _symClub;
    [SerializeField]
    private Sprite _iconPause;
    [SerializeField]
    private Sprite _symMask;
    public Sprite _0x7f1ca861
    {
        get
        {
            return this._iconPause;
        }
    }

    [SerializeField]
    private Sprite _symHeart;
    [SerializeField]
    private Sprite _logo;
    [SerializeField]
    private Sprite _valance;
    public Sprite _0xf4df0193
    {
        get
        {
            return this._buttonRound != null ? this._buttonRound : this._plate;
        }
    }

    public Sprite _0x81e6d18e
    {
        get
        {
            return this._trinket1;
        }
    }

    /// <summary>
    /// The splash mark. The generated logo may come back with lettering on it, and the
    /// title must never be shown, so the abstract jester emblem is the safe default and
    /// the logo is only used when it was deliberately wired in the scene.
    /// </summary>
    public Sprite _0x2d9ff0d6
    {
        get
        {
            return this._emblem != null ? this._emblem : this._logo;
        }
    }

    [SerializeField]
    private Sprite _reelFrame;
    public Sprite _0xc5d1e44f
    {
        get
        {
            return this._valance;
        }
    }

    /// <summary>Avatar options: the emblem first, then the unlocked curios.</summary>
    public Sprite _0x2b503346(int _0x44cebdde)
    {
        if (_0x44cebdde <= 0)
            return this._0x2d9ff0d6;
        return this._0xed029fc3((_0x44cebdde - 1) % _0x0331a644.TrinketCount);
    }

    [SerializeField]
    private Sprite _symCrown;
    [SerializeField]
    private Sprite _stageArt1;
    public Sprite _0xc24dddd0
    {
        get
        {
            return this._iconCheck;
        }
    }

    [SerializeField]
    private Sprite _giftChest;
    public Sprite _0xcef53720
    {
        get
        {
            return this._buttonRect != null ? this._buttonRect : this._plate;
        }
    }

    public Sprite _0x9bc213f0
    {
        get
        {
            return this._plate;
        }
    }

    [SerializeField]
    private Sprite _symDiamond;
    [SerializeField]
    private Sprite _stageArt5;
    [SerializeField]
    private Sprite _plate;
    [SerializeField]
    private Sprite _trinket2;
    [SerializeField]
    private Sprite _symTicket;
}