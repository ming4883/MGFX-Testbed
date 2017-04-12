using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MyMesh : MonoBehaviour {

	// Use this for initialization
	void Start () {
		MeshFilter _meshFilter = gameObject.GetComponent<MeshFilter>();
		if (null != _meshFilter)
		{
			_meshFilter.mesh = CreateMesh(2, 2);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	Mesh CreateMesh(float _w, float _h)
	{
		Mesh _mesh = new Mesh();
		_mesh.name = "ProceduralMesh";

		// position
		Vector3[] _pos = new Vector3[4];
		_pos[0] = new Vector3(0, 0, 0);
		_pos[1] = new Vector3(_w, 0, 0);
		_pos[2] = new Vector3(0, _h, 0);
		_pos[3] = new Vector3(_w, _h, 0);

		_mesh.vertices = _pos;

		// normal
		Vector3[] _nor = new Vector3[4];
		_nor[0] = -Vector3.forward;
		_nor[1] = -Vector3.forward;
		_nor[2] = -Vector3.forward;
		_nor[3] = -Vector3.forward;

		_mesh.normals = _nor;

		// texcoord
		Vector2[] _uv12 = new Vector2[4];
		_uv12[0] = new Vector2(0, 0);
		_uv12[1] = new Vector2(1, 0);
		_uv12[2] = new Vector2(0, 1);
		_uv12[3] = new Vector2(1, 1);

		_mesh.uv = _uv12;
		//_mesh.uv2 = _uv12;

		float _t = 4;
		Vector2[] _uv3 = new Vector2[4];
		_uv3[0] = new Vector2( 0, 0);
		_uv3[1] = new Vector2(_t, 0);
		_uv3[2] = new Vector2( 0, _t);
		_uv3[3] = new Vector2(_t, _t);

		_mesh.uv3 = _uv3;

		// color
		Color[] _clr = new Color[4];
		_clr[0] = new Color(1, 1, 1, 0);
		_clr[1] = new Color(1, 1, 1, 1);
		_clr[2] = new Color(1, 1, 1, 0);
		_clr[3] = new Color(1, 1, 1, 1);

		_mesh.colors = _clr;

		// triangle
		int[] _idx = new int[6];
		_idx[0] = 0; _idx[1] = 2; _idx[2] = 1;
		_idx[3] = 2; _idx[4] = 3; _idx[5] = 1;

		_mesh.triangles = _idx;

		return _mesh;

	}
}
