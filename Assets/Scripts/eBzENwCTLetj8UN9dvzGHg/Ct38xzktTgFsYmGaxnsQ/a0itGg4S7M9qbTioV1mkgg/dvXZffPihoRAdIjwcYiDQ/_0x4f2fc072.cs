using TMPro;
using UnityEngine;
using static _0xa93ecf08;

public class _0x4f2fc072 : MonoBehaviour
{
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x130979ed;
            if (this.gameObject.TryGetComponent(out _0x130979ed))
                this.MoneyCountText = _0x130979ed;
        }

        this._0x849f9d44();
    }

    public TMP_Text MoneyCountText;
    public void _0x849f9d44()
    {
        this.MoneyCountText.text = _0xf0cc7cd1._0xc8557463.ToString();
    }
}