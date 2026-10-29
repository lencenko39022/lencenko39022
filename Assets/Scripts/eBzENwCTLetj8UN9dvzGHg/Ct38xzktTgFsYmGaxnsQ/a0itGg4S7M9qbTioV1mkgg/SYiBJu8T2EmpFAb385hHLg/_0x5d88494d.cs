using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x5d88494d : MonoBehaviour
{
    private void _0x5a086410()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x5a086410();
    }

    public TMP_Text ContentAdditionalText;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public static void HideAllPops()
    {
        _0xf12a3ca3.Instance._0xb3f8431f();
    }

    private bool _0xbeb8f57a => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public TMP_Text ContentHeaderText;
    public Ease ease = Ease.OutSine;
    public void _0x8b22c543()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public bool IsOnlyYScale;
    public TMP_Text ContentMainText;
    public GameObject Content;
    public Image ContentImage;
    private void Start()
    {
    // Content.SetActive(false);
    }

    public bool IsScaledDownOnAwake = true;
    public float scaleDuration = 0.4f;
}