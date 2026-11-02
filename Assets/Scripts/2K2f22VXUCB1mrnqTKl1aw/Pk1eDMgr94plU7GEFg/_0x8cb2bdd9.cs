using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x0a549333;

public class _0x8cb2bdd9 : MonoBehaviour
{
    private void _0x04a6c331(int _0x07a077ee)
    {
        this._0xb5fa798b(_0x07a077ee);
        this._0x34b21747(_0x07a077ee);
        this.CurrentPanelIndex = _0x07a077ee;
        this.Panels[_0x07a077ee]._0xf1cc35c4();
    }

    public float ScaleDuration = 0.4f;
    private void _0xb5fa798b(int _0xf9b0b9ea)
    {
        this.LastPanelIndexes.Add(_0xf9b0b9ea);
        this.CurrentPanelIndex = _0xf9b0b9ea;
        for (int _0x4c0628da = 0; _0x4c0628da < this.Panels.Count; _0x4c0628da++)
            if (_0x4c0628da != _0xf9b0b9ea && this.Panels[_0x4c0628da] != null)
                this.Panels[_0x4c0628da]._0xb950aabe();
    }

    public List<_0x2f79026e> Panels;
    private void _0x56bd0719(int _0xbf505ea4)
    {
        this.LastPanelIndexes.Add(_0xbf505ea4);
        this.CurrentPanelIndex = _0xbf505ea4;
        for (int _0x04852d35 = 0; _0x04852d35 < this.Panels.Count; _0x04852d35++)
            if (_0x04852d35 != _0xbf505ea4 && this.Panels[_0x04852d35] != null)
                this.Panels[_0x04852d35]._0xb950aabe();
    }

    private _0x2f79026e _0x20cc8730(int _0xc9dd50aa)
    {
        return this.Panels[_0xc9dd50aa];
    }

    private void _0x34b21747(int _0xf7f31ff9)
    {
        if (_0xf7f31ff9 == _0x0fc897b7.SPLASH)
            _0x92b6f7a4.Instance._0x2d5911c9();
        if (_0x685a4663.Instance._0x1174d4e5 == _0xb5c50aa6.SCENE_0)
        {
        }
    }

    public float StaticBlurMaterialInitialValue;
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    public void _0xdb7398e1(int _0xefe521bc)
    {
        this._0xb5fa798b(_0xefe521bc);
        this._0x34b21747(_0xefe521bc);
        this.CurrentPanelIndex = _0xefe521bc;
        this.Panels[_0xefe521bc].Show();
    }

    public static _0x8cb2bdd9 Instance;
    private void SwitchSplash()
    {
        if (_0x4e0bbe1d.Instance.IsTutorialEnabled && !_0x685a4663._0xd4efefcb._0x7cf8f88b)
            this._0xdb7398e1(_0x0fc897b7.TUTORIAL0);
        else
            this._0xdb7398e1(_0x0fc897b7.DEFAULT);
    }

    private void _0xdd6ee835()
    {
        this._0x04a6c331(_0x0fc897b7.SPLASH);
        if (_0x685a4663.Instance._0x1174d4e5 == _0xb5c50aa6.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x92b6f7a4.Instance.DefaultAnimationTime);
        }
    }

    public int CurrentPanelIndex;
    public void _0xfbe5c827(int _0xa636de13)
    {
        if (_0xa636de13 == _0x0fc897b7.SPLASH && _0x685a4663.Instance._0x1174d4e5 != _0xb5c50aa6.SCENE_0)
            _0x92b6f7a4.Instance._0x4740fdad();
        if (_0x685a4663.Instance._0x1174d4e5 != _0xb5c50aa6.SCENE_0)
        {
            if (_0xa636de13 == _0x0fc897b7.SPLASH || _0xa636de13 == _0x0fc897b7.TUTORIAL0)
                _0x685a4663.Instance._0x3e82a295(false);
            else if (_0xa636de13 == _0x0fc897b7.DEFAULT)
                _0x685a4663.Instance._0x3e82a295(true);
        }
    }

    public void _0x1d65bfb0()
    {
        this.LastPanelIndexes.RemoveAll(_0x53c5622e => _0x53c5622e == this.CurrentPanelIndex);
        int _0xadf77184 = this.LastPanelIndexes.Last();
        this._0x34b21747(_0xadf77184);
        this._0x56bd0719(_0xadf77184);
        this.CurrentPanelIndex = _0xadf77184;
        this.Panels[_0xadf77184].Show();
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x8cb2bdd9>();
    }

    public bool IsShowSplashOnStart = true;
    private void Start()
    {
        this._0xdd6ee835();
    }
}