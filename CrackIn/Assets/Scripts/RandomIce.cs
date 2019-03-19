using UnityEngine;

public class RandomIce : MonoBehaviour
{

    private GameObject iceplatform;
    private IcePlatform myPlatform;
    public GameObject[] platforms;
    float myTimer = 0;
    float deltaTime = 0;

    private void Update()
    {
        myTimer += Time.deltaTime;

        if (myTimer > 5f)
        {
            Random();

            myTimer = 0;
        }
    }

    private const int RANDOMSEED = 123;
    //public static System.Random rnd = new System.Random(RANDOMSEED);
    public static System.Random rnd = new System.Random();

    int getRandomNumber()
    {
        return rnd.Next(54);
    }

    void Random()
    {
        int x = getRandomNumber();

        if (!platforms[x].gameObject.GetComponent<CircleCollider2D>().enabled)
        {
            myPlatform = platforms[x].gameObject.GetComponent<IcePlatform>();
            myPlatform.setLayerInactive();
            myPlatform.setColliderActive();
        }
    } 
}
