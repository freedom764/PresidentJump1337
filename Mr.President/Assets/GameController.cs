using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject DoodlerPrefab;
    public GameObject Doodler;
    public Transform SpawnPosition;
    
    // Start is called before the first frame update
    void OnEnable()
    {
        Doodler = Instantiate(DoodlerPrefab, SpawnPosition.position, SpawnPosition.rotation) as GameObject;
       

    }

    // Update is called once per frame
    void Update()
    {
        MovementFunction();

    
    }

    void MovementFunction() { 
    if (Input.GetKey(KeyCode.A))
        {
            Doodler.transform.eulerAngles = new Vector2(0, 180);
            Doodler.transform.Translate(Vector2.right * 5f * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            Doodler.transform.eulerAngles = new Vector2(0, 0);
            Doodler.transform.Translate(Vector2.right * 5f * Time.deltaTime);

        }
    }
   
}
