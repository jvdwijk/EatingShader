Shader "Custom/BMI" {
	Properties {
      _MainTex ("Texture", 2D) = "white" {}
      _Amount ("Extrusion Amount", Range(-1,1)) = 0.5
    }
    SubShader {
      CGPROGRAM
      #pragma surface Surf Lambert vertex:Vert
      struct Input {
          float2 mainTex;
      };
      float _Amount;
      void Vert (inout appdata_full v) {
          v.vertex.xyz += v.normal * _Amount;
      }
      sampler2D _MainTex;
      void Surf (Input IN, inout SurfaceOutput output) {
          output.Albedo = tex2D (_MainTex, IN.mainTex).rgb;
      }
      ENDCG
    } 
    Fallback "Diffuse"
  }
