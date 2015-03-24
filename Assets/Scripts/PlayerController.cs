 using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float speed;
	public float jumpHeight;
	public Transform Top;
	public Transform Bot;
	public Transform Left;
	public Transform Right;

	RaycastHit2D hit;
	LayerMask layerMask = 1 << 8;

	void Update()
	{
//		GetComponent<Rigidbody2D>().velocity = new Vector2 (0, GetComponent<Rigidbody2D>().velocity.y);
	}

	void FixedUpdate()
	{
		//Get Input And Check if Against a wall

		Vector2 top = Top.transform.position;
		Vector2 bot = Bot.transform.position;
		float move = 0;


//		Slowdown ();

		if(!Physics2D.Raycast (top, transform.right, .5f, layerMask) && !Physics2D.Raycast (bot, transform.right, .5f, layerMask))
		{
			if(Input.GetKey (KeyCode.D))
			{
				move = 1;
			}
		}

		if(!Physics2D.Raycast (top, -transform.right, .5f, layerMask) && !Physics2D.Raycast (bot, -transform.right, .5f,layerMask))
		{
			if(Input.GetKey (KeyCode.A))
			{
				move = -1;
			}
		}

//		GetComponent<Rigidbody2D>().velocity = new Vector2 (0, GetComponent<Rigidbody2D>().velocity.y);

//		gameObject.GetComponent<Rigidbody2D>().AddForce (new Vector2(move * speed * Time.deltaTime * 100, 0));

		GetComponent<Rigidbody2D> ().velocity = new Vector2 (move * speed * Time.deltaTime, GetComponent<Rigidbody2D> ().velocity.y);

		if(Input.GetKeyDown (KeyCode.Space))
		{
			if(Physics2D.Raycast (Left.position, -Vector2.up, .1f, layerMask) || Physics2D.Raycast (Right.position, -Vector2.up, .1f, layerMask) || Physics2D.Raycast (transform.position, -Vector2.up, .6f, layerMask) )
			{
				GetComponent<Rigidbody2D>().AddForce (new Vector2(0,1) * jumpHeight);
			}
		}
	}
//	void Slowdown()
//	{
//		rigidbody2D.velocity = new Vector3 (rigidbody2D.velocity.x * .6f, rigidbody2D.velocity.y);
//	}
}