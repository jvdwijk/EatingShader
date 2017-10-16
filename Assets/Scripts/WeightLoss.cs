using UnityEngine;

public class WeightLoss : MonoBehaviour
{
	private Material _material;
	private float _size;

	private void Start()
	{
		_material = gameObject.GetComponent<Renderer>().material;
	}
	
	void OnTriggerStay (Collider other)
	{
		if (other.CompareTag("Player")) return;
		_size = _size - 0.01f;
		print(_material.GetFloat("_Amount"));
		_material.SetFloat("_Amount", _size);
	    
	}
}