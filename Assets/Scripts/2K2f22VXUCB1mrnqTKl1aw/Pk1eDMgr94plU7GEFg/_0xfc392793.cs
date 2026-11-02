using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0xfc392793 : MonoBehaviour
{
    private Touch? _0xb7c73c7d()
    {
        if (!_0x685a4663.Instance._0x694fb632)
            return null;
        foreach (Touch _0xe93eeca1 in Touch.activeTouches)
            if (!_0xe93eeca1.ended)
                if (this._0x2d15f0ae(_0xe93eeca1))
                    return _0xe93eeca1;
        return null;
    }

    private void _0x4609f4f8(Touch? _0x609462a4)
    {
        if (!_0x685a4663.Instance._0x694fb632)
        {
            _0x609462a4 = null;
            return;
        }

        int _0x0f148161 = _0x609462a4.Value.touchId;
        _0x609462a4 = Touch.activeTouches.FirstOrDefault(_0xd21b4b17 => _0xd21b4b17.touchId == _0x0f148161);
        if (!this._0x2d15f0ae(_0x609462a4.Value))
            _0x609462a4 = null;
    }

    private Touch? _0xb3c824bc(Bounds _0x9799df08)
    {
        if (!_0x685a4663.Instance._0x694fb632)
            return null;
        foreach (Touch _0x7e4cba04 in Touch.activeTouches)
            if (!_0x7e4cba04.ended)
            {
                Vector3 _0x672083cc = Camera.main.ScreenToWorldPoint(_0x7e4cba04.screenPosition);
                Vector3 _0x3e7411f1 = new(_0x672083cc.x, _0x672083cc.y, _0x9799df08.center.z);
                if (_0x9799df08.Contains(_0x3e7411f1) && this._0x2d15f0ae(_0x7e4cba04))
                    return _0x7e4cba04;
            }

        return null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x39d2a06c = this.gameObject.GetComponent<_0xfc392793>();
    }

    public BoxCollider2D CameraTouchBounds;
    private Touch? _0x6ad60577(Bounds _0x0944747e, TouchPhase _0xbc98799f)
    {
        if (!_0x685a4663.Instance._0x694fb632)
            return null;
        foreach (Touch _0xab1e54f0 in Touch.activeTouches)
            if (_0xab1e54f0.phase == _0xbc98799f)
            {
                Vector3 _0x780e7daf = Camera.main.ScreenToWorldPoint(_0xab1e54f0.screenPosition);
                Vector3 _0x6b33cbe4 = new(_0x780e7daf.x, _0x780e7daf.y, _0x0944747e.center.z);
                if (_0x0944747e.Contains(_0x6b33cbe4) && this._0x2d15f0ae(_0xab1e54f0))
                    return _0xab1e54f0;
            }

        return null;
    }

    private Touch? _0x2eb67e76(Bounds _0xa96fe3c6)
    {
        if (!_0x685a4663.Instance._0x694fb632)
            return null;
        foreach (Touch _0x4e78d4f7 in Touch.activeTouches)
            if (_0x4e78d4f7.ended)
            {
                Vector3 _0xc4c600c8 = Camera.main.ScreenToWorldPoint(_0x4e78d4f7.screenPosition);
                Vector3 _0x76523234 = new(_0xc4c600c8.x, _0xc4c600c8.y, _0xa96fe3c6.center.z);
                if (_0xa96fe3c6.Contains(_0x76523234) && this._0x2d15f0ae(_0x4e78d4f7))
                    return _0x4e78d4f7;
            }

        return null;
    }

    private bool _0x2d15f0ae(Touch? _0x84d77364)
    {
        if (!_0x84d77364.HasValue)
            return false;
        Vector3 _0xa053f3ec = Camera.main.ScreenToWorldPoint(_0x84d77364.Value.screenPosition);
        Vector3 _0x9947eee4 = _0xa053f3ec;
        _0x9947eee4.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x9947eee4))
            return true;
        _0x84d77364 = null;
        return false;
    }

    private Touch? _0xa399366b()
    {
        if (!_0x685a4663.Instance._0x694fb632)
            return null;
        foreach (Touch _0xff1c86c4 in Touch.activeTouches)
            if (_0xff1c86c4.ended)
                if (this._0x2d15f0ae(_0xff1c86c4))
                    return _0xff1c86c4;
        return null;
    }

    private bool _0x39631e42(Touch? _0x065f713a, Bounds _0xe2b4c4e0, TouchPhase _0x470b2600)
    {
        if (!_0x685a4663.Instance._0x694fb632)
        {
            _0x065f713a = null;
            return false;
        }

        if (_0x065f713a != null)
            if (_0x065f713a.Value.phase == _0x470b2600)
            {
                Vector3 _0x7e3bd6e3 = Camera.main.ScreenToWorldPoint(_0x065f713a.Value.screenPosition);
                Vector3 _0xeaab87db = new(_0x7e3bd6e3.x, _0x7e3bd6e3.y, _0xe2b4c4e0.center.z);
                if (_0xe2b4c4e0.Contains(_0xeaab87db) && this._0x2d15f0ae(_0x065f713a.Value))
                    return true;
            }

        return false;
    }

    private static _0xfc392793 _0x39d2a06c;
}