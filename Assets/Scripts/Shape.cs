using TMPro;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public string shapeName { get; set; }
    public Color shapeColor { get; set; }
    public string colorName { get; set; }
    public TMP_Text text { get; set; }
    private Renderer rend;

    protected virtual void Start()
    {
        text = GameObject.Find("Text").GetComponent<TMP_Text>();
        rend = GetComponent<Renderer>();
        if (rend != null)
        {
            rend.material.color = shapeColor;
        }
    }

    private void OnMouseDown()
    {
        DisplayText();
    }

    public abstract void DisplayText();
}
