using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xa93ecf08;

public class _0xf12a3ca3 : MonoBehaviour
{
    public void _0x82de80b2()
    {
        this.LastPopIndexes.RemoveAll(_0xbecb9bd4 => _0xbecb9bd4 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0xb3f8431f();
        else
            this._0x9e5425e7(this.LastPopIndexes.Last());
    }

    private void _0x70591a8b()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public void _0x9e5425e7(int _0x225ab968)
    {
        this.CurrentPopIndex = _0x225ab968;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x89cd9c89(true);
        this._0xd55a93c9();
        this.Pops[_0x225ab968].Show();
        foreach (GameObject _0x400649ff in this.GameObjectsToHide)
            _0x400649ff.SetActive(false);
    }

    public List<_0x5d88494d> Pops;
    public List<GameObject> GameObjectsToHide;
    private void _0xd55a93c9()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public GameObject BlurBackground;
    public _0x5d88494d _0x3fd61d15(int _0x3ba1daaa)
    {
        return this.Pops[_0x3ba1daaa];
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xf12a3ca3>();
    }

    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x5d88494d _0xffa4ade6 in this.Pops)
            if (_0xffa4ade6 != null)
                _0xffa4ade6.gameObject.SetActive(true);
    }

    public List<int> LastPopIndexes = new();
    public int CurrentPopIndex;
    public static _0xf12a3ca3 Instance;
    public float ScaleDuration = 0.4f;
    public void _0xb3f8431f()
    {
        this.LastPopIndexes.Clear();
        this._0x89cd9c89();
        foreach (GameObject _0xd94ff272 in this.GameObjectsToHide)
            if (_0xd94ff272 != null)
                _0xd94ff272.SetActive(true);
        this._0x70591a8b();
    }

    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    private void _0x89cd9c89(bool _0x178299bb = false)
    {
        for (int _0xab3010f6 = 0; _0xab3010f6 < this.Pops.Count; ++_0xab3010f6)
            if (this.Pops[_0xab3010f6] != null && !(_0xab3010f6 == this.CurrentPopIndex && _0x178299bb))
                this.Pops[_0xab3010f6]._0x8b22c543();
    }
}