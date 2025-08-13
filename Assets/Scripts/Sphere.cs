using UnityEngine;

public class Sphere : Shape
{
    protected override void Start()
    {
        shapeName = "Sphere";
        shapeColor = Color.red;
        base.Start();
    }

    public override void DisplayText()
    {
        Debug.Log("This is a round " + shapeName + ". It is an intense " + shapeColor + ".");
    }
}
