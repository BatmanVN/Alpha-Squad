Shader "PolygonArsenal/PolyRimLightTransparent" {
	Properties {
		_InnerColor ("Inner Color", Vector) = (1,1,1,1)
		_RimColor ("Rim Color", Vector) = (0.26,0.19,0.16,0)
		_RimWidth ("Rim Width", Range(0.2, 20)) = 3
		_RimGlow ("Rim Glow Multiplier", Range(0, 9)) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = 1;
		}
		ENDCG
	}
	Fallback "Diffuse"
}