Shader "Custom/UV_Offset" {
	Properties {
		_MainTex ("Texture", 2D) = "white" {}
		_TimeMultiplier ("Time multipler", Float) = 1
		_TimeMultiplier1 ("Time multipler1", Float) = 1
		[Toggle(MOVE_X)] _MoveX ("Move UV.x", Float) = 0
		[Toggle(MOVE_Y)] _MoveY ("Move UV.y", Float) = 0
		_OffsetX ("Offset UV.x", Float) = 0
		_OffsetY ("Offset UV.y", Float) = 0
		_ClipA ("Clip alpha", Range(0, 1)) = 0.1
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