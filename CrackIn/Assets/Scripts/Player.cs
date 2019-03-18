using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    private Rigidbody2D rb2d; //Store a reference to the Rigidbody2D component required to use 2D Physics.
    private const string AXISHORIZONTAL = "Horizontal";

    //configruation parameters
    public float moveSpeed = 5.0f;
    public float xMin = 3.0f, xMax = 5.0f;
    public float posZ = 1;
    float timer = 0;

    public Text collected;

    private const string TAGPLAYER = "Player";
    private const string TAGGROUND = "Water";

    public SceneLoader sceneLoader;
    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); //Get and store a reference to the Rigidbody2D component so that we can access it.
    }
    // Update is called once per frame
    void Update()
    {
        Move();
        timer += Time.deltaTime;
    }

    private void Move()
    {
        var deltaX = Input.GetAxis(AXISHORIZONTAL) * Time.deltaTime * moveSpeed;
        var newPosX = Mathf.Clamp(transform.position.x + deltaX, xMin, xMax);
        posZ = posZ * timer;

        transform.position = new Vector3(newPosX, transform.position.y, timer);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Water" && gameObject.tag == "Player")
        {
           // Debug.Log(" hallo " + collision.tag + " gameObject " + gameObject.tag);

           sceneLoader.LoadGameOverScene();

            Debug.Log("gameover");
        }

    }
}