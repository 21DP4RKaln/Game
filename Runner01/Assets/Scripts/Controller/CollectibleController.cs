using UnityEngine;
using System.Collections;

public class CollectibleController : MonoBehaviour {


	void Update () {
		transform.Rotate(new Vector3(30, 30, 45) * Time.deltaTime);
	}
}
