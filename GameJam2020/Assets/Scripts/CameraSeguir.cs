using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSeguir : MonoBehaviour
{
    // Start is called before the first frame update
    	public GameObject target;
	public float moveSpeed;
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	if (target != null){
		transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime * moveSpeed);
	}     
    }
}
