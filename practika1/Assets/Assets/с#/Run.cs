using UnityEngine;

public class Run : MonoBehaviour
{
    private bool isMoving = false;
    private Vector3 target;
    private float speed = 20f;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SetTargetPosition();
        }
        if (isMoving)
        {
            Move();
        }
        if (Input.GetMouseButtonUp(0))
        {
            isMoving = false;
        }
        
    }

    private void SetTargetPosition()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.z = transform.position.z;
        isMoving = true;
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position == target)
        {
            isMoving = false;

        }
    }
}
