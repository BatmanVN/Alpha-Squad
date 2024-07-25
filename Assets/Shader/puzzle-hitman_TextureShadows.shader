Shader "puzzle-hitman/TextureShadows" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
		[Toggle(CSC)] _csc ("Custom shadow color?", Float) = 0
		_CustomShadowColor ("Custom shadow color", Vector) = (0,0,0,0)
		[Toggle(ONE_SIDE)] _os ("Only front shadows", Float) = 1
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
	Fallback "VertexLit"
}