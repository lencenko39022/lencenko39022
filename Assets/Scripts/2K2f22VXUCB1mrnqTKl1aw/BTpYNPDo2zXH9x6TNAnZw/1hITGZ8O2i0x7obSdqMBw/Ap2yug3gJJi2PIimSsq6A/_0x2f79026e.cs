using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x2f79026e : MonoBehaviour
{
    public Ease Ease = Ease.OutSine;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x10547ac2();
    }

    public float ScaleDuration = 0.4f;
    private void _0x7e6214b3()
    {
        if (this.OuterBackground != null)
        {
            Image _0xb3e4833d = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xb3e4833d, true);
            _0xb3e4833d.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public TMP_Text MainText;
    public GameObject OuterBackground;
    private void _0x461c6b88()
    {
        if (this.OuterBackground != null)
        {
            Image _0xdd77fbd2 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xdd77fbd2, true);
            _0xdd77fbd2.DOFade(0f, this.ScaleDuration);
        }
    }

    private void _0x10547ac2()
    {
        if (this.OuterBackground != null)
        {
            Image _0x809bc01c = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x809bc01c, true);
            _0x809bc01c.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    private void _0xe80fbe5f()
    {
        if (this.OuterBackground != null)
        {
            Image _0x677b0346 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x677b0346, true);
            _0x677b0346.DOFade(1f, 0f);
        }
    }

    public void _0xf1cc35c4()
    {
        this._0xe80fbe5f();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x8cb2bdd9.Instance._0xfbe5c827(_0x8cb2bdd9.Instance.CurrentPanelIndex);
    }

    public TMP_Text HeaderText;
    public bool IsScaledDownOnAwake = true;
    public void _0xb950aabe()
    {
        this._0x461c6b88();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public GameObject Content;
    private bool _0xabf30821 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public void Show()
    {
        this._0x7e6214b3();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x8cb2bdd9.Instance._0xfbe5c827(_0x8cb2bdd9.Instance.CurrentPanelIndex);
            });
        }
    }
}