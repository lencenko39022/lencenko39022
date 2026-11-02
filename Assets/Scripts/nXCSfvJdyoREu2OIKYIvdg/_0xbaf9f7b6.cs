using TMPro;
using UnityEngine;

/// <summary>
/// The template ships more panels than this app dresses - tutorials above all - and every
/// one of them carries placeholder copy. This blanks the text of every panel the club
/// does not dress, addressing them by SETTINGS index so renaming cannot break it. The
/// panels stay in place: controllers navigate by index.
/// </summary>
public sealed class _0xbaf9f7b6 : MonoBehaviour
{
    private void Update()
    {
        if (this._0xabf5aab0)
            return;
        this._0x3cbefeb7 += Time.unscaledDeltaTime;
        if (this._0x3cbefeb7 < 0.5f)
            return;
        this._0x3cbefeb7 = 0f;
        this._0x891ecf84();
    }

    private void Start()
    {
        this._0x891ecf84();
    }

    private void _0x891ecf84()
    {
        _0x8cb2bdd9 _0x9e8fda68 = _0x8cb2bdd9.Instance;
        if (_0x9e8fda68 == null || _0x9e8fda68.Panels == null)
            return;
        for (int _0xf8a4cad8 = 0; _0xf8a4cad8 < _0x9e8fda68.Panels.Count; _0xf8a4cad8++)
        {
            if (_0xf8a4cad8 == _0x0a549333._0x0fc897b7.SPLASH || _0xf8a4cad8 == _0x0a549333._0x0fc897b7.DEFAULT)
                continue;
            _0x2f79026e _0x1a0bf359 = _0x9e8fda68.Panels[_0xf8a4cad8];
            if (_0x1a0bf359 == null)
                continue;
            TMP_Text[] _0xda162f2b = _0x1a0bf359.GetComponentsInChildren<TMP_Text>(true);
            for (int _0x3efbc20b = 0; _0x3efbc20b < _0xda162f2b.Length; _0x3efbc20b++)
                if (_0xda162f2b[_0x3efbc20b] != null && !string.IsNullOrEmpty(_0xda162f2b[_0x3efbc20b].text))
                    _0xda162f2b[_0x3efbc20b].text = string.Empty;
        }

        this._0xabf5aab0 = true;
    }

    private float _0x3cbefeb7;
    private bool _0xabf5aab0;
}