using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x36de0c29 : MonoBehaviour
{
    private int _0x26e65307 => this.CustomTargetScore + _0x7aee932b._0x0171931a._0x402a4331 * 10;

    private void _0xb5b87c42()
    {
        if (this.ScoreCurrent > _0x7aee932b._0x0171931a._0x7cf8f88b)
            _0x7aee932b._0x0171931a._0x7cf8f88b = this.ScoreCurrent;
        if (_0x0e064a10.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x26e65307)
                this._0xb26b9db6();
    }

    private void _0x6fb18ade()
    {
        this.IsGameEnd = true;
        _0x7aee932b.IsAfterLevelComplete = true;
    }

    public void _0xd7f47f2d()
    {
        _0x7aee932b.Instance._0x3042a8ff(true);
        _0x7aee932b.Instance._0x62098066(_0xa93ecf08._0x41b99ebc.SCENE_0);
    }

    public int CustomTimeInitial = 30;
    private static _0x36de0c29 _0xbc5c5f0d;
    public int CustomTargetScore = 10;
    private void _0x18b0a518()
    {
        if (this.ScoreCurrent >= this._0x26e65307)
            this._0xb26b9db6();
        else
            this._0x70b8b0c8();
    }

    public void _0xb26b9db6()
    {
        if (!this.IsGameEnd)
        {
            this._0x6fb18ade();
            _0x7aee932b.IsAfterLevelComplete = true;
            _0x7aee932b.IsAfterLevelFailed = false;
            _0x5d88494d _0x0f6960fb = _0xf12a3ca3.Instance._0x3fd61d15(_0xa93ecf08._0x308a9b74.WIN).GetComponent<_0x5d88494d>();
            if (_0x0e064a10.Instance.IsCheckScoreEnabled)
                _0x0f6960fb.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x26e65307}";
            else
                _0x0f6960fb.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x0e064a10.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xa93ecf08._0xf0cc7cd1._0xc8557463)
                    _0xa93ecf08._0xf0cc7cd1._0xc8557463 = this.ScoreCurrent;
                _0x0f6960fb.ContentAdditionalText.text = $"{_0xa93ecf08._0xf0cc7cd1._0xc8557463}";
            }
            else
            {
                _0x0f6960fb.ContentAdditionalText.text = $"{this._0xabf30821}";
                _0xa93ecf08._0xf0cc7cd1._0xc8557463 += this._0xabf30821;
            }

            if (_0x0e064a10.Instance.IsLevelIncrementOnWin)
                ++_0x7aee932b._0x0171931a._0x402a4331;
            _0xf12a3ca3.Instance._0x9e5425e7(_0xa93ecf08._0x308a9b74.WIN);
        }
    }

    public List<TMP_Text> SubtitleText = new();
    [HideInInspector]
    public int CurrentGameIndex;
    public void _0x70b8b0c8()
    {
        if (_0x0e064a10.Instance.IsOnlyWinGameEndEnabled)
            this._0xb26b9db6();
        if (!this.IsGameEnd)
        {
            this._0x6fb18ade();
            _0x7aee932b.IsAfterLevelComplete = false;
            _0x7aee932b.IsAfterLevelFailed = true;
            _0x5d88494d _0x0e34191d = _0xf12a3ca3.Instance._0x3fd61d15(_0xa93ecf08._0x308a9b74.LOSE).GetComponent<_0x5d88494d>();
            if (_0x0e064a10.Instance.IsCheckScoreEnabled)
                _0x0e34191d.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x26e65307}";
            else
                _0x0e34191d.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x0e34191d.ContentAdditionalText.text = $"{0}";
            _0xa93ecf08._0xf0cc7cd1._0xc8557463 += 0;
            _0xf12a3ca3.Instance._0x9e5425e7(_0xa93ecf08._0x308a9b74.LOSE);
        }
    }

    private void Awake()
    {
        _0xbc5c5f0d = this.gameObject.GetComponent<_0x36de0c29>();
    }

    private void _0x260c8591()
    {
        this.TimerText.ForEach(_0xeddc9f97 => _0xeddc9f97.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x751e7f5b._0xd3b1b1a2(new byte[6] { 226, 226, 211, 181, 252, 252 }, 143)));
    }

    [HideInInspector]
    public bool IsGameEnd;
    private int _0xc6d58e0a => this.CustomTimeInitial + _0x7aee932b._0x0171931a._0x402a4331 * 10;
    private int _0xabf30821 => this.ScoreCurrent;

    private IEnumerator _0x8442c9cc()
    {
        this._0x260c8591();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x7aee932b.Instance._0x694fb632 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x7aee932b.Instance._0x53ed5416)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x260c8591();
            }
        }

        if (!this.IsGameEnd)
            this._0x70b8b0c8();
    }

    public List<Button> PauseButtons = new();
    public void _0x15ab8f99(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x6d14f38f();
            this._0xb5b87c42();
        }
    }

    [HideInInspector]
    public int ScoreCurrent;
    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0xc6d58e0a;
        this.CurrentGameIndex = _0x7aee932b.Instance._0x694fb632;
        foreach (Button _0xfb62e90a in this.HomeButtons)
            _0xfb62e90a.onClick.AddListener(() =>
            {
                this._0xd7f47f2d();
            });
        foreach (Button _0xee745df2 in this.PauseButtons)
            _0xee745df2.onClick.AddListener(() =>
            {
                _0x7aee932b.Instance._0x3042a8ff(false);
                _0xf12a3ca3.Instance._0x9e5425e7(_0xa93ecf08._0x308a9b74.PAUSE);
            });
        this._0x6d14f38f();
        this.LevelNumberText.ForEach(_0xeddc9f97 => _0xeddc9f97.text = $"LVL {_0x7aee932b._0x0171931a._0x402a4331 + 1}");
        if (_0x0e064a10.Instance.IsTimerEnabled)
        {
            this._0x260c8591();
            this.StartCoroutine(this._0x8442c9cc());
        }
    }

    public List<TMP_Text> LevelNumberText = new();
    public List<TMP_Text> ScoreText = new();
    public List<Button> HomeButtons = new();
    private void _0x6d14f38f()
    {
        if (_0x0e064a10.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0xeddc9f97 => _0xeddc9f97.text = $"{this.ScoreCurrent}/{this._0x26e65307}");
        else
            this.ScoreText.ForEach(_0xeddc9f97 => _0xeddc9f97.text = $"{this.ScoreCurrent}");
    }

    public List<TMP_Text> TimerText = new();
    [HideInInspector]
    public int TimeLeft;
}

internal static class _0x751e7f5b
{
    internal static string _0xd3b1b1a2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}