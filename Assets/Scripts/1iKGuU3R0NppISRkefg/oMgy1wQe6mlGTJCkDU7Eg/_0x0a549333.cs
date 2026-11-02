using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x0a549333
{
    public static class _0x68a164ec
    {
        public static int _0xc0c6bbec
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x86b7edd4._0x39c37c89(new byte[5] { 112, 92, 90, 93, 64 }, 51)))
                    PlayerPrefs.SetInt(_0x86b7edd4._0x39c37c89(new byte[5] { 137, 165, 163, 164, 185 }, 202), 0);
                return PlayerPrefs.GetInt(_0x86b7edd4._0x39c37c89(new byte[5] { 125, 81, 87, 80, 77 }, 62));
            }

            set
            {
                PlayerPrefs.SetInt(_0x86b7edd4._0x39c37c89(new byte[5] { 72, 100, 98, 101, 120 }, 11), value);
                _0x685a4663.Instance._0xfe63879b();
            }
        }
    }

    public static class _0x0fc897b7
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0x3ccaa3c8
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public class _0x07b7bc24
    {
        private static readonly _0x07b7bc24 _0x23e4ed58 = new();
        public static readonly _0x07b7bc24[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x23e4ed58,
            _0x23e4ed58,
            _0x23e4ed58,
        };
        private int _0xc8557463 => 0;
        private int _0xfc3e1055 => 10;
        private string _0xea0434a3 => _0x86b7edd4._0x39c37c89(new byte[4] { 220, 244, 255, 228 }, 145);
        private string _0x09f85d5b => _0x86b7edd4._0x39c37c89(new byte[8] { 67, 74, 89, 74, 67, 116, 63, 114 }, 15);

        private int _0xf7cb12e1
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x86b7edd4._0x39c37c89(new byte[25] { 47, 25, 30, 30, 9, 2, 24, 43, 0, 3, 14, 13, 0, 47, 4, 13, 28, 24, 9, 30, 37, 2, 8, 9, 20 }, 108)))
                    PlayerPrefs.SetInt(_0x86b7edd4._0x39c37c89(new byte[25] { 168, 158, 153, 153, 142, 133, 159, 172, 135, 132, 137, 138, 135, 168, 131, 138, 155, 159, 142, 153, 162, 133, 143, 142, 147 }, 235), 0);
                return PlayerPrefs.GetInt(_0x86b7edd4._0x39c37c89(new byte[25] { 213, 227, 228, 228, 243, 248, 226, 209, 250, 249, 244, 247, 250, 213, 254, 247, 230, 226, 243, 228, 223, 248, 242, 243, 238 }, 150));
            }

            set => PlayerPrefs.SetInt(_0x86b7edd4._0x39c37c89(new byte[25] { 56, 14, 9, 9, 30, 21, 15, 60, 23, 20, 25, 26, 23, 56, 19, 26, 11, 15, 30, 9, 50, 21, 31, 30, 3 }, 123), value);
        }

        public int _0xad3d97d5
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xea0434a3}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0xea0434a3}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0xea0434a3}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0xea0434a3}CurrentLevelIndex", value);
        }

        public int _0x402a4331
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xea0434a3}BestScore"))
                    this._0x402a4331 = 0;
                return PlayerPrefs.GetInt($"{this._0xea0434a3}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0xea0434a3}BestScore", value);
        }

        public bool _0x7cf8f88b
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xea0434a3}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0xea0434a3}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0xea0434a3}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0xea0434a3}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0xb5c50aa6
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }
}

internal static class _0x86b7edd4
{
    internal static string _0x39c37c89(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}