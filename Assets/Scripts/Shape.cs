using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public string shapeName { get; set; }
    public Color shapeColor { get; set; }

    private Renderer rend;

    protected virtual void Start()
    {
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
