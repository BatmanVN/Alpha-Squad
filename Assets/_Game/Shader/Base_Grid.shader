Shader "Base/Grid" {
	Properties {
		_LineColor ("Line Color", Vector) = (1,1,1,1)
		_CellColor ("Cell Color", Vector) = (1,1,1,0)
		_Width ("Line Width", Range(0.0001, 0.5)) = 0.035
		_Sharpness ("Line Sharpness", Range(0, 0.99)) = 0.2
		_Size ("Cell Size", Float) = 1
		_SphereMaskRadius ("Sphere Mask Radius", Float) = 0
		_SphereMaskSoftness ("Sphere Mask Softness", Float) = 0
		_TopFalloff ("Top Falloff", Range(0, 1)) = 0
		_TopFalloffOffset ("Top Falloff Offset", Range(0, 0.5)) = 0
		_BottomFalloff ("Bottom Falloff", Range(0, 1)) = 0
		_BottomFalloffOffset ("Bottom Falloff Offset", Range(0, 0.5)) = 0
		_SideFalloff ("Side Falloff", Range(0, 1)) = 0
		_SideFalloffOffset ("Side Falloff Offset", Range(0, 0.5)) = 0
		_MinAlphaMultiplier ("Min Alpha Multiplier", Range(0, 1)) = 1
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
}