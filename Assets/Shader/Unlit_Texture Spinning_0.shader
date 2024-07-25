Shader "Unlit/Texture Spinning" {
	Properties {
		_MainTex ("Texture", 2D) = "white" {}
		_UVMinX ("Min Uv X", Float) = 0
		_UVMaxX ("Max Uv X", Float) = 1
		_UVMinY ("Min Uv Y", Float) = 0
		_UVMaxY ("Max Uv Y", Float) = 1
		_TimeMultiplier ("TImeMultiplier", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
}