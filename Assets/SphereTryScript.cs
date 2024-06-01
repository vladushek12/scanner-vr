using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereTryScript : MonoBehaviour
{
	[Header("speed")]
	public float speed;

	[Header("destroy time")]
	public float delay_destoy_time;

    // Start is called before the first frame update
    void Start()
    {
        destroy_object();
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 vectorMash = this.transform.localScale;
        // float growing = this.speed * Time.deltaTime;
        // this.transform.localScale = new Vector3(vectorMash.x + growing, vectorMash.y + growing, vectorMash.z + growing);
    }

    private void destroy_object() {
        Destroy(this.gameObject, delay_destoy_time);
    }
}
