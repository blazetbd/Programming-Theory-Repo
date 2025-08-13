using UnityEngine;

public class Cylinder : Shape
{
    protected override void Start()
    {
        shapeName = "Cylinder";
        shapeColor = Color.yellow;
        colorName = "yellow";
        base.Start();
    }

    public override void DisplayText()
    {
        string textToDisplay = "This is a " + shapeName + ". It is a bright " + colorName + ".";
        Debug.Log(textToDisplay);
        text.text = textToDisplay;
    }
}
