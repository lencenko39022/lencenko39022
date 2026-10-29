using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xa93ecf08;

public class _0x7aee932b : MonoBehaviour
{
    public Canvas MainCanvas;
    public bool _0x53ed5416 { get; private set; }
    private static _0xa0ab22b1 _0xd4efefcb => _0xa0ab22b1.ALL_SCENES_SETTING_SINGLETONS[0];

    public static bool IsAfterLevelFailed = false;
    public Button ShowResetTutorialButton;
    private static void ExitGame()
    {
        Application.Quit();
    }

    public int _0x694fb632 => SceneManager.GetActiveScene().buildIndex;

    public void _0x3042a8ff(bool _0x26b3824a)
    {
        this._0x53ed5416 = _0x26b3824a;
        this._0x6209b959(!this._0x53ed5416);
        Physics2D.simulationMode = this._0x53ed5416 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xf1e97355(this.EnvironmentWithTweensToToggle);
    }

    private void Start()
    {
        if (this._0x694fb632 != _0x41b99ebc.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0x62098066(_0x41b99ebc.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x0171931a._0x1174d4e5 = false;
            _0xf12a3ca3.Instance._0xb3f8431f();
            _0x5bc6383a.Instance._0xfb4aa4a2(_0x27eba83c.TUTORIAL0);
        });
    }

    public static _0xa0ab22b1 _0x0171931a => _0xa0ab22b1.ALL_SCENES_SETTING_SINGLETONS[Instance._0x694fb632];

    public static _0x7aee932b Instance;
    private void _0xf1e97355(Transform _0x8a6022a5)
    {
        Transform[] _0x212b8208 = _0x8a6022a5.GetComponentsInChildren<Transform>();
        foreach (Transform _0x584c28e7 in _0x212b8208)
            if (_0x584c28e7 != null && DOTween.IsTweening(_0x584c28e7))
            {
                if (this._0x53ed5416)
                    DOTween.Play(_0x584c28e7);
                else
                    DOTween.Pause(_0x584c28e7);
            }
    }

    public void _0x7939cb32()
    {
        this._0x62098066(SceneManager.GetActiveScene().buildIndex);
    }

    public Button DeleteProgressDataButton;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x7aee932b>();
        this.RootGameObject = GameObject.FindWithTag(_0x3fdd013f._0xb55095ae(new byte[4] { 230, 219, 219, 192 }, 180));
        if (this._0x694fb632 == _0x41b99ebc.SCENE_0)
            this._0x3042a8ff(true);
        else
            this._0x3042a8ff(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x4f2fc072>(true).ToList();
    }

    private void _0x3fcd7686()
    {
        IsAfterLevelComplete = true;
        Instance._0x62098066(_0x41b99ebc.SCENE_0);
    }

    private static void MakeGrid(List<RectTransform> _0xa4014878, AspectRatioFitter _0xd19752c6, float _0x1f6c50a3, int _0xe024ffb8, int _0xacdef0c2)
    {
        _0xd19752c6.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0xd19752c6.aspectRatio = _0x1f6c50a3;
        foreach (RectTransform _0xda56d5ee in _0xa4014878)
        {
            int _0x0ef58cd3 = _0xda56d5ee.transform.GetSiblingIndex();
            _0xda56d5ee.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x0ef58cd3 % _0xe024ffb8) * (1f / _0xe024ffb8), (_0xacdef0c2 - (Mathf.FloorToInt((float)_0x0ef58cd3 / _0xe024ffb8) % _0xacdef0c2 + 1f)) * (1f / _0xacdef0c2));
            _0xda56d5ee.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x0ef58cd3 % _0xe024ffb8 + 1f) * (1f / _0xe024ffb8), (_0xacdef0c2 - Mathf.FloorToInt((float)_0x0ef58cd3 / _0xe024ffb8) % _0xacdef0c2) * (1f / _0xacdef0c2));
            _0xda56d5ee.offsetMin = Vector2.zero;
            _0xda56d5ee.offsetMax = Vector2.zero;
        }
    }

    public void _0x1c89ee29()
    {
        foreach (_0x4f2fc072 _0x5396b5f9 in this.MoneyCountContainers)
            _0x5396b5f9._0x849f9d44();
    }

    public static bool IsAfterLevelComplete;
    private void _0x6209b959(bool _0x4949b96a)
    {
        Rigidbody2D[] _0x60b0a2c7 = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0xafe993c9 in _0x60b0a2c7)
            if (_0x4949b96a)
                _0xafe993c9.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0xafe993c9.constraints = RigidbodyConstraints2D.None;
    }

    [HideInInspector]
    public List<_0x4f2fc072> MoneyCountContainers = new();
    public Transform EnvironmentWithTweensToToggle;
    private static _0xa0ab22b1 GAME_INDEX_SETTINGS(int _0x028555ab)
    {
        return _0xa0ab22b1.ALL_SCENES_SETTING_SINGLETONS[_0x028555ab];
    }

    private IEnumerator _0x64ccf774(string _0x6231ce93)
    {
        _0x5bc6383a.Instance._0xfb4aa4a2(_0x27eba83c.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x318deaca = SceneManager.LoadSceneAsync(_0x6231ce93);
        while (!_0x318deaca.isDone)
            yield return null;
    }

    private IEnumerator _0xef33c76a(int _0x2fced40d)
    {
        _0x5bc6383a.Instance._0xfb4aa4a2(_0x27eba83c.SPLASH);
        AsyncOperation _0x75fdefbc = SceneManager.LoadSceneAsync(_0x2fced40d);
        while (!_0x75fdefbc.isDone)
            yield return null;
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public Transform Environment;
    public void _0x62098066(int _0xb40c676e)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xef33c76a(_0xb40c676e));
    }

    public void _0xf0350f82()
    {
        _0x0171931a._0x1174d4e5 = true;
    }
}

internal static class _0x3fdd013f
{
    internal static string _0xb55095ae(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}