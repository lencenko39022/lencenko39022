using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x89d8d941 : MonoBehaviour
{
    private TMP_Text _0x79c60d08;
    private void _0x390a9cbe()
    {
        if (this._0x3134c85a.canvasRenderer.GetColor() != this._0x79c60d08.canvasRenderer.GetColor())
            this._0x79c60d08.canvasRenderer.SetColor(this._0x3134c85a.canvasRenderer.GetColor());
    }

    private Image _0x3134c85a;
    private void Update()
    {
        this._0x390a9cbe();
    }
}