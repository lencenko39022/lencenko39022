using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x41d45867 : MonoBehaviour
{
    private Touch? _0x38e5578d(Bounds _0xa01a221a)
    {
        if (!_0x7aee932b.Instance._0x53ed5416)
            return null;
        foreach (Touch _0xadfd141c in Touch.activeTouches)
            if (_0xadfd141c.ended)
            {
                Vector3 _0xf6250459 = Camera.main.ScreenToWorldPoint(_0xadfd141c.screenPosition);
                Vector3 _0x795816b2 = new(_0xf6250459.x, _0xf6250459.y, _0xa01a221a.center.z);
                if (_0xa01a221a.Contains(_0x795816b2) && this._0xc360a83e(_0xadfd141c))
                    return _0xadfd141c;
            }

        return null;
    }

    private Touch? _0x82e37bef()
    {
        if (!_0x7aee932b.Instance._0x53ed5416)
            return null;
        foreach (Touch _0xb802a1a2 in Touch.activeTouches)
            if (_0xb802a1a2.ended)
                if (this._0xc360a83e(_0xb802a1a2))
                    return _0xb802a1a2;
        return null;
    }

    private Touch? _0x29caa87d(Bounds _0x52b4e5d2, TouchPhase _0xfd5e4e95)
    {
        if (!_0x7aee932b.Instance._0x53ed5416)
            return null;
        foreach (Touch _0x2aff6427 in Touch.activeTouches)
            if (_0x2aff6427.phase == _0xfd5e4e95)
            {
                Vector3 _0xf9e3ac99 = Camera.main.ScreenToWorldPoint(_0x2aff6427.screenPosition);
                Vector3 _0x487d92c0 = new(_0xf9e3ac99.x, _0xf9e3ac99.y, _0x52b4e5d2.center.z);
                if (_0x52b4e5d2.Contains(_0x487d92c0) && this._0xc360a83e(_0x2aff6427))
                    return _0x2aff6427;
            }

        return null;
    }

    public BoxCollider2D CameraTouchBounds;
    private bool _0xc360a83e(Touch? _0xdf90b4df)
    {
        if (!_0xdf90b4df.HasValue)
            return false;
        Vector3 _0x87ace12f = Camera.main.ScreenToWorldPoint(_0xdf90b4df.Value.screenPosition);
        Vector3 _0xc4447d84 = _0x87ace12f;
        _0xc4447d84.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xc4447d84))
            return true;
        _0xdf90b4df = null;
        return false;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0xf1e26f6f = this.gameObject.GetComponent<_0x41d45867>();
    }

    private Touch? _0xb933481c(Bounds _0x17d5e888)
    {
        if (!_0x7aee932b.Instance._0x53ed5416)
            return null;
        foreach (Touch _0x0a09dc8f in Touch.activeTouches)
            if (!_0x0a09dc8f.ended)
            {
                Vector3 _0x41e2632e = Camera.main.ScreenToWorldPoint(_0x0a09dc8f.screenPosition);
                Vector3 _0xc7e1b720 = new(_0x41e2632e.x, _0x41e2632e.y, _0x17d5e888.center.z);
                if (_0x17d5e888.Contains(_0xc7e1b720) && this._0xc360a83e(_0x0a09dc8f))
                    return _0x0a09dc8f;
            }

        return null;
    }

    private Touch? _0x76f0ece2()
    {
        if (!_0x7aee932b.Instance._0x53ed5416)
            return null;
        foreach (Touch _0xff163cc9 in Touch.activeTouches)
            if (!_0xff163cc9.ended)
                if (this._0xc360a83e(_0xff163cc9))
                    return _0xff163cc9;
        return null;
    }

    private void _0x3d088f5f(Touch? _0xa1df00d3)
    {
        if (!_0x7aee932b.Instance._0x53ed5416)
        {
            _0xa1df00d3 = null;
            return;
        }

        int _0x99801db5 = _0xa1df00d3.Value.touchId;
        _0xa1df00d3 = Touch.activeTouches.FirstOrDefault(_0xed111f5c => _0xed111f5c.touchId == _0x99801db5);
        if (!this._0xc360a83e(_0xa1df00d3.Value))
            _0xa1df00d3 = null;
    }

    private bool _0xdfd20969(Touch? _0xb611fce8, Bounds _0xbe9e58f7, TouchPhase _0xda304172)
    {
        if (!_0x7aee932b.Instance._0x53ed5416)
        {
            _0xb611fce8 = null;
            return false;
        }

        if (_0xb611fce8 != null)
            if (_0xb611fce8.Value.phase == _0xda304172)
            {
                Vector3 _0x29597f94 = Camera.main.ScreenToWorldPoint(_0xb611fce8.Value.screenPosition);
                Vector3 _0x5e1abb7a = new(_0x29597f94.x, _0x29597f94.y, _0xbe9e58f7.center.z);
                if (_0xbe9e58f7.Contains(_0x5e1abb7a) && this._0xc360a83e(_0xb611fce8.Value))
                    return true;
            }

        return false;
    }

    private static _0x41d45867 _0xf1e26f6f;
}