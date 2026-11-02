using TMPro;
using UnityEngine;
using static _0x0a549333;

public class _0x86d958cc : MonoBehaviour
{
    public TMP_Text MoneyCountText;
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x82a8aca5;
            if (this.gameObject.TryGetComponent(out _0x82a8aca5))
                this.MoneyCountText = _0x82a8aca5;
        }

        this._0x65adf330();
    }

    public void _0x65adf330()
    {
        this.MoneyCountText.text = _0x68a164ec._0xc0c6bbec.ToString();
    }
}