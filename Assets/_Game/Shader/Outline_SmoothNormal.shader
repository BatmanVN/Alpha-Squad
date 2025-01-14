Shader "Outline/SmoothNormal" {
	Properties {
		[Toggle(WORLD_OUTLINE)] _WorldOutline ("World Outline", Float) = 0
		_MainTex ("Texture", 2D) = "white" {}
		_OutlineColor ("Outline Color", Vector) = (0,0,0,1)
		_OutlineWidth ("Value", Float) = 1
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