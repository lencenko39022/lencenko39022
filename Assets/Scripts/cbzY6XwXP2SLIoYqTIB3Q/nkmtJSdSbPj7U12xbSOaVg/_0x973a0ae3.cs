using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x973a0ae3 : MonoBehaviour
{
    private float _0x91a1ea86 = 4;
    private void Update()
    {
        int _0xa978465d = 1;
        if (this._0x5df4ba62.Count > 0)
        {
            string _0x79b726dd = this._0x60496811.text;
            foreach (string _0xd15bc338 in this._0x5df4ba62)
                while (_0x79b726dd.Contains(_0xd15bc338))
                    _0x79b726dd = _0x79b726dd.Replace(_0xd15bc338, "");
            _0xa978465d = _0x79b726dd.Length;
        }
        else
        {
            _0xa978465d = this._0x60496811.text.Length;
        }

        float _0x2f5a0c87 = Mathf.Clamp(this._0xfea8ede8 + this._0x17b78224 * _0xa978465d, this._0x7e31d4e7, this._0x91a1ea86);
        if (!Mathf.Approximately(this._0xb30f39e7.aspectRatio, _0x2f5a0c87))
            this._0xb30f39e7.aspectRatio = _0x2f5a0c87;
    }

    private float _0x7e31d4e7 = 1.5f;
    private AspectRatioFitter _0xb30f39e7;
    private float _0x17b78224 = 0.6f;
    private float _0xfea8ede8;
    private TMP_Text _0x60496811;
    private List<string> _0x5df4ba62 = new();
}