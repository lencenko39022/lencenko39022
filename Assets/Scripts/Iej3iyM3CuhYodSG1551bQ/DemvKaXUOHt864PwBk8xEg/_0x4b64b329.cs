using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x4b64b329 : MonoBehaviour
{
    private Vector3 _0xcc41111d { get; set; }

    private float _0x46b675d1 = 1;
    private Vector3 _0xd68fe6b1 { get; set; }
    private Vector3 _0xce29456e { get; set; }

    private void Awake()
    {
        this._0xbda9e764 = this.GetComponent<Camera>();
        _0x0359a9b6 = this;
        this._0x94763d8e();
    }

    public enum _0x87400027
    {
        Landscape,
        Portrait
    }

    private Color _0xb5845f31 = Color.white;
    private Vector3 _0xb907d73d { get; set; }
    private Vector3 _0x47337272 { get; set; }
    //public bool executeInUpdate;
    private float _0xbeb8f57a { get; set; }

    private _0x87400027 _0x9b672c84 = _0x87400027.Portrait;
    private Vector3 _0x12eaeb61 { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0xb5845f31;
        Matrix4x4 _0x2cf6035e = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xbda9e764.orthographic)
        {
            float _0x05408f35 = this._0xbda9e764.farClipPlane - this._0xbda9e764.nearClipPlane;
            float _0xf315d362 = (this._0xbda9e764.farClipPlane + this._0xbda9e764.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0xf315d362), new Vector3(this._0xbda9e764.orthographicSize * 2 * this._0xbda9e764.aspect, this._0xbda9e764.orthographicSize * 2, _0x05408f35));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xbda9e764.fieldOfView, this._0xbda9e764.farClipPlane, this._0xbda9e764.nearClipPlane, this._0xbda9e764.aspect);
        }

        Gizmos.matrix = _0x2cf6035e;
    }

    private void _0x94763d8e()
    {
        float _0xe6bbd05a, _0xf2df9cb3, _0xe9b78729, _0xf666694b;
        if (this._0x9b672c84 == _0x87400027.Landscape)
            this._0xbda9e764.orthographicSize = 1f / this._0xbda9e764.aspect * this._0x46b675d1 / 2f;
        else
            this._0xbda9e764.orthographicSize = this._0x46b675d1 / 2f;
        this._0xde61b006 = 2f * this._0xbda9e764.orthographicSize;
        this._0xbeb8f57a = this._0xde61b006 * this._0xbda9e764.aspect;
        float _0x71cbe119 = this._0xbda9e764.transform.position.x;
        float _0x71f6d037 = this._0xbda9e764.transform.position.y;
        _0xe6bbd05a = _0x71cbe119 - this._0xbeb8f57a / 2;
        _0xf2df9cb3 = _0x71cbe119 + this._0xbeb8f57a / 2;
        _0xe9b78729 = _0x71f6d037 + this._0xde61b006 / 2;
        _0xf666694b = _0x71f6d037 - this._0xde61b006 / 2;
        this._0xb907d73d = new Vector3(_0xe6bbd05a, _0xf666694b, 0);
        this._0xd68fe6b1 = new Vector3(_0x71cbe119, _0xf666694b, 0);
        this._0xcc41111d = new Vector3(_0xf2df9cb3, _0xf666694b, 0);
        this._0xeffecbf0 = new Vector3(_0xe6bbd05a, _0x71f6d037, 0);
        this._0xce29456e = new Vector3(_0x71cbe119, _0x71f6d037, 0);
        this._0x47337272 = new Vector3(_0xf2df9cb3, _0x71f6d037, 0);
        this._0xbfd958d3 = new Vector3(_0xe6bbd05a, _0xe9b78729, 0);
        this._0x2c492fbe = new Vector3(_0x71cbe119, _0xe9b78729, 0);
        this._0x12eaeb61 = new Vector3(_0xf2df9cb3, _0xe9b78729, 0);
    }

    private Vector3 _0xbfd958d3 { get; set; }

    private new Camera _0xbda9e764;
    private Vector3 _0xeffecbf0 { get; set; }

    private static _0x4b64b329 _0x0359a9b6;
    private float _0xde61b006 { get; set; }
    private Vector3 _0x2c492fbe { get; set; }
}