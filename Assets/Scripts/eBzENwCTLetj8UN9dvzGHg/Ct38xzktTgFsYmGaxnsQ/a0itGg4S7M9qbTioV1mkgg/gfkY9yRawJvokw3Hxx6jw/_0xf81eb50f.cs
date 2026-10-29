using UnityEngine;
using UnityEngine.UI;

public class _0xf81eb50f : MonoBehaviour
{
    public int PopToShowIndex;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsShowLastPop;
    public bool IsHideAllPops;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xf12a3ca3.Instance._0x82de80b2();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xf12a3ca3.Instance._0xb3f8431f());
        else
            this.Button.onClick.AddListener(() => _0xf12a3ca3.Instance._0x9e5425e7(this.PopToShowIndex));
    }

    public Button Button;
}