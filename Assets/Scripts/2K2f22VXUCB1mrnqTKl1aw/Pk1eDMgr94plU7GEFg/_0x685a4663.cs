using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x0a549333;

public class _0x685a4663 : MonoBehaviour
{
    public void _0x3e82a295(bool _0xc92c5d60)
    {
        this._0x694fb632 = _0xc92c5d60;
        this._0xb4e9ff31(!this._0x694fb632);
        Physics2D.simulationMode = this._0x694fb632 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x31ec8bda(this.EnvironmentWithTweensToToggle);
    }

    private IEnumerator _0xf4f42c7d(int _0x21f3ac33)
    {
        _0x8cb2bdd9.Instance._0xdb7398e1(_0x0fc897b7.SPLASH);
        AsyncOperation _0x48d74db7 = SceneManager.LoadSceneAsync(_0x21f3ac33);
        while (!_0x48d74db7.isDone)
            yield return null;
    }

    private void Start()
    {
        if (this._0x1174d4e5 != _0xb5c50aa6.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0x96703be7(_0xb5c50aa6.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0xd4efefcb._0x7cf8f88b = false;
            _0xefee00e5.Instance._0x4d93ed74();
            _0x8cb2bdd9.Instance._0xdb7398e1(_0x0fc897b7.TUTORIAL0);
        });
    }

    public static bool IsAfterLevelComplete;
    public Canvas MainCanvas;
    private static void ExitGame()
    {
        Application.Quit();
    }

    public void _0xfe63879b()
    {
        foreach (_0x86d958cc _0xb754f143 in this.MoneyCountContainers)
            _0xb754f143._0x65adf330();
    }

    public void _0x88b71322()
    {
        _0xd4efefcb._0x7cf8f88b = true;
    }

    public Transform Environment;
    private void _0x31ec8bda(Transform _0xb0283057)
    {
        Transform[] _0xd3e7da4e = _0xb0283057.GetComponentsInChildren<Transform>();
        foreach (Transform _0x8974e474 in _0xd3e7da4e)
            if (_0x8974e474 != null && DOTween.IsTweening(_0x8974e474))
            {
                if (this._0x694fb632)
                    DOTween.Play(_0x8974e474);
                else
                    DOTween.Pause(_0x8974e474);
            }
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x685a4663>();
        this.RootGameObject = GameObject.FindWithTag(_0x269ad52d._0x055e6bfb(new byte[4] { 40, 21, 21, 14 }, 122));
        if (this._0x1174d4e5 == _0xb5c50aa6.SCENE_0)
            this._0x3e82a295(true);
        else
            this._0x3e82a295(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x86d958cc>(true).ToList();
    }

    public Transform EnvironmentWithTweensToToggle;
    public static _0x07b7bc24 _0xd4efefcb => _0x07b7bc24.ALL_SCENES_SETTING_SINGLETONS[Instance._0x1174d4e5];

    public Button DeleteProgressDataButton;
    private static void MakeGrid(List<RectTransform> _0x611e97ca, AspectRatioFitter _0x22bb3b41, float _0xc2d70a46, int _0x9e57301b, int _0x699c4a71)
    {
        _0x22bb3b41.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x22bb3b41.aspectRatio = _0xc2d70a46;
        foreach (RectTransform _0xb5a06729 in _0x611e97ca)
        {
            int _0xed16e7e6 = _0xb5a06729.transform.GetSiblingIndex();
            _0xb5a06729.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xed16e7e6 % _0x9e57301b) * (1f / _0x9e57301b), (_0x699c4a71 - (Mathf.FloorToInt((float)_0xed16e7e6 / _0x9e57301b) % _0x699c4a71 + 1f)) * (1f / _0x699c4a71));
            _0xb5a06729.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xed16e7e6 % _0x9e57301b + 1f) * (1f / _0x9e57301b), (_0x699c4a71 - Mathf.FloorToInt((float)_0xed16e7e6 / _0x9e57301b) % _0x699c4a71) * (1f / _0x699c4a71));
            _0xb5a06729.offsetMin = Vector2.zero;
            _0xb5a06729.offsetMax = Vector2.zero;
        }
    }

    private void _0x21354bd7()
    {
        IsAfterLevelComplete = true;
        Instance._0x96703be7(_0xb5c50aa6.SCENE_0);
    }

    private static _0x07b7bc24 _0x53ed5416 => _0x07b7bc24.ALL_SCENES_SETTING_SINGLETONS[0];

    public void _0x96703be7(int _0x7c12663c)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xf4f42c7d(_0x7c12663c));
    }

    public static _0x685a4663 Instance;
    public static bool IsAfterLevelFailed = false;
    private IEnumerator _0xb9abed22(string _0xe8bdb5a5)
    {
        _0x8cb2bdd9.Instance._0xdb7398e1(_0x0fc897b7.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x60bbcd46 = SceneManager.LoadSceneAsync(_0xe8bdb5a5);
        while (!_0x60bbcd46.isDone)
            yield return null;
    }

    public void _0x3868e518()
    {
        this._0x96703be7(SceneManager.GetActiveScene().buildIndex);
    }

    public Button ShowResetTutorialButton;
    private static _0x07b7bc24 GAME_INDEX_SETTINGS(int _0x23cfb5e0)
    {
        return _0x07b7bc24.ALL_SCENES_SETTING_SINGLETONS[_0x23cfb5e0];
    }

    private void _0xb4e9ff31(bool _0x97139ac5)
    {
        Rigidbody2D[] _0xe57ba9c3 = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x6ad8e361 in _0xe57ba9c3)
            if (_0x97139ac5)
                _0x6ad8e361.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x6ad8e361.constraints = RigidbodyConstraints2D.None;
    }

    public bool _0x694fb632 { get; private set; }

    [HideInInspector]
    public List<_0x86d958cc> MoneyCountContainers = new();
    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public int _0x1174d4e5 => SceneManager.GetActiveScene().buildIndex;
}

internal static class _0x269ad52d
{
    internal static string _0x055e6bfb(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}