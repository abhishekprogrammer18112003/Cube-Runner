using UnityEngine;

public class playerscript : MonoBehaviour
{
    public new Rigidbody rigidbody;
    public float force = 1000f;
    public float speed = 10f;
    public float minx;
    public float maxx;


    public bool isleftbtntrigger;
    public bool isrightbtntrigger;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerpos = transform.position;
        if (playerpos.x < minx)
        {
            playerpos.x = minx;
        }
        if (playerpos.x > maxx)
        {
            playerpos.x = maxx;
        }
        transform.position = playerpos;


        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + -new Vector3(speed * Time.deltaTime, 0, 0);
        }

        if (isleftbtntrigger == true)
        {
            leftbtnpressed();

        }
        if (isrightbtntrigger)
        {
            rightbtnpressed();

        }


    }


    void FixedUpdate()
    {
        rigidbody.AddForce(0, 0, force * Time.deltaTime);
    }

    public void leftbtnpressed()
    {
        transform.position = transform.position + -new Vector3(speed * Time.deltaTime, 0, 0);
        print("left btn pressed");
    }
    public void rightbtnpressed()
    {
        transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        print("rightbtnpressed");
    }

    public void leftpointerdown()
    {
        isleftbtntrigger = true;
    }
    public void leftpointerup()
    {
        isleftbtntrigger = false;
    }
    public void rightpointerdown()
    {
        isrightbtntrigger = true;
    }
    public void rightpointerup()
    {
        isrightbtntrigger = false;
    }

}
