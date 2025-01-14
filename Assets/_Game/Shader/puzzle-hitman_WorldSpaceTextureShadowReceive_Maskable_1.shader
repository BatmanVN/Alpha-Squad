Shader "puzzle-hitman/WorldSpaceTextureShadowReceive_Maskable" {
	Properties {
		_Color ("Main Color", Vector) = (1,1,1,1)
		_WallColorShift ("Wall color shift", Vector) = (1,1,1,1)
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_WallTex ("Wall (RGB)", 2D) = "white" {}
		[Toggle(CSC)] _csc ("Custom shadow color?", Float) = 0
		_CustomShadowColor ("Custom shadow color", Vector) = (0,0,0,1)
		[Toggle(ONE_SIDE)] _os ("Only front shadows", Float) = 1
		[Toggle(WALL_SHADOWS)] _cwsc ("Custom Wall Shadows", Float) = 1
		_CustomWallShadowColor ("Custom Wall Shadow Color", Vector) = (0,0,0,1)
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
	Fallback "VertexLit"
}