Shader "FakeLight/FakeLight_BlikAddColor" {
	Properties {
		_Color ("Color", Vector) = (1,1,1,1)
		_MainTex ("Texture", 2D) = "white" {}
		_LightGradient ("Light Gradient", 2D) = "white" {}
		_BlikGradient ("Blik Gradient", 2D) = "white" {}
		_LightDirection ("Light Direction", Vector) = (1.25,1.75,1.5,1)
		_BlikDirection ("Blik Direction", Vector) = (1,1,1,1)
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