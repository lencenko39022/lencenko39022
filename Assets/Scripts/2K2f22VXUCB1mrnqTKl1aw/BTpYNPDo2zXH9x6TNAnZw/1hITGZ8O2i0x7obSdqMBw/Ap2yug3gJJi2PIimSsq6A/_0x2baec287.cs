using UnityEngine;
using UnityEngine.UI;

public class _0x2baec287 : MonoBehaviour
{
    public int NextTutorialPanelIndex;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x8cb2bdd9.Instance._0xdb7398e1(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x685a4663.Instance._0x88b71322());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x8cb2bdd9.Instance._0xdb7398e1(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x8cb2bdd9.Instance._0xdb7398e1(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x685a4663.Instance._0x88b71322());
        }
    }

    public bool IsTutorialEndPanel;
    public Button TutorialEndButton;
    public int EndTutorialPanelIndex = 1;
    public Button NextTutorialButton;
}