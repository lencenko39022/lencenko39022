using UnityEngine;
using UnityEngine.UI;

public class _0xefbd03a9 : MonoBehaviour
{
    private void Awake()
    {
        if (this._0x1713ab3e == null)
            if (!this.TryGetComponent(out this._0x1713ab3e))
                this._0x1713ab3e = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this._0x686bf015)
            this._0x1713ab3e.onClick.AddListener(() => _0x5bc6383a.Instance._0xefbe6a00());
        else
            this._0x1713ab3e.onClick.AddListener(() => _0x5bc6383a.Instance._0xfb4aa4a2(this._0xd132a8ad));
    }

    private int _0xd132a8ad;
    private Button _0x1713ab3e;
    private bool _0x686bf015;
}