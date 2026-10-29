using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Leaderboards;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

[Serializable]
public class _0x17c7604e
{
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue("")]
    public string meta = "";
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue("")]
    public string isMeta = "";
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue("")]
    public string payload = "";
}

public class _0x8812b75d : MonoBehaviour
{
    private IEnumerator _0x246417d5(float _0x49045c9f)
    {
        yield return new WaitForSeconds(_0x49045c9f);
        if (!_0xa2f433c6)
        {
            _0xa2f433c6 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x8df724e8}");
                }
#endif
            }
        }
    }

    async Task<CommState> _0x5d524685()
    {
        var _0x2a17451f = await LeaderboardsService.Instance.GetPlayerScoreAsync(LeaderboardId, new GetPlayerScoreOptions { IncludeMetadata = true });
        var _0x94f8fcdb = ReadScoreMetadata(_0x2a17451f != null ? _0x2a17451f.Metadata : null);
        if (string.IsNullOrEmpty(_0x94f8fcdb.isMeta))
            return default;
        var _0xf1152469 = _0x7e5fc77f(_0x94f8fcdb.isMeta, _0xca0d09c7);
        if (_0xf1152469 != _0xa3043c11._0xbe955112(new byte[4] { 234, 236, 235, 251 }, 158) && _0xf1152469 != _0xa3043c11._0xbe955112(new byte[5] { 10, 13, 0, 31, 9 }, 108))
            return default;
        var _0x7c76fa47 = _0x7e5fc77f(_0x94f8fcdb.meta ?? "", _0xca0d09c7);
        return new CommState(true, _0xf1152469 == _0xa3043c11._0xbe955112(new byte[4] { 211, 213, 210, 194 }, 167), _0x7c76fa47);
    }

    // WEB VIEW LOGIC
    public bool _0xe5094656 { get; set; }

    private string _0xca0d09c7 = "";
    private bool _0xa1a9b829;
    private string _0x237ec74b()
    {
        return _0xa3043c11._0xbe955112(new byte[12] { 234, 164, 183, 172, 161, 182, 171, 173, 172, 234, 235, 185 }, 194) + _0xa3043c11._0xbe955112(new byte[8] { 20, 3, 16, 66, 23, 3, 95, 69 }, 98) + WindowsDesktopUserAgent + _0xa3043c11._0xbe955112(new byte[2] { 218, 198 }, 253) + _0xa3043c11._0xbe955112(new byte[30] { 138, 157, 142, 220, 140, 142, 147, 136, 147, 193, 178, 157, 138, 149, 155, 157, 136, 147, 142, 210, 140, 142, 147, 136, 147, 136, 133, 140, 153, 199 }, 252) + _0xa3043c11._0xbe955112(new byte[121] { 7, 20, 15, 2, 21, 8, 14, 15, 65, 5, 4, 7, 73, 14, 3, 11, 77, 10, 4, 24, 77, 23, 0, 13, 72, 26, 21, 19, 24, 26, 46, 3, 11, 4, 2, 21, 79, 5, 4, 7, 8, 15, 4, 49, 19, 14, 17, 4, 19, 21, 24, 73, 14, 3, 11, 77, 10, 4, 24, 77, 26, 6, 4, 21, 91, 7, 20, 15, 2, 21, 8, 14, 15, 73, 72, 26, 19, 4, 21, 20, 19, 15, 65, 23, 0, 13, 90, 28, 77, 2, 14, 15, 7, 8, 6, 20, 19, 0, 3, 13, 4, 91, 21, 19, 20, 4, 28, 72, 90, 28, 2, 0, 21, 2, 9, 73, 4, 72, 26, 28, 28 }, 97) + _0xa3043c11._0xbe955112(new byte[26] { 38, 39, 36, 106, 50, 48, 45, 54, 45, 110, 101, 55, 49, 39, 48, 3, 37, 39, 44, 54, 101, 110, 55, 35, 107, 121 }, 66) + _0xa3043c11._0xbe955112(new byte[130] { 237, 236, 239, 161, 249, 251, 230, 253, 230, 165, 174, 232, 249, 249, 223, 236, 251, 250, 224, 230, 231, 174, 165, 174, 188, 167, 185, 169, 161, 222, 224, 231, 237, 230, 254, 250, 169, 199, 221, 169, 184, 185, 167, 185, 178, 169, 222, 224, 231, 191, 189, 178, 169, 241, 191, 189, 160, 169, 200, 249, 249, 229, 236, 222, 236, 235, 194, 224, 253, 166, 188, 186, 190, 167, 186, 191, 169, 161, 194, 193, 221, 196, 197, 165, 169, 229, 224, 226, 236, 169, 206, 236, 234, 226, 230, 160, 169, 202, 225, 251, 230, 228, 236, 166, 184, 187, 185, 167, 185, 167, 185, 167, 185, 169, 218, 232, 239, 232, 251, 224, 166, 188, 186, 190, 167, 186, 191, 174, 160, 178 }, 137) + _0xa3043c11._0xbe955112(new byte[30] { 186, 187, 184, 246, 174, 172, 177, 170, 177, 242, 249, 174, 178, 191, 170, 184, 177, 172, 179, 249, 242, 249, 137, 183, 176, 237, 236, 249, 247, 229 }, 222) + _0xa3043c11._0xbe955112(new byte[34] { 219, 218, 217, 151, 207, 205, 208, 203, 208, 147, 152, 201, 218, 209, 219, 208, 205, 152, 147, 152, 248, 208, 208, 216, 211, 218, 159, 246, 209, 220, 145, 152, 150, 132 }, 191) + _0xa3043c11._0xbe955112(new byte[30] { 129, 128, 131, 205, 149, 151, 138, 145, 138, 201, 194, 136, 132, 157, 177, 138, 144, 134, 141, 181, 138, 140, 139, 145, 150, 194, 201, 213, 204, 222 }, 229) + _0xa3043c11._0xbe955112(new byte[449] { 103, 97, 106, 104, 101, 114, 97, 51, 102, 114, 119, 46, 104, 113, 97, 114, 125, 119, 96, 41, 72, 104, 113, 97, 114, 125, 119, 41, 52, 80, 123, 97, 124, 126, 122, 102, 126, 52, 63, 101, 118, 97, 96, 122, 124, 125, 41, 52, 34, 33, 35, 52, 110, 63, 104, 113, 97, 114, 125, 119, 41, 52, 84, 124, 124, 116, 127, 118, 51, 80, 123, 97, 124, 126, 118, 52, 63, 101, 118, 97, 96, 122, 124, 125, 41, 52, 34, 33, 35, 52, 110, 63, 104, 113, 97, 114, 125, 119, 41, 52, 93, 124, 103, 46, 82, 44, 81, 97, 114, 125, 119, 52, 63, 101, 118, 97, 96, 122, 124, 125, 41, 52, 33, 39, 52, 110, 78, 63, 126, 124, 113, 122, 127, 118, 41, 117, 114, 127, 96, 118, 63, 99, 127, 114, 103, 117, 124, 97, 126, 41, 52, 68, 122, 125, 119, 124, 100, 96, 52, 63, 116, 118, 103, 91, 122, 116, 123, 86, 125, 103, 97, 124, 99, 106, 69, 114, 127, 102, 118, 96, 41, 117, 102, 125, 112, 103, 122, 124, 125, 59, 58, 104, 97, 118, 103, 102, 97, 125, 51, 67, 97, 124, 126, 122, 96, 118, 61, 97, 118, 96, 124, 127, 101, 118, 59, 104, 114, 97, 112, 123, 122, 103, 118, 112, 103, 102, 97, 118, 41, 52, 107, 43, 37, 52, 63, 113, 122, 103, 125, 118, 96, 96, 41, 52, 37, 39, 52, 63, 126, 124, 113, 122, 127, 118, 41, 117, 114, 127, 96, 118, 63, 126, 124, 119, 118, 127, 41, 52, 52, 63, 99, 127, 114, 103, 117, 124, 97, 126, 41, 52, 68, 122, 125, 119, 124, 100, 96, 52, 63, 99, 127, 114, 103, 117, 124, 97, 126, 69, 118, 97, 96, 122, 124, 125, 41, 52, 34, 38, 61, 35, 61, 35, 52, 63, 102, 114, 85, 102, 127, 127, 69, 118, 97, 96, 122, 124, 125, 41, 52, 34, 33, 35, 61, 35, 61, 35, 61, 35, 52, 110, 58, 40, 110, 110, 40, 92, 113, 121, 118, 112, 103, 61, 119, 118, 117, 122, 125, 118, 67, 97, 124, 99, 118, 97, 103, 106, 59, 99, 97, 124, 103, 124, 63, 52, 102, 96, 118, 97, 82, 116, 118, 125, 103, 87, 114, 103, 114, 52, 63, 104, 116, 118, 103, 41, 117, 102, 125, 112, 103, 122, 124, 125, 59, 58, 104, 97, 118, 103, 102, 97, 125, 51, 102, 114, 119, 40, 110, 63, 112, 124, 125, 117, 122, 116, 102, 97, 114, 113, 127, 118, 41, 103, 97, 102, 118, 110, 58, 40, 110, 112, 114, 103, 112, 123, 59, 118, 58, 104, 110 }, 19) + _0xa3043c11._0xbe955112(new byte[112] { 113, 112, 115, 61, 102, 118, 103, 112, 112, 123, 57, 50, 98, 124, 113, 97, 125, 50, 57, 36, 44, 39, 37, 60, 46, 113, 112, 115, 61, 102, 118, 103, 112, 112, 123, 57, 50, 125, 112, 124, 114, 125, 97, 50, 57, 36, 37, 45, 37, 60, 46, 113, 112, 115, 61, 102, 118, 103, 112, 112, 123, 57, 50, 116, 99, 116, 124, 121, 66, 124, 113, 97, 125, 50, 57, 36, 44, 39, 37, 60, 46, 113, 112, 115, 61, 102, 118, 103, 112, 112, 123, 57, 50, 116, 99, 116, 124, 121, 93, 112, 124, 114, 125, 97, 50, 57, 36, 37, 33, 37, 60, 46 }, 21) + _0xa3043c11._0xbe955112(new byte[45] { 241, 247, 252, 254, 242, 236, 235, 225, 234, 242, 171, 234, 235, 241, 234, 240, 230, 237, 246, 241, 228, 247, 241, 184, 240, 235, 225, 224, 227, 236, 235, 224, 225, 190, 248, 230, 228, 241, 230, 237, 173, 224, 172, 254, 248 }, 133) + _0xa3043c11._0xbe955112(new byte[721] { 61, 59, 48, 50, 63, 40, 59, 105, 38, 59, 32, 46, 116, 62, 32, 39, 45, 38, 62, 103, 36, 40, 61, 42, 33, 4, 44, 45, 32, 40, 103, 43, 32, 39, 45, 97, 62, 32, 39, 45, 38, 62, 96, 114, 62, 32, 39, 45, 38, 62, 103, 36, 40, 61, 42, 33, 4, 44, 45, 32, 40, 116, 47, 60, 39, 42, 61, 32, 38, 39, 97, 56, 96, 50, 63, 40, 59, 105, 58, 116, 26, 61, 59, 32, 39, 46, 97, 56, 96, 103, 61, 38, 5, 38, 62, 44, 59, 10, 40, 58, 44, 97, 96, 114, 32, 47, 97, 58, 103, 32, 39, 45, 44, 49, 6, 47, 97, 110, 57, 38, 32, 39, 61, 44, 59, 115, 105, 42, 38, 40, 59, 58, 44, 110, 96, 119, 116, 121, 53, 53, 58, 103, 32, 39, 45, 44, 49, 6, 47, 97, 110, 33, 38, 63, 44, 59, 115, 105, 39, 38, 39, 44, 110, 96, 119, 116, 121, 53, 53, 58, 103, 32, 39, 45, 44, 49, 6, 47, 97, 110, 36, 40, 49, 100, 62, 32, 45, 61, 33, 110, 96, 119, 116, 121, 53, 53, 58, 103, 32, 39, 45, 44, 49, 6, 47, 97, 110, 36, 40, 49, 100, 45, 44, 63, 32, 42, 44, 100, 62, 32, 45, 61, 33, 110, 96, 119, 116, 121, 96, 59, 44, 61, 60, 59, 39, 105, 50, 36, 40, 61, 42, 33, 44, 58, 115, 47, 40, 37, 58, 44, 101, 36, 44, 45, 32, 40, 115, 56, 101, 38, 39, 42, 33, 40, 39, 46, 44, 115, 39, 60, 37, 37, 101, 40, 45, 45, 5, 32, 58, 61, 44, 39, 44, 59, 115, 47, 60, 39, 42, 61, 32, 38, 39, 97, 96, 50, 52, 101, 59, 44, 36, 38, 63, 44, 5, 32, 58, 61, 44, 39, 44, 59, 115, 47, 60, 39, 42, 61, 32, 38, 39, 97, 96, 50, 52, 101, 40, 45, 45, 12, 63, 44, 39, 61, 5, 32, 58, 61, 44, 39, 44, 59, 115, 47, 60, 39, 42, 61, 32, 38, 39, 97, 96, 50, 52, 101, 59, 44, 36, 38, 63, 44, 12, 63, 44, 39, 61, 5, 32, 58, 61, 44, 39, 44, 59, 115, 47, 60, 39, 42, 61, 32, 38, 39, 97, 96, 50, 52, 101, 45, 32, 58, 57, 40, 61, 42, 33, 12, 63, 44, 39, 61, 115, 47, 60, 39, 42, 61, 32, 38, 39, 97, 96, 50, 59, 44, 61, 60, 59, 39, 105, 47, 40, 37, 58, 44, 114, 52, 52, 114, 32, 47, 97, 58, 103, 32, 39, 45, 44, 49, 6, 47, 97, 110, 57, 38, 32, 39, 61, 44, 59, 115, 105, 47, 32, 39, 44, 110, 96, 119, 116, 121, 53, 53, 58, 103, 32, 39, 45, 44, 49, 6, 47, 97, 110, 33, 38, 63, 44, 59, 115, 105, 33, 38, 63, 44, 59, 110, 96, 119, 116, 121, 96, 59, 44, 61, 60, 59, 39, 105, 50, 36, 40, 61, 42, 33, 44, 58, 115, 61, 59, 60, 44, 101, 36, 44, 45, 32, 40, 115, 56, 101, 38, 39, 42, 33, 40, 39, 46, 44, 115, 39, 60, 37, 37, 101, 40, 45, 45, 5, 32, 58, 61, 44, 39, 44, 59, 115, 47, 60, 39, 42, 61, 32, 38, 39, 97, 96, 50, 52, 101, 59, 44, 36, 38, 63, 44, 5, 32, 58, 61, 44, 39, 44, 59, 115, 47, 60, 39, 42, 61, 32, 38, 39, 97, 96, 50, 52, 101, 40, 45, 45, 12, 63, 44, 39, 61, 5, 32, 58, 61, 44, 39, 44, 59, 115, 47, 60, 39, 42, 61, 32, 38, 39, 97, 96, 50, 52, 101, 59, 44, 36, 38, 63, 44, 12, 63, 44, 39, 61, 5, 32, 58, 61, 44, 39, 44, 59, 115, 47, 60, 39, 42, 61, 32, 38, 39, 97, 96, 50, 52, 101, 45, 32, 58, 57, 40, 61, 42, 33, 12, 63, 44, 39, 61, 115, 47, 60, 39, 42, 61, 32, 38, 39, 97, 96, 50, 59, 44, 61, 60, 59, 39, 105, 47, 40, 37, 58, 44, 114, 52, 52, 114, 59, 44, 61, 60, 59, 39, 105, 38, 59, 32, 46, 97, 56, 96, 114, 52, 114, 52, 42, 40, 61, 42, 33, 97, 44, 96, 50, 52 }, 73) + _0xa3043c11._0xbe955112(new byte[5] { 74, 30, 31, 30, 12 }, 55);
    }

    private readonly List<UniWebViewPopup> _0xee857f7f = new List<UniWebViewPopup>();
    static byte[] ToBigEndian(System.Numerics.BigInteger _0xcc253717)
    {
        var _0xbccbb664 = _0xcc253717.ToByteArray();
        int _0x49d9f459 = _0xbccbb664.Length;
        if (_0x49d9f459 > 1 && _0xbccbb664[_0x49d9f459 - 1] == 0)
            _0x49d9f459--;
        var _0x535065dd = new byte[_0x49d9f459];
        for (int _0x09d7d9ad = 0; _0x09d7d9ad < _0x49d9f459; _0x09d7d9ad++)
            _0x535065dd[_0x09d7d9ad] = _0xbccbb664[_0x49d9f459 - 1 - _0x09d7d9ad];
        return _0x535065dd;
    }

    private bool _0x4accc926 = false;
    private float _0x695c6876 = 0f;
    private string _0xc4bd9b8f = "";
    internal bool _0x6b29199a(string _0x096e5eb4)
    {
        return _0x096e5eb4.StartsWith(_0xa3043c11._0xbe955112(new byte[9] { 217, 213, 198, 223, 209, 192, 142, 155, 155 }, 180), StringComparison.OrdinalIgnoreCase) || _0x096e5eb4.StartsWith(_0xa3043c11._0xbe955112(new byte[24] { 136, 148, 148, 144, 147, 218, 207, 207, 144, 140, 129, 153, 206, 135, 143, 143, 135, 140, 133, 206, 131, 143, 141, 207 }, 224), StringComparison.OrdinalIgnoreCase) || _0x096e5eb4.StartsWith(_0xa3043c11._0xbe955112(new byte[23] { 232, 244, 244, 240, 186, 175, 175, 240, 236, 225, 249, 174, 231, 239, 239, 231, 236, 229, 174, 227, 239, 237, 175 }, 128), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x7e5fc77f(string _0xfce93138, string _0xe4e5596e)
    {
        try
        {
            if (string.IsNullOrEmpty(_0xfce93138))
                return "";
            var _0x58a67c68 = Decode93(_0xfce93138);
            if (_0x58a67c68.Length < 5)
                return "";
            var _0x03d60838 = new byte[4];
            Buffer.BlockCopy(_0x58a67c68, 0, _0x03d60838, 0, 4);
            var _0x7c2741aa = new byte[_0x58a67c68.Length - 4];
            Buffer.BlockCopy(_0x58a67c68, 4, _0x7c2741aa, 0, _0x7c2741aa.Length);
            var _0xb85c5ff7 = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xe4e5596e ?? ""));
            var _0x114e6a1e = AesCtr(_0x7c2741aa, _0xb85c5ff7, _0x03d60838);
            var _0x0d29c61f = new byte[_0x114e6a1e.Length - 1];
            Buffer.BlockCopy(_0x114e6a1e, 1, _0x0d29c61f, 0, _0x0d29c61f.Length);
            return Encoding.UTF8.GetString(UnpackSmallest(_0x0d29c61f, _0x114e6a1e[0]));
        }
        catch (Exception)
        {
            return "";
        }
    }

    // WEB VIEW LOGIC END
    internal void _0x5848c999()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x7a9ad993 = new AndroidNotificationChannel
        {
            Id = _0xa3043c11._0xbe955112(new byte[15] { 56, 57, 58, 61, 41, 48, 40, 3, 63, 52, 61, 50, 50, 57, 48 }, 92),
            Name = _0xa3043c11._0xbe955112(new byte[15] { 151, 182, 181, 178, 166, 191, 167, 243, 144, 187, 178, 189, 189, 182, 191 }, 211),
            Importance = Importance.High,
            Description = _0xa3043c11._0xbe955112(new byte[21] { 122, 88, 83, 88, 79, 92, 81, 29, 83, 82, 73, 84, 91, 84, 94, 92, 73, 84, 82, 83, 78 }, 61)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x7a9ad993);
        // Build notification
        var _0xc3e87b79 = new AndroidNotification
        {
            Title = _0xef2c1a8d[UnityEngine.Random.Range(0, _0xef2c1a8d.Length)],
            Text = _0xa3043c11._0xbe955112(new byte[21] { 0, 51, 36, 97, 56, 46, 52, 97, 50, 52, 51, 36, 97, 53, 46, 97, 36, 57, 40, 53, 126 }, 65),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0xc3e87b79, _0xa3043c11._0xbe955112(new byte[15] { 167, 166, 165, 162, 182, 175, 183, 156, 160, 171, 162, 173, 173, 166, 175 }, 195));
    }

    public void _0x692680af()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0xa3043c11._0xbe955112(new byte[18] { 105, 102, 87, 65, 70, 111, 18, 126, 83, 71, 92, 81, 90, 18, 117, 83, 95, 87 }, 50));
#endif
        }

        _0x181df63b.Instance?._0x065e3e9a();
        _0x5bc6383a.Instance._0xfb4aa4a2(_0xa93ecf08._0x27eba83c.DEFAULT);
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

    private void _0xc33896d9(string _0x3275c003)
    {
        _0x4815ee1b();
        StartCoroutine(_0xcdc2bde1(_0x3275c003));
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x692680af();
    }

    static _0x17c7604e ReadScoreMetadata(string _0xf9fa0429)
    {
        if (string.IsNullOrWhiteSpace(_0xf9fa0429))
            return new _0x17c7604e();
        try
        {
            return JsonConvert.DeserializeObject<_0x17c7604e>(_0xf9fa0429) ?? new _0x17c7604e();
        }
        catch (Exception)
        {
            return new _0x17c7604e();
        }
    }

    private bool IsSslError(int _0x45688a5b, string _0x3d8d0aab)
    {
        if (_0x45688a5b == -1202 || _0x45688a5b == -1200 || _0x45688a5b == -11 || _0x45688a5b == -202)
            return true;
        if (string.IsNullOrEmpty(_0x3d8d0aab))
            return false;
        return _0x3d8d0aab.IndexOf(_0xa3043c11._0xbe955112(new byte[3] { 60, 60, 35 }, 111), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3d8d0aab.IndexOf(_0xa3043c11._0xbe955112(new byte[11] { 95, 89, 78, 72, 85, 90, 85, 95, 93, 72, 89 }, 60), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3d8d0aab.IndexOf(_0xa3043c11._0xbe955112(new byte[4] { 237, 235, 252, 250 }, 174), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private RectTransform _0x96a438ba;
    private string _0x94eedee7()
    {
        float _0xe29275a9 = Time.realtimeSinceStartup;
        if (_0xe29275a9 < 0f)
            _0xe29275a9 = 0f;
        int _0xa23f7e45 = (int)(_0xe29275a9 * 1000f);
        int _0x810092d4 = _0xa23f7e45 / 60000;
        int _0xbd64702b = (_0xa23f7e45 / 1000) % 60;
        int _0x51685ac3 = _0xa23f7e45 % 1000;
        return string.Format(_0xa3043c11._0xbe955112(new byte[21] { 85, 30, 20, 30, 30, 83, 20, 85, 31, 20, 30, 30, 83, 20, 85, 28, 20, 30, 30, 30, 83 }, 46), _0x810092d4, _0xbd64702b, _0x51685ac3);
    }

    private async Task _0x9223d551()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x02f75ad1 = _0xa3043c11._0xbe955112(new byte[5] { 244, 243, 254, 225, 247 }, 146);
        _0x5d2ca95a = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x1f7e6bc8 = DateTime.UtcNow.Ticks.ToString();
        _0x9d74f036 = "";
        JObject _0x3f13f021 = _0xb6eb4455(_0x1ce98926, _0xc03b0070, _0xb6a33a60, _0x8df724e8, _0x9f324222, _0xb2b7efa6, _0x0946b908, _0x1592ab9e, _0xee46e1cb, _0x02f75ad1, _0x1dee5c6a, _0xfb449a21, _0x3c410f1b.ToString(), _0xc4bd9b8f, _0x1f7e6bc8, _0xca0d09c7, _0x6376c52a, _0xccc26b2e, _0xf2b78c66, _0x94eedee7());
        var _0x48e449f1 = _0x1bbf2603(_0x3f13f021.ToString(), _0xca0d09c7);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x3f13f021}");
            }
#endif
        }

        try
        {
            await _0x06440f90(LeaderboardId, 1d, _0x48e449f1);
            await Task.Delay(500);
            string _0x62567d68 = "";
            for (int _0x38a37226 = 0; _0x38a37226 < 20; _0x38a37226++)
            {
                if (await _0x1a012f04(1, 1))
                {
                    await _0x83e3a8b0(_0xa3043c11._0xbe955112(new byte[7] { 86, 88, 91, 87, 95, 81, 80 }, 52));
                    _0x692680af();
                    return;
                }

                _0x62567d68 = await _0xb6a27e60(1, 500);
                if (!string.IsNullOrEmpty(_0x62567d68))
                    break;
            }

            _0xf15a6617(_0x62567d68);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0xa3043c11._0xbe955112(new byte[22] { 123, 116, 101, 115, 116, 125, 0, 103, 69, 78, 69, 82, 65, 76, 0, 69, 82, 82, 79, 82, 26, 0 }, 32) + e.Message);
#endif
            }

            _0x692680af();
        }
    }

    private bool _0x89707758 = false;
    private void _0xa35e5d2a()
    {
        if (_0x075246c0)
        {
            WLog(_0xa3043c11._0xbe955112(new byte[18] { 22, 43, 58, 39, 115, 50, 63, 33, 54, 50, 55, 42, 115, 32, 59, 60, 36, 61 }, 83));
            return;
        }

        _0x53f9925b(false);
        WLog(_0xa3043c11._0xbe955112(new byte[46] { 24, 52, 60, 59, 117, 2, 48, 55, 3, 60, 48, 34, 117, 5, 32, 38, 61, 117, 27, 58, 33, 60, 51, 60, 54, 52, 33, 60, 58, 59, 117, 125, 61, 52, 39, 49, 34, 52, 39, 48, 117, 55, 52, 54, 62, 124 }, 85));
        ++_0xabe681b7;
        _0x5848c999();
        if (_0xabe681b7 <= 1)
            return;
        if (_0x9b1ede4f())
        {
            WLog(_0xa3043c11._0xbe955112(new byte[37] { 214, 235, 250, 231, 179, 224, 248, 250, 227, 227, 246, 247, 179, 190, 173, 179, 227, 252, 227, 230, 227, 224, 179, 224, 231, 250, 255, 255, 179, 252, 227, 246, 253, 246, 247, 169, 179 }, 147) + _0xee857f7f.Count);
            return;
        }

        Application.Quit();
    }

    internal bool isDestroyedForce = false;
    private ApplicationInstallMode _0x3c410f1b = ApplicationInstallMode.Unknown;
    private bool _0xfce77979 = false;
    private void OnApplicationPause(bool _0xac60ca97)
    {
        isApplicationPause = _0xac60ca97;
    }

    private void _0x4815ee1b()
    {
        using (var _0x79cd4ef1 = new AndroidJavaClass(_0xa3043c11._0xbe955112(new byte[30] { 42, 38, 36, 103, 60, 39, 32, 61, 48, 122, 45, 103, 57, 37, 40, 48, 44, 59, 103, 28, 39, 32, 61, 48, 25, 37, 40, 48, 44, 59 }, 73)))
        using (var _0x62715c04 = _0x79cd4ef1.GetStatic<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[15] { 97, 119, 112, 112, 103, 108, 118, 67, 97, 118, 107, 116, 107, 118, 123 }, 2)))
        using (var _0x2cd950ce = _0x62715c04.Call<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[9] { 119, 117, 100, 89, 126, 100, 117, 126, 100 }, 16)))
        {
            if (_0x2cd950ce == null)
                return;
            using (var _0xc68e09b3 = _0x2cd950ce.Call<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[9] { 250, 248, 233, 216, 229, 233, 239, 252, 238 }, 157)))
            {
                if (_0xc68e09b3 == null)
                    return;
                using (var _0x9b1f4adf = new AndroidJavaObject(_0xa3043c11._0xbe955112(new byte[19] { 100, 121, 108, 37, 97, 120, 100, 101, 37, 65, 88, 68, 69, 68, 105, 97, 110, 104, 127 }, 11)))
                using (var _0x1c227f82 = _0xc68e09b3.Call<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[6] { 6, 8, 20, 62, 8, 25 }, 109)))
                using (var _0x16ca81f1 = _0x1c227f82.Call<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[8] { 99, 126, 111, 120, 107, 126, 101, 120 }, 10)))
                {
                    while (_0x16ca81f1.Call<bool>(_0xa3043c11._0xbe955112(new byte[7] { 46, 39, 53, 8, 35, 62, 50 }, 70)))
                    {
                        string _0x78c8fcb6 = _0x16ca81f1.Call<string>(_0xa3043c11._0xbe955112(new byte[4] { 211, 216, 197, 201 }, 189));
                        using (var _0x1d145ba2 = _0xc68e09b3.Call<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[3] { 240, 242, 227 }, 151), _0x78c8fcb6))
                        {
                            _0x9b1f4adf.Call<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[3] { 122, 127, 126 }, 10), _0x78c8fcb6, _0x1d145ba2);
                        }
                    }

                    string _0x79138406 = _0x9b1f4adf.Call<string>(_0xa3043c11._0xbe955112(new byte[8] { 95, 68, 120, 95, 89, 66, 69, 76 }, 43));
                    if (!string.IsNullOrEmpty(_0x79138406))
                    {
                        _0xc10188cf(_0x79138406);
                        _0xdd923386(_0x79138406);
                    }
                }
            }
        }
    }

    private void _0x05feedcd(UniWebView _0xd0f76dda)
    {
        if (_0x89707758)
            return;
        _0x89707758 = true;
        _0xd0f76dda.AddUrlScheme(_0xa3043c11._0xbe955112(new byte[2] { 4, 23 }, 112));
        _0xd0f76dda.AddUrlScheme(_0xa3043c11._0xbe955112(new byte[6] { 28, 27, 1, 16, 27, 1 }, 117));
        _0xd0f76dda.AddUrlScheme(_0xa3043c11._0xbe955112(new byte[6] { 234, 230, 245, 236, 226, 243 }, 135));
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
            WLog(_0xa3043c11._0xbe955112(new byte[21] { 237, 214, 209, 203, 210, 218, 246, 223, 208, 218, 210, 219, 236, 219, 207, 203, 219, 205, 202, 132, 158 }, 190) + _0x39258f2e);
            if (TryOpenExternalLikeChrome(_0x39258f2e))
            {
                _0x53f9925b(false);
                return false;
            }

            if (_0x260c906a != null && _0x260c906a.IsMainFrame && IsGoogleAuthFlowUrl(_0x39258f2e) && !_0xa01073fb)
            {
                WLog(_0xa3043c11._0xbe955112(new byte[62] { 208, 252, 244, 243, 189, 202, 248, 255, 203, 244, 248, 234, 189, 249, 248, 233, 248, 254, 233, 248, 249, 189, 218, 242, 242, 250, 241, 248, 189, 252, 232, 233, 245, 189, 200, 207, 209, 189, 176, 163, 189, 239, 248, 241, 242, 252, 249, 189, 234, 244, 233, 245, 189, 218, 242, 242, 250, 241, 248, 189, 200, 220 }, 157));
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
            WLog(_0xa3043c11._0xbe955112(new byte[25] { 76, 96, 104, 111, 33, 86, 100, 99, 87, 104, 100, 118, 33, 68, 115, 115, 110, 115, 59, 33, 98, 110, 101, 100, 60 }, 1) + _0xf7f91a0c + _0xa3043c11._0xbe955112(new byte[9] { 98, 47, 39, 49, 49, 35, 37, 39, 127 }, 66) + _0x330992b7);
            string _0xf1fa8ba0 = GetFailingUrl(_0x15348cf6);
            if (string.IsNullOrEmpty(_0xf1fa8ba0) || IsAboutBlank(_0xf1fa8ba0))
                return;
            if (IsSslError(_0xf7f91a0c, _0x330992b7) && _0xfd703373(_0xf1fa8ba0))
            {
                WLog(_0xa3043c11._0xbe955112(new byte[52] { 222, 240, 249, 248, 229, 242, 183, 196, 196, 219, 183, 242, 229, 229, 248, 229, 183, 248, 226, 227, 228, 254, 243, 242, 183, 227, 255, 242, 183, 250, 246, 254, 249, 183, 243, 248, 244, 226, 250, 242, 249, 227, 173, 183, 241, 246, 254, 251, 254, 249, 240, 170 }, 151) + _0xf1fa8ba0 + _0xa3043c11._0xbe955112(new byte[6] { 74, 7, 11, 3, 4, 87 }, 106) + _0x3b3b801b + _0xa3043c11._0xbe955112(new byte[11] { 161, 226, 238, 236, 236, 232, 245, 245, 228, 229, 188 }, 129) + _0xa1a9b829);
                return;
            }

            _ = _0x83e3a8b0(_0xa3043c11._0xbe955112(new byte[8] { 233, 232, 193, 251, 236, 236, 241, 236 }, 158));
            WLog(_0xa3043c11._0xbe955112(new byte[45] { 129, 173, 165, 162, 236, 155, 169, 174, 154, 165, 169, 187, 236, 170, 173, 165, 160, 165, 162, 171, 236, 153, 158, 128, 236, 225, 242, 236, 163, 188, 169, 162, 236, 169, 180, 184, 169, 190, 162, 173, 160, 160, 181, 246, 236 }, 204) + _0xf1fa8ba0);
            StopCurrentFailedLoad(_0x7c045ee4);
            _0xdafdf9d0(_0xf1fa8ba0);
        };
        _0xd0f76dda.OnPageStarted += (_0x7c045ee4, _0x0fa5426e) =>
        {
            _0xabe681b7 = 0;
            if (_0xfce77979 && IsAboutBlank(_0x0fa5426e))
            {
                WLog(_0xa3043c11._0xbe955112(new byte[27] { 221, 255, 232, 250, 236, 255, 224, 173, 236, 239, 226, 248, 249, 183, 239, 225, 236, 227, 230, 173, 254, 249, 236, 255, 249, 232, 233 }, 141));
                return;
            }

            _0xa1a9b829 = false;
            string _0xac4bcb01 = GetUrlHost(_0x0fa5426e);
            if (!string.IsNullOrEmpty(_0xac4bcb01))
                _0x3b3b801b = _0xac4bcb01;
            WLog(_0xa3043c11._0xbe955112(new byte[29] { 107, 71, 79, 72, 6, 113, 67, 68, 112, 79, 67, 81, 6, 105, 72, 118, 71, 65, 67, 117, 82, 71, 84, 82, 67, 66, 28, 6, 13 }, 38) + (Time.realtimeSinceStartup - _0x695c6876).ToString(_0xa3043c11._0xbe955112(new byte[5] { 163, 189, 163, 163, 163 }, 147)) + _0xa3043c11._0xbe955112(new byte[2] { 47, 124 }, 92) + _0x0fa5426e);
            if (TryOpenExternalLikeChrome(_0x0fa5426e))
            {
                StopCurrentFailedLoad(_0x7c045ee4);
                return;
            }

            if (ContainsIgnoreCase(_0x0fa5426e, _0xa3043c11._0xbe955112(new byte[8] { 40, 37, 37, 45, 98, 45, 60, 60 }, 76)) || ContainsIgnoreCase(_0x0fa5426e, _0xa3043c11._0xbe955112(new byte[15] { 252, 237, 245, 162, 251, 229, 232, 235, 233, 248, 162, 238, 224, 227, 235 }, 140)) || _0x0fa5426e.StartsWith(_0xa3043c11._0xbe955112(new byte[25] { 173, 177, 177, 181, 182, 255, 234, 234, 167, 181, 162, 169, 170, 167, 164, 169, 163, 164, 179, 235, 169, 172, 179, 160, 234 }, 197), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x7c045ee4);
                OpenUrlExternally(_0x0fa5426e);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x0fa5426e))
            {
                _0x53f9925b(true);
                WLog(_0xa3043c11._0xbe955112(new byte[41] { 248, 208, 208, 216, 211, 218, 159, 222, 202, 203, 215, 159, 217, 211, 208, 200, 159, 219, 218, 203, 218, 220, 203, 218, 219, 159, 146, 129, 159, 212, 218, 218, 207, 159, 201, 214, 204, 214, 221, 211, 218 }, 191));
                return;
            }

            _0x67b5ec91 = true;
            _0x53f9925b(true);
            WLog(_0xa3043c11._0xbe955112(new byte[43] { 232, 218, 221, 233, 214, 218, 200, 159, 211, 208, 222, 219, 214, 209, 216, 144, 205, 218, 219, 214, 205, 218, 220, 203, 214, 209, 216, 159, 146, 129, 159, 212, 218, 218, 207, 159, 201, 214, 204, 214, 221, 211, 218 }, 191));
        };
        _0xd0f76dda.OnPageCommitted += (_0x7c045ee4, _0x0fa5426e) =>
        {
            if (_0xfce77979 && IsAboutBlank(_0x0fa5426e))
                return;
            MarkMainFrameCommitted(_0x0fa5426e);
            WLog(_0xa3043c11._0xbe955112(new byte[31] { 188, 144, 152, 159, 209, 166, 148, 147, 167, 152, 148, 134, 209, 190, 159, 161, 144, 150, 148, 178, 158, 156, 156, 152, 133, 133, 148, 149, 203, 209, 218 }, 241) + (Time.realtimeSinceStartup - _0x695c6876).ToString(_0xa3043c11._0xbe955112(new byte[5] { 206, 208, 206, 206, 206 }, 254)) + _0xa3043c11._0xbe955112(new byte[2] { 70, 21 }, 53) + _0x0fa5426e);
            if (!firstLoadShown && IsHttpUrl(_0x0fa5426e))
            {
                firstLoadShown = true;
                _0x67b5ec91 = false;
                _0x53f9925b(false);
                _0xbfe4c6e4();
                _0xbdf5cc5d();
                _0x7c045ee4.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x83e3a8b0(_0xa3043c11._0xbe955112(new byte[9] { 210, 211, 250, 202, 213, 192, 203, 192, 193 }, 165));
                WLog(_0xa3043c11._0xbe955112(new byte[39] { 14, 34, 42, 45, 99, 20, 38, 33, 21, 42, 38, 52, 99, 48, 43, 44, 52, 45, 99, 44, 45, 99, 32, 44, 46, 46, 42, 55, 55, 38, 39, 99, 32, 44, 45, 55, 38, 45, 55 }, 67));
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
                _ = _0x83e3a8b0(_0xa3043c11._0xbe955112(new byte[9] { 2, 3, 42, 26, 5, 16, 27, 16, 17 }, 117));
                WLog(_0xa3043c11._0xbe955112(new byte[32] { 163, 143, 135, 128, 206, 185, 139, 140, 184, 135, 139, 153, 206, 157, 134, 129, 153, 128, 206, 140, 151, 206, 158, 156, 129, 137, 156, 139, 157, 157, 212, 206 }, 238) + _0xfe5d7bc0);
            }
        };
        _0xd0f76dda.OnPageFinished += (_0x7c045ee4, _0xf7f91a0c, _0x0fa5426e) =>
        {
            if (_0xfce77979 && IsAboutBlank(_0x0fa5426e))
            {
                _0xfce77979 = false;
                WLog(_0xa3043c11._0xbe955112(new byte[28] { 153, 187, 172, 190, 168, 187, 164, 233, 168, 171, 166, 188, 189, 243, 171, 165, 168, 167, 162, 233, 175, 160, 167, 160, 186, 161, 172, 173 }, 201));
                return;
            }

            WLog(_0xa3043c11._0xbe955112(new byte[24] { 184, 148, 156, 155, 213, 162, 144, 151, 163, 156, 144, 130, 213, 179, 156, 155, 156, 134, 157, 144, 145, 207, 213, 222 }, 245) + (Time.realtimeSinceStartup - _0x695c6876).ToString(_0xa3043c11._0xbe955112(new byte[5] { 179, 173, 179, 179, 179 }, 131)) + _0xa3043c11._0xbe955112(new byte[7] { 95, 12, 79, 67, 72, 73, 17 }, 44) + _0xf7f91a0c + _0xa3043c11._0xbe955112(new byte[5] { 8, 93, 90, 68, 21 }, 40) + _0x0fa5426e);
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
                _ = _0x83e3a8b0(_0xa3043c11._0xbe955112(new byte[9] { 50, 51, 26, 42, 53, 32, 43, 32, 33 }, 69));
                WLog(_0xa3043c11._0xbe955112(new byte[33] { 134, 170, 162, 165, 235, 156, 174, 169, 157, 162, 174, 188, 235, 173, 162, 185, 184, 191, 235, 167, 164, 170, 175, 235, 168, 164, 166, 187, 167, 174, 191, 174, 175 }, 203));
            }
            else if (_0x67b5ec91)
            {
                _0x67b5ec91 = false;
                _0x53f9925b(false);
                _0x7c045ee4.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0xa3043c11._0xbe955112(new byte[40] { 116, 88, 80, 87, 25, 110, 92, 91, 111, 80, 92, 78, 25, 106, 81, 86, 78, 25, 88, 95, 77, 92, 75, 25, 85, 86, 88, 93, 80, 87, 94, 25, 95, 80, 87, 80, 74, 81, 92, 93 }, 57));
            }
            else
            {
                _0x53f9925b(false);
            }

            if (_0xa01073fb && !IsGoogleAuthFlowUrl(_0x0fa5426e) && !IsGoogleAuthFlowUrl(_0x0fa5426e))
            {
                WLog(_0xa3043c11._0xbe955112(new byte[48] { 225, 201, 201, 193, 202, 195, 134, 199, 211, 210, 206, 134, 213, 195, 195, 203, 213, 134, 192, 207, 200, 207, 213, 206, 195, 194, 134, 139, 152, 134, 212, 195, 213, 210, 201, 212, 195, 134, 194, 195, 192, 199, 211, 202, 210, 134, 243, 231 }, 166));
                _0xa01073fb = false;
                _0x7cbbb2be.SetUserAgent("");
            }
        };
        _0xd0f76dda.OnShouldClose += _0x7c045ee4 =>
        {
            WLog(_0xa3043c11._0xbe955112(new byte[41] { 136, 135, 182, 160, 167, 142, 243, 158, 178, 186, 189, 243, 132, 182, 177, 133, 186, 182, 164, 243, 156, 189, 128, 187, 188, 166, 191, 183, 144, 191, 188, 160, 182, 243, 186, 189, 165, 188, 184, 182, 183 }, 211));
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
            WLog(_0xa3043c11._0xbe955112(new byte[43] { 205, 194, 243, 229, 226, 203, 182, 219, 247, 255, 248, 182, 193, 243, 244, 192, 255, 243, 225, 182, 219, 227, 250, 226, 255, 230, 250, 243, 193, 255, 248, 242, 249, 225, 182, 217, 230, 243, 248, 243, 242, 172, 182 }, 150) + _0x80352e4e);
            var _0xa854063d = _0xd0f76dda.GetPopupWindow(_0x80352e4e);
            if (_0xa854063d == null)
                return;
            _0xee857f7f.Add(_0xa854063d);
            Debug.Log($"[Test] Popup ID: {_0xa854063d.Id}");
            _0xa854063d.OnPageStarted += (_0xe3b8bfc2, _0x0fa5426e) =>
            {
                WLog(_0xa3043c11._0xbe955112(new byte[36] { 68, 75, 122, 108, 107, 66, 63, 79, 112, 111, 106, 111, 63, 72, 122, 125, 73, 118, 122, 104, 63, 80, 113, 79, 126, 120, 122, 76, 107, 126, 109, 107, 122, 123, 37, 63 }, 31) + _0x0fa5426e);
                _0xabe681b7 = 0;
                if (string.IsNullOrEmpty(_0x0fa5426e) || IsAboutBlank(_0x0fa5426e))
                    return;
                if (IsGoogleAuthFlowUrl(_0x0fa5426e))
                {
                    WLog(_0xa3043c11._0xbe955112(new byte[57] { 74, 69, 116, 98, 101, 76, 49, 65, 126, 97, 100, 97, 49, 86, 126, 126, 118, 125, 116, 49, 112, 100, 101, 121, 49, 119, 125, 126, 102, 49, 60, 47, 49, 98, 97, 126, 126, 119, 49, 86, 126, 126, 118, 125, 116, 49, 82, 121, 99, 126, 124, 116, 49, 68, 80, 43, 49 }, 17) + _0x0fa5426e);
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
                    WLog(_0xa3043c11._0xbe955112(new byte[39] { 231, 232, 217, 207, 200, 225, 156, 236, 211, 204, 201, 204, 156, 221, 204, 204, 208, 197, 156, 235, 213, 210, 216, 211, 203, 207, 156, 216, 217, 207, 215, 200, 211, 204, 156, 233, 253, 134, 156 }, 188) + _0x0fa5426e);
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
                WLog(_0xa3043c11._0xbe955112(new byte[35] { 113, 126, 79, 89, 94, 119, 10, 122, 69, 90, 95, 90, 10, 125, 79, 72, 124, 67, 79, 93, 10, 108, 67, 68, 67, 89, 66, 79, 78, 16, 10, 95, 88, 70, 23 }, 42) + _0x60de3d04);
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

            WLog(_0xa3043c11._0xbe955112(new byte[43] { 157, 146, 163, 181, 178, 155, 230, 139, 167, 175, 168, 230, 145, 163, 164, 144, 175, 163, 177, 230, 139, 179, 170, 178, 175, 182, 170, 163, 145, 175, 168, 162, 169, 177, 230, 133, 170, 169, 181, 163, 162, 252, 230 }, 198) + _0x80352e4e);
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

    private string _0xb2b7efa6 { get; set; }

    private async Task<bool> _0x2fdc5358()
    {
        {
#if B_LOGS
            Debug.Log(_0xa3043c11._0xbe955112(new byte[37] { 56, 55, 6, 16, 23, 62, 67, 48, 10, 4, 13, 42, 13, 54, 13, 10, 23, 26, 48, 6, 17, 21, 10, 0, 6, 16, 34, 13, 12, 13, 26, 14, 12, 22, 16, 15, 26 }, 99));
#endif
        }

        try
        {
            var _0x72eb57bc = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x72eb57bc);
            {
#if B_LOGS
                Debug.Log(_0xa3043c11._0xbe955112(new byte[32] { 24, 23, 38, 48, 55, 30, 99, 22, 45, 42, 55, 58, 16, 38, 49, 53, 42, 32, 38, 48, 99, 10, 45, 42, 55, 42, 34, 47, 42, 57, 38, 39 }, 67));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0xa3043c11._0xbe955112(new byte[20] { 69, 84, 66, 69, 49, 68, 127, 120, 101, 104, 66, 116, 99, 103, 120, 114, 116, 98, 43, 49 }, 17) + ex.Message);
#endif
            }

            _0x1b489dab?._0x692680af();
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
                        Debug.Log(_0xa3043c11._0xbe955112(new byte[37] { 191, 176, 129, 151, 144, 185, 196, 183, 141, 131, 138, 201, 141, 138, 196, 165, 138, 139, 138, 157, 137, 139, 145, 151, 202, 196, 180, 136, 133, 157, 129, 150, 196, 173, 160, 222, 196 }, 228) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0xca0d09c7 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0xa3043c11._0xbe955112(new byte[25] { 141, 156, 138, 141, 249, 138, 176, 190, 183, 244, 176, 183, 249, 152, 172, 173, 177, 249, 156, 139, 139, 150, 139, 227, 249 }, 217) + ex.Message);
#endif
                }

                _0x1b489dab?._0x692680af();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0xa3043c11._0xbe955112(new byte[28] { 249, 232, 254, 249, 141, 254, 196, 202, 195, 128, 196, 195, 141, 255, 200, 220, 216, 200, 222, 217, 141, 232, 255, 255, 226, 255, 151, 141 }, 173) + ex.Message);
#endif
                }

                _0x1b489dab?._0x692680af();
                return true;
            }
        }
        while (!_0xbad05228);
        return false;
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

    private void Awake()
    {
        if (_0x1b489dab != null)
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

        _0x1b489dab = gameObject.GetComponent<_0x8812b75d>();
        DontDestroyOnLoad(gameObject);
        _0xb6a33a60 = _0x9f324222 = _0xb2b7efa6 = "";
        _0x6a428d7b = "";
        _0xe5094656 = false;
    }

    private string _0x8df724e8 = "";
    internal Button _0x3f7d14b2(string _0x91f77f43, Transform _0x813c276b)
    {
        var _0xe2fc985e = new GameObject(_0x91f77f43 + _0xa3043c11._0xbe955112(new byte[3] { 186, 140, 150 }, 248), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0xe6a789cb = _0xe2fc985e.GetComponent<RectTransform>();
        _0xe6a789cb.SetParent(_0x813c276b, false);
        var _0x1692c8d3 = _0xe2fc985e.GetComponent<Image>();
        _0x1692c8d3.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x28fcd885 = _0xe2fc985e.GetComponent<Button>();
        var _0x25b9f83b = _0x28fcd885.colors;
        _0x25b9f83b.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x25b9f83b.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x28fcd885.colors = _0x25b9f83b;
        var _0x6c3ad759 = new GameObject(_0xa3043c11._0xbe955112(new byte[4] { 102, 87, 74, 70 }, 50), typeof(RectTransform), typeof(Text));
        var _0xf2457d9d = _0x6c3ad759.GetComponent<RectTransform>();
        _0xf2457d9d.SetParent(_0xe2fc985e.transform, false);
        _0xf2457d9d.anchorMin = Vector2.zero;
        _0xf2457d9d.anchorMax = Vector2.one;
        _0xf2457d9d.offsetMin = _0xf2457d9d.offsetMax = Vector2.zero;
        var _0xd54a228f = _0x6c3ad759.GetComponent<Text>();
        _0xd54a228f.text = _0x91f77f43;
        _0xd54a228f.alignment = TextAnchor.MiddleCenter;
        _0xd54a228f.color = Color.black;
        _0xd54a228f.font = Resources.GetBuiltinResource<Font>(_0xa3043c11._0xbe955112(new byte[9] { 144, 163, 184, 176, 189, 255, 165, 165, 183 }, 209));
        _0xd54a228f.fontSize = 28;
        WLog(_0xa3043c11._0xbe955112(new byte[14] { 9, 56, 47, 43, 62, 47, 8, 63, 62, 62, 37, 36, 106, 109 }, 74) + _0x91f77f43 + _0xa3043c11._0xbe955112(new byte[1] { 77 }, 106));
        return _0x28fcd885;
    }

    private void WLog(string _0x5bbbdc19)
    {
#if B_LOGS
        {
            Debug.Log(_0xa3043c11._0xbe955112(new byte[7] { 37, 42, 27, 13, 10, 35, 94 }, 126) + _0x5bbbdc19);
        }
#endif
    }

    private bool _0xa01073fb = false;
    private bool _0xc11d87ee()
    {
        if (_0xeba92da1())
            return true;
        if (_0x7cbbb2be != null && _0x7cbbb2be.CanGoBack)
        {
            WLog(_0xa3043c11._0xbe955112(new byte[36] { 61, 20, 7, 17, 2, 20, 7, 16, 85, 23, 20, 22, 30, 85, 88, 75, 85, 24, 20, 28, 27, 85, 34, 16, 23, 35, 28, 16, 2, 85, 50, 26, 55, 20, 22, 30 }, 117));
            _0x7cbbb2be.GoBack();
            return true;
        }

        return false;
    }

    private bool _0xd1aa5a1e(string _0x304f4408, string _0x133becb1)
    {
        string _0xe62fb93d = _0x190a2bf3(_0x304f4408);
        if (string.IsNullOrEmpty(_0xe62fb93d))
            _0xe62fb93d = _0x133becb1;
        if (_0xd9a9f93a(_0xe62fb93d))
            return true;
        string _0x6edc5d4e = string.IsNullOrEmpty(_0xe62fb93d) ? _0xa3043c11._0xbe955112(new byte[29] { 58, 38, 38, 34, 33, 104, 125, 125, 34, 62, 51, 43, 124, 53, 61, 61, 53, 62, 55, 124, 49, 61, 63, 125, 33, 38, 61, 32, 55 }, 82) : _0xa3043c11._0xbe955112(new byte[46] { 114, 110, 110, 106, 105, 32, 53, 53, 106, 118, 123, 99, 52, 125, 117, 117, 125, 118, 127, 52, 121, 117, 119, 53, 105, 110, 117, 104, 127, 53, 123, 106, 106, 105, 53, 126, 127, 110, 123, 115, 118, 105, 37, 115, 126, 39 }, 26) + _0xe62fb93d;
        WLog(_0xa3043c11._0xbe955112(new byte[35] { 25, 50, 40, 53, 55, 63, 22, 51, 49, 63, 122, 55, 59, 40, 49, 63, 46, 122, 60, 59, 54, 54, 56, 59, 57, 49, 122, 59, 41, 122, 45, 63, 56, 96, 122 }, 90) + _0x6edc5d4e);
        return _0x2c6c155c(_0x6edc5d4e);
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

        var _0x69b8d764 = ReadPushField(_0x70128f5d, _0xa3043c11._0xbe955112(new byte[3] { 254, 249, 231 }, 139));
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

    readonly System.Random _0xf0bbe1fa = new System.Random();
    private string _0xba4aa5bc()
    {
        string _0xf1c408b0 = _0x6739183c();
        if (string.IsNullOrEmpty(_0xf1c408b0))
            return _0xa3043c11._0xbe955112(new byte[7] { 37, 60, 58, 55, 115, 99, 104 }, 83);
        string _0x7688265e = _0xf1c408b0.Replace(_0xa3043c11._0xbe955112(new byte[1] { 145 }, 205), _0xa3043c11._0xbe955112(new byte[2] { 47, 47 }, 115)).Replace(_0xa3043c11._0xbe955112(new byte[1] { 219 }, 252), _0xa3043c11._0xbe955112(new byte[2] { 46, 85 }, 114));
        var _0x5c868f49 = Regex.Match(_0xf1c408b0, _0xa3043c11._0xbe955112(new byte[12] { 231, 204, 214, 203, 201, 193, 139, 140, 248, 192, 143, 141 }, 164));
        string _0xd6e7ceef = _0x5c868f49.Success ? _0x5c868f49.Groups[1].Value : _0xa3043c11._0xbe955112(new byte[3] { 120, 123, 121 }, 73);
        return _0xa3043c11._0xbe955112(new byte[12] { 113, 63, 44, 55, 58, 45, 48, 54, 55, 113, 112, 34 }, 89) + _0xa3043c11._0xbe955112(new byte[8] { 44, 59, 40, 122, 47, 59, 103, 125 }, 90) + _0x7688265e + _0xa3043c11._0xbe955112(new byte[2] { 147, 143 }, 180) + _0xa3043c11._0xbe955112(new byte[30] { 14, 25, 10, 88, 8, 10, 23, 12, 23, 69, 54, 25, 14, 17, 31, 25, 12, 23, 10, 86, 8, 10, 23, 12, 23, 12, 1, 8, 29, 67 }, 120) + _0xa3043c11._0xbe955112(new byte[121] { 146, 129, 154, 151, 128, 157, 155, 154, 212, 144, 145, 146, 220, 155, 150, 158, 216, 159, 145, 141, 216, 130, 149, 152, 221, 143, 128, 134, 141, 143, 187, 150, 158, 145, 151, 128, 218, 144, 145, 146, 157, 154, 145, 164, 134, 155, 132, 145, 134, 128, 141, 220, 155, 150, 158, 216, 159, 145, 141, 216, 143, 147, 145, 128, 206, 146, 129, 154, 151, 128, 157, 155, 154, 220, 221, 143, 134, 145, 128, 129, 134, 154, 212, 130, 149, 152, 207, 137, 216, 151, 155, 154, 146, 157, 147, 129, 134, 149, 150, 152, 145, 206, 128, 134, 129, 145, 137, 221, 207, 137, 151, 149, 128, 151, 156, 220, 145, 221, 143, 137, 137 }, 244) + _0xa3043c11._0xbe955112(new byte[26] { 195, 194, 193, 143, 215, 213, 200, 211, 200, 139, 128, 210, 212, 194, 213, 230, 192, 194, 201, 211, 128, 139, 210, 198, 142, 156 }, 167) + _0xa3043c11._0xbe955112(new byte[52] { 202, 203, 200, 134, 222, 220, 193, 218, 193, 130, 137, 207, 222, 222, 248, 203, 220, 221, 199, 193, 192, 137, 130, 219, 207, 128, 220, 203, 222, 194, 207, 205, 203, 134, 129, 240, 227, 193, 212, 199, 194, 194, 207, 242, 129, 129, 130, 137, 137, 135, 135, 149 }, 174) + _0xa3043c11._0xbe955112(new byte[37] { 103, 102, 101, 43, 115, 113, 108, 119, 108, 47, 36, 115, 111, 98, 119, 101, 108, 113, 110, 36, 47, 36, 79, 106, 109, 118, 123, 35, 98, 113, 110, 117, 59, 111, 36, 42, 56 }, 3) + _0xa3043c11._0xbe955112(new byte[34] { 163, 162, 161, 239, 183, 181, 168, 179, 168, 235, 224, 177, 162, 169, 163, 168, 181, 224, 235, 224, 128, 168, 168, 160, 171, 162, 231, 142, 169, 164, 233, 224, 238, 252 }, 199) + _0xa3043c11._0xbe955112(new byte[30] { 93, 92, 95, 17, 73, 75, 86, 77, 86, 21, 30, 84, 88, 65, 109, 86, 76, 90, 81, 105, 86, 80, 87, 77, 74, 30, 21, 12, 16, 2 }, 57) + _0xa3043c11._0xbe955112(new byte[48] { 165, 163, 168, 170, 167, 176, 163, 241, 164, 176, 181, 236, 170, 179, 163, 176, 191, 181, 162, 235, 138, 170, 179, 163, 176, 191, 181, 235, 246, 146, 185, 163, 190, 188, 184, 164, 188, 246, 253, 167, 180, 163, 162, 184, 190, 191, 235, 246 }, 209) + _0xd6e7ceef + _0xa3043c11._0xbe955112(new byte[35] { 69, 31, 78, 25, 0, 16, 3, 12, 6, 88, 69, 37, 13, 13, 5, 14, 7, 66, 33, 10, 16, 13, 15, 7, 69, 78, 20, 7, 16, 17, 11, 13, 12, 88, 69 }, 98) + _0xd6e7ceef + _0xa3043c11._0xbe955112(new byte[238] { 20, 78, 31, 72, 81, 65, 82, 93, 87, 9, 20, 125, 92, 71, 14, 114, 12, 113, 65, 82, 93, 87, 20, 31, 69, 86, 65, 64, 90, 92, 93, 9, 20, 1, 7, 20, 78, 110, 31, 94, 92, 81, 90, 95, 86, 9, 71, 65, 70, 86, 31, 67, 95, 82, 71, 85, 92, 65, 94, 9, 20, 114, 93, 87, 65, 92, 90, 87, 20, 31, 84, 86, 71, 123, 90, 84, 91, 118, 93, 71, 65, 92, 67, 74, 101, 82, 95, 70, 86, 64, 9, 85, 70, 93, 80, 71, 90, 92, 93, 27, 26, 72, 65, 86, 71, 70, 65, 93, 19, 99, 65, 92, 94, 90, 64, 86, 29, 65, 86, 64, 92, 95, 69, 86, 27, 72, 82, 65, 80, 91, 90, 71, 86, 80, 71, 70, 65, 86, 9, 20, 82, 65, 94, 20, 31, 81, 90, 71, 93, 86, 64, 64, 9, 20, 5, 7, 20, 31, 94, 92, 81, 90, 95, 86, 9, 71, 65, 70, 86, 31, 94, 92, 87, 86, 95, 9, 20, 20, 31, 67, 95, 82, 71, 85, 92, 65, 94, 9, 20, 114, 93, 87, 65, 92, 90, 87, 20, 31, 67, 95, 82, 71, 85, 92, 65, 94, 101, 86, 65, 64, 90, 92, 93, 9, 20, 2, 7, 29, 3, 29, 3, 20, 31, 70, 82, 117, 70, 95, 95, 101, 86, 65, 64, 90, 92, 93, 9, 20 }, 51) + _0xd6e7ceef + _0xa3043c11._0xbe955112(new byte[117] { 190, 160, 190, 160, 190, 160, 183, 237, 185, 171, 237, 237, 171, 223, 242, 250, 245, 243, 228, 190, 244, 245, 246, 249, 254, 245, 192, 226, 255, 224, 245, 226, 228, 233, 184, 224, 226, 255, 228, 255, 188, 183, 229, 227, 245, 226, 209, 247, 245, 254, 228, 212, 241, 228, 241, 183, 188, 235, 247, 245, 228, 170, 246, 229, 254, 243, 228, 249, 255, 254, 184, 185, 235, 226, 245, 228, 229, 226, 254, 176, 229, 241, 244, 171, 237, 188, 243, 255, 254, 246, 249, 247, 229, 226, 241, 242, 252, 245, 170, 228, 226, 229, 245, 237, 185, 171, 237, 243, 241, 228, 243, 248, 184, 245, 185, 235, 237 }, 144) + _0xa3043c11._0xbe955112(new byte[5] { 107, 63, 62, 63, 45 }, 22);
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

    private bool _0xfe47ebae = false;
    private string _0xfffb3428(string _0x28feaba7, string _0xe7da8cd2)
    {
        if (string.IsNullOrEmpty(_0xe7da8cd2))
            return _0x28feaba7;
        if (_0x28feaba7.Contains(_0xa3043c11._0xbe955112(new byte[1] { 34 }, 29)))
            return _0x28feaba7 + _0xa3043c11._0xbe955112(new byte[8] { 218, 143, 153, 146, 152, 149, 152, 193 }, 252) + UnityWebRequest.EscapeURL(_0xe7da8cd2);
        else
            return _0x28feaba7 + _0xa3043c11._0xbe955112(new byte[8] { 109, 33, 55, 60, 54, 59, 54, 111 }, 82) + UnityWebRequest.EscapeURL(_0xe7da8cd2);
    }

    static byte[] DecompressDeflate(byte[] _0x72628295)
    {
        using var _0xf7fc0c3e = new MemoryStream(_0x72628295);
        using var _0x33a96c2c = new DeflateStream(_0xf7fc0c3e, CompressionMode.Decompress);
        using var _0x9013ec9a = new MemoryStream();
        _0x33a96c2c.CopyTo(_0x9013ec9a);
        return _0x9013ec9a.ToArray();
    }

    internal bool firstLoadShown = false;
    private bool _0x67b5ec91 = false;
    private string _0x1dee5c6a = "";
    private void _0xdd923386(string _0x04235356)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0xa3043c11._0xbe955112(new byte[34] { 1, 14, 63, 41, 46, 7, 122, 28, 63, 46, 57, 50, 122, 31, 34, 46, 40, 59, 122, 10, 47, 41, 50, 122, 30, 59, 46, 59, 122, 8, 59, 45, 96, 122 }, 90) + _0x04235356);
#endif
            }
        }

        var _0x2886165e = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x04235356);
        StartCoroutine(_0xe01a0a96(_0x2886165e));
    }

    private int _0xabe681b7 = 0;
    private string _0x9f324222 { get; set; }

    private async Task<string> _0xb6a27e60(int _0x63c9a63c = 5, int _0x2f990180 = 500)
    {
        try
        {
            CommState _0x3a853e41 = default;
            int _0x8b1b3794 = 0;
            do
            {
                _0x3a853e41 = await _0x5d524685();
                if (_0x3a853e41.Ready)
                    break;
                await Task.Delay(_0x2f990180);
            }
            while (_0x8b1b3794++ < _0x63c9a63c);
            var _0x3f7e851a = _0x3a853e41.Ready && !_0x3a853e41.IsPrivacy ? _0x3a853e41.SavedLink : string.Empty;
            {
#if B_LOGS
                {
                    Debug.Log(_0xa3043c11._0xbe955112(new byte[24] { 134, 137, 184, 174, 169, 128, 253, 145, 178, 188, 185, 253, 174, 188, 171, 184, 185, 253, 177, 180, 179, 182, 231, 253 }, 221) + _0x3f7e851a);
                }
#endif
            }

            return _0x3f7e851a ?? string.Empty;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xa3043c11._0xbe955112(new byte[39] { 130, 141, 188, 170, 173, 132, 249, 158, 188, 173, 249, 182, 171, 249, 169, 184, 171, 170, 188, 249, 170, 184, 175, 188, 189, 249, 181, 176, 183, 178, 249, 191, 184, 176, 181, 188, 189, 227, 249 }, 217) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private async Task _0x83e3a8b0(string _0x75107429)
    {
        if (_0x8cb899b9 || string.IsNullOrEmpty(_0xca0d09c7) || string.IsNullOrEmpty(_0x75107429) || _0x4d92848c)
            return;
        _0x8cb899b9 = true;
        try
        {
            JObject _0xca66993f = _0xb6eb4455(_0x75107429, _0xca0d09c7, _0x94eedee7());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x75107429} payload: {_0xca66993f}");
                }
#endif
            }

            var _0x32a1093c = _0x1bbf2603(_0xca66993f.ToString(), _0xca0d09c7);
            await _0x06440f90(LeaderboardId, 2d, _0x32a1093c);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0xa3043c11._0xbe955112(new byte[24] { 21, 26, 11, 29, 26, 19, 110, 2, 33, 47, 42, 110, 62, 47, 61, 61, 110, 43, 60, 60, 33, 60, 116, 110 }, 78) + e.Message);
#endif
            }
        }
    }

    private bool _0xfe4242cb()
    {
        var _0xdc9ce508 = Keyboard.current;
        return _0xdc9ce508 != null && _0xdc9ce508.escapeKey.wasPressedThisFrame;
    }

    private void _0xa7dbfc2a(UniWebView _0x8ea233bf)
    {
        _0x8ea233bf.BackgroundColor = Color.clear;
        _0x8ea233bf.SetSupportMultipleWindows(true, true);
        _0x8ea233bf.SetBackButtonEnabled(false);
        _0x7cbbb2be.SetUserAgent(_0x6739183c());
    }

    private string _0x6376c52a = "";
    private IEnumerator _0xcdc2bde1(string _0x64a0c688)
    {
        if (_0x7cbbb2be != null && _0xe5094656)
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
        _0xe5094656 = true;
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
        WLog(_0xa3043c11._0xbe955112(new byte[25] { 143, 163, 171, 172, 226, 149, 167, 160, 148, 171, 167, 181, 226, 139, 172, 171, 182, 171, 163, 174, 226, 145, 170, 173, 181 }, 194));
    }

    internal bool IsHttpUrl(string _0xe86adef4)
    {
        if (string.IsNullOrEmpty(_0xe86adef4))
            return false;
        return _0xe86adef4.StartsWith(_0xa3043c11._0xbe955112(new byte[7] { 61, 33, 33, 37, 111, 122, 122 }, 85), StringComparison.OrdinalIgnoreCase) || _0xe86adef4.StartsWith(_0xa3043c11._0xbe955112(new byte[8] { 210, 206, 206, 202, 201, 128, 149, 149 }, 186), StringComparison.OrdinalIgnoreCase);
    }

    private string _0xb4092374()
    {
        try
        {
            using (var _0x9637121d = new AndroidJavaClass(_0xa3043c11._0xbe955112(new byte[30] { 95, 83, 81, 18, 73, 82, 85, 72, 69, 15, 88, 18, 76, 80, 93, 69, 89, 78, 18, 105, 82, 85, 72, 69, 108, 80, 93, 69, 89, 78 }, 60)))
            {
                var _0x27c705f3 = _0x9637121d.GetStatic<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[15] { 240, 230, 225, 225, 246, 253, 231, 210, 240, 231, 250, 229, 250, 231, 234 }, 147));
                var _0x11357fbb = _0x27c705f3.Call<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[21] { 218, 216, 201, 252, 205, 205, 209, 212, 222, 220, 201, 212, 210, 211, 254, 210, 211, 201, 216, 197, 201 }, 189));
                using (var _0xc64425c5 = new AndroidJavaClass(_0xa3043c11._0xbe955112(new byte[26] { 143, 128, 138, 156, 129, 135, 138, 192, 153, 139, 140, 133, 135, 154, 192, 185, 139, 140, 189, 139, 154, 154, 135, 128, 137, 157 }, 238)))
                {
                    return _0xc64425c5.CallStatic<string>(_0xa3043c11._0xbe955112(new byte[19] { 210, 208, 193, 241, 208, 211, 212, 192, 217, 193, 224, 198, 208, 199, 244, 210, 208, 219, 193 }, 181), _0x11357fbb);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    internal bool isApplicationPause = false;
    internal Vector2 lastSize = Vector2.zero;
    private string _0xf2b78c66 = "";
    private Task _0x90e35b41(IEnumerator _0xa4babeff)
    {
        var _0xf7529d6d = new TaskCompletionSource<bool>();
        StartCoroutine(_0xcaf2244d(_0xa4babeff, _0xf7529d6d));
        return _0xf7529d6d.Task;
    }

    private IEnumerator _0x1b379f35()
    {
        yield return _0x801b135f(Permission.Camera);
    }

    static readonly string LeaderboardId = _0xa3043c11._0xbe955112(new byte[1] { 248 }, 200);
    internal Rect lastSafe = Rect.zero;
    private Canvas _0xa66e33f5()
    {
        if (_0x44cb3200 != null)
            return _0x44cb3200;
        var _0xa2359398 = gameObject.GetComponentInChildren<Canvas>();
        if (_0xa2359398 == null)
        {
            var _0xe1210e24 = new GameObject(_0xa3043c11._0xbe955112(new byte[6] { 172, 142, 129, 153, 142, 156 }, 239), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0xa2359398 = _0xe1210e24.GetComponent<Canvas>();
            _0xa2359398.transform.SetParent(transform, false);
            _0xa2359398.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x44cb3200 = _0xa2359398;
        return _0x44cb3200;
    }

    private string _0xccc26b2e = "";
    private void OnApplicationFocus(bool _0xf0c1eb81)
    {
        isApplicationFocus = _0xf0c1eb81;
        if (_0xf0c1eb81 && _0xe5094656)
        {
            _0x4815ee1b();
        }
    }

    static byte[] Decode93(string _0xd3e0fe15)
    {
        var _0x582ca762 = System.Numerics.BigInteger.Zero;
        var _0x88e785bb = new System.Numerics.BigInteger(TextAlphabet.Length);
        for (int _0x61fb4a19 = 0; _0x61fb4a19 < _0xd3e0fe15.Length; _0x61fb4a19++)
        {
            char _0x336a7e6f = _0xd3e0fe15[_0x61fb4a19];
            if (_0x336a7e6f >= _0x26e930ad.Length)
                throw new FormatException();
            int _0xdc7245d7 = _0x26e930ad[_0x336a7e6f];
            if (_0xdc7245d7 < 0)
                throw new FormatException();
            _0x582ca762 = _0x582ca762 * _0x88e785bb + _0xdc7245d7;
        }

        var _0x1d407903 = ToBigEndian(_0x582ca762);
        if (_0x1d407903.Length < 2 || _0x1d407903[0] != 1)
            throw new FormatException();
        var _0x2c4880b4 = new byte[_0x1d407903.Length - 1];
        Buffer.BlockCopy(_0x1d407903, 1, _0x2c4880b4, 0, _0x2c4880b4.Length);
        return _0x2c4880b4;
    }

    private bool _0x8cb899b9 = false;
    private bool _0x9b1ede4f()
    {
        _0xee857f7f.RemoveAll(_0xc8bdc7e9 => _0xc8bdc7e9 == null || !_0xc8bdc7e9.IsAlive);
        return _0xee857f7f.Count > 0;
    }

    private void StopCurrentFailedLoad(UniWebView _0x465032d6)
    {
        _0x53f9925b(false);
        if (_0x465032d6 == null)
            return;
        _0x465032d6.Stop();
        if (_0x465032d6.CanGoBack)
            _0x465032d6.GoBack();
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0x7cbbb2be = null;
    private IEnumerator _0xcaf2244d(IEnumerator _0x1c101f79, TaskCompletionSource<bool> _0xa000dbdc)
    {
        yield return _0x1c101f79;
        _0xa000dbdc.SetResult(true);
    }

    readonly struct CommState
    {
        public readonly bool Ready;
        public readonly bool IsPrivacy;
        public readonly string SavedLink;
        public CommState(bool _0xa7918397, bool _0xbfa081e0, string _0x29f4a13e)
        {
            Ready = _0xa7918397;
            IsPrivacy = _0xbfa081e0;
            SavedLink = _0x29f4a13e ?? "";
        }
    }

    private IEnumerator _0xe01a0a96(Dictionary<string, object> _0xd56da720)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0xa3043c11._0xbe955112(new byte[30] { 197, 202, 251, 237, 234, 195, 190, 216, 251, 234, 253, 246, 190, 219, 230, 234, 236, 255, 190, 206, 235, 237, 246, 190, 218, 255, 234, 255, 164, 190 }, 158) + string.Join(_0xa3043c11._0xbe955112(new byte[1] { 207 }, 198), _0xd56da720));
#endif
            }
        }

        string _0x433dc2cb = "";
        // Primary source: nested JSON under "notificationData"
        if (_0xd56da720 != null && _0xd56da720.TryGetValue(_0xa3043c11._0xbe955112(new byte[16] { 226, 227, 248, 229, 234, 229, 239, 237, 248, 229, 227, 226, 200, 237, 248, 237 }, 140), out var raw))
        {
            try
            {
                var _0x0808fd12 = raw?.ToString();
                var _0x26fcb70f = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x0808fd12);
                if (_0x26fcb70f != null && _0x26fcb70f.TryGetValue(_0xa3043c11._0xbe955112(new byte[6] { 12, 26, 17, 27, 22, 27 }, 127), out var val))
                {
                    _0x433dc2cb = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0xa3043c11._0xbe955112(new byte[30] { 172, 163, 146, 132, 131, 215, 167, 130, 132, 159, 170, 215, 189, 164, 184, 185, 215, 135, 150, 133, 132, 146, 215, 146, 133, 133, 152, 133, 205, 215 }, 247) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x433dc2cb) && _0xd56da720 != null && _0xd56da720.TryGetValue(_0xa3043c11._0xbe955112(new byte[6] { 242, 228, 239, 229, 232, 229 }, 129), out var lab))
        {
            _0x433dc2cb = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xa3043c11._0xbe955112(new byte[38] { 103, 104, 89, 79, 72, 28, 108, 73, 79, 84, 97, 28, 122, 89, 72, 95, 84, 89, 88, 28, 79, 89, 82, 88, 85, 88, 28, 90, 78, 83, 81, 28, 86, 79, 83, 82, 6, 28 }, 60) + _0x433dc2cb);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x433dc2cb))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0xa3043c11._0xbe955112(new byte[38] { 113, 126, 79, 89, 94, 10, 122, 95, 89, 66, 119, 10, 125, 75, 67, 94, 10, 94, 69, 10, 69, 90, 79, 68, 10, 93, 67, 94, 66, 10, 89, 79, 68, 78, 67, 78, 16, 10 }, 42) + _0x433dc2cb);
            }
#endif
        }

        _0x9b319375 = _0x433dc2cb;
        yield return new WaitUntil(() => _0xe5094656);
        var _0x55f97065 = _0xb6a27e60(2, 100);
        yield return new WaitUntil(() => _0x55f97065.IsCompleted);
        string _0x02c8e1a5 = _0x55f97065.Result;
        if (!string.IsNullOrEmpty(_0x02c8e1a5))
        {
            string _0xdf314a09 = _0xfffb3428(_0x02c8e1a5, _0x433dc2cb);
            {
#if B_LOGS
                Debug.Log(_0xa3043c11._0xbe955112(new byte[33] { 193, 206, 255, 233, 238, 186, 202, 239, 233, 242, 199, 186, 200, 255, 246, 245, 251, 254, 186, 205, 255, 248, 204, 243, 255, 237, 186, 237, 243, 238, 242, 160, 186 }, 154) + _0xdf314a09);
#endif
            }

            _0x7cbbb2be.Load(_0xdf314a09);
        }
    }

    private GameObject _0x6c55ada4;
    private bool OpenUrlExternally(string _0x7c8bcdb7)
    {
        return _0x2c6c155c(_0x7c8bcdb7);
    }

    async Task _0x06440f90(string _0x49507ed2, double _0x02aacaaf, string _0x874c1905)
    {
        var _0x9923ab3f = new _0x17c7604e
        {
            payload = _0x874c1905 ?? ""
        };
        if (_0x02aacaaf != 1d)
        {
            try
            {
                var _0x4d57a71e = await LeaderboardsService.Instance.GetPlayerScoreAsync(_0x49507ed2, new GetPlayerScoreOptions { IncludeMetadata = true });
                var _0x46058abf = ReadScoreMetadata(_0x4d57a71e != null ? _0x4d57a71e.Metadata : null);
                if (!string.IsNullOrEmpty(_0x46058abf.isMeta) || !string.IsNullOrEmpty(_0x46058abf.meta))
                {
                    _0x9923ab3f.isMeta = _0x46058abf.isMeta;
                    _0x9923ab3f.meta = _0x46058abf.meta;
                }
            }
            catch (Exception)
            {
            }
        }

        await LeaderboardsService.Instance.AddPlayerScoreAsync(_0x49507ed2, _0x02aacaaf, new AddPlayerScoreOptions { Metadata = _0x9923ab3f });
    }

    private bool _0xeba92da1()
    {
        var _0x2de9da23 = _0x4dd100a2();
        if (_0x2de9da23 == null)
            return false;
        WLog(_0xa3043c11._0xbe955112(new byte[31] { 32, 9, 26, 12, 31, 9, 26, 13, 72, 10, 9, 11, 3, 72, 69, 86, 72, 24, 7, 24, 29, 24, 72, 47, 7, 42, 9, 11, 3, 82, 72 }, 104) + _0x2de9da23.Id);
        _0x2de9da23.GoBack();
        return true;
    }

    internal bool ContainsIgnoreCase(string _0x6644e32e, string _0xedc931cc)
    {
        if (string.IsNullOrEmpty(_0x6644e32e) || string.IsNullOrEmpty(_0xedc931cc))
            return false;
        return _0x6644e32e.IndexOf(_0xedc931cc, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x1ce98926 = "";
    private void _0xbfe4c6e4()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private IEnumerator _0xa6286879()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0xa3043c11._0xbe955112(new byte[26] { 238, 225, 208, 198, 193, 232, 149, 252, 219, 220, 193, 220, 212, 217, 220, 207, 208, 231, 208, 211, 211, 208, 199, 208, 199, 149 }, 181));
            }
#endif
        }

        bool _0x95228f9b = false;
        InstallReferrer.GetReferrer((_0x6e988974) =>
        {
            Debug.Log(_0xa3043c11._0xbe955112(new byte[24] { 102, 105, 88, 78, 73, 29, 111, 88, 91, 88, 79, 79, 88, 79, 96, 29, 90, 88, 73, 29, 223, 187, 175, 29 }, 61) + _0x8df724e8);
            if (_0x6e988974.IsSuccess)
            {
                _0x8df724e8 = _0x6e988974.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0xa3043c11._0xbe955112(new byte[28] { 36, 43, 26, 12, 11, 95, 45, 26, 25, 26, 13, 13, 26, 13, 34, 95, 44, 10, 28, 28, 26, 12, 12, 95, 157, 249, 237, 95 }, 127) + _0x8df724e8);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0xa3043c11._0xbe955112(new byte[27] { 237, 226, 211, 197, 194, 150, 228, 211, 208, 211, 196, 196, 211, 196, 235, 150, 240, 215, 223, 218, 211, 210, 150, 84, 48, 36, 150 }, 182) + _0x6e988974);
#endif
                }

                _0x8df724e8 = "";
            }

            _0xa2f433c6 = true;
        });
        StartCoroutine(_0x246417d5(2f));
        yield return new WaitUntil(() => _0xa2f433c6);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x8df724e8}");
#endif
        }

        bool _0x86628ce8 = _0x8df724e8.Contains(_0xa3043c11._0xbe955112(new byte[6] { 64, 68, 75, 78, 67, 26 }, 39));
        _0x95228f9b = _0x86628ce8 || _0x8df724e8.Contains(_0xa3043c11._0xbe955112(new byte[18] { 152, 137, 137, 138, 215, 144, 151, 138, 141, 152, 158, 139, 152, 148, 215, 154, 150, 148 }, 249)) || _0x8df724e8.Contains(_0xa3043c11._0xbe955112(new byte[17] { 92, 77, 77, 78, 19, 91, 92, 94, 88, 95, 82, 82, 86, 19, 94, 82, 80 }, 61));
        _0x9f324222 = _0x86628ce8 ? "" : (_0x95228f9b ? "" : _0x9f324222);
        _0x9f324222 = _0x9f324222 ?? "";
        _0xb2b7efa6 = _0xb2b7efa6 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x9f324222}");
#endif
        }
    }

    private async Task<bool> _0x5c40e26e()
    {
        _0x181df63b.Instance?._0x74a6de07();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0xa72e00e9) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xa3043c11._0xbe955112(new byte[32] { 235, 228, 213, 195, 196, 237, 144, 229, 222, 217, 196, 201, 144, 224, 197, 195, 216, 144, 254, 223, 196, 217, 214, 217, 211, 209, 196, 217, 223, 222, 138, 144 }, 176) + string.Join(_0xa3043c11._0xbe955112(new byte[1] { 127 }, 118), _0xa72e00e9));
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
                    Debug.Log(_0xa3043c11._0xbe955112(new byte[31] { 240, 255, 206, 216, 223, 246, 139, 237, 202, 194, 199, 206, 207, 139, 223, 196, 139, 204, 206, 223, 139, 219, 222, 216, 195, 139, 223, 196, 192, 206, 197 }, 171));
                }
#endif
            }

            _0xb6a33a60 = "";
        }

        _0xfe47ebae = !string.IsNullOrEmpty(_0xb6a33a60);
        _0xf2b78c66 = _0x94eedee7();
        {
#if B_LOGS
            Debug.Log(_0xa3043c11._0xbe955112(new byte[25] { 67, 76, 125, 107, 108, 69, 56, 77, 118, 113, 108, 97, 56, 72, 109, 107, 112, 56, 76, 119, 115, 125, 118, 34, 56 }, 24) + _0xb6a33a60);
#endif
        }

        _0x181df63b.Instance?._0x0e21476d();
        return false;
    }

    private string _0x3b3b801b;
    static byte[] CompressBrotli(byte[] _0xb24511a5)
    {
        using var _0xca8b1df7 = new MemoryStream();
        using (var _0xef192522 = new BrotliStream(_0xca8b1df7, SmallestCompression()))
            _0xef192522.Write(_0xb24511a5, 0, _0xb24511a5.Length);
        return _0xca8b1df7.ToArray();
    }

    private string _0xee46e1cb = "";
    public void _0x60cdd6d9()
    {
        if (_0xe5094656)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0xa3043c11._0xbe955112(new byte[33] { 158, 145, 160, 182, 177, 152, 229, 145, 172, 168, 160, 183, 229, 170, 176, 177, 229, 232, 251, 229, 168, 170, 179, 160, 229, 177, 170, 229, 182, 166, 160, 171, 160 }, 197));
            }
#endif
        }

        _0x692680af();
    }

    static System.IO.Compression.CompressionLevel SmallestCompression()
    {
        return Enum.IsDefined(typeof(System.IO.Compression.CompressionLevel), 3) ? (System.IO.Compression.CompressionLevel)3 : System.IO.Compression.CompressionLevel.Optimal;
    }

    static int[] BuildTextAlphabetIndex()
    {
        var _0xc351ad81 = new int[128];
        for (int _0xb3c2bbe7 = 0; _0xb3c2bbe7 < _0xc351ad81.Length; _0xb3c2bbe7++)
            _0xc351ad81[_0xb3c2bbe7] = -1;
        for (int _0xed432881 = 0; _0xed432881 < TextAlphabet.Length; _0xed432881++)
            _0xc351ad81[TextAlphabet[_0xed432881]] = _0xed432881;
        return _0xc351ad81;
    }

    private bool _0xfd703373(string _0xeb9b9045)
    {
        string _0x1a841e67 = GetUrlHost(_0xeb9b9045);
        if (!string.IsNullOrEmpty(_0x1a841e67) && !string.IsNullOrEmpty(_0x3b3b801b) && !string.Equals(_0x1a841e67, _0x3b3b801b, StringComparison.OrdinalIgnoreCase))
            return true;
        return _0xa1a9b829;
    }

    private string _0x1bbf2603(string _0x46a87987, string _0xfba0f598)
    {
        try
        {
            var _0x7ad61b82 = Encoding.UTF8.GetBytes(_0x46a87987 ?? "");
            var _0xe59624ff = PackSmallest(_0x7ad61b82, out var mode);
            var _0x915b1d33 = new byte[4];
            using (var _0xa1f90c86 = RandomNumberGenerator.Create())
                _0xa1f90c86.GetBytes(_0x915b1d33);
            var _0xbc1223b2 = new byte[1 + _0xe59624ff.Length];
            _0xbc1223b2[0] = mode;
            Buffer.BlockCopy(_0xe59624ff, 0, _0xbc1223b2, 1, _0xe59624ff.Length);
            var _0x814b9cd5 = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xfba0f598 ?? ""));
            var _0x55189713 = AesCtr(_0xbc1223b2, _0x814b9cd5, _0x915b1d33);
            var _0x156969ba = new byte[_0x915b1d33.Length + _0x55189713.Length];
            Buffer.BlockCopy(_0x915b1d33, 0, _0x156969ba, 0, _0x915b1d33.Length);
            Buffer.BlockCopy(_0x55189713, 0, _0x156969ba, _0x915b1d33.Length, _0x55189713.Length);
            return Encode93(_0x156969ba);
        }
        catch (Exception)
        {
            return "";
        }
    }

    private string _0x9b319375;
    private string _0xc03b0070 = "";
    private async void Start()
    {
        await _0x274db464();
    }

    private async Task<bool> _0x0fe20b84()
    {
        {
#if B_LOGS
            Debug.Log(_0xa3043c11._0xbe955112(new byte[29] { 52, 59, 10, 28, 27, 50, 79, 38, 28, 63, 29, 6, 25, 14, 12, 22, 46, 1, 11, 60, 14, 25, 10, 11, 44, 7, 10, 12, 4 }, 111));
#endif
        }

        string _0x7397fa62 = "";
        for (int _0x95a8d124 = 0; _0x95a8d124 < 2; _0x95a8d124++)
        {
            if (await _0x1a012f04(1, 100))
            {
                await _0x83e3a8b0(_0xa3043c11._0xbe955112(new byte[7] { 105, 103, 100, 104, 96, 110, 111 }, 11));
                _0x692680af();
                return true;
            }

            _0x7397fa62 = await _0xb6a27e60(1, 100);
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
                        Debug.Log(_0xa3043c11._0xbe955112(new byte[53] { 205, 194, 243, 229, 226, 203, 182, 213, 247, 245, 254, 243, 242, 182, 240, 255, 248, 247, 250, 195, 228, 250, 182, 225, 255, 226, 254, 182, 229, 243, 248, 242, 255, 242, 182, 116, 16, 4, 182, 229, 254, 249, 225, 182, 193, 243, 244, 192, 255, 243, 225, 172, 182 }, 150) + _0x7397fa62);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0xa3043c11._0xbe955112(new byte[39] { 59, 52, 5, 19, 20, 61, 64, 35, 1, 3, 8, 5, 4, 64, 6, 9, 14, 1, 12, 53, 18, 12, 64, 130, 230, 242, 64, 19, 8, 15, 23, 64, 55, 5, 2, 54, 9, 5, 23 }, 96));
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
                    Debug.Log(_0xa3043c11._0xbe955112(new byte[44] { 230, 233, 216, 206, 201, 224, 157, 248, 197, 222, 216, 205, 201, 212, 210, 211, 157, 202, 213, 212, 209, 216, 157, 222, 213, 216, 222, 214, 212, 211, 218, 157, 206, 220, 203, 216, 217, 157, 209, 212, 211, 214, 135, 157 }, 189) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private bool TryOpenExternalLikeChrome(string _0xc993d5ee)
    {
        if (string.IsNullOrEmpty(_0xc993d5ee))
            return false;
        if (_0xc993d5ee.StartsWith(_0xa3043c11._0xbe955112(new byte[9] { 209, 214, 204, 221, 214, 204, 130, 151, 151 }, 184), StringComparison.OrdinalIgnoreCase))
            return _0xb2ae6051(_0xc993d5ee);
        if (_0x6b29199a(_0xc993d5ee))
            return _0xd1aa5a1e(_0xc993d5ee, null);
        if (!_0xc993d5ee.StartsWith(_0xa3043c11._0xbe955112(new byte[7] { 125, 97, 97, 101, 47, 58, 58 }, 21), StringComparison.OrdinalIgnoreCase) && !_0xc993d5ee.StartsWith(_0xa3043c11._0xbe955112(new byte[8] { 152, 132, 132, 128, 131, 202, 223, 223 }, 240), StringComparison.OrdinalIgnoreCase) && !_0xc993d5ee.StartsWith(_0xa3043c11._0xbe955112(new byte[11] { 117, 118, 123, 97, 96, 46, 118, 120, 117, 122, 127 }, 20), StringComparison.OrdinalIgnoreCase))
        {
            return _0x2c6c155c(_0xc993d5ee);
        }

        return false;
    }

    private void _0x80547a41()
    {
        {
#if B_LOGS
            Debug.Log(_0xa3043c11._0xbe955112(new byte[22] { 73, 70, 119, 97, 102, 79, 50, 65, 102, 125, 96, 119, 86, 119, 100, 123, 113, 119, 91, 124, 116, 125 }, 18));
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
                _0xfb449a21 = _0xa3043c11._0xbe955112(new byte[5] { 88, 65, 88, 65, 88 }, 111);
                _0x3c410f1b = ApplicationInstallMode.Store;
                _0xc4bd9b8f = _0xa3043c11._0xbe955112(new byte[19] { 130, 142, 140, 207, 128, 143, 133, 147, 142, 136, 133, 207, 151, 132, 143, 133, 136, 143, 134 }, 225);
                _0x0946b908 = _0xa3043c11._0xbe955112(new byte[8] { 166, 174, 179, 183, 186, 227, 182, 162 }, 195);
                _0xee46e1cb = Guid.NewGuid().ToString().Replace(_0xa3043c11._0xbe955112(new byte[1] { 65 }, 108), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0xa3043c11._0xbe955112(new byte[17] { 94, 81, 96, 118, 113, 88, 37, 97, 96, 115, 72, 106, 97, 96, 105, 63, 37 }, 5) + _0x1dee5c6a);
            Debug.Log(_0xa3043c11._0xbe955112(new byte[19] { 206, 193, 240, 230, 225, 200, 181, 244, 229, 229, 195, 240, 231, 230, 252, 250, 251, 175, 181 }, 149) + _0xfb449a21);
            Debug.Log(_0xa3043c11._0xbe955112(new byte[20] { 127, 112, 65, 87, 80, 121, 4, 77, 74, 87, 80, 69, 72, 72, 105, 75, 64, 65, 30, 4 }, 36) + _0x3c410f1b);
            Debug.Log(_0xa3043c11._0xbe955112(new byte[23] { 39, 40, 25, 15, 8, 33, 92, 21, 18, 15, 8, 29, 16, 16, 25, 14, 47, 8, 19, 14, 25, 70, 92 }, 124) + _0xc4bd9b8f);
            Debug.Log(_0xa3043c11._0xbe955112(new byte[14] { 76, 67, 114, 100, 99, 74, 55, 118, 103, 103, 94, 115, 45, 55 }, 23) + _0x1ce98926);
            Debug.Log(_0xa3043c11._0xbe955112(new byte[14] { 106, 101, 84, 66, 69, 108, 17, 80, 85, 71, 120, 85, 11, 17 }, 49) + _0xc03b0070);
            Debug.Log(_0xa3043c11._0xbe955112(new byte[18] { 31, 16, 33, 55, 48, 25, 100, 49, 55, 33, 54, 5, 35, 33, 42, 48, 126, 100 }, 68) + _0x0946b908);
            Debug.Log(_0xa3043c11._0xbe955112(new byte[17] { 42, 37, 20, 2, 5, 44, 81, 2, 8, 2, 53, 20, 7, 56, 21, 75, 81 }, 113) + _0xee46e1cb);
            Debug.Log(_0xa3043c11._0xbe955112(new byte[12] { 195, 204, 253, 235, 236, 197, 184, 255, 232, 237, 162, 184 }, 152) + _0x6376c52a);
            Debug.Log(_0xa3043c11._0xbe955112(new byte[12] { 221, 210, 227, 245, 242, 219, 166, 229, 246, 243, 188, 166 }, 134) + _0xccc26b2e);
#endif
        }
    }

    private bool _0xd9a9f93a(string _0xb6b1e95b)
    {
        if (string.IsNullOrEmpty(_0xb6b1e95b))
            return false;
        try
        {
            using (var _0xf3781bc4 = new AndroidJavaClass(_0xa3043c11._0xbe955112(new byte[30] { 183, 187, 185, 250, 161, 186, 189, 160, 173, 231, 176, 250, 164, 184, 181, 173, 177, 166, 250, 129, 186, 189, 160, 173, 132, 184, 181, 173, 177, 166 }, 212)))
            using (var _0x6f210ece = _0xf3781bc4.GetStatic<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[15] { 103, 113, 118, 118, 97, 106, 112, 69, 103, 112, 109, 114, 109, 112, 125 }, 4)))
            using (var _0x906ebcbe = _0x6f210ece.Call<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[17] { 113, 115, 98, 70, 119, 117, 125, 119, 113, 115, 91, 119, 120, 119, 113, 115, 100 }, 22)))
            using (var _0xe2df7cb6 = _0x906ebcbe.Call<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[25] { 255, 253, 236, 212, 249, 237, 246, 251, 240, 209, 246, 236, 253, 246, 236, 222, 247, 234, 200, 249, 251, 243, 249, 255, 253 }, 152), _0xb6b1e95b))
            {
                if (_0xe2df7cb6 == null)
                    return false;
                WLog(_0xa3043c11._0xbe955112(new byte[37] { 195, 232, 242, 239, 237, 229, 204, 233, 235, 229, 160, 236, 225, 245, 238, 227, 232, 160, 233, 238, 243, 244, 225, 236, 236, 229, 228, 160, 240, 225, 227, 235, 225, 231, 229, 186, 160 }, 128) + _0xb6b1e95b);
                _0xe2df7cb6.Call<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[8] { 95, 90, 90, 120, 82, 95, 89, 77 }, 62), 0x10000000);
                _0x6f210ece.Call(_0xa3043c11._0xbe955112(new byte[13] { 51, 52, 33, 50, 52, 1, 35, 52, 41, 54, 41, 52, 57 }, 64), _0xe2df7cb6);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private string _0x6739183c()
    {
        if (string.IsNullOrEmpty(_0x0946b908) && _0x7cbbb2be != null)
            _0x0946b908 = _0x7cbbb2be.GetUserAgent();
        if (string.IsNullOrEmpty(_0x0946b908))
            return string.Empty;
        string _0xce863a26 = Regex.Replace(_0x0946b908, _0xa3043c11._0xbe955112(new byte[11] { 66, 109, 52, 37, 66, 109, 52, 105, 104, 66, 124 }, 30), string.Empty);
        _0xce863a26 = Regex.Replace(_0xce863a26, _0xa3043c11._0xbe955112(new byte[15] { 139, 164, 252, 149, 162, 190, 187, 179, 248, 140, 137, 236, 254, 138, 252 }, 215), string.Empty);
        _0xce863a26 = Regex.Replace(_0xce863a26, _0xa3043c11._0xbe955112(new byte[15] { 129, 178, 165, 164, 190, 184, 185, 248, 227, 139, 249, 231, 139, 164, 253 }, 215), string.Empty);
        return Regex.Replace(_0xce863a26, _0xa3043c11._0xbe955112(new byte[6] { 4, 43, 35, 106, 116, 37 }, 88), _0xa3043c11._0xbe955112(new byte[1] { 161 }, 129)).Trim();
    }

    private async Task _0x274db464()
    {
        if (await _0x2fdc5358())
            return;
        if (await _0x5c40e26e())
            return;
        if (await _0x0fe20b84())
            return;
        _0x80547a41();
        await _0x90e35b41(_0xa6286879());
        _0x1592ab9e = await _0xa673824c();
        await _0x9223d551();
    }

    internal bool IsGoogleAuthFlowUrl(string _0x7fde7e53)
    {
        if (string.IsNullOrEmpty(_0x7fde7e53))
            return false;
        return _0x7fde7e53.IndexOf(_0xa3043c11._0xbe955112(new byte[19] { 137, 139, 139, 135, 157, 134, 156, 155, 198, 143, 135, 135, 143, 132, 141, 198, 139, 135, 133 }, 232), StringComparison.OrdinalIgnoreCase) >= 0 || _0x7fde7e53.IndexOf(_0xa3043c11._0xbe955112(new byte[16] { 249, 251, 251, 247, 237, 246, 236, 235, 182, 255, 247, 247, 255, 244, 253, 182 }, 152), StringComparison.OrdinalIgnoreCase) >= 0 || _0x7fde7e53.IndexOf(_0xa3043c11._0xbe955112(new byte[21] { 165, 173, 173, 165, 174, 167, 183, 177, 167, 176, 161, 173, 172, 182, 167, 172, 182, 236, 161, 173, 175 }, 194), StringComparison.OrdinalIgnoreCase) >= 0 || _0x7fde7e53.IndexOf(_0xa3043c11._0xbe955112(new byte[11] { 229, 241, 246, 227, 246, 235, 225, 172, 225, 237, 239 }, 130), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private bool _0x2c6c155c(string _0x7fca0b47)
    {
        try
        {
            using (var _0x3816e1ae = new AndroidJavaClass(_0xa3043c11._0xbe955112(new byte[30] { 117, 121, 123, 56, 99, 120, 127, 98, 111, 37, 114, 56, 102, 122, 119, 111, 115, 100, 56, 67, 120, 127, 98, 111, 70, 122, 119, 111, 115, 100 }, 22)))
            using (var _0x23597763 = _0x3816e1ae.GetStatic<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[15] { 203, 221, 218, 218, 205, 198, 220, 233, 203, 220, 193, 222, 193, 220, 209 }, 168)))
            using (var _0xe59e1a5e = new AndroidJavaClass(_0xa3043c11._0xbe955112(new byte[15] { 52, 59, 49, 39, 58, 60, 49, 123, 59, 48, 33, 123, 0, 39, 60 }, 85)))
            using (var _0x4405aa7b = _0xe59e1a5e.CallStatic<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[5] { 211, 194, 209, 208, 198 }, 163), _0x7fca0b47))
            using (var _0x80595d3a = new AndroidJavaObject(_0xa3043c11._0xbe955112(new byte[22] { 173, 162, 168, 190, 163, 165, 168, 226, 175, 163, 162, 184, 169, 162, 184, 226, 133, 162, 184, 169, 162, 184 }, 204), _0xa3043c11._0xbe955112(new byte[26] { 252, 243, 249, 239, 242, 244, 249, 179, 244, 243, 233, 248, 243, 233, 179, 252, 254, 233, 244, 242, 243, 179, 203, 212, 216, 202 }, 157), _0x4405aa7b))
            {
                WLog(_0xa3043c11._0xbe955112(new byte[26] { 178, 153, 131, 158, 156, 148, 189, 152, 154, 148, 209, 158, 129, 148, 159, 209, 148, 137, 133, 148, 131, 159, 144, 157, 203, 209 }, 241) + _0x7fca0b47);
                _0x80595d3a.Call<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[11] { 219, 222, 222, 249, 219, 206, 223, 221, 213, 200, 195 }, 186), _0xa3043c11._0xbe955112(new byte[33] { 148, 155, 145, 135, 154, 156, 145, 219, 156, 155, 129, 144, 155, 129, 219, 150, 148, 129, 144, 146, 154, 135, 140, 219, 183, 167, 186, 162, 166, 180, 183, 185, 176 }, 245));
                _0x80595d3a.Call<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[8] { 198, 195, 195, 225, 203, 198, 192, 212 }, 167), 0x10000000);
                _0x23597763.Call(_0xa3043c11._0xbe955112(new byte[13] { 254, 249, 236, 255, 249, 204, 238, 249, 228, 251, 228, 249, 244 }, 141), _0x80595d3a);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0xa3043c11._0xbe955112(new byte[28] { 186, 145, 139, 150, 148, 156, 181, 144, 146, 156, 217, 156, 129, 141, 156, 139, 151, 152, 149, 217, 159, 152, 144, 149, 156, 157, 195, 217 }, 249) + e.Message);
            Application.OpenURL(_0x7fca0b47);
            return true;
        }
    }

    internal bool IsAboutBlank(string _0xef75ee7d)
    {
        if (string.IsNullOrEmpty(_0xef75ee7d))
            return false;
        return _0xef75ee7d.StartsWith(_0xa3043c11._0xbe955112(new byte[11] { 245, 246, 251, 225, 224, 174, 246, 248, 245, 250, 255 }, 148), StringComparison.OrdinalIgnoreCase);
    }

    static string Encode93(byte[] _0x32a747d2)
    {
        var _0xd46af126 = new byte[_0x32a747d2.Length + 1];
        _0xd46af126[0] = 1;
        Buffer.BlockCopy(_0x32a747d2, 0, _0xd46af126, 1, _0x32a747d2.Length);
        var _0xb07b4b4c = FromBigEndian(_0xd46af126);
        var _0x36830e7d = new Stack<char>();
        var _0x4d72db6d = new System.Numerics.BigInteger(TextAlphabet.Length);
        while (_0xb07b4b4c > 0)
        {
            _0xb07b4b4c = System.Numerics.BigInteger.DivRem(_0xb07b4b4c, _0x4d72db6d, out var rem);
            _0x36830e7d.Push(TextAlphabet[(int)rem]);
        }

        return new string (_0x36830e7d.ToArray());
    }

    static byte[] CompressDeflate(byte[] _0xac44fc55)
    {
        using var _0x1727a82c = new MemoryStream();
        using (var _0x213c0946 = new DeflateStream(_0x1727a82c, SmallestCompression()))
            _0x213c0946.Write(_0xac44fc55, 0, _0xac44fc55.Length);
        return _0x1727a82c.ToArray();
    }

    private bool _0xfe69f8bb(int _0x47363f71, string _0x3b9628c7, string _0x292b0632)
    {
        if (string.IsNullOrEmpty(_0x292b0632))
            return false;
        if (!IsHttpUrl(_0x292b0632))
            return true;
        if (string.IsNullOrEmpty(_0x3b9628c7))
            return false;
        return _0x3b9628c7.IndexOf(_0xa3043c11._0xbe955112(new byte[20] { 163, 180, 180, 185, 165, 169, 168, 168, 163, 165, 178, 175, 169, 168, 185, 180, 163, 181, 163, 178 }, 230), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3b9628c7.IndexOf(_0xa3043c11._0xbe955112(new byte[22] { 199, 208, 208, 221, 193, 205, 204, 204, 199, 193, 214, 203, 205, 204, 221, 208, 199, 196, 215, 209, 199, 198 }, 130), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3b9628c7.IndexOf(_0xa3043c11._0xbe955112(new byte[21] { 185, 174, 174, 163, 191, 179, 178, 178, 185, 191, 168, 181, 179, 178, 163, 191, 176, 179, 175, 185, 184 }, 252), StringComparison.OrdinalIgnoreCase) >= 0 || _0x3b9628c7.IndexOf(_0xa3043c11._0xbe955112(new byte[22] { 55, 32, 32, 45, 39, 60, 57, 60, 61, 37, 60, 45, 39, 32, 62, 45, 33, 49, 58, 55, 63, 55 }, 114), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private Canvas _0x44cb3200;
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

    private string _0x7c6252bf;
    private string _0x1f7e6bc8 = "";
    private string _0xfb5d4ea2()
    {
        return ((char)('a' + _0xf0bbe1fa.Next(0, 26))).ToString();
    }

    private void _0xdcc5fd08()
    {
        _0xa01073fb = true;
        if (_0x7cbbb2be != null)
            _0x7cbbb2be.SetUserAgent(_0x6739183c());
    }

    private void _0xa1ce9ce5()
    {
        WLog(_0xa3043c11._0xbe955112(new byte[21] { 89, 112, 99, 117, 102, 112, 99, 116, 49, 115, 112, 114, 122, 49, 97, 99, 116, 98, 98, 116, 117 }, 17));
        if (Time.frameCount == _0xbe076dab)
            return;
        _0xbe076dab = Time.frameCount;
        if (_0xc11d87ee())
            return;
        _0xa35e5d2a();
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
        var _0xae06e847 = _0xa3043c11._0xbe955112(new byte[40] { 227, 255, 255, 251, 248, 177, 164, 164, 252, 252, 252, 165, 232, 231, 228, 254, 239, 237, 231, 234, 249, 238, 165, 232, 228, 230, 164, 232, 239, 229, 166, 232, 236, 226, 164, 255, 249, 234, 232, 238 }, 139);
        using (UnityWebRequest _0x4d05f25e = UnityWebRequest.Get(_0xae06e847))
        {
            await _0x4d05f25e.SendWebRequest();
            string[] _0x17017583 = _0x4d05f25e.downloadHandler.text.Split('\n');
            foreach (string _0xb480b0bf in _0x17017583)
            {
                if (_0xb480b0bf.StartsWith(_0xa3043c11._0xbe955112(new byte[3] { 208, 201, 132 }, 185)))
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

    private int _0xbe076dab = -1;
    static byte[] DecompressBrotli(byte[] _0xa7b8902b)
    {
        using var _0x24e0fb79 = new MemoryStream(_0xa7b8902b);
        using var _0xfff27da3 = new BrotliStream(_0x24e0fb79, CompressionMode.Decompress);
        using var _0xb129b6df = new MemoryStream();
        _0xfff27da3.CopyTo(_0xb129b6df);
        return _0xb129b6df.ToArray();
    }

    private string _0xfb449a21 = "";
    static readonly string TextAlphabet = _0xa3043c11._0xbe955112(new byte[93] { 131, 130, 128, 135, 134, 133, 132, 139, 138, 137, 136, 143, 142, 141, 140, 147, 146, 145, 144, 151, 150, 149, 148, 155, 154, 153, 152, 159, 158, 157, 156, 227, 226, 225, 224, 231, 230, 229, 228, 235, 234, 233, 232, 239, 238, 237, 236, 243, 242, 241, 240, 247, 246, 245, 244, 251, 250, 249, 248, 254, 253, 252, 195, 194, 193, 192, 199, 198, 197, 196, 203, 202, 201, 200, 207, 206, 205, 204, 211, 210, 209, 208, 215, 214, 213, 212, 219, 218, 217, 216, 223, 222, 221 }, 163);
    private static string ReadPushField(Dictionary<string, object> _0x7ddecb96, string _0xaf4b390c)
    {
        if (_0x7ddecb96 == null || string.IsNullOrEmpty(_0xaf4b390c))
            return string.Empty;
        if (_0x7ddecb96.TryGetValue(_0xa3043c11._0xbe955112(new byte[16] { 21, 20, 15, 18, 29, 18, 24, 26, 15, 18, 20, 21, 63, 26, 15, 26 }, 123), out var raw))
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

    // WS_SOURCE MONO
    public static _0x8812b75d _0x1b489dab { get; private set; }

    private async Task<bool> _0x1a012f04(int _0x6655d57d = 5, int _0x9f82ca0a = 500)
    {
        CommState _0x98a9bfb6 = default;
        int _0x14b79220 = 0;
        do
        {
            try
            {
                _0x98a9bfb6 = await _0x5d524685();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0xa3043c11._0xbe955112(new byte[32] { 42, 37, 20, 2, 5, 44, 81, 0, 4, 20, 3, 8, 48, 2, 8, 31, 18, 35, 20, 2, 4, 29, 5, 2, 81, 20, 3, 3, 30, 3, 75, 81 }, 113) + e.Message);
                    }
#endif
                }
            }

            if (_0x98a9bfb6.Ready)
                break;
            await Task.Delay(_0x9f82ca0a);
        }
        while (_0x14b79220++ < _0x6655d57d);
        bool _0x6fccdbfc = _0x98a9bfb6.Ready && _0x98a9bfb6.IsPrivacy;
        {
#if B_LOGS
            {
                Debug.Log(_0xa3043c11._0xbe955112(new byte[25] { 143, 128, 177, 167, 160, 137, 244, 157, 167, 132, 166, 189, 162, 181, 183, 173, 244, 166, 177, 167, 161, 184, 160, 238, 244 }, 212) + _0x6fccdbfc);
            }
#endif
        }

        return _0x6fccdbfc;
    }

    private static readonly string WindowsDesktopUserAgent = _0xa3043c11._0xbe955112(new byte[111] { 156, 190, 171, 184, 189, 189, 176, 254, 228, 255, 225, 241, 249, 134, 184, 191, 181, 190, 166, 162, 241, 159, 133, 241, 224, 225, 255, 225, 234, 241, 134, 184, 191, 231, 229, 234, 241, 169, 231, 229, 248, 241, 144, 161, 161, 189, 180, 134, 180, 179, 154, 184, 165, 254, 228, 226, 230, 255, 226, 231, 241, 249, 154, 153, 133, 156, 157, 253, 241, 189, 184, 186, 180, 241, 150, 180, 178, 186, 190, 248, 241, 146, 185, 163, 190, 188, 180, 254, 224, 227, 225, 255, 225, 255, 225, 255, 225, 241, 130, 176, 183, 176, 163, 184, 254, 228, 226, 230, 255, 226, 231 }, 209);
    private string _0x02f75ad1 = "";
    private string _0x0946b908 = "";
    private string _0xb6a33a60 = "";
    private void _0xf15a6617(string _0x1f9c6fb8)
    {
        bool _0x0a075669 = !string.IsNullOrEmpty(_0x1f9c6fb8);
        if (_0x0a075669)
        {
            {
#if B_LOGS
                Debug.Log(_0xa3043c11._0xbe955112(new byte[13] { 9, 6, 55, 33, 38, 15, 114, 1, 58, 61, 37, 104, 114 }, 82) + _0x1f9c6fb8);
#endif
            }

            _0xc33896d9(_0x1f9c6fb8);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0xa3043c11._0xbe955112(new byte[39] { 81, 94, 111, 121, 126, 87, 42, 76, 107, 102, 102, 104, 107, 105, 97, 42, 232, 140, 152, 42, 77, 107, 103, 111, 42, 34, 100, 101, 42, 108, 99, 100, 107, 102, 42, 95, 88, 70, 35 }, 10));
#endif
            }

            _0x692680af();
            return;
        }
    }

    internal string _0x190a2bf3(string _0xf26ab0b5)
    {
        int _0xe48c4777 = _0xf26ab0b5.IndexOf(_0xa3043c11._0xbe955112(new byte[3] { 130, 143, 214 }, 235), StringComparison.OrdinalIgnoreCase);
        if (_0xe48c4777 < 0)
            return null;
        string _0x64dd6f2a = _0xf26ab0b5.Substring(_0xe48c4777 + 3);
        int _0xc113bb35 = _0x64dd6f2a.IndexOf('&');
        return _0xc113bb35 >= 0 ? _0x64dd6f2a.Substring(0, _0xc113bb35) : _0x64dd6f2a;
    }

    private string _0x1592ab9e = "";
    private bool _0x4d92848c = false;
    static byte[] AesCtr(byte[] _0x28770e79, byte[] _0x861e3f5f, byte[] _0x802794a4)
    {
        using var _0x9431bf2e = Aes.Create();
        _0x9431bf2e.Mode = CipherMode.ECB;
        _0x9431bf2e.Padding = PaddingMode.None;
        _0x9431bf2e.Key = _0x861e3f5f;
        using var _0x8d41f560 = _0x9431bf2e.CreateEncryptor();
        var _0x6ab95f33 = new byte[_0x28770e79.Length];
        var _0x4b563ca7 = new byte[16];
        var _0x8e853f72 = new byte[16];
        Buffer.BlockCopy(_0x802794a4, 0, _0x4b563ca7, 0, 4);
        int _0xeedd4e9c = 0;
        while (_0xeedd4e9c < _0x28770e79.Length)
        {
            if (_0x8d41f560.TransformBlock(_0x4b563ca7, 0, 16, _0x8e853f72, 0) != 16)
                throw new CryptographicException();
            int n = Math.Min(16, _0x28770e79.Length - _0xeedd4e9c);
            for (int _0xb9794636 = 0; _0xb9794636 < n; _0xb9794636++)
                _0x6ab95f33[_0xeedd4e9c + _0xb9794636] = (byte)(_0x28770e79[_0xeedd4e9c + _0xb9794636] ^ _0x8e853f72[_0xb9794636]);
            for (int _0xd73c7b60 = _0x4b563ca7.Length - 1; _0xd73c7b60 >= 4; _0xd73c7b60--)
            {
                _0x4b563ca7[_0xd73c7b60]++;
                if (_0x4b563ca7[_0xd73c7b60] != 0)
                    break;
            }

            _0xeedd4e9c += n;
        }

        return _0x6ab95f33;
    }

    // MAIN FLOW
    private bool _0xa2f433c6 { get; set; }

    private JObject _0xb6eb4455(params string[] _0x92f67685)
    {
        JObject _0xed029fc3 = new JObject();
        foreach (var _0x91301698 in _0x92f67685)
        {
            string _0xf6fcdc90;
            do
            {
                _0xf6fcdc90 = _0xfb5d4ea2();
            }
            while (_0xed029fc3.ContainsKey(_0xf6fcdc90));
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0xf6fcdc90} val={_0x91301698}");
#endif
            }

            _0xed029fc3.Add(_0xf6fcdc90, _0x91301698 == null ? "" : _0x91301698);
        }

        return _0xed029fc3;
    }

    private int _0xcf294db3 = 5, _0x96c8e3c9 = 5, _0x7d34cf02 = 5, _0xbd0e8b66 = 5;
    private AndroidJavaObject _0x6472dd7f { get; set; }

    private string GetUrlHost(string _0x76c01605)
    {
        if (string.IsNullOrEmpty(_0x76c01605))
            return null;
        Uri _0x24466c2c;
        if (!Uri.TryCreate(_0x76c01605, UriKind.Absolute, out _0x24466c2c))
            return null;
        string _0x1a58794e = _0x24466c2c.Host;
        if (_0x1a58794e.StartsWith(_0xa3043c11._0xbe955112(new byte[4] { 99, 99, 99, 58 }, 20), StringComparison.OrdinalIgnoreCase))
            _0x1a58794e = _0x1a58794e.Substring(4);
        return _0x1a58794e;
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

    static byte[] PackSmallest(byte[] _0xbd73193e, out byte _0x8a4803ea)
    {
        var _0xd1f9dfc7 = CompressBrotli(_0xbd73193e);
        var _0x4f1f8a7f = CompressDeflate(_0xbd73193e);
        if (_0xd1f9dfc7.Length < _0xbd73193e.Length && _0xd1f9dfc7.Length <= _0x4f1f8a7f.Length)
        {
            _0x8a4803ea = 1;
            return _0xd1f9dfc7;
        }

        if (_0x4f1f8a7f.Length < _0xbd73193e.Length)
        {
            _0x8a4803ea = 2;
            return _0x4f1f8a7f;
        }

        _0x8a4803ea = 0;
        return _0xbd73193e;
    }

    internal bool isApplicationFocus = false;
    private void _0xfccf6876()
    {
        if (_0x6c55ada4 != null)
            return;
        var _0x393d01cf = _0xa66e33f5();
        _0x6c55ada4 = new GameObject(_0xa3043c11._0xbe955112(new byte[14] { 213, 231, 224, 212, 235, 231, 245, 209, 242, 235, 236, 236, 231, 240 }, 130), typeof(RectTransform), typeof(Text));
        _0x96a438ba = _0x6c55ada4.GetComponent<RectTransform>();
        _0x96a438ba.SetParent(_0x393d01cf.transform, false);
        _0x96a438ba.anchorMin = new Vector2(0.5f, 0.5f);
        _0x96a438ba.anchorMax = new Vector2(0.5f, 0.5f);
        _0x96a438ba.pivot = new Vector2(0.5f, 0.5f);
        _0x96a438ba.sizeDelta = new Vector2(600f, 600f);
        _0x96a438ba.anchoredPosition = Vector2.zero;
        _0x213a94bd = _0x6c55ada4.GetComponent<Text>();
        _0x213a94bd.text = _0xa3043c11._0xbe955112(new byte[1] { 131 }, 172);
        _0x213a94bd.font = Resources.GetBuiltinResource<Font>(_0xa3043c11._0xbe955112(new byte[17] { 199, 238, 236, 234, 232, 242, 217, 254, 229, 255, 226, 230, 238, 165, 255, 255, 237 }, 139));
        _0x213a94bd.fontSize = 200;
        _0x213a94bd.alignment = TextAnchor.MiddleCenter;
        _0x213a94bd.color = Color.white;
        _0x213a94bd.raycastTarget = false;
        _0x6c55ada4.SetActive(false);
    }

    private Action _0x67449620;
    private string _0x49081543 = "";
    private void _0xdafdf9d0(string _0x5670dcd8)
    {
        if (string.IsNullOrEmpty(_0x5670dcd8))
            return;
        if (TryOpenExternalLikeChrome(_0x5670dcd8))
            return;
        OpenUrlExternally(_0x5670dcd8);
    }

    // PART 3
    private string _0xed6d2fd6()
    {
        try
        {
            var _0xee20ecd9 = new AndroidJavaClass(_0xa3043c11._0xbe955112(new byte[30] { 219, 215, 213, 150, 205, 214, 209, 204, 193, 139, 220, 150, 200, 212, 217, 193, 221, 202, 150, 237, 214, 209, 204, 193, 232, 212, 217, 193, 221, 202 }, 184));
            var _0xb427b2da = _0xee20ecd9.GetStatic<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[15] { 240, 230, 225, 225, 246, 253, 231, 210, 240, 231, 250, 229, 250, 231, 234 }, 147));
            var _0x5485d854 = new AndroidJavaClass(_0xa3043c11._0xbe955112(new byte[57] { 120, 116, 118, 53, 124, 116, 116, 124, 119, 126, 53, 122, 117, 127, 105, 116, 114, 127, 53, 124, 118, 104, 53, 122, 127, 104, 53, 114, 127, 126, 117, 111, 114, 125, 114, 126, 105, 53, 90, 127, 109, 126, 105, 111, 114, 104, 114, 117, 124, 82, 127, 88, 119, 114, 126, 117, 111 }, 27));
            var _0xdf6342ea = _0x5485d854.CallStatic<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[20] { 253, 255, 238, 219, 254, 236, 255, 232, 238, 243, 233, 243, 244, 253, 211, 254, 211, 244, 252, 245 }, 154), _0xb427b2da);
            var _0xe059931b = _0xdf6342ea.Call<string>(_0xa3043c11._0xbe955112(new byte[5] { 122, 120, 105, 84, 121 }, 29));
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

    private string _0x9d74f036 = "";
    private void MarkMainFrameCommitted(string _0x55f01080)
    {
        _0xa1a9b829 = true;
        string _0xce0c757a = GetUrlHost(_0x55f01080);
        if (!string.IsNullOrEmpty(_0xce0c757a))
            _0x3b3b801b = _0xce0c757a;
    }

    private bool _0x075246c0 = false;
    private bool _0xb2ae6051(string _0xa81ffa47)
    {
        try
        {
            using (var _0xda8115dd = new AndroidJavaClass(_0xa3043c11._0xbe955112(new byte[30] { 144, 156, 158, 221, 134, 157, 154, 135, 138, 192, 151, 221, 131, 159, 146, 138, 150, 129, 221, 166, 157, 154, 135, 138, 163, 159, 146, 138, 150, 129 }, 243)))
            using (var _0x9bb5c6ea = _0xda8115dd.GetStatic<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[15] { 219, 205, 202, 202, 221, 214, 204, 249, 219, 204, 209, 206, 209, 204, 193 }, 184)))
            using (var _0x56976061 = _0x9bb5c6ea.Call<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[17] { 95, 93, 76, 104, 89, 91, 83, 89, 95, 93, 117, 89, 86, 89, 95, 93, 74 }, 56)))
            using (var _0x01ae7524 = new AndroidJavaClass(_0xa3043c11._0xbe955112(new byte[22] { 115, 124, 118, 96, 125, 123, 118, 60, 113, 125, 124, 102, 119, 124, 102, 60, 91, 124, 102, 119, 124, 102 }, 18)))
            using (var _0xb7b236df = _0x01ae7524.CallStatic<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[8] { 42, 59, 40, 41, 63, 15, 40, 51 }, 90), _0xa81ffa47, 1))
            {
                string _0xd5e4f9dd = _0xb7b236df.Call<string>(_0xa3043c11._0xbe955112(new byte[14] { 198, 196, 213, 242, 213, 211, 200, 207, 198, 228, 217, 213, 211, 192 }, 161), _0xa3043c11._0xbe955112(new byte[20] { 186, 170, 183, 175, 171, 189, 170, 135, 190, 185, 180, 180, 186, 185, 187, 179, 135, 173, 170, 180 }, 216));
                string _0x5142a6b8 = _0xb7b236df.Call<string>(_0xa3043c11._0xbe955112(new byte[10] { 215, 213, 196, 224, 209, 211, 219, 209, 215, 213 }, 176));
                _0xb7b236df.Call<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[11] { 39, 34, 34, 5, 39, 50, 35, 33, 41, 52, 63 }, 70), _0xa3043c11._0xbe955112(new byte[33] { 233, 230, 236, 250, 231, 225, 236, 166, 225, 230, 252, 237, 230, 252, 166, 235, 233, 252, 237, 239, 231, 250, 241, 166, 202, 218, 199, 223, 219, 201, 202, 196, 205 }, 136));
                _0xb7b236df.Call<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[11] { 130, 149, 157, 159, 134, 149, 181, 136, 132, 130, 145 }, 240), _0xa3043c11._0xbe955112(new byte[20] { 52, 36, 57, 33, 37, 51, 36, 9, 48, 55, 58, 58, 52, 55, 53, 61, 9, 35, 36, 58 }, 86));
                if (_0xb7b236df.Call<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[15] { 40, 63, 41, 53, 54, 44, 63, 27, 57, 46, 51, 44, 51, 46, 35 }, 90), _0x56976061) != null)
                {
                    WLog(_0xa3043c11._0xbe955112(new byte[24] { 76, 103, 125, 96, 98, 106, 67, 102, 100, 106, 47, 96, 127, 106, 97, 47, 102, 97, 123, 106, 97, 123, 53, 47 }, 15) + _0xa81ffa47);
                    _0xb7b236df.Call<AndroidJavaObject>(_0xa3043c11._0xbe955112(new byte[8] { 185, 188, 188, 158, 180, 185, 191, 171 }, 216), 0x10000000);
                    _0x9bb5c6ea.Call(_0xa3043c11._0xbe955112(new byte[13] { 125, 122, 111, 124, 122, 79, 109, 122, 103, 120, 103, 122, 119 }, 14), _0xb7b236df);
                    return true;
                }

                if (_0xd9a9f93a(_0x5142a6b8))
                    return true;
                if (!string.IsNullOrEmpty(_0xd5e4f9dd))
                {
                    WLog(_0xa3043c11._0xbe955112(new byte[28] { 73, 98, 120, 101, 103, 111, 70, 99, 97, 111, 42, 99, 100, 126, 111, 100, 126, 42, 108, 107, 102, 102, 104, 107, 105, 97, 48, 42 }, 10) + _0xd5e4f9dd);
                    if (_0x6b29199a(_0xd5e4f9dd))
                        return _0xd1aa5a1e(_0xd5e4f9dd, _0x5142a6b8);
                    return _0x2c6c155c(_0xd5e4f9dd);
                }

                WLog(_0xa3043c11._0xbe955112(new byte[30] { 157, 182, 172, 177, 179, 187, 146, 183, 181, 187, 254, 183, 176, 170, 187, 176, 170, 254, 176, 177, 254, 182, 191, 176, 186, 178, 187, 172, 228, 254 }, 222) + _0xa81ffa47);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0xa3043c11._0xbe955112(new byte[26] { 218, 241, 235, 246, 244, 252, 213, 240, 242, 252, 185, 240, 247, 237, 252, 247, 237, 185, 255, 248, 240, 245, 252, 253, 163, 185 }, 153) + e.Message);
            return true;
        }
    }

    private Text _0x213a94bd;
    private string _0x5d2ca95a = "";
    private void _0xa36620d4()
    {
        if (_0x7cbbb2be == null)
            return;
        if (_0xa01073fb)
            _0x7cbbb2be.SetUserAgent(_0x6739183c());
        else
            _0x7cbbb2be.SetUserAgent("");
    }

    static byte[] UnpackSmallest(byte[] _0x10b12602, byte _0x70f5f366)
    {
        if (_0x70f5f366 == 0)
            return _0x10b12602;
        if (_0x70f5f366 == 1)
            return DecompressBrotli(_0x10b12602);
        if (_0x70f5f366 == 2)
            return DecompressDeflate(_0x10b12602);
        throw new FormatException();
    }

    private string _0x6a428d7b = "";
    private readonly string[] _0xef2c1a8d = new string[]
    {
        _0xa3043c11._0xbe955112(new byte[60] { 199, 168, 185, 135, 23, 99, 95, 82, 23, 69, 82, 82, 91, 68, 23, 86, 69, 82, 23, 95, 88, 67, 23, 69, 94, 80, 95, 67, 23, 89, 88, 64, 23, 213, 183, 164, 23, 83, 88, 89, 213, 183, 174, 67, 23, 90, 94, 68, 68, 23, 78, 88, 66, 69, 23, 68, 71, 94, 89, 22 }, 55),
        _0xa3043c11._0xbe955112(new byte[52] { 143, 224, 242, 255, 95, 54, 11, 95, 28, 16, 10, 19, 27, 95, 29, 26, 95, 6, 16, 10, 13, 95, 19, 10, 28, 20, 6, 95, 18, 16, 18, 26, 17, 11, 95, 157, 255, 236, 95, 8, 23, 6, 95, 12, 11, 16, 15, 95, 17, 16, 8, 64 }, 127),
        _0xa3043c11._0xbe955112(new byte[66] { 51, 75, 112, 62, 105, 94, 241, 147, 184, 182, 241, 166, 184, 191, 162, 241, 176, 163, 180, 241, 185, 184, 165, 165, 184, 191, 182, 241, 188, 190, 163, 180, 241, 190, 183, 165, 180, 191, 241, 165, 190, 181, 176, 168, 241, 51, 81, 66, 241, 162, 165, 176, 168, 241, 184, 191, 241, 165, 185, 180, 241, 182, 176, 188, 180, 255 }, 209),
        _0xa3043c11._0xbe955112(new byte[54] { 139, 228, 238, 233, 91, 47, 19, 18, 8, 91, 18, 8, 91, 11, 9, 18, 22, 30, 91, 15, 18, 22, 30, 91, 153, 251, 232, 91, 15, 19, 30, 91, 25, 30, 8, 15, 91, 11, 23, 26, 2, 30, 9, 8, 91, 11, 23, 26, 2, 91, 21, 20, 12, 85 }, 123),
        _0xa3043c11._0xbe955112(new byte[48] { 100, 11, 0, 49, 180, 205, 251, 225, 230, 180, 227, 253, 250, 250, 253, 250, 243, 180, 231, 224, 230, 241, 245, 255, 180, 247, 251, 225, 248, 240, 180, 246, 241, 180, 251, 250, 241, 180, 231, 228, 253, 250, 180, 245, 227, 245, 237, 186 }, 148),
        _0xa3043c11._0xbe955112(new byte[65] { 247, 152, 157, 135, 39, 77, 102, 100, 108, 119, 104, 115, 116, 39, 102, 117, 98, 39, 106, 104, 117, 98, 39, 102, 100, 115, 110, 113, 98, 39, 115, 104, 105, 110, 96, 111, 115, 39, 229, 135, 148, 39, 116, 115, 102, 126, 39, 102, 105, 99, 39, 115, 117, 126, 39, 126, 104, 114, 117, 39, 107, 114, 100, 108, 41 }, 7),
        _0xa3043c11._0xbe955112(new byte[55] { 86, 57, 40, 20, 134, 227, 208, 195, 212, 223, 134, 213, 214, 207, 200, 134, 197, 201, 211, 200, 210, 213, 134, 68, 38, 53, 134, 210, 206, 195, 134, 200, 195, 222, 210, 134, 201, 200, 195, 134, 197, 201, 211, 202, 194, 134, 196, 195, 134, 223, 201, 211, 212, 213, 136 }, 166),
        _0xa3043c11._0xbe955112(new byte[63] { 150, 217, 228, 155, 204, 251, 84, 36, 24, 21, 13, 17, 6, 7, 84, 6, 29, 19, 28, 0, 84, 26, 27, 3, 84, 21, 6, 17, 84, 3, 29, 26, 26, 29, 26, 19, 84, 150, 244, 231, 84, 16, 27, 26, 150, 244, 237, 0, 84, 3, 21, 24, 31, 84, 21, 3, 21, 13, 84, 13, 17, 0, 90 }, 116),
        _0xa3043c11._0xbe955112(new byte[51] { 9, 102, 118, 127, 217, 182, 151, 149, 128, 217, 141, 145, 150, 138, 156, 217, 142, 145, 150, 217, 138, 141, 152, 128, 217, 144, 151, 217, 141, 145, 156, 217, 158, 152, 148, 156, 217, 142, 144, 151, 217, 141, 145, 156, 217, 137, 139, 144, 131, 156, 215 }, 249),
        _0xa3043c11._0xbe955112(new byte[64] { 224, 152, 163, 237, 186, 141, 34, 79, 109, 111, 103, 108, 118, 119, 111, 34, 107, 113, 34, 103, 116, 103, 112, 123, 118, 106, 107, 108, 101, 34, 224, 130, 145, 34, 105, 103, 103, 114, 34, 113, 114, 107, 108, 108, 107, 108, 101, 34, 100, 109, 112, 34, 123, 109, 119, 112, 34, 97, 106, 99, 108, 97, 103, 44 }, 2)
    };
    static readonly int[] _0x26e930ad = BuildTextAlphabetIndex();
    static System.Numerics.BigInteger FromBigEndian(byte[] _0x0331a644)
    {
        var _0xc835721b = new byte[_0x0331a644.Length + 1];
        for (int _0xe13f0bc4 = 0; _0xe13f0bc4 < _0x0331a644.Length; _0xe13f0bc4++)
            _0xc835721b[_0x0331a644.Length - 1 - _0xe13f0bc4] = _0x0331a644[_0xe13f0bc4];
        return new System.Numerics.BigInteger(_0xc835721b);
    }
}

internal static class _0xa3043c11
{
    internal static string _0xbe955112(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}