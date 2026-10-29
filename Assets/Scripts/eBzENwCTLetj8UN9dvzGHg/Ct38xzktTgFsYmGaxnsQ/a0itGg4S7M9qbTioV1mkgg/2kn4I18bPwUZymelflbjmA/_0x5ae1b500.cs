using UnityEngine;
using UnityEngine.UI;

public class _0x5ae1b500 : MonoBehaviour
{
    public bool IsTutorialEndPanel;
    public Button NextTutorialButton;
    public Button TutorialEndButton;
    public int EndTutorialPanelIndex = 1;
    public int NextTutorialPanelIndex;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x5bc6383a.Instance._0xfb4aa4a2(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x7aee932b.Instance._0xf0350f82());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x5bc6383a.Instance._0xfb4aa4a2(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x5bc6383a.Instance._0xfb4aa4a2(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x7aee932b.Instance._0xf0350f82());
        }
    }
}