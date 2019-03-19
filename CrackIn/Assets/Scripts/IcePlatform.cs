using UnityEngine;

public class IcePlatform : MonoBehaviour {
   private CircleCollider2D myCollider;
   private SpriteRenderer myLayer;

	void Start () {
        myCollider = GetComponent<CircleCollider2D>();
        myLayer = GetComponent<SpriteRenderer>();

        setColliderInactive();
        setLayerActive();
	}
	
   public void setColliderActive()
    {
        myCollider.enabled = true;
    }

   public void setColliderInactive()
    {
        myCollider.enabled = false;
    }

   public void setLayerActive()
    {
        myLayer.enabled = true;
    }

public void setLayerInactive()
    {
        myLayer.enabled = false;
    }
}
