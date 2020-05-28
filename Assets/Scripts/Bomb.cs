using System.Collections;
using UnityEngine;

public class Bomb : MonoBehaviour
{

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.transform.name.CompareTo("Box") == 0) PlayerMovement.target++;
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.transform.name.CompareTo("Box") == 0) PlayerMovement.target--;
	}
}