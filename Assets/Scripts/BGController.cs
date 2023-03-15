using UnityEngine;

public class BGController : MonoBehaviour
{
    public SpriteRenderer bg;

    private void Start()
    {
        float height = bg.sprite.bounds.size.y;
        float scale = CameraController.cameraHeightSize / height;
        bg.transform.localScale = new Vector3(scale, scale, 1.0f);
    }
}