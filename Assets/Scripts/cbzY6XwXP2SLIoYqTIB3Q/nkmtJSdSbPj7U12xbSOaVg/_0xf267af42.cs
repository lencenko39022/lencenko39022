using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xf267af42 : MonoBehaviour
{
    private TMP_Text _0x3d702a0d;
    private Image _0xfde88266;
    private void Update()
    {
        this._0x5c3fff9e();
    }

    private void _0x5c3fff9e()
    {
        if (this._0xfde88266.canvasRenderer.GetColor() != this._0x3d702a0d.canvasRenderer.GetColor())
            this._0x3d702a0d.canvasRenderer.SetColor(this._0xfde88266.canvasRenderer.GetColor());
    }
}