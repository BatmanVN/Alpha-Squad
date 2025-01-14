Shader "Custom/EmblemHologram" {
	Properties {
		_Alpha ("Alpha", Range(0, 1)) = 1
		_Direction ("Direction", Vector) = (0,1,0,0)
		[PerRendererData] _MainTex ("MainTexture", 2D) = "white" {}
		_ScanTiling ("Scan Tiling", Range(0.01, 100)) = 0.05
		_ScanSpeed ("Scan Speed", Range(-2, 2)) = 1
		_Samples ("Samples", Float) = 8
		_Offset ("Offset", Range(-0.001, 0.001)) = 0
		_Lerp ("Effect Strength", Range(0, 1)) = 0.5
		_LOD ("LOD", Float) = 1
		[Toggle(REPLACE_COLOR)] _ReplaceColor ("Replace Color", Float) = 0
		_ColorToReplace ("Color to Replace", Vector) = (0,0,0,0)
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