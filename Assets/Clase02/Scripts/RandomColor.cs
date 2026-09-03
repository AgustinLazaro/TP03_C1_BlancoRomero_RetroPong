using UnityEngine;

public class RandomColor : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite;
    [SerializeField] private KeyCode ChangeColor = KeyCode.R;
    
    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKeyUp(ChangeColor))
        {
            float r = Random.value;
            float g = Random.value;
            float b = Random.value;

            sprite.color = new Color(r, g, b);
        }
    }
}
