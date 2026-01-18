using UnityEngine;
using System.Collections;

public class Blinking : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public float blinkTime = 0.2f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(Blink());
    }

    IEnumerator Blink()
    {
        while (true)
        {
            spriteRenderer.enabled = !spriteRenderer.enabled;
            yield return new WaitForSeconds(blinkTime);
        }
    }
}
