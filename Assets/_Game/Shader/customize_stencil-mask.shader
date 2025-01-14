Shader "customize/stencil-mask" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
		[HideInInspector] _Stencil ("Stencil", Float) = 0
		[HideInInspector] _StencilOp ("StencilOP", Float) = 0
		[HideInInspector] _StencilComp ("StencilComp", Float) = 0
		[HideInInspector] _StencilReadMask ("StencilReadMask", Float) = 0
		[HideInInspector] _StencilWriteMask ("StencilWriteMask", Float) = 0
		[HideInInspector] _ColorMask ("ColorMask", Float) = 15
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