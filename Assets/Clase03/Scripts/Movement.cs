using UnityEngine;

public class Movement : MonoBehaviour

{
    [Header("Config Movement")]
    [SerializeField] private KeyCode MoveUp = KeyCode.W;
    [SerializeField] private KeyCode MoveLeft = KeyCode.A;
    [SerializeField] private KeyCode MoveDown = KeyCode.S;
    [SerializeField] private KeyCode MoveRight = KeyCode.D;

    [Header("Config Speed")]
    public float moveSpeed = 5f;

    private void Update()
    {
        if (Input.GetKey(MoveUp))
        {
            transform.position += new Vector3(0, moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(MoveRight))
        {
            transform.position += new Vector3(moveSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(MoveDown))
        {
            transform.position += new Vector3(0, -moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(MoveLeft))
        {
            transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0);
        }
    }
}
