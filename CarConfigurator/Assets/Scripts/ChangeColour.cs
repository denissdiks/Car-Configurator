using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    public Renderer carRenderer;

    [SerializeField]
    private Color newColor;

    public void SetColor()
    {
        carRenderer.material.color = newColor;
    }
}
