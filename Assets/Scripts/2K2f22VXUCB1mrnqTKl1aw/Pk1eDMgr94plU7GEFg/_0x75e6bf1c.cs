using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x75e6bf1c : MonoBehaviour
{
    private void _0xd8052775()
    {
        this.TimerText.ForEach(_0x553d9488 => _0x553d9488.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0xffbe44bc._0xf63980ed(new byte[6] { 217, 217, 232, 142, 199, 199 }, 180)));
    }

    [HideInInspector]
    public int CurrentGameIndex;
    [HideInInspector]
    public int TimeLeft;
    private int _0xc6d58e0a => this.CustomTargetScore + _0x685a4663._0xd4efefcb._0xad3d97d5 * 10;

    private static _0x75e6bf1c _0xd5836e39;
    private void Awake()
    {
        _0xd5836e39 = this.gameObject.GetComponent<_0x75e6bf1c>();
    }

    [HideInInspector]
    public bool IsGameEnd;
    public List<Button> HomeButtons = new();
    public void _0x2e17f264()
    {
        if (!this.IsGameEnd)
        {
            this._0xf6e5aa9c();
            _0x685a4663.IsAfterLevelComplete = true;
            _0x685a4663.IsAfterLevelFailed = false;
            _0xd25c6be7 _0x26303320 = _0xefee00e5.Instance._0xf142a0bd(_0x0a549333._0x3ccaa3c8.WIN).GetComponent<_0xd25c6be7>();
            if (_0x4e0bbe1d.Instance.IsCheckScoreEnabled)
                _0x26303320.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xc6d58e0a}";
            else
                _0x26303320.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x4e0bbe1d.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x0a549333._0x68a164ec._0xc0c6bbec)
                    _0x0a549333._0x68a164ec._0xc0c6bbec = this.ScoreCurrent;
                _0x26303320.ContentAdditionalText.text = $"{_0x0a549333._0x68a164ec._0xc0c6bbec}";
            }
            else
            {
                _0x26303320.ContentAdditionalText.text = $"{this._0x26e65307}";
                _0x0a549333._0x68a164ec._0xc0c6bbec += this._0x26e65307;
            }

            if (_0x4e0bbe1d.Instance.IsLevelIncrementOnWin)
                ++_0x685a4663._0xd4efefcb._0xad3d97d5;
            _0xefee00e5.Instance._0x13bc7317(_0x0a549333._0x3ccaa3c8.WIN);
        }
    }

    [HideInInspector]
    public int ScoreCurrent;
    private IEnumerator _0x5ef97b05()
    {
        this._0xd8052775();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x685a4663.Instance._0x1174d4e5 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x685a4663.Instance._0x694fb632)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0xd8052775();
            }
        }

        if (!this.IsGameEnd)
            this._0x6a3c9724();
    }

    private void _0xaee7418b()
    {
        if (this.ScoreCurrent >= this._0xc6d58e0a)
            this._0x2e17f264();
        else
            this._0x6a3c9724();
    }

    private int _0x26e65307 => this.ScoreCurrent;

    public void _0x6a3c9724()
    {
        if (_0x4e0bbe1d.Instance.IsOnlyWinGameEndEnabled)
            this._0x2e17f264();
        if (!this.IsGameEnd)
        {
            this._0xf6e5aa9c();
            _0x685a4663.IsAfterLevelComplete = false;
            _0x685a4663.IsAfterLevelFailed = true;
            _0xd25c6be7 _0xa29ae640 = _0xefee00e5.Instance._0xf142a0bd(_0x0a549333._0x3ccaa3c8.LOSE).GetComponent<_0xd25c6be7>();
            if (_0x4e0bbe1d.Instance.IsCheckScoreEnabled)
                _0xa29ae640.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xc6d58e0a}";
            else
                _0xa29ae640.ContentMainText.text = $"{this.ScoreCurrent}";
            _0xa29ae640.ContentAdditionalText.text = $"{0}";
            _0x0a549333._0x68a164ec._0xc0c6bbec += 0;
            _0xefee00e5.Instance._0x13bc7317(_0x0a549333._0x3ccaa3c8.LOSE);
        }
    }

    public int CustomTargetScore = 10;
    private void _0xf6e5aa9c()
    {
        this.IsGameEnd = true;
        _0x685a4663.IsAfterLevelComplete = true;
    }

    private int _0x0171931a => this.CustomTimeInitial + _0x685a4663._0xd4efefcb._0xad3d97d5 * 10;

    public void _0x5baf5ccf(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x1fc0b272();
            this._0x0afa8d37();
        }
    }

    public List<TMP_Text> ScoreText = new();
    public void _0x8864217c()
    {
        _0x685a4663.Instance._0x3e82a295(true);
        _0x685a4663.Instance._0x96703be7(_0x0a549333._0xb5c50aa6.SCENE_0);
    }

    public List<TMP_Text> LevelNumberText = new();
    private void _0x1fc0b272()
    {
        if (_0x4e0bbe1d.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x553d9488 => _0x553d9488.text = $"{this.ScoreCurrent}/{this._0xc6d58e0a}");
        else
            this.ScoreText.ForEach(_0x553d9488 => _0x553d9488.text = $"{this.ScoreCurrent}");
    }

    public int CustomTimeInitial = 30;
    private void _0x0afa8d37()
    {
        if (this.ScoreCurrent > _0x685a4663._0xd4efefcb._0x402a4331)
            _0x685a4663._0xd4efefcb._0x402a4331 = this.ScoreCurrent;
        if (_0x4e0bbe1d.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0xc6d58e0a)
                this._0x2e17f264();
    }

    public List<TMP_Text> SubtitleText = new();
    public List<TMP_Text> TimerText = new();
    public List<Button> PauseButtons = new();
    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x0171931a;
        this.CurrentGameIndex = _0x685a4663.Instance._0x1174d4e5;
        foreach (Button _0xaaf4c16b in this.HomeButtons)
            _0xaaf4c16b.onClick.AddListener(() =>
            {
                this._0x8864217c();
            });
        foreach (Button _0x46649dab in this.PauseButtons)
            _0x46649dab.onClick.AddListener(() =>
            {
                _0x685a4663.Instance._0x3e82a295(false);
                _0xefee00e5.Instance._0x13bc7317(_0x0a549333._0x3ccaa3c8.PAUSE);
            });
        this._0x1fc0b272();
        this.LevelNumberText.ForEach(_0x553d9488 => _0x553d9488.text = $"LVL {_0x685a4663._0xd4efefcb._0xad3d97d5 + 1}");
        if (_0x4e0bbe1d.Instance.IsTimerEnabled)
        {
            this._0xd8052775();
            this.StartCoroutine(this._0x5ef97b05());
        }
    }
}

internal static class _0xffbe44bc
{
    internal static string _0xf63980ed(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}