Shader "Unlit/Running_Waterfal" {
	Properties {
		_TopColor ("Top Color", Vector) = (1,1,1,1)
		_BottomColor ("Bottom Color", Vector) = (0,0,0,0)
		_FoamColor ("Foam Color", Vector) = (1,1,1,1)
		_MainTex ("Water Texture", 2D) = "white" {}
		_WaterAlpha ("Water Transparency", Float) = 1
		_MainTex2 ("Mask", 2D) = "white" {}
		_MainTex3 ("Hide Mask", 2D) = "white" {}
		_Color ("Ripple Color", Vector) = (1,1,1,1)
		_ScrollSpeed ("Water speed", Float) = 1
		_Bool ("Water = 0, Ripples = 1", Float) = 0
		_BubbleHeight ("Bubble Height", Range(0, 1)) = 0.83
		_BubbleFall ("Bubble Fall Height", Float) = 1
		_OneMinus ("One Minus", Vector) = (0,0,0,0)
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
}