Shader "FlipMan/outlineShader_Maskable" {
	Properties {
		_Color ("Color", Vector) = (0.5,0.65,1,1)
		_MainTex ("Main Texture", 2D) = "white" {}
		[HDR] _AmbientColor ("Ambient  Color", Vector) = (0.4,0.4,0.4,1)
		_SpecularColor ("Specular Color", Vector) = (0.9,0.9,0.9,1)
		_Glossiness ("Glossiness", Range(0, 500)) = 32
		_RimColor ("Rim Color", Vector) = (1,1,1,1)
		_RimAmount ("Rim Amount", Range(0, 1)) = 0.716
		_RimThreshold ("Rim threshold", Range(0, 1)) = 0.1
		_DarkRimColor ("Dark Rim Color", Vector) = (1,1,1,1)
		_DarkRimAmount ("Dark Rim Amount", Range(0, 1)) = 0.716
		_DarkRimThreshold ("Dark Rim threshold", Range(0, 1)) = 0.1
		_ThirdRimColor ("Third Rim Color", Vector) = (1,1,1,1)
		_ThirdRimAmount ("Third Rim Amount", Range(0, 1)) = 0.716
		_ThirdRimThreshold ("Third Rim threshold", Range(0, 1)) = 0.1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		fixed4 _Color;
		struct Input
		{
			float2 uv_MainTex;
		};
		
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
	Fallback "Unlit/Texture DropShadow"
}