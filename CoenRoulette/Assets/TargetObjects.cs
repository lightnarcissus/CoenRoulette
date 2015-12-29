using UnityEngine;
using System.Collections;

public class TargetObjects : MonoBehaviour {

    public GameObject camObj;
    private Ray ray;
    public LayerMask targetLayer = 9;
    private RaycastHit hit;
    public int number = 0; // 1 for Player 1, 3 for Player 2
	// Use this for initialization
	void Start () {

        

    }

    // Update is called once per frame
    void Update () {
        // Debug.DrawLine(ray);
        Debug.DrawRay(ray.origin, ray.direction * 1000f, Color.red);

        if (Input.GetMouseButtonDown(0))
        {
            ray = camObj.GetComponent<Camera>().ScreenPointToRay(new Vector3(Screen.width / 4f *number,  Screen.height / 2f, 0f));
            

            //if (Physics.Raycast(ray,out hit,100f,targetLayer.value))
            if (Physics.SphereCast(ray, 0.8f,out hit, 100f, targetLayer.value))
            {
                Debug.DrawLine(transform.position, hit.collider.transform.position, Color.red);
                Debug.Log(hit.collider.gameObject);
                Destroy(hit.collider.gameObject);
                Debug.Log("hi");
            }
        }
      
    }

    void OnMouseDown()
    {

    }
}
