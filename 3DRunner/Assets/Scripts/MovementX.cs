using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementX : MonoBehaviour
{
    [SerializeField] Vector3 movementTransform;
    [SerializeField] float sensivity = 5f;
    Vector2 readingValue;
    Vector3 movementValue;
    SwipeControl swipeControl;
    CharacterController characterController;
    [SerializeField] float speed = 3f;
    //public bool gameOver = false;


    //float facingAngle;
    //Vector2 UnitVector;

    // Start is called before the first frame update
    void Awake()
    {
        readingValue = Vector2.zero;
        swipeControl = new SwipeControl();
        characterController = GetComponent<CharacterController>();
        swipeControl.Move.MoveZ.started += MovementInputX;
        swipeControl.Move.MoveZ.performed += MovementInputX;
        swipeControl.Move.MoveZ.canceled += MovementInputX;
    }
    private void OnEnable()
    {
        swipeControl.Enable();
    }

    private void OnDisable()
    {
        swipeControl.Disable();
    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        characterController.Move(movementValue * speed * Time.deltaTime);
 
        //facingAngle += movementValue.x; 
        //UnitVector = new Vector2(Mathf.Cos(facingAngle * Mathf.Deg2Rad),  Mathf.Sin(facingAngle * Mathf.Deg2Rad));

        //RaycastHit hit;
        //Ray rayDown = new Ray(transform.position, Vector3.down);
        //if (!Physics.Raycast(rayDown, out hit, 1f))
        //{
        //    gameOver = true;
        //}
        //Debug.DrawLine(transform.position, hit.point, Color.red);

    }

    private void FixedUpdate()
    {

        //this.transform.GetComponentInChildren<Rigidbody>().AddForce(new Vector3(UnitVector.x, UnitVector.y, 0 ) * movementValue.y * 3);
    }

    void MovementInputX(InputAction.CallbackContext context)
    {
        readingValue = context.ReadValue<Vector2>();
        movementValue.x = readingValue.x / sensivity;
    }

   
}
