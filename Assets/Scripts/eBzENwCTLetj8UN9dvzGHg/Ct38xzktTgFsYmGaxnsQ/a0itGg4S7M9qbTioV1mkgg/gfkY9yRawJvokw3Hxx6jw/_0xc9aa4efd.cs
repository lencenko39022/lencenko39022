using UnityEngine;
using UnityEngine.UI;

public class _0xc9aa4efd : MonoBehaviour
{
    public bool IsPhysicsRunOnClick;
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x7aee932b.Instance._0x3042a8ff(this.IsPhysicsRunOnClick));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
}