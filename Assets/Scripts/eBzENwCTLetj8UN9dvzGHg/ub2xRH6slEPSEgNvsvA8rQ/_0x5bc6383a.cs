using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xa93ecf08;

public class _0x5bc6383a : MonoBehaviour
{
    private void _0xf5bbf542()
    {
        this._0xf6dce5fc(_0x27eba83c.SPLASH);
        if (_0x7aee932b.Instance._0x694fb632 == _0x41b99ebc.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x181df63b.Instance.DefaultAnimationTime);
        }
    }

    public bool IsShowSplashOnStart = true;
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    public List<_0xd8539b11> Panels;
    public int CurrentPanelIndex;
    private _0xd8539b11 _0x62c06968(int _0xedb10b7f)
    {
        return this.Panels[_0xedb10b7f];
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x5bc6383a>();
    }

    private void _0xf6dce5fc(int _0x837b52fb)
    {
        this._0xd961f1a1(_0x837b52fb);
        this._0xf8ba2ee6(_0x837b52fb);
        this.CurrentPanelIndex = _0x837b52fb;
        this.Panels[_0x837b52fb]._0xfa2687cd();
    }

    private void SwitchSplash()
    {
        if (_0x0e064a10.Instance.IsTutorialEnabled && !_0x7aee932b._0x0171931a._0x1174d4e5)
            this._0xfb4aa4a2(_0x27eba83c.TUTORIAL0);
        else
            this._0xfb4aa4a2(_0x27eba83c.DEFAULT);
    }

    public float ScaleDuration = 0.4f;
    public void _0xfb4aa4a2(int _0x13fd71f3)
    {
        this._0xd961f1a1(_0x13fd71f3);
        this._0xf8ba2ee6(_0x13fd71f3);
        this.CurrentPanelIndex = _0x13fd71f3;
        this.Panels[_0x13fd71f3].Show();
    }

    private void _0xf8ba2ee6(int _0xfc9251c2)
    {
        if (_0xfc9251c2 == _0x27eba83c.SPLASH)
            _0x181df63b.Instance._0xe7630695();
        if (_0x7aee932b.Instance._0x694fb632 == _0x41b99ebc.SCENE_0)
        {
        }
    }

    public static _0x5bc6383a Instance;
    private void _0x9c33d395(int _0xa0efe80a)
    {
        this.LastPanelIndexes.Add(_0xa0efe80a);
        this.CurrentPanelIndex = _0xa0efe80a;
        for (int _0x0d59215a = 0; _0x0d59215a < this.Panels.Count; _0x0d59215a++)
            if (_0x0d59215a != _0xa0efe80a && this.Panels[_0x0d59215a] != null)
                this.Panels[_0x0d59215a]._0x350d5ab7();
    }

    public float StaticBlurMaterialInitialValue;
    private void _0xd961f1a1(int _0xab544d0b)
    {
        this.LastPanelIndexes.Add(_0xab544d0b);
        this.CurrentPanelIndex = _0xab544d0b;
        for (int _0xc16e4e61 = 0; _0xc16e4e61 < this.Panels.Count; _0xc16e4e61++)
            if (_0xc16e4e61 != _0xab544d0b && this.Panels[_0xc16e4e61] != null)
                this.Panels[_0xc16e4e61]._0x350d5ab7();
    }

    private void Start()
    {
        this._0xf5bbf542();
    }

    public void _0xefbe6a00()
    {
        this.LastPanelIndexes.RemoveAll(_0xbecb9bd4 => _0xbecb9bd4 == this.CurrentPanelIndex);
        int _0xbc7784e3 = this.LastPanelIndexes.Last();
        this._0xf8ba2ee6(_0xbc7784e3);
        this._0x9c33d395(_0xbc7784e3);
        this.CurrentPanelIndex = _0xbc7784e3;
        this.Panels[_0xbc7784e3].Show();
    }

    public void _0xc21e7a3b(int _0x0e8596da)
    {
        if (_0x0e8596da == _0x27eba83c.SPLASH && _0x7aee932b.Instance._0x694fb632 != _0x41b99ebc.SCENE_0)
            _0x181df63b.Instance._0xa4fabc25();
        if (_0x7aee932b.Instance._0x694fb632 != _0x41b99ebc.SCENE_0)
        {
            if (_0x0e8596da == _0x27eba83c.SPLASH || _0x0e8596da == _0x27eba83c.TUTORIAL0)
                _0x7aee932b.Instance._0x3042a8ff(false);
            else if (_0x0e8596da == _0x27eba83c.DEFAULT)
                _0x7aee932b.Instance._0x3042a8ff(true);
        }
    }
}