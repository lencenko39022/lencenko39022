using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xa93ecf08
{
    public static class _0x41b99ebc
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public static class _0x27eba83c
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

    public static class _0x308a9b74
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0xf0cc7cd1
    {
        public static int _0xc8557463
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x7d4a7eb9._0x8eec5f45(new byte[5] { 166, 138, 140, 139, 150 }, 229)))
                    PlayerPrefs.SetInt(_0x7d4a7eb9._0x8eec5f45(new byte[5] { 194, 238, 232, 239, 242 }, 129), 0);
                return PlayerPrefs.GetInt(_0x7d4a7eb9._0x8eec5f45(new byte[5] { 204, 224, 230, 225, 252 }, 143));
            }

            set
            {
                PlayerPrefs.SetInt(_0x7d4a7eb9._0x8eec5f45(new byte[5] { 166, 138, 140, 139, 150 }, 229), value);
                _0x7aee932b.Instance._0x1c89ee29();
            }
        }
    }

    public class _0xa0ab22b1
    {
        private static readonly _0xa0ab22b1 _0x7f12df16 = new();
        public static readonly _0xa0ab22b1[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x7f12df16,
            _0x7f12df16,
            _0x7f12df16,
        };
        private int _0xfc3e1055 => 0;
        private int _0xea0434a3 => 10;
        private string _0x09f85d5b => _0x7d4a7eb9._0x8eec5f45(new byte[4] { 102, 78, 69, 94 }, 43);
        private string _0xf7cb12e1 => _0x7d4a7eb9._0x8eec5f45(new byte[8] { 134, 143, 156, 143, 134, 177, 250, 183 }, 202);

        private int _0xad3d97d5
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x7d4a7eb9._0x8eec5f45(new byte[25] { 143, 185, 190, 190, 169, 162, 184, 139, 160, 163, 174, 173, 160, 143, 164, 173, 188, 184, 169, 190, 133, 162, 168, 169, 180 }, 204)))
                    PlayerPrefs.SetInt(_0x7d4a7eb9._0x8eec5f45(new byte[25] { 224, 214, 209, 209, 198, 205, 215, 228, 207, 204, 193, 194, 207, 224, 203, 194, 211, 215, 198, 209, 234, 205, 199, 198, 219 }, 163), 0);
                return PlayerPrefs.GetInt(_0x7d4a7eb9._0x8eec5f45(new byte[25] { 193, 247, 240, 240, 231, 236, 246, 197, 238, 237, 224, 227, 238, 193, 234, 227, 242, 246, 231, 240, 203, 236, 230, 231, 250 }, 130));
            }

            set => PlayerPrefs.SetInt(_0x7d4a7eb9._0x8eec5f45(new byte[25] { 9, 63, 56, 56, 47, 36, 62, 13, 38, 37, 40, 43, 38, 9, 34, 43, 58, 62, 47, 56, 3, 36, 46, 47, 50 }, 74), value);
        }

        public int _0x402a4331
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x09f85d5b}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x09f85d5b}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x09f85d5b}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x09f85d5b}CurrentLevelIndex", value);
        }

        public int _0x7cf8f88b
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x09f85d5b}BestScore"))
                    this._0x7cf8f88b = 0;
                return PlayerPrefs.GetInt($"{this._0x09f85d5b}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x09f85d5b}BestScore", value);
        }

        public bool _0x1174d4e5
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x09f85d5b}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x09f85d5b}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x09f85d5b}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x09f85d5b}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }
}

internal static class _0x7d4a7eb9
{
    internal static string _0x8eec5f45(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}