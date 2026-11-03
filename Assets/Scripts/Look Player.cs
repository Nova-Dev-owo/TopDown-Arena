using Unity.VisualScripting;
using UnityEngine;

public class SmoothLookAtMouse : MonoBehaviour
{

    public float rotationSpeed = 10f;
    public float angleOffset = -90f;
    private Camera mainCamera;

    public GameObject bullet;
    public Transform bulletTransform;
    public bool canFire;
    private float timer;
    public float SetDefaultTime;
    
    void Start()
    {
        
        mainCamera = Camera.main;
    }

    void Update()
    {
        RotateTowardsMouse();
    }

    void RotateTowardsMouse()
    {

        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        Vector2 direction = (mousePosition - transform.position);

        float targetAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + angleOffset;

        Quaternion targetRotation = Quaternion.Euler(0f, 0f, targetAngle);


        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        if (!canFire)
        {
            timer += Time.deltaTime;
            if (timer > SetDefaultTime)
            {
                canFire = true;
                timer = 0;
            }
        }   
        if (Input.GetKey(KeyCode.E) && canFire)
        {
                canFire = false;
                Instantiate(bullet, bulletTransform.position, Quaternion.identity);
        }
        
    }
}