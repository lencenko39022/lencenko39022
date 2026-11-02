using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0xf1747815 : MonoBehaviour
{
    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x79138406();
    }

    private bool _0xfe4242cb()
    {
        var _0xdc9ce508 = Keyboard.current;
        return _0xdc9ce508 != null && _0xdc9ce508.escapeKey.wasPressedThisFrame;
    }

    private bool _0xfe47ebae = false;
    private async Task _0x8812b75d()
    {
        if (await _0x2fdc5358())
            return;
        if (await _0x5c40e26e())
            return;
        if (await _0x0fe20b84())
            return;
        _0x1d145ba2();
        await _0x90e35b41(_0xa6286879());
        _0x1592ab9e = await _0xa673824c();
        await _0x48e449f1();
    }

    private string _0x0946b908 = "";
    private void MarkMainFrameCommitted(string _0x55f01080)
    {
        _0xa1a9b829 = true;
        string _0xce0c757a = GetUrlHost(_0x55f01080);
        if (!string.IsNullOrEmpty(_0xce0c757a))
            _0x3b3b801b = _0xce0c757a;
    }

    private Text _0x213a94bd;
    private void _0x05feedcd(UniWebView _0xd0f76dda)
    {
        if (_0x89707758)
            return;
        _0x89707758 = true;
        _0xd0f76dda.AddUrlScheme(_0x0b933aab._0x641ee83b(new byte[2] { 21, 6 }, 97));
        _0xd0f76dda.AddUrlScheme(_0x0b933aab._0x641ee83b(new byte[6] { 9, 14, 20, 5, 14, 20 }, 96));
        _0xd0f76dda.AddUrlScheme(_0x0b933aab._0x641ee83b(new byte[6] { 194, 206, 221, 196, 202, 219 }, 175));
        _0xd0f76dda.OnMessageReceived += (_0x7c045ee4, _0x330992b7) =>
        {
            if (TryOpenExternalLikeChrome(_0x330992b7.RawMessage))
            {
                _0x53f9925b(false);
                return;
            }
        };
        _0xd0f76dda.RegisterShouldHandleRequest(_0x260c906a =>
        {
            string _0x39258f2e = _0x260c906a != null ? _0x260c906a.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x39258f2e))
                return true;
            WLog(_0x0b933aab._0x641ee83b(new byte[21] { 189, 134, 129, 155, 130, 138, 166, 143, 128, 138, 130, 139, 188, 139, 159, 155, 139, 157, 154, 212, 206 }, 238) + _0x39258f2e);
            if (TryOpenExternalLikeChrome(_0x39258f2e))
            {
                _0x53f9925b(false);
                return false;
            }

            if (_0x260c906a != null && _0x260c906a.IsMainFrame && IsGoogleAuthFlowUrl(_0x39258f2e) && !_0xa01073fb)
            {
                WLog(_0x0b933aab._0x641ee83b(new byte[62] { 27, 55, 63, 56, 118, 1, 51, 52, 0, 63, 51, 33, 118, 50, 51, 34, 51, 53, 34, 51, 50, 118, 17, 57, 57, 49, 58, 51, 118, 55, 35, 34, 62, 118, 3, 4, 26, 118, 123, 104, 118, 36, 51, 58, 57, 55, 50, 118, 33, 63, 34, 62, 118, 17, 57, 57, 49, 58, 51, 118, 3, 23 }, 86));
                _0xa01073fb = true;
                _0x53f9925b(true);
                _0x7cbbb2be.SetUserAgent(_0x6739183c());
                _0x7cbbb2be.Load(_0x39258f2e);
                return false;
            }

            return true;
        });
        _0xd0f76dda.OnLoadingErrorReceived += (_0x7c045ee4, _0xf7f91a0c, _0x330992b7, _0x15348cf6) =>
        {
            WLog(_0x0b933aab._0x641ee83b(new byte[25] { 90, 118, 126, 121, 55, 64, 114, 117, 65, 126, 114, 96, 55, 82, 101, 101, 120, 101, 45, 55, 116, 120, 115, 114, 42 }, 23) + _0xf7f91a0c + _0x0b933aab._0x641ee83b(new byte[9] { 82, 31, 23, 1, 1, 19, 21, 23, 79 }, 114) + _0x330992b7);
            string _0xf1fa8ba0 = GetFailingUrl(_0x15348cf6);
            if (string.IsNullOrEmpty(_0xf1fa8ba0) || IsAboutBlank(_0xf1fa8ba0))
                return;
            if (IsSslError(_0xf7f91a0c, _0x330992b7) && _0xfd703373(_0xf1fa8ba0))
            {
                WLog(_0x0b933aab._0x641ee83b(new byte[52] { 33, 15, 6, 7, 26, 13, 72, 59, 59, 36, 72, 13, 26, 26, 7, 26, 72, 7, 29, 28, 27, 1, 12, 13, 72, 28, 0, 13, 72, 5, 9, 1, 6, 72, 12, 7, 11, 29, 5, 13, 6, 28, 82, 72, 14, 9, 1, 4, 1, 6, 15, 85 }, 104) + _0xf1fa8ba0 + _0x0b933aab._0x641ee83b(new byte[6] { 212, 153, 149, 157, 154, 201 }, 244) + _0x3b3b801b + _0x0b933aab._0x641ee83b(new byte[11] { 41, 106, 102, 100, 100, 96, 125, 125, 108, 109, 52 }, 9) + _0xa1a9b829);
                return;
            }

            _ = _0xca66993f(_0x0b933aab._0x641ee83b(new byte[8] { 143, 142, 167, 157, 138, 138, 151, 138 }, 248));
            WLog(_0x0b933aab._0x641ee83b(new byte[45] { 22, 58, 50, 53, 123, 12, 62, 57, 13, 50, 62, 44, 123, 61, 58, 50, 55, 50, 53, 60, 123, 14, 9, 23, 123, 118, 101, 123, 52, 43, 62, 53, 123, 62, 35, 47, 62, 41, 53, 58, 55, 55, 34, 97, 123 }, 91) + _0xf1fa8ba0);
            StopCurrentFailedLoad(_0x7c045ee4);
            _0xdafdf9d0(_0xf1fa8ba0);
        };
        _0xd0f76dda.OnPageStarted += (_0x7c045ee4, _0x0fa5426e) =>
        {
            _0xabe681b7 = 0;
            if (_0xfce77979 && IsAboutBlank(_0x0fa5426e))
            {
                WLog(_0x0b933aab._0x641ee83b(new byte[27] { 100, 70, 81, 67, 85, 70, 89, 20, 85, 86, 91, 65, 64, 14, 86, 88, 85, 90, 95, 20, 71, 64, 85, 70, 64, 81, 80 }, 52));
                return;
            }

            _0xa1a9b829 = false;
            string _0xac4bcb01 = GetUrlHost(_0x0fa5426e);
            if (!string.IsNullOrEmpty(_0xac4bcb01))
                _0x3b3b801b = _0xac4bcb01;
            WLog(_0x0b933aab._0x641ee83b(new byte[29] { 194, 238, 230, 225, 175, 216, 234, 237, 217, 230, 234, 248, 175, 192, 225, 223, 238, 232, 234, 220, 251, 238, 253, 251, 234, 235, 181, 175, 164 }, 143) + (Time.realtimeSinceStartup - _0x695c6876).ToString(_0x0b933aab._0x641ee83b(new byte[5] { 216, 198, 216, 216, 216 }, 232)) + _0x0b933aab._0x641ee83b(new byte[2] { 43, 120 }, 88) + _0x0fa5426e);
            if (TryOpenExternalLikeChrome(_0x0fa5426e))
            {
                StopCurrentFailedLoad(_0x7c045ee4);
                return;
            }

            if (ContainsIgnoreCase(_0x0fa5426e, _0x0b933aab._0x641ee83b(new byte[8] { 97, 108, 108, 100, 43, 100, 117, 117 }, 5)) || ContainsIgnoreCase(_0x0fa5426e, _0x0b933aab._0x641ee83b(new byte[15] { 14, 31, 7, 80, 9, 23, 26, 25, 27, 10, 80, 28, 18, 17, 25 }, 126)) || _0x0fa5426e.StartsWith(_0x0b933aab._0x641ee83b(new byte[25] { 62, 34, 34, 38, 37, 108, 121, 121, 52, 38, 49, 58, 57, 52, 55, 58, 48, 55, 32, 120, 58, 63, 32, 51, 121 }, 86), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x7c045ee4);
                OpenUrlExternally(_0x0fa5426e);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x0fa5426e))
            {
                _0x53f9925b(true);
                WLog(_0x0b933aab._0x641ee83b(new byte[41] { 222, 246, 246, 254, 245, 252, 185, 248, 236, 237, 241, 185, 255, 245, 246, 238, 185, 253, 252, 237, 252, 250, 237, 252, 253, 185, 180, 167, 185, 242, 252, 252, 233, 185, 239, 240, 234, 240, 251, 245, 252 }, 153));
                return;
            }

            _0x67b5ec91 = true;
            _0x53f9925b(true);
            WLog(_0x0b933aab._0x641ee83b(new byte[43] { 112, 66, 69, 113, 78, 66, 80, 7, 75, 72, 70, 67, 78, 73, 64, 8, 85, 66, 67, 78, 85, 66, 68, 83, 78, 73, 64, 7, 10, 25, 7, 76, 66, 66, 87, 7, 81, 78, 84, 78, 69, 75, 66 }, 39));
        };
        _0xd0f76dda.OnPageCommitted += (_0x7c045ee4, _0x0fa5426e) =>
        {
            if (_0xfce77979 && IsAboutBlank(_0x0fa5426e))
                return;
            MarkMainFrameCommitted(_0x0fa5426e);
            WLog(_0x0b933aab._0x641ee83b(new byte[31] { 138, 166, 174, 169, 231, 144, 162, 165, 145, 174, 162, 176, 231, 136, 169, 151, 166, 160, 162, 132, 168, 170, 170, 174, 179, 179, 162, 163, 253, 231, 236 }, 199) + (Time.realtimeSinceStartup - _0x695c6876).ToString(_0x0b933aab._0x641ee83b(new byte[5] { 21, 11, 21, 21, 21 }, 37)) + _0x0b933aab._0x641ee83b(new byte[2] { 243, 160 }, 128) + _0x0fa5426e);
            if (!firstLoadShown && IsHttpUrl(_0x0fa5426e))
            {
                firstLoadShown = true;
                _0x67b5ec91 = false;
                _0x53f9925b(false);
                _0xbfe4c6e4();
                _0xbdf5cc5d();
                _0x7c045ee4.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xca66993f(_0x0b933aab._0x641ee83b(new byte[9] { 238, 239, 198, 246, 233, 252, 247, 252, 253 }, 153));
                WLog(_0x0b933aab._0x641ee83b(new byte[39] { 190, 146, 154, 157, 211, 164, 150, 145, 165, 154, 150, 132, 211, 128, 155, 156, 132, 157, 211, 156, 157, 211, 144, 156, 158, 158, 154, 135, 135, 150, 151, 211, 144, 156, 157, 135, 150, 157, 135 }, 243));
            }
        };
        _0xd0f76dda.OnPageProgressChanged += (_0x7c045ee4, _0xfe5d7bc0) =>
        {
            if (_0xfce77979)
                return;
            if (!firstLoadShown && _0xfe5d7bc0 >= 0.65f)
            {
                firstLoadShown = true;
                _0x67b5ec91 = false;
                _0x53f9925b(false);
                _0xbfe4c6e4();
                _0xbdf5cc5d();
                _0x7c045ee4.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xca66993f(_0x0b933aab._0x641ee83b(new byte[9] { 69, 68, 109, 93, 66, 87, 92, 87, 86 }, 50));
                WLog(_0x0b933aab._0x641ee83b(new byte[32] { 156, 176, 184, 191, 241, 134, 180, 179, 135, 184, 180, 166, 241, 162, 185, 190, 166, 191, 241, 179, 168, 241, 161, 163, 190, 182, 163, 180, 162, 162, 235, 241 }, 209) + _0xfe5d7bc0);
            }
        };
        _0xd0f76dda.OnPageFinished += (_0x7c045ee4, _0xf7f91a0c, _0x0fa5426e) =>
        {
            if (_0xfce77979 && IsAboutBlank(_0x0fa5426e))
            {
                _0xfce77979 = false;
                WLog(_0x0b933aab._0x641ee83b(new byte[28] { 165, 135, 144, 130, 148, 135, 152, 213, 148, 151, 154, 128, 129, 207, 151, 153, 148, 155, 158, 213, 147, 156, 155, 156, 134, 157, 144, 145 }, 245));
                return;
            }

            WLog(_0x0b933aab._0x641ee83b(new byte[24] { 150, 186, 178, 181, 251, 140, 190, 185, 141, 178, 190, 172, 251, 157, 178, 181, 178, 168, 179, 190, 191, 225, 251, 240 }, 219) + (Time.realtimeSinceStartup - _0x695c6876).ToString(_0x0b933aab._0x641ee83b(new byte[5] { 60, 34, 60, 60, 60 }, 12)) + _0x0b933aab._0x641ee83b(new byte[7] { 136, 219, 152, 148, 159, 158, 198 }, 251) + _0xf7f91a0c + _0x0b933aab._0x641ee83b(new byte[5] { 9, 92, 91, 69, 20 }, 41) + _0x0fa5426e);
            if (_0xf7f91a0c >= 200 && _0xf7f91a0c < 400)
                MarkMainFrameCommitted(_0x0fa5426e);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x67b5ec91 = false;
                _0x53f9925b(false);
                _0xbfe4c6e4();
                _0xbdf5cc5d();
                _0x7c045ee4.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xca66993f(_0x0b933aab._0x641ee83b(new byte[9] { 105, 104, 65, 113, 110, 123, 112, 123, 122 }, 30));
                WLog(_0x0b933aab._0x641ee83b(new byte[33] { 39, 11, 3, 4, 74, 61, 15, 8, 60, 3, 15, 29, 74, 12, 3, 24, 25, 30, 74, 6, 5, 11, 14, 74, 9, 5, 7, 26, 6, 15, 30, 15, 14 }, 106));
            }
            else if (_0x67b5ec91)
            {
                _0x67b5ec91 = false;
                _0x53f9925b(false);
                _0x7c045ee4.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x0b933aab._0x641ee83b(new byte[40] { 40, 4, 12, 11, 69, 50, 0, 7, 51, 12, 0, 18, 69, 54, 13, 10, 18, 69, 4, 3, 17, 0, 23, 69, 9, 10, 4, 1, 12, 11, 2, 69, 3, 12, 11, 12, 22, 13, 0, 1 }, 101));
            }
            else
            {
                _0x53f9925b(false);
            }

            if (_0xa01073fb && !IsGoogleAuthFlowUrl(_0x0fa5426e) && !IsGoogleAuthFlowUrl(_0x0fa5426e))
            {
                WLog(_0x0b933aab._0x641ee83b(new byte[48] { 59, 19, 19, 27, 16, 25, 92, 29, 9, 8, 20, 92, 15, 25, 25, 17, 15, 92, 26, 21, 18, 21, 15, 20, 25, 24, 92, 81, 66, 92, 14, 25, 15, 8, 19, 14, 25, 92, 24, 25, 26, 29, 9, 16, 8, 92, 41, 61 }, 124));
                _0xa01073fb = false;
                _0x7cbbb2be.SetUserAgent("");
            }
        };
        _0xd0f76dda.OnShouldClose += _0x7c045ee4 =>
        {
            WLog(_0x0b933aab._0x641ee83b(new byte[41] { 157, 146, 163, 181, 178, 155, 230, 139, 167, 175, 168, 230, 145, 163, 164, 144, 175, 163, 177, 230, 137, 168, 149, 174, 169, 179, 170, 162, 133, 170, 169, 181, 163, 230, 175, 168, 176, 169, 173, 163, 162 }, 198));
            _0xa1ce9ce5();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0xd0f76dda.SetPopupPageEventEnabled(true);
        bool _0x4601a2fe = false;
        bool _0x682ba529 = false;
        _0xd0f76dda.OnMultipleWindowOpened += (_0x7c045ee4, _0x80352e4e) =>
        {
            _0x7c045ee4.ScrollTo(0, 0, false);
            WLog(_0x0b933aab._0x641ee83b(new byte[43] { 61, 50, 3, 21, 18, 59, 70, 43, 7, 15, 8, 70, 49, 3, 4, 48, 15, 3, 17, 70, 43, 19, 10, 18, 15, 22, 10, 3, 49, 15, 8, 2, 9, 17, 70, 41, 22, 3, 8, 3, 2, 92, 70 }, 102) + _0x80352e4e);
            var _0xa854063d = _0xd0f76dda.GetPopupWindow(_0x80352e4e);
            if (_0xa854063d == null)
                return;
            _0xee857f7f.Add(_0xa854063d);
            Debug.Log($"[Test] Popup ID: {_0xa854063d.Id}");
            _0xa854063d.OnPageStarted += (_0xe3b8bfc2, _0x0fa5426e) =>
            {
                WLog(_0x0b933aab._0x641ee83b(new byte[36] { 20, 27, 42, 60, 59, 18, 111, 31, 32, 63, 58, 63, 111, 24, 42, 45, 25, 38, 42, 56, 111, 0, 33, 31, 46, 40, 42, 28, 59, 46, 61, 59, 42, 43, 117, 111 }, 79) + _0x0fa5426e);
                _0xabe681b7 = 0;
                if (string.IsNullOrEmpty(_0x0fa5426e) || IsAboutBlank(_0x0fa5426e))
                    return;
                if (IsGoogleAuthFlowUrl(_0x0fa5426e))
                {
                    WLog(_0x0b933aab._0x641ee83b(new byte[57] { 247, 248, 201, 223, 216, 241, 140, 252, 195, 220, 217, 220, 140, 235, 195, 195, 203, 192, 201, 140, 205, 217, 216, 196, 140, 202, 192, 195, 219, 140, 129, 146, 140, 223, 220, 195, 195, 202, 140, 235, 195, 195, 203, 192, 201, 140, 239, 196, 222, 195, 193, 201, 140, 249, 237, 150, 140 }, 172) + _0x0fa5426e);
                    _0x4601a2fe = false;
                    _0xdcc5fd08();
                    if (_0xe3b8bfc2 != null && _0xe3b8bfc2.IsAlive)
                        _0xe3b8bfc2.EvaluateJavaScript(_0xba4aa5bc());
                    return;
                }

                if (_0x7cbbb2be == null)
                    return;
                if (!_0x4601a2fe)
                {
                    _0x4601a2fe = true;
                    _0x7cbbb2be.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x0b933aab._0x641ee83b(new byte[39] { 211, 220, 237, 251, 252, 213, 168, 216, 231, 248, 253, 248, 168, 233, 248, 248, 228, 241, 168, 223, 225, 230, 236, 231, 255, 251, 168, 236, 237, 251, 227, 252, 231, 248, 168, 221, 201, 178, 168 }, 136) + _0x0fa5426e);
                }

                if (_0xe3b8bfc2 != null && _0xe3b8bfc2.IsAlive)
                    _0xe3b8bfc2.EvaluateJavaScript(_0x237ec74b());
                if (!_0x682ba529 && _0xe3b8bfc2 != null && _0xe3b8bfc2.IsAlive && IsHttpUrl(_0x0fa5426e))
                {
                    _0x682ba529 = true;
                }
            };
            _0xa854063d.OnPageFinished += (_0xe3b8bfc2, _0x15348cf6) =>
            {
                string _0x60de3d04 = _0x15348cf6 != null ? _0x15348cf6.data : string.Empty;
                WLog(_0x0b933aab._0x641ee83b(new byte[35] { 198, 201, 248, 238, 233, 192, 189, 205, 242, 237, 232, 237, 189, 202, 248, 255, 203, 244, 248, 234, 189, 219, 244, 243, 244, 238, 245, 248, 249, 167, 189, 232, 239, 241, 160 }, 157) + _0x60de3d04);
                if (_0xe3b8bfc2 == null || !_0xe3b8bfc2.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x60de3d04))
                {
                    _0xdcc5fd08();
                    _0xe3b8bfc2.EvaluateJavaScript(_0xba4aa5bc());
                    return;
                }

                if (!_0x4601a2fe)
                    return;
                _0xe3b8bfc2.EvaluateJavaScript(_0x237ec74b());
            };
        };
        _0xd0f76dda.OnMultipleWindowClosed += (_0x7c045ee4, _0x80352e4e) =>
        {
            _0xee857f7f.RemoveAll(_0xc8bdc7e9 => _0xc8bdc7e9 == null || _0xc8bdc7e9.Id == _0x80352e4e || !_0xc8bdc7e9.IsAlive);
            _0x53f9925b(false);
            if (_0xee857f7f.Count == 0 && _0x7cbbb2be != null)
            {
                _0x4601a2fe = false;
                _0x682ba529 = false;
                _0xa36620d4();
            }

            WLog(_0x0b933aab._0x641ee83b(new byte[43] { 211, 220, 237, 251, 252, 213, 168, 197, 233, 225, 230, 168, 223, 237, 234, 222, 225, 237, 255, 168, 197, 253, 228, 252, 225, 248, 228, 237, 223, 225, 230, 236, 231, 255, 168, 203, 228, 231, 251, 237, 236, 178, 168 }, 136) + _0x80352e4e);
        };
        _0xd0f76dda.RegisterOnRequestMediaCapturePermission(_0x260c906a =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    // PART 3
    private string _0xed6d2fd6()
    {
        try
        {
            var _0xee20ecd9 = new AndroidJavaClass(_0x0b933aab._0x641ee83b(new byte[30] { 114, 126, 124, 63, 100, 127, 120, 101, 104, 34, 117, 63, 97, 125, 112, 104, 116, 99, 63, 68, 127, 120, 101, 104, 65, 125, 112, 104, 116, 99 }, 17));
            var _0xb427b2da = _0xee20ecd9.GetStatic<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[15] { 207, 217, 222, 222, 201, 194, 216, 237, 207, 216, 197, 218, 197, 216, 213 }, 172));
            var _0x5485d854 = new AndroidJavaClass(_0x0b933aab._0x641ee83b(new byte[57] { 133, 137, 139, 200, 129, 137, 137, 129, 138, 131, 200, 135, 136, 130, 148, 137, 143, 130, 200, 129, 139, 149, 200, 135, 130, 149, 200, 143, 130, 131, 136, 146, 143, 128, 143, 131, 148, 200, 167, 130, 144, 131, 148, 146, 143, 149, 143, 136, 129, 175, 130, 165, 138, 143, 131, 136, 146 }, 230));
            var _0xdf6342ea = _0x5485d854.CallStatic<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[20] { 83, 81, 64, 117, 80, 66, 81, 70, 64, 93, 71, 93, 90, 83, 125, 80, 125, 90, 82, 91 }, 52), _0xb427b2da);
            var _0xe059931b = _0xdf6342ea.Call<string>(_0x0b933aab._0x641ee83b(new byte[5] { 217, 219, 202, 247, 218 }, 190));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0xe059931b}");
#endif
            }

            return string.IsNullOrEmpty(_0xe059931b) ? "" : _0xe059931b;
        }
        catch
        {
            return "";
        }
    }

    private readonly string[] _0xef2c1a8d = new string[]
    {
        _0x0b933aab._0x641ee83b(new byte[60] { 234, 133, 148, 170, 58, 78, 114, 127, 58, 104, 127, 127, 118, 105, 58, 123, 104, 127, 58, 114, 117, 110, 58, 104, 115, 125, 114, 110, 58, 116, 117, 109, 58, 248, 154, 137, 58, 126, 117, 116, 248, 154, 131, 110, 58, 119, 115, 105, 105, 58, 99, 117, 111, 104, 58, 105, 106, 115, 116, 59 }, 26),
        _0x0b933aab._0x641ee83b(new byte[52] { 222, 177, 163, 174, 14, 103, 90, 14, 77, 65, 91, 66, 74, 14, 76, 75, 14, 87, 65, 91, 92, 14, 66, 91, 77, 69, 87, 14, 67, 65, 67, 75, 64, 90, 14, 204, 174, 189, 14, 89, 70, 87, 14, 93, 90, 65, 94, 14, 64, 65, 89, 17 }, 46),
        _0x0b933aab._0x641ee83b(new byte[66] { 84, 44, 23, 89, 14, 57, 150, 244, 223, 209, 150, 193, 223, 216, 197, 150, 215, 196, 211, 150, 222, 223, 194, 194, 223, 216, 209, 150, 219, 217, 196, 211, 150, 217, 208, 194, 211, 216, 150, 194, 217, 210, 215, 207, 150, 84, 54, 37, 150, 197, 194, 215, 207, 150, 223, 216, 150, 194, 222, 211, 150, 209, 215, 219, 211, 152 }, 182),
        _0x0b933aab._0x641ee83b(new byte[54] { 125, 18, 24, 31, 173, 217, 229, 228, 254, 173, 228, 254, 173, 253, 255, 228, 224, 232, 173, 249, 228, 224, 232, 173, 111, 13, 30, 173, 249, 229, 232, 173, 239, 232, 254, 249, 173, 253, 225, 236, 244, 232, 255, 254, 173, 253, 225, 236, 244, 173, 227, 226, 250, 163 }, 141),
        _0x0b933aab._0x641ee83b(new byte[48] { 245, 154, 145, 160, 37, 92, 106, 112, 119, 37, 114, 108, 107, 107, 108, 107, 98, 37, 118, 113, 119, 96, 100, 110, 37, 102, 106, 112, 105, 97, 37, 103, 96, 37, 106, 107, 96, 37, 118, 117, 108, 107, 37, 100, 114, 100, 124, 43 }, 5),
        _0x0b933aab._0x641ee83b(new byte[65] { 4, 107, 110, 116, 212, 190, 149, 151, 159, 132, 155, 128, 135, 212, 149, 134, 145, 212, 153, 155, 134, 145, 212, 149, 151, 128, 157, 130, 145, 212, 128, 155, 154, 157, 147, 156, 128, 212, 22, 116, 103, 212, 135, 128, 149, 141, 212, 149, 154, 144, 212, 128, 134, 141, 212, 141, 155, 129, 134, 212, 152, 129, 151, 159, 218 }, 244),
        _0x0b933aab._0x641ee83b(new byte[55] { 105, 6, 23, 43, 185, 220, 239, 252, 235, 224, 185, 234, 233, 240, 247, 185, 250, 246, 236, 247, 237, 234, 185, 123, 25, 10, 185, 237, 241, 252, 185, 247, 252, 225, 237, 185, 246, 247, 252, 185, 250, 246, 236, 245, 253, 185, 251, 252, 185, 224, 246, 236, 235, 234, 183 }, 153),
        _0x0b933aab._0x641ee83b(new byte[63] { 217, 150, 171, 212, 131, 180, 27, 107, 87, 90, 66, 94, 73, 72, 27, 73, 82, 92, 83, 79, 27, 85, 84, 76, 27, 90, 73, 94, 27, 76, 82, 85, 85, 82, 85, 92, 27, 217, 187, 168, 27, 95, 84, 85, 217, 187, 162, 79, 27, 76, 90, 87, 80, 27, 90, 76, 90, 66, 27, 66, 94, 79, 21 }, 59),
        _0x0b933aab._0x641ee83b(new byte[51] { 223, 176, 160, 169, 15, 96, 65, 67, 86, 15, 91, 71, 64, 92, 74, 15, 88, 71, 64, 15, 92, 91, 78, 86, 15, 70, 65, 15, 91, 71, 74, 15, 72, 78, 66, 74, 15, 88, 70, 65, 15, 91, 71, 74, 15, 95, 93, 70, 85, 74, 1 }, 47),
        _0x0b933aab._0x641ee83b(new byte[64] { 183, 207, 244, 186, 237, 218, 117, 24, 58, 56, 48, 59, 33, 32, 56, 117, 60, 38, 117, 48, 35, 48, 39, 44, 33, 61, 60, 59, 50, 117, 183, 213, 198, 117, 62, 48, 48, 37, 117, 38, 37, 60, 59, 59, 60, 59, 50, 117, 51, 58, 39, 117, 44, 58, 32, 39, 117, 54, 61, 52, 59, 54, 48, 123 }, 85)
    };
    private bool _0x4d92848c = false;
    private void StopCurrentFailedLoad(UniWebView _0x465032d6)
    {
        _0x53f9925b(false);
        if (_0x465032d6 == null)
            return;
        _0x465032d6.Stop();
        if (_0x465032d6.CanGoBack)
            _0x465032d6.GoBack();
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0x07242fd1)
    {
        if (_0x07242fd1 == null || _0x07242fd1.Extra == null)
            return null;
        object _0xa674a007;
        if (!_0x07242fd1.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0xa674a007))
            return null;
        return _0xa674a007 as string;
    }

    private void _0xa7dbfc2a(UniWebView _0x8ea233bf)
    {
        _0x8ea233bf.BackgroundColor = Color.clear;
        _0x8ea233bf.SetSupportMultipleWindows(true, true);
        _0x8ea233bf.SetBackButtonEnabled(false);
        _0x7cbbb2be.SetUserAgent(_0x6739183c());
    }

    private string _0xfb449a21 = "";
    private void _0xfccf6876()
    {
        if (_0x6c55ada4 != null)
            return;
        var _0x393d01cf = _0xa66e33f5();
        _0x6c55ada4 = new GameObject(_0x0b933aab._0x641ee83b(new byte[14] { 54, 4, 3, 55, 8, 4, 22, 50, 17, 8, 15, 15, 4, 19 }, 97), typeof(RectTransform), typeof(Text));
        _0x96a438ba = _0x6c55ada4.GetComponent<RectTransform>();
        _0x96a438ba.SetParent(_0x393d01cf.transform, false);
        _0x96a438ba.anchorMin = new Vector2(0.5f, 0.5f);
        _0x96a438ba.anchorMax = new Vector2(0.5f, 0.5f);
        _0x96a438ba.pivot = new Vector2(0.5f, 0.5f);
        _0x96a438ba.sizeDelta = new Vector2(600f, 600f);
        _0x96a438ba.anchoredPosition = Vector2.zero;
        _0x213a94bd = _0x6c55ada4.GetComponent<Text>();
        _0x213a94bd.text = _0x0b933aab._0x641ee83b(new byte[1] { 203 }, 228);
        _0x213a94bd.font = Resources.GetBuiltinResource<Font>(_0x0b933aab._0x641ee83b(new byte[17] { 236, 197, 199, 193, 195, 217, 242, 213, 206, 212, 201, 205, 197, 142, 212, 212, 198 }, 160));
        _0x213a94bd.fontSize = 200;
        _0x213a94bd.alignment = TextAnchor.MiddleCenter;
        _0x213a94bd.color = Color.white;
        _0x213a94bd.raycastTarget = false;
        _0x6c55ada4.SetActive(false);
    }

    private void _0xa36620d4()
    {
        if (_0x7cbbb2be == null)
            return;
        if (_0xa01073fb)
            _0x7cbbb2be.SetUserAgent(_0x6739183c());
        else
            _0x7cbbb2be.SetUserAgent("");
    }

    private IEnumerator _0x801b135f(string _0xd62a9c74)
    {
        if (Permission.HasUserAuthorizedPermission(_0xd62a9c74))
            yield break;
        bool _0x41548766 = false;
        var _0x510fb14b = new PermissionCallbacks();
        _0x510fb14b.PermissionGranted += _0x88717932 => _0x41548766 = true;
        _0x510fb14b.PermissionDenied += _0x88717932 => _0x41548766 = true;
        Permission.RequestUserPermission(_0xd62a9c74, _0x510fb14b);
        yield return new WaitUntil(() => _0x41548766);
    }

    private void OnApplicationFocus(bool _0xf0c1eb81)
    {
        isApplicationFocus = _0xf0c1eb81;
        if (_0xf0c1eb81 && _0x4eee2880)
        {
            _0x60cdd6d9();
        }
    }

    private void _0xc10188cf(string _0x6b97787a)
    {
        Dictionary<string, object> _0x70128f5d;
        try
        {
            _0x70128f5d = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x6b97787a);
        }
        catch
        {
            return;
        }

        var _0x69b8d764 = ReadPushField(_0x70128f5d, _0x0b933aab._0x641ee83b(new byte[3] { 7, 0, 30 }, 114));
        if (string.IsNullOrWhiteSpace(_0x69b8d764))
            return;
        _0x69b8d764 = _0x69b8d764.Trim();
        if (!IsHttpUrl(_0x69b8d764))
            return;
        if (string.Equals(_0x69b8d764, _0x7c6252bf, StringComparison.Ordinal))
            return;
        _0x7c6252bf = _0x69b8d764;
        OpenUrlExternally(_0x69b8d764);
    }

    private string _0x8df724e8 = "";
    private bool OpenUrlExternally(string _0x7c8bcdb7)
    {
        return _0x2c6c155c(_0x7c8bcdb7);
    }

    private bool _0xd1aa5a1e(string _0x304f4408, string _0x133becb1)
    {
        string _0xe62fb93d = _0x190a2bf3(_0x304f4408);
        if (string.IsNullOrEmpty(_0xe62fb93d))
            _0xe62fb93d = _0x133becb1;
        if (_0xd9a9f93a(_0xe62fb93d))
            return true;
        string _0x6edc5d4e = string.IsNullOrEmpty(_0xe62fb93d) ? _0x0b933aab._0x641ee83b(new byte[29] { 113, 109, 109, 105, 106, 35, 54, 54, 105, 117, 120, 96, 55, 126, 118, 118, 126, 117, 124, 55, 122, 118, 116, 54, 106, 109, 118, 107, 124 }, 25) : _0x0b933aab._0x641ee83b(new byte[46] { 147, 143, 143, 139, 136, 193, 212, 212, 139, 151, 154, 130, 213, 156, 148, 148, 156, 151, 158, 213, 152, 148, 150, 212, 136, 143, 148, 137, 158, 212, 154, 139, 139, 136, 212, 159, 158, 143, 154, 146, 151, 136, 196, 146, 159, 198 }, 251) + _0xe62fb93d;
        WLog(_0x0b933aab._0x641ee83b(new byte[35] { 184, 147, 137, 148, 150, 158, 183, 146, 144, 158, 219, 150, 154, 137, 144, 158, 143, 219, 157, 154, 151, 151, 153, 154, 152, 144, 219, 154, 136, 219, 140, 158, 153, 193, 219 }, 251) + _0x6edc5d4e);
        return _0x2c6c155c(_0x6edc5d4e);
    }

    private string _0xccc26b2e = "";
    private async Task<bool> _0x1a012f04(int _0x6655d57d = 5, int _0x9f82ca0a = 500)
    {
        List<EntityData> _0x98a9bfb6 = new List<EntityData>();
        int _0x14b79220 = 0;
        do
        {
            try
            {
                _0x98a9bfb6 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x0b933aab._0x641ee83b(new byte[8] { 66, 94, 83, 75, 87, 64, 123, 86 }, 50), _0xca0d09c7, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x0b933aab._0x641ee83b(new byte[9] { 126, 100, 71, 101, 126, 97, 118, 116, 110 }, 23) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x0b933aab._0x641ee83b(new byte[32] { 125, 114, 67, 85, 82, 123, 6, 87, 83, 67, 84, 95, 103, 85, 95, 72, 69, 116, 67, 85, 83, 74, 82, 85, 6, 67, 84, 84, 73, 84, 28, 6 }, 38) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0x9f82ca0a);
        }
        while (_0x98a9bfb6.Count == 0 && _0x14b79220++ < _0x6655d57d);
        {
#if B_LOGS
            {
                Debug.Log(_0x0b933aab._0x641ee83b(new byte[32] { 216, 215, 230, 240, 247, 222, 163, 202, 240, 211, 241, 234, 245, 226, 224, 250, 163, 210, 246, 230, 241, 250, 163, 241, 230, 240, 246, 239, 247, 240, 185, 163 }, 131) + JsonConvert.SerializeObject(_0x98a9bfb6, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x0b933aab._0x641ee83b(new byte[38] { 128, 143, 190, 168, 175, 134, 251, 146, 168, 139, 169, 178, 173, 186, 184, 162, 251, 138, 174, 190, 169, 162, 251, 169, 190, 168, 174, 183, 175, 168, 251, 184, 180, 174, 181, 175, 225, 251 }, 219) + _0x98a9bfb6.Count);
            }
#endif
        }

        bool _0x6fccdbfc = true;
        if (_0x98a9bfb6.Count == 0)
        {
            _0x6fccdbfc = false;
        }
        else
        {
            _0x6fccdbfc = _0x98a9bfb6.Any(_0x8b1b3794 => _0x8b1b3794.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x0b933aab._0x641ee83b(new byte[25] { 102, 105, 88, 78, 73, 96, 29, 116, 78, 109, 79, 84, 75, 92, 94, 68, 29, 79, 88, 78, 72, 81, 73, 7, 29 }, 61) + _0x6fccdbfc);
            }
#endif
        }

        return _0x6fccdbfc;
    }

    private async void Start()
    {
        await _0x8812b75d();
    }

    internal bool firstLoadShown = false;
    private int _0xbe076dab = -1;
    private IEnumerator _0xe01a0a96(Dictionary<string, object> _0xd56da720)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x0b933aab._0x641ee83b(new byte[30] { 67, 76, 125, 107, 108, 69, 56, 94, 125, 108, 123, 112, 56, 93, 96, 108, 106, 121, 56, 72, 109, 107, 112, 56, 92, 121, 108, 121, 34, 56 }, 24) + string.Join(_0x0b933aab._0x641ee83b(new byte[1] { 1 }, 8), _0xd56da720));
#endif
            }
        }

        string _0x433dc2cb = "";
        // Primary source: nested JSON under "notificationData"
        if (_0xd56da720 != null && _0xd56da720.TryGetValue(_0x0b933aab._0x641ee83b(new byte[16] { 130, 131, 152, 133, 138, 133, 143, 141, 152, 133, 131, 130, 168, 141, 152, 141 }, 236), out var raw))
        {
            try
            {
                var _0x0808fd12 = raw?.ToString();
                var _0x26fcb70f = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x0808fd12);
                if (_0x26fcb70f != null && _0x26fcb70f.TryGetValue(_0x0b933aab._0x641ee83b(new byte[6] { 238, 248, 243, 249, 244, 249 }, 157), out var val))
                {
                    _0x433dc2cb = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x0b933aab._0x641ee83b(new byte[30] { 112, 127, 78, 88, 95, 11, 123, 94, 88, 67, 118, 11, 97, 120, 100, 101, 11, 91, 74, 89, 88, 78, 11, 78, 89, 89, 68, 89, 17, 11 }, 43) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x433dc2cb) && _0xd56da720 != null && _0xd56da720.TryGetValue(_0x0b933aab._0x641ee83b(new byte[6] { 232, 254, 245, 255, 242, 255 }, 155), out var lab))
        {
            _0x433dc2cb = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x0b933aab._0x641ee83b(new byte[38] { 43, 36, 21, 3, 4, 80, 32, 5, 3, 24, 45, 80, 54, 21, 4, 19, 24, 21, 20, 80, 3, 21, 30, 20, 25, 20, 80, 22, 2, 31, 29, 80, 26, 3, 31, 30, 74, 80 }, 112) + _0x433dc2cb);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x433dc2cb))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x0b933aab._0x641ee83b(new byte[38] { 183, 184, 137, 159, 152, 204, 188, 153, 159, 132, 177, 204, 187, 141, 133, 152, 204, 152, 131, 204, 131, 156, 137, 130, 204, 155, 133, 152, 132, 204, 159, 137, 130, 136, 133, 136, 214, 204 }, 236) + _0x433dc2cb);
            }
#endif
        }

        _0x9b319375 = _0x433dc2cb;
        yield return new WaitUntil(() => _0x4eee2880);
        var _0x55f97065 = _0x80547a41(2, 100);
        yield return new WaitUntil(() => _0x55f97065.IsCompleted);
        string _0x02c8e1a5 = _0x55f97065.Result;
        if (!string.IsNullOrEmpty(_0x02c8e1a5))
        {
            string _0xdf314a09 = _0xfffb3428(_0x02c8e1a5, _0x433dc2cb);
            {
#if B_LOGS
                Debug.Log(_0x0b933aab._0x641ee83b(new byte[33] { 86, 89, 104, 126, 121, 45, 93, 120, 126, 101, 80, 45, 95, 104, 97, 98, 108, 105, 45, 90, 104, 111, 91, 100, 104, 122, 45, 122, 100, 121, 101, 55, 45 }, 13) + _0xdf314a09);
#endif
            }

            _0x7cbbb2be.Load(_0xdf314a09);
        }
    }

    private string _0x1592ab9e = "";
    internal Button _0x3f7d14b2(string _0x91f77f43, Transform _0x813c276b)
    {
        var _0xe2fc985e = new GameObject(_0x91f77f43 + _0x0b933aab._0x641ee83b(new byte[3] { 191, 137, 147 }, 253), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0xe6a789cb = _0xe2fc985e.GetComponent<RectTransform>();
        _0xe6a789cb.SetParent(_0x813c276b, false);
        var _0x1692c8d3 = _0xe2fc985e.GetComponent<Image>();
        _0x1692c8d3.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x28fcd885 = _0xe2fc985e.GetComponent<Button>();
        var _0x25b9f83b = _0x28fcd885.colors;
        _0x25b9f83b.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x25b9f83b.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x28fcd885.colors = _0x25b9f83b;
        var _0x6c3ad759 = new GameObject(_0x0b933aab._0x641ee83b(new byte[4] { 64, 113, 108, 96 }, 20), typeof(RectTransform), typeof(Text));
        var _0xf2457d9d = _0x6c3ad759.GetComponent<RectTransform>();
        _0xf2457d9d.SetParent(_0xe2fc985e.transform, false);
        _0xf2457d9d.anchorMin = Vector2.zero;
        _0xf2457d9d.anchorMax = Vector2.one;
        _0xf2457d9d.offsetMin = _0xf2457d9d.offsetMax = Vector2.zero;
        var _0xd54a228f = _0x6c3ad759.GetComponent<Text>();
        _0xd54a228f.text = _0x91f77f43;
        _0xd54a228f.alignment = TextAnchor.MiddleCenter;
        _0xd54a228f.color = Color.black;
        _0xd54a228f.font = Resources.GetBuiltinResource<Font>(_0x0b933aab._0x641ee83b(new byte[9] { 154, 169, 178, 186, 183, 245, 175, 175, 189 }, 219));
        _0xd54a228f.fontSize = 28;
        WLog(_0x0b933aab._0x641ee83b(new byte[14] { 238, 223, 200, 204, 217, 200, 239, 216, 217, 217, 194, 195, 141, 138 }, 173) + _0x91f77f43 + _0x0b933aab._0x641ee83b(new byte[1] { 115 }, 84));
        return _0x28fcd885;
    }

    private string _0x1ce98926 = "";
    private string _0x58a67c68()
    {
        string _0x03d60838 = _0x0b933aab._0x641ee83b(new byte[62] { 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, 31, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 46, 45, 44, 43, 42, 41, 40, 39, 38, 37, 36, 35, 34, 33, 32, 63, 62, 61, 60, 59, 58, 57, 56, 55, 54, 53, 95, 94, 93, 92, 91, 90, 89, 88, 87, 86 }, 111);
        System.Random _0x7c2741aa = new System.Random();
        int _0xb85c5ff7 = _0x7c2741aa.Next(8, 16);
        return new string (Enumerable.Repeat(_0x03d60838, _0xb85c5ff7).Select(_0x114e6a1e => _0x114e6a1e[_0x7c2741aa.Next(_0x114e6a1e.Length)]).ToArray());
    }

    private string _0x6a428d7b = "";
    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x29f4a13e(string _0x1bbf2603, string _0x46a87987)
    {
        try
        {
            using var _0xfba0f598 = Aes.Create();
            _0xfba0f598.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x46a87987));
            _0xfba0f598.GenerateIV();
            using var _0x7ad61b82 = new MemoryStream();
            _0x7ad61b82.Write(_0xfba0f598.IV, 0, _0xfba0f598.IV.Length);
            using (var _0xe59624ff = new CryptoStream(_0x7ad61b82, _0xfba0f598.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x915b1d33 = Encoding.UTF8.GetBytes(_0x1bbf2603);
                _0xe59624ff.Write(_0x915b1d33, 0, _0x915b1d33.Length);
                _0xe59624ff.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x7ad61b82.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private bool TryOpenExternalLikeChrome(string _0xc993d5ee)
    {
        if (string.IsNullOrEmpty(_0xc993d5ee))
            return false;
        if (_0xc993d5ee.StartsWith(_0x0b933aab._0x641ee83b(new byte[9] { 76, 75, 81, 64, 75, 81, 31, 10, 10 }, 37), StringComparison.OrdinalIgnoreCase))
            return _0xb2ae6051(_0xc993d5ee);
        if (_0x6b29199a(_0xc993d5ee))
            return _0xd1aa5a1e(_0xc993d5ee, null);
        if (!_0xc993d5ee.StartsWith(_0x0b933aab._0x641ee83b(new byte[7] { 64, 92, 92, 88, 18, 7, 7 }, 40), StringComparison.OrdinalIgnoreCase) && !_0xc993d5ee.StartsWith(_0x0b933aab._0x641ee83b(new byte[8] { 167, 187, 187, 191, 188, 245, 224, 224 }, 207), StringComparison.OrdinalIgnoreCase) && !_0xc993d5ee.StartsWith(_0x0b933aab._0x641ee83b(new byte[11] { 74, 73, 68, 94, 95, 17, 73, 71, 74, 69, 64 }, 43), StringComparison.OrdinalIgnoreCase))
        {
            return _0x2c6c155c(_0xc993d5ee);
        }

        return false;
    }

    private async Task<bool> _0x0fe20b84()
    {
        {
#if B_LOGS
            Debug.Log(_0x0b933aab._0x641ee83b(new byte[29] { 22, 25, 40, 62, 57, 16, 109, 4, 62, 29, 63, 36, 59, 44, 46, 52, 12, 35, 41, 30, 44, 59, 40, 41, 14, 37, 40, 46, 38 }, 77));
#endif
        }

        string _0x7397fa62 = "";
        for (int _0x95a8d124 = 0; _0x95a8d124 < 2; _0x95a8d124++)
        {
            if (await _0x1a012f04(1, 100))
            {
                await _0xca66993f(_0x0b933aab._0x641ee83b(new byte[7] { 19, 29, 30, 18, 26, 20, 21 }, 113));
                _0x79138406();
                return true;
            }

            _0x7397fa62 = await _0x80547a41(1, 100);
            if (!string.IsNullOrEmpty(_0x7397fa62))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x7397fa62))
            {
                if (!string.IsNullOrEmpty(_0x9b319375))
                {
                    _0x7397fa62 = _0xfffb3428(_0x7397fa62, _0x9b319375);
                    {
#if B_LOGS
                        Debug.Log(_0x0b933aab._0x641ee83b(new byte[53] { 94, 81, 96, 118, 113, 88, 37, 70, 100, 102, 109, 96, 97, 37, 99, 108, 107, 100, 105, 80, 119, 105, 37, 114, 108, 113, 109, 37, 118, 96, 107, 97, 108, 97, 37, 231, 131, 151, 37, 118, 109, 106, 114, 37, 82, 96, 103, 83, 108, 96, 114, 63, 37 }, 5) + _0x7397fa62);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x0b933aab._0x641ee83b(new byte[39] { 49, 62, 15, 25, 30, 55, 74, 41, 11, 9, 2, 15, 14, 74, 12, 3, 4, 11, 6, 63, 24, 6, 74, 136, 236, 248, 74, 25, 2, 5, 29, 74, 61, 15, 8, 60, 3, 15, 29 }, 106));
#endif
                    }
                }

                _0x4d92848c = true;
                _0xc33896d9(_0x7397fa62);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x0b933aab._0x641ee83b(new byte[44] { 87, 88, 105, 127, 120, 81, 44, 73, 116, 111, 105, 124, 120, 101, 99, 98, 44, 123, 100, 101, 96, 105, 44, 111, 100, 105, 111, 103, 101, 98, 107, 44, 127, 109, 122, 105, 104, 44, 96, 101, 98, 103, 54, 44 }, 12) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private AndroidJavaObject _0xbc48bfb6 { get; set; }

    internal Rect lastSafe = Rect.zero;
    private string _0xca0d09c7 = "";
    internal bool isApplicationFocus = false;
    internal bool IsAboutBlank(string _0xef75ee7d)
    {
        if (string.IsNullOrEmpty(_0xef75ee7d))
            return false;
        return _0xef75ee7d.StartsWith(_0x0b933aab._0x641ee83b(new byte[11] { 118, 117, 120, 98, 99, 45, 117, 123, 118, 121, 124 }, 23), StringComparison.OrdinalIgnoreCase);
    }

    internal bool _0x6b29199a(string _0x096e5eb4)
    {
        return _0x096e5eb4.StartsWith(_0x0b933aab._0x641ee83b(new byte[9] { 233, 229, 246, 239, 225, 240, 190, 171, 171 }, 132), StringComparison.OrdinalIgnoreCase) || _0x096e5eb4.StartsWith(_0x0b933aab._0x641ee83b(new byte[24] { 228, 248, 248, 252, 255, 182, 163, 163, 252, 224, 237, 245, 162, 235, 227, 227, 235, 224, 233, 162, 239, 227, 225, 163 }, 140), StringComparison.OrdinalIgnoreCase) || _0x096e5eb4.StartsWith(_0x0b933aab._0x641ee83b(new byte[23] { 125, 97, 97, 101, 47, 58, 58, 101, 121, 116, 108, 59, 114, 122, 122, 114, 121, 112, 59, 118, 122, 120, 58 }, 21), StringComparison.OrdinalIgnoreCase);
    }

    private JObject _0x70f5f366(params string[] _0xb24511a5)
    {
        JObject _0xca8b1df7 = new JObject();
        foreach (var _0xef192522 in _0xb24511a5)
        {
            string _0xa7b8902b = _0x58a67c68();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0xa7b8902b} val={_0xef192522}");
#endif
            }

            _0xca8b1df7.Add(_0xa7b8902b, _0xef192522 == null ? "" : _0xef192522);
        }

        return _0xca8b1df7;
    }

    private string _0x02f75ad1 = "";
    private IEnumerator _0x1b379f35()
    {
        yield return _0x801b135f(Permission.Camera);
    }

    private void _0x1d145ba2()
    {
        {
#if B_LOGS
            Debug.Log(_0x0b933aab._0x641ee83b(new byte[22] { 33, 46, 31, 9, 14, 39, 90, 41, 14, 21, 8, 31, 62, 31, 12, 19, 25, 31, 51, 20, 28, 21 }, 122));
#endif
        }

        _0x1dee5c6a = SystemInfo.deviceModel;
        _0xfb449a21 = Application.version;
        _0x3c410f1b = Application.installMode;
        _0xc4bd9b8f = Application.installerName;
        _0x1ce98926 = Application.identifier;
        _0xc03b0070 = _0xed6d2fd6();
        _0x0946b908 = _0xb4092374();
        _0xee46e1cb = SystemInfo.deviceUniqueIdentifier;
        _0x6376c52a = SystemInfo.graphicsDeviceName;
        _0xccc26b2e = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0xfb449a21 = _0x0b933aab._0x641ee83b(new byte[5] { 248, 225, 248, 225, 248 }, 207);
                _0x3c410f1b = ApplicationInstallMode.Store;
                _0xc4bd9b8f = _0x0b933aab._0x641ee83b(new byte[19] { 109, 97, 99, 32, 111, 96, 106, 124, 97, 103, 106, 32, 120, 107, 96, 106, 103, 96, 105 }, 14);
                _0x0946b908 = _0x0b933aab._0x641ee83b(new byte[8] { 94, 86, 75, 79, 66, 27, 78, 90 }, 59);
                _0xee46e1cb = Guid.NewGuid().ToString().Replace(_0x0b933aab._0x641ee83b(new byte[1] { 19 }, 62), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x0b933aab._0x641ee83b(new byte[17] { 180, 187, 138, 156, 155, 178, 207, 139, 138, 153, 162, 128, 139, 138, 131, 213, 207 }, 239) + _0x1dee5c6a);
            Debug.Log(_0x0b933aab._0x641ee83b(new byte[19] { 197, 202, 251, 237, 234, 195, 190, 255, 238, 238, 200, 251, 236, 237, 247, 241, 240, 164, 190 }, 158) + _0xfb449a21);
            Debug.Log(_0x0b933aab._0x641ee83b(new byte[20] { 221, 210, 227, 245, 242, 219, 166, 239, 232, 245, 242, 231, 234, 234, 203, 233, 226, 227, 188, 166 }, 134) + _0x3c410f1b);
            Debug.Log(_0x0b933aab._0x641ee83b(new byte[23] { 76, 67, 114, 100, 99, 74, 55, 126, 121, 100, 99, 118, 123, 123, 114, 101, 68, 99, 120, 101, 114, 45, 55 }, 23) + _0xc4bd9b8f);
            Debug.Log(_0x0b933aab._0x641ee83b(new byte[14] { 3, 12, 61, 43, 44, 5, 120, 57, 40, 40, 17, 60, 98, 120 }, 88) + _0x1ce98926);
            Debug.Log(_0x0b933aab._0x641ee83b(new byte[14] { 53, 58, 11, 29, 26, 51, 78, 15, 10, 24, 39, 10, 84, 78 }, 110) + _0xc03b0070);
            Debug.Log(_0x0b933aab._0x641ee83b(new byte[18] { 197, 202, 251, 237, 234, 195, 190, 235, 237, 251, 236, 223, 249, 251, 240, 234, 164, 190 }, 158) + _0x0946b908);
            Debug.Log(_0x0b933aab._0x641ee83b(new byte[17] { 229, 234, 219, 205, 202, 227, 158, 205, 199, 205, 250, 219, 200, 247, 218, 132, 158 }, 190) + _0xee46e1cb);
            Debug.Log(_0x0b933aab._0x641ee83b(new byte[12] { 60, 51, 2, 20, 19, 58, 71, 0, 23, 18, 93, 71 }, 103) + _0x6376c52a);
            Debug.Log(_0x0b933aab._0x641ee83b(new byte[12] { 14, 1, 48, 38, 33, 8, 117, 54, 37, 32, 111, 117 }, 85) + _0xccc26b2e);
#endif
        }
    }

    private bool _0x4accc926 = false;
    private void _0xc33896d9(string _0x3275c003)
    {
        _0x60cdd6d9();
        StartCoroutine(_0xcdc2bde1(_0x3275c003));
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0xa673824c()
    {
        var _0xae06e847 = _0x0b933aab._0x641ee83b(new byte[40] { 141, 145, 145, 149, 150, 223, 202, 202, 146, 146, 146, 203, 134, 137, 138, 144, 129, 131, 137, 132, 151, 128, 203, 134, 138, 136, 202, 134, 129, 139, 200, 134, 130, 140, 202, 145, 151, 132, 134, 128 }, 229);
        using (UnityWebRequest _0x4d05f25e = UnityWebRequest.Get(_0xae06e847))
        {
            await _0x4d05f25e.SendWebRequest();
            string[] _0x17017583 = _0x4d05f25e.downloadHandler.text.Split('\n');
            foreach (string _0xb480b0bf in _0x17017583)
            {
                if (_0xb480b0bf.StartsWith(_0x0b933aab._0x641ee83b(new byte[3] { 228, 253, 176 }, 141)))
                {
                    string _0x079b2e0d = _0xb480b0bf.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x079b2e0d} from {_0xae06e847}");
                        }
#endif
                    }

                    return _0x079b2e0d;
                }
            }
        }

        return "";
    }

    internal void Update()
    {
        if (_0x7cbbb2be == null)
            return;
        if (_0xfe4242cb())
            _0xa1ce9ce5();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0xbdf5cc5d();
        if (_0x4accc926 && _0x96a438ba != null)
            _0x96a438ba.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private Task _0x90e35b41(IEnumerator _0xa4babeff)
    {
        var _0xf7529d6d = new TaskCompletionSource<bool>();
        StartCoroutine(_0xcaf2244d(_0xa4babeff, _0xf7529d6d));
        return _0xf7529d6d.Task;
    }

    private int _0xabe681b7 = 0;
    private string Decrypt(string _0xa1f90c86, string _0xbc1223b2)
    {
        try
        {
            var _0x814b9cd5 = Convert.FromBase64String(_0xa1f90c86);
            using var _0x55189713 = Aes.Create();
            _0x55189713.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xbc1223b2));
            var _0x156969ba = new byte[16];
            Buffer.BlockCopy(_0x814b9cd5, 0, _0x156969ba, 0, 16);
            _0x55189713.IV = _0x156969ba;
            using var _0x7e5fc77f = new MemoryStream(_0x814b9cd5, 16, _0x814b9cd5.Length - 16);
            using var _0xfce93138 = new CryptoStream(_0x7e5fc77f, _0x55189713.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0xe4e5596e = new StreamReader(_0xfce93138, Encoding.UTF8);
            return _0xe4e5596e.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private bool _0x89707758 = false;
    private void OnApplicationPause(bool _0xac60ca97)
    {
        isApplicationPause = _0xac60ca97;
    }

    private async Task _0x48e449f1()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x02f75ad1 = _0x0b933aab._0x641ee83b(new byte[5] { 243, 244, 249, 230, 240 }, 149);
        _0x5d2ca95a = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x1f7e6bc8 = DateTime.UtcNow.Ticks.ToString();
        _0x9d74f036 = "";
        JObject _0x62567d68 = _0x70f5f366(_0x1ce98926, _0x49081543, _0xc03b0070, _0xb6a33a60, _0x8df724e8, _0x39f516fc, _0x2c9bb801, _0x0946b908, _0x1592ab9e, _0xee46e1cb, _0x02f75ad1, _0x9d74f036, _0x1dee5c6a, _0xfb449a21, _0x3c410f1b.ToString(), _0xc4bd9b8f, _0x1f7e6bc8, _0x5d2ca95a, _0xca0d09c7, _0x6376c52a, _0xccc26b2e, _0xf2b78c66, _0x0d29c61f());
        var _0x38a37226 = _0x29f4a13e(_0x62567d68.ToString(), _0xca0d09c7);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x62567d68}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x0b933aab._0x641ee83b(new byte[7] { 26, 11, 19, 6, 5, 11, 14 }, 106) + _0xca0d09c7, _0x38a37226 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x0b933aab._0x641ee83b(new byte[22] { 252, 243, 226, 244, 243, 250, 135, 224, 194, 201, 194, 213, 198, 203, 135, 194, 213, 213, 200, 213, 157, 135 }, 167) + e.Message);
#endif
            }
        }

        await Task.Delay(500);
        string _0x83e3a8b0 = "";
        for (int _0x75107429 = 0; _0x75107429 < 30; _0x75107429++)
        {
            if (await _0x1a012f04(1, 1))
            {
                await _0xca66993f(_0x0b933aab._0x641ee83b(new byte[7] { 239, 225, 226, 238, 230, 232, 233 }, 141));
                _0x79138406();
                return;
            }

            _0x83e3a8b0 = await _0x80547a41(1, 500);
            if (!string.IsNullOrEmpty(_0x83e3a8b0))
                break;
        }

        _0x0a075669(_0x83e3a8b0);
    }

    private void WLog(string _0x5bbbdc19)
    {
#if B_LOGS
        {
            Debug.Log(_0x0b933aab._0x641ee83b(new byte[7] { 85, 90, 107, 125, 122, 83, 46 }, 14) + _0x5bbbdc19);
        }
#endif
    }

    private bool _0x9b1ede4f()
    {
        _0xee857f7f.RemoveAll(_0xc8bdc7e9 => _0xc8bdc7e9 == null || !_0xc8bdc7e9.IsAlive);
        return _0xee857f7f.Count > 0;
    }

    private string _0xb6a33a60 = "";
    private string _0x2c9bb801 { get; set; }

    private UniWebViewPopup _0x4dd100a2()
    {
        for (int _0x1598b735 = _0xee857f7f.Count - 1; _0x1598b735 >= 0; _0x1598b735--)
        {
            var _0x8d1ffab6 = _0xee857f7f[_0x1598b735];
            if (_0x8d1ffab6 != null && _0x8d1ffab6.IsAlive)
                return _0x8d1ffab6;
            _0xee857f7f.RemoveAt(_0x1598b735);
        }

        return null;
    }

    // WS_SOURCE MONO
    public static _0xf1747815 _0xdcb87af9 { get; private set; }

    private bool _0xb2ae6051(string _0xa81ffa47)
    {
        try
        {
            using (var _0xda8115dd = new AndroidJavaClass(_0x0b933aab._0x641ee83b(new byte[30] { 141, 129, 131, 192, 155, 128, 135, 154, 151, 221, 138, 192, 158, 130, 143, 151, 139, 156, 192, 187, 128, 135, 154, 151, 190, 130, 143, 151, 139, 156 }, 238)))
            using (var _0x9bb5c6ea = _0xda8115dd.GetStatic<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[15] { 54, 32, 39, 39, 48, 59, 33, 20, 54, 33, 60, 35, 60, 33, 44 }, 85)))
            using (var _0x56976061 = _0x9bb5c6ea.Call<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[17] { 62, 60, 45, 9, 56, 58, 50, 56, 62, 60, 20, 56, 55, 56, 62, 60, 43 }, 89)))
            using (var _0x01ae7524 = new AndroidJavaClass(_0x0b933aab._0x641ee83b(new byte[22] { 239, 224, 234, 252, 225, 231, 234, 160, 237, 225, 224, 250, 235, 224, 250, 160, 199, 224, 250, 235, 224, 250 }, 142)))
            using (var _0xb7b236df = _0x01ae7524.CallStatic<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[8] { 186, 171, 184, 185, 175, 159, 184, 163 }, 202), _0xa81ffa47, 1))
            {
                string _0xd5e4f9dd = _0xb7b236df.Call<string>(_0x0b933aab._0x641ee83b(new byte[14] { 115, 113, 96, 71, 96, 102, 125, 122, 115, 81, 108, 96, 102, 117 }, 20), _0x0b933aab._0x641ee83b(new byte[20] { 254, 238, 243, 235, 239, 249, 238, 195, 250, 253, 240, 240, 254, 253, 255, 247, 195, 233, 238, 240 }, 156));
                string _0x5142a6b8 = _0xb7b236df.Call<string>(_0x0b933aab._0x641ee83b(new byte[10] { 134, 132, 149, 177, 128, 130, 138, 128, 134, 132 }, 225));
                _0xb7b236df.Call<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[11] { 231, 226, 226, 197, 231, 242, 227, 225, 233, 244, 255 }, 134), _0x0b933aab._0x641ee83b(new byte[33] { 199, 200, 194, 212, 201, 207, 194, 136, 207, 200, 210, 195, 200, 210, 136, 197, 199, 210, 195, 193, 201, 212, 223, 136, 228, 244, 233, 241, 245, 231, 228, 234, 227 }, 166));
                _0xb7b236df.Call<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[11] { 98, 117, 125, 127, 102, 117, 85, 104, 100, 98, 113 }, 16), _0x0b933aab._0x641ee83b(new byte[20] { 57, 41, 52, 44, 40, 62, 41, 4, 61, 58, 55, 55, 57, 58, 56, 48, 4, 46, 41, 55 }, 91));
                if (_0xb7b236df.Call<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[15] { 1, 22, 0, 28, 31, 5, 22, 50, 16, 7, 26, 5, 26, 7, 10 }, 115), _0x56976061) != null)
                {
                    WLog(_0x0b933aab._0x641ee83b(new byte[24] { 127, 84, 78, 83, 81, 89, 112, 85, 87, 89, 28, 83, 76, 89, 82, 28, 85, 82, 72, 89, 82, 72, 6, 28 }, 60) + _0xa81ffa47);
                    _0xb7b236df.Call<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[8] { 142, 139, 139, 169, 131, 142, 136, 156 }, 239), 0x10000000);
                    _0x9bb5c6ea.Call(_0x0b933aab._0x641ee83b(new byte[13] { 164, 163, 182, 165, 163, 150, 180, 163, 190, 161, 190, 163, 174 }, 215), _0xb7b236df);
                    return true;
                }

                if (_0xd9a9f93a(_0x5142a6b8))
                    return true;
                if (!string.IsNullOrEmpty(_0xd5e4f9dd))
                {
                    WLog(_0x0b933aab._0x641ee83b(new byte[28] { 221, 246, 236, 241, 243, 251, 210, 247, 245, 251, 190, 247, 240, 234, 251, 240, 234, 190, 248, 255, 242, 242, 252, 255, 253, 245, 164, 190 }, 158) + _0xd5e4f9dd);
                    if (_0x6b29199a(_0xd5e4f9dd))
                        return _0xd1aa5a1e(_0xd5e4f9dd, _0x5142a6b8);
                    return _0x2c6c155c(_0xd5e4f9dd);
                }

                WLog(_0x0b933aab._0x641ee83b(new byte[30] { 255, 212, 206, 211, 209, 217, 240, 213, 215, 217, 156, 213, 210, 200, 217, 210, 200, 156, 210, 211, 156, 212, 221, 210, 216, 208, 217, 206, 134, 156 }, 188) + _0xa81ffa47);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x0b933aab._0x641ee83b(new byte[26] { 247, 220, 198, 219, 217, 209, 248, 221, 223, 209, 148, 221, 218, 192, 209, 218, 192, 148, 210, 213, 221, 216, 209, 208, 142, 148 }, 180) + e.Message);
            return true;
        }
    }

    internal bool IsHttpUrl(string _0xe86adef4)
    {
        if (string.IsNullOrEmpty(_0xe86adef4))
            return false;
        return _0xe86adef4.StartsWith(_0x0b933aab._0x641ee83b(new byte[7] { 143, 147, 147, 151, 221, 200, 200 }, 231), StringComparison.OrdinalIgnoreCase) || _0xe86adef4.StartsWith(_0x0b933aab._0x641ee83b(new byte[8] { 102, 122, 122, 126, 125, 52, 33, 33 }, 14), StringComparison.OrdinalIgnoreCase);
    }

    private bool _0xfe69f8bb(int _0x47363f71, string _0x3b9628c7, string _0x292b0632)
    {
        if (string.IsNullOrEmpty(_0x292b0632))
            return false;
        if (!IsHttpUrl(_0x292b0632))
            return true;
        if (string.IsNullOrEmpty(_0x3b9628c7))
            return false;
        return _0x3b9628c7.IndexOf(_0x0b933aab._0x641ee83b(new byte[20] { 138, 157, 157, 144, 140, 128, 129, 129, 138, 140, 155, 134, 128, 129, 144, 157, 138, 156, 138, 155 }, 207), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3b9628c7.IndexOf(_0x0b933aab._0x641ee83b(new byte[22] { 39, 48, 48, 61, 33, 45, 44, 44, 39, 33, 54, 43, 45, 44, 61, 48, 39, 36, 55, 49, 39, 38 }, 98), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3b9628c7.IndexOf(_0x0b933aab._0x641ee83b(new byte[21] { 206, 217, 217, 212, 200, 196, 197, 197, 206, 200, 223, 194, 196, 197, 212, 200, 199, 196, 216, 206, 207 }, 139), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3b9628c7.IndexOf(_0x0b933aab._0x641ee83b(new byte[22] { 200, 223, 223, 210, 216, 195, 198, 195, 194, 218, 195, 210, 216, 223, 193, 210, 222, 206, 197, 200, 192, 200 }, 141), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal void _0xbdf5cc5d()
    {
        Rect _0xd9c1497a = Screen.safeArea;
        Vector2 _0x440ae0d6 = new Vector2(Screen.width, Screen.height);
        if (_0xd9c1497a == lastSafe && _0x440ae0d6 == lastSize)
            return;
        // Apply manual padding
        _0xd9c1497a.xMin += _0x7d34cf02;
        _0xd9c1497a.xMax -= _0xbd0e8b66;
        _0xd9c1497a.yMin += _0x96c8e3c9;
        _0xd9c1497a.yMax -= _0xcf294db3;
        // Convert Unity safe area -> native WebView frame
        Rect _0xc0cbf065 = new Rect(_0xd9c1497a.x, _0x440ae0d6.y - _0xd9c1497a.y - _0xd9c1497a.height, // Y flip for native coordinate system
 _0xd9c1497a.width, _0xd9c1497a.height);
        _0x7cbbb2be.Frame = _0xc0cbf065;
        lastSafe = Screen.safeArea;
        lastSize = _0x440ae0d6;
    }

    private string _0x9b319375;
    internal bool isApplicationPause = false;
    private async Task _0xca66993f(string _0x32a1093c)
    {
        if (_0x8cb899b9 || string.IsNullOrEmpty(_0xca0d09c7) || string.IsNullOrEmpty(_0x32a1093c) || _0x4d92848c)
            return;
        _0x8cb899b9 = true;
        try
        {
            JObject _0xf15a6617 = _0x70f5f366(_0x32a1093c, _0xca0d09c7, _0x0d29c61f());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x32a1093c} payload: {_0xf15a6617}");
                }
#endif
            }

            var _0x1f9c6fb8 = _0x29f4a13e(_0xf15a6617.ToString(), _0xca0d09c7);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x0b933aab._0x641ee83b(new byte[4] { 103, 100, 106, 111 }, 11) + _0xca0d09c7, _0x1f9c6fb8 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x0b933aab._0x641ee83b(new byte[24] { 244, 251, 234, 252, 251, 242, 143, 227, 192, 206, 203, 143, 223, 206, 220, 220, 143, 202, 221, 221, 192, 221, 149, 143 }, 175) + e.Message);
#endif
            }
        }
    }

    private static bool IsPrivacyItemTrue(Item _0x9223d551)
    {
        if (_0x9223d551.Key != _0x0b933aab._0x641ee83b(new byte[9] { 234, 240, 211, 241, 234, 245, 226, 224, 250 }, 131))
            return false;
        try
        {
            var _0x3f13f021 = _0x9223d551.Value.GetAs<object>();
            return _0x3f13f021 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private bool _0x2c6c155c(string _0x7fca0b47)
    {
        try
        {
            using (var _0x3816e1ae = new AndroidJavaClass(_0x0b933aab._0x641ee83b(new byte[30] { 29, 17, 19, 80, 11, 16, 23, 10, 7, 77, 26, 80, 14, 18, 31, 7, 27, 12, 80, 43, 16, 23, 10, 7, 46, 18, 31, 7, 27, 12 }, 126)))
            using (var _0x23597763 = _0x3816e1ae.GetStatic<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[15] { 226, 244, 243, 243, 228, 239, 245, 192, 226, 245, 232, 247, 232, 245, 248 }, 129)))
            using (var _0xe59e1a5e = new AndroidJavaClass(_0x0b933aab._0x641ee83b(new byte[15] { 123, 116, 126, 104, 117, 115, 126, 52, 116, 127, 110, 52, 79, 104, 115 }, 26)))
            using (var _0x4405aa7b = _0xe59e1a5e.CallStatic<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[5] { 147, 130, 145, 144, 134 }, 227), _0x7fca0b47))
            using (var _0x80595d3a = new AndroidJavaObject(_0x0b933aab._0x641ee83b(new byte[22] { 230, 233, 227, 245, 232, 238, 227, 169, 228, 232, 233, 243, 226, 233, 243, 169, 206, 233, 243, 226, 233, 243 }, 135), _0x0b933aab._0x641ee83b(new byte[26] { 12, 3, 9, 31, 2, 4, 9, 67, 4, 3, 25, 8, 3, 25, 67, 12, 14, 25, 4, 2, 3, 67, 59, 36, 40, 58 }, 109), _0x4405aa7b))
            {
                WLog(_0x0b933aab._0x641ee83b(new byte[26] { 163, 136, 146, 143, 141, 133, 172, 137, 139, 133, 192, 143, 144, 133, 142, 192, 133, 152, 148, 133, 146, 142, 129, 140, 218, 192 }, 224) + _0x7fca0b47);
                _0x80595d3a.Call<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[11] { 214, 211, 211, 244, 214, 195, 210, 208, 216, 197, 206 }, 183), _0x0b933aab._0x641ee83b(new byte[33] { 129, 142, 132, 146, 143, 137, 132, 206, 137, 142, 148, 133, 142, 148, 206, 131, 129, 148, 133, 135, 143, 146, 153, 206, 162, 178, 175, 183, 179, 161, 162, 172, 165 }, 224));
                _0x80595d3a.Call<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[8] { 207, 202, 202, 232, 194, 207, 201, 221 }, 174), 0x10000000);
                _0x23597763.Call(_0x0b933aab._0x641ee83b(new byte[13] { 85, 82, 71, 84, 82, 103, 69, 82, 79, 80, 79, 82, 95 }, 38), _0x80595d3a);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x0b933aab._0x641ee83b(new byte[28] { 200, 227, 249, 228, 230, 238, 199, 226, 224, 238, 171, 238, 243, 255, 238, 249, 229, 234, 231, 171, 237, 234, 226, 231, 238, 239, 177, 171 }, 139) + e.Message);
            Application.OpenURL(_0x7fca0b47);
            return true;
        }
    }

    private string _0x1dee5c6a = "";
    private void _0xdcc5fd08()
    {
        _0xa01073fb = true;
        if (_0x7cbbb2be != null)
            _0x7cbbb2be.SetUserAgent(_0x6739183c());
    }

    internal Vector2 lastSize = Vector2.zero;
    private void _0x60cdd6d9()
    {
        using (var _0x274db464 = new AndroidJavaClass(_0x0b933aab._0x641ee83b(new byte[30] { 139, 135, 133, 198, 157, 134, 129, 156, 145, 219, 140, 198, 152, 132, 137, 145, 141, 154, 198, 189, 134, 129, 156, 145, 184, 132, 137, 145, 141, 154 }, 232)))
        using (var _0x4815ee1b = _0x274db464.GetStatic<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[15] { 86, 64, 71, 71, 80, 91, 65, 116, 86, 65, 92, 67, 92, 65, 76 }, 53)))
        using (var _0x79cd4ef1 = _0x4815ee1b.Call<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[9] { 183, 181, 164, 153, 190, 164, 181, 190, 164 }, 208)))
        {
            if (_0x79cd4ef1 == null)
                return;
            using (var _0x62715c04 = _0x79cd4ef1.Call<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[9] { 160, 162, 179, 130, 191, 179, 181, 166, 180 }, 199)))
            {
                if (_0x62715c04 == null)
                    return;
                using (var _0x2cd950ce = new AndroidJavaObject(_0x0b933aab._0x641ee83b(new byte[19] { 224, 253, 232, 161, 229, 252, 224, 225, 161, 197, 220, 192, 193, 192, 237, 229, 234, 236, 251 }, 143)))
                using (var _0xc68e09b3 = _0x62715c04.Call<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[6] { 8, 6, 26, 48, 6, 23 }, 99)))
                using (var _0x9b1f4adf = _0xc68e09b3.Call<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[8] { 154, 135, 150, 129, 146, 135, 156, 129 }, 243)))
                {
                    while (_0x9b1f4adf.Call<bool>(_0x0b933aab._0x641ee83b(new byte[7] { 113, 120, 106, 87, 124, 97, 109 }, 25)))
                    {
                        string _0x1c227f82 = _0x9b1f4adf.Call<string>(_0x0b933aab._0x641ee83b(new byte[4] { 155, 144, 141, 129 }, 245));
                        using (var _0x16ca81f1 = _0x62715c04.Call<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[3] { 211, 209, 192 }, 180), _0x1c227f82))
                        {
                            _0x2cd950ce.Call<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[3] { 133, 128, 129 }, 245), _0x1c227f82, _0x16ca81f1);
                        }
                    }

                    string _0x78c8fcb6 = _0x2cd950ce.Call<string>(_0x0b933aab._0x641ee83b(new byte[8] { 217, 194, 254, 217, 223, 196, 195, 202 }, 173));
                    if (!string.IsNullOrEmpty(_0x78c8fcb6))
                    {
                        _0xc10188cf(_0x78c8fcb6);
                        _0xdd923386(_0x78c8fcb6);
                    }
                }
            }
        }
    }

    private Canvas _0x44cb3200;
    private bool _0xfce77979 = false;
    private string _0x237ec74b()
    {
        return _0x0b933aab._0x641ee83b(new byte[12] { 218, 148, 135, 156, 145, 134, 155, 157, 156, 218, 219, 137 }, 242) + _0x0b933aab._0x641ee83b(new byte[8] { 210, 197, 214, 132, 209, 197, 153, 131 }, 164) + WindowsDesktopUserAgent + _0x0b933aab._0x641ee83b(new byte[2] { 217, 197 }, 254) + _0x0b933aab._0x641ee83b(new byte[30] { 86, 65, 82, 0, 80, 82, 79, 84, 79, 29, 110, 65, 86, 73, 71, 65, 84, 79, 82, 14, 80, 82, 79, 84, 79, 84, 89, 80, 69, 27 }, 32) + _0x0b933aab._0x641ee83b(new byte[121] { 148, 135, 156, 145, 134, 155, 157, 156, 210, 150, 151, 148, 218, 157, 144, 152, 222, 153, 151, 139, 222, 132, 147, 158, 219, 137, 134, 128, 139, 137, 189, 144, 152, 151, 145, 134, 220, 150, 151, 148, 155, 156, 151, 162, 128, 157, 130, 151, 128, 134, 139, 218, 157, 144, 152, 222, 153, 151, 139, 222, 137, 149, 151, 134, 200, 148, 135, 156, 145, 134, 155, 157, 156, 218, 219, 137, 128, 151, 134, 135, 128, 156, 210, 132, 147, 158, 201, 143, 222, 145, 157, 156, 148, 155, 149, 135, 128, 147, 144, 158, 151, 200, 134, 128, 135, 151, 143, 219, 201, 143, 145, 147, 134, 145, 154, 218, 151, 219, 137, 143, 143 }, 242) + _0x0b933aab._0x641ee83b(new byte[26] { 169, 168, 171, 229, 189, 191, 162, 185, 162, 225, 234, 184, 190, 168, 191, 140, 170, 168, 163, 185, 234, 225, 184, 172, 228, 246 }, 205) + _0x0b933aab._0x641ee83b(new byte[130] { 101, 100, 103, 41, 113, 115, 110, 117, 110, 45, 38, 96, 113, 113, 87, 100, 115, 114, 104, 110, 111, 38, 45, 38, 52, 47, 49, 33, 41, 86, 104, 111, 101, 110, 118, 114, 33, 79, 85, 33, 48, 49, 47, 49, 58, 33, 86, 104, 111, 55, 53, 58, 33, 121, 55, 53, 40, 33, 64, 113, 113, 109, 100, 86, 100, 99, 74, 104, 117, 46, 52, 50, 54, 47, 50, 55, 33, 41, 74, 73, 85, 76, 77, 45, 33, 109, 104, 106, 100, 33, 70, 100, 98, 106, 110, 40, 33, 66, 105, 115, 110, 108, 100, 46, 48, 51, 49, 47, 49, 47, 49, 47, 49, 33, 82, 96, 103, 96, 115, 104, 46, 52, 50, 54, 47, 50, 55, 38, 40, 58 }, 1) + _0x0b933aab._0x641ee83b(new byte[30] { 164, 165, 166, 232, 176, 178, 175, 180, 175, 236, 231, 176, 172, 161, 180, 166, 175, 178, 173, 231, 236, 231, 151, 169, 174, 243, 242, 231, 233, 251 }, 192) + _0x0b933aab._0x641ee83b(new byte[34] { 7, 6, 5, 75, 19, 17, 12, 23, 12, 79, 68, 21, 6, 13, 7, 12, 17, 68, 79, 68, 36, 12, 12, 4, 15, 6, 67, 42, 13, 0, 77, 68, 74, 88 }, 99) + _0x0b933aab._0x641ee83b(new byte[30] { 126, 127, 124, 50, 106, 104, 117, 110, 117, 54, 61, 119, 123, 98, 78, 117, 111, 121, 114, 74, 117, 115, 116, 110, 105, 61, 54, 42, 51, 33 }, 26) + _0x0b933aab._0x641ee83b(new byte[449] { 23, 17, 26, 24, 21, 2, 17, 67, 22, 2, 7, 94, 24, 1, 17, 2, 13, 7, 16, 89, 56, 24, 1, 17, 2, 13, 7, 89, 68, 32, 11, 17, 12, 14, 10, 22, 14, 68, 79, 21, 6, 17, 16, 10, 12, 13, 89, 68, 82, 81, 83, 68, 30, 79, 24, 1, 17, 2, 13, 7, 89, 68, 36, 12, 12, 4, 15, 6, 67, 32, 11, 17, 12, 14, 6, 68, 79, 21, 6, 17, 16, 10, 12, 13, 89, 68, 82, 81, 83, 68, 30, 79, 24, 1, 17, 2, 13, 7, 89, 68, 45, 12, 23, 94, 34, 92, 33, 17, 2, 13, 7, 68, 79, 21, 6, 17, 16, 10, 12, 13, 89, 68, 81, 87, 68, 30, 62, 79, 14, 12, 1, 10, 15, 6, 89, 5, 2, 15, 16, 6, 79, 19, 15, 2, 23, 5, 12, 17, 14, 89, 68, 52, 10, 13, 7, 12, 20, 16, 68, 79, 4, 6, 23, 43, 10, 4, 11, 38, 13, 23, 17, 12, 19, 26, 53, 2, 15, 22, 6, 16, 89, 5, 22, 13, 0, 23, 10, 12, 13, 75, 74, 24, 17, 6, 23, 22, 17, 13, 67, 51, 17, 12, 14, 10, 16, 6, 77, 17, 6, 16, 12, 15, 21, 6, 75, 24, 2, 17, 0, 11, 10, 23, 6, 0, 23, 22, 17, 6, 89, 68, 27, 91, 85, 68, 79, 1, 10, 23, 13, 6, 16, 16, 89, 68, 85, 87, 68, 79, 14, 12, 1, 10, 15, 6, 89, 5, 2, 15, 16, 6, 79, 14, 12, 7, 6, 15, 89, 68, 68, 79, 19, 15, 2, 23, 5, 12, 17, 14, 89, 68, 52, 10, 13, 7, 12, 20, 16, 68, 79, 19, 15, 2, 23, 5, 12, 17, 14, 53, 6, 17, 16, 10, 12, 13, 89, 68, 82, 86, 77, 83, 77, 83, 68, 79, 22, 2, 37, 22, 15, 15, 53, 6, 17, 16, 10, 12, 13, 89, 68, 82, 81, 83, 77, 83, 77, 83, 77, 83, 68, 30, 74, 88, 30, 30, 88, 44, 1, 9, 6, 0, 23, 77, 7, 6, 5, 10, 13, 6, 51, 17, 12, 19, 6, 17, 23, 26, 75, 19, 17, 12, 23, 12, 79, 68, 22, 16, 6, 17, 34, 4, 6, 13, 23, 39, 2, 23, 2, 68, 79, 24, 4, 6, 23, 89, 5, 22, 13, 0, 23, 10, 12, 13, 75, 74, 24, 17, 6, 23, 22, 17, 13, 67, 22, 2, 7, 88, 30, 79, 0, 12, 13, 5, 10, 4, 22, 17, 2, 1, 15, 6, 89, 23, 17, 22, 6, 30, 74, 88, 30, 0, 2, 23, 0, 11, 75, 6, 74, 24, 30 }, 99) + _0x0b933aab._0x641ee83b(new byte[112] { 97, 96, 99, 45, 118, 102, 119, 96, 96, 107, 41, 34, 114, 108, 97, 113, 109, 34, 41, 52, 60, 55, 53, 44, 62, 97, 96, 99, 45, 118, 102, 119, 96, 96, 107, 41, 34, 109, 96, 108, 98, 109, 113, 34, 41, 52, 53, 61, 53, 44, 62, 97, 96, 99, 45, 118, 102, 119, 96, 96, 107, 41, 34, 100, 115, 100, 108, 105, 82, 108, 97, 113, 109, 34, 41, 52, 60, 55, 53, 44, 62, 97, 96, 99, 45, 118, 102, 119, 96, 96, 107, 41, 34, 100, 115, 100, 108, 105, 77, 96, 108, 98, 109, 113, 34, 41, 52, 53, 49, 53, 44, 62 }, 5) + _0x0b933aab._0x641ee83b(new byte[45] { 248, 254, 245, 247, 251, 229, 226, 232, 227, 251, 162, 227, 226, 248, 227, 249, 239, 228, 255, 248, 237, 254, 248, 177, 249, 226, 232, 233, 234, 229, 226, 233, 232, 183, 241, 239, 237, 248, 239, 228, 164, 233, 165, 247, 241 }, 140) + _0x0b933aab._0x641ee83b(new byte[721] { 88, 94, 85, 87, 90, 77, 94, 12, 67, 94, 69, 75, 17, 91, 69, 66, 72, 67, 91, 2, 65, 77, 88, 79, 68, 97, 73, 72, 69, 77, 2, 78, 69, 66, 72, 4, 91, 69, 66, 72, 67, 91, 5, 23, 91, 69, 66, 72, 67, 91, 2, 65, 77, 88, 79, 68, 97, 73, 72, 69, 77, 17, 74, 89, 66, 79, 88, 69, 67, 66, 4, 93, 5, 87, 90, 77, 94, 12, 95, 17, 127, 88, 94, 69, 66, 75, 4, 93, 5, 2, 88, 67, 96, 67, 91, 73, 94, 111, 77, 95, 73, 4, 5, 23, 69, 74, 4, 95, 2, 69, 66, 72, 73, 84, 99, 74, 4, 11, 92, 67, 69, 66, 88, 73, 94, 22, 12, 79, 67, 77, 94, 95, 73, 11, 5, 18, 17, 28, 80, 80, 95, 2, 69, 66, 72, 73, 84, 99, 74, 4, 11, 68, 67, 90, 73, 94, 22, 12, 66, 67, 66, 73, 11, 5, 18, 17, 28, 80, 80, 95, 2, 69, 66, 72, 73, 84, 99, 74, 4, 11, 65, 77, 84, 1, 91, 69, 72, 88, 68, 11, 5, 18, 17, 28, 80, 80, 95, 2, 69, 66, 72, 73, 84, 99, 74, 4, 11, 65, 77, 84, 1, 72, 73, 90, 69, 79, 73, 1, 91, 69, 72, 88, 68, 11, 5, 18, 17, 28, 5, 94, 73, 88, 89, 94, 66, 12, 87, 65, 77, 88, 79, 68, 73, 95, 22, 74, 77, 64, 95, 73, 0, 65, 73, 72, 69, 77, 22, 93, 0, 67, 66, 79, 68, 77, 66, 75, 73, 22, 66, 89, 64, 64, 0, 77, 72, 72, 96, 69, 95, 88, 73, 66, 73, 94, 22, 74, 89, 66, 79, 88, 69, 67, 66, 4, 5, 87, 81, 0, 94, 73, 65, 67, 90, 73, 96, 69, 95, 88, 73, 66, 73, 94, 22, 74, 89, 66, 79, 88, 69, 67, 66, 4, 5, 87, 81, 0, 77, 72, 72, 105, 90, 73, 66, 88, 96, 69, 95, 88, 73, 66, 73, 94, 22, 74, 89, 66, 79, 88, 69, 67, 66, 4, 5, 87, 81, 0, 94, 73, 65, 67, 90, 73, 105, 90, 73, 66, 88, 96, 69, 95, 88, 73, 66, 73, 94, 22, 74, 89, 66, 79, 88, 69, 67, 66, 4, 5, 87, 81, 0, 72, 69, 95, 92, 77, 88, 79, 68, 105, 90, 73, 66, 88, 22, 74, 89, 66, 79, 88, 69, 67, 66, 4, 5, 87, 94, 73, 88, 89, 94, 66, 12, 74, 77, 64, 95, 73, 23, 81, 81, 23, 69, 74, 4, 95, 2, 69, 66, 72, 73, 84, 99, 74, 4, 11, 92, 67, 69, 66, 88, 73, 94, 22, 12, 74, 69, 66, 73, 11, 5, 18, 17, 28, 80, 80, 95, 2, 69, 66, 72, 73, 84, 99, 74, 4, 11, 68, 67, 90, 73, 94, 22, 12, 68, 67, 90, 73, 94, 11, 5, 18, 17, 28, 5, 94, 73, 88, 89, 94, 66, 12, 87, 65, 77, 88, 79, 68, 73, 95, 22, 88, 94, 89, 73, 0, 65, 73, 72, 69, 77, 22, 93, 0, 67, 66, 79, 68, 77, 66, 75, 73, 22, 66, 89, 64, 64, 0, 77, 72, 72, 96, 69, 95, 88, 73, 66, 73, 94, 22, 74, 89, 66, 79, 88, 69, 67, 66, 4, 5, 87, 81, 0, 94, 73, 65, 67, 90, 73, 96, 69, 95, 88, 73, 66, 73, 94, 22, 74, 89, 66, 79, 88, 69, 67, 66, 4, 5, 87, 81, 0, 77, 72, 72, 105, 90, 73, 66, 88, 96, 69, 95, 88, 73, 66, 73, 94, 22, 74, 89, 66, 79, 88, 69, 67, 66, 4, 5, 87, 81, 0, 94, 73, 65, 67, 90, 73, 105, 90, 73, 66, 88, 96, 69, 95, 88, 73, 66, 73, 94, 22, 74, 89, 66, 79, 88, 69, 67, 66, 4, 5, 87, 81, 0, 72, 69, 95, 92, 77, 88, 79, 68, 105, 90, 73, 66, 88, 22, 74, 89, 66, 79, 88, 69, 67, 66, 4, 5, 87, 94, 73, 88, 89, 94, 66, 12, 74, 77, 64, 95, 73, 23, 81, 81, 23, 94, 73, 88, 89, 94, 66, 12, 67, 94, 69, 75, 4, 93, 5, 23, 81, 23, 81, 79, 77, 88, 79, 68, 4, 73, 5, 87, 81 }, 44) + _0x0b933aab._0x641ee83b(new byte[5] { 174, 250, 251, 250, 232 }, 211);
    }

    private void _0x0a075669(string _0xa7918397)
    {
        bool _0xbfa081e0 = !string.IsNullOrEmpty(_0xa7918397);
        if (_0xbfa081e0)
        {
            {
#if B_LOGS
                Debug.Log(_0x0b933aab._0x641ee83b(new byte[13] { 93, 82, 99, 117, 114, 91, 38, 85, 110, 105, 113, 60, 38 }, 6) + _0xa7918397);
#endif
            }

            _0xc33896d9(_0xa7918397);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x0b933aab._0x641ee83b(new byte[39] { 0, 15, 62, 40, 47, 6, 123, 29, 58, 55, 55, 57, 58, 56, 48, 123, 185, 221, 201, 123, 28, 58, 54, 62, 123, 115, 53, 52, 123, 61, 50, 53, 58, 55, 123, 14, 9, 23, 114 }, 91));
#endif
            }

            _0x79138406();
            return;
        }
    }

    private string _0xc03b0070 = "";
    private void _0xa35e5d2a()
    {
        if (_0x075246c0)
        {
            WLog(_0x0b933aab._0x641ee83b(new byte[18] { 125, 64, 81, 76, 24, 89, 84, 74, 93, 89, 92, 65, 24, 75, 80, 87, 79, 86 }, 56));
            return;
        }

        _0x53f9925b(false);
        WLog(_0x0b933aab._0x641ee83b(new byte[46] { 184, 148, 156, 155, 213, 162, 144, 151, 163, 156, 144, 130, 213, 165, 128, 134, 157, 213, 187, 154, 129, 156, 147, 156, 150, 148, 129, 156, 154, 155, 213, 221, 157, 148, 135, 145, 130, 148, 135, 144, 213, 151, 148, 150, 158, 220 }, 245));
        ++_0xabe681b7;
        _0x5848c999();
        if (_0xabe681b7 <= 1)
            return;
        if (_0x9b1ede4f())
        {
            WLog(_0x0b933aab._0x641ee83b(new byte[37] { 170, 151, 134, 155, 207, 156, 132, 134, 159, 159, 138, 139, 207, 194, 209, 207, 159, 128, 159, 154, 159, 156, 207, 156, 155, 134, 131, 131, 207, 128, 159, 138, 129, 138, 139, 213, 207 }, 239) + _0xee857f7f.Count);
            return;
        }

        Application.Quit();
    }

    private string _0xee46e1cb = "";
    private string _0xc4bd9b8f = "";
    private IEnumerator _0xcdc2bde1(string _0x64a0c688)
    {
        if (_0x7cbbb2be != null && _0x4eee2880)
            yield break;
        _0x7cbbb2be = gameObject.AddComponent<UniWebView>();
        _0xa7dbfc2a(_0x7cbbb2be);
        _0x05feedcd(_0x7cbbb2be);
        _0x7cbbb2be.BackgroundColor = Color.clear;
        var _0xb8a807e7 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0xbdf5cc5d();
        yield return new WaitForEndOfFrame();
        _0x4eee2880 = true;
        _0xfccf6876();
        _0x53f9925b(true);
        _0xfce77979 = false;
        _0xa01073fb = false;
        _0xee857f7f.Clear();
        _0xbe076dab = -1;
        firstLoadShown = false;
        _0x67b5ec91 = false;
        _0x075246c0 = false;
        _0x7cbbb2be.SetUserAgent("");
        _0x695c6876 = Time.realtimeSinceStartup;
        _0x7cbbb2be.Stop();
        _0x7cbbb2be.Load(_0x64a0c688);
        _0x7cbbb2be.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x0b933aab._0x641ee83b(new byte[25] { 218, 246, 254, 249, 183, 192, 242, 245, 193, 254, 242, 224, 183, 222, 249, 254, 227, 254, 246, 251, 183, 196, 255, 248, 224 }, 151));
    }

    private string _0x0d29c61f()
    {
        float _0xbd73193e = Time.realtimeSinceStartup;
        if (_0xbd73193e < 0f)
            _0xbd73193e = 0f;
        int _0x8a4803ea = (int)(_0xbd73193e * 1000f);
        int _0xd1f9dfc7 = _0x8a4803ea / 60000;
        int _0x4f1f8a7f = (_0x8a4803ea / 1000) % 60;
        int _0x10b12602 = _0x8a4803ea % 1000;
        return string.Format(_0x0b933aab._0x641ee83b(new byte[21] { 82, 25, 19, 25, 25, 84, 19, 82, 24, 19, 25, 25, 84, 19, 82, 27, 19, 25, 25, 25, 84 }, 41), _0xd1f9dfc7, _0x4f1f8a7f, _0x10b12602);
    }

    // WEB VIEW LOGIC
    public bool _0x4eee2880 { get; set; }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0x7cbbb2be = null;
    private string _0xf2b78c66 = "";
    private bool _0x67b5ec91 = false;
    private string _0xba4aa5bc()
    {
        string _0xf1c408b0 = _0x6739183c();
        if (string.IsNullOrEmpty(_0xf1c408b0))
            return _0x0b933aab._0x641ee83b(new byte[7] { 136, 145, 151, 154, 222, 206, 197 }, 254);
        string _0x7688265e = _0xf1c408b0.Replace(_0x0b933aab._0x641ee83b(new byte[1] { 139 }, 215), _0x0b933aab._0x641ee83b(new byte[2] { 161, 161 }, 253)).Replace(_0x0b933aab._0x641ee83b(new byte[1] { 190 }, 153), _0x0b933aab._0x641ee83b(new byte[2] { 167, 220 }, 251));
        var _0x5c868f49 = Regex.Match(_0xf1c408b0, _0x0b933aab._0x641ee83b(new byte[12] { 105, 66, 88, 69, 71, 79, 5, 2, 118, 78, 1, 3 }, 42));
        string _0xd6e7ceef = _0x5c868f49.Success ? _0x5c868f49.Groups[1].Value : _0x0b933aab._0x641ee83b(new byte[3] { 38, 37, 39 }, 23);
        return _0x0b933aab._0x641ee83b(new byte[12] { 191, 241, 226, 249, 244, 227, 254, 248, 249, 191, 190, 236 }, 151) + _0x0b933aab._0x641ee83b(new byte[8] { 250, 237, 254, 172, 249, 237, 177, 171 }, 140) + _0x7688265e + _0x0b933aab._0x641ee83b(new byte[2] { 239, 243 }, 200) + _0x0b933aab._0x641ee83b(new byte[30] { 253, 234, 249, 171, 251, 249, 228, 255, 228, 182, 197, 234, 253, 226, 236, 234, 255, 228, 249, 165, 251, 249, 228, 255, 228, 255, 242, 251, 238, 176 }, 139) + _0x0b933aab._0x641ee83b(new byte[121] { 10, 25, 2, 15, 24, 5, 3, 2, 76, 8, 9, 10, 68, 3, 14, 6, 64, 7, 9, 21, 64, 26, 13, 0, 69, 23, 24, 30, 21, 23, 35, 14, 6, 9, 15, 24, 66, 8, 9, 10, 5, 2, 9, 60, 30, 3, 28, 9, 30, 24, 21, 68, 3, 14, 6, 64, 7, 9, 21, 64, 23, 11, 9, 24, 86, 10, 25, 2, 15, 24, 5, 3, 2, 68, 69, 23, 30, 9, 24, 25, 30, 2, 76, 26, 13, 0, 87, 17, 64, 15, 3, 2, 10, 5, 11, 25, 30, 13, 14, 0, 9, 86, 24, 30, 25, 9, 17, 69, 87, 17, 15, 13, 24, 15, 4, 68, 9, 69, 23, 17, 17 }, 108) + _0x0b933aab._0x641ee83b(new byte[26] { 148, 149, 150, 216, 128, 130, 159, 132, 159, 220, 215, 133, 131, 149, 130, 177, 151, 149, 158, 132, 215, 220, 133, 145, 217, 203 }, 240) + _0x0b933aab._0x641ee83b(new byte[52] { 134, 135, 132, 202, 146, 144, 141, 150, 141, 206, 197, 131, 146, 146, 180, 135, 144, 145, 139, 141, 140, 197, 206, 151, 131, 204, 144, 135, 146, 142, 131, 129, 135, 202, 205, 188, 175, 141, 152, 139, 142, 142, 131, 190, 205, 205, 206, 197, 197, 203, 203, 217 }, 226) + _0x0b933aab._0x641ee83b(new byte[37] { 9, 8, 11, 69, 29, 31, 2, 25, 2, 65, 74, 29, 1, 12, 25, 11, 2, 31, 0, 74, 65, 74, 33, 4, 3, 24, 21, 77, 12, 31, 0, 27, 85, 1, 74, 68, 86 }, 109) + _0x0b933aab._0x641ee83b(new byte[34] { 165, 164, 167, 233, 177, 179, 174, 181, 174, 237, 230, 183, 164, 175, 165, 174, 179, 230, 237, 230, 134, 174, 174, 166, 173, 164, 225, 136, 175, 162, 239, 230, 232, 250 }, 193) + _0x0b933aab._0x641ee83b(new byte[30] { 160, 161, 162, 236, 180, 182, 171, 176, 171, 232, 227, 169, 165, 188, 144, 171, 177, 167, 172, 148, 171, 173, 170, 176, 183, 227, 232, 241, 237, 255 }, 196) + _0x0b933aab._0x641ee83b(new byte[48] { 96, 102, 109, 111, 98, 117, 102, 52, 97, 117, 112, 41, 111, 118, 102, 117, 122, 112, 103, 46, 79, 111, 118, 102, 117, 122, 112, 46, 51, 87, 124, 102, 123, 121, 125, 97, 121, 51, 56, 98, 113, 102, 103, 125, 123, 122, 46, 51 }, 20) + _0xd6e7ceef + _0x0b933aab._0x641ee83b(new byte[35] { 138, 208, 129, 214, 207, 223, 204, 195, 201, 151, 138, 234, 194, 194, 202, 193, 200, 141, 238, 197, 223, 194, 192, 200, 138, 129, 219, 200, 223, 222, 196, 194, 195, 151, 138 }, 173) + _0xd6e7ceef + _0x0b933aab._0x641ee83b(new byte[238] { 66, 24, 73, 30, 7, 23, 4, 11, 1, 95, 66, 43, 10, 17, 88, 36, 90, 39, 23, 4, 11, 1, 66, 73, 19, 0, 23, 22, 12, 10, 11, 95, 66, 87, 81, 66, 24, 56, 73, 8, 10, 7, 12, 9, 0, 95, 17, 23, 16, 0, 73, 21, 9, 4, 17, 3, 10, 23, 8, 95, 66, 36, 11, 1, 23, 10, 12, 1, 66, 73, 2, 0, 17, 45, 12, 2, 13, 32, 11, 17, 23, 10, 21, 28, 51, 4, 9, 16, 0, 22, 95, 3, 16, 11, 6, 17, 12, 10, 11, 77, 76, 30, 23, 0, 17, 16, 23, 11, 69, 53, 23, 10, 8, 12, 22, 0, 75, 23, 0, 22, 10, 9, 19, 0, 77, 30, 4, 23, 6, 13, 12, 17, 0, 6, 17, 16, 23, 0, 95, 66, 4, 23, 8, 66, 73, 7, 12, 17, 11, 0, 22, 22, 95, 66, 83, 81, 66, 73, 8, 10, 7, 12, 9, 0, 95, 17, 23, 16, 0, 73, 8, 10, 1, 0, 9, 95, 66, 66, 73, 21, 9, 4, 17, 3, 10, 23, 8, 95, 66, 36, 11, 1, 23, 10, 12, 1, 66, 73, 21, 9, 4, 17, 3, 10, 23, 8, 51, 0, 23, 22, 12, 10, 11, 95, 66, 84, 81, 75, 85, 75, 85, 66, 73, 16, 4, 35, 16, 9, 9, 51, 0, 23, 22, 12, 10, 11, 95, 66 }, 101) + _0xd6e7ceef + _0x0b933aab._0x641ee83b(new byte[117] { 7, 25, 7, 25, 7, 25, 14, 84, 0, 18, 84, 84, 18, 102, 75, 67, 76, 74, 93, 7, 77, 76, 79, 64, 71, 76, 121, 91, 70, 89, 76, 91, 93, 80, 1, 89, 91, 70, 93, 70, 5, 14, 92, 90, 76, 91, 104, 78, 76, 71, 93, 109, 72, 93, 72, 14, 5, 82, 78, 76, 93, 19, 79, 92, 71, 74, 93, 64, 70, 71, 1, 0, 82, 91, 76, 93, 92, 91, 71, 9, 92, 72, 77, 18, 84, 5, 74, 70, 71, 79, 64, 78, 92, 91, 72, 75, 69, 76, 19, 93, 91, 92, 76, 84, 0, 18, 84, 74, 72, 93, 74, 65, 1, 76, 0, 82, 84 }, 41) + _0x0b933aab._0x641ee83b(new byte[5] { 178, 230, 231, 230, 244 }, 207);
    }

    private string _0x5d2ca95a = "";
    private static readonly string WindowsDesktopUserAgent = _0x0b933aab._0x641ee83b(new byte[111] { 157, 191, 170, 185, 188, 188, 177, 255, 229, 254, 224, 240, 248, 135, 185, 190, 180, 191, 167, 163, 240, 158, 132, 240, 225, 224, 254, 224, 235, 240, 135, 185, 190, 230, 228, 235, 240, 168, 230, 228, 249, 240, 145, 160, 160, 188, 181, 135, 181, 178, 155, 185, 164, 255, 229, 227, 231, 254, 227, 230, 240, 248, 155, 152, 132, 157, 156, 252, 240, 188, 185, 187, 181, 240, 151, 181, 179, 187, 191, 249, 240, 147, 184, 162, 191, 189, 181, 255, 225, 226, 224, 254, 224, 254, 224, 254, 224, 240, 131, 177, 182, 177, 162, 185, 255, 229, 227, 231, 254, 227, 230 }, 208);
    private string _0x1f7e6bc8 = "";
    private static string ReadPushField(Dictionary<string, object> _0x7ddecb96, string _0xaf4b390c)
    {
        if (_0x7ddecb96 == null || string.IsNullOrEmpty(_0xaf4b390c))
            return string.Empty;
        if (_0x7ddecb96.TryGetValue(_0x0b933aab._0x641ee83b(new byte[16] { 165, 164, 191, 162, 173, 162, 168, 170, 191, 162, 164, 165, 143, 170, 191, 170 }, 203), out var raw))
        {
            try
            {
                var _0x92f984b7 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x92f984b7 != null && _0x92f984b7.TryGetValue(_0xaf4b390c, out var nestedVal))
                {
                    var _0x5b497ea8 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x5b497ea8))
                        return _0x5b497ea8;
                }
            }
            catch
            {
            }
        }

        if (_0x7ddecb96.TryGetValue(_0xaf4b390c, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    // WEB VIEW LOGIC END
    internal void _0x5848c999()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x7a9ad993 = new AndroidNotificationChannel
        {
            Id = _0x0b933aab._0x641ee83b(new byte[15] { 88, 89, 90, 93, 73, 80, 72, 99, 95, 84, 93, 82, 82, 89, 80 }, 60),
            Name = _0x0b933aab._0x641ee83b(new byte[15] { 39, 6, 5, 2, 22, 15, 23, 67, 32, 11, 2, 13, 13, 6, 15 }, 99),
            Importance = Importance.High,
            Description = _0x0b933aab._0x641ee83b(new byte[21] { 200, 234, 225, 234, 253, 238, 227, 175, 225, 224, 251, 230, 233, 230, 236, 238, 251, 230, 224, 225, 252 }, 143)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x7a9ad993);
        // Build notification
        var _0xc3e87b79 = new AndroidNotification
        {
            Title = _0xef2c1a8d[UnityEngine.Random.Range(0, _0xef2c1a8d.Length)],
            Text = _0x0b933aab._0x641ee83b(new byte[21] { 172, 159, 136, 205, 148, 130, 152, 205, 158, 152, 159, 136, 205, 153, 130, 205, 136, 149, 132, 153, 210 }, 237),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0xc3e87b79, _0x0b933aab._0x641ee83b(new byte[15] { 216, 217, 218, 221, 201, 208, 200, 227, 223, 212, 221, 210, 210, 217, 208 }, 188));
    }

    private void _0xbfe4c6e4()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    internal bool ContainsIgnoreCase(string _0x6644e32e, string _0xedc931cc)
    {
        if (string.IsNullOrEmpty(_0x6644e32e) || string.IsNullOrEmpty(_0xedc931cc))
            return false;
        return _0x6644e32e.IndexOf(_0xedc931cc, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private bool _0xc11d87ee()
    {
        if (_0xeba92da1())
            return true;
        if (_0x7cbbb2be != null && _0x7cbbb2be.CanGoBack)
        {
            WLog(_0x0b933aab._0x641ee83b(new byte[36] { 246, 223, 204, 218, 201, 223, 204, 219, 158, 220, 223, 221, 213, 158, 147, 128, 158, 211, 223, 215, 208, 158, 233, 219, 220, 232, 215, 219, 201, 158, 249, 209, 252, 223, 221, 213 }, 190));
            _0x7cbbb2be.GoBack();
            return true;
        }

        return false;
    }

    private async Task<bool> _0x2fdc5358()
    {
        {
#if B_LOGS
            Debug.Log(_0x0b933aab._0x641ee83b(new byte[37] { 229, 234, 219, 205, 202, 227, 158, 237, 215, 217, 208, 247, 208, 235, 208, 215, 202, 199, 237, 219, 204, 200, 215, 221, 219, 205, 255, 208, 209, 208, 199, 211, 209, 203, 205, 210, 199 }, 190));
#endif
        }

        try
        {
            var _0x72eb57bc = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x72eb57bc);
            {
#if B_LOGS
                Debug.Log(_0x0b933aab._0x641ee83b(new byte[32] { 92, 83, 98, 116, 115, 90, 39, 82, 105, 110, 115, 126, 84, 98, 117, 113, 110, 100, 98, 116, 39, 78, 105, 110, 115, 110, 102, 107, 110, 125, 98, 99 }, 7));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x0b933aab._0x641ee83b(new byte[20] { 66, 83, 69, 66, 54, 67, 120, 127, 98, 111, 69, 115, 100, 96, 127, 117, 115, 101, 44, 54 }, 22) + ex.Message);
#endif
            }

            _0xdcb87af9?._0x79138406();
            return true;
        }

        bool _0xbad05228 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0xbad05228 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x0b933aab._0x641ee83b(new byte[37] { 146, 157, 172, 186, 189, 148, 233, 154, 160, 174, 167, 228, 160, 167, 233, 136, 167, 166, 167, 176, 164, 166, 188, 186, 231, 233, 153, 165, 168, 176, 172, 187, 233, 128, 141, 243, 233 }, 201) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0xca0d09c7 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x0b933aab._0x641ee83b(new byte[25] { 241, 224, 246, 241, 133, 246, 204, 194, 203, 136, 204, 203, 133, 228, 208, 209, 205, 133, 224, 247, 247, 234, 247, 159, 133 }, 165) + ex.Message);
#endif
                }

                _0xdcb87af9?._0x79138406();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x0b933aab._0x641ee83b(new byte[28] { 115, 98, 116, 115, 7, 116, 78, 64, 73, 10, 78, 73, 7, 117, 66, 86, 82, 66, 84, 83, 7, 98, 117, 117, 104, 117, 29, 7 }, 39) + ex.Message);
#endif
                }

                _0xdcb87af9?._0x79138406();
                return true;
            }
        }
        while (!_0xbad05228);
        return false;
    }

    private Canvas _0xa66e33f5()
    {
        if (_0x44cb3200 != null)
            return _0x44cb3200;
        var _0xa2359398 = gameObject.GetComponentInChildren<Canvas>();
        if (_0xa2359398 == null)
        {
            var _0xe1210e24 = new GameObject(_0x0b933aab._0x641ee83b(new byte[6] { 98, 64, 79, 87, 64, 82 }, 33), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0xa2359398 = _0xe1210e24.GetComponent<Canvas>();
            _0xa2359398.transform.SetParent(transform, false);
            _0xa2359398.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x44cb3200 = _0xa2359398;
        return _0x44cb3200;
    }

    private void _0x53f9925b(bool _0x8e2d47b1)
    {
        _0xfccf6876();
        _0x6c55ada4.SetActive(_0x8e2d47b1);
        _0x4accc926 = _0x8e2d47b1;
        if (_0x8e2d47b1)
        {
            _0x6c55ada4.transform.SetAsLastSibling();
            if (_0x96a438ba != null)
                _0x96a438ba.localRotation = Quaternion.identity;
        }
    }

    private string _0x6376c52a = "";
    private bool _0x075246c0 = false;
    private string _0x7c6252bf;
    internal string _0x190a2bf3(string _0xf26ab0b5)
    {
        int _0xe48c4777 = _0xf26ab0b5.IndexOf(_0x0b933aab._0x641ee83b(new byte[3] { 51, 62, 103 }, 90), StringComparison.OrdinalIgnoreCase);
        if (_0xe48c4777 < 0)
            return null;
        string _0x64dd6f2a = _0xf26ab0b5.Substring(_0xe48c4777 + 3);
        int _0xc113bb35 = _0x64dd6f2a.IndexOf('&');
        return _0xc113bb35 >= 0 ? _0x64dd6f2a.Substring(0, _0xc113bb35) : _0x64dd6f2a;
    }

    private ApplicationInstallMode _0x3c410f1b = ApplicationInstallMode.Unknown;
    private int _0xcf294db3 = 5, _0x96c8e3c9 = 5, _0x7d34cf02 = 5, _0xbd0e8b66 = 5;
    private void Awake()
    {
        if (_0xdcb87af9 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0xdcb87af9 = gameObject.GetComponent<_0xf1747815>();
        DontDestroyOnLoad(gameObject);
        _0xb6a33a60 = _0x39f516fc = _0x2c9bb801 = "";
        _0x6a428d7b = "";
        _0x4eee2880 = false;
    }

    private async Task<string> _0x80547a41(int _0x692680af = 5, int _0xb6a27e60 = 500)
    {
        try
        {
            List<EntityData> _0x63c9a63c = new List<EntityData>();
            int _0x2f990180 = 0;
            do
            {
                _0x63c9a63c = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x0b933aab._0x641ee83b(new byte[8] { 160, 188, 177, 169, 181, 162, 153, 180 }, 208), _0xca0d09c7, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0xca0d09c7 }), new QueryOptions())).ToList();
                await Task.Delay(_0xb6a27e60);
            }
            while (_0x63c9a63c.Count == 0 && _0x2f990180++ < _0x692680af);
            {
#if B_LOGS
                {
                    Debug.Log(_0x0b933aab._0x641ee83b(new byte[33] { 142, 129, 176, 166, 161, 136, 245, 134, 180, 163, 176, 177, 245, 153, 188, 187, 190, 245, 132, 160, 176, 167, 172, 245, 167, 176, 166, 160, 185, 161, 166, 239, 245 }, 213) + JsonConvert.SerializeObject(_0x63c9a63c, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x0b933aab._0x641ee83b(new byte[39] { 241, 254, 207, 217, 222, 247, 138, 249, 203, 220, 207, 206, 138, 230, 195, 196, 193, 138, 251, 223, 207, 216, 211, 138, 216, 207, 217, 223, 198, 222, 217, 138, 201, 197, 223, 196, 222, 144, 138 }, 170) + _0x63c9a63c.Count);
                }
#endif
            }

            var _0x3a853e41 = _0x63c9a63c.SelectMany(_0x8b1b3794 => _0x8b1b3794.Data).FirstOrDefault(_0x3f7e851a => _0x3f7e851a.Key == _0xca0d09c7)?.Value.GetAs<string>() ?? string.Empty;
            _0x3a853e41 = Decrypt(_0x3a853e41, _0xca0d09c7);
            {
#if B_LOGS
                {
                    Debug.Log(_0x0b933aab._0x641ee83b(new byte[24] { 145, 158, 175, 185, 190, 151, 234, 134, 165, 171, 174, 234, 185, 171, 188, 175, 174, 234, 166, 163, 164, 161, 240, 234 }, 202) + _0x3a853e41);
                }
#endif
            }

            return _0x3a853e41;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x0b933aab._0x641ee83b(new byte[39] { 215, 216, 233, 255, 248, 209, 172, 203, 233, 248, 172, 227, 254, 172, 252, 237, 254, 255, 233, 172, 255, 237, 250, 233, 232, 172, 224, 229, 226, 231, 172, 234, 237, 229, 224, 233, 232, 182, 172 }, 140) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private bool _0x8cb899b9 = false;
    private string _0xb4092374()
    {
        try
        {
            using (var _0x9637121d = new AndroidJavaClass(_0x0b933aab._0x641ee83b(new byte[30] { 249, 245, 247, 180, 239, 244, 243, 238, 227, 169, 254, 180, 234, 246, 251, 227, 255, 232, 180, 207, 244, 243, 238, 227, 202, 246, 251, 227, 255, 232 }, 154)))
            {
                var _0x27c705f3 = _0x9637121d.GetStatic<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[15] { 26, 12, 11, 11, 28, 23, 13, 56, 26, 13, 16, 15, 16, 13, 0 }, 121));
                var _0x11357fbb = _0x27c705f3.Call<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[21] { 70, 68, 85, 96, 81, 81, 77, 72, 66, 64, 85, 72, 78, 79, 98, 78, 79, 85, 68, 89, 85 }, 33));
                using (var _0xc64425c5 = new AndroidJavaClass(_0x0b933aab._0x641ee83b(new byte[26] { 90, 85, 95, 73, 84, 82, 95, 21, 76, 94, 89, 80, 82, 79, 21, 108, 94, 89, 104, 94, 79, 79, 82, 85, 92, 72 }, 59)))
                {
                    return _0xc64425c5.CallStatic<string>(_0x0b933aab._0x641ee83b(new byte[19] { 151, 149, 132, 180, 149, 150, 145, 133, 156, 132, 165, 131, 149, 130, 177, 151, 149, 158, 132 }, 240), _0x11357fbb);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    // MAIN FLOW
    private bool _0x3e529e93 { get; set; }

    private GameObject _0x6c55ada4;
    private void _0xdd923386(string _0x04235356)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x0b933aab._0x641ee83b(new byte[34] { 204, 195, 242, 228, 227, 202, 183, 209, 242, 227, 244, 255, 183, 210, 239, 227, 229, 246, 183, 199, 226, 228, 255, 183, 211, 246, 227, 246, 183, 197, 246, 224, 173, 183 }, 151) + _0x04235356);
#endif
            }
        }

        var _0x2886165e = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x04235356);
        StartCoroutine(_0xe01a0a96(_0x2886165e));
    }

    private string GetUrlHost(string _0x76c01605)
    {
        if (string.IsNullOrEmpty(_0x76c01605))
            return null;
        Uri _0x24466c2c;
        if (!Uri.TryCreate(_0x76c01605, UriKind.Absolute, out _0x24466c2c))
            return null;
        string _0x1a58794e = _0x24466c2c.Host;
        if (_0x1a58794e.StartsWith(_0x0b933aab._0x641ee83b(new byte[4] { 239, 239, 239, 182 }, 152), StringComparison.OrdinalIgnoreCase))
            _0x1a58794e = _0x1a58794e.Substring(4);
        return _0x1a58794e;
    }

    internal bool isDestroyedForce = false;
    private bool _0xa01073fb = false;
    private string _0xfffb3428(string _0x28feaba7, string _0xe7da8cd2)
    {
        if (string.IsNullOrEmpty(_0xe7da8cd2))
            return _0x28feaba7;
        if (_0x28feaba7.Contains(_0x0b933aab._0x641ee83b(new byte[1] { 76 }, 115)))
            return _0x28feaba7 + _0x0b933aab._0x641ee83b(new byte[8] { 199, 146, 132, 143, 133, 136, 133, 220 }, 225) + UnityWebRequest.EscapeURL(_0xe7da8cd2);
        else
            return _0x28feaba7 + _0x0b933aab._0x641ee83b(new byte[8] { 125, 49, 39, 44, 38, 43, 38, 127 }, 66) + UnityWebRequest.EscapeURL(_0xe7da8cd2);
    }

    private string _0x39f516fc { get; set; }

    private IEnumerator _0xcaf2244d(IEnumerator _0x1c101f79, TaskCompletionSource<bool> _0xa000dbdc)
    {
        yield return _0x1c101f79;
        _0xa000dbdc.SetResult(true);
    }

    private bool _0xeba92da1()
    {
        var _0x2de9da23 = _0x4dd100a2();
        if (_0x2de9da23 == null)
            return false;
        WLog(_0x0b933aab._0x641ee83b(new byte[31] { 123, 82, 65, 87, 68, 82, 65, 86, 19, 81, 82, 80, 88, 19, 30, 13, 19, 67, 92, 67, 70, 67, 19, 116, 92, 113, 82, 80, 88, 9, 19 }, 51) + _0x2de9da23.Id);
        _0x2de9da23.GoBack();
        return true;
    }

    private IEnumerator _0x246417d5(float _0x49045c9f)
    {
        yield return new WaitForSeconds(_0x49045c9f);
        if (!_0x3e529e93)
        {
            _0x3e529e93 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x8df724e8}");
                }
#endif
            }
        }
    }

    private readonly List<UniWebViewPopup> _0xee857f7f = new List<UniWebViewPopup>();
    private Action _0x67449620;
    private bool _0xfd703373(string _0xeb9b9045)
    {
        string _0x1a841e67 = GetUrlHost(_0xeb9b9045);
        if (!string.IsNullOrEmpty(_0x1a841e67) && !string.IsNullOrEmpty(_0x3b3b801b) && !string.Equals(_0x1a841e67, _0x3b3b801b, StringComparison.OrdinalIgnoreCase))
            return true;
        return _0xa1a9b829;
    }

    private string _0x6739183c()
    {
        if (string.IsNullOrEmpty(_0x0946b908) && _0x7cbbb2be != null)
            _0x0946b908 = _0x7cbbb2be.GetUserAgent();
        if (string.IsNullOrEmpty(_0x0946b908))
            return string.Empty;
        string _0xce863a26 = Regex.Replace(_0x0946b908, _0x0b933aab._0x641ee83b(new byte[11] { 93, 114, 43, 58, 93, 114, 43, 118, 119, 93, 99 }, 1), string.Empty);
        _0xce863a26 = Regex.Replace(_0xce863a26, _0x0b933aab._0x641ee83b(new byte[15] { 115, 92, 4, 109, 90, 70, 67, 75, 0, 116, 113, 20, 6, 114, 4 }, 47), string.Empty);
        _0xce863a26 = Regex.Replace(_0xce863a26, _0x0b933aab._0x641ee83b(new byte[15] { 94, 109, 122, 123, 97, 103, 102, 39, 60, 84, 38, 56, 84, 123, 34 }, 8), string.Empty);
        return Regex.Replace(_0xce863a26, _0x0b933aab._0x641ee83b(new byte[6] { 111, 64, 72, 1, 31, 78 }, 51), _0x0b933aab._0x641ee83b(new byte[1] { 126 }, 94)).Trim();
    }

    internal bool IsGoogleAuthFlowUrl(string _0x7fde7e53)
    {
        if (string.IsNullOrEmpty(_0x7fde7e53))
            return false;
        return _0x7fde7e53.IndexOf(_0x0b933aab._0x641ee83b(new byte[19] { 249, 251, 251, 247, 237, 246, 236, 235, 182, 255, 247, 247, 255, 244, 253, 182, 251, 247, 245 }, 152), StringComparison.OrdinalIgnoreCase) >= 0 || _0x7fde7e53.IndexOf(_0x0b933aab._0x641ee83b(new byte[16] { 251, 249, 249, 245, 239, 244, 238, 233, 180, 253, 245, 245, 253, 246, 255, 180 }, 154), StringComparison.OrdinalIgnoreCase) >= 0 || _0x7fde7e53.IndexOf(_0x0b933aab._0x641ee83b(new byte[21] { 79, 71, 71, 79, 68, 77, 93, 91, 77, 90, 75, 71, 70, 92, 77, 70, 92, 6, 75, 71, 69 }, 40), StringComparison.OrdinalIgnoreCase) >= 0 || _0x7fde7e53.IndexOf(_0x0b933aab._0x641ee83b(new byte[11] { 190, 170, 173, 184, 173, 176, 186, 247, 186, 182, 180 }, 217), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x9d74f036 = "";
    private RectTransform _0x96a438ba;
    private void _0xdafdf9d0(string _0x5670dcd8)
    {
        if (string.IsNullOrEmpty(_0x5670dcd8))
            return;
        if (TryOpenExternalLikeChrome(_0x5670dcd8))
            return;
        OpenUrlExternally(_0x5670dcd8);
    }

    public void _0x17c7604e()
    {
        if (_0x4eee2880)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x0b933aab._0x641ee83b(new byte[33] { 150, 153, 168, 190, 185, 144, 237, 153, 164, 160, 168, 191, 237, 162, 184, 185, 237, 224, 243, 237, 160, 162, 187, 168, 237, 185, 162, 237, 190, 174, 168, 163, 168 }, 205));
            }
#endif
        }

        _0x79138406();
    }

    private float _0x695c6876 = 0f;
    private bool _0xd9a9f93a(string _0xb6b1e95b)
    {
        if (string.IsNullOrEmpty(_0xb6b1e95b))
            return false;
        try
        {
            using (var _0xf3781bc4 = new AndroidJavaClass(_0x0b933aab._0x641ee83b(new byte[30] { 104, 100, 102, 37, 126, 101, 98, 127, 114, 56, 111, 37, 123, 103, 106, 114, 110, 121, 37, 94, 101, 98, 127, 114, 91, 103, 106, 114, 110, 121 }, 11)))
            using (var _0x6f210ece = _0xf3781bc4.GetStatic<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[15] { 230, 240, 247, 247, 224, 235, 241, 196, 230, 241, 236, 243, 236, 241, 252 }, 133)))
            using (var _0x906ebcbe = _0x6f210ece.Call<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[17] { 48, 50, 35, 7, 54, 52, 60, 54, 48, 50, 26, 54, 57, 54, 48, 50, 37 }, 87)))
            using (var _0xe2df7cb6 = _0x906ebcbe.Call<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[25] { 64, 66, 83, 107, 70, 82, 73, 68, 79, 110, 73, 83, 66, 73, 83, 97, 72, 85, 119, 70, 68, 76, 70, 64, 66 }, 39), _0xb6b1e95b))
            {
                if (_0xe2df7cb6 == null)
                    return false;
                WLog(_0x0b933aab._0x641ee83b(new byte[37] { 125, 86, 76, 81, 83, 91, 114, 87, 85, 91, 30, 82, 95, 75, 80, 93, 86, 30, 87, 80, 77, 74, 95, 82, 82, 91, 90, 30, 78, 95, 93, 85, 95, 89, 91, 4, 30 }, 62) + _0xb6b1e95b);
                _0xe2df7cb6.Call<AndroidJavaObject>(_0x0b933aab._0x641ee83b(new byte[8] { 39, 34, 34, 0, 42, 39, 33, 53 }, 70), 0x10000000);
                _0x6f210ece.Call(_0x0b933aab._0x641ee83b(new byte[13] { 210, 213, 192, 211, 213, 224, 194, 213, 200, 215, 200, 213, 216 }, 161), _0xe2df7cb6);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private bool _0xa1a9b829;
    private string _0x3b3b801b;
    private IEnumerator _0xa6286879()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x0b933aab._0x641ee83b(new byte[26] { 48, 63, 14, 24, 31, 54, 75, 34, 5, 2, 31, 2, 10, 7, 2, 17, 14, 57, 14, 13, 13, 14, 25, 14, 25, 75 }, 107));
            }
#endif
        }

        bool _0x95228f9b = false;
        InstallReferrer.GetReferrer((_0x6e988974) =>
        {
            Debug.Log(_0x0b933aab._0x641ee83b(new byte[24] { 25, 22, 39, 49, 54, 98, 16, 39, 36, 39, 48, 48, 39, 48, 31, 98, 37, 39, 54, 98, 160, 196, 208, 98 }, 66) + _0x8df724e8);
            if (_0x6e988974.IsSuccess)
            {
                _0x8df724e8 = _0x6e988974.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x0b933aab._0x641ee83b(new byte[28] { 141, 130, 179, 165, 162, 246, 132, 179, 176, 179, 164, 164, 179, 164, 139, 246, 133, 163, 181, 181, 179, 165, 165, 246, 52, 80, 68, 246 }, 214) + _0x8df724e8);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x0b933aab._0x641ee83b(new byte[27] { 225, 238, 223, 201, 206, 154, 232, 223, 220, 223, 200, 200, 223, 200, 231, 154, 252, 219, 211, 214, 223, 222, 154, 88, 60, 40, 154 }, 186) + _0x6e988974);
#endif
                }

                _0x8df724e8 = "";
            }

            _0x3e529e93 = true;
        });
        StartCoroutine(_0x246417d5(2f));
        yield return new WaitUntil(() => _0x3e529e93);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x8df724e8}");
#endif
        }

        bool _0x86628ce8 = _0x8df724e8.Contains(_0x0b933aab._0x641ee83b(new byte[6] { 57, 61, 50, 55, 58, 99 }, 94));
        _0x95228f9b = _0x86628ce8 || _0x8df724e8.Contains(_0x0b933aab._0x641ee83b(new byte[18] { 37, 52, 52, 55, 106, 45, 42, 55, 48, 37, 35, 54, 37, 41, 106, 39, 43, 41 }, 68)) || _0x8df724e8.Contains(_0x0b933aab._0x641ee83b(new byte[17] { 86, 71, 71, 68, 25, 81, 86, 84, 82, 85, 88, 88, 92, 25, 84, 88, 90 }, 55));
        _0x39f516fc = _0x86628ce8 ? "" : (_0x95228f9b ? "" : _0x39f516fc);
        _0x39f516fc = _0x39f516fc ?? "";
        _0x2c9bb801 = _0x2c9bb801 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x39f516fc}");
#endif
        }
    }

    private void _0xa1ce9ce5()
    {
        WLog(_0x0b933aab._0x641ee83b(new byte[21] { 26, 51, 32, 54, 37, 51, 32, 55, 114, 48, 51, 49, 57, 114, 34, 32, 55, 33, 33, 55, 54 }, 82));
        if (Time.frameCount == _0xbe076dab)
            return;
        _0xbe076dab = Time.frameCount;
        if (_0xc11d87ee())
            return;
        _0xa35e5d2a();
    }

    private bool IsSslError(int _0x45688a5b, string _0x3d8d0aab)
    {
        if (_0x45688a5b == -1202 || _0x45688a5b == -1200 || _0x45688a5b == -11 || _0x45688a5b == -202)
            return true;
        if (string.IsNullOrEmpty(_0x3d8d0aab))
            return false;
        return _0x3d8d0aab.IndexOf(_0x0b933aab._0x641ee83b(new byte[3] { 72, 72, 87 }, 27), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3d8d0aab.IndexOf(_0x0b933aab._0x641ee83b(new byte[11] { 74, 76, 91, 93, 64, 79, 64, 74, 72, 93, 76 }, 41), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3d8d0aab.IndexOf(_0x0b933aab._0x641ee83b(new byte[4] { 221, 219, 204, 202 }, 158), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private async Task<bool> _0x5c40e26e()
    {
        _0x92b6f7a4.Instance?._0x0bb2fea0();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0xa72e00e9) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x0b933aab._0x641ee83b(new byte[32] { 13, 2, 51, 37, 34, 11, 118, 3, 56, 63, 34, 47, 118, 6, 35, 37, 62, 118, 24, 57, 34, 63, 48, 63, 53, 55, 34, 63, 57, 56, 108, 118 }, 86) + string.Join(_0x0b933aab._0x641ee83b(new byte[1] { 44 }, 37), _0xa72e00e9));
                }
#endif
            }
        };
        try
        {
            _0xb6a33a60 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x0b933aab._0x641ee83b(new byte[31] { 23, 24, 41, 63, 56, 17, 108, 10, 45, 37, 32, 41, 40, 108, 56, 35, 108, 43, 41, 56, 108, 60, 57, 63, 36, 108, 56, 35, 39, 41, 34 }, 76));
                }
#endif
            }

            _0xb6a33a60 = "";
        }

        _0xfe47ebae = !string.IsNullOrEmpty(_0xb6a33a60);
        _0xf2b78c66 = _0x0d29c61f();
        {
#if B_LOGS
            Debug.Log(_0x0b933aab._0x641ee83b(new byte[25] { 128, 143, 190, 168, 175, 134, 251, 142, 181, 178, 175, 162, 251, 139, 174, 168, 179, 251, 143, 180, 176, 190, 181, 225, 251 }, 219) + _0xb6a33a60);
#endif
        }

        _0x92b6f7a4.Instance?._0xea0d5b75();
        return false;
    }

    private string _0x49081543 = "";
    public void _0x79138406()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x0b933aab._0x641ee83b(new byte[18] { 152, 151, 166, 176, 183, 158, 227, 143, 162, 182, 173, 160, 171, 227, 132, 162, 174, 166 }, 195));
#endif
        }

        _0x92b6f7a4.Instance?._0x17598b2f();
        _0x8cb2bdd9.Instance._0xdb7398e1(_0x0a549333._0x0fc897b7.DEFAULT);
    }
}

internal static class _0x0b933aab
{
    internal static string _0x641ee83b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}