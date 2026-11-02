using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x940858d3 : MonoBehaviour
{
    private float _0x471e6ca6 = 0.6f;
    private float _0xd99795a1 = 1.5f;
    private void Update()
    {
        int _0xab9b4321 = 1;
        if (this._0x75a6ad47.Count > 0)
        {
            string _0x24c2b628 = this._0x6a89ca01.text;
            foreach (string _0x82a5c174 in this._0x75a6ad47)
                while (_0x24c2b628.Contains(_0x82a5c174))
                    _0x24c2b628 = _0x24c2b628.Replace(_0x82a5c174, "");
            _0xab9b4321 = _0x24c2b628.Length;
        }
        else
        {
            _0xab9b4321 = this._0x6a89ca01.text.Length;
        }

        float _0x9aaba7e8 = Mathf.Clamp(this._0xa6100c56 + this._0x471e6ca6 * _0xab9b4321, this._0xd99795a1, this._0xa9560cca);
        if (!Mathf.Approximately(this._0xa7c9bee8.aspectRatio, _0x9aaba7e8))
            this._0xa7c9bee8.aspectRatio = _0x9aaba7e8;
    }

    private AspectRatioFitter _0xa7c9bee8;
    private List<string> _0x75a6ad47 = new();
    private float _0xa6100c56;
    private TMP_Text _0x6a89ca01;
    private float _0xa9560cca = 4;
}