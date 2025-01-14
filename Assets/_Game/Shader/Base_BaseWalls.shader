Shader "Base/BaseWalls" {
	Properties {
		_MainTex ("Main Tex", 2D) = "white" {}
		[Toggle(USE_AMBIENCE)] _UseAmbience ("Affected by ambience", Float) = 0
		[Toggle(CSC)] _csc ("Custom shadow color?", Float) = 0
		_CustomShadowColor ("Custom shadow color", Vector) = (0,0,0,0)
		[Toggle(ONE_SIDE)] _os ("Only front shadows", Float) = 1
		[Toggle(TINT_BACK)] _TintBack ("Tint Back Walls", Float) = 0
		_BackFaceTint ("Back Wall Tint", Vector) = (0,0,0,0)
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