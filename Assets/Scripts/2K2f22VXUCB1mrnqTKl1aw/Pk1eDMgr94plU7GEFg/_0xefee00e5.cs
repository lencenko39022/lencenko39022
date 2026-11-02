using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x0a549333;

public class _0xefee00e5 : MonoBehaviour
{
    public float ScaleDuration = 0.4f;
    private void _0xa1ff68bc()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public int CurrentPopIndex;
    public _0xd25c6be7 _0xf142a0bd(int _0xacb3741b)
    {
        return this.Pops[_0xacb3741b];
    }

    public static _0xefee00e5 Instance;
    public List<_0xd25c6be7> Pops;
    public List<GameObject> GameObjectsToHide;
    public void _0x71726381()
    {
        this.LastPopIndexes.RemoveAll(_0x53c5622e => _0x53c5622e == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x4d93ed74();
        else
            this._0x13bc7317(this.LastPopIndexes.Last());
    }

    private void _0xf50cbc39(bool _0x71a7c2fa = false)
    {
        for (int _0x75c9e808 = 0; _0x75c9e808 < this.Pops.Count; ++_0x75c9e808)
            if (this.Pops[_0x75c9e808] != null && !(_0x75c9e808 == this.CurrentPopIndex && _0x71a7c2fa))
                this.Pops[_0x75c9e808]._0xc2463d4d();
    }

    public GameObject BlurBackground;
    private void _0xa3dec531()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public void _0x4d93ed74()
    {
        this.LastPopIndexes.Clear();
        this._0xf50cbc39();
        foreach (GameObject _0xbe24d83c in this.GameObjectsToHide)
            if (_0xbe24d83c != null)
                _0xbe24d83c.SetActive(true);
        this._0xa1ff68bc();
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xefee00e5>();
    }

    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0xd25c6be7 _0x5f6a1987 in this.Pops)
            if (_0x5f6a1987 != null)
                _0x5f6a1987.gameObject.SetActive(true);
    }

    public void _0x13bc7317(int _0x63453652)
    {
        this.CurrentPopIndex = _0x63453652;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0xf50cbc39(true);
        this._0xa3dec531();
        this.Pops[_0x63453652].Show();
        foreach (GameObject _0x5a55d923 in this.GameObjectsToHide)
            _0x5a55d923.SetActive(false);
    }

    public List<int> LastPopIndexes = new();
}