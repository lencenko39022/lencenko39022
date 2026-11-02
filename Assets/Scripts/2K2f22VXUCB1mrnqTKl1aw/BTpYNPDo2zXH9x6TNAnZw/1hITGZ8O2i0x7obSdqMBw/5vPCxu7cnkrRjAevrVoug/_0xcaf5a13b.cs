using UnityEngine;
using UnityEngine.UI;

public class _0xcaf5a13b : MonoBehaviour
{
    private void Awake()
    {
        if (this._0xf13538dd == null)
            if (!this.TryGetComponent(out this._0xf13538dd))
                this._0xf13538dd = this.GetComponentInChildren<Button>();
    }

    private int _0x87e38782;
    private void Start()
    {
        if (this._0x4f413877)
            this._0xf13538dd.onClick.AddListener(() => _0x8cb2bdd9.Instance._0x1d65bfb0());
        else
            this._0xf13538dd.onClick.AddListener(() => _0x8cb2bdd9.Instance._0xdb7398e1(this._0x87e38782));
    }

    private Button _0xf13538dd;
    private bool _0x4f413877;
}