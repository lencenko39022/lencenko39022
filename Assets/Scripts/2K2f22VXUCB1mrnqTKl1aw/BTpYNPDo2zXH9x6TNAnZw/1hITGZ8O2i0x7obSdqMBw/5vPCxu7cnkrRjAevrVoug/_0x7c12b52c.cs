using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x7c12b52c : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x685a4663.Instance._0x96703be7(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x685a4663.Instance._0x96703be7(this.LoadSceneId));
    }

    public bool IsLoadCurrentScene;
    public int LoadSceneId;
}