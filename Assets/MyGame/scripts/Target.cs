using UnityEngine;

public class Target : MonoBehaviour
{
    public int secToDestroy;

    // Start is called before the first frame update
    void Start()
    {
        //secToDestroy = 2;
        //Destroy(gameObject, secToDestroy);    
    }

    private void OnMouseDown()
    {
        Debug.Log("Mouse Down");
        Destroy(gameObject);
    }

    
}
