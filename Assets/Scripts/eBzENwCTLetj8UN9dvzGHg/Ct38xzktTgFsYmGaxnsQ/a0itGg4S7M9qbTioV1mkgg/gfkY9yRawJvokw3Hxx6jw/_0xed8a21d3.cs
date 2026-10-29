using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xed8a21d3 : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
    public bool IsLoadCurrentScene;
    public int LoadSceneId;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x7aee932b.Instance._0x62098066(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x7aee932b.Instance._0x62098066(this.LoadSceneId));
    }
}