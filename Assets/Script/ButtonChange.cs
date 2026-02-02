using UnityEngine;

public class ButtonChange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public void ColourChange()
    {
        spriteRenderer.color = Random.ColorHSV();
    }
}
