using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x181df63b : MonoBehaviour
{
    public void _0xa4fabc25()
    {
        this._0xe7630695();
        bool _0x3bcfbc1f = _0x32f9fdf2;
        this._0x2bb0886a = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xc4f9f78d => this.AnimationSlider.value = _0xc4f9f78d, _0x3bcfbc1f ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x32f9fdf2 = !_0x32f9fdf2;
    }

    private void _0x00050afe()
    {
        this.AnimationSlider.value = 0.05f;
        _0x32f9fdf2 = !_0x32f9fdf2;
        this._0x2bb0886a = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xc4f9f78d => this.AnimationSlider.value = _0xc4f9f78d, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x8812b75d._0x1b489dab?._0x60cdd6d9();
        });
    }

    private static bool _0x32f9fdf2 = false;
    public GameObject Background;
    public void _0x74a6de07()
    {
        this._0x2bb0886a?.Pause();
    }

    public GameObject Error;
    private Sequence _0x2bb0886a;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x181df63b>();
    }

    public void _0xe7630695()
    {
        this._0x2bb0886a?.Kill();
        this.AnimationSlider.value = _0x32f9fdf2 ? this.SecondPassSliderValue : 0.05f;
    }

    public GameObject Content;
    public Slider AnimationSlider;
    public void _0x065e3e9a()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x2bb0886a?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x32f9fdf2 = false;
    }

    public float DefaultAnimationTime = 0.4f;
    public void _0x0e21476d()
    {
        this._0x2bb0886a?.Play();
    }

    public float FirstAnimationTime = 10.0f;
    public float SecondPassSliderValue = 0.5f;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xa93ecf08._0x41b99ebc.SCENE_0 && !_0x32f9fdf2)
        {
            this._0x00050afe();
        }
        else
        {
            this._0xa4fabc25();
        }
    }

    public static _0x181df63b Instance;
}