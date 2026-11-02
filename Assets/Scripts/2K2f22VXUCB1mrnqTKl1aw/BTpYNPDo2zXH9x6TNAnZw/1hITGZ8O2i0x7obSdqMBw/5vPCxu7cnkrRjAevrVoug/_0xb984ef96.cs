using UnityEngine;
using UnityEngine.UI;

public class _0xb984ef96 : MonoBehaviour
{
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x685a4663.Instance._0x3e82a295(this.IsPhysicsRunOnClick));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsPhysicsRunOnClick;
    public Button Button;
}