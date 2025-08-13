using UnityEngine;

public class Cube : Shape
{
    protected override void Start()
    {
        shapeName = "Cube";
        shapeColor = Color.blue;
        colorName = "blue";
        base.Start();
    }

    public override void DisplayText()
    {
        string textToDisplay = "This is a " + shapeName + ". It is a normal, boring " + colorName + ".";
        Debug.Log(textToDisplay);
        text.text = textToDisplay;
    }
}
