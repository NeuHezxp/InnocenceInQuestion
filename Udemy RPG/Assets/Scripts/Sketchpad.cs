using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketchpad : MonoBehaviour
{
    public RectTransform drawingArea; // Assign the RectTransform of your sketchpad UI
    public LineRenderer linePrefab;
    private LineRenderer currentLine;

    void Update()
    {
        Draw();
    }

    void Draw()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreateLine();
        }
        if (Input.GetMouseButton(0) && currentLine != null)
        {
            Vector2 localPoint;
            // Convert the screen point to local canvas space
            if (RectTransformUtility.ScreenPointToLocalPointInRectangle(drawingArea, Input.mousePosition, null, out localPoint))
            {
                currentLine.positionCount++;
                currentLine.SetPosition(currentLine.positionCount - 1, localPoint);
            }
        }
    }

    void CreateLine()
    {
        currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity);
        currentLine.positionCount = 1;
    }
}

