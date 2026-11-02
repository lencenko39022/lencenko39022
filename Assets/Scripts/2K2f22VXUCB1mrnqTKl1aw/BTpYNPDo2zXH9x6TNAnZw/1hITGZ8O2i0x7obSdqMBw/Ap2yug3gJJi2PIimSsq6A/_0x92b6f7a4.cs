using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x92b6f7a4 : MonoBehaviour
{
    public void _0xea0d5b75()
    {
        this._0x7bd549df?.Play();
    }

    public void _0x17598b2f()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x7bd549df?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x37b3917c = false;
    }

    public static _0x92b6f7a4 Instance;
    public Slider AnimationSlider;
    public float SecondPassSliderValue = 0.5f;
    public float DefaultAnimationTime = 0.4f;
    public void _0x0bb2fea0()
    {
        this._0x7bd549df?.Pause();
    }

    private Sequence _0x7bd549df;
    public GameObject Content;
    public void _0x2d5911c9()
    {
        this._0x7bd549df?.Kill();
        this.AnimationSlider.value = _0x37b3917c ? this.SecondPassSliderValue : 0.05f;
    }

    private void _0x8591dbff()
    {
        this.AnimationSlider.value = 0.05f;
        _0x37b3917c = !_0x37b3917c;
        this._0x7bd549df = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x99eb3fd3 => this.AnimationSlider.value = _0x99eb3fd3, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0xf1747815._0xdcb87af9?._0x17c7604e();
        });
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x0a549333._0xb5c50aa6.SCENE_0 && !_0x37b3917c)
        {
            this._0x8591dbff();
        }
        else
        {
            this._0x4740fdad();
        }
    }

    private static bool _0x37b3917c = false;
    public void _0x4740fdad()
    {
        this._0x2d5911c9();
        bool _0xbf88ce09 = _0x37b3917c;
        this._0x7bd549df = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x99eb3fd3 => this.AnimationSlider.value = _0x99eb3fd3, _0xbf88ce09 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x37b3917c = !_0x37b3917c;
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x92b6f7a4>();
    }

    public GameObject Background;
    public GameObject Error;
    public float FirstAnimationTime = 10.0f;
}