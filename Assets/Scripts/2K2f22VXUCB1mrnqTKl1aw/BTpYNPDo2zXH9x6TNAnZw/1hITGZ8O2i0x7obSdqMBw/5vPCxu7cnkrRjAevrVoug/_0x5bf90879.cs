using UnityEngine;
using UnityEngine.UI;

public class _0x5bf90879 : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsHideAllPops;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xefee00e5.Instance._0x71726381();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xefee00e5.Instance._0x4d93ed74());
        else
            this.Button.onClick.AddListener(() => _0xefee00e5.Instance._0x13bc7317(this.PopToShowIndex));
    }

    public Button Button;
    public bool IsShowLastPop;
    public int PopToShowIndex;
}