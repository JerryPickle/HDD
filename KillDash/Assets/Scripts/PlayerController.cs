using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] public float moveSpeed = 5f;
    [SerializeField] public Transform movePoint;

    bool up = false;
    bool down = false;
    bool right = false;
    bool left = false;
    int last = 0;
    Vector3 current;
    Vector3 previous;

    public Animator anim;
    public Rigidbody2D rd;

    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        previous = transform.position;
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
        current = transform.position;

        if(((current.magnitude - previous.magnitude) / Time.deltaTime) == 0)
        {
            if (last == 1)
            {

            }
            else if (last == 2)
            {

            }
            else if (last == 3)
            {
                anim.Play("Idle_Back_Animation");
            }
            else if (last == 4)
            {
                anim.Play("Idle_Animation");
            }
        }

        if (Vector3.Distance(transform.position, movePoint.position) <= .05f)
        {


            if (Input.GetAxisRaw("Horizontal") == 1f)
            {
                movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                right = true;
                last = 1;

            } else if(Input.GetAxisRaw("Horizontal") == -1f)
            {
                movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                left = true;
                last = 2;
            }
            else if (Input.GetAxisRaw("Vertical") == 1f)
            {
                movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                up = true;
                //anim.Play("Walk_Backward_Animation");
                last = 3;

            } else if (Input.GetAxisRaw("Vertical") == -1f)
            {
                movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                down = true;
                //anim.Play("Walk_Forward_Animation");
                last = 4;
            }
        }
        else
        {
            if(up == true)
            {
                anim.Play("Walk_Backward_Animation");

            }else if (down == true)
            {
                anim.Play("Walk_Forward_Animation");
            }else if (right == true)
            {

            }else if (left == true)
            {

            }


            up = false;
            down = false;
            right = false;
            left = false;
        }


    }
}
