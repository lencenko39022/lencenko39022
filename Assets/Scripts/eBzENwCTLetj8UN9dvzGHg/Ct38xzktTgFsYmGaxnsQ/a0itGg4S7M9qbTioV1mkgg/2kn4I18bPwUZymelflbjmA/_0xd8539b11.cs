using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xd8539b11 : MonoBehaviour
{
    private void _0x1367ebcf()
    {
        if (this.OuterBackground != null)
        {
            Image _0x5ed15a00 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x5ed15a00, true);
            _0x5ed15a00.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    private void _0x2c80171c()
    {
        if (this.OuterBackground != null)
        {
            Image _0x60866a53 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x60866a53, true);
            _0x60866a53.DOFade(0f, this.ScaleDuration);
        }
    }

    private void _0x58bd4e2f()
    {
        if (this.OuterBackground != null)
        {
            Image _0xb80b3838 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xb80b3838, true);
            _0xb80b3838.DOFade(1f, 0f);
        }
    }

    public float ScaleDuration = 0.4f;
    private void _0xa05d4a66()
    {
        if (this.OuterBackground != null)
        {
            Image _0x4082b988 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x4082b988, true);
            _0x4082b988.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public TMP_Text MainText;
    public GameObject Content;
    public GameObject OuterBackground;
    public Ease Ease = Ease.OutSine;
    public void _0xfa2687cd()
    {
        this._0x58bd4e2f();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x5bc6383a.Instance._0xc21e7a3b(_0x5bc6383a.Instance.CurrentPanelIndex);
    }

    private bool _0x62949b3b => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public void _0x350d5ab7()
    {
        this._0x2c80171c();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public void Show()
    {
        this._0x1367ebcf();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x5bc6383a.Instance._0xc21e7a3b(_0x5bc6383a.Instance.CurrentPanelIndex);
            });
        }
    }

    public TMP_Text HeaderText;
    public bool IsScaledDownOnAwake = true;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xa05d4a66();
    }
}