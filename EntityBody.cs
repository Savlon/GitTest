using UnityEngine;
using System.Collections;

public class EntityBody : BaseEntity
{

	public override void FixedUpdate ()
	{
		_rigidbody2D.velocity = _velocity * 10 * Time.deltaTime;
	}
}