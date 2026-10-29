using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x7d644fc5 : MonoBehaviour
{
    private _0x0d2ffa01 _0xcb986308 = _0x0d2ffa01.Portrait;
    private Vector3 _0xbfd958d3 { get; set; }

    private float _0x06a1648a = 1;
    private static _0x7d644fc5 _0x328e68d0;
    private Color _0x0967259a = Color.white;
    private Vector3 _0xcc41111d { get; set; }

    public enum _0x0d2ffa01
    {
        Landscape,
        Portrait
    }

    private float _0xb907d73d { get; set; }
    private Vector3 _0x47337272 { get; set; }
    private Vector3 _0xd68fe6b1 { get; set; }
    private Vector3 _0xeffecbf0 { get; set; }
    private Vector3 _0x2c492fbe { get; set; }

    private new Camera _0xc6272d94;
    //public bool executeInUpdate;
    private float _0xde61b006 { get; set; }

    private void _0x86b7edd4()
    {
        float _0x39c37c89, _0xe6ea3a08, _0x31269ad5, _0x2d055e6b;
        if (this._0xcb986308 == _0x0d2ffa01.Landscape)
            this._0xc6272d94.orthographicSize = 1f / this._0xc6272d94.aspect * this._0x06a1648a / 2f;
        else
            this._0xc6272d94.orthographicSize = this._0x06a1648a / 2f;
        this._0xb907d73d = 2f * this._0xc6272d94.orthographicSize;
        this._0xde61b006 = this._0xb907d73d * this._0xc6272d94.aspect;
        float _0xfb1ffbe4 = this._0xc6272d94.transform.position.x;
        float _0x4bcf6398 = this._0xc6272d94.transform.position.y;
        _0x39c37c89 = _0xfb1ffbe4 - this._0xde61b006 / 2;
        _0xe6ea3a08 = _0xfb1ffbe4 + this._0xde61b006 / 2;
        _0x31269ad5 = _0x4bcf6398 + this._0xb907d73d / 2;
        _0x2d055e6b = _0x4bcf6398 - this._0xb907d73d / 2;
        this._0xd68fe6b1 = new Vector3(_0x39c37c89, _0x2d055e6b, 0);
        this._0xcc41111d = new Vector3(_0xfb1ffbe4, _0x2d055e6b, 0);
        this._0xeffecbf0 = new Vector3(_0xe6ea3a08, _0x2d055e6b, 0);
        this._0xce29456e = new Vector3(_0x39c37c89, _0x4bcf6398, 0);
        this._0x47337272 = new Vector3(_0xfb1ffbe4, _0x4bcf6398, 0);
        this._0xbfd958d3 = new Vector3(_0xe6ea3a08, _0x4bcf6398, 0);
        this._0x2c492fbe = new Vector3(_0x39c37c89, _0x31269ad5, 0);
        this._0x12eaeb61 = new Vector3(_0xfb1ffbe4, _0x31269ad5, 0);
        this._0xf1747815 = new Vector3(_0xe6ea3a08, _0x31269ad5, 0);
    }

    private Vector3 _0x12eaeb61 { get; set; }
    private Vector3 _0xf1747815 { get; set; }

    private void Awake()
    {
        this._0xc6272d94 = this.GetComponent<Camera>();
        _0x328e68d0 = this;
        this._0x86b7edd4();
    }

    private Vector3 _0xce29456e { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x0967259a;
        Matrix4x4 _0x5c7f27b9 = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xc6272d94.orthographic)
        {
            float _0x036bd14a = this._0xc6272d94.farClipPlane - this._0xc6272d94.nearClipPlane;
            float _0x62bfca32 = (this._0xc6272d94.farClipPlane + this._0xc6272d94.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x62bfca32), new Vector3(this._0xc6272d94.orthographicSize * 2 * this._0xc6272d94.aspect, this._0xc6272d94.orthographicSize * 2, _0x036bd14a));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xc6272d94.fieldOfView, this._0xc6272d94.farClipPlane, this._0xc6272d94.nearClipPlane, this._0xc6272d94.aspect);
        }

        Gizmos.matrix = _0x5c7f27b9;
    }
}