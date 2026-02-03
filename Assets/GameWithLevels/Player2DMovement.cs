using UnityEngine;

public class Player2DMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    void Update()
    {
        float x =  Input.GetAxis("Horizontal");
        transform.position += new Vector3(x,0,0) * (moveSpeed * Time.deltaTime);
    }
}
