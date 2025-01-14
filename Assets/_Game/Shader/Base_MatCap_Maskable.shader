Shader "Base/MatCap_Maskable" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
		[Toggle(USE_AMBIENCE)] _UseAmbience ("Affected by ambience", Float) = 0
		_MatCap ("MatCap (RGB)", 2D) = "white" {}
		_ShadowTint ("Shadow Tint", Vector) = (1,1,1,1)
		_MatCapStrength ("MatCap Strength", Range(0, 1)) = 0.4
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